using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
bool stuff = false;


namespace NuclearReactors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void outputLabel_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            
            if (stuff == false)
            {
                stuff = true;
            }
            else
            {
                stuff = false;
            }


            reactor1stateLabel.BackColor = Color.Red;
            reactor2stateLabel.BackColor = Color.Red;
            
            outputLabel.Text = "MELTDOWN";
            outputLabel.ForeColor = Color.Red;

            Refresh();
            Thread.Sleep(1000);

            reactor1stateLabel.BackColor = Color.White;
            reactor2stateLabel.BackColor = Color.White;

            outputLabel.ForeColor = Color.Black;



            reactor1stateLabel.BackColor = Color.Lime;
            reactor2stateLabel.BackColor = Color.Lime;
            outputLabel.Text = "Reactors Stable";


        }
    }
}
