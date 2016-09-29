namespace app9
{
    partial class FrmModificar
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
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.listBoxModificar = new System.Windows.Forms.ListBox();
            this.labelSeleccione = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(583, 398);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(132, 31);
            this.buttonSalir.TabIndex = 7;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(16, 398);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(132, 31);
            this.buttonModificar.TabIndex = 6;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // listBoxModificar
            // 
            this.listBoxModificar.FormattingEnabled = true;
            this.listBoxModificar.ItemHeight = 20;
            this.listBoxModificar.Location = new System.Drawing.Point(16, 33);
            this.listBoxModificar.Name = "listBoxModificar";
            this.listBoxModificar.Size = new System.Drawing.Size(699, 344);
            this.listBoxModificar.TabIndex = 5;
            // 
            // labelSeleccione
            // 
            this.labelSeleccione.AutoSize = true;
            this.labelSeleccione.Location = new System.Drawing.Point(12, 9);
            this.labelSeleccione.Name = "labelSeleccione";
            this.labelSeleccione.Size = new System.Drawing.Size(245, 20);
            this.labelSeleccione.TabIndex = 4;
            this.labelSeleccione.Text = "Seleccione el vehiculo a modificar";
            // 
            // FrmModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 445);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.listBoxModificar);
            this.Controls.Add(this.labelSeleccione);
            this.Name = "FrmModificar";
            this.Text = "FrmModificar";
            this.Load += new System.EventHandler(this.FrmModificar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.ListBox listBoxModificar;
        private System.Windows.Forms.Label labelSeleccione;
    }
}