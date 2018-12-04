using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculating_cubes_and_that
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void work_Click(object sender, EventArgs e)
        {
            try
            {
                double i = double.Parse(box1.Text);
                double a = Math.Pow(i, 1.0 / 3.0);
                box2.Text = a.ToString();
            }
            catch
            {
                MessageBox.Show("put a number in");
            }
        }

        private void work2_Click(object sender, EventArgs e)
        {
            try
            {
                double n1 = double.Parse(box3.Text);
                double n2 = double.Parse(box4.Text);
                double ans = Math.Pow(n1, n2);
                box5.Text = ans.ToString();
            }
            catch
            {
                MessageBox.Show("Enter 2 numbers");
            }
        }
    }
}
