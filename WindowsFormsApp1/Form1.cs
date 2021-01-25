using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int operacao;
        double result;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnNumerador_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txt_valor.Text = txt_valor.Text + bt.Text;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdi_Click(object sender, EventArgs e)
        {
            operacao = 1;
            result = Convert.ToDouble(txt_valor.Text);
            txt_valor.Text = "";
        }

        private void btnIgu_Click(object sender, EventArgs e)
        {
            if(operacao == 1)
            {
                Double resultado = Convert.ToDouble(txt_valor.Text) + result;
                txt_valor.Text = Convert.ToString(resultado);
            }
            if (operacao == 2)
            {
                Double resultado = result - Convert.ToDouble(txt_valor.Text);
                txt_valor.Text = Convert.ToString(resultado);
            }
            if (operacao == 3)
            {
                Double resultado = Convert.ToDouble(txt_valor.Text) * result;
                txt_valor.Text = Convert.ToString(resultado);
            }
            if (operacao == 4)
            {
                Double resultado = result / Convert.ToDouble(txt_valor.Text);
                txt_valor.Text = Convert.ToString(resultado);
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            operacao = 2;
            result = Convert.ToDouble(txt_valor.Text);
            txt_valor.Text = "";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            operacao = 3;
            result = Convert.ToDouble(txt_valor.Text);
            txt_valor.Text = "";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operacao = 4;
            result = Convert.ToDouble(txt_valor.Text);
            txt_valor.Text = "";
        }
    }
}
