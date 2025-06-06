using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int Edad0, Edad1, Edad2, Edad3;
        double Monto,Porcentaje0,Porcentaje1, Porcentaje2, Porcentaje3;
        double Monto0, Monto1, Monto2, Monto3;

        public double RegistrarMontoARepartir(double monto)
        {
            monto = Convert.ToDouble(tbMonto.Text);
            return monto;
        }
        private void btRegistrarMonto_Click(object sender, EventArgs e)
        {
           Monto = RegistrarMontoARepartir(Monto);
        }

        public int RegistrarEdades(int edad,int nroNiña)
        {
            Edad0 = Convert.ToInt32(tbEdad1.Text);
            Edad1 = Convert.ToInt32(tbEdad2.Text);
            Edad2 = Convert.ToInt32(tbEdad3.Text);
            Edad3 = Convert.ToInt32(tbEdad4.Text);

            return edad;
        }
        private void btRegistrarEdades_Click(object sender, EventArgs e)
        {
            RegistrarEdades(Edad0, 1);
            RegistrarEdades(Edad1, 2);
            RegistrarEdades(Edad2, 3);
            RegistrarEdades(Edad3, 4);
        }

        public void CalcularMontosYPorcentajesARepartir()
        {
            int suma = Edad0 + Edad1 + Edad2 + Edad3;
            Porcentaje0 = (double) (Edad0 * 100) / suma;
            Porcentaje1 = (double) (Edad1 * 100) / suma;
            Porcentaje2 = (double) (Edad2 * 100) / suma;
            Porcentaje3 = (double) (Edad3 * 100) / suma;
            Monto0 = (Porcentaje0 / 100) * Monto;
            Monto1 = (Porcentaje1 / 100) * Monto;
            Monto2 = (Porcentaje2 / 100) * Monto;
            Monto3 = (Porcentaje3 / 100) * Monto;

        }
        private void btnActualizarPorcentaje_Click(object sender, EventArgs e)
        { 
            CalcularMontosYPorcentajesARepartir();
            lBoxPorcentajes.Items.Clear();
            lBoxPorcentajes.Items.Add($"Niña 1 ({Edad0}), Porcentaje {Porcentaje0:F2}, Monto ${Monto0:F2}");
            lBoxPorcentajes.Items.Add($"Niña 2 ({Edad1}), Porcentaje {Porcentaje1:F2}, Monto ${Monto1:F2}");
            lBoxPorcentajes.Items.Add($"Niña 3 ({Edad2}), Porcentaje {Porcentaje2:F2}, Monto ${Monto2:F2}");
            lBoxPorcentajes.Items.Add($"Niña 4 ({Edad3}), Porcentaje {Porcentaje3:F2}, Monto ${Monto3:F2}");

        }

    }
}
