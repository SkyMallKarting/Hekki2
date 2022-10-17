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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            numbersOfKarts.Text = "1\n2\n3\n4\n5\n6\n7\n8";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            List<int> karts = new List<int>();
            foreach (string i in numbersOfKarts.Lines)
                karts.Add(Int32.Parse(i));
            SprintReg win2 = new SprintReg(karts);
            win2.Closed += (s, args) => this.Close();
            win2.Show();
        }

        private void every_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            List<int> karts = new List<int>();
            foreach (string i in numbersOfKarts.Lines)
                karts.Add(Int32.Parse(i));
            EveryReg win6 = new EveryReg(karts);
            win6.Closed += (s, args) => this.Close();
            win6.Show();
        }

        private void juniorButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            List<int> karts = new List<int>();
            foreach (string i in numbersOfKarts.Lines)
                karts.Add(Int32.Parse(i));
            JuniorReg win5 = new JuniorReg(karts);
            win5.Closed += (s, args) => this.Close();
            win5.Show();
        }

        private void numbersOfKarts_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Cherkasy_Click(object sender, EventArgs e)
        {
            this.Hide();
            List<int> karts = new List<int>();
            foreach (string i in numbersOfKarts.Lines)
                karts.Add(Int32.Parse(i));
            CherkasyReg win3 = new CherkasyReg(karts);
            win3.Closed += (s, args) => this.Close();
            win3.Show();
        }

        private void schoolButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            List<int> karts = new List<int>();
            foreach (string i in numbersOfKarts.Lines)
                karts.Add(Int32.Parse(i));
            SchoolReg win4 = new SchoolReg(karts);
            win4.Closed += (s, args) => this.Close();
            win4.Show();
        }
    }
}
