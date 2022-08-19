using Hekki;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hekki2
{
    internal class Cherkasy
    {
        private static List<Pilot> pilots = new List<Pilot>();
        private static int totalPilots;

        public static void DoOneRace(List<int> numbersKarts)
        {
            int numberRace = pilots[0].GetNumbersKarts().Count;
            pilots = Race.MakePilotsFromTotalBoard(pilots.Count);
            int countGroups = (int)Math.Ceiling((double)pilots.Count / numbersKarts.Count);
            Race.StartFinalRace(pilots, numbersKarts, numberRace, countGroups);
            ExcelWorker.WriteUsedKarts(pilots);
        }

        public static void DoQualRace(List<int> numbersKarts)
        {
            int numberRace; 
            try
            {
                numberRace = pilots[0].GetNumbersKarts().Count;
            }
            catch (Exception)
            {
                numberRace = 0;
            }
            

            pilots.Clear();
            List<string> pilotsNames = ExcelWorker.ReadNamesInTotalBoard();
            foreach (var pilotName in pilotsNames)
                pilots.Add(new Pilot(pilotName));
            totalPilots = pilots.Count;
            
            pilots = Race.MakePilotsFromTotalBoard(pilots.Count);
            Race.StartHeatRace(pilots, numbersKarts, numberRace);
            ExcelWorker.WriteUsedKarts(pilots);
        }

        public static void ReadTime()
        {
            var dic = ExcelWorker.ReadTimeInRace(totalPilots);
            foreach (var pilot in pilots)
            {
                pilot.AddTime(dic);
            }
            ExcelWorker.WriteTimeInTotalBoard(pilots);
        }

        public static void ReadScor()
        {
            var dic = ExcelWorker.ReadScoresInRace(totalPilots);
            foreach (var pilot in pilots)
            {
                pilot.AddScore(dic);
            }
            ExcelWorker.WriteScoreInTotalBoard(pilots);
        }
    }
}
