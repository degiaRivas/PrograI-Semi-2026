using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miDecimaAplicacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1=0, num2=0, resultado=0;
            num1 = Double.Parse(txtNum1.Text);
            num2 = Double.Parse(txtNum2.Text);

            if (rdbSuma.Checked) {
                resultado = num1 + num2;
            }
            if (rdbResta.Checked) {
                resultado = num1 - num2;
            }
            if (rdbMultiplicacion.Checked) {
                resultado = num1 * num2;
            }
            if (rdbDivision.Checked) {
                resultado = num1 / num2;
            }
            if (rdbExponente.Checked) {
                resultado = Math.Pow(num1, num2); //Elevar num1 a la potencia num2
            }
            if (rdbRaiz.Checked) {
                resultado = Math.Pow(num1, 1/num2); //Raiz num2 de num1
            }
            if (rdbFactorial.Checked) {
                resultado = 1;
                for(int i = 1; i <= num1; i++) {
                    resultado *= i;
                }
            }
            lblRespuesta.Text = "Respuesta: " + Math.Round(resultado, 2).ToString();
        }
    }
}
