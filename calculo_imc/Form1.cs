using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculo_imc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double peso, altura, imc;
            peso = Convert.ToDouble(txtPeso.Text);
            altura = Convert.ToDouble(txtAltura.Text);
            imc = peso / (altura * altura);
            txtImc.Text = imc.ToString("0.00");

            /*Condições de acordo com os resultados dos cálculos
         Serão exibidas mensagens,
         configuração das messagebox, (mensagens, botões, ícones)
         como são várias condições temos um encadeamento de ifs*/
            if (imc < 18.49)
                MessageBox.Show("SITUAÇÃO: Você está abaixo do Peso", "Cálculo de IMC",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (imc < 24.99)
                MessageBox.Show("SITUAÇÃO: Você está com Peso dentro da Normalidade", "Calculo de IMC",
                     MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (imc < 29.99)
                MessageBox.Show("SITUAÇÃO: Você está acima do Peso", "Cálculo de IMC",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (imc < 34.99)
                MessageBox.Show("Atenção!Você está com Obesidade Grau I", "Cálculo de IMC",
               MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else if (imc < 39.99)
                MessageBox.Show("Atenção!Você está com Obesidade Grau II (severa)", "Calculo de IMC" ,
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else
                MessageBox.Show("Atenção!Você está com grau de obesidade Grau III (mórbida)",
               "Cálculo de IMC", MessageBoxButtons.OK, MessageBoxIcon.Stop);
       
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPeso.Text = "";
            txtAltura.Text = "";
            txtImc.Text = "";

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
