using Microsoft.Office.Interop.Excel;
using System.Collections.Generic;

namespace Hekki
{
    internal class RaceManager
    {
        private static List<Pilot> pilots = new List<Pilot>();
        public static void DoThreeRaces(List<int> numbersKarts)
        {
            pilots.Clear();
            List<string> pilotsNames = ExcelWorker.ReadNamesInTotalBoard();
            foreach (var pilotName in pilotsNames)
                pilots.Add(new Pilot(pilotName));

            ExcelWorker.CleanData(4);

            for (int i = 0; i < 3; i++)
                Race.Start(pilots, numbersKarts, i);

            ExcelWorker.WriteUsedKarts(pilots);
        }

        public static void DoOneRace(List<int> numbersKarts)
        {
            int numberRace = pilots.Count > 16 ? 3 : 4;
            Race.Start(pilots, numbersKarts, numberRace);
            ExcelWorker.WriteUsedKarts(pilots);
        }

        public static void Sort()
        {
            
            
            Microsoft.Office.Interop.Excel.Range rangeToSort = ExcelWorker.GetRangeToSort();
            rangeToSort.Sort(rangeToSort.Columns[8], XlSortOrder.xlDescending);
        }

        public static void ReadScor()
        {
            var dic = ExcelWorker.ReadScoresInRace(pilots.Count);
            foreach (var pilot in pilots)
            {
                pilot.AddScore(dic);
            }
            ExcelWorker.WriteScoreInTotalBoard(pilots);
        }
    }
}
