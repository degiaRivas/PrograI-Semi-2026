using System;
using System.Windows.Forms;

namespace ConversorBitcoinCA
{
    public partial class frmConversorPropioBitcon : Form
    {
        // =========================================================================
        // NOTA DE VALOR DE REFERENCIA:
        // El precio del Bitcoin es altamente volátil. 
        // Cotización registrada en la fecha y hora: 25 de agosto de 2026 - 09:48 PM.
        // Tasa base de referencia: 1 BTC = $64,500.00 USD
        // =========================================================================

        private const double PRECIO_BTC_USD = 64500.00;
        private const double TASA_QUETZAL = 7.75;
        private const double TASA_LEMPIRA = 24.65;
        private const double TASA_CORDOBA = 36.60;
        private const double TASA_COLON_CR = 520.50;

        public frmConversorPropioBitcon()
        {
            InitializeComponent();
            PrepararFormulario();
        }

        private void PrepararFormulario()
        {
            if (cmbMonedas.Items.Count == 0)
            {
                cmbMonedas.Items.Add("Dólares (USD)");
                cmbMonedas.Items.Add("Quetzales (GTQ)");
                cmbMonedas.Items.Add("Lempiras (HNL)");
                cmbMonedas.Items.Add("Córdobas (NIO)");
                cmbMonedas.Items.Add("Colones CR (CRC)");
            }

            cmbMonedas.SelectedIndex = 0;
            lblResultado.Text = "Resultado: ---";
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtBitcoin.Text, out double bitcoins) || bitcoins < 0)
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida de Bitcoin.",
                                "Error de entrada",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtBitcoin.Focus();
                return;
            }

            double valorEnUSD = bitcoins * PRECIO_BTC_USD;
            double resultadoFinal = 0;
            string simboloMoneda = "";

            switch (cmbMonedas.SelectedIndex)
            {
                case 0: // Dólares
                    resultadoFinal = valorEnUSD;
                    simboloMoneda = "$";
                    break;

                case 1: // Quetzales
                    resultadoFinal = valorEnUSD * TASA_QUETZAL;
                    simboloMoneda = "Q";
                    break;

                case 2: // Lempiras
                    resultadoFinal = valorEnUSD * TASA_LEMPIRA;
                    simboloMoneda = "L";
                    break;

                case 3: // Córdobas
                    resultadoFinal = valorEnUSD * TASA_CORDOBA;
                    simboloMoneda = "C$";
                    break;

                case 4: // Colones costarricenses
                    resultadoFinal = valorEnUSD * TASA_COLON_CR;
                    simboloMoneda = "₡";
                    break;

                default:
                    MessageBox.Show("Seleccione una moneda de la lista.", "Atención");
                    return;
            }

            lblResultado.Text = $"Resultado: {simboloMoneda} {resultadoFinal:N2}";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBitcoin.Clear();
            cmbMonedas.SelectedIndex = 0;
            lblResultado.Text = "Resultado: ---";
            txtBitcoin.Focus();
        }
    }
}