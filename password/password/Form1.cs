using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace password
{
    public partial class Form1 : Form
    {
        string[] lines = System.IO.File.ReadAllLines("new.txt");
        List<string> username = new List<string>();
        List<string> pass = new List<string>();
         
        String[] l = new string[2];
        public Form1()
        {
            InitializeComponent();
            textBox2.UseSystemPasswordChar = false;
            textBox2.PasswordChar = '$';
            foreach (String line in lines)
            {
                l = line.Split(',');
                username.Add(l[0]);
                pass.Add(l[1]);
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            String us = textBox1.Text;
            String ps = textBox2.Text;
            textBox1.Text = "";
            textBox2.Text = "";
            if(username.Contains(us))
            {
                int i = username.IndexOf(us);
                if(ps==pass[i])
                {
                    MessageBox.Show("You are Logged in");
                }
                else
                {
                    MessageBox.Show("Incorrect Password");
                }
            }
            else
            {
                MessageBox.Show("Invalid Username");
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
