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
    public partial class FormHistoria : Form
    {
        public FormHistoria()
        {
            InitializeComponent();
            panelContenedorHistoriaMas.Visible = false;
            panelContenedorHistoria.Visible = false;
        }

        private void AbrirFormHija(object formhija)
        {
            if (this.panelContenedorHistoria.Controls.Count > 0)
                this.panelContenedorHistoria.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedorHistoria.Controls.Add(fh);
            this.panelContenedorHistoria.Tag = fh;
            fh.Show();

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            panelContenedorHistoria.Visible = true;
            AbrirFormHija(new FormIngresarHistoria());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            panelContenedorHistoria.Visible = true;
            AbrirFormHija(new FormBuscarOpcionesHistoria());
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
                Lectura = File.OpenText("Historia.txt");
                libro = labelPrimera.Text;
                cadena = Lectura.ReadLine();
                while (cadena != null && encontrado == false)
                {
                    campo = cadena.Split(separador);
                    if (campo[1].Trim().Equals(libro))
                    {
                        txtHistoriaCodigo.Text = campo[0];
                        txtHistoriaNombre.Text = campo[1];
                        txtHistoriaAutor.Text = campo[2];
                        txtHistoriaYear.Text = campo[3];
                        txtHistoriaPagina.Text = campo[4];
                        panelContenedorHistoriaMas.Visible = true;
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
                Lectura = File.OpenText("Historia.txt");
                libro = labelSegunda.Text;
                cadena = Lectura.ReadLine();
                while (cadena != null && encontrado == false)
                {
                    campo = cadena.Split(separador);
                    if (campo[1].Trim().Equals(libro))
                    {
                        txtHistoriaCodigo.Text = campo[0];
                        txtHistoriaNombre.Text = campo[1];
                        txtHistoriaAutor.Text = campo[2];
                        txtHistoriaYear.Text = campo[3];
                        txtHistoriaPagina.Text = campo[4];
                        panelContenedorHistoriaMas.Visible = true;
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
                Lectura = File.OpenText("Historia.txt");
                libro = labelTercera.Text;
                cadena = Lectura.ReadLine();
                while (cadena != null && encontrado == false)
                {
                    campo = cadena.Split(separador);
                    if (campo[0].Trim().Equals(libro))
                    {
                        txtHistoriaCodigo.Text = campo[0];
                        txtHistoriaNombre.Text = campo[1];
                        txtHistoriaAutor.Text = campo[2];
                        txtHistoriaYear.Text = campo[3];
                        txtHistoriaPagina.Text = campo[4];
                        panelContenedorHistoriaMas.Visible = true;
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
            panelContenedorHistoria.Visible = true;
            AbrirFormHija(new FormEliminarHostoria());
        }
    }
}
