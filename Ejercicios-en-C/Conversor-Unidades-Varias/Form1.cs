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
    String[][] etiquetas = {
        new string[]{"Metros", "Centímetros", "Pulgadas", "Pies", "Varas", "Yardas", "Kilómetros", "Millas", "Milímetros", "Hectometros"}, //Longitud (Metros)
        new string[]{"Dólar", "Quetzal","Lempira","Cordobas","Colón CR", "Bolívares", "Yenes", "Pesos Mexicanos", "Bitcoin", "Euros", "Libras Esterlinas"}, //Monedas (Dólares)
        new string[]{"Kilogramos", "Libras", "Onzas", "Quintal", "Toneladas", "Hectogramos", "Miligramos", "Decagramo", "Centigramo", "Decigramo"}, //Masa (Kilogramos)
        new string[]{"Litros", "Mililitros", "Galones", "Barriles", "Metros Cúbicos", "Pie Cúbico", "Tazas Americanas", "Cucharadas Soperas", "Pulgadas Cúbicas", "Onzas Líquidas"}, //Volumen (Litros)
        new string[]{"Megabytes", "Bytes", "Kilobytes", "Gigabytes", "Terabytes", "Petabytes", "Bits", "Gigabits", "Kilobits", "Megabits"}, //Almacenamiento (Megabytes)
        new string[]{"Segundos", "Minutos", "Horas", "Días", "Semanas", "Meses", "Años", "Milisegundos", "Décadas", "Siglos"} //Tiempo (Segundo)
    };

    Double[][] valores = {
        new double[]{1, 100, 39.3701, 3.28084, 1.1963, 1.09361, 0.001, 0.000621371, 1000, 0.01},
        new double[]{1, 7.63, 26.81, 36.80, 449.23, 771.58, 159.26, 17.06, 0.000016, 0.92, 0.74},
        new double[]{1, 2.20462, 35.274, 0.01, 0.001, 10, 1000000, 100, 100000, 10000},
        new double[]{1, 1000, 0.264, 0.00629, 0.001, 0.0353, 4.227, 66.67, 61.024, 33.814},
        new double[]{1, 1048576, 1024, 0.0009765625, 0.0000009536743, 0.0000000009313, 8388608, 0.0078125, 8192, 8},
        new double[]{1, 0.0166666667, 0.0002777778, 0.0000115741, 0.0000016534, 0.0000003805, 0.0000000317, 1000, 0.00000000317, 0.000000000317}
    };
        private void Form1_Load(object sender, EventArgs e) {
        }
        private void btnCalcular_Click(object sender, EventArgs e) {
                
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            int de = cboDe.SelectedIndex, a = cboA.SelectedIndex, opcion = cboOpciones.SelectedIndex;
            double cantidad = Double.Parse(txtCantidad.Text);

            double respuesta = valores[opcion][a] / valores[opcion][de] * cantidad;

            lblRespuesta.Text = respuesta.ToString();
        }

        private void cboOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboDe.Items.Clear();
            cboA.Items.Clear();

            int opcion = cboOpciones.SelectedIndex;
            cboDe.Items.AddRange(etiquetas[opcion]);
            cboA.Items.AddRange(etiquetas[opcion]);

        }
    }
}