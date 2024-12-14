using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinearAlgebraCalculatorr
{
    public partial class inverseForm2 : Form
    {
        public inverseForm2()
        {
            InitializeComponent();
        }

        private void inverseForm2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[,] matrix1 = { { double.Parse(textBox1.Text), double.Parse(textBox2.Text),double.Parse(textBox3.Text)},
                                  {double.Parse(textBox4.Text), double.Parse(textBox5.Text),double.Parse(textBox6.Text)},
                                  {double.Parse(textBox7.Text), double.Parse(textBox8.Text),double.Parse(textBox9.Text) } };
            
        }
    }
}
