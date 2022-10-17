﻿using Microsoft.Office.Interop.Excel;
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
            if (keyCells.Count == 0)
            {
                return new List<List<int>>();
            }
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

        public static List<List<string>> ReadTimesInTotalBoard(int countPilots)
        {
            var keyCells = FindKeyCellByValue("Best Lap", excel.Range["A1", "K100"]);
            if (keyCells.Count == 0)
            {
                return new List<List<string>>();
            }
            List<List<string>> time = new List<List<string>>();

            int i = 0;
            int k = 1;

            for (int j = 0; j < countPilots; j++)
            {
                time.Add(new List<string>());
                for (int q = 0; q < keyCells.Count; q++)
                {
                    string number;
                    if (keyCells[q].Cells[1 + k].Value == null)
                        continue;
                    else
                        number = keyCells[q].Cells[1 + k].Value.ToString();
                    time[i].Add(number);
                }
                i++;
                k++;
            }
            return time;
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

        public static void CleanData(int countBellow = 45)
        {
            var keyCells = FindKeyCellByValue("Номера", null);
            keyCells.AddRange(FindKeyCellByValue("Best Lap", null));
            keyCells.AddRange(FindKeyCellByValue("ХИТ", null));
            keyCells.AddRange(FindKeyCellByValue("Карт", null));
            keyCells.AddRange(FindKeyCellByValue("Пилоты", null));
            //keyCells.AddRange(FindKeyCellByValue("Очки", null));
            keyCells.AddRange(FindKeyCellByValue("Штраф", null));
            //keyCells.AddRange(FindKeyCellByValue("Время", null));
            //keyCells.AddRange(FindKeyCellByValue("Имя", null));
            
            for (int i = 0; i < keyCells.Count; i++)
            {
                string q = keyCells[i][2].Address.Replace("$", String.Empty);
                string s = keyCells[i][countBellow].Address.Replace("$", String.Empty);
                var aras = excel.get_Range(q, s);
                //aras.Interior.Color = Microsoft.Office.Interop.Excel.XlRgbColor.rgbWhite;
                aras.ClearContents();
            }
            
        }

        public static void WriteUsedKarts(List<Pilot> pilots)
        {
            var usedKarts = new List<string>();
            var keyCells = FindKeyCellByValue("Номера", null);
            var startIndex = keyCells[0].Row + 1;
            var names = ReadNamesInTotalBoard();
            for (int i = 0; i < pilots.Count; i++)
            {
                var index = pilots.FindIndex(x => x.Name == names[i]);
                excel.Cells[startIndex, keyCells[0].Column] = pilots[index].GetAllNumbersKarts();
                startIndex++;
            }
        }

        public static List<Pilot> ReadScoresInRace(List<Pilot> pilots)
        {
            Pilot.ClearScoreGlobal(pilots);
            var keyScore = FindKeyCellByValue("Итого", null);

            for (int j = 0; j < keyScore.Count; j++)
            {
                var startIndexScore = keyScore[j].Row + 1;
                int columnIndexName = 0;

                while (excel.Cells[keyScore[j].Row, keyScore[j][startIndexScore - 1, columnIndexName].Column].Value != "Пилоты")
                    columnIndexName--;

                columnIndexName = keyScore[j].Column - ((columnIndexName * -1) + 1);
                for (int i = 0; i < pilots.Count && startIndexScore < 50; startIndexScore++)
                {
                    string name;
                    try
                    {
                        name = excel.Cells[startIndexScore, columnIndexName].Value.ToString();
                    }
                    catch (Exception)
                    {
                        continue;
                    }

                    var index = pilots.FindIndex(x => x.Name == name);
                    if (index == -1)
                    {
                        continue;
                    }
                    pilots[index].AddScore((int)excel.Cells[startIndexScore, keyScore[j].Column].Value);
                    i++;
                }
            }
            return pilots;
        }

        public static List<Pilot> ReadTimeInRace(List<Pilot> pilots)
        {
            Pilot.ClearTimeGlobal(pilots);
            var keyTime = FindKeyCellByValue("Время", null);

            for (int j = 0; j < keyTime.Count; j++)
            {
                var startIndexTime = keyTime[j].Row + 1;
                int columnIndexName = 0;

                while (excel.Cells[keyTime[j].Row, keyTime[j][startIndexTime - 1, columnIndexName].Column].Value != "Пилоты")
                    columnIndexName--;

                columnIndexName = keyTime[j].Column - ((columnIndexName * -1) + 1);
                for (int i = 0; i < pilots.Count && startIndexTime < 50; startIndexTime++)
                {
                    string name;
                    try
                    {
                        name = excel.Cells[startIndexTime, columnIndexName].Value.ToString();
                    }
                    catch (Exception)
                    {
                        continue;
                    }

                    var index = pilots.FindIndex(x => x.Name == name);
                    if (index == -1)
                    {
                        continue;
                    }
                    pilots[index].AddTime(excel.Cells[startIndexTime, keyTime[j].Column].Value.ToString());
                    i++;
                }
            }
            return pilots;
        }

        private static Range GetTotalBoardRange()
        {
            var keyCells = FindKeyCellByValue("№", null);
            var keyCells2 = FindKeyCellByValue("Всего",null);
            string ad1 = keyCells[0].Address.Replace("$", String.Empty);
            string ad2 = keyCells2[0].Address.Replace("$", String.Empty);
            return excel.get_Range(ad1, ad2);

        }

        public static void WriteScoreInTotalBoard(List<Pilot> pilots)
        {
            
            var names = ReadNamesInTotalBoard();
            var keyCells = FindKeyCellByValue("Хит", GetTotalBoardRange());
            for (int i = 0; i < keyCells.Count; i++)
            {
                var startIndex = keyCells[0].Row + 1;
                for (int j = 0; j < pilots.Count; j++)
                {
                    var index = pilots.FindIndex(x => x.Name == names[j]);
                    if (pilots[index].ScoresCount - 1 < i)
                    {
                        startIndex++;
                        continue;
                    }
                    excel.Cells[startIndex, keyCells[i].Column].Value = pilots[index].GetScoreByNumberRace(i).ToString();

                    startIndex++;
                }
            }
        }

        public static void WriteTimeInTotalBoard(List<Pilot> pilots)
        {
            var myCulture = new CultureInfo("ru-RU");
            myCulture.NumberFormat.NumberDecimalSeparator = ".";
            Thread.CurrentThread.CurrentCulture = myCulture;

            var names = ReadNamesInTotalBoard();
            var keyCells = FindKeyCellByValue("Best Lap", excel.Range["A1", "K100"]);


            for (int i = 1; i < pilots[0].TimesCount + 1; i++)
            {
                var startIndex = keyCells[0].Row + 1;
                for (int j = 0; j < pilots.Count; j++)
                {
                    var index = pilots.FindIndex(x => x.Name == names[j]);
                    if (pilots[index].TimesCount < i)
                    {
                        startIndex++;
                        continue;
                    }
                    excel.Cells[startIndex, keyCells[i - 1].Column].Value = pilots[index].GetTimeByIndex(i - 1).ToString();
                    startIndex++;
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
            var firstPilotsKarts = numberKarts[0].Count;

            if (firstPilotsKarts > numberKarts[numberKarts.Count - 1].Count)
            {
                foreach (var kart in numberKarts)
                {
                    if (kart.Count == firstPilotsKarts)
                    {
                        kart.RemoveAt(kart.Count - 1);
                    }
                    
                }
            }
            else
            {
                foreach (var kart in numberKarts)
                {
                    kart.RemoveAt(kart.Count - 1);
                }
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
