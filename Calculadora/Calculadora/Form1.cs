using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class 
        Form1 : Form
    {
        double Num1 = 0, Num2 = 0;
        char operador;

        public Form1()
        {
            InitializeComponent();
        }
        private void agregarNumero(object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            if (txtResultado.Text == "0")
                txtResultado.Text = "";

            txtResultado.Text += boton.Text;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            Num2 = Convert.ToDouble(txtResultado.Text);

            if (operador == '+')
            {
                txtResultado.Text = (Num1+ Num2).ToString();
                Num1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (operador == '-')
            {
                txtResultado.Text = (Num1 - Num2).ToString();
                Num1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (operador == 'X')
            {
                txtResultado.Text = (Num1 * Num2).ToString();
                Num1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (operador == '∕')
            {
                if (txtResultado.Text != "0")
                { 
                txtResultado.Text = (Num1 / Num2).ToString();
                Num1 = Convert.ToDouble(txtResultado.Text);
                }
                else
                {
                    MessageBox.Show("No se puede dividir por cero");
                }
            }
        }

        private void btnrr_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Length > 1)
            {
                txtResultado.Text = txtResultado.Text.Substring(0, txtResultado.Text.Length - 1);
            }
            else
            {
                txtResultado.Text = "0";
            }
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            Num1 = 0;
            Num2 = 0;
            operador = '\0';
            txtResultado.Text = "0";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "0";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains("."))
            {
                txtResultado.Text += ".";
            }
        }

        private void btnSigno_Click(object sender, EventArgs e)
        {
            Num1 = Convert.ToDouble(txtResultado.Text);
            Num1 *= -1;
            txtResultado.Text = Num1.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void clickOperador(object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            Num1 = Convert.ToDouble(txtResultado.Text);
            operador = Convert.ToChar(boton.Tag);
            if (operador == '²')
            {
                Num1 = Math.Pow(Num1, 2);
                txtResultado.Text = Num1.ToString();
            }
            else if (operador == '√')
            {
                Num1 = Math.Sqrt(Num1);
                txtResultado.Text = Num1.ToString();
            }
            else
            

            txtResultado.Text = "0";
        }
    }
}
