namespace Generica
{
    partial class frmAltaAlumno
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
            this.label1Apellido = new System.Windows.Forms.Label();
            this.textBox1Apellido = new System.Windows.Forms.TextBox();
            this.textBox2Nombre = new System.Windows.Forms.TextBox();
            this.label2Nombre = new System.Windows.Forms.Label();
            this.textBox3Foto = new System.Windows.Forms.TextBox();
            this.label3Foto = new System.Windows.Forms.Label();
            this.textBox4Dni = new System.Windows.Forms.TextBox();
            this.label4Dni = new System.Windows.Forms.Label();
            this.button1Aceptar = new System.Windows.Forms.Button();
            this.button2Cancelar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1Apellido
            // 
            this.label1Apellido.AutoSize = true;
            this.label1Apellido.Location = new System.Drawing.Point(13, 13);
            this.label1Apellido.Name = "label1Apellido";
            this.label1Apellido.Size = new System.Drawing.Size(65, 20);
            this.label1Apellido.TabIndex = 0;
            this.label1Apellido.Text = "Apellido";
            // 
            // textBox1Apellido
            // 
            this.textBox1Apellido.Location = new System.Drawing.Point(17, 37);
            this.textBox1Apellido.Name = "textBox1Apellido";
            this.textBox1Apellido.Size = new System.Drawing.Size(299, 26);
            this.textBox1Apellido.TabIndex = 1;
            // 
            // textBox2Nombre
            // 
            this.textBox2Nombre.Location = new System.Drawing.Point(17, 97);
            this.textBox2Nombre.Name = "textBox2Nombre";
            this.textBox2Nombre.Size = new System.Drawing.Size(299, 26);
            this.textBox2Nombre.TabIndex = 3;
            // 
            // label2Nombre
            // 
            this.label2Nombre.AutoSize = true;
            this.label2Nombre.Location = new System.Drawing.Point(13, 73);
            this.label2Nombre.Name = "label2Nombre";
            this.label2Nombre.Size = new System.Drawing.Size(65, 20);
            this.label2Nombre.TabIndex = 2;
            this.label2Nombre.Text = "Nombre";
            // 
            // textBox3Foto
            // 
            this.textBox3Foto.Location = new System.Drawing.Point(17, 220);
            this.textBox3Foto.Name = "textBox3Foto";
            this.textBox3Foto.Size = new System.Drawing.Size(299, 26);
            this.textBox3Foto.TabIndex = 7;
            this.textBox3Foto.DoubleClick += new System.EventHandler(this.textBox3Foto_DoubleClick);
            // 
            // label3Foto
            // 
            this.label3Foto.AutoSize = true;
            this.label3Foto.Location = new System.Drawing.Point(13, 196);
            this.label3Foto.Name = "label3Foto";
            this.label3Foto.Size = new System.Drawing.Size(42, 20);
            this.label3Foto.TabIndex = 6;
            this.label3Foto.Text = "Foto";
            // 
            // textBox4Dni
            // 
            this.textBox4Dni.Location = new System.Drawing.Point(17, 160);
            this.textBox4Dni.Name = "textBox4Dni";
            this.textBox4Dni.Size = new System.Drawing.Size(299, 26);
            this.textBox4Dni.TabIndex = 5;
            // 
            // label4Dni
            // 
            this.label4Dni.AutoSize = true;
            this.label4Dni.Location = new System.Drawing.Point(13, 136);
            this.label4Dni.Name = "label4Dni";
            this.label4Dni.Size = new System.Drawing.Size(33, 20);
            this.label4Dni.TabIndex = 4;
            this.label4Dni.Text = "Dni";
            // 
            // button1Aceptar
            // 
            this.button1Aceptar.Location = new System.Drawing.Point(13, 367);
            this.button1Aceptar.Name = "button1Aceptar";
            this.button1Aceptar.Size = new System.Drawing.Size(122, 43);
            this.button1Aceptar.TabIndex = 8;
            this.button1Aceptar.Text = "Aceptar";
            this.button1Aceptar.UseVisualStyleBackColor = true;
            this.button1Aceptar.Click += new System.EventHandler(this.button1Aceptar_Click);
            // 
            // button2Cancelar
            // 
            this.button2Cancelar.Location = new System.Drawing.Point(194, 367);
            this.button2Cancelar.Name = "button2Cancelar";
            this.button2Cancelar.Size = new System.Drawing.Size(122, 43);
            this.button2Cancelar.TabIndex = 9;
            this.button2Cancelar.Text = "Cancelar";
            this.button2Cancelar.UseVisualStyleBackColor = true;
            this.button2Cancelar.Click += new System.EventHandler(this.button2Cancelar_Click);
            // 
            // frmAltaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 422);
            this.Controls.Add(this.button2Cancelar);
            this.Controls.Add(this.button1Aceptar);
            this.Controls.Add(this.textBox3Foto);
            this.Controls.Add(this.label3Foto);
            this.Controls.Add(this.textBox4Dni);
            this.Controls.Add(this.label4Dni);
            this.Controls.Add(this.textBox2Nombre);
            this.Controls.Add(this.label2Nombre);
            this.Controls.Add(this.textBox1Apellido);
            this.Controls.Add(this.label1Apellido);
            this.Name = "frmAltaAlumno";
            this.Text = "frmAltaAlumno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1Apellido;
        public System.Windows.Forms.TextBox textBox1Apellido;
        public System.Windows.Forms.TextBox textBox2Nombre;
        private System.Windows.Forms.Label label2Nombre;
        public System.Windows.Forms.TextBox textBox3Foto;
        private System.Windows.Forms.Label label3Foto;
        public System.Windows.Forms.TextBox textBox4Dni;
        private System.Windows.Forms.Label label4Dni;
        private System.Windows.Forms.Button button1Aceptar;
        private System.Windows.Forms.Button button2Cancelar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

