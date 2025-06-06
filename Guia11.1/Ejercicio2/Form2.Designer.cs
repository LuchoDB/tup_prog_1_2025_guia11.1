namespace Ejercicio2
{
    partial class Form2
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
            this.boxPedirMonto = new System.Windows.Forms.GroupBox();
            this.boxEdades = new System.Windows.Forms.GroupBox();
            this.boxPorcentajes = new System.Windows.Forms.GroupBox();
            this.tbMonto = new System.Windows.Forms.TextBox();
            this.tbEdad1 = new System.Windows.Forms.TextBox();
            this.tbEdad2 = new System.Windows.Forms.TextBox();
            this.tbEdad3 = new System.Windows.Forms.TextBox();
            this.tbEdad4 = new System.Windows.Forms.TextBox();
            this.lbMonto = new System.Windows.Forms.Label();
            this.lbEdad1 = new System.Windows.Forms.Label();
            this.lbEdad3 = new System.Windows.Forms.Label();
            this.lbEdad2 = new System.Windows.Forms.Label();
            this.lbEdad4 = new System.Windows.Forms.Label();
            this.btRegistrarEdades = new System.Windows.Forms.Button();
            this.btRegistrarMonto = new System.Windows.Forms.Button();
            this.lBoxPorcentajes = new System.Windows.Forms.ListBox();
            this.btnActualizarPorcentaje = new System.Windows.Forms.Button();
            this.boxPedirMonto.SuspendLayout();
            this.boxEdades.SuspendLayout();
            this.boxPorcentajes.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxPedirMonto
            // 
            this.boxPedirMonto.Controls.Add(this.btRegistrarMonto);
            this.boxPedirMonto.Controls.Add(this.lbMonto);
            this.boxPedirMonto.Controls.Add(this.tbMonto);
            this.boxPedirMonto.Location = new System.Drawing.Point(52, 35);
            this.boxPedirMonto.Name = "boxPedirMonto";
            this.boxPedirMonto.Size = new System.Drawing.Size(467, 77);
            this.boxPedirMonto.TabIndex = 0;
            this.boxPedirMonto.TabStop = false;
            this.boxPedirMonto.Text = "Solicitud de Monto a Repartir";
            // 
            // boxEdades
            // 
            this.boxEdades.Controls.Add(this.btRegistrarEdades);
            this.boxEdades.Controls.Add(this.lbEdad4);
            this.boxEdades.Controls.Add(this.lbEdad2);
            this.boxEdades.Controls.Add(this.lbEdad3);
            this.boxEdades.Controls.Add(this.lbEdad1);
            this.boxEdades.Controls.Add(this.tbEdad4);
            this.boxEdades.Controls.Add(this.tbEdad3);
            this.boxEdades.Controls.Add(this.tbEdad2);
            this.boxEdades.Controls.Add(this.tbEdad1);
            this.boxEdades.Location = new System.Drawing.Point(52, 139);
            this.boxEdades.Name = "boxEdades";
            this.boxEdades.Size = new System.Drawing.Size(467, 221);
            this.boxEdades.TabIndex = 1;
            this.boxEdades.TabStop = false;
            this.boxEdades.Text = "Solicitud de las edades de las niñas";
            // 
            // boxPorcentajes
            // 
            this.boxPorcentajes.Controls.Add(this.btnActualizarPorcentaje);
            this.boxPorcentajes.Controls.Add(this.lBoxPorcentajes);
            this.boxPorcentajes.Location = new System.Drawing.Point(52, 396);
            this.boxPorcentajes.Name = "boxPorcentajes";
            this.boxPorcentajes.Size = new System.Drawing.Size(467, 191);
            this.boxPorcentajes.TabIndex = 2;
            this.boxPorcentajes.TabStop = false;
            this.boxPorcentajes.Text = "Monto y Porcentajes a las niñas";
            // 
            // tbMonto
            // 
            this.tbMonto.Location = new System.Drawing.Point(179, 31);
            this.tbMonto.Name = "tbMonto";
            this.tbMonto.Size = new System.Drawing.Size(100, 22);
            this.tbMonto.TabIndex = 0;
            // 
            // tbEdad1
            // 
            this.tbEdad1.Location = new System.Drawing.Point(104, 62);
            this.tbEdad1.Name = "tbEdad1";
            this.tbEdad1.Size = new System.Drawing.Size(100, 22);
            this.tbEdad1.TabIndex = 1;
            // 
            // tbEdad2
            // 
            this.tbEdad2.Location = new System.Drawing.Point(104, 116);
            this.tbEdad2.Name = "tbEdad2";
            this.tbEdad2.Size = new System.Drawing.Size(100, 22);
            this.tbEdad2.TabIndex = 2;
            // 
            // tbEdad3
            // 
            this.tbEdad3.Location = new System.Drawing.Point(302, 62);
            this.tbEdad3.Name = "tbEdad3";
            this.tbEdad3.Size = new System.Drawing.Size(100, 22);
            this.tbEdad3.TabIndex = 3;
            // 
            // tbEdad4
            // 
            this.tbEdad4.Location = new System.Drawing.Point(302, 114);
            this.tbEdad4.Name = "tbEdad4";
            this.tbEdad4.Size = new System.Drawing.Size(100, 22);
            this.tbEdad4.TabIndex = 4;
            // 
            // lbMonto
            // 
            this.lbMonto.AutoSize = true;
            this.lbMonto.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonto.Location = new System.Drawing.Point(17, 31);
            this.lbMonto.Name = "lbMonto";
            this.lbMonto.Size = new System.Drawing.Size(132, 20);
            this.lbMonto.TabIndex = 1;
            this.lbMonto.Text = "Monto a Repartir";
            // 
            // lbEdad1
            // 
            this.lbEdad1.AutoSize = true;
            this.lbEdad1.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEdad1.Location = new System.Drawing.Point(17, 64);
            this.lbEdad1.Name = "lbEdad1";
            this.lbEdad1.Size = new System.Drawing.Size(60, 20);
            this.lbEdad1.TabIndex = 2;
            this.lbEdad1.Text = "Edad1:";
            // 
            // lbEdad3
            // 
            this.lbEdad3.AutoSize = true;
            this.lbEdad3.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEdad3.Location = new System.Drawing.Point(219, 64);
            this.lbEdad3.Name = "lbEdad3";
            this.lbEdad3.Size = new System.Drawing.Size(60, 20);
            this.lbEdad3.TabIndex = 5;
            this.lbEdad3.Text = "Edad3:";
            // 
            // lbEdad2
            // 
            this.lbEdad2.AutoSize = true;
            this.lbEdad2.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEdad2.Location = new System.Drawing.Point(17, 118);
            this.lbEdad2.Name = "lbEdad2";
            this.lbEdad2.Size = new System.Drawing.Size(60, 20);
            this.lbEdad2.TabIndex = 6;
            this.lbEdad2.Text = "Edad2:";
            // 
            // lbEdad4
            // 
            this.lbEdad4.AutoSize = true;
            this.lbEdad4.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEdad4.Location = new System.Drawing.Point(219, 116);
            this.lbEdad4.Name = "lbEdad4";
            this.lbEdad4.Size = new System.Drawing.Size(60, 20);
            this.lbEdad4.TabIndex = 7;
            this.lbEdad4.Text = "Edad4:";
            // 
            // btRegistrarEdades
            // 
            this.btRegistrarEdades.Location = new System.Drawing.Point(149, 165);
            this.btRegistrarEdades.Name = "btRegistrarEdades";
            this.btRegistrarEdades.Size = new System.Drawing.Size(130, 50);
            this.btRegistrarEdades.TabIndex = 8;
            this.btRegistrarEdades.Text = "Registrar Edades";
            this.btRegistrarEdades.UseVisualStyleBackColor = true;
            this.btRegistrarEdades.Click += new System.EventHandler(this.btRegistrarEdades_Click);
            // 
            // btRegistrarMonto
            // 
            this.btRegistrarMonto.Location = new System.Drawing.Point(331, 17);
            this.btRegistrarMonto.Name = "btRegistrarMonto";
            this.btRegistrarMonto.Size = new System.Drawing.Size(130, 50);
            this.btRegistrarMonto.TabIndex = 9;
            this.btRegistrarMonto.Text = "Registrar Monto";
            this.btRegistrarMonto.UseVisualStyleBackColor = true;
            this.btRegistrarMonto.Click += new System.EventHandler(this.btRegistrarMonto_Click);
            // 
            // lBoxPorcentajes
            // 
            this.lBoxPorcentajes.FormattingEnabled = true;
            this.lBoxPorcentajes.ItemHeight = 16;
            this.lBoxPorcentajes.Location = new System.Drawing.Point(21, 31);
            this.lBoxPorcentajes.Name = "lBoxPorcentajes";
            this.lBoxPorcentajes.Size = new System.Drawing.Size(304, 148);
            this.lBoxPorcentajes.TabIndex = 0;
            // 
            // btnActualizarPorcentaje
            // 
            this.btnActualizarPorcentaje.Location = new System.Drawing.Point(331, 84);
            this.btnActualizarPorcentaje.Name = "btnActualizarPorcentaje";
            this.btnActualizarPorcentaje.Size = new System.Drawing.Size(130, 50);
            this.btnActualizarPorcentaje.TabIndex = 9;
            this.btnActualizarPorcentaje.Text = "Actualizar";
            this.btnActualizarPorcentaje.UseVisualStyleBackColor = true;
            this.btnActualizarPorcentaje.Click += new System.EventHandler(this.btnActualizarPorcentaje_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 636);
            this.Controls.Add(this.boxPorcentajes);
            this.Controls.Add(this.boxEdades);
            this.Controls.Add(this.boxPedirMonto);
            this.Name = "Form2";
            this.Text = "Ejercicio2 - Niñas";
            this.boxPedirMonto.ResumeLayout(false);
            this.boxPedirMonto.PerformLayout();
            this.boxEdades.ResumeLayout(false);
            this.boxEdades.PerformLayout();
            this.boxPorcentajes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox boxPedirMonto;
        private System.Windows.Forms.GroupBox boxEdades;
        private System.Windows.Forms.GroupBox boxPorcentajes;
        private System.Windows.Forms.TextBox tbMonto;
        private System.Windows.Forms.TextBox tbEdad1;
        private System.Windows.Forms.Button btRegistrarMonto;
        private System.Windows.Forms.Label lbMonto;
        private System.Windows.Forms.Button btRegistrarEdades;
        private System.Windows.Forms.Label lbEdad4;
        private System.Windows.Forms.Label lbEdad2;
        private System.Windows.Forms.Label lbEdad3;
        private System.Windows.Forms.Label lbEdad1;
        private System.Windows.Forms.TextBox tbEdad4;
        private System.Windows.Forms.TextBox tbEdad3;
        private System.Windows.Forms.TextBox tbEdad2;
        private System.Windows.Forms.ListBox lBoxPorcentajes;
        private System.Windows.Forms.Button btnActualizarPorcentaje;
    }
}

