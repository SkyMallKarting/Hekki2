﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hekki;
using Microsoft.Office.Interop.Excel;

namespace Hekki2
{
    internal class Every
    {
        private static List<Pilot> pilots = new List<Pilot>();
        private static int totalPilots;
        public static int TotalRacesCount;

        public static void DoRaces(List<int> numbersKarts)
        {
            pilots.Clear();
            List<string> pilotsNames = ExcelWorker.ReadNamesInTotalBoard();
            foreach (var pilotName in pilotsNames)
                pilots.Add(new Pilot(pilotName));
            totalPilots = pilots.Count;

            pilots = Race.MakePilotsFromTotalBoard(pilots.Count);
            Race.StartRandomRace(pilots, numbersKarts);

        }

        public static void SortScores()
        {
            var keyCells = ExcelWorker.FindKeyCellByValue("ВСЕГО", null);

            for (int i = 0; i < keyCells.Count; i++)
            {
                int j = 0;
                while (keyCells[i][1, j--].Value != null) { }
                var firstCellRow = keyCells[i].Row;
                var firstCellCol = keyCells[i][1, j].Column;

                Range rangeToSort = ExcelWorker.excel.Range[ExcelWorker.excel.Cells[firstCellRow + 1, firstCellCol + 1], keyCells[i][50]];
                rangeToSort.Sort(rangeToSort.Columns[(j - 1) * -1], XlSortOrder.xlDescending);
            }
        }

        public static void ReadScor()
        {
            pilots = ExcelWorker.ReadScoresInRace(pilots);
            ExcelWorker.WriteScoreInTotalBoard(pilots);
        }
    }
}
