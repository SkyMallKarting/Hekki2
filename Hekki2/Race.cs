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
        public static void Start(List<Pilot> pilots, List<int> numbers, int numberRace, Application workSheet)
        {
            
            List<List<Pilot>> groups = new List<List<Pilot>>();
            //if (numberRace == 4)
            //{
            //    List<Pilot> group = pilots;
            //    DoAssignmentToGroup(group, numbers, numberRace);
            //}
            //if (numberRace == 3)
            //{
            //    groups = DevideGroupByOdd(pilots, numbers);
            //    for (int i = 0; i < groups.Count; i++)
            //        DoAssignmentToGroup(groups[i], numbers, numberRace);

            //}
            
                groups = DivideByGroup(pilots, numbers);
                for (int i = 0; i < groups.Count; i++)
                    DoAssignmentToGroup(groups[i], numbers, numberRace);
            
            ExcelWorker.WriteNames(workSheet, groups, numberRace, "Пилоты");
        }

        private static void DoAssignmentToGroup(List<Pilot> group, List<int> numbersOfKarts, int numberRace)
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
                    group[i].AddNumberKart(0, numberRace);
                DoAssignmentToGroup(group, numbersOfKarts, numberRace);
            }
        }

        private static List<List<Pilot>> DivideByGroup(List<Pilot> pilots, List<int> numbersOfKarts)
        {
            Shuffle(pilots);

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

            return groups;
        }

        private static List<List<Pilot>> DivideGroupByOdd(List<Pilot> pilots, List<int> numbersOfKarts)
        {
            List<List<Pilot>> groups = new List<List<Pilot>>();
            for (int i = 0; i < pilots.Count; i++)
            {
                if (i % 2 == 0)
                {
                    
                }
                else
                {

                }
            }
            return null;
        }

        private static void Shuffle<T>(IList<T> list)
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
        private static void CopyList<T>(List<T> source, List<T> destination)
        {
            Shuffle(source);
            source.ForEach((item) =>
            {
                destination.Add((item));
            });

        }
    }
}