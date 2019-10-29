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
    public partial class FormAnimacion : Form
    {
        public FormAnimacion()
        {
            InitializeComponent();
            panelContenedorAnimacionMas.Visible = false;
            panelContenedorAnimacion.Visible = false;
        }

        private void AbrirFormHija(object formhija)
        {
            if (this.panelContenedorAnimacion.Controls.Count > 0)
                this.panelContenedorAnimacion.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedorAnimacion.Controls.Add(fh);
            this.panelContenedorAnimacion.Tag = fh;
            fh.Show();

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            panelContenedorAnimacion.Visible = true;
            AbrirFormHija(new FormIngresarAnimacion());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            panelContenedorAnimacion.Visible = true;
            AbrirFormHija(new FormBuscarOpcionesAnimacion());
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
                Lectura = File.OpenText("Animacion.txt");
                libro = labelPrimera.Text;
                cadena = Lectura.ReadLine();
                while (cadena != null && encontrado == false)
                {
                    campo = cadena.Split(separador);
                    if (campo[1].Trim().Equals(libro))
                    {
                        txtAnimacionCodigo.Text = campo[0];
                        txtAnimacionNombre.Text = campo[1];
                        txtAnimacionAutor.Text = campo[2];
                        txtAnimacionYear.Text = campo[3];
                        txtAnimacionPagina.Text = campo[4];
                        panelContenedorAnimacionMas.Visible = true;
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
                Lectura = File.OpenText("Animacion.txt");
                libro = labelSegunda.Text;
                cadena = Lectura.ReadLine();
                while (cadena != null && encontrado == false)
                {
                    campo = cadena.Split(separador);
                    if (campo[1].Trim().Equals(libro))
                    {
                        txtAnimacionCodigo.Text = campo[0];
                        txtAnimacionNombre.Text = campo[1];
                        txtAnimacionAutor.Text = campo[2];
                        txtAnimacionYear.Text = campo[3];
                        txtAnimacionPagina.Text = campo[4];
                        panelContenedorAnimacionMas.Visible = true;
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
                Lectura = File.OpenText("Animacion.txt");
                libro = labelTercera.Text;
                cadena = Lectura.ReadLine();
                while (cadena != null && encontrado == false)
                {
                    campo = cadena.Split(separador);
                    if (campo[1].Trim().Equals(libro))
                    {
                        txtAnimacionCodigo.Text = campo[0];
                        txtAnimacionNombre.Text = campo[1];
                        txtAnimacionAutor.Text = campo[2];
                        txtAnimacionYear.Text = campo[3];
                        txtAnimacionPagina.Text = campo[4];
                        panelContenedorAnimacionMas.Visible = true;
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
            panelContenedorAnimacion.Visible = true;
            AbrirFormHija(new FormEliminarAnimacion());
        }
    }
}
