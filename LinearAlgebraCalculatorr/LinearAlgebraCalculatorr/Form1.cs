namespace LinearAlgebraCalculatorr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Determinant newForm = new Determinant();
            newForm.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //Matrix Multp
            MatrixMultpFormcs newForm = new MatrixMultpFormcs();
            newForm.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            inverseForm2 newForm = new inverseForm2();
            newForm.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            toRowEhalonForm newform = new toRowEhalonForm();
            newform.Show();
        }
    }
}
