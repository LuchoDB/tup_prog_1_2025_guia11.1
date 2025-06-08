namespace Ejercicio3
{
    partial class Form3
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
            this.gbNombreLibreta = new System.Windows.Forms.GroupBox();
            this.gbMostrarLista = new System.Windows.Forms.GroupBox();
            this.lbLibreta1 = new System.Windows.Forms.Label();
            this.lbLibreta2 = new System.Windows.Forms.Label();
            this.lbLibreta3 = new System.Windows.Forms.Label();
            this.tbLibreta1 = new System.Windows.Forms.TextBox();
            this.tbLibreta2 = new System.Windows.Forms.TextBox();
            this.tbLibreta3 = new System.Windows.Forms.TextBox();
            this.tbNombre1 = new System.Windows.Forms.TextBox();
            this.lbNombre1 = new System.Windows.Forms.Label();
            this.tbNombre2 = new System.Windows.Forms.TextBox();
            this.lbNombre2 = new System.Windows.Forms.Label();
            this.tbNombre3 = new System.Windows.Forms.TextBox();
            this.lbNombre3 = new System.Windows.Forms.Label();
            this.btnRegistrarAlumno = new System.Windows.Forms.Button();
            this.boxMostrarAlumnos = new System.Windows.Forms.ListBox();
            this.btnActualizarBox = new System.Windows.Forms.Button();
            this.gbNombreLibreta.SuspendLayout();
            this.gbMostrarLista.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbNombreLibreta
            // 
            this.gbNombreLibreta.Controls.Add(this.btnRegistrarAlumno);
            this.gbNombreLibreta.Controls.Add(this.tbNombre3);
            this.gbNombreLibreta.Controls.Add(this.lbNombre3);
            this.gbNombreLibreta.Controls.Add(this.tbNombre2);
            this.gbNombreLibreta.Controls.Add(this.lbNombre2);
            this.gbNombreLibreta.Controls.Add(this.tbNombre1);
            this.gbNombreLibreta.Controls.Add(this.lbNombre1);
            this.gbNombreLibreta.Controls.Add(this.tbLibreta3);
            this.gbNombreLibreta.Controls.Add(this.tbLibreta2);
            this.gbNombreLibreta.Controls.Add(this.tbLibreta1);
            this.gbNombreLibreta.Controls.Add(this.lbLibreta3);
            this.gbNombreLibreta.Controls.Add(this.lbLibreta2);
            this.gbNombreLibreta.Controls.Add(this.lbLibreta1);
            this.gbNombreLibreta.Location = new System.Drawing.Point(12, 12);
            this.gbNombreLibreta.Name = "gbNombreLibreta";
            this.gbNombreLibreta.Size = new System.Drawing.Size(521, 268);
            this.gbNombreLibreta.TabIndex = 0;
            this.gbNombreLibreta.TabStop = false;
            this.gbNombreLibreta.Text = "Registro del Alumno (libreta y nombre)";
            // 
            // gbMostrarLista
            // 
            this.gbMostrarLista.Controls.Add(this.btnActualizarBox);
            this.gbMostrarLista.Controls.Add(this.boxMostrarAlumnos);
            this.gbMostrarLista.Location = new System.Drawing.Point(12, 286);
            this.gbMostrarLista.Name = "gbMostrarLista";
            this.gbMostrarLista.Size = new System.Drawing.Size(521, 257);
            this.gbMostrarLista.TabIndex = 1;
            this.gbMostrarLista.TabStop = false;
            this.gbMostrarLista.Text = "Mostrar Lista Ordenada";
            // 
            // lbLibreta1
            // 
            this.lbLibreta1.AutoSize = true;
            this.lbLibreta1.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLibreta1.Location = new System.Drawing.Point(59, 59);
            this.lbLibreta1.Name = "lbLibreta1";
            this.lbLibreta1.Size = new System.Drawing.Size(54, 17);
            this.lbLibreta1.TabIndex = 0;
            this.lbLibreta1.Text = "Libreta";
            // 
            // lbLibreta2
            // 
            this.lbLibreta2.AutoSize = true;
            this.lbLibreta2.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLibreta2.Location = new System.Drawing.Point(59, 119);
            this.lbLibreta2.Name = "lbLibreta2";
            this.lbLibreta2.Size = new System.Drawing.Size(54, 17);
            this.lbLibreta2.TabIndex = 1;
            this.lbLibreta2.Text = "Libreta";
            // 
            // lbLibreta3
            // 
            this.lbLibreta3.AutoSize = true;
            this.lbLibreta3.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLibreta3.Location = new System.Drawing.Point(59, 182);
            this.lbLibreta3.Name = "lbLibreta3";
            this.lbLibreta3.Size = new System.Drawing.Size(54, 17);
            this.lbLibreta3.TabIndex = 2;
            this.lbLibreta3.Text = "Libreta";
            // 
            // tbLibreta1
            // 
            this.tbLibreta1.Location = new System.Drawing.Point(129, 59);
            this.tbLibreta1.Name = "tbLibreta1";
            this.tbLibreta1.Size = new System.Drawing.Size(100, 22);
            this.tbLibreta1.TabIndex = 3;
            // 
            // tbLibreta2
            // 
            this.tbLibreta2.Location = new System.Drawing.Point(129, 119);
            this.tbLibreta2.Name = "tbLibreta2";
            this.tbLibreta2.Size = new System.Drawing.Size(100, 22);
            this.tbLibreta2.TabIndex = 4;
            // 
            // tbLibreta3
            // 
            this.tbLibreta3.Location = new System.Drawing.Point(129, 182);
            this.tbLibreta3.Name = "tbLibreta3";
            this.tbLibreta3.Size = new System.Drawing.Size(100, 22);
            this.tbLibreta3.TabIndex = 5;
            // 
            // tbNombre1
            // 
            this.tbNombre1.Location = new System.Drawing.Point(356, 59);
            this.tbNombre1.Name = "tbNombre1";
            this.tbNombre1.Size = new System.Drawing.Size(100, 22);
            this.tbNombre1.TabIndex = 7;
            // 
            // lbNombre1
            // 
            this.lbNombre1.AutoSize = true;
            this.lbNombre1.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre1.Location = new System.Drawing.Point(286, 59);
            this.lbNombre1.Name = "lbNombre1";
            this.lbNombre1.Size = new System.Drawing.Size(61, 17);
            this.lbNombre1.TabIndex = 6;
            this.lbNombre1.Text = "Nombre";
            // 
            // tbNombre2
            // 
            this.tbNombre2.Location = new System.Drawing.Point(356, 119);
            this.tbNombre2.Name = "tbNombre2";
            this.tbNombre2.Size = new System.Drawing.Size(100, 22);
            this.tbNombre2.TabIndex = 9;
            // 
            // lbNombre2
            // 
            this.lbNombre2.AutoSize = true;
            this.lbNombre2.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre2.Location = new System.Drawing.Point(286, 119);
            this.lbNombre2.Name = "lbNombre2";
            this.lbNombre2.Size = new System.Drawing.Size(61, 17);
            this.lbNombre2.TabIndex = 8;
            this.lbNombre2.Text = "Nombre";
            // 
            // tbNombre3
            // 
            this.tbNombre3.Location = new System.Drawing.Point(356, 182);
            this.tbNombre3.Name = "tbNombre3";
            this.tbNombre3.Size = new System.Drawing.Size(100, 22);
            this.tbNombre3.TabIndex = 11;
            // 
            // lbNombre3
            // 
            this.lbNombre3.AutoSize = true;
            this.lbNombre3.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre3.Location = new System.Drawing.Point(286, 182);
            this.lbNombre3.Name = "lbNombre3";
            this.lbNombre3.Size = new System.Drawing.Size(61, 17);
            this.lbNombre3.TabIndex = 10;
            this.lbNombre3.Text = "Nombre";
            // 
            // btnRegistrarAlumno
            // 
            this.btnRegistrarAlumno.Location = new System.Drawing.Point(211, 226);
            this.btnRegistrarAlumno.Name = "btnRegistrarAlumno";
            this.btnRegistrarAlumno.Size = new System.Drawing.Size(118, 33);
            this.btnRegistrarAlumno.TabIndex = 12;
            this.btnRegistrarAlumno.Text = "Registrar Alumno";
            this.btnRegistrarAlumno.UseVisualStyleBackColor = true;
            this.btnRegistrarAlumno.Click += new System.EventHandler(this.btnRegistrarAlumno_Click);
            // 
            // boxMostrarAlumnos
            // 
            this.boxMostrarAlumnos.FormattingEnabled = true;
            this.boxMostrarAlumnos.ItemHeight = 16;
            this.boxMostrarAlumnos.Location = new System.Drawing.Point(62, 44);
            this.boxMostrarAlumnos.Name = "boxMostrarAlumnos";
            this.boxMostrarAlumnos.Size = new System.Drawing.Size(289, 180);
            this.boxMostrarAlumnos.TabIndex = 0;
            // 
            // btnActualizarBox
            // 
            this.btnActualizarBox.Location = new System.Drawing.Point(391, 108);
            this.btnActualizarBox.Name = "btnActualizarBox";
            this.btnActualizarBox.Size = new System.Drawing.Size(88, 59);
            this.btnActualizarBox.TabIndex = 1;
            this.btnActualizarBox.Text = "Actualizar";
            this.btnActualizarBox.UseVisualStyleBackColor = true;
            this.btnActualizarBox.Click += new System.EventHandler(this.btnActualizarBox_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 558);
            this.Controls.Add(this.gbMostrarLista);
            this.Controls.Add(this.gbNombreLibreta);
            this.Name = "Form3";
            this.Text = "Form1";
            this.gbNombreLibreta.ResumeLayout(false);
            this.gbNombreLibreta.PerformLayout();
            this.gbMostrarLista.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNombreLibreta;
        private System.Windows.Forms.TextBox tbLibreta1;
        private System.Windows.Forms.Label lbLibreta3;
        private System.Windows.Forms.Label lbLibreta2;
        private System.Windows.Forms.Label lbLibreta1;
        private System.Windows.Forms.GroupBox gbMostrarLista;
        private System.Windows.Forms.TextBox tbLibreta3;
        private System.Windows.Forms.TextBox tbLibreta2;
        private System.Windows.Forms.Button btnRegistrarAlumno;
        private System.Windows.Forms.TextBox tbNombre3;
        private System.Windows.Forms.Label lbNombre3;
        private System.Windows.Forms.TextBox tbNombre2;
        private System.Windows.Forms.Label lbNombre2;
        private System.Windows.Forms.TextBox tbNombre1;
        private System.Windows.Forms.Label lbNombre1;
        private System.Windows.Forms.ListBox boxMostrarAlumnos;
        private System.Windows.Forms.Button btnActualizarBox;
    }
}

