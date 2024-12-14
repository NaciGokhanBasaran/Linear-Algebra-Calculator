using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LinearAlgebraCalculatorr
{
    public partial class toRowEhalonForm : Form
    {
        public toRowEhalonForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[,] matrix1 = { { double.Parse(textBox1.Text), double.Parse(textBox2.Text),double.Parse(textBox3.Text)},
                                  {double.Parse(textBox4.Text), double.Parse(textBox5.Text),double.Parse(textBox6.Text)},
                                  {double.Parse(textBox7.Text), double.Parse(textBox8.Text),double.Parse(textBox9.Text) } };
            double[,] result = LinearAlgebraFormulas.ToRowEchelonForm(matrix1);
 
            textBox10.Text = result[0, 0].ToString();
            textBox11.Text = result[0, 1].ToString();
            textBox12.Text = result[0, 2].ToString();
            textBox13.Text = result[1, 0].ToString();
            textBox14.Text = result[1, 1].ToString();
            textBox15.Text = result[1, 2].ToString();
            textBox16.Text = result[2, 0].ToString();
            textBox17.Text = result[2, 1].ToString();
            textBox18.Text = result[2, 2].ToString();
        }
    }
}
