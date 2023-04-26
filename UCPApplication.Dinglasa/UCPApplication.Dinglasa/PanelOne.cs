using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UCPApplication.Dinglasa
{
    public partial class PanelOne : UserControl
    {
        public PanelOne()
        {
            InitializeComponent();
        }

        private void PanelOne_Load(object sender, EventArgs e)
        {

        }

        private void poIOneBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void poITwoBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            var poIOneBox = this.poIOneBox.Text;
            var poITwoBox = this.poITwoBox.Text;

            //parent
            var parent = this.Parent as Form1;
            parent.InputOne = poIOneBox;
            parent.InputTwo = poITwoBox;
        }
    }
}
