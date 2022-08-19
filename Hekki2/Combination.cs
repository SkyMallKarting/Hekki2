using Hekki;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Hekki2
{
    internal class Combination
    {
        private static int Factorial(int n)
        {
            var factorial = new BigInteger(1);
            for (int i = 1; i <= n; i++)
                factorial *= i;

            return (int)factorial;
        }

        private static void AllVariables(List<int> numbers)
        {
            HashSet<List<int>> curr = new HashSet<List<int>>();

            while (curr.Count < (int)Factorial(numbers.Count))
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    for (int j = 0; j < numbers.Count; j++)
                    {
                        var temp =
                        curr.Add(numbers);
                    }
                }
            }
        }

        private static IEnumerable<List<int>> AllCombinations(List<int> arg, List<int> awithout)
        {
            if (arg.Count == 1)
            {
                var result = new List<List<int>>();
                result.Add(new List<int>());
                result[0].Add(arg[0]);
                return result;
            }
            else
            {
                var result = new List<List<int>>();

                foreach (var first in arg)
                {
                    var others0 = new List<int>(arg.Except(new int[1] { first }));
                    awithout.Add(first);
                    var others = new List<int>(others0.Except(awithout));

                    var combinations = AllCombinations(others, awithout);
                    awithout.Remove(first);

                    foreach (var tail in combinations)
                    {
                        tail.Insert(0, first);
                        result.Add(tail);
                    }
                }
                return result;
            }
        }
        private static void ShowInfo(IEnumerable<int> arg)
        {
            foreach (var str in arg)
                Console.Write(str);
            Console.WriteLine();
        }

        public static List<int> GetAvaibleCombo(List<int> numbersKarts, List<Pilot> pilots)
        {
            var totallist = new List<int>(numbersKarts);
            var allcombis = AllCombinations(totallist, new List<int>());
            var allcombi = allcombis.ToList();

            for (int i = 0; i < pilots.Count; i++)
            {
                for (int j = 0; j < pilots[i].GetNumbersKarts().Count; j++)
                {
                    List<int> nums = new List<int>();
                    int count = 0;
                    foreach (var combi in allcombi)
                    {
                        if (combi[i] == pilots[i].GetNumbersKarts()[j])
                        {
                            nums.Add(count);
                        }
                        count++;
                    }
                    foreach (int indice in nums.OrderByDescending(v => v))
                    {
                        allcombi.RemoveAt(indice);
                    }

                }
            }

            Random rnd = new Random();
            if (allcombi.Count == 0)
            {
                return new List<int>();
            }
            else
                return allcombi[rnd.Next(allcombi.Count)];
        }

        public static void AllAvaibleCombos()
        { 

        }
    }
}
