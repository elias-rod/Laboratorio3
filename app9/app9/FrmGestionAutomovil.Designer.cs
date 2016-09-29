namespace app9
{
    partial class FrmGestionAutomovil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionAutomovil));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevosVehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoAutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaMotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaCamionetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarVehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarVehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDelAdministradorDeVehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevosVehiculosToolStripMenuItem,
            this.borrarVehiculosToolStripMenuItem,
            this.modificarVehiculosToolStripMenuItem,
            this.salirDelAdministradorDeVehiculosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(850, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevosVehiculosToolStripMenuItem
            // 
            this.nuevosVehiculosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoAutoToolStripMenuItem,
            this.nuevaMotoToolStripMenuItem,
            this.nuevaCamionetaToolStripMenuItem});
            this.nuevosVehiculosToolStripMenuItem.Name = "nuevosVehiculosToolStripMenuItem";
            this.nuevosVehiculosToolStripMenuItem.Size = new System.Drawing.Size(162, 29);
            this.nuevosVehiculosToolStripMenuItem.Text = "Nuevos vehiculos";
            // 
            // nuevoAutoToolStripMenuItem
            // 
            this.nuevoAutoToolStripMenuItem.Name = "nuevoAutoToolStripMenuItem";
            this.nuevoAutoToolStripMenuItem.Size = new System.Drawing.Size(234, 30);
            this.nuevoAutoToolStripMenuItem.Text = "Nuevo auto";
            this.nuevoAutoToolStripMenuItem.Click += new System.EventHandler(this.nuevoAutoToolStripMenuItem_Click);
            // 
            // nuevaMotoToolStripMenuItem
            // 
            this.nuevaMotoToolStripMenuItem.Name = "nuevaMotoToolStripMenuItem";
            this.nuevaMotoToolStripMenuItem.Size = new System.Drawing.Size(234, 30);
            this.nuevaMotoToolStripMenuItem.Text = "Nueva moto";
            this.nuevaMotoToolStripMenuItem.Click += new System.EventHandler(this.nuevaMotoToolStripMenuItem_Click);
            // 
            // nuevaCamionetaToolStripMenuItem
            // 
            this.nuevaCamionetaToolStripMenuItem.Name = "nuevaCamionetaToolStripMenuItem";
            this.nuevaCamionetaToolStripMenuItem.Size = new System.Drawing.Size(234, 30);
            this.nuevaCamionetaToolStripMenuItem.Text = "Nueva camioneta";
            this.nuevaCamionetaToolStripMenuItem.Click += new System.EventHandler(this.nuevaCamionetaToolStripMenuItem_Click);
            // 
            // borrarVehiculosToolStripMenuItem
            // 
            this.borrarVehiculosToolStripMenuItem.Name = "borrarVehiculosToolStripMenuItem";
            this.borrarVehiculosToolStripMenuItem.Size = new System.Drawing.Size(150, 29);
            this.borrarVehiculosToolStripMenuItem.Text = "Borrar vehiculos";
            this.borrarVehiculosToolStripMenuItem.Click += new System.EventHandler(this.borrarVehiculosToolStripMenuItem_Click);
            // 
            // modificarVehiculosToolStripMenuItem
            // 
            this.modificarVehiculosToolStripMenuItem.Name = "modificarVehiculosToolStripMenuItem";
            this.modificarVehiculosToolStripMenuItem.Size = new System.Drawing.Size(177, 29);
            this.modificarVehiculosToolStripMenuItem.Text = "Modificar vehiculos";
            this.modificarVehiculosToolStripMenuItem.Click += new System.EventHandler(this.modificarVehiculosToolStripMenuItem_Click);
            // 
            // salirDelAdministradorDeVehiculosToolStripMenuItem
            // 
            this.salirDelAdministradorDeVehiculosToolStripMenuItem.Name = "salirDelAdministradorDeVehiculosToolStripMenuItem";
            this.salirDelAdministradorDeVehiculosToolStripMenuItem.Size = new System.Drawing.Size(305, 29);
            this.salirDelAdministradorDeVehiculosToolStripMenuItem.Text = "Salir del administrador de vehiculos";
            this.salirDelAdministradorDeVehiculosToolStripMenuItem.Click += new System.EventHandler(this.salirDelAdministradorDeVehiculosToolStripMenuItem_Click);
            // 
            // FrmGestionAutomovil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::app9.Properties.Resources.CarBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(850, 479);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmGestionAutomovil";
            this.Text = "FrmGestionAutomovil";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevosVehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarVehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarVehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirDelAdministradorDeVehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoAutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaMotoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaCamionetaToolStripMenuItem;
    }
}