
namespace ConversorBitcoinCA
{
    partial class frmConversorPropioBitcon
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBitcoin = new System.Windows.Forms.TextBox();
            this.cmbMonedas = new System.Windows.Forms.ComboBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblMonedaDestino = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBitcoin
            // 
            this.txtBitcoin.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBitcoin.Location = new System.Drawing.Point(37, 68);
            this.txtBitcoin.Name = "txtBitcoin";
            this.txtBitcoin.Size = new System.Drawing.Size(100, 22);
            this.txtBitcoin.TabIndex = 0;
            // 
            // cmbMonedas
            // 
            this.cmbMonedas.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMonedas.FormattingEnabled = true;
            this.cmbMonedas.Items.AddRange(new object[] {
            "Dólares (USD)",
            "Quetzales (GTQ)",
            "Lempiras (HNL)",
            "Córdobas (NIO)",
            "Colones CR (CRC)"});
            this.cmbMonedas.Location = new System.Drawing.Point(188, 67);
            this.cmbMonedas.Name = "cmbMonedas";
            this.cmbMonedas.Size = new System.Drawing.Size(121, 24);
            this.cmbMonedas.TabIndex = 1;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.Location = new System.Drawing.Point(48, 138);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(75, 23);
            this.btnConvertir.TabIndex = 2;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(213, 138);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(148, 205);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 16);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Resultado";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(58, 32);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(50, 16);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblMonedaDestino
            // 
            this.lblMonedaDestino.AutoSize = true;
            this.lblMonedaDestino.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonedaDestino.Location = new System.Drawing.Point(203, 32);
            this.lblMonedaDestino.Name = "lblMonedaDestino";
            this.lblMonedaDestino.Size = new System.Drawing.Size(85, 16);
            this.lblMonedaDestino.TabIndex = 6;
            this.lblMonedaDestino.Text = "Moneda/Destino";
            // 
            // frmConversorPropioBitcon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(357, 263);
            this.Controls.Add(this.lblMonedaDestino);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.cmbMonedas);
            this.Controls.Add(this.txtBitcoin);
            this.Name = "frmConversorPropioBitcon";
            this.Text = "Convertir Bitcoin a Moneda Centroamericana";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBitcoin;
        private System.Windows.Forms.ComboBox cmbMonedas;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblMonedaDestino;
    }
}

