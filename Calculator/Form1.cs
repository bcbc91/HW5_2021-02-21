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
        private double Input1;
        private double Input2;
        private string Op;
        private double Result;
        public Form1()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (tb.Text == "0")
            {
                tb.Text = "1";
            }
            else
            {
                tb.Text = tb.Text + "1";
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (tb.Text == "0")
            {
                tb.Text = "2";
            }
            else
            {
                tb.Text = tb.Text + "2";
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (tb.Text == "0")
            {
                tb.Text = "3";
            }
            else
            {
                tb.Text = tb.Text + "3";
            }
        }

        private void b4_Click(object sender, EventArgs e)
        {
            if (tb.Text == "0")
            {
                tb.Text = "4";
            }
            else
            {
                tb.Text = tb.Text + "4";
            }
        }

        private void b5_Click(object sender, EventArgs e)
        {
            if (tb.Text == "0")
            {
                tb.Text = "5";
            }
            else
            {
                tb.Text = tb.Text + "5";
            }
        }

        private void b6_Click(object sender, EventArgs e)
        {
            if (tb.Text == "0")
            {
                tb.Text = "6";
            }
            else
            {
                tb.Text = tb.Text + "6";
            }
        }

        private void b7_Click(object sender, EventArgs e)
        {
            if (tb.Text == "0")
            {
                tb.Text = "7";
            }
            else
            {
                tb.Text = tb.Text + "7";
            }
        }

        private void b8_Click(object sender, EventArgs e)
        {
            if (tb.Text == "0")
            {
                tb.Text = "8";
            }
            else
            {
                tb.Text = tb.Text + "8";

            }
        }

        private void b9_Click(object sender, EventArgs e)
        {
            if (tb.Text == "0")
            {
                tb.Text = "9";
            }
            else
            {
                tb.Text = tb.Text + "9";
            }
        }

        private void b0_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "0";
        }

        private void bSum_Click(object sender, EventArgs e)
        {
            Input1 = Double.Parse(tb.Text);
            Op = "+";
            tb.Text = "0";
        }

        private void bSub_Click(object sender, EventArgs e)
        {
            Input1 = Double.Parse(tb.Text);
            Op = "-";
            tb.Text = "0";
        }

        private void bMul_Click(object sender, EventArgs e)
        {
            Input1 = Double.Parse(tb.Text);
            Op = "*";
            tb.Text = "0";
        }

        private void bDiv_Click(object sender, EventArgs e)
        {
            Input1 = Double.Parse(tb.Text);
            Op = "/";
            tb.Text = "0";
        }

        private void bSqrt_Click(object sender, EventArgs e)
        {
            Input1 = Double.Parse(tb.Text);
            Result = Math.Sqrt(Input1);
            tb.Text = Result.ToString();
            Input1 = Result;
        }

        private void bLog_Click(object sender, EventArgs e)
        {
            Input1 = Double.Parse(tb.Text);
            Op = "log";
            tb.Text = "0";
        }

        private void bLn_Click(object sender, EventArgs e)
        {
            Input1 = Double.Parse(tb.Text);
            
            Result = Math.Log(Input1, Math.E);
            tb.Text = Result.ToString();
            Input1 = Result;
        }
        private void bF_Click(object sender, EventArgs e)
        {
            Input1 = Double.Parse(tb.Text);
            for (double i = Input1-1; i >= 1; i--)
            {
                Input1 = Input1 * i;

            }

            tb.Text = Input1.ToString();
            
        }
        private void bSq_Click(object sender, EventArgs e)
        {
            Input1= Double.Parse(tb.Text);
            Result = Math.Pow(Input1, 2.0);
            tb.Text = Result.ToString();
            Input1 = Result;
        }
        private void bSin_Click(object sender, EventArgs e)
        {
            Input1 = Double.Parse(tb.Text);
            Result = Math.Sin((Input1 * Math.PI) / 180);
            tb.Text = Result.ToString();
            Input1 = Result;
        }

        private void bCos_Click(object sender, EventArgs e)
        {
            Input1 = Double.Parse(tb.Text);
            Result = Math.Cos((Input1*Math.PI)/180);
            tb.Text = Result.ToString();
            Input1 = Result;
        }

        private void bTan_Click(object sender, EventArgs e)
        {
            Input1 = Double.Parse(tb.Text);
            Result = Math.Tan((Input1 * Math.PI) / 180);
            tb.Text = Result.ToString();
            Input1 = Result;
        }

        private void bCot_Click(object sender, EventArgs e)
        {
            Input1 = Double.Parse(tb.Text);
            Result = 1/Math.Tan((Input1 * Math.PI) / 180);
            tb.Text = Result.ToString();
            Input1 = Result;
        }

        private void bPow_Click(object sender, EventArgs e)
        {
            Input1 = Double.Parse(tb.Text);
            Op = "pow";
            tb.Text = "0";
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            tb.Text = "0";
        }

        private void bDot_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + ",";
        }

        private void bEq_Click(object sender, EventArgs e)
        {
            Input2 = Double.Parse(tb.Text);
            if (Op == "+")
            {
                Result = Input1 + Input2;
                tb.Text = Result.ToString();
                Input1 = Result;
            }

            if (Op == "-")
            {
                Result = Input1 - Input2;
                tb.Text = Result.ToString();
                Input1 = Result;
            }

            if (Op == "*")
            {
                Result = Input1 * Input2;
                tb.Text = Result.ToString();
                Input1 = Result;
            }

            if (Op=="/")
            {
                Result = Input1 / Input2;
                tb.Text = Result.ToString();
                Input1 = Result;
            }

           

            if (Op=="log")
            {
                Result = Math.Log(Input1, Input2);
                tb.Text = Result.ToString();
                Input1 = Result;
            }

           

            if (Op=="pow")
            {
                Result = Math.Pow(Input1, Input2);
                tb.Text = Result.ToString();
                Input1 = Result;

                
            }
        }

       
    }
}
