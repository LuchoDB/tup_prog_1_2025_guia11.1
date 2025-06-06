namespace Ejercicio1_Aux
{
    partial class Ejercicio1
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
            this.boxProcesarNumeros = new System.Windows.Forms.GroupBox();
            this.tbPedirNum = new System.Windows.Forms.TextBox();
            this.btRegistrarNum = new System.Windows.Forms.Button();
            this.lbIngresoNum = new System.Windows.Forms.Label();
            this.boxMaxMin = new System.Windows.Forms.GroupBox();
            this.btnMaxMin = new System.Windows.Forms.Button();
            this.lbMostrarMin = new System.Windows.Forms.Label();
            this.lbMostrarMax = new System.Windows.Forms.Label();
            this.lbMin = new System.Windows.Forms.Label();
            this.lbMax = new System.Windows.Forms.Label();
            this.boxPromedio = new System.Windows.Forms.GroupBox();
            this.btnPromedio = new System.Windows.Forms.Button();
            this.lbMostrarPromedio = new System.Windows.Forms.Label();
            this.lbPromedio = new System.Windows.Forms.Label();
            this.boxCantidad = new System.Windows.Forms.GroupBox();
            this.btnMostrarCantidad = new System.Windows.Forms.Button();
            this.lbMostarCant = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReinicio = new System.Windows.Forms.Button();
            this.boxProcesarNumeros.SuspendLayout();
            this.boxMaxMin.SuspendLayout();
            this.boxPromedio.SuspendLayout();
            this.boxCantidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxProcesarNumeros
            // 
            this.boxProcesarNumeros.Controls.Add(this.tbPedirNum);
            this.boxProcesarNumeros.Controls.Add(this.btRegistrarNum);
            this.boxProcesarNumeros.Controls.Add(this.lbIngresoNum);
            this.boxProcesarNumeros.Location = new System.Drawing.Point(56, 36);
            this.boxProcesarNumeros.Name = "boxProcesarNumeros";
            this.boxProcesarNumeros.Size = new System.Drawing.Size(441, 137);
            this.boxProcesarNumeros.TabIndex = 0;
            this.boxProcesarNumeros.TabStop = false;
            this.boxProcesarNumeros.Text = "Procesar Numeros Ingresados";
            // 
            // tbPedirNum
            // 
            this.tbPedirNum.Location = new System.Drawing.Point(201, 52);
            this.tbPedirNum.Name = "tbPedirNum";
            this.tbPedirNum.Size = new System.Drawing.Size(100, 22);
            this.tbPedirNum.TabIndex = 2;
            // 
            // btRegistrarNum
            // 
            this.btRegistrarNum.Location = new System.Drawing.Point(122, 93);
            this.btRegistrarNum.Name = "btRegistrarNum";
            this.btRegistrarNum.Size = new System.Drawing.Size(149, 31);
            this.btRegistrarNum.TabIndex = 1;
            this.btRegistrarNum.Text = "Registrar número";
            this.btRegistrarNum.UseVisualStyleBackColor = true;
            this.btRegistrarNum.Click += new System.EventHandler(this.btRegistrarNum_Click);
            // 
            // lbIngresoNum
            // 
            this.lbIngresoNum.AutoSize = true;
            this.lbIngresoNum.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIngresoNum.Location = new System.Drawing.Point(35, 52);
            this.lbIngresoNum.Name = "lbIngresoNum";
            this.lbIngresoNum.Size = new System.Drawing.Size(142, 20);
            this.lbIngresoNum.TabIndex = 0;
            this.lbIngresoNum.Text = "Ingrese un numero";
            // 
            // boxMaxMin
            // 
            this.boxMaxMin.Controls.Add(this.btnMaxMin);
            this.boxMaxMin.Controls.Add(this.lbMostrarMin);
            this.boxMaxMin.Controls.Add(this.lbMostrarMax);
            this.boxMaxMin.Controls.Add(this.lbMin);
            this.boxMaxMin.Controls.Add(this.lbMax);
            this.boxMaxMin.Location = new System.Drawing.Point(56, 214);
            this.boxMaxMin.Name = "boxMaxMin";
            this.boxMaxMin.Size = new System.Drawing.Size(441, 131);
            this.boxMaxMin.TabIndex = 1;
            this.boxMaxMin.TabStop = false;
            this.boxMaxMin.Text = "Procesar Maximo y minimo";
            // 
            // btnMaxMin
            // 
            this.btnMaxMin.Location = new System.Drawing.Point(297, 46);
            this.btnMaxMin.Name = "btnMaxMin";
            this.btnMaxMin.Size = new System.Drawing.Size(112, 60);
            this.btnMaxMin.TabIndex = 5;
            this.btnMaxMin.Text = "Actualizar";
            this.btnMaxMin.UseVisualStyleBackColor = true;
            this.btnMaxMin.Click += new System.EventHandler(this.btnMaxMin_Click);
            // 
            // lbMostrarMin
            // 
            this.lbMostrarMin.AutoSize = true;
            this.lbMostrarMin.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMostrarMin.Location = new System.Drawing.Point(141, 86);
            this.lbMostrarMin.Name = "lbMostrarMin";
            this.lbMostrarMin.Size = new System.Drawing.Size(81, 20);
            this.lbMostrarMin.TabIndex = 4;
            this.lbMostrarMin.Text = "lbMinimo";
            // 
            // lbMostrarMax
            // 
            this.lbMostrarMax.AutoSize = true;
            this.lbMostrarMax.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMostrarMax.Location = new System.Drawing.Point(141, 46);
            this.lbMostrarMax.Name = "lbMostrarMax";
            this.lbMostrarMax.Size = new System.Drawing.Size(84, 20);
            this.lbMostrarMax.TabIndex = 3;
            this.lbMostrarMax.Text = "lbMaximo";
            // 
            // lbMin
            // 
            this.lbMin.AutoSize = true;
            this.lbMin.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMin.Location = new System.Drawing.Point(35, 86);
            this.lbMin.Name = "lbMin";
            this.lbMin.Size = new System.Drawing.Size(67, 20);
            this.lbMin.TabIndex = 2;
            this.lbMin.Text = "Minimo";
            // 
            // lbMax
            // 
            this.lbMax.AutoSize = true;
            this.lbMax.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMax.Location = new System.Drawing.Point(35, 46);
            this.lbMax.Name = "lbMax";
            this.lbMax.Size = new System.Drawing.Size(70, 20);
            this.lbMax.TabIndex = 1;
            this.lbMax.Text = "Maximo";
            // 
            // boxPromedio
            // 
            this.boxPromedio.Controls.Add(this.btnPromedio);
            this.boxPromedio.Controls.Add(this.lbMostrarPromedio);
            this.boxPromedio.Controls.Add(this.lbPromedio);
            this.boxPromedio.Location = new System.Drawing.Point(56, 372);
            this.boxPromedio.Name = "boxPromedio";
            this.boxPromedio.Size = new System.Drawing.Size(441, 91);
            this.boxPromedio.TabIndex = 1;
            this.boxPromedio.TabStop = false;
            this.boxPromedio.Text = "Procesar Promedio";
            // 
            // btnPromedio
            // 
            this.btnPromedio.Location = new System.Drawing.Point(297, 21);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(112, 60);
            this.btnPromedio.TabIndex = 6;
            this.btnPromedio.Text = "Actualizar";
            this.btnPromedio.UseVisualStyleBackColor = true;
            this.btnPromedio.Click += new System.EventHandler(this.btnPromedio_Click);
            // 
            // lbMostrarPromedio
            // 
            this.lbMostrarPromedio.AutoSize = true;
            this.lbMostrarPromedio.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMostrarPromedio.Location = new System.Drawing.Point(141, 44);
            this.lbMostrarPromedio.Name = "lbMostrarPromedio";
            this.lbMostrarPromedio.Size = new System.Drawing.Size(93, 20);
            this.lbMostrarPromedio.TabIndex = 5;
            this.lbMostrarPromedio.Text = "lbPromedio";
            // 
            // lbPromedio
            // 
            this.lbPromedio.AutoSize = true;
            this.lbPromedio.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPromedio.Location = new System.Drawing.Point(35, 44);
            this.lbPromedio.Name = "lbPromedio";
            this.lbPromedio.Size = new System.Drawing.Size(79, 20);
            this.lbPromedio.TabIndex = 3;
            this.lbPromedio.Text = "Promedio";
            // 
            // boxCantidad
            // 
            this.boxCantidad.Controls.Add(this.btnMostrarCantidad);
            this.boxCantidad.Controls.Add(this.lbMostarCant);
            this.boxCantidad.Controls.Add(this.label4);
            this.boxCantidad.Location = new System.Drawing.Point(56, 488);
            this.boxCantidad.Name = "boxCantidad";
            this.boxCantidad.Size = new System.Drawing.Size(441, 91);
            this.boxCantidad.TabIndex = 2;
            this.boxCantidad.TabStop = false;
            this.boxCantidad.Text = "Procesar Cantidad de numeros ingresados";
            // 
            // btnMostrarCantidad
            // 
            this.btnMostrarCantidad.Location = new System.Drawing.Point(297, 21);
            this.btnMostrarCantidad.Name = "btnMostrarCantidad";
            this.btnMostrarCantidad.Size = new System.Drawing.Size(112, 60);
            this.btnMostrarCantidad.TabIndex = 7;
            this.btnMostrarCantidad.Text = "Actualizar";
            this.btnMostrarCantidad.UseVisualStyleBackColor = true;
            this.btnMostrarCantidad.Click += new System.EventHandler(this.btnMostrarCantidad_Click);
            // 
            // lbMostarCant
            // 
            this.lbMostarCant.AutoSize = true;
            this.lbMostarCant.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMostarCant.Location = new System.Drawing.Point(141, 43);
            this.lbMostarCant.Name = "lbMostarCant";
            this.lbMostarCant.Size = new System.Drawing.Size(88, 20);
            this.lbMostarCant.TabIndex = 6;
            this.lbMostarCant.Text = "lbCantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cantidad";
            // 
            // btnReinicio
            // 
            this.btnReinicio.Location = new System.Drawing.Point(178, 605);
            this.btnReinicio.Name = "btnReinicio";
            this.btnReinicio.Size = new System.Drawing.Size(165, 44);
            this.btnReinicio.TabIndex = 6;
            this.btnReinicio.Text = "Reiniciar Variables";
            this.btnReinicio.UseVisualStyleBackColor = true;
            this.btnReinicio.Click += new System.EventHandler(this.btnReinicio_Click);
            // 
            // Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 661);
            this.Controls.Add(this.btnReinicio);
            this.Controls.Add(this.boxCantidad);
            this.Controls.Add(this.boxPromedio);
            this.Controls.Add(this.boxMaxMin);
            this.Controls.Add(this.boxProcesarNumeros);
            this.Name = "Ejercicio1";
            this.Text = "Ejercicio 1";
            this.boxProcesarNumeros.ResumeLayout(false);
            this.boxProcesarNumeros.PerformLayout();
            this.boxMaxMin.ResumeLayout(false);
            this.boxMaxMin.PerformLayout();
            this.boxPromedio.ResumeLayout(false);
            this.boxPromedio.PerformLayout();
            this.boxCantidad.ResumeLayout(false);
            this.boxCantidad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox boxProcesarNumeros;
        private System.Windows.Forms.Label lbIngresoNum;
        private System.Windows.Forms.GroupBox boxMaxMin;
        private System.Windows.Forms.Label lbMostrarMax;
        private System.Windows.Forms.Label lbMin;
        private System.Windows.Forms.Label lbMax;
        private System.Windows.Forms.GroupBox boxPromedio;
        private System.Windows.Forms.Label lbPromedio;
        private System.Windows.Forms.GroupBox boxCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbMostrarMin;
        private System.Windows.Forms.Label lbMostrarPromedio;
        private System.Windows.Forms.Label lbMostarCant;
        private System.Windows.Forms.Button btRegistrarNum;
        private System.Windows.Forms.Button btnMaxMin;
        private System.Windows.Forms.TextBox tbPedirNum;
        private System.Windows.Forms.Button btnPromedio;
        private System.Windows.Forms.Button btnMostrarCantidad;
        private System.Windows.Forms.Button btnReinicio;
    }
}

