using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        int d, m, a;

        public int DeterminarLosDiasDelAño(int mes, int año)
        {
            d = 0;
            switch (mes)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    d = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    d = 30;
                    break;
                case 2:
                    if (DeterminarSiEsBisiesto(año))
                    {
                        d = 29;
                    }
                    else
                    {
                        d = 28;
                    }
                    break;
                default:
                    MessageBox.Show("Ingrese un mes válido");
                    break;
            }
            return d;
        }

        public bool DeterminarSiEsBisiesto(int año)
        {
            return año % 4 == 0 && ((año % 100 != 0) || (año % 400 == 0));
        }

        private void btnCalcularBisiesto_Click(object sender, EventArgs e)
        {
            int dias = DeterminarLosDiasDelAño((int)numericMes.Value, (int)numericAño.Value);
            lbCantidadDias.Text = $"{dias}";
            lbEsBisiesto.Text = DeterminarSiEsBisiesto((int)numericAño.Value) ? "Es Bisiesto" : "No es Bisiesto";
        }
    }
}
