using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public string nombre0;
        public string nombre1;
        public string nombre2;
        public int numLibreta0;
        public int numLibreta1;
        public int numLibreta2;
        public int orden = 0;


        public void RegistrarNombreYNumeroLibreta(string nombre, int numeroLibreta)
        {
            if (orden == 0)
            {
                nombre0 = nombre;
                numLibreta0 = numeroLibreta;
            }
            else if (orden == 1)
            {
                if (numeroLibreta < numLibreta0)
                {
                    nombre1 = nombre0;
                    numLibreta1 = numLibreta0;
                    nombre0 = nombre;
                    numLibreta0 = numeroLibreta;
                }
                else
                {
                    nombre1 = nombre;
                    numLibreta1 = numeroLibreta;
                }
            }
            else if (orden == 2)
            {
                if (numeroLibreta < numLibreta0)
                {
                    nombre2 = nombre1;
                    numLibreta2 = numLibreta1;
                    nombre1 = nombre0;
                    numLibreta1 = numLibreta0;
                    nombre0 = nombre;
                    numLibreta0 = numeroLibreta;
                }
                if (numeroLibreta < numLibreta1)
                {
                    nombre2 = nombre1;
                    numLibreta2 = numLibreta1;
                    nombre1 = nombre;
                    numLibreta1 = numeroLibreta;
                }
                else
                {
                    nombre2 = nombre;
                    numLibreta2 = numeroLibreta;
                }
            }
            orden++;
        }
        private void btnRegistrarAlumno_Click(object sender, EventArgs e)
        { 
            RegistrarNombreYNumeroLibreta(tbNombre1.Text, int.Parse(tbLibreta1.Text));
            RegistrarNombreYNumeroLibreta(tbNombre2.Text, int.Parse(tbLibreta2.Text));
            RegistrarNombreYNumeroLibreta(tbNombre3.Text, int.Parse(tbLibreta3.Text));
        }

        
        private void btnActualizarBox_Click(object sender, EventArgs e)
        {
            boxMostrarAlumnos.Items.Clear();
            boxMostrarAlumnos.Items.Add($"{nombre0}| {numLibreta0}");
            boxMostrarAlumnos.Items.Add($"{nombre1}| {numLibreta1}");
            boxMostrarAlumnos.Items.Add($"{nombre2}| {numLibreta2}");
        }
    }
}
