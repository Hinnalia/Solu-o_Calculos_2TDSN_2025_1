using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Calculos_2TDSN_2025_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            lblSinal.Text = "+";
            double a, b;
            try
            {
                a = double.Parse(txtN1.Text);
                b = double.Parse(txtN2.Text);

                lblResultado.Text = (a + b).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show(this, "Favor apenas números", "Erro!!!");
            }
        }
           

        private void txtN1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtN2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void blbResultado_Click(object sender, EventArgs e)
        {

        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtN1.Clear();
            txtN2.Clear();
            lblSinal.Text = "?";
            lblResultado.Text = "?";   
            txtN1.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSubtrair_Click_1(object sender, EventArgs e)
        {
            lblSinal.Text = "-";
            double a, b;
            try
            {
                a = double.Parse(txtN1.Text);
                b = double.Parse(txtN2.Text);

                lblResultado.Text = (a - b).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show(this, "Favor apenas números", "Erro!!!");
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            lblSinal.Text = "x";
            double a, b;
            try
            {
                a = double.Parse(txtN1.Text);
                b = double.Parse(txtN2.Text);

                lblResultado.Text = (a * b).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show(this, "Favor apenas números", "Erro!!!");
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            lblSinal.Text = "%";
            decimal a, b;
            try
            {
                a = decimal.Parse(txtN1.Text);
                b = decimal.Parse(txtN2.Text);

                lblResultado.Text = (a / b).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show(this, "Favor apenas números", "Erro!!!");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show(this, "Impossível divir zero");
            }
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSubtrair_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
