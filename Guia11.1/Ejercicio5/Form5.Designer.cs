namespace Ejercicio5
{
    partial class Form5
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
            this.gbAñoBisiesto = new System.Windows.Forms.GroupBox();
            this.numericAño = new System.Windows.Forms.NumericUpDown();
            this.numericMes = new System.Windows.Forms.NumericUpDown();
            this.lbEsBisiesto = new System.Windows.Forms.Label();
            this.lbCantidadDias = new System.Windows.Forms.Label();
            this.lbAñoBisiesto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAño = new System.Windows.Forms.Label();
            this.lbMes = new System.Windows.Forms.Label();
            this.btnCalcularBisiesto = new System.Windows.Forms.Button();
            this.gbAñoBisiesto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAño)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMes)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAñoBisiesto
            // 
            this.gbAñoBisiesto.Controls.Add(this.btnCalcularBisiesto);
            this.gbAñoBisiesto.Controls.Add(this.numericAño);
            this.gbAñoBisiesto.Controls.Add(this.numericMes);
            this.gbAñoBisiesto.Controls.Add(this.lbEsBisiesto);
            this.gbAñoBisiesto.Controls.Add(this.lbCantidadDias);
            this.gbAñoBisiesto.Controls.Add(this.lbAñoBisiesto);
            this.gbAñoBisiesto.Controls.Add(this.label1);
            this.gbAñoBisiesto.Controls.Add(this.lbAño);
            this.gbAñoBisiesto.Controls.Add(this.lbMes);
            this.gbAñoBisiesto.Location = new System.Drawing.Point(12, 12);
            this.gbAñoBisiesto.Name = "gbAñoBisiesto";
            this.gbAñoBisiesto.Size = new System.Drawing.Size(450, 226);
            this.gbAñoBisiesto.TabIndex = 0;
            this.gbAñoBisiesto.TabStop = false;
            this.gbAñoBisiesto.Text = "Determinar los dias del mes";
            // 
            // numericAño
            // 
            this.numericAño.Location = new System.Drawing.Point(207, 88);
            this.numericAño.Maximum = new decimal(new int[] {
                9999, 0, 0, 0}); // Puedes poner un valor aún mayor si lo necesitas
            this.numericAño.Name = "numericAño";
            this.numericAño.Size = new System.Drawing.Size(84, 22);
            this.numericAño.TabIndex = 7;
            // 
            // numericMes
            // 
            this.numericMes.Location = new System.Drawing.Point(55, 88);
            this.numericMes.Name = "numericMes";
            this.numericMes.Size = new System.Drawing.Size(84, 22);
            this.numericMes.TabIndex = 6;
            // 
            // lbEsBisiesto
            // 
            this.lbEsBisiesto.AutoSize = true;
            this.lbEsBisiesto.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEsBisiesto.Location = new System.Drawing.Point(197, 189);
            this.lbEsBisiesto.Name = "lbEsBisiesto";
            this.lbEsBisiesto.Size = new System.Drawing.Size(86, 17);
            this.lbEsBisiesto.TabIndex = 5;
            this.lbEsBisiesto.Text = "lbEsBisiesto";
            // 
            // lbCantidadDias
            // 
            this.lbCantidadDias.AutoSize = true;
            this.lbCantidadDias.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantidadDias.Location = new System.Drawing.Point(197, 152);
            this.lbCantidadDias.Name = "lbCantidadDias";
            this.lbCantidadDias.Size = new System.Drawing.Size(107, 17);
            this.lbCantidadDias.TabIndex = 4;
            this.lbCantidadDias.Text = "lbCantidadDias";
            // 
            // lbAñoBisiesto
            // 
            this.lbAñoBisiesto.AutoSize = true;
            this.lbAñoBisiesto.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAñoBisiesto.Location = new System.Drawing.Point(52, 189);
            this.lbAñoBisiesto.Name = "lbAñoBisiesto";
            this.lbAñoBisiesto.Size = new System.Drawing.Size(122, 17);
            this.lbAñoBisiesto.TabIndex = 3;
            this.lbAñoBisiesto.Text = "¿Es Año Bisiesto?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cantidad de Dias:";
            // 
            // lbAño
            // 
            this.lbAño.AutoSize = true;
            this.lbAño.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAño.Location = new System.Drawing.Point(232, 68);
            this.lbAño.Name = "lbAño";
            this.lbAño.Size = new System.Drawing.Size(40, 17);
            this.lbAño.TabIndex = 1;
            this.lbAño.Text = "Año:";
            // 
            // lbMes
            // 
            this.lbMes.AutoSize = true;
            this.lbMes.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMes.Location = new System.Drawing.Point(74, 68);
            this.lbMes.Name = "lbMes";
            this.lbMes.Size = new System.Drawing.Size(40, 17);
            this.lbMes.TabIndex = 0;
            this.lbMes.Text = "Mes:";
            // 
            // btnCalcularBisiesto
            // 
            this.btnCalcularBisiesto.Location = new System.Drawing.Point(337, 126);
            this.btnCalcularBisiesto.Name = "btnCalcularBisiesto";
            this.btnCalcularBisiesto.Size = new System.Drawing.Size(89, 59);
            this.btnCalcularBisiesto.TabIndex = 8;
            this.btnCalcularBisiesto.Text = "Calcular";
            this.btnCalcularBisiesto.UseVisualStyleBackColor = true;
            this.btnCalcularBisiesto.Click += new System.EventHandler(this.btnCalcularBisiesto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 250);
            this.Controls.Add(this.gbAñoBisiesto);
            this.Name = "Form1";
            this.Text = "Ejercicio 5 - Año Bisisesto";
            this.gbAñoBisiesto.ResumeLayout(false);
            this.gbAñoBisiesto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAño)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAñoBisiesto;
        private System.Windows.Forms.Label lbMes;
        private System.Windows.Forms.NumericUpDown numericAño;
        private System.Windows.Forms.NumericUpDown numericMes;
        private System.Windows.Forms.Label lbEsBisiesto;
        private System.Windows.Forms.Label lbCantidadDias;
        private System.Windows.Forms.Label lbAñoBisiesto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbAño;
        private System.Windows.Forms.Button btnCalcularBisiesto;
    }
}

