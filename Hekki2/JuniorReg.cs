using Hekki;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hekki2
{
    public partial class JuniorReg : Form
    {
        private static List<int> numbersKarts;
        public JuniorReg(List<int> karts)
        {
            InitializeComponent();
            numbersKarts = karts;
            numbersOfKarts.Lines = numbersKarts.ConvertAll<string>(delegate (int i) { return i.ToString(); }).ToArray();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Junior.DoQualRandom(numbersKarts);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Junior.DoQualByList(numbersKarts);
        }

        private void DoRace1_Click(object sender, EventArgs e)
        {
            Junior.DoRace(numbersKarts);
        }

        private void DoRace2_Click(object sender, EventArgs e)
        {
            Junior.DoRace(numbersKarts);
        }

        private void DoFinal_Click(object sender, EventArgs e)
        {
            Junior.DoFinal(numbersKarts);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numbersKarts.Clear();
            foreach (string i in numbersOfKarts.Lines)
                numbersKarts.Add(Int32.Parse(i));
        }

        private void RebuildPilots_Click(object sender, EventArgs e)
        {
            Junior.ReBuildPilots();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            ExcelWorker.CleanData();
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            Junior.SortScores();
        }

        private void SortAllTimes_Click(object sender, EventArgs e)
        {
            Junior.SortTimes();
        }

        private void DoResult_Click(object sender, EventArgs e)
        {
            Junior.ReadScor();
        }

        private void WriteTime_Click(object sender, EventArgs e)
        {
            Junior.ReadTime();
        }

        
    }
}
