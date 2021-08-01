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
        static double firstNumber=0;
        static int Number=0;
        public Form1()
        {
            InitializeComponent();
        }

     

        private void Btn0_Click(object sender, EventArgs e)
        {
            if (label.Text == "0")
            {
                label.Text = "0";
            }
            else if (label.Text ==null && label.Text == "")
            {
                label.Text = "0";
            }
            else if (label.Text != null && label.Text != "0")
            {
                double new_labelText = double.Parse(label.Text);
                new_labelText = new_labelText * 10;
                label.Text = $"{new_labelText}";

            }
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (label.Text == "0")
            {
                label.Text = "1";
            }
            else if (label.Text == null && label.Text == "")
            {
                label.Text = "1";
            }
            else if (label.Text != null && label.Text != "0")
            {
                label.Text = label.Text + "1";
            }
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (label.Text == "0")
            {
                label.Text = "2";
            }
            else if (label.Text == null && label.Text == "")
            {
                label.Text = "2";
            }
            else if (label.Text != null && label.Text != "0")
            {
                label.Text = label.Text + "2";

            }
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (label.Text == "0")
            {
                label.Text = "3";
            }
            else if (label.Text == null && label.Text == "")
            {
                label.Text = "3";
            }
            else if (label.Text != null && label.Text != "0")
            {
                label.Text = label.Text + "3";

            }
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (label.Text == "0")
            {
                label.Text = "4";
            }
            else if (label.Text == null && label.Text == "")
            {
                label.Text = "4";
            }
            else if (label.Text != null && label.Text != "0")
            {
                label.Text = label.Text + "4";

            }
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (label.Text == "0")
            {
                label.Text = "5";
            }
            else if (label.Text == null && label.Text == "")
            {
                label.Text = "5";
            }
            else if (label.Text != null && label.Text != "0")
            {
                label.Text = label.Text + "5";

            }
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (label.Text == "0")
            {
                label.Text = "6";
            }
            else if (label.Text == null && label.Text == "")
            {
                label.Text = "6";
            }
            else if (label.Text != null && label.Text != "0")
            {
                label.Text = label.Text + "6";

            }
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (label.Text == "0")
            {
                label.Text = "7";
            }
            else if (label.Text == null && label.Text == "")
            {
                label.Text = "7";
            }
            else if (label.Text != null && label.Text != "0")
            {
                label.Text = label.Text + "7";

            }
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (label.Text == "0")
            {
                label.Text = "8";
            }
            else if (label.Text == null && label.Text == "")
            {
                label.Text = "8";
            }
            else if (label.Text != null && label.Text != "0")
            {
                label.Text = label.Text + "8";

            }
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (label.Text == "0")
            {
                label.Text = "9";
            }
            else if (label.Text == null&&label.Text=="")
            {
                label.Text = "9";
            }
            else if (label.Text != null && label.Text != "0" )
            {
                label.Text = label.Text + "9";

            }
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            if (label.Text != null)
            {
                firstNumber = double.Parse(label.Text);
                label.Text = "0";
                Number = 1;
            }
            else
            {
                firstNumber = 0;
                label.Text = "0";
                Number = 1;
            }
        }

        private void XBtn_Click(object sender, EventArgs e)
        {
            if (label.Text != null)
            {
                firstNumber = double.Parse(label.Text);
                label.Text = "0";
                Number = 3;
            }
            else
            {
                firstNumber = 0;
                label.Text = "0";
                Number = 3;
            }
        }
        private void BtnBolme_Click(object sender, EventArgs e)
        {
            if (label.Text != null)
            {
                firstNumber = double.Parse(label.Text);
                label.Text = "0";
                Number = 4;
            }
            else
            {
                firstNumber = 0;
                label.Text = "0";
                Number = 4;
            }
        }
        private void _Btn_Click(object sender, EventArgs e)
        {
            if (label.Text != null)
            {
                firstNumber = double.Parse(label.Text);
                label.Text = "0";
                Number = 2;
            }
            else
            {
                firstNumber = 0;
                label.Text = "0";
                Number = 2;
            }
        }
        private void BtnNotice_Click(object sender, EventArgs e)
        {
            double sum = double.Parse(label.Text);
            label.Text = "0";
            if (Number == 1)
            {
            label.Text = $"{firstNumber + sum}";
            }
            else if (Number == 2)
            {
                label.Text = $"{firstNumber - sum}";
            }
            else if (Number == 3)
            {
                label.Text = $"{firstNumber * sum}";
            }
            else if (Number == 4)
            {
                label.Text = $"{firstNumber / sum}";
            }
            else
            {
                label.Text = $"{sum}";
            }
            firstNumber = 0;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int count = 0;
            double notice = double.Parse(label.Text);
            if (notice == (int)notice)
            {
                notice =(int)notice/10;
            }
            else if (notice != (int)notice)
            {
                bool a = true;
                while (a)
                {
                    if (notice * 10 != (int)notice * 10)
                    {
                        notice *= 10;
                        ++count;
                    }
                    else
                    {
                        notice = (int)notice / 10;
                        for (int i = 0; i < count-1; i++)
                        {
                            notice /= 10;
                        }
                        a = false;
                    }
                }

            }
            label.Text = $"{notice}";
        }

        private void BtnKvadrat_Click(object sender, EventArgs e)
        {
            double sum = double.Parse(label.Text);
            sum *= sum;
            label.Text = $"{sum}";
        }

        private void BtnAllDelete_Click(object sender, EventArgs e)
        {
            label.Text = "0";
        }

        private void BtnMenfi_Click(object sender, EventArgs e)
        {
            double sum = double.Parse(label.Text);
            sum = (-sum);
            label.Text = $"{sum}";
        }

        private void BtnNokte_Click(object sender, EventArgs e)
        {
            label.Text = label.Text + ".";
            
        }
    }
}
