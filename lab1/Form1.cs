using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            var rnd = new Random();
            Color[] color = new Color[] { Color.Red, Color.Green, Color.Yellow, Color.White, Color.Gray, Color.Blue, Color.Cyan, Color.DarkBlue, Color.DarkCyan, Color.DarkGray, Color.DarkBlue, Color.DarkRed, Color.DarkOrange };
            button2.BackColor = color[rnd.Next(0, color.Length)];
            button2.Text = button2.BackColor.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var rnd = new Random();
            Color[] color = new Color[] { Color.Red, Color.Green, Color.Yellow, Color.White, Color.Gray, Color.Blue, Color.Cyan, Color.DarkBlue, Color.DarkCyan, Color.DarkGray, Color.DarkBlue, Color.DarkRed, Color.DarkOrange };
            button1.BackColor = color[rnd.Next(0, color.Length)];
            button1.Text = button1.BackColor.ToString();
        }
        double equ1(double a, double b, double x)
        {
            return (Math.Abs(Math.Sign(a * x + b) - Math.Abs(x - b)));
        }
        double equ2(double z, double x)
        {
            return x - (z / (z - (Math.Pow(x, 2) / 4))) - Math.Pow(x, 2) / 120;
        }

        public void button3_Click(object sender, EventArgs e)
        {
            if (button1.BackColor == Color.White && button2.BackColor == Color.Gray)
            {
                bool resx = int.TryParse(textBox4.Text, out var x);
                bool resa = int.TryParse(textBox3.Text, out var a);
                bool resb = int.TryParse(textBox2.Text, out var b);
                bool resz = int.TryParse(textBox1.Text, out var z);

                if (resx == false | resa == false | resb == false | resz == false)
                {
                    label9.Text = "Неверный формат данных";
                }
                else label9.Text = "  ";

                if (resx == true && resb == true && resa == true && resz == true)
                {
                    label7.Text = "=" + Convert.ToString(equ1(a, b, x));
                    label8.Text = "=" + Convert.ToString(equ2(z, x));
                }
                else
                {
                    label7.Text = "";
                    label8.Text = "";
                }
                    
            }
        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
;
        }
        private void label4_Click(object sender, EventArgs e)
        {
        }
        private void label3_Click(object sender, EventArgs e)
        { 
        }
        public void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {


        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sure?", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
