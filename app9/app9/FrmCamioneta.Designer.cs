namespace app9
{
    partial class FrmCamioneta
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
            this.labelAltura = new System.Windows.Forms.Label();
            this.textBoxAltura = new System.Windows.Forms.TextBox();
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
            // labelAltura
            // 
            this.labelAltura.AutoSize = true;
            this.labelAltura.Location = new System.Drawing.Point(44, 240);
            this.labelAltura.Name = "labelAltura";
            this.labelAltura.Size = new System.Drawing.Size(51, 20);
            this.labelAltura.TabIndex = 8;
            this.labelAltura.Text = "Altura";
            // 
            // textBoxAltura
            // 
            this.textBoxAltura.Location = new System.Drawing.Point(44, 264);
            this.textBoxAltura.Name = "textBoxAltura";
            this.textBoxAltura.Size = new System.Drawing.Size(100, 26);
            this.textBoxAltura.TabIndex = 3;
            // 
            // FrmCamioneta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::app9.Properties.Resources.Polarizado_para_Camioneta;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(728, 445);
            this.Controls.Add(this.textBoxAltura);
            this.Controls.Add(this.labelAltura);
            this.DoubleBuffered = true;
            this.Name = "FrmCamioneta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmCamioneta";
            this.Controls.SetChildIndex(this.labelMarca, 0);
            this.Controls.SetChildIndex(this.labelColor, 0);
            this.Controls.SetChildIndex(this.labelPatente, 0);
            this.Controls.SetChildIndex(this.textBoxMarca, 0);
            this.Controls.SetChildIndex(this.comboBoxColor, 0);
            this.Controls.SetChildIndex(this.textBoxPatente, 0);
            this.Controls.SetChildIndex(this.buttonCancelar, 0);
            this.Controls.SetChildIndex(this.buttonAceptar, 0);
            this.Controls.SetChildIndex(this.labelAltura, 0);
            this.Controls.SetChildIndex(this.textBoxAltura, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAltura;
        private System.Windows.Forms.TextBox textBoxAltura;
    }
}