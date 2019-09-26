using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 

namespace Image
{
    public partial class Form1 : Form
    {
        System.Drawing.Image newImage = System.Drawing.Image.FromFile("goku.jpg");
      
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Width = newImage.Width;
            pictureBox1.Height = newImage.Height;
            pictureBox1.Image = newImage;
            pictureBox2.Width = newImage.Width;
            pictureBox2.Height = newImage.Height;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap(newImage);
            Color c;

            for(int i =0;i<b.Width;i++)
            {
                for(int j=0;j<b.Height;j++)
                {
                    c = b.GetPixel(i, j);
                    byte gray = (byte)(.299 * c.R + .587 * c.G + .114 * c.B);

                    b.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                }
            }
            pictureBox2.Image = b;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            int x, y;
            x = MousePosition.X;
            y = MousePosition.Y;
            Bitmap b1 = new Bitmap(newImage);
            MessageBox.Show(MousePosition.ToString());
        }
    }
}
