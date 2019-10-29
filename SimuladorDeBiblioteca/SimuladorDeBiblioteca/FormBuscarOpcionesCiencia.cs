using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorDeBiblioteca
{
    public partial class FormBuscarOpcionesCiencia : Form
    {
        public FormBuscarOpcionesCiencia()
        {
            InitializeComponent();
            panelContenedorBuscarCiencia.Visible = false;
        }

        private void AbrirFormHija(object formhija)
        {
            if (this.panelContenedorBuscarCiencia.Controls.Count > 0)
                this.panelContenedorBuscarCiencia.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedorBuscarCiencia.Controls.Add(fh);
            this.panelContenedorBuscarCiencia.Tag = fh;
            fh.Show();

        }

        private void btnNombre_Click(object sender, EventArgs e)
        {
            panelContenedorBuscarCiencia.Visible = true;
            AbrirFormHija(new FormBuscarNombreCiencia());
        }

        private void btnCodigo_Click(object sender, EventArgs e)
        {
            panelContenedorBuscarCiencia.Visible = true;
            AbrirFormHija(new FormBuscarCodigoCiencia());
        }
    }
}
