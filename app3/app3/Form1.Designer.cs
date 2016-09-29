namespace app3
{
    partial class FormManejo
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
            this.labelCadena = new System.Windows.Forms.Label();
            this.labelInvertida = new System.Windows.Forms.Label();
            this.labelOrden = new System.Windows.Forms.Label();
            this.textIngrese = new System.Windows.Forms.TextBox();
            this.textInvertida = new System.Windows.Forms.TextBox();
            this.textOrden = new System.Windows.Forms.TextBox();
            this.buttonOperar = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCadena
            // 
            this.labelCadena.AutoSize = true;
            this.labelCadena.Location = new System.Drawing.Point(13, 44);
            this.labelCadena.Name = "labelCadena";
            this.labelCadena.Size = new System.Drawing.Size(180, 17);
            this.labelCadena.TabIndex = 0;
            this.labelCadena.Text = "Ingrese la cadena a invertir";
            // 
            // labelInvertida
            // 
            this.labelInvertida.AutoSize = true;
            this.labelInvertida.Location = new System.Drawing.Point(12, 83);
            this.labelInvertida.Name = "labelInvertida";
            this.labelInvertida.Size = new System.Drawing.Size(115, 17);
            this.labelInvertida.TabIndex = 1;
            this.labelInvertida.Text = "Cadena invertida";
            // 
            // labelOrden
            // 
            this.labelOrden.AutoSize = true;
            this.labelOrden.Location = new System.Drawing.Point(12, 122);
            this.labelOrden.Name = "labelOrden";
            this.labelOrden.Size = new System.Drawing.Size(113, 17);
            this.labelOrden.TabIndex = 2;
            this.labelOrden.Text = "Orden alfabético";
            // 
            // textIngrese
            // 
            this.textIngrese.Location = new System.Drawing.Point(199, 44);
            this.textIngrese.Name = "textIngrese";
            this.textIngrese.Size = new System.Drawing.Size(251, 22);
            this.textIngrese.TabIndex = 3;
            // 
            // textInvertida
            // 
            this.textInvertida.Location = new System.Drawing.Point(199, 80);
            this.textInvertida.Name = "textInvertida";
            this.textInvertida.Size = new System.Drawing.Size(251, 22);
            this.textInvertida.TabIndex = 4;
            // 
            // textOrden
            // 
            this.textOrden.Location = new System.Drawing.Point(199, 119);
            this.textOrden.Name = "textOrden";
            this.textOrden.Size = new System.Drawing.Size(251, 22);
            this.textOrden.TabIndex = 5;
            // 
            // buttonOperar
            // 
            this.buttonOperar.Location = new System.Drawing.Point(15, 201);
            this.buttonOperar.Name = "buttonOperar";
            this.buttonOperar.Size = new System.Drawing.Size(131, 28);
            this.buttonOperar.TabIndex = 6;
            this.buttonOperar.Text = "Operar";
            this.buttonOperar.UseVisualStyleBackColor = true;
            this.buttonOperar.Click += new System.EventHandler(this.buttonOperar_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(167, 201);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(131, 28);
            this.buttonLimpiar.TabIndex = 7;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(319, 201);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(131, 28);
            this.buttonSalir.TabIndex = 8;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // FormManejo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 255);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonOperar);
            this.Controls.Add(this.textOrden);
            this.Controls.Add(this.textInvertida);
            this.Controls.Add(this.textIngrese);
            this.Controls.Add(this.labelOrden);
            this.Controls.Add(this.labelInvertida);
            this.Controls.Add(this.labelCadena);
            this.Name = "FormManejo";
            this.Text = "Manejo de cadenas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCadena;
        private System.Windows.Forms.Label labelInvertida;
        private System.Windows.Forms.Label labelOrden;
        private System.Windows.Forms.TextBox textIngrese;
        private System.Windows.Forms.TextBox textInvertida;
        private System.Windows.Forms.TextBox textOrden;
        private System.Windows.Forms.Button buttonOperar;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonSalir;
    }
}

