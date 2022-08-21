using Hekki2;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;

namespace Hekki
{
    public class ExcelWorker
    {
        private static int count = 0;
        public static Application excel = GetExcel();
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

        public static List<string> ReadNamesInTotalBoard()
        {
            var keyCells = FindKeyCellByValue("Имя", null);
            List<string> names = new List<string>();

            int i = 2;  
            while (keyCells[0].Cells[i].Value != null)
            {
                names.Add(keyCells[0].Cells[i].Value.ToString());
                i++;
            }

            return names;
        }

        public static Range GetRangeToSort()
        {
            return excel.get_Range("C4", "J100");
        }

        public static List<List<int>> ReadUsedKartsInTotalBoard()
        {
            var keyCells = FindKeyCellByValue("Номера", null);
            List<List<int>> karts = new List<List<int>>();

            int i = 2;
            int q = 0;
            
            while (keyCells[0].Cells[i].Value != null)
            {
                karts.Add(new List<int>());
                
                string numbers = keyCells[0].Cells[i, 1].Value.ToString();
                for (int j = 0, k = 0; j < numbers.Length; j++, k++)
                {
                    karts[q].Add(numbers[k] - '0');
                }
                i++;
                q++;
            }

            return karts;
        }

        public static List<List<int>> ReadScoresInTotalBoard(int countPilots)
        {
            var keyCells = FindKeyCellByValue("Хит", excel.Range["A1", "K100"]);
           
            List<List<int>> score = new List<List<int>>();

            int i = 0;
            int k = 1;

            for (int j = 0; j < countPilots; j++)
            {
                score.Add(new List<int>());
                for (int q = 0; q < keyCells.Count; q++)
                {
                    int number;
                    if (keyCells[q].Cells[1 + k].Value == null)
                        continue;
                    else
                        number = (int)keyCells[q].Cells[1 + k].Value;
                    score[i].Add(number);
                }
                i++;
                k++;
            }
            return score;
        }

        public static void WriteNames(List<List<Pilot>> groups, int numberRace, string keyWord)
        {
            var keyCells = FindKeyCellByValue(keyWord, true, null);
            var keyKartCell = FindKeyCellByValue("Карт", true, null);
            var startIndex = GetStartIndexOfEmptyTable(keyCells[1].Row, keyCells[1].Column);

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
                        excel.Cells[startIndex, keyKartCell[1].Column] = "";
                        startIndex++;
                    }
                    else
                    {
                        //System.Threading.Thread.Sleep(500);
                        excel.Cells[startIndex, keyCells[1].Column] = pilot.Name;
                        excel.Cells[startIndex, keyKartCell[1].Column] = pilot.GetNumberKartByRace(numberRace);
                        startIndex++;
                    }
                }
            }
        }

        private static int GetStartIndexOfEmptyTable(int row, int column)
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
            string value,
            Range searchedRange)
        {
            if (searchedRange == null)
                searchedRange = excel.get_Range("A1", "XFD1048576");
            var finded = searchedRange.Find(value);

            if (finded == null)
                return new List<Range>();

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

        public static void CleanData(int row)
        {
            Microsoft.Office.Interop.Excel.Range searchedRange = excel.get_Range("A1", "XFD1048576");
            excel.Range["E4", "I100"].Value = "";
            excel.Range["C4", "C100"].Value = "";
            var finded = searchedRange.Find("Пилоты");
            var firstAddres = finded.Address;
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
                if (finded.Address == firstAddres)
                    break;
            } while (i < 50);
        }

        public static void WriteUsedKarts(List<Pilot> pilots)
        {
            var keyCells = FindKeyCellByValue("Номера", null);
            var startIndex = keyCells[0].Row + 1;
            for (int i = 0; i < pilots.Count; i++)
            {
                excel.Cells[startIndex, keyCells[0].Column] = pilots[i].GetAllNumbersKarts();
                excel.Cells[startIndex, keyCells[0].Column + 1] = pilots[i].Name;
                startIndex++;
            }
        }

        public static Dictionary<string, List<int>> ReadScoresInRace(int pilotsCount)
        {
            var keyScore = FindKeyCellByValue("Итого", null);
            var keyName = FindKeyCellByValue("Пилоты", null);
            Dictionary<string, List<int>> score = new Dictionary<string, List<int>>();

            for (int j = 0; j < keyScore.Count; j++)
            {
                var startIndex = keyScore[j].Row + 1;
                for (int i = 0; i < pilotsCount && startIndex < 50; startIndex++)
                {
                    int columnIndexName = 0;

                    while (excel.Cells[keyScore[j].Row, keyScore[j][startIndex - 1, columnIndexName].Column].Value != "Пилоты")
                        columnIndexName--;

                    if (excel.Cells[startIndex, keyScore[j][startIndex,columnIndexName].Column].Value == null)
                        continue;

                    string key = excel.Cells[startIndex, keyScore[j][startIndex,columnIndexName].Column].Value.ToString();
                    int val = (int)excel.Cells[startIndex, keyScore[j].Column].Value;
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

        public static Dictionary<string, List<string>> ReadTimeInRace(int pilotsCount)
        {
            var keyTime = FindKeyCellByValue("Время", null);
            Dictionary<string, List<string>> time = new Dictionary<string, List<string>>();
            for (int j = 0; j < keyTime.Count; j++)
            {
                var startIndex = keyTime[j].Row + 1;
                for (int i = 0; i < pilotsCount && startIndex < 50; startIndex++)
                {
                    int columnIndexName = 0;

                    while (excel.Cells[keyTime[j].Row, keyTime[j][startIndex - 1, columnIndexName].Column].Value != "Пилоты")
                        columnIndexName--;

                    if (excel.Cells[startIndex, keyTime[j][startIndex, columnIndexName].Column].Value == null)
                        continue;

                    string key = excel.Cells[startIndex, keyTime[j][startIndex, columnIndexName].Column].Value.ToString();
                    string val = excel.Cells[startIndex, keyTime[j].Column].Value;
                    if (!time.ContainsKey(key))
                    {
                        time.Add(key, new List<string>());
                    }
                    time[key].Add(val);
                    i++;
                }
            }
            return time;
        }

        public static void WriteScoreInTotalBoard(List<Pilot> pilots)
        {
            var keyCells = FindKeyCellByValue("Хит", excel.Range["A1", "K100"]);
            int k = 1;
            for (int i = 0; i < pilots[0].ScoresCount; i++)
            {
                for (int j = 0; j < pilots.Count; j++)
                {
                    var cell = FindKeyCellByValue(pilots[j].Name, excel.get_Range("A1", "K100"));
                    excel.Cells[cell[0].Row, keyCells[i].Column].Value = pilots[j].GetScoreByNumberRace(i).ToString();
                }
                k++;
            }

            //for (int i = 1; i < pilots[0].ScoresCount + 1; i++)
            //{
            //    for (int j = 0; j < pilots.Count; j++)
            //    {
            //        var cell = FindKeyCellByValue(pilots[j].Name, excel.get_Range("A1", "K100"));
            //        excel.Cells[cell[0].Row, cell[0].Column + i].Value = pilots[j].GetScoreByNumberRace(i - 1).ToString();
            //    }
            //}
        }

        public static void WriteTimeInTotalBoard(List<Pilot> pilots)
        {
            var myCulture = new CultureInfo("ru-RU");
            myCulture.NumberFormat.NumberDecimalSeparator = ".";
            Thread.CurrentThread.CurrentCulture = myCulture;

            var keyCells = FindKeyCellByValue("Best Lap", excel.Range["A1", "K100"]);

            for (int i = 1; i < pilots[0].TimesCount + 1; i++)
            {
                for (int j = 0; j < pilots.Count; j++)
                {
                    var cell = FindKeyCellByValue(pilots[j].Name, excel.get_Range("A1", "K100"));
                    excel.Cells[cell[0].Row, keyCells[i - 1].Column].Value = pilots[j].GetTimeByIndex(i - 1).ToString();
                }
            }
        }

        public static void WriteNamesInTotalBoard(List<string> names)
        {
            var keyCells = FindKeyCellByValue("Имя", null);
            CleanColumnAfterKey(keyCells[0]);
            for (int i = 2, j = 0; j < names.Count; i++, j++)
            {
                keyCells[0][i] = names[j];
            }
        }

        public static List<string> ReadDataFromTotalBoard(int countPilots)
        {
            var keyCells = FindKeyCellByValue("Имя", null);
            var names = ReadNamesInTotalBoard();
            List<int> karts;
            List<int> scores;
            List<string> data = new List<string>();
            for (int i = 2; i < countPilots + 2; i++)
            {
                data.Add(keyCells[0][i, 0].Value + "?" + keyCells[0][i].Value + "?" + keyCells[0][i, 7].Value);
            }
            return data;
        }

        public static List<string> ReadTestNamesFromTxt()
        {
            List<string> names = File.ReadAllLines(@"../../../TestNames.txt").ToList();
            return names;
        }

        public static void CleanColumnAfterKey(Range keyCell)
        {
            for (int i = 2; i < 100; i++)
            {
                keyCell[i] = "";
            }
        }

        public static void DeleteLastUsedKartsInTotalBoard()
        {
            var numberKarts = ReadUsedKartsInTotalBoard();
            foreach (var kart in numberKarts)
            {
                kart.RemoveAt(kart.Count - 1);
            }
            WriteUsedKartsInTotalBoard(numberKarts);
        }

        public static void WriteUsedKartsInTotalBoard(List<List<int>> numberKarts)
        {
            var keyCells = FindKeyCellByValue("Номера", excel.Range["A1", "K100"]);
            int k = 2;
            for (int i = 0; i < numberKarts.Count; i++)
            {
                string numbers = "";
                for (int j = 0; j < numberKarts[i].Count; j++)
                {
                    numbers += numberKarts[i][j].ToString();
                }
                keyCells[0][k].Value = numbers;
                k++;
            }
        }
    }
}
