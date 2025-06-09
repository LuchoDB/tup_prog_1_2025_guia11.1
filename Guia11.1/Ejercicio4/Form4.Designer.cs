namespace Ejercicio4
{
    partial class Form4
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
            this.boxRegistrarJugadores = new System.Windows.Forms.GroupBox();
            this.btnRegistrarJugadores = new System.Windows.Forms.Button();
            this.tbNombre2 = new System.Windows.Forms.TextBox();
            this.tbNombre1 = new System.Windows.Forms.TextBox();
            this.lbJugador2 = new System.Windows.Forms.Label();
            this.lbJugador1 = new System.Windows.Forms.Label();
            this.boxAnotarSets = new System.Windows.Forms.GroupBox();
            this.btnAnotarPuntos = new System.Windows.Forms.Button();
            this.numericPuntosJ2 = new System.Windows.Forms.NumericUpDown();
            this.numericPuntosJ1 = new System.Windows.Forms.NumericUpDown();
            this.lbSetJ2 = new System.Windows.Forms.Label();
            this.lbSetJ1 = new System.Windows.Forms.Label();
            this.lbNumeroSets = new System.Windows.Forms.Label();
            this.lbTituloSets = new System.Windows.Forms.Label();
            this.boxResumen = new System.Windows.Forms.GroupBox();
            this.lbResultados = new System.Windows.Forms.ListBox();
            this.boxRegistrarJugadores.SuspendLayout();
            this.boxAnotarSets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPuntosJ2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPuntosJ1)).BeginInit();
            this.boxResumen.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxRegistrarJugadores
            // 
            this.boxRegistrarJugadores.Controls.Add(this.btnRegistrarJugadores);
            this.boxRegistrarJugadores.Controls.Add(this.tbNombre2);
            this.boxRegistrarJugadores.Controls.Add(this.tbNombre1);
            this.boxRegistrarJugadores.Controls.Add(this.lbJugador2);
            this.boxRegistrarJugadores.Controls.Add(this.lbJugador1);
            this.boxRegistrarJugadores.Location = new System.Drawing.Point(12, 12);
            this.boxRegistrarJugadores.Name = "boxRegistrarJugadores";
            this.boxRegistrarJugadores.Size = new System.Drawing.Size(512, 159);
            this.boxRegistrarJugadores.TabIndex = 0;
            this.boxRegistrarJugadores.TabStop = false;
            this.boxRegistrarJugadores.Text = "Registrar Jugadores";
            // 
            // btnRegistrarJugadores
            // 
            this.btnRegistrarJugadores.Location = new System.Drawing.Point(385, 54);
            this.btnRegistrarJugadores.Name = "btnRegistrarJugadores";
            this.btnRegistrarJugadores.Size = new System.Drawing.Size(105, 57);
            this.btnRegistrarJugadores.TabIndex = 4;
            this.btnRegistrarJugadores.Text = "Registrar Jugadores";
            this.btnRegistrarJugadores.UseVisualStyleBackColor = true;
            this.btnRegistrarJugadores.Click += new System.EventHandler(this.btnRegistrarJugadores_Click);
            // 
            // tbNombre2
            // 
            this.tbNombre2.Location = new System.Drawing.Point(190, 101);
            this.tbNombre2.Name = "tbNombre2";
            this.tbNombre2.Size = new System.Drawing.Size(139, 22);
            this.tbNombre2.TabIndex = 3;
            // 
            // tbNombre1
            // 
            this.tbNombre1.Location = new System.Drawing.Point(190, 52);
            this.tbNombre1.Name = "tbNombre1";
            this.tbNombre1.Size = new System.Drawing.Size(139, 22);
            this.tbNombre1.TabIndex = 2;
            // 
            // lbJugador2
            // 
            this.lbJugador2.AutoSize = true;
            this.lbJugador2.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJugador2.Location = new System.Drawing.Point(49, 106);
            this.lbJugador2.Name = "lbJugador2";
            this.lbJugador2.Size = new System.Drawing.Size(127, 17);
            this.lbJugador2.TabIndex = 1;
            this.lbJugador2.Text = "Nombre Jugador 2";
            // 
            // lbJugador1
            // 
            this.lbJugador1.AutoSize = true;
            this.lbJugador1.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJugador1.Location = new System.Drawing.Point(49, 54);
            this.lbJugador1.Name = "lbJugador1";
            this.lbJugador1.Size = new System.Drawing.Size(127, 17);
            this.lbJugador1.TabIndex = 0;
            this.lbJugador1.Text = "Nombre Jugador 1";
            // 
            // boxAnotarSets
            // 
            this.boxAnotarSets.Controls.Add(this.btnAnotarPuntos);
            this.boxAnotarSets.Controls.Add(this.numericPuntosJ2);
            this.boxAnotarSets.Controls.Add(this.numericPuntosJ1);
            this.boxAnotarSets.Controls.Add(this.lbSetJ2);
            this.boxAnotarSets.Controls.Add(this.lbSetJ1);
            this.boxAnotarSets.Controls.Add(this.lbNumeroSets);
            this.boxAnotarSets.Controls.Add(this.lbTituloSets);
            this.boxAnotarSets.Location = new System.Drawing.Point(12, 187);
            this.boxAnotarSets.Name = "boxAnotarSets";
            this.boxAnotarSets.Size = new System.Drawing.Size(512, 159);
            this.boxAnotarSets.TabIndex = 1;
            this.boxAnotarSets.TabStop = false;
            this.boxAnotarSets.Text = "Anotar Sets";
            // 
            // btnAnotarPuntos
            // 
            this.btnAnotarPuntos.Location = new System.Drawing.Point(385, 73);
            this.btnAnotarPuntos.Name = "btnAnotarPuntos";
            this.btnAnotarPuntos.Size = new System.Drawing.Size(105, 57);
            this.btnAnotarPuntos.TabIndex = 5;
            this.btnAnotarPuntos.Text = "Anotar Puntos";
            this.btnAnotarPuntos.UseVisualStyleBackColor = true;
            this.btnAnotarPuntos.Click += new System.EventHandler(this.btnAnotarPuntos_Click);
            // 
            // numericPuntosJ2
            // 
            this.numericPuntosJ2.Location = new System.Drawing.Point(189, 93);
            this.numericPuntosJ2.Name = "numericPuntosJ2";
            this.numericPuntosJ2.Size = new System.Drawing.Size(101, 22);
            this.numericPuntosJ2.TabIndex = 7;
            // 
            // numericPuntosJ1
            // 
            this.numericPuntosJ1.Location = new System.Drawing.Point(33, 93);
            this.numericPuntosJ1.Name = "numericPuntosJ1";
            this.numericPuntosJ1.Size = new System.Drawing.Size(101, 22);
            this.numericPuntosJ1.TabIndex = 6;
            // 
            // lbSetJ2
            // 
            this.lbSetJ2.AutoSize = true;
            this.lbSetJ2.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSetJ2.Location = new System.Drawing.Point(206, 73);
            this.lbSetJ2.Name = "lbSetJ2";
            this.lbSetJ2.Size = new System.Drawing.Size(70, 17);
            this.lbSetJ2.TabIndex = 5;
            this.lbSetJ2.Text = "Jugador 2";
            // 
            // lbSetJ1
            // 
            this.lbSetJ1.AutoSize = true;
            this.lbSetJ1.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSetJ1.Location = new System.Drawing.Point(49, 73);
            this.lbSetJ1.Name = "lbSetJ1";
            this.lbSetJ1.Size = new System.Drawing.Size(70, 17);
            this.lbSetJ1.TabIndex = 4;
            this.lbSetJ1.Text = "Jugador 1";
            // 
            // lbNumeroSets
            // 
            this.lbNumeroSets.AutoSize = true;
            this.lbNumeroSets.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumeroSets.Location = new System.Drawing.Point(286, 34);
            this.lbNumeroSets.Name = "lbNumeroSets";
            this.lbNumeroSets.Size = new System.Drawing.Size(65, 17);
            this.lbNumeroSets.TabIndex = 3;
            this.lbNumeroSets.Text = "lbNroSet";
            // 
            // lbTituloSets
            // 
            this.lbTituloSets.AutoSize = true;
            this.lbTituloSets.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloSets.Location = new System.Drawing.Point(166, 34);
            this.lbTituloSets.Name = "lbTituloSets";
            this.lbTituloSets.Size = new System.Drawing.Size(114, 17);
            this.lbTituloSets.TabIndex = 2;
            this.lbTituloSets.Text = "Numero de Sets:";
            // 
            // boxResumen
            // 
            this.boxResumen.Controls.Add(this.lbResultados);
            this.boxResumen.Location = new System.Drawing.Point(12, 352);
            this.boxResumen.Name = "boxResumen";
            this.boxResumen.Size = new System.Drawing.Size(512, 159);
            this.boxResumen.TabIndex = 1;
            this.boxResumen.TabStop = false;
            this.boxResumen.Text = "Resumen";
            // 
            // lbResultados
            // 
            this.lbResultados.FormattingEnabled = true;
            this.lbResultados.ItemHeight = 16;
            this.lbResultados.Location = new System.Drawing.Point(37, 25);
            this.lbResultados.Name = "lbResultados";
            this.lbResultados.Size = new System.Drawing.Size(428, 116);
            this.lbResultados.TabIndex = 0;
            this.lbResultados.SelectedIndexChanged += new System.EventHandler(this.lbResultados_SelectedIndexChanged);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 558);
            this.Controls.Add(this.boxResumen);
            this.Controls.Add(this.boxAnotarSets);
            this.Controls.Add(this.boxRegistrarJugadores);
            this.Name = "Form4";
            this.Text = "Ejercicio 4 - Tenis";
            this.boxRegistrarJugadores.ResumeLayout(false);
            this.boxRegistrarJugadores.PerformLayout();
            this.boxAnotarSets.ResumeLayout(false);
            this.boxAnotarSets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPuntosJ2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPuntosJ1)).EndInit();
            this.boxResumen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox boxRegistrarJugadores;
        private System.Windows.Forms.GroupBox boxAnotarSets;
        private System.Windows.Forms.GroupBox boxResumen;
        private System.Windows.Forms.Label lbJugador1;
        private System.Windows.Forms.Label lbJugador2;
        private System.Windows.Forms.Label lbTituloSets;
        private System.Windows.Forms.NumericUpDown numericPuntosJ2;
        private System.Windows.Forms.NumericUpDown numericPuntosJ1;
        private System.Windows.Forms.Label lbSetJ2;
        private System.Windows.Forms.Label lbSetJ1;
        private System.Windows.Forms.Label lbNumeroSets;
        private System.Windows.Forms.Button btnRegistrarJugadores;
        private System.Windows.Forms.TextBox tbNombre2;
        private System.Windows.Forms.TextBox tbNombre1;
        private System.Windows.Forms.ListBox lbResultados;
        private System.Windows.Forms.Button btnAnotarPuntos;
    }
}

