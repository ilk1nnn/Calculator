using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    

        private void dividebtn_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text.Length != 0)
            {
                guna2TextBox1.Text += "/";
            }
        }

        private void one_btn_Click(object sender, EventArgs e)
        {
            
            guna2TextBox1.Text += one_btn.Text;
        }

        private void two_btn_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += two_btn.Text;
        }

        private void three_btn_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += three_btn.Text;
        }

        private void four_btn_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += four_btn.Text;
        }

        private void five_btn_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += five_btn.Text;
        }

        private void six_btn_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += six_btn.Text;
        }

        private void seven_btn_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += seven_btn.Text;
        }

        private void eigth_btn_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += eigth_btn.Text;
        }

        private void nine_btn_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += nine_btn.Text;
        }

        private void zero_btn_Click(object sender, EventArgs e)
        {
            if(guna2TextBox1.Text.Length!=0)
            {
                guna2TextBox1.Text += zero_btn.Text;
            }
            else
            {
                guna2TextBox1.Text =String.Empty;
            }

        }

        private void AC_btn_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text = string.Empty;
        }

        private void plusbtn_Click(object sender, EventArgs e)
        {
            double first_number = double.Parse(guna2TextBox1.Text);
            if(guna2TextBox1.Text.Length!=0)
            {
                guna2TextBox1.Text += "+";
            }

        }

        private void equalbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void minusbtn_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text.Length != 0)
            {
                guna2TextBox1.Text += "-";
            }
        }

        private void multbtn_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text.Length != 0)
            {
                guna2TextBox1.Text += "*";
            }
        }
    }
}
