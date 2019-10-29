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
    public partial class FormRomance : Form
    {
        public FormRomance()
        {
            InitializeComponent();
            panelContenedorRomanceMas.Visible = false;
            panelContenedorRomance.Visible = false;
        }

        private void AbrirFormHija(object formhija)
        {
            if (this.panelContenedorRomance.Controls.Count > 0)
                this.panelContenedorRomance.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedorRomance.Controls.Add(fh);
            this.panelContenedorRomance.Tag = fh;
            fh.Show();

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            panelContenedorRomance.Visible = true;
            AbrirFormHija(new FormIngresarRomance());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            panelContenedorRomance.Visible = true;
            AbrirFormHija(new FormBuscarOpcionesRomance());
        }

        private void btnMas1_Click(object sender, EventArgs e)
        {
            StreamReader Lectura;
            String cadena, libro;
            bool encontrado = false; ;
            string[] campo = new string[5];
            char[] separador = { ',' };

            try
            {
                Lectura = File.OpenText("Romance.txt");
                libro = labelPrimera.Text;
                cadena = Lectura.ReadLine();
                while (cadena != null && encontrado == false)
                {
                    campo = cadena.Split(separador);
                    if (campo[1].Trim().Equals(libro))
                    {
                        txtRomanceCodigo.Text = campo[0];
                        txtRomanceNombre.Text = campo[1];
                        txtRomanceAutor.Text = campo[2];
                        txtRomanceYear.Text = campo[3];
                        txtRomancePagina.Text = campo[4];
                        panelContenedorRomanceMas.Visible = true;
                        encontrado = true;
                    }
                    else
                    {
                        cadena = Lectura.ReadLine();

                    }
                }

                if (encontrado == false)
                {
                    labelPrimera.Text = "No existe el libro en nuestra libreria";
                }
                Lectura.Close();
            }
            catch (FileNotFoundException fe)
            {
                labelPrimera.Text = ("¡ERROR!" + fe.Message);
            }
        }

        private void btnMas2_Click(object sender, EventArgs e)
        {
            StreamReader Lectura;
            String cadena, libro;
            bool encontrado = false; ;
            string[] campo = new string[5];
            char[] separador = { ',' };

            try
            {
                Lectura = File.OpenText("Romance.txt");
                libro = labelSegunda.Text;
                cadena = Lectura.ReadLine();
                while (cadena != null && encontrado == false)
                {
                    campo = cadena.Split(separador);
                    if (campo[1].Trim().Equals(libro))
                    {
                        txtRomanceCodigo.Text = campo[0];
                        txtRomanceNombre.Text = campo[1];
                        txtRomanceAutor.Text = campo[2];
                        txtRomanceYear.Text = campo[3];
                        txtRomancePagina.Text = campo[4];
                        panelContenedorRomanceMas.Visible = true;
                        encontrado = true;
                    }
                    else
                    {
                        cadena = Lectura.ReadLine();

                    }
                }

                if (encontrado == false)
                {
                    labelSegunda.Text = "No existe el libro en nuestra libreria";
                }
                Lectura.Close();
            }
            catch (FileNotFoundException fe)
            {
                labelSegunda.Text = ("¡ERROR!" + fe.Message);
            }
        }

        private void btnMas3_Click(object sender, EventArgs e)
        {
            StreamReader Lectura;
            String cadena, libro;
            bool encontrado = false; ;
            string[] campo = new string[5];
            char[] separador = { ',' };

            try
            {
                Lectura = File.OpenText("Romance.txt");
                libro = labelTercera.Text;
                cadena = Lectura.ReadLine();
                while (cadena != null && encontrado == false)
                {
                    campo = cadena.Split(separador);
                    if (campo[1].Trim().Equals(libro))
                    {
                        txtRomanceCodigo.Text = campo[0];
                        txtRomanceNombre.Text = campo[1];
                        txtRomanceAutor.Text = campo[2];
                        txtRomanceYear.Text = campo[3];
                        txtRomancePagina.Text = campo[4];
                        panelContenedorRomanceMas.Visible = true;
                        encontrado = true;
                    }
                    else
                    {
                        cadena = Lectura.ReadLine();

                    }
                }

                if (encontrado == false)
                {
                    labelTercera.Text = "No existe el libro en nuestra libreria";
                }
                Lectura.Close();
            }
            catch (FileNotFoundException fe)
            {
                labelTercera.Text = ("¡ERROR!" + fe.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            panelContenedorRomance.Visible = true;
            AbrirFormHija(new FormEliminarRomance());
        }
    }
}
