using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using static System.Math;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Num1_Click(object sender, EventArgs e)
        {
            Output.Text += "1";
        }

        private void Num2_Click(object sender, EventArgs e)
        {
            Output.Text += "2";
        }

        private void Num3_Click(object sender, EventArgs e)
        {
            Output.Text += "3";
        }

        private void Num4_Click(object sender, EventArgs e)
        {
            Output.Text += "4";
        }
        private void Button12_Click(object sender, EventArgs e)
        {
            Output.Text += "5";
        }
        private void Button13_Click(object sender, EventArgs e)
        {
            Output.Text += "6";
        }

        private void Num7_Click(object sender, EventArgs e)
        {
            Output.Text += "7";
        }

        private void Num8_Click(object sender, EventArgs e)
        {
            Output.Text += "8";
        }

        private void Num9_Click(object sender, EventArgs e)
        {
            Output.Text += "9";
        }

        private void Num0_Click(object sender, EventArgs e)
        {
            Output.Text += "0";
        }

        private void DotBut_Click(object sender, EventArgs e)
        {
            int len = Output.Text.Length;
            if (Output.Text[--len] != '.') 
            {
                Output.Text += ".";
            }
        }

        private void ClearBut_Click(object sender, EventArgs e)
        {
            Output.Text = "";
        }

        private void SumBut_Click(object sender, EventArgs e)
        {
            Output.Text += "+";
        }

        private void MinBut_Click(object sender, EventArgs e)
        {
            Output.Text += "-";
        }

        private void MulBut_Click(object sender, EventArgs e)
        {
            Output.Text += "*";
        }

        private void DivBut_Click(object sender, EventArgs e)
        {
            Output.Text += "/";
        }

        private void SQRT_Click(object sender, EventArgs e)
        {
            try
            {
                double ans = Sqrt(Double.Parse(Output.Text));
                Output.Text = ans.ToString();
            }
            catch(Exception E) 
            {
                MessageBox.Show(E.Message);
            }
        }

        private void Pow_Click(object sender, EventArgs e)
        {
            try
            {
                double ans = Pow(Double.Parse(Output.Text), 2 );
                Output.Text = ans.ToString();
            }
            catch(Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void Sum_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable Calc = new DataTable();
                var ans = Calc.Compute(Output.Text, "");
                Output.Text = ans.ToString();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
    }
}
