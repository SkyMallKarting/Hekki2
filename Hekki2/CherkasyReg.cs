using Hekki;
using Microsoft.Office.Interop.Excel;
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
    public partial class CherkasyReg : Form
    {
        private static List<int> numbersKarts;
        public CherkasyReg(List<int> karts)
        {
            InitializeComponent();
            numbersKarts = karts;
            numbersOfKarts.Lines = numbersKarts.ConvertAll<string>(delegate (int i) { return i.ToString(); }).ToArray();
        }

        private void Cherkasy_Load(object sender, EventArgs e)
        {

        }

        private void DoQual1_Click(object sender, EventArgs e)
        {
            Cherkasy.DoQualRace(numbersKarts);
        }

        private void DoHeat1_Click(object sender, EventArgs e)
        {
            Cherkasy.DoOneRace(numbersKarts);
        }

        private void DoQual2_Click(object sender, EventArgs e)
        {
            Cherkasy.DoQualRace(numbersKarts);
        }

        private void DoHeat2_Click(object sender, EventArgs e)
        {
            Cherkasy.DoOneRace(numbersKarts);
        }

        private void DoResult_Click(object sender, EventArgs e)
        {
            Cherkasy.ReadScor();
        }

        private void WriteQual_Click(object sender, EventArgs e)
        {
            Cherkasy.ReadTime();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            ExcelWorker.CleanData(4);
        }

        private void RebuildKarts_Click(object sender, EventArgs e)
        {
            Cherkasy.ReBuildPilots();
        }

        private void SortQual_Click(object sender, EventArgs e)
        {
            Cherkasy.SortTimes();
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            Range rangeToSort = ExcelWorker.GetRangeToSort();
            rangeToSort.Sort(rangeToSort.Columns[8], XlSortOrder.xlDescending);
        }

        private void DoFinal_Click(object sender, EventArgs e)
        {
            Cherkasy.DoFinal(numbersKarts);
        }
    }
}
