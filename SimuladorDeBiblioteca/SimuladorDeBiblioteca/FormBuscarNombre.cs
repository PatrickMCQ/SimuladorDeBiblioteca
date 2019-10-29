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
    public partial class FormBuscarNombre : Form
    {
        public FormBuscarNombre()
        {
            InitializeComponent();
            panelContenedorBNombreEspiritual.Visible = false;
        }

        private void AbrirFormHija(object formhija)
        {
            if (this.panelContenedorBNombreEspiritual.Controls.Count > 0)
                this.panelContenedorBNombreEspiritual.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedorBNombreEspiritual.Controls.Add(fh);
            this.panelContenedorBNombreEspiritual.Tag = fh;
            fh.Show();

        }


        private void btnBuscarNombre_Click(object sender, EventArgs e)
        {
            StreamReader Lectura;
            String cadena, libro;
            bool encontrado = false; ;
            string[] campo = new string[5];
            char[] separador = { ',' };

            try
            {
                Lectura = File.OpenText("Espiritual.txt");
                libro = txtBuscarNombre.Text;
                cadena = Lectura.ReadLine();
                while (cadena != null && encontrado == false)
                {
                    campo = cadena.Split(separador);
                    if(campo[1].Trim().Equals(libro))
                    {
                        txtEspiritualCodigo.Text = campo[0];
                        txtEspiritualNombre.Text = campo[1];
                        txtEspiritualAutor.Text = campo[2];
                        txtEspiritualYear.Text = campo[3];
                        txtEspiritualPagina.Text = campo[4];
                        labelMensaje.Visible = false;
                        panelContenedorBNombreEspiritual.Visible = true;
                        encontrado = true;
                    }else
                    {
                        cadena = Lectura.ReadLine();

                    }
                }

                if(encontrado == false)
                {
                    labelMensaje.Text = "No existe el libro en nuestra libreria";
                }
                Lectura.Close();
            }catch(FileNotFoundException fe)
            {
                labelMensaje.Text = ("¡ERROR!" + fe.Message);
            }

        }
    }
}
