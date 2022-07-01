using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Delegate_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double FirstNumber;
        string Operation;
       
        //numbers 
        private void bt_1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void bt_2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void bt_3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void bt_4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void bt_5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void bt_6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void bt_7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void bt_8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void bt_9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void bt_dot_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }
      
        private void bt_0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }
        //clear button
        private void bt_clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
        //operations
        private void bt_plus_Click(object sender, EventArgs e)
        {

            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            Operation = "+";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            Operation = "-";
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            Operation = "*";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            Operation = "/";
        }

        // Equal button
        private void equal_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(textBox1.Text);
           
            if (Operation == "+")
            {
                Class1.MathDelegate mathDelegate = Class1.Add;
                Result = mathDelegate(FirstNumber,SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Class1.MathDelegate mathDelegate = Class1.Subtract;
                Result = (FirstNumber - SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Class1.MathDelegate mathDelegate = Class1.Multiply;
                Result = (FirstNumber * SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    textBox1.Text = "Cannot divide by zero";

                }
                else
                {
                    Class1.MathDelegate mathDelegate = Class1.Divide;
                    Result = (FirstNumber / SecondNumber);
                    textBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
        }

       
    }
}
