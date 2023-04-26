using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UCPApplication.Dinglasa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string InputOne {
            set {
                opInputOne.Text = value;
            }
        }
        public string InputTwo {
            set {
                opInputTwo.Text = value;
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pOnebtn_Click(object sender, EventArgs e)
        {
            panelOne1.Show();
            panelOne1.BringToFront();
            panelTwo1.Hide();
        }

        private void pTwoBtn_Click(object sender, EventArgs e)
        {
            panelTwo1.Show();
            panelOne1.BringToFront();
            panelOne1.Hide();
        }

        private void panelOne1_Load(object sender, EventArgs e)
        {

        }

        private void opInputOne_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void opInputTwo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
