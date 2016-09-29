namespace app9
{
    partial class FrmBorrar
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
            this.labelSeleccione = new System.Windows.Forms.Label();
            this.listBoxBorrar = new System.Windows.Forms.ListBox();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSeleccione
            // 
            this.labelSeleccione.AutoSize = true;
            this.labelSeleccione.Location = new System.Drawing.Point(13, 13);
            this.labelSeleccione.Name = "labelSeleccione";
            this.labelSeleccione.Size = new System.Drawing.Size(223, 20);
            this.labelSeleccione.TabIndex = 0;
            this.labelSeleccione.Text = "Seleccione el vehiculo a borrar";
            // 
            // listBoxBorrar
            // 
            this.listBoxBorrar.FormattingEnabled = true;
            this.listBoxBorrar.ItemHeight = 20;
            this.listBoxBorrar.Location = new System.Drawing.Point(17, 37);
            this.listBoxBorrar.Name = "listBoxBorrar";
            this.listBoxBorrar.Size = new System.Drawing.Size(699, 344);
            this.listBoxBorrar.TabIndex = 1;
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.Location = new System.Drawing.Point(17, 402);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(132, 31);
            this.buttonBorrar.TabIndex = 2;
            this.buttonBorrar.Text = "Borrar";
            this.buttonBorrar.UseVisualStyleBackColor = true;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(584, 402);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(132, 31);
            this.buttonSalir.TabIndex = 3;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // FrmBorrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 445);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.listBoxBorrar);
            this.Controls.Add(this.labelSeleccione);
            this.Name = "FrmBorrar";
            this.Text = "FrmBorrar";
            this.Load += new System.EventHandler(this.FrmBorrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSeleccione;
        private System.Windows.Forms.ListBox listBoxBorrar;
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.Button buttonSalir;
    }
}