using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double filipino = Convert.ToDouble(textBox2.Text);
            double math = Convert.ToDouble(textBox3.Text);
            double english = Convert.ToDouble(textBox4.Text);
            double history = Convert.ToDouble(textBox5.Text);
            double science = Convert.ToDouble(textBox6.Text);

            double sum = filipino + math + english + history + science;
            double totalgrades = sum / 5;
            double average = Math.Round(totalgrades);

            label8.Text = average >= 75.00 ? "The Student Passed. Congrats!!! \nThe general average of the student is " + textBox1.Text +  " " + average : "The Student Failed. Please reach out to your professor!!";




        }
    }
}
