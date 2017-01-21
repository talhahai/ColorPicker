using System;
using System.Drawing;
using System.Windows.Forms;

namespace ColorPicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var bitmap = new Bitmap(1, 1))
            {
                using (var graphics = Graphics.FromImage(bitmap))
                {
                    graphics.CopyFromScreen(Cursor.Position, new Point(0, 0), new Size(1, 1));
                }

                int Red = Convert.ToInt32(bitmap.GetPixel(0, 0).R);
                int Green = Convert.ToInt32(bitmap.GetPixel(0, 0).G);
                int Blue = Convert.ToInt32(bitmap.GetPixel(0, 0).B);

                string Color = "#" + Red.ToString("X2") + "" + Green.ToString("X2") + "" + Blue.ToString("X2"); ;

                textBox1.Text = Color;

                textBox2.Text = Red.ToString();
                textBox3.Text = Green.ToString();
                textBox4.Text = Blue.ToString();

                pictureBox1.BackColor = bitmap.GetPixel(0, 0);
                
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
        }
    }
}
