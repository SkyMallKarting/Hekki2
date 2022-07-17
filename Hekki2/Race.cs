using Hekki2;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Hekki
{
    class Race
    {
        public readonly int MaxOfKarts = SprintReg.GetMaxKarts();
        private static Random rng = new Random();
        private static int CountPilotsInLastGroup;
        public static void Start(List<Pilot> pilots, List<int> numbers, int numberRace)
        {

            List<List<Pilot>> groups = new List<List<Pilot>>();
            if (numberRace == 4)
            {
                var sortedPilots = MakePilotsFromTotalBoard(pilots.Count);
                RemoveWorstPilots(sortedPilots);
                groups = DivideByGroup(sortedPilots, numbers);
                DoAssignmentToGroup(groups[0], numbers, numberRace);
            }
            if (numberRace == 3)
            {
                //var sortedPilots = MakePilotsFromTotalBoard(pilots.Count);
                pilots = MakePilotsFromTotalBoard(pilots.Count);
                RemoveWorstPilots(pilots);
                groups = DivideByGroup(pilots, numbers);
                for (int i = 0; i < groups.Count; i++)
                    DoAssignmentToGroup(groups[i], numbers, numberRace);

            }
            else
            {
                Shuffle(pilots);
                groups = DivideByGroup(pilots, numbers);
                for (int i = 0; i < groups.Count; i++)
                    DoAssignmentToGroup(groups[i], numbers, numberRace);

            }
            ExcelWorker.WriteNames(groups, numberRace, "Пилоты");
        }

        private static void RemoveWorstPilots(List<Pilot> sortedPilots)
        {
            for (int i = 0; i < CountPilotsInLastGroup; i++)
            {
                sortedPilots.RemoveAt(sortedPilots.Count - 1);
            }
        }

        

        public static void DoAssignmentToGroup(List<Pilot> group, List<int> numbersOfKarts, int numberRace)
        {
            List<int> copyNumbersOfKarts;
            CopyList(numbersOfKarts, copyNumbersOfKarts = new List<int>());
            while (copyNumbersOfKarts.Count > group.Count)
                copyNumbersOfKarts.RemoveAt(0);
            for (int j = 0; j < group.Count; j++)
            {
                int k = 0;
                while (k < copyNumbersOfKarts.Count)
                {
                    if (Pilot.IsCanBeAdd(group[j], copyNumbersOfKarts[k]))
                    {
                        group[j].AddNumberKart(copyNumbersOfKarts[k], numberRace);
                        copyNumbersOfKarts.RemoveAt(k);
                        break;
                    }
                    k++;
                }
            }
            if (copyNumbersOfKarts.Count > 0)
            {
                for (int i = 0; i < group.Count; i++)
                    //group[i].AddNumberKart(0, numberRace);
                    group[i].ClearUsedKartsByNumberRace(numberRace);
                DoAssignmentToGroup(group, numbersOfKarts, numberRace);
            }
        }

        public static List<List<Pilot>> DivideByGroup(List<Pilot> pilots, List<int> numbersOfKarts)
        {
            

            List<List<Pilot>> groups = new List<List<Pilot>>();
            int countGroups = (int)Math.Ceiling((double)pilots.Count / numbersOfKarts.Count);

            for (int i = 0; i < countGroups; i++)
                groups.Add(new List<Pilot>());

            for (int i = 0, j = 0; i < pilots.Count; i++, j++)
            {
                if (j == countGroups)
                    j = 0;
                groups[j].Add(pilots[i]);
            }
            CountPilotsInLastGroup = groups[groups.Count - 1].Count;
            return groups;
        }

        public static void SortPilotsByScore(List<Pilot> pilots)
        {
            List<Pilot> sorted = new List<Pilot>();

            for (int i = 1; i < pilots.Count; i++)
            {
                var keyPilot = pilots[i];
                var keyScore = pilots[i].Score;
                int j = i - 1;
                while (j >= 0 && pilots[j].Score < keyScore)
                {
                    pilots[j + 1] = pilots[j];
                    j--;
                }
                pilots[j + 1] = keyPilot;
            }
            //pilots.Reverse();
        }

        public static List<Pilot> MakePilotsFromTotalBoard(int countPilots)
        {
            List<Pilot> pilots = new List<Pilot>();
            //var data = ExcelWorker.ReadDataFromTotalBoard(countPilots);
            //string[] pilotInfo;
            //for (int i = 0; i < data.Count; i++)
            //{
            //    pilotInfo = data[i].Split('?');

            //    List<int> numbersKarts = new List<int>();
            //    for (int j = 0; j < pilotInfo[0].Length; j++)
            //        numbersKarts.Add(pilotInfo[0][j] - '0');

            //    int scores = Int32.Parse(pilotInfo[2]);
            //    List<int> scores = new List<int>();
            //    for (int j = 0; j < pilotInfo[0].Length; j++)
            //        scores.Add(pilotInfo[2][j] - '0');

            //    pilots.Add(new Pilot(numbersKarts, pilotInfo[1], scores));
            //}
            return pilots;
        }

        public static void Shuffle<T>(IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
        // TODO: Повертати новий список за допомогою ToList()
        public static void CopyList<T>(List<T> source, List<T> destination)
        {
            Shuffle(source);
            source.ForEach((item) =>
            {
                destination.Add((item));
            });

        }
    }
}