namespace app5
{
    partial class Form1
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
            this.groupBoxIngrese = new System.Windows.Forms.GroupBox();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.labelIngrese = new System.Windows.Forms.Label();
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.textBoxCifraMenor = new System.Windows.Forms.TextBox();
            this.textBoxCifraMayor = new System.Windows.Forms.TextBox();
            this.textBoxSumaTotal = new System.Windows.Forms.TextBox();
            this.textBoxSumaCifrasPares = new System.Windows.Forms.TextBox();
            this.textBoxSumaCifrasImpares = new System.Windows.Forms.TextBox();
            this.textBoxCantidadCifras = new System.Windows.Forms.TextBox();
            this.labelCifraMenor = new System.Windows.Forms.Label();
            this.labelCifraMayor = new System.Windows.Forms.Label();
            this.labelSumaTotal = new System.Windows.Forms.Label();
            this.labelSumaCifrasPares = new System.Windows.Forms.Label();
            this.labelSumaCifrasImpares = new System.Windows.Forms.Label();
            this.labelCantidadCifras = new System.Windows.Forms.Label();
            this.groupBoxDivisores = new System.Windows.Forms.GroupBox();
            this.listBoxDivisores = new System.Windows.Forms.ListBox();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.groupBoxIngrese.SuspendLayout();
            this.groupBoxData.SuspendLayout();
            this.groupBoxDivisores.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxIngrese
            // 
            this.groupBoxIngrese.Controls.Add(this.textBoxNumero);
            this.groupBoxIngrese.Controls.Add(this.labelIngrese);
            this.groupBoxIngrese.Location = new System.Drawing.Point(13, 13);
            this.groupBoxIngrese.Name = "groupBoxIngrese";
            this.groupBoxIngrese.Size = new System.Drawing.Size(263, 74);
            this.groupBoxIngrese.TabIndex = 0;
            this.groupBoxIngrese.TabStop = false;
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(141, 31);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(116, 22);
            this.textBoxNumero.TabIndex = 1;
            this.textBoxNumero.TextChanged += new System.EventHandler(this.textBoxNumero_TextChanged);
            // 
            // labelIngrese
            // 
            this.labelIngrese.AutoSize = true;
            this.labelIngrese.Location = new System.Drawing.Point(7, 31);
            this.labelIngrese.Name = "labelIngrese";
            this.labelIngrese.Size = new System.Drawing.Size(127, 17);
            this.labelIngrese.TabIndex = 0;
            this.labelIngrese.Text = "Ingrese un número";
            // 
            // groupBoxData
            // 
            this.groupBoxData.Controls.Add(this.textBoxCifraMenor);
            this.groupBoxData.Controls.Add(this.textBoxCifraMayor);
            this.groupBoxData.Controls.Add(this.textBoxSumaTotal);
            this.groupBoxData.Controls.Add(this.textBoxSumaCifrasPares);
            this.groupBoxData.Controls.Add(this.textBoxSumaCifrasImpares);
            this.groupBoxData.Controls.Add(this.textBoxCantidadCifras);
            this.groupBoxData.Controls.Add(this.labelCifraMenor);
            this.groupBoxData.Controls.Add(this.labelCifraMayor);
            this.groupBoxData.Controls.Add(this.labelSumaTotal);
            this.groupBoxData.Controls.Add(this.labelSumaCifrasPares);
            this.groupBoxData.Controls.Add(this.labelSumaCifrasImpares);
            this.groupBoxData.Controls.Add(this.labelCantidadCifras);
            this.groupBoxData.Location = new System.Drawing.Point(12, 93);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Size = new System.Drawing.Size(264, 246);
            this.groupBoxData.TabIndex = 1;
            this.groupBoxData.TabStop = false;
            // 
            // textBoxCifraMenor
            // 
            this.textBoxCifraMenor.Location = new System.Drawing.Point(166, 205);
            this.textBoxCifraMenor.Name = "textBoxCifraMenor";
            this.textBoxCifraMenor.Size = new System.Drawing.Size(92, 22);
            this.textBoxCifraMenor.TabIndex = 11;
            // 
            // textBoxCifraMayor
            // 
            this.textBoxCifraMayor.Location = new System.Drawing.Point(166, 171);
            this.textBoxCifraMayor.Name = "textBoxCifraMayor";
            this.textBoxCifraMayor.Size = new System.Drawing.Size(92, 22);
            this.textBoxCifraMayor.TabIndex = 10;
            // 
            // textBoxSumaTotal
            // 
            this.textBoxSumaTotal.Location = new System.Drawing.Point(166, 137);
            this.textBoxSumaTotal.Name = "textBoxSumaTotal";
            this.textBoxSumaTotal.Size = new System.Drawing.Size(92, 22);
            this.textBoxSumaTotal.TabIndex = 9;
            // 
            // textBoxSumaCifrasPares
            // 
            this.textBoxSumaCifrasPares.Location = new System.Drawing.Point(166, 103);
            this.textBoxSumaCifrasPares.Name = "textBoxSumaCifrasPares";
            this.textBoxSumaCifrasPares.Size = new System.Drawing.Size(92, 22);
            this.textBoxSumaCifrasPares.TabIndex = 8;
            // 
            // textBoxSumaCifrasImpares
            // 
            this.textBoxSumaCifrasImpares.Location = new System.Drawing.Point(166, 69);
            this.textBoxSumaCifrasImpares.Name = "textBoxSumaCifrasImpares";
            this.textBoxSumaCifrasImpares.Size = new System.Drawing.Size(92, 22);
            this.textBoxSumaCifrasImpares.TabIndex = 7;
            // 
            // textBoxCantidadCifras
            // 
            this.textBoxCantidadCifras.Location = new System.Drawing.Point(166, 35);
            this.textBoxCantidadCifras.Name = "textBoxCantidadCifras";
            this.textBoxCantidadCifras.Size = new System.Drawing.Size(92, 22);
            this.textBoxCantidadCifras.TabIndex = 2;
            // 
            // labelCifraMenor
            // 
            this.labelCifraMenor.AutoSize = true;
            this.labelCifraMenor.Location = new System.Drawing.Point(8, 208);
            this.labelCifraMenor.Name = "labelCifraMenor";
            this.labelCifraMenor.Size = new System.Drawing.Size(81, 17);
            this.labelCifraMenor.TabIndex = 6;
            this.labelCifraMenor.Text = "Cifra menor";
            // 
            // labelCifraMayor
            // 
            this.labelCifraMayor.AutoSize = true;
            this.labelCifraMayor.Location = new System.Drawing.Point(8, 174);
            this.labelCifraMayor.Name = "labelCifraMayor";
            this.labelCifraMayor.Size = new System.Drawing.Size(80, 17);
            this.labelCifraMayor.TabIndex = 5;
            this.labelCifraMayor.Text = "Cifra mayor";
            // 
            // labelSumaTotal
            // 
            this.labelSumaTotal.AutoSize = true;
            this.labelSumaTotal.Location = new System.Drawing.Point(8, 140);
            this.labelSumaTotal.Name = "labelSumaTotal";
            this.labelSumaTotal.Size = new System.Drawing.Size(133, 17);
            this.labelSumaTotal.TabIndex = 4;
            this.labelSumaTotal.Text = "Suma total de cifras";
            // 
            // labelSumaCifrasPares
            // 
            this.labelSumaCifrasPares.AutoSize = true;
            this.labelSumaCifrasPares.Location = new System.Drawing.Point(8, 106);
            this.labelSumaCifrasPares.Name = "labelSumaCifrasPares";
            this.labelSumaCifrasPares.Size = new System.Drawing.Size(142, 17);
            this.labelSumaCifrasPares.TabIndex = 3;
            this.labelSumaCifrasPares.Text = "Suma de cifras pares";
            // 
            // labelSumaCifrasImpares
            // 
            this.labelSumaCifrasImpares.AutoSize = true;
            this.labelSumaCifrasImpares.Location = new System.Drawing.Point(8, 72);
            this.labelSumaCifrasImpares.Name = "labelSumaCifrasImpares";
            this.labelSumaCifrasImpares.Size = new System.Drawing.Size(156, 17);
            this.labelSumaCifrasImpares.TabIndex = 2;
            this.labelSumaCifrasImpares.Text = "Suma de cifras impares";
            // 
            // labelCantidadCifras
            // 
            this.labelCantidadCifras.AutoSize = true;
            this.labelCantidadCifras.Location = new System.Drawing.Point(6, 38);
            this.labelCantidadCifras.Name = "labelCantidadCifras";
            this.labelCantidadCifras.Size = new System.Drawing.Size(122, 17);
            this.labelCantidadCifras.TabIndex = 1;
            this.labelCantidadCifras.Text = "Cantidad de cifras";
            // 
            // groupBoxDivisores
            // 
            this.groupBoxDivisores.Controls.Add(this.listBoxDivisores);
            this.groupBoxDivisores.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBoxDivisores.Location = new System.Drawing.Point(282, 93);
            this.groupBoxDivisores.Name = "groupBoxDivisores";
            this.groupBoxDivisores.Size = new System.Drawing.Size(226, 246);
            this.groupBoxDivisores.TabIndex = 2;
            this.groupBoxDivisores.TabStop = false;
            this.groupBoxDivisores.Text = "Divisores";
            // 
            // listBoxDivisores
            // 
            this.listBoxDivisores.FormattingEnabled = true;
            this.listBoxDivisores.ItemHeight = 16;
            this.listBoxDivisores.Location = new System.Drawing.Point(7, 22);
            this.listBoxDivisores.Name = "listBoxDivisores";
            this.listBoxDivisores.Size = new System.Drawing.Size(213, 212);
            this.listBoxDivisores.TabIndex = 0;
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(282, 25);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(111, 62);
            this.buttonLimpiar.TabIndex = 3;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(395, 25);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(111, 62);
            this.buttonCancelar.TabIndex = 4;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 351);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.groupBoxDivisores);
            this.Controls.Add(this.groupBoxData);
            this.Controls.Add(this.groupBoxIngrese);
            this.Name = "Form1";
            this.Text = "Información del número";
            this.groupBoxIngrese.ResumeLayout(false);
            this.groupBoxIngrese.PerformLayout();
            this.groupBoxData.ResumeLayout(false);
            this.groupBoxData.PerformLayout();
            this.groupBoxDivisores.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxIngrese;
        private System.Windows.Forms.Label labelIngrese;
        private System.Windows.Forms.GroupBox groupBoxData;
        private System.Windows.Forms.Label labelCifraMenor;
        private System.Windows.Forms.Label labelCifraMayor;
        private System.Windows.Forms.Label labelSumaTotal;
        private System.Windows.Forms.Label labelSumaCifrasPares;
        private System.Windows.Forms.Label labelSumaCifrasImpares;
        private System.Windows.Forms.Label labelCantidadCifras;
        private System.Windows.Forms.GroupBox groupBoxDivisores;
        private System.Windows.Forms.ListBox listBoxDivisores;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.TextBox textBoxCifraMenor;
        private System.Windows.Forms.TextBox textBoxCifraMayor;
        private System.Windows.Forms.TextBox textBoxSumaTotal;
        private System.Windows.Forms.TextBox textBoxSumaCifrasPares;
        private System.Windows.Forms.TextBox textBoxSumaCifrasImpares;
        private System.Windows.Forms.TextBox textBoxCantidadCifras;
    }
}

