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
        private static Random rng = new Random();
        private static int _countPilotsInFirstGroup;
        private static int CountPilotsInLastGroup;
        public static int CountPilotsInFirstGroup { get { return _countPilotsInFirstGroup; } }
        //public static void Start(List<Pilot> pilots, List<int> numbers, int numberRace)
        //{

        //    List<List<Pilot>> groups = new List<List<Pilot>>();
        //    if (numberRace == 4)
        //    {
        //        groups = DivideByGroup(pilots, numbers);
        //        DoAssignmentToGroup(pilots, numbers, numberRace);
        //    }
        //    else if (numberRace == 3)
        //    {
        //        groups = DivideByGroup(pilots, numbers);
        //        for (int i = 0; i < groups.Count; i++)
        //            DoAssignmentToGroup(groups[i], numbers, numberRace);
        //    }
        //    else
        //    {
        //        Shuffle(pilots);
        //        groups = DivideByGroup(pilots, numbers);
        //        _countPilotsInFirstGroup = groups[0].Count;
        //        for (int i = 0; i < groups.Count; i++)
        //            DoAssignmentToGroup(groups[i], numbers, numberRace);

        //    }
        //    ExcelWorker.WriteNames(groups, numberRace, "Пилоты");
        //}
        
        public static void StartHeatRace(List<Pilot> pilots, List<int> numbers, int numberRace)
        {
            List<List<Pilot>> groups = new List<List<Pilot>>();
            Shuffle(pilots);
            groups = DivideByGroup(pilots, numbers);
            _countPilotsInFirstGroup = groups[0].Count;
            for (int i = 0; i < groups.Count; i++)
                DoAssignmentToGroup(groups[i], numbers, numberRace);
            ExcelWorker.WriteNames(groups, numberRace, "Пилоты");
        }

        public static void StartSemiRace(List<Pilot> pilots, List<int> numbers, int numberRace)
        {
            List<List<Pilot>> groups = new List<List<Pilot>>();
            groups = DivideByGroup(pilots, numbers);
            for (int i = 0; i < groups.Count; i++)
                DoAssignmentToGroup(groups[i], numbers, numberRace);
            ExcelWorker.WriteNames(groups, numberRace, "Пилоты");
        }

        public static void StartFinalRace(List<Pilot> pilots, List<int> numbers, int numberRace, int count = 1)
        {
            List<List<Pilot>> groups = new List<List<Pilot>>();
            groups = SimpleDivideByGroup(pilots, numbers);
            for (int i = 0; i < groups.Count; i++)
                DoAssignmentToGroup(groups[i], numbers, numberRace);
            
            ExcelWorker.WriteNames(groups, numberRace, "Пилоты");
        }

        public static void RemoveWorstPilots(List<Pilot> sortedPilots)
        {
            for (int i = 0; i < CountPilotsInLastGroup; i++)
            {
                sortedPilots.RemoveAt(sortedPilots.Count - 1);
            }
        }

        public static void AddInfoForLosers(List<Pilot> pilots, int repeatTimes)
        {
            for (int j = 0, x = pilots.Count - CountPilotsInLastGroup; j < CountPilotsInLastGroup; j++)
            {
                for (int i = 0; i < repeatTimes; i++)
                {
                    pilots[x].AddEmptyScore();
                    pilots[x].AddEmptyNumberKart();
                }
                x++;
            }
            
        }

        public static void DoAssignmentToGroup(List<Pilot> group, List<int> numbersOfKarts, int numberRace, int counerReapeat = 0)
        {
            if (counerReapeat == 50)
            {
                DoAssignmentByCombo(group, numbersOfKarts, numberRace);
                return;
            }
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
                    group[i].ClearUsedKartsByNumberRace(numberRace);
                DoAssignmentToGroup(group, numbersOfKarts, numberRace, counerReapeat + 1);
            }
        }

        private static void DoAssignmentByCombo(List<Pilot> group, List<int> numbersOfKarts, int numberRace)
        {
            var combo = Combination.GetAvaibleCombo(numbersOfKarts, group);
            if (combo.Count == 0)
                return;
            for (int i = 0; i < group.Count; i++)
            {
                group[i].AddNumberKart(combo[i], numberRace);
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

        public static List<List<Pilot>> SimpleDivideByGroup(List<Pilot> pilots, List<int> numbersOfKarts)
        {
            var dividedGroups = DivideByGroup(pilots, numbersOfKarts);
            List<List<Pilot>> groups = new List<List<Pilot>>();
            int countGroups = (int)Math.Ceiling((double)pilots.Count / numbersOfKarts.Count);

            for (int i = 0; i < countGroups; i++)
                groups.Add(new List<Pilot>());

            int counter = 0;
            for (int i = 0, j = 0; i < countGroups; i++)
            {
                while (counter < dividedGroups[i].Count)
                {
                    groups[i].Add(pilots[j]);
                    j++;
                    counter++;
                }
                counter = 0;
            }
            return groups;
        }

        public static List<Pilot> MakePilotsFromTotalBoard(int countPilots)
        {
            List<Pilot> pilots = new List<Pilot>();
            var names = ExcelWorker.ReadNamesInTotalBoard();
            var kartsMerged = ExcelWorker.ReadUsedKartsInTotalBoard();
            var scoresMerged = ExcelWorker.ReadScoresInTotalBoard(countPilots);

            for (int i = 0; i < countPilots; i++)
            {
                List<int> karts = new List<int>();
                List<int> scores = new List<int>();
                for (int j = 0; j < kartsMerged[0].Count; j++)
                {
                    karts.Add(kartsMerged[i][j]);
                }
                for (int j = 0; j < scoresMerged[0].Count; j++)
                {
                    scores.Add(scoresMerged[i][j]);
                }
                pilots.Add(new Pilot(karts, names[i], scores));
            }
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