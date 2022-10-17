using Hekki;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hekki2
{
    internal class Sprint
    {
        private static List<Pilot> pilots = new List<Pilot>();
        private static int totalPilots;
        public static int TotalRacesCount;
        public static int maxKarts;
        public static void DoThreeRaces(List<int> numbersKarts)
        {
            pilots.Clear();
            List<string> pilotsNames = ExcelWorker.ReadNamesInTotalBoard();
            foreach (var pilotName in pilotsNames)
                pilots.Add(new Pilot(pilotName));
            totalPilots = pilots.Count;
            TotalRacesCount = totalPilots > 16 ? 3 : 4;
            ExcelWorker.CleanData();

            for (int i = 0; i < 3; i++)
                Race.StartHeatRace(pilots, numbersKarts, i);

            ExcelWorker.WriteUsedKarts(pilots);
        }
        public static void DoOneRace(List<int> numbersKarts)
        {
            pilots.Clear();
            Race.ReBuildCountPilotsInFirstGroup(numbersKarts);
            List<string> pilotsNames = ExcelWorker.ReadNamesInTotalBoard();
            foreach (var pilotName in pilotsNames)
                pilots.Add(new Pilot(pilotName));
            pilots = Race.MakePilotsFromTotalBoard(pilots.Count);
            totalPilots = pilots.Count;
            TotalRacesCount = totalPilots > 16 ? 3 : 4;

            Race.StartHeatRace(pilots, numbersKarts, pilots[0].KartsCount);

            ExcelWorker.WriteUsedKarts(pilots);
        }
        
        public static void DoNextRace(List<int> numbersKarts, int numberRace)
        {
            Race.ReBuildCountPilotsInFirstGroup(numbersKarts);
            //int numberRace = pilots.Count >= 17 ? 3 : 4;
            if (numberRace == 3)
            {
                pilots = Race.MakePilotsFromTotalBoard(Race.CountPilotsInFirstGroup * 2);
                Race.StartSemiRace(pilots, numbersKarts, numberRace);
            }
            else
            {
                pilots = Race.MakePilotsFromTotalBoard(Race.CountPilotsInFirstGroup);
                Race.StartFinalRace(pilots, numbersKarts, numberRace);
            }
            ExcelWorker.WriteUsedKarts(pilots);
        }

        public static void Sort()
        {
            Range rangeToSort = ExcelWorker.GetRangeToSort();
            rangeToSort.Sort(rangeToSort.Columns[8], XlSortOrder.xlDescending);
        }

        public static void ReadScor()
        {
            pilots = ExcelWorker.ReadScoresInRace(pilots);
            ExcelWorker.WriteScoreInTotalBoard(pilots);
        }

        public static void ReBuildPilots()
        {
            List<string> pilotsNames = ExcelWorker.ReadNamesInTotalBoard();
            pilots = Race.MakePilotsFromTotalBoard(pilotsNames.Count);
            totalPilots = pilots.Count;
        }
    }
}
