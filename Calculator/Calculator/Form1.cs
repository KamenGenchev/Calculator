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
        string mathopp;
        string input1;
        string input2;
        int inputtemp = 0;

        
        public Form1()
        {
            InitializeComponent();
        }

        public enum MathOperations
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbResult.Text == "0" || input2 != "null")
            {
                tbResult.Text = "0";
            }
            else { tbResult.Text += "0"; }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (tbResult.Text == "0" || input2 != "null")
            {
                tbResult.Text = "2";
            }
            else { tbResult.Text += "2"; }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            input1 = tbResult.Text;
            mathopp = "add";
            inputtemp += 1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            input1 = tbResult.Text;
            mathopp = "sub";
            inputtemp += 1;
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            input1 = tbResult.Text;
            mathopp = "expo";
            inputtemp += 1;
        }

        private void bN1_Click(object sender, EventArgs e)
        {
            if (tbResult.Text == "0" || input2 != "null")
            {
                tbResult.Text = "1";
            }
            else { tbResult.Text += "1"; }
        }

        private void bN3_Click(object sender, EventArgs e)
        {
            if (tbResult.Text == "0" || input2 != "null")
            {
                tbResult.Text = "3";
            }
            else { tbResult.Text += "3"; }
        }

        private void bN4_Click(object sender, EventArgs e)
        {
            if (tbResult.Text == "0" || input2 != "null")
            {
                tbResult.Text = "4";
            }
            else { tbResult.Text += "4"; }
        }

        private void bN5_Click(object sender, EventArgs e)
        {
            if (tbResult.Text == "0" || input2 != "null")
            {
                tbResult.Text = "5";
            }
            else { tbResult.Text += "5"; }
        }

        private void bN6_Click(object sender, EventArgs e)
        {
            if (tbResult.Text == "0" || input2 != "null")
            {
                tbResult.Text = "6";
            }
            else { tbResult.Text += "6"; }
        }

        private void bN7_Click(object sender, EventArgs e)
        {
            if (tbResult.Text == "0" || input2 != "null")
            {
                tbResult.Text = "7";
            }
            else { tbResult.Text += "7"; }
        }

        private void bN8_Click(object sender, EventArgs e)
        {
            if (tbResult.Text == "0"|| input2 != "null")
            {
                tbResult.Text = "8";
            }
            else { tbResult.Text += "8"; }
        }

        private void bN9_Click(object sender, EventArgs e)
        {
            if (tbResult.Text == "0" || input2!="null")
            {
                tbResult.Text = "9";
            }
            else { tbResult.Text += "9"; }
        }

        private void bDot_Click(object sender, EventArgs e)
        {
            tbResult.Text += ".";
        }

        private void bOnCl_Click(object sender, EventArgs e)
        {
            tbResult.Text = "0";
        }

        private void bMul_Click(object sender, EventArgs e)
        {
            input1 = tbResult.Text;
            mathopp = "mul";
            inputtemp += 1;
        }

        private void bDiv_Click(object sender, EventArgs e)
        {
            input1 = tbResult.Text;
            mathopp = "div";
            inputtemp += 1;
        }

        private void bEqual_Click(object sender, EventArgs e)
        {
            double n1;
            double n2;
            double oppresult;
            input2 = tbResult.Text.Replace(input1,"");
            
            n1 = double.Parse(input1);
            n2 = double.Parse(input2);

            switch (mathopp)
            {
                case "add":
                    oppresult = n1 + n2;
                    tbResult.Text = Convert.ToString(oppresult);
                    input2 = "null";
                    break;
                case "sub":
                    oppresult = n1 - n2;
                    tbResult.Text = Convert.ToString(oppresult);
                    input2 = "null";
                    break;
                case "mul":
                    oppresult = n1 * n2;
                    tbResult.Text = Convert.ToString(oppresult);
                    input2 = "null";
                    break;
                case "div":
                    oppresult = n1 / n2;
                    tbResult.Text = Convert.ToString(oppresult);
                    input2 = "null";
                    break;
                case "sqrt":
                    oppresult = n1 * Math.Sqrt(n2);
                         tbResult.Text = Convert.ToString(oppresult);
                    input2 = "null";
                    break;
                case "expo":
                    oppresult = Math.Pow(n1, n2);
                    tbResult.Text = Convert.ToString(oppresult);
                    input2 = "null";
                    break;


            }
        }

        private void bSquare_Click(object sender, EventArgs e)
        {
            input1 = tbResult.Text;
            mathopp = "sqrt";
            inputtemp += 1;
        }
    }
}
    

