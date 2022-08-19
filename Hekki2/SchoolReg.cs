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
    public partial class SchoolReg : Form
    {
        private static List<int> numbersKarts;
        public SchoolReg(List<int> karts)
        {
            InitializeComponent();
            numbersKarts = karts;
            numbersOfKarts.Lines = numbersKarts.ConvertAll<string>(delegate (int i) { return i.ToString(); }).ToArray();
        }

        private void RebuildPilots_Click(object sender, EventArgs e)
        {
            School.ReBuildPilots();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numbersKarts.Clear();
            foreach (string i in numbersOfKarts.Lines)
                numbersKarts.Add(Int32.Parse(i));
        }

        private void DoRace1_Click(object sender, EventArgs e)
        {
            School.DoRace(numbersKarts);
        }

        private void DoRace2_Click(object sender, EventArgs e)
        {
            School.DoRace(numbersKarts);
        }

        private void WriteTime_Click(object sender, EventArgs e)
        {
            School.ReadTime();
        }

        private void SortAllTimes_Click(object sender, EventArgs e)
        {
            School.SortTimes();
        }
    }
}
