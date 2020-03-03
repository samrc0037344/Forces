using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double sin(double x)
        {
            return (Math.Sin(x * Math.PI / 180.0));
        }

        double cos(double x)
        {
            return (Math.Cos(x * Math.PI / 180.0));
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double Force, Angle;
            // Parse means read this text as a number so it turns text into a number, this code reads whats in the text box and  
            try
            {
                double Force = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Type a number in the Force box, you doofus!");
            }
            Angle = double.Parse(textBox2.Text);


            // Calculates Fx and Fy
            double Fx = Force * cos(Angle);
            double Fy = Force * sin(Angle);

            //put values for Fx and Fy in lables
            lable1.Text = "Fx = " + Fx + " N";
            lable2.Text = "Fy = " + Fy + " N";
        }
    }
}
