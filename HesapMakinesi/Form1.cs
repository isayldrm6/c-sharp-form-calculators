using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        double firstNumber;

        string Operation;
        public Form1()
        {
            InitializeComponent();

        }
        
        private void btn_bir_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void btn_iki_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void btn_üç_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void btn_dört_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void btn_beş_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void btn_altı_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void btn_yedi_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void btn_sekiz_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void btn_dokuz_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void btn_sıfır_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }
        private void btn_virgül_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }

        private void btn_topla_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);

            textBox1.Text = null;

            Operation = "+";

        }

        private void btn_cıkar_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);

            textBox1.Text = null;

            Operation = "-";
        }

        private void btn_carp_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);

            textBox1.Text = null;

            Operation = "*";
        }

        private void btn_bol_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);

            textBox1.Text = null;

            Operation = "/";
        }

        private void btn_sonuc_Click(object sender, EventArgs e)
        {
            double SecondNumber;

            double Result;

            SecondNumber = Convert.ToDouble(textBox1.Text);
            if (Operation == "+")
            {
                Result = firstNumber + SecondNumber;
                textBox1.Text = Convert.ToString(Result);
                firstNumber = Result;
            }
            else if (Operation == "-")
            {
                Result = firstNumber - SecondNumber;
                textBox1.Text = Convert.ToString(Result);
                firstNumber = Result;
            }
            else if (Operation == "*")
            {
                Result = firstNumber * SecondNumber;
                textBox1.Text = Convert.ToString(Result);
                firstNumber = Result;
            }
            if (Operation == "/")
                if (SecondNumber == 0)
                {
                    textBox1.Text = "uygulanamaz";
                }
                else
                {
                    Result = firstNumber / SecondNumber;
                    textBox1.Text = Convert.ToString(Result);
                    firstNumber = Result;
                }
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }
    }
}
