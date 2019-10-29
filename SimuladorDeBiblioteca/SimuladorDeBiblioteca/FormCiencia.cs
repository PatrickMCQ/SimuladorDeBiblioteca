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
    public partial class FormCiencia : Form
    {
        public FormCiencia()
        {
            InitializeComponent();
            panelContenedorBCienciaMas.Visible = false;
            panelContenedorCiencia.Visible = false;
        }

        private void AbrirFormHija(object formhija)
        {
            if (this.panelContenedorCiencia.Controls.Count > 0)
                this.panelContenedorCiencia.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedorCiencia.Controls.Add(fh);
            this.panelContenedorCiencia.Tag = fh;
            fh.Show();

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            panelContenedorCiencia.Visible = true;
            AbrirFormHija(new FormIngresarCiencia());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            panelContenedorCiencia.Visible = true;
            AbrirFormHija(new FormBuscarOpcionesCiencia());
        }

        private void btnMás1_Click(object sender, EventArgs e)
        {
            StreamReader Lectura;
            String cadena, libro;
            bool encontrado = false; ;
            string[] campo = new string[5];
            char[] separador = { ',' };

            try
            {
                Lectura = File.OpenText("Ciencia.txt");
                libro = labelPrimera.Text;
                cadena = Lectura.ReadLine();
                while (cadena != null && encontrado == false)
                {
                    campo = cadena.Split(separador);
                    if (campo[1].Trim().Equals(libro))
                    {
                        txtCienciaCodigo.Text = campo[0];
                        txtCienciaNombre.Text = campo[1];
                        txtCienciaAutor.Text = campo[2];
                        txtCienciaYear.Text = campo[3];
                        txtCienciaPagina.Text = campo[4];
                        panelContenedorBCienciaMas.Visible = true;
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
                Lectura = File.OpenText("Ciencia.txt");
                libro = labelSegunda.Text;
                cadena = Lectura.ReadLine();
                while (cadena != null && encontrado == false)
                {
                    campo = cadena.Split(separador);
                    if (campo[1].Trim().Equals(libro))
                    {
                        txtCienciaCodigo.Text = campo[0];
                        txtCienciaNombre.Text = campo[1];
                        txtCienciaAutor.Text = campo[2];
                        txtCienciaYear.Text = campo[3];
                        txtCienciaPagina.Text = campo[4];
                        panelContenedorBCienciaMas.Visible = true;
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
                Lectura = File.OpenText("Ciencia.txt");
                libro = labelTercera.Text;
                cadena = Lectura.ReadLine();
                while (cadena != null && encontrado == false)
                {
                    campo = cadena.Split(separador);
                    if (campo[1].Trim().Equals(libro))
                    {
                        txtCienciaCodigo.Text = campo[0];
                        txtCienciaNombre.Text = campo[1];
                        txtCienciaAutor.Text = campo[2];
                        txtCienciaYear.Text = campo[3];
                        txtCienciaPagina.Text = campo[4];
                        panelContenedorBCienciaMas.Visible = true;
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
            panelContenedorCiencia.Visible = true;
            AbrirFormHija(new FormEliminarCiencia());
        }
    }
}
