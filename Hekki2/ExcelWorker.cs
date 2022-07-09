using Hekki2;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Hekki
{
    public class ExcelWorker
    {
        private static int count = 0;
        private static int maxKarts = SprintReg.GetMaxKarts();
        public static Application GetExcel()
        {
            Application myExcel;

            try
            {
                myExcel = (Application)Marshal2.GetActiveObject("Excel.Application");
            }
            catch (Exception)
            {
                throw new Exception("Excel не открыт");
            }

            return myExcel;
        }

        public static List<string> ReadNames(Application excel)
        {
            var keyCells = FindKeyCellByValue(excel, "Имя", null);
            List<string> names = new List<string>();

            int i = 2;
            while (keyCells[0].Cells[i].Value != null)
            {
                names.Add(keyCells[0].Cells[i].Value.ToString());
                i++;
            }

            return names;
        }

        public static void WriteNames(Application excel, List<List<Pilot>> groups, int numberRace, string keyWord)
        {
            var keyCells = FindKeyCellByValue(excel, keyWord, true, null);
            var startIndex = GetStartIndex(excel, keyCells[1].Row, keyCells[1].Column);

            foreach (var group in groups)
            {
                List<Pilot> fullGroup = new List<Pilot>(group);
                if (fullGroup.Count < 8)
                    fullGroup = AddEmptysInGroup(group);
                foreach (var pilot in fullGroup)
                {
                    if (pilot.Name == "1")
                    {
                        excel.Cells[startIndex, keyCells[1].Column] = "";
                        excel.Cells[startIndex, keyCells[1].Column - 2] = "";
                        startIndex++;
                    }
                    else
                    {
                        excel.Cells[startIndex, keyCells[1].Column] = pilot.Name;
                        excel.Cells[startIndex, keyCells[1].Column - 2] = pilot.GetNumberKartByRace(numberRace);
                        startIndex++;
                    }
                }
            }
        }

        private static int GetStartIndex(Application excel, int row, int column)
        {
            int index = row;
            while (excel.Cells[index, column].Value != null)
            {
                index++;
            }
            return index;
        }

        private static List<Pilot> AddEmptysInGroup(List<Pilot> group)
        {
            while (group.Count < 8)
            {
                group.Add(new Pilot("1"));
            }
            return group;
        }

        public static Microsoft.Office.Interop.Excel.Range FindKeyCellByValue(
            Application excel,
            string value,
            bool needEmpty,
            Range searchedRange)
        {
            if (searchedRange == null)
                searchedRange = excel.get_Range("A1", "XFD1048576");
            var finded = searchedRange.Find(value);
            var firstAdress = finded.Address;
            while (excel.Cells[finded.Row + 1, finded.Column].Value != null && needEmpty)
            {
                finded = searchedRange.FindNext(finded);
                if (firstAdress == finded.Address)
                    throw new Exception("While doing the cirle");
                firstAdress = finded.Address;
            }
            return finded;
        }

        public static List<Microsoft.Office.Interop.Excel.Range> FindKeyCellByValue(
            Application excel,
            string value,
            Range searchedRange)
        {
            if (searchedRange == null)
                searchedRange = excel.get_Range("A1", "XFD1048576");
         
            var finded = searchedRange.Find(value);
            var firstAdress = finded.Address;
            List<Range> ranges = new List<Range>();
            while (true)
            {
                ranges.Add(finded);
                finded = searchedRange.FindNext(finded);
                if (firstAdress == finded.Address)
                    return ranges;
            }
        }

        public static void CleanData(Application excel, int row)
        {
            Microsoft.Office.Interop.Excel.Range searchedRange = excel.get_Range("A1", "XFD1048576");
            var finded = searchedRange.Find("Пилоты");
            var column = finded.Column;
            int i = 0;
            do
            {

                var v1 = excel.Cells[row, column - 2];
                var v2 = excel.Cells[row + 100, column];
                var cells = excel.Range[v1, v2];
                cells.ClearContents();
                count = column;
                finded = searchedRange.FindNext(finded);
                column = finded.Column;
                i++;
            } while (i < 3);
        }

        public static void WriteUsedKarts(Application excel, List<Pilot> pilots)
        {
            var keyCells = FindKeyCellByValue(excel, "Карты", null);
            var startIndex = keyCells[0].Row + 1;
            for (int i = 0; i < pilots.Count; i++)
            {
                excel.Cells[startIndex, keyCells[0].Column] = pilots[i].GetAllNumbersKarts();
                excel.Cells[startIndex, keyCells[0].Column + 1] = pilots[i].Name;
                startIndex++;
            }
        }

        public static Dictionary<string, List<int>> ReadScores(Application excel, int pilotsCount)
        {

            var keyCells = FindKeyCellByValue(excel, "Пилоты", null);
            
            Dictionary<string, List<int>> score = new Dictionary<string, List<int>>();
            for (int j = 0; j < keyCells.Count; j++)
            {
                var startIndex = keyCells[j].Row + 1;
                for (int i = 0; i < pilotsCount && startIndex < 50; startIndex++)
                {
                    if (excel.Cells[startIndex, keyCells[j].Column].Value == null)
                    {
                        continue;
                    }
                    string key = excel.Cells[startIndex, keyCells[j].Column].Value.ToString();
                    int val = (int)excel.Cells[startIndex, keyCells[j].Column + 3].Value;
                    if (!score.ContainsKey(key))
                    {
                        score.Add(key, new List<int>());
                    }
                    score[key].Add(val);
                    i++;
                }
            }
            return score;
        }

        public static void WriteScore(Application excel, List<Pilot> pilots)
        {
            for (int i = 1; i < pilots[0].ScoresCount + 1; i++)
            {
                for (int j = 0; j < pilots.Count; j++)
                {
                    var cell = FindKeyCellByValue(excel, pilots[j].Name, false, excel.get_Range("A1", "K100"));
                    excel.Cells[cell.Row, cell.Column + i].Value = pilots[j].GetScoreByNumberRace(i - 1).ToString();
                }
            }
        }

        public static void WriteNamesInTotalBoard(Application excel, List<string> names)
        {
            var keyCells = FindKeyCellByValue(excel, "Имя", null);
            CleanColumnAfterKey(excel, keyCells[0]);
            for (int i = 2, j = 0; j < names.Count; i++, j++)
            {
                keyCells[0][i] = names[j];
            }
        }

        public static List<string> ReadTestNamesFromTxt()
        {
            List<string> names = File.ReadAllLines(@"../../../TestNames.txt").ToList();
            return names;
        }

        public static void CleanColumnAfterKey(Application excel, Range keyCell)
        {
            for (int i = 2; i < 100; i++)
            {
                keyCell[i] = "";
            }
        }
    }
}
