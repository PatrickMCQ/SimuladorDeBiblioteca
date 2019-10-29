using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SimuladorDeBiblioteca
{
    public partial class FormEliminarCiencia : Form
    {
        public FormEliminarCiencia()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            StreamReader Lectura;
            StreamWriter escribir;
            String cadena, libro;
            bool encontrado = false; ;
            string[] campo = new string[5];
            char[] separador = { ',' };

            try
            {
                Lectura = File.OpenText("Ciencia.txt");
                escribir = File.CreateText("tmp.txt");
                libro = txtEliminar.Text;
                cadena = Lectura.ReadLine();
                while (cadena != null)
                {
                    campo = cadena.Split(separador);
                    if (campo[1].Trim().Equals(libro))
                    {

                        encontrado = true;
                    }
                    else
                    {
                        escribir.WriteLine(cadena);

                    }
                    cadena = Lectura.ReadLine();
                }

                if (encontrado == false)
                {
                    labelNombre.Text = "No existe";
                }
                else
                {
                    labelNombre.Text = "Libro eliminado";
                }
                Lectura.Close();
                escribir.Close();

                File.Delete("Ciencia.txt");
                File.Move("tmp.txt", "Ciencia.txt");
            }
            catch (FileNotFoundException fe)
            {
                labelNombre.Text = ("¡ERROR!" + fe.Message);
            }
        }
    }
}
