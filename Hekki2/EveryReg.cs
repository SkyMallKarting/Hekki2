using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hekki;
using Microsoft.Office.Interop.Excel;

namespace Hekki2
{
    public partial class EveryReg : Form
    {
        private static List<int> numbersKarts;
        public EveryReg(List<int> karts)
        {
            InitializeComponent();
            numbersKarts = karts;
            numbersOfKarts.Lines = numbersKarts.ConvertAll<string>(delegate (int i) { return i.ToString(); }).ToArray();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numbersKarts.Clear();
            foreach (string i in numbersOfKarts.Lines)
                numbersKarts.Add(Int32.Parse(i));
        }

        private void clear_Click(object sender, EventArgs e)
        {
            ExcelWorker.CleanData(11);
        }

        private void DoResult_Click(object sender, EventArgs e)
        {
            Every.ReadScor();
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            Every.SortScores();
        }

        private void DoRaces_Click(object sender, EventArgs e)
        {
            Every.DoRaces(numbersKarts);
        }
    }
}
