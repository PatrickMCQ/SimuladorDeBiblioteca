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
    public partial class FormBuscarOpcionesHistoria : Form
    {
        public FormBuscarOpcionesHistoria()
        {
            InitializeComponent();
            panelContenedorBuscarHistoria.Visible = false;
        }

        private void AbrirFormHija(object formhija)
        {
            if (this.panelContenedorBuscarHistoria.Controls.Count > 0)
                this.panelContenedorBuscarHistoria.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedorBuscarHistoria.Controls.Add(fh);
            this.panelContenedorBuscarHistoria.Tag = fh;
            fh.Show();

        }

        private void btnNombre_Click(object sender, EventArgs e)
        {
            panelContenedorBuscarHistoria.Visible = true;
            AbrirFormHija(new FormBuscarNombreHistoria());
        }

        private void btnCodigo_Click(object sender, EventArgs e)
        {
            panelContenedorBuscarHistoria.Visible = true;
            AbrirFormHija(new FormBuscarCodigoHistoria());
        }
    }
}
