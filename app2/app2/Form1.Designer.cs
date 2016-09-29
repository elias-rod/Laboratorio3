namespace app2
{
    partial class foDescuento
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
            this.gbInformación = new System.Windows.Forms.GroupBox();
            this.laIngrese = new System.Windows.Forms.Label();
            this.laDescuento = new System.Windows.Forms.Label();
            this.laTotal = new System.Windows.Forms.Label();
            this.teIngrese = new System.Windows.Forms.TextBox();
            this.teDescuento = new System.Windows.Forms.TextBox();
            this.teTotal = new System.Windows.Forms.TextBox();
            this.boAceptar = new System.Windows.Forms.Button();
            this.boLimpiar = new System.Windows.Forms.Button();
            this.boSalir = new System.Windows.Forms.Button();
            this.gbInformación.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInformación
            // 
            this.gbInformación.Controls.Add(this.teTotal);
            this.gbInformación.Controls.Add(this.teDescuento);
            this.gbInformación.Controls.Add(this.teIngrese);
            this.gbInformación.Controls.Add(this.laTotal);
            this.gbInformación.Controls.Add(this.laDescuento);
            this.gbInformación.Controls.Add(this.laIngrese);
            this.gbInformación.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gbInformación.Location = new System.Drawing.Point(12, 12);
            this.gbInformación.Name = "gbInformación";
            this.gbInformación.Size = new System.Drawing.Size(444, 191);
            this.gbInformación.TabIndex = 0;
            this.gbInformación.TabStop = false;
            this.gbInformación.Text = "Información";
            // 
            // laIngrese
            // 
            this.laIngrese.AutoSize = true;
            this.laIngrese.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laIngrese.ForeColor = System.Drawing.SystemColors.ControlText;
            this.laIngrese.Location = new System.Drawing.Point(16, 27);
            this.laIngrese.Name = "laIngrese";
            this.laIngrese.Size = new System.Drawing.Size(195, 17);
            this.laIngrese.TabIndex = 0;
            this.laIngrese.Text = "Ingrese el monto a cobrar";
            // 
            // laDescuento
            // 
            this.laDescuento.AutoSize = true;
            this.laDescuento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.laDescuento.Location = new System.Drawing.Point(202, 107);
            this.laDescuento.Name = "laDescuento";
            this.laDescuento.Size = new System.Drawing.Size(130, 17);
            this.laDescuento.TabIndex = 1;
            this.laDescuento.Text = "Descuento recibido";
            // 
            // laTotal
            // 
            this.laTotal.AutoSize = true;
            this.laTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.laTotal.Location = new System.Drawing.Point(239, 135);
            this.laTotal.Name = "laTotal";
            this.laTotal.Size = new System.Drawing.Size(93, 17);
            this.laTotal.TabIndex = 2;
            this.laTotal.Text = "Total a pagar";
            // 
            // teIngrese
            // 
            this.teIngrese.Location = new System.Drawing.Point(217, 24);
            this.teIngrese.Name = "teIngrese";
            this.teIngrese.Size = new System.Drawing.Size(100, 22);
            this.teIngrese.TabIndex = 3;
            // 
            // teDescuento
            // 
            this.teDescuento.Enabled = false;
            this.teDescuento.Location = new System.Drawing.Point(338, 104);
            this.teDescuento.Name = "teDescuento";
            this.teDescuento.Size = new System.Drawing.Size(100, 22);
            this.teDescuento.TabIndex = 4;
            // 
            // teTotal
            // 
            this.teTotal.Enabled = false;
            this.teTotal.Location = new System.Drawing.Point(338, 132);
            this.teTotal.Name = "teTotal";
            this.teTotal.Size = new System.Drawing.Size(100, 22);
            this.teTotal.TabIndex = 5;
            // 
            // boAceptar
            // 
            this.boAceptar.Location = new System.Drawing.Point(12, 209);
            this.boAceptar.Name = "boAceptar";
            this.boAceptar.Size = new System.Drawing.Size(121, 34);
            this.boAceptar.TabIndex = 1;
            this.boAceptar.Text = "Aceptar";
            this.boAceptar.UseVisualStyleBackColor = true;
            this.boAceptar.Click += new System.EventHandler(this.boAceptar_Click);
            // 
            // boLimpiar
            // 
            this.boLimpiar.Location = new System.Drawing.Point(173, 209);
            this.boLimpiar.Name = "boLimpiar";
            this.boLimpiar.Size = new System.Drawing.Size(121, 34);
            this.boLimpiar.TabIndex = 2;
            this.boLimpiar.Text = "Limpiar";
            this.boLimpiar.UseVisualStyleBackColor = true;
            this.boLimpiar.Click += new System.EventHandler(this.boLimpiar_Click);
            // 
            // boSalir
            // 
            this.boSalir.Location = new System.Drawing.Point(334, 209);
            this.boSalir.Name = "boSalir";
            this.boSalir.Size = new System.Drawing.Size(121, 34);
            this.boSalir.TabIndex = 6;
            this.boSalir.Text = "Salir";
            this.boSalir.UseVisualStyleBackColor = true;
            this.boSalir.Click += new System.EventHandler(this.boSalir_Click);
            // 
            // foDescuento
            // 
            this.AcceptButton = this.boAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 255);
            this.Controls.Add(this.boSalir);
            this.Controls.Add(this.boLimpiar);
            this.Controls.Add(this.boAceptar);
            this.Controls.Add(this.gbInformación);
            this.Name = "foDescuento";
            this.Text = "Descuento";
            this.gbInformación.ResumeLayout(false);
            this.gbInformación.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInformación;
        private System.Windows.Forms.Label laTotal;
        private System.Windows.Forms.Label laDescuento;
        private System.Windows.Forms.Label laIngrese;
        private System.Windows.Forms.TextBox teTotal;
        private System.Windows.Forms.TextBox teDescuento;
        private System.Windows.Forms.TextBox teIngrese;
        private System.Windows.Forms.Button boAceptar;
        private System.Windows.Forms.Button boLimpiar;
        private System.Windows.Forms.Button boSalir;
    }
}

