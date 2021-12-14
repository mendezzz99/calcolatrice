using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcolatrice
{
    public partial class Form1 : Form
    {
        public double n1 = 0;
        public double n2 = 0;
        public bool operatore = false;
        public int operazioneAritmetica = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //1
        {
            if (operatore == true)
            {
                textBox1.Text = "" + 1;
                operatore = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (operatore == true)
            {
                textBox1.Text = "" + 2;
                operatore = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + 2;
            }
        }

        private void button3_Click(object sender, EventArgs e) //3
        {
            if (operatore == true)
            {
                textBox1.Text = "" + 3;
                operatore = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + 3;
            }
        }

        private void button5_Click(object sender, EventArgs e) //4
        {
            if (operatore == true)
            {
                textBox1.Text = "" + 4;
                operatore = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + 4;
            }
        }

        private void button8_Click(object sender, EventArgs e) //5
        {
            if (operatore == true)
            {
                textBox1.Text = "" + 5;
                operatore = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + 5;
            }
        }

        private void button12_Click(object sender, EventArgs e) //6
        {
            if (operatore == true)
            {
                textBox1.Text = "" + 6;
                operatore = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + 6;
            }
        }

        private void button6_Click(object sender, EventArgs e) //7
        {
            if (operatore == true)
            {
                textBox1.Text = "" + 7;
                operatore = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + 7;
            }
        }

        private void button7_Click(object sender, EventArgs e) //8
        {
            if (operatore == true)
            {
                textBox1.Text = "" + 8;
                operatore = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + 8;
            }
        }

        private void button9_Click(object sender, EventArgs e) //9
        {
            if (operatore == true)
            {
                textBox1.Text = "" + 9;
                operatore = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + 9;
            }
        }

        private void button13_Click(object sender, EventArgs e) //0
        {
            if (operatore == true)
            {
                textBox1.Text = "" + 0;
                operatore = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + 0;
            }
        }


        private void button14_Click(object sender, EventArgs e) // punto
        {
            if (operatore == true)
            {
                textBox1.Text = "" + ",";
                operatore = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + ",";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) //testo
        {

        }

        private void button10_Click(object sender, EventArgs e) //+
        {
            if (n1 == 0)

            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "0";
                }
                n1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(n1);
                operatore = true;
                operazioneAritmetica = 1;
            }
            else
            {
                n2 = Convert.ToDouble(textBox1.Text);
                n1 = n1 + n2;
                textBox1.Text = Convert.ToString(n1);
                operatore = true;
                operazioneAritmetica = 1;

            }

        }

        private void button11_Click(object sender, EventArgs e) //-
        {
            if (n1 == 0)

            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "0";
                }
                n1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(n1);
                operatore = true;
                operazioneAritmetica = 2;
            }
            else
            {
                n2 = Convert.ToDouble(textBox1.Text);
                n1 = n1 + n2;
                textBox1.Text = Convert.ToString(n1);
                operatore = true;
                operazioneAritmetica = 2;

            }
        }

        private void button4_Click(object sender, EventArgs e) //*
        {
            if (n1 == 0)

            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "0";
                }
                n1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(n1);
                operatore = true;
                operazioneAritmetica = 3;
            }
            else
            {
                n2 = Convert.ToDouble(textBox1.Text);
                n1 = n1 + n2;
                textBox1.Text = Convert.ToString(n1);
                operatore = true;
                operazioneAritmetica = 3;

            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (n1 == 0)

            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "0";
                }
                n1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(n1);
                operatore = true;
                operazioneAritmetica = 4;
            }
            else
            {
                n2 = Convert.ToDouble(textBox1.Text);
                n1 = n1 + n2;
                textBox1.Text = Convert.ToString(n1);
                operatore = true;
                operazioneAritmetica = 4;

            }
        }

        private void button16_Click(object sender, EventArgs e) //uguale
        {
            switch (operazioneAritmetica)
            {
                case 1:
                    n2 = Convert.ToDouble(textBox1.Text);
                    n1 = n1 + n2;
                    textBox1.Text = Convert.ToString(n1);
                    n1 = 0;
                    n2 = 0;
                    operatore = true;
                    operazioneAritmetica = 5; break;
                case 2:
                    n2 = Convert.ToDouble(textBox1.Text);
                    n1 = n1 - n2;
                    textBox1.Text = Convert.ToString(n1);
                    n1 = 0;
                    n2 = 0;
                    operatore = true;
                    operazioneAritmetica = 5; break;
                case 3:
                    n2 = Convert.ToDouble(textBox1.Text);
                    n1 = n1 * n2;
                    textBox1.Text = Convert.ToString(n1);
                    n1 = 0;
                    n2 = 0;
                    operatore = true;
                    operazioneAritmetica = 5; break;
                case 4:
                    n2 = Convert.ToDouble(textBox1.Text);
                    n1 = n1 / n2;
                    textBox1.Text = Convert.ToString(n1);
                    n1 = 0;
                    n2 = 0;
                    operatore = true;
                    operazioneAritmetica = 5; break;
                case 5:
                    textBox1.Text = textBox1.Text; break;

            }
        }

        private void button17_Click(object sender, EventArgs e) //cancella
        {
            n1 = 0;
            n2 = 0;
            operatore = false;
            operazioneAritmetica = 0;
            textBox1.Text = "";
        }

       
    }   
}
