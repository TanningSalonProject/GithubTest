using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        double no1, no2;
        String sign;
        bool equalClicked;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn15_Click(object sender, EventArgs e) //equals
        {
            no2 = no1;
            no2 += double.Parse(txtdisplay.Text);
        }

        private void btn12_Click(object sender, EventArgs e) //minus
        {

        }

        private void btn11_Click(object sender, EventArgs e) //add
        {
            no1 += double.Parse(txtdisplay.Text); 
            txtdisplay.Clear();
            //txtdisplay2.Clear();
            equalClicked = false;
        }

        private void btn13_Click(object sender, EventArgs e) //multiply
        {

        }

        private void btn14_Click(object sender, EventArgs e) //divide
        {

        }

        private void btn16_Click(object sender, EventArgs e) //clear
        {
            txtdisplay.Clear();
            txtdisplay2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn1 = (Button)sender;

            txtdisplay.Text += btn1.Text;
            //txtdisplay2.Text += btn1.Text;
        }


    }
}
