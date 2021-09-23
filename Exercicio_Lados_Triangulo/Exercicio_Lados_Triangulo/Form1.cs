using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_Lados_Triangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double lado1, lado2, lado3;
            string resultado = "Triangulo Isósceles";

            //Variáves que guardam os valores vindos do Fomrulário
            lado1 = double.Parse(txtLado1.Text);
            lado2 = double.Parse(txtLado2.Text);
            lado3 = double.Parse(txtLado3.Text);

            //Verificação sempre feita com 0 para saber se esse triangulo é válido
            if (lado1 <= 0 || lado2 <= 0 || lado3 <= 0 || lado1 + lado2 <= lado3 || lado1 + lado3 <= lado2 || lado2 + lado3 <= lado1)
            {
                resultado = "Isto não é um triângulo";                
            }
            else if (lado1 == lado2 && lado2 == lado3) 
            {
                resultado = "Isto é um Triângulo Equilátero";               
            }
            else if (lado1 != lado2 && lado2 != lado3 && lado1 != lado3)
            {
                resultado = "Isto é um Triângulo Escaleno";                
            }
           //Caso não caia em nenhuma das opções assume-se que seja Isósceles. Poderia ter feito os ifs para os tipos e caso não fosse o caso 
           //assumiria que não é um triangulo válido.

            lblResultado.Text = resultado;
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
