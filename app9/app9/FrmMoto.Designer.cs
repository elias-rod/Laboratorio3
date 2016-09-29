namespace app9
{
    partial class FrmMoto
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
            this.labelCilindrada = new System.Windows.Forms.Label();
            this.textBoxCilindrada = new System.Windows.Forms.TextBox();
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
            // labelCilindrada
            // 
            this.labelCilindrada.AutoSize = true;
            this.labelCilindrada.Location = new System.Drawing.Point(44, 240);
            this.labelCilindrada.Name = "labelCilindrada";
            this.labelCilindrada.Size = new System.Drawing.Size(79, 20);
            this.labelCilindrada.TabIndex = 8;
            this.labelCilindrada.Text = "Cilindrada";
            // 
            // textBoxCilindrada
            // 
            this.textBoxCilindrada.Location = new System.Drawing.Point(44, 264);
            this.textBoxCilindrada.Name = "textBoxCilindrada";
            this.textBoxCilindrada.Size = new System.Drawing.Size(100, 26);
            this.textBoxCilindrada.TabIndex = 3;
            // 
            // FrmMoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::app9.Properties.Resources.Beautiful_Motorbike_of_2012_Yamaha_and_Star_Motorcycles_Model_630x393;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(728, 445);
            this.Controls.Add(this.textBoxCilindrada);
            this.Controls.Add(this.labelCilindrada);
            this.Name = "FrmMoto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmMoto";
            this.Controls.SetChildIndex(this.labelMarca, 0);
            this.Controls.SetChildIndex(this.labelColor, 0);
            this.Controls.SetChildIndex(this.labelPatente, 0);
            this.Controls.SetChildIndex(this.textBoxMarca, 0);
            this.Controls.SetChildIndex(this.comboBoxColor, 0);
            this.Controls.SetChildIndex(this.textBoxPatente, 0);
            this.Controls.SetChildIndex(this.buttonCancelar, 0);
            this.Controls.SetChildIndex(this.buttonAceptar, 0);
            this.Controls.SetChildIndex(this.labelCilindrada, 0);
            this.Controls.SetChildIndex(this.textBoxCilindrada, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCilindrada;
        private System.Windows.Forms.TextBox textBoxCilindrada;
    }
}