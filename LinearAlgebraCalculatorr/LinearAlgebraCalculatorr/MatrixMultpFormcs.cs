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
    public partial class MatrixMultpFormcs : Form
    {
        public MatrixMultpFormcs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[,] matrix1 = { { double.Parse(textBox1.Text), double.Parse(textBox2.Text),double.Parse(textBox3.Text)},
                                  {double.Parse(textBox4.Text), double.Parse(textBox5.Text),double.Parse(textBox6.Text)},
                                  {double.Parse(textBox7.Text), double.Parse(textBox8.Text),double.Parse(textBox9.Text) } };

            double[,] matrix2 = { { double.Parse(textBox10.Text), double.Parse(textBox11.Text),double.Parse(textBox12.Text)},
                                  {double.Parse(textBox13.Text), double.Parse(textBox14.Text),double.Parse(textBox15.Text)},
                                  {double.Parse(textBox16.Text), double.Parse(textBox17.Text),double.Parse(textBox18.Text) } };
            double[,] result = LinearAlgebraFormulas.MatrixMultp(matrix1, matrix2);
            textBox19.Text = result[0, 0].ToString();
            textBox20.Text = result[0, 1].ToString();
            textBox21.Text = result[0, 2].ToString();
            textBox22.Text = result[1, 0].ToString();
            textBox23.Text = result[1, 1].ToString();
            textBox24.Text = result[1, 2].ToString();
            textBox25.Text = result[2, 0].ToString();
            textBox26.Text = result[2, 1].ToString();
            textBox27.Text = result[2, 2].ToString();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
