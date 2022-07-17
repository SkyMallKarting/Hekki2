using System;
using System.Collections.Generic;
using System.Linq;

namespace Hekki
{
    public class Pilot
    {
        private string _name;
        private List<int> _usedKarts = new List<int>();
        private List<int> _scores = new List<int>();
        public int Score;
        public int ScoresCount;
        public string Name { get { return _name; } set { _name = value; } }
        public Pilot(string name)
        {
            Name = name;
        }

        public Pilot(List<int> usedKarts, string name, List<int> scores)
        {
            for (int i = 0; i < usedKarts.Count; i++)
                _usedKarts.Add(usedKarts[i]);

            _name = name;

            for (int i = 0; i < scores.Count; i++)
                _scores.Add(scores[i]);

            Score = scores.Sum();
            ScoresCount = scores.Count;
            
        }

        public void AddNumberKart(int numberKart, int numberRace)
        {
            _usedKarts.Add(numberKart);
        }

        public static bool IsCanBeAdd(Pilot pilot, int number)
        {
            if (pilot._usedKarts.Contains(number))
                return false;
            return true;
        }

        public string GetNumberKartByRace(int numberRace)
        {
            return _usedKarts[numberRace].ToString();
        }

        public string GetAllNumbersKarts()
        {
            string res = "";
            foreach (int numberKart in _usedKarts)
            {
                res += numberKart.ToString();
            }
            return res;
        }

        public void AddScore(Dictionary<string, List<int>> score)
        {
            _scores.Clear();
            for (int i = 0; i < score[_name].Count; i++)
            {
                _scores.Add(score[_name][i]);
            }
            ScoresCount = score[_name].Count;
            Score = _scores.Sum();
        }

        public int GetScoreByNumberRace(int numberRace)
        {
            return _scores[numberRace];
        }

        public void ClearUsedKartsByNumberRace(int numberRace)
        {
            try
            {
                _usedKarts.RemoveAt(numberRace);
            }
            catch (Exception)
            {

               
            }
            
        }
    }
}