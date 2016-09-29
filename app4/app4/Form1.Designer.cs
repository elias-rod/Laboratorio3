namespace app4
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
            this.groupBoxIngresar = new System.Windows.Forms.GroupBox();
            this.textBoxIngresar = new System.Windows.Forms.TextBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.groupBoxOrden = new System.Windows.Forms.GroupBox();
            this.radioButtonDescendente = new System.Windows.Forms.RadioButton();
            this.radioButtonAscendente = new System.Windows.Forms.RadioButton();
            this.buttonOrdenar = new System.Windows.Forms.Button();
            this.groupBoxLista = new System.Windows.Forms.GroupBox();
            this.listBoxLista = new System.Windows.Forms.ListBox();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.groupBoxIngresar.SuspendLayout();
            this.groupBoxOrden.SuspendLayout();
            this.groupBoxLista.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxIngresar
            // 
            this.groupBoxIngresar.Controls.Add(this.textBoxIngresar);
            this.groupBoxIngresar.Controls.Add(this.buttonAgregar);
            this.groupBoxIngresar.Location = new System.Drawing.Point(12, 12);
            this.groupBoxIngresar.Name = "groupBoxIngresar";
            this.groupBoxIngresar.Size = new System.Drawing.Size(200, 87);
            this.groupBoxIngresar.TabIndex = 0;
            this.groupBoxIngresar.TabStop = false;
            this.groupBoxIngresar.Text = "Ingresar un nuevo número";
            // 
            // textBoxIngresar
            // 
            this.textBoxIngresar.Location = new System.Drawing.Point(6, 32);
            this.textBoxIngresar.Name = "textBoxIngresar";
            this.textBoxIngresar.Size = new System.Drawing.Size(107, 22);
            this.textBoxIngresar.TabIndex = 1;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(119, 27);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(75, 32);
            this.buttonAgregar.TabIndex = 0;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // groupBoxOrden
            // 
            this.groupBoxOrden.Controls.Add(this.radioButtonDescendente);
            this.groupBoxOrden.Controls.Add(this.radioButtonAscendente);
            this.groupBoxOrden.Controls.Add(this.buttonOrdenar);
            this.groupBoxOrden.Location = new System.Drawing.Point(12, 105);
            this.groupBoxOrden.Name = "groupBoxOrden";
            this.groupBoxOrden.Size = new System.Drawing.Size(200, 138);
            this.groupBoxOrden.TabIndex = 1;
            this.groupBoxOrden.TabStop = false;
            this.groupBoxOrden.Text = "Orden";
            // 
            // radioButtonDescendente
            // 
            this.radioButtonDescendente.AutoSize = true;
            this.radioButtonDescendente.Location = new System.Drawing.Point(6, 74);
            this.radioButtonDescendente.Name = "radioButtonDescendente";
            this.radioButtonDescendente.Size = new System.Drawing.Size(113, 21);
            this.radioButtonDescendente.TabIndex = 3;
            this.radioButtonDescendente.TabStop = true;
            this.radioButtonDescendente.Text = "Descendente";
            this.radioButtonDescendente.UseVisualStyleBackColor = true;
            // 
            // radioButtonAscendente
            // 
            this.radioButtonAscendente.AutoSize = true;
            this.radioButtonAscendente.Location = new System.Drawing.Point(6, 47);
            this.radioButtonAscendente.Name = "radioButtonAscendente";
            this.radioButtonAscendente.Size = new System.Drawing.Size(104, 21);
            this.radioButtonAscendente.TabIndex = 2;
            this.radioButtonAscendente.TabStop = true;
            this.radioButtonAscendente.Text = "Ascendente";
            this.radioButtonAscendente.UseVisualStyleBackColor = true;
            // 
            // buttonOrdenar
            // 
            this.buttonOrdenar.Location = new System.Drawing.Point(119, 53);
            this.buttonOrdenar.Name = "buttonOrdenar";
            this.buttonOrdenar.Size = new System.Drawing.Size(75, 32);
            this.buttonOrdenar.TabIndex = 1;
            this.buttonOrdenar.Text = "Ordenar";
            this.buttonOrdenar.UseVisualStyleBackColor = true;
            this.buttonOrdenar.Click += new System.EventHandler(this.buttonOrdenar_Click);
            // 
            // groupBoxLista
            // 
            this.groupBoxLista.Controls.Add(this.listBoxLista);
            this.groupBoxLista.Location = new System.Drawing.Point(220, 12);
            this.groupBoxLista.Name = "groupBoxLista";
            this.groupBoxLista.Size = new System.Drawing.Size(144, 231);
            this.groupBoxLista.TabIndex = 2;
            this.groupBoxLista.TabStop = false;
            this.groupBoxLista.Text = "Lista de números";
            // 
            // listBoxLista
            // 
            this.listBoxLista.FormattingEnabled = true;
            this.listBoxLista.ItemHeight = 16;
            this.listBoxLista.Location = new System.Drawing.Point(7, 27);
            this.listBoxLista.Name = "listBoxLista";
            this.listBoxLista.Size = new System.Drawing.Size(131, 196);
            this.listBoxLista.TabIndex = 0;
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackgroundImage = global::app4.Properties.Resources.user_exit_512;
            this.buttonSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSalir.Location = new System.Drawing.Point(364, 12);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(114, 110);
            this.buttonSalir.TabIndex = 2;
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 255);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.groupBoxLista);
            this.Controls.Add(this.groupBoxOrden);
            this.Controls.Add(this.groupBoxIngresar);
            this.Name = "Form1";
            this.Text = "Ordenamiento por burbujeo";
            this.groupBoxIngresar.ResumeLayout(false);
            this.groupBoxIngresar.PerformLayout();
            this.groupBoxOrden.ResumeLayout(false);
            this.groupBoxOrden.PerformLayout();
            this.groupBoxLista.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxIngresar;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.GroupBox groupBoxOrden;
        private System.Windows.Forms.RadioButton radioButtonDescendente;
        private System.Windows.Forms.RadioButton radioButtonAscendente;
        private System.Windows.Forms.Button buttonOrdenar;
        private System.Windows.Forms.GroupBox groupBoxLista;
        private System.Windows.Forms.ListBox listBoxLista;
        private System.Windows.Forms.TextBox textBoxIngresar;
        private System.Windows.Forms.Button buttonSalir;
    }
}

