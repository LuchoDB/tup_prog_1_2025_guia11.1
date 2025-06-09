using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        string jugador1,jugador2;
        int setGanados1 = 0, setGanados2 = 0;
        int NumerosSetsRegistrados = 0;

        public void RegistrarJugadores(string nombre1,string nombre2)
        {
            jugador1 = nombre1;
            jugador2 = nombre2;
        }

        

        private void btnRegistrarJugadores_Click(object sender, EventArgs e)
        {
            RegistrarJugadores(tbNombre1.Text, tbNombre2.Text);
            tbNombre1.Clear();
            tbNombre2.Clear();
            lbNumeroSets.Text = "1"; // Mostramos que vamos a registrar el primer set
            lbResultados.Items.Clear();

        }

        private void lbResultados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NumerosSetsRegistrados == 3)
            {
                if (setGanados1 > setGanados2)
                {
                    lbResultados.Items.Clear();
                    lbResultados.Items.Add($"Ganador {jugador1}");
                }

                if (setGanados2 > setGanados1)
                {
                    lbResultados.Items.Clear();
                    lbResultados.Items.Add($"Ganador {jugador2}");

                }
            }
        }

        public void RegistrarResultadosSets(int resultado1, int resultado2)
        {
            int puntos1 = resultado1;
            int puntos2 = resultado2;
            if (puntos1 > puntos2)
            {
                setGanados1 += 1;
                NumerosSetsRegistrados += 1;
            }

            if (puntos2 > puntos1)
            {
                setGanados2 += 1;
                NumerosSetsRegistrados += 1;
            }
            if (NumerosSetsRegistrados < 3)
                lbNumeroSets.Text = (NumerosSetsRegistrados + 1).ToString();
            else
                lbNumeroSets.Text = "—";
        }

        private void btnAnotarPuntos_Click(object sender, EventArgs e)
        {
            if (NumerosSetsRegistrados < 3)
            {
                int puntos1 = (int)numericPuntosJ1.Value;
                int puntos2 = (int)numericPuntosJ2.Value;

                if (puntos1 == puntos2)
                {
                    MessageBox.Show("No se permiten empates. Ingrese puntajes distintos.");
                    return;
                }

                RegistrarResultadosSets(puntos1, puntos2);
                numericPuntosJ1.Value = 0;
                numericPuntosJ2.Value = 0;

                if (NumerosSetsRegistrados == 3)
                {
                    lbResultados_SelectedIndexChanged(null, null); // fuerza mostrar resultado
                }
            }
            else
            {
                MessageBox.Show("Ya se han registrado los 3 sets.");
            }

        }


    }
}
