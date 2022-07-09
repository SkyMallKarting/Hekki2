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
    public partial class SprintReg : Form
    {
        private static List<int> numbersKarts;
        public SprintReg(List<int> karts)
        {
            InitializeComponent();
            numbersKarts = karts;
        }

        private void DoThreeRaces_Click(object sender, EventArgs e)
        {
            
            RaceManager.DoThreeRaces(numbersKarts);
        }

        private void DoSemiFinal_Click(object sender, EventArgs e)
        {
            RaceManager.DoOneRace(numbersKarts);
        }

        private void DoFinal_Click(object sender, EventArgs e)
        {
            RaceManager.DoOneRace(numbersKarts);
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            RaceManager.Sort();
        }

        private void SprintReg_Load(object sender, EventArgs e)
        {

        }

        public static int GetMaxKarts()
        {
            return numbersKarts.Count;
        }

        private void DoResult_Click(object sender, EventArgs e)
        {
            RaceManager.ReadScor();
        }
    }
}
