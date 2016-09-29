namespace app9
{
    partial class FrmAuto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelPuertas = new System.Windows.Forms.Label();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.Items.AddRange(new object[] {
            ClassLibrary.eColores.Rojo,
            ClassLibrary.eColores.Amarillo,
            ClassLibrary.eColores.Negro,
            ClassLibrary.eColores.Azul});
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // labelPuertas
            // 
            this.labelPuertas.AutoSize = true;
            this.labelPuertas.Location = new System.Drawing.Point(44, 245);
            this.labelPuertas.Name = "labelPuertas";
            this.labelPuertas.Size = new System.Drawing.Size(153, 20);
            this.labelPuertas.TabIndex = 8;
            this.labelPuertas.Text = "Cantidad de puertas";
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(44, 269);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(100, 26);
            this.textBoxCantidad.TabIndex = 3;
            // 
            // FrmAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::app9.Properties.Resources.r8_coupe;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(728, 445);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.labelPuertas);
            this.DoubleBuffered = true;
            this.Name = "FrmAuto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmAuto";
            this.Controls.SetChildIndex(this.labelMarca, 0);
            this.Controls.SetChildIndex(this.labelColor, 0);
            this.Controls.SetChildIndex(this.labelPatente, 0);
            this.Controls.SetChildIndex(this.textBoxMarca, 0);
            this.Controls.SetChildIndex(this.comboBoxColor, 0);
            this.Controls.SetChildIndex(this.textBoxPatente, 0);
            this.Controls.SetChildIndex(this.buttonCancelar, 0);
            this.Controls.SetChildIndex(this.buttonAceptar, 0);
            this.Controls.SetChildIndex(this.labelPuertas, 0);
            this.Controls.SetChildIndex(this.textBoxCantidad, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPuertas;
        private System.Windows.Forms.TextBox textBoxCantidad;
    }
}