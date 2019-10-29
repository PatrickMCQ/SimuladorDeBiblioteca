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
    public partial class FormEspiritual : Form
    {
        public FormEspiritual()
        {
            InitializeComponent();
            panelContenedorEspiritual.Visible = false;
            panelContenedorEspiritualMas.Visible = false;
        }

        private void AbrirFormHija(object formhija)
        {
            if (this.panelContenedorEspiritual.Controls.Count > 0)
                this.panelContenedorEspiritual.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedorEspiritual.Controls.Add(fh);
            this.panelContenedorEspiritual.Tag = fh;
            fh.Show();

        }


        private void btnIngresarMenuEspiritual_Click(object sender, EventArgs e)
        {
            panelContenedorEspiritualMas.Visible = false;
            panelContenedorEspiritual.Visible = true;
            AbrirFormHija(new FormIngresarEspirirual());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelContenedorEspiritualMas.Visible = false;
            panelContenedorEspiritual.Visible = true;
            AbrirFormHija(new FormBuscarOpciones());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelContenedorEspiritual.Visible = false;
            StreamReader Lectura;
            String cadena, libro;
            bool encontrado = false; ;
            string[] campo = new string[5];
            char[] separador = { ',' };

            try
            {
                Lectura = File.OpenText("Espiritual.txt");
                libro = labelPrimera.Text;
                cadena = Lectura.ReadLine();
                while (cadena != null && encontrado == false)
                {
                    campo = cadena.Split(separador);
                    if (campo[1].Trim().Equals(libro))
                    {
                        txtEspiritualCodigo.Text = campo[0];
                        txtEspiritualNombre.Text = campo[1];
                        txtEspiritualAutor.Text = campo[2];
                        txtEspiritualYear.Text = campo[3];
                        txtEspiritualPagina.Text = campo[4]; 
                        panelContenedorEspiritualMas.Visible = true;
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
            }catch (FileNotFoundException fe)
            {
                labelPrimera.Text = ("¡ERROR!" + fe.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelContenedorEspiritual.Visible = false;
            StreamReader Lectura;
            String cadena, libro;
            bool encontrado = false; ;
            string[] campo = new string[5];
            char[] separador = { ',' };

            try
            {
                Lectura = File.OpenText("Espiritual.txt");
                libro = labelSegunda.Text;
                cadena = Lectura.ReadLine();
                while (cadena != null && encontrado == false)
                {
                    campo = cadena.Split(separador);
                    if (campo[1].Trim().Equals(libro))
                    {
                        txtEspiritualCodigo.Text = campo[0];
                        txtEspiritualNombre.Text = campo[1];
                        txtEspiritualAutor.Text = campo[2];
                        txtEspiritualYear.Text = campo[3];
                        txtEspiritualPagina.Text = campo[4];
                        panelContenedorEspiritualMas.Visible = true;
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

        private void button3_Click(object sender, EventArgs e)
        {
            panelContenedorEspiritual.Visible = false;
            StreamReader Lectura;
            String cadena, libro;
            bool encontrado = false; ;
            string[] campo = new string[5];
            char[] separador = { ',' };

            try
            {
                Lectura = File.OpenText("Espiritual.txt");
                libro = labelTercera.Text;
                cadena = Lectura.ReadLine();
                while (cadena != null && encontrado == false)
                {
                    campo = cadena.Split(separador);
                    if (campo[1].Trim().Equals(libro))
                    {
                        txtEspiritualCodigo.Text = campo[0];
                        txtEspiritualNombre.Text = campo[1];
                        txtEspiritualAutor.Text = campo[2];
                        txtEspiritualYear.Text = campo[3];
                        txtEspiritualPagina.Text = campo[4];
                        panelContenedorEspiritualMas.Visible = true;
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
            panelContenedorEspiritualMas.Visible = false;
            panelContenedorEspiritual.Visible = true;
            AbrirFormHija(new FormEliminar());
        }
    }
}
