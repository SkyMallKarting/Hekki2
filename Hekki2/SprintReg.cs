﻿using Hekki;
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
    public partial class SprintReg : Form
    {
        private static List<int> numbersKarts;
        public SprintReg(List<int> karts)
        {
            InitializeComponent();
            numbersKarts = karts;
            numbersOfKarts.Lines = numbersKarts.ConvertAll<string>(delegate(int i) { return i.ToString(); }).ToArray();
        }

        private void DoThreeRaces_Click(object sender, EventArgs e)
        {
            Sprint.DoThreeRaces(numbersKarts);
        }

        private void DoSemiFinal_Click(object sender, EventArgs e)
        {
            Sprint.DoNextRace(numbersKarts, 3);
        }

        private void DoFinal_Click(object sender, EventArgs e)
        {
            Sprint.DoNextRace(numbersKarts, 4);
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            Sprint.Sort();
        }

        private void SprintReg_Load(object sender, EventArgs e)
        {

        }

        private void DoResult_Click(object sender, EventArgs e)
        {
            Sprint.ReadScor();
            //Sprint.Sort();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            ExcelWorker.CleanData(4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numbersKarts.Clear();
            foreach (string i in numbersOfKarts.Lines)
                numbersKarts.Add(Int32.Parse(i));
        }

        private void DoOneRace_Click(object sender, EventArgs e)
        {
            Sprint.DoOneRace(numbersKarts);
        }

        private void RebuildPilots_Click(object sender, EventArgs e)
        {
            Sprint.ReBuildPilots();
        }

        private void DeleteLastUsedKart_Click(object sender, EventArgs e)
        {
            ExcelWorker.DeleteLastUsedKartsInTotalBoard();
            Sprint.ReBuildPilots();
        }
    }
}
