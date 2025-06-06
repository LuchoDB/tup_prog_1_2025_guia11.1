using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1_Aux
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        int acumulador = 0;
        int contador = 0;
        int maximo = -1;
        int minimo = 99999;
        private void btRegistrarNum_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(tbPedirNum.Text);
            acumulador += n;
            contador++;
            tbPedirNum.Clear();

            if (n > maximo)
            {
                maximo = n;
            }
            if (n < minimo)
            {
                minimo = n;
            }
        }

        private void btnMaxMin_Click(object sender, EventArgs e)
        {

            lbMostrarMax.Text = maximo.ToString();
            lbMostrarMin.Text = minimo.ToString();
        }

        public double Promedio()
        {
            return (double)acumulador / contador;
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            lbMostrarPromedio.Text = Promedio().ToString("0.00");
        }

        private void btnMostrarCantidad_Click(object sender, EventArgs e)
        {
            lbMostarCant.Text = contador.ToString();
        }

        private void btnReinicio_Click(object sender, EventArgs e)
        {
            acumulador = 0;
            contador = 0;
            maximo = -1;
            minimo = 99999;
            lbMostrarMax.Text = "0";
            lbMostrarMin.Text = "0";
            lbMostrarPromedio.Text = "0.00";
            lbMostarCant.Text = "0";
        }
    }
}
