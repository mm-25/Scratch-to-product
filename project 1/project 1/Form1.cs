using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_1
{
    public partial class Form1 : Form
    {
        int opc = 0;
        double v1;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            try
            {
                v1 = Convert.ToDouble(textBox1.Text);
            }
            catch(Exception ex)
            {
                textBox1.Text = "";
                MessageBox.Show("Enter a Number","Invalid Input",MessageBoxButtons.OK);
            }
           
            textBox1.Text="";
            opc = 1;
        }

        private void Button18_Click(object sender, EventArgs e)
        {

            try
            {
                v1 = Convert.ToDouble(textBox1.Text);
            }
            catch (Exception ex)
            {
                textBox1.Text = "";
                MessageBox.Show("Enter a Number", "Invalid Input", MessageBoxButtons.OK);
            }
            textBox1.Text = "";
            opc = 2;
        }

        private void Button19_Click(object sender, EventArgs e)
        {

            try
            {
                v1 = Convert.ToDouble(textBox1.Text);
            }
            catch (Exception ex)
            {
                textBox1.Text = "";
                MessageBox.Show("Enter a Number", "Invalid Input", MessageBoxButtons.OK);
            }
            textBox1.Text = "";
            opc = 3;
        }

        private void Button15_Click(object sender, EventArgs e)
        {

            try
            {
                v1 = Convert.ToDouble(textBox1.Text);
            }
            catch (Exception ex)
            {
                textBox1.Text = "";
                MessageBox.Show("Enter a Number", "Invalid Input", MessageBoxButtons.OK);
            }
            textBox1.Text = "";
            opc = 4;
        }

        private void Button16_Click(object sender, EventArgs e)
        {

            try
            {
                v1 = Convert.ToDouble(textBox1.Text);
            }
            catch (Exception ex)
            {
                textBox1.Text = "";
                MessageBox.Show("Enter a Number", "Invalid Input", MessageBoxButtons.OK);
            }
            textBox1.Text = (v1 * v1).ToString();
             
        }

        private void Button17_Click(object sender, EventArgs e)
        {

            try
            {
                v1 = Convert.ToDouble(textBox1.Text);
            }
            catch (Exception ex)
            {
                textBox1.Text = "";
                MessageBox.Show("Enter a Number", "Invalid Input", MessageBoxButtons.OK);
            }
            textBox1.Text = Math.Sqrt(v1).ToString();
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }
       
        private void Button1_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void Button12_Click(object sender, EventArgs e)
        {

  
                textBox1.Text += ".";
             
        }

        private void Button10_Click(object sender, EventArgs e)
        {

             
           
                textBox1.Text += "0";
            
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            double v2 = 0;
            try
            {
                v2 = Convert.ToDouble(textBox1.Text);
            }
            catch (Exception ex)
            {
                textBox1.Text = "";
                MessageBox.Show("Enter a Number", "Invalid Input", MessageBoxButtons.OK);
            }
            switch (opc)
            {
                case 1 : textBox1.Text=(v1 + v2).ToString();
                    break;
                case 2:
                    textBox1.Text = (v1 - v2).ToString();
                    break;
                case 3:
                    textBox1.Text = (v1 * v2).ToString();
                    break;
                case 4:
                    textBox1.Text = (v1 / v2).ToString();
                    break;
                default: textBox1.Text = "Invalid operation";
                    break;

            }
        }
    }
}
