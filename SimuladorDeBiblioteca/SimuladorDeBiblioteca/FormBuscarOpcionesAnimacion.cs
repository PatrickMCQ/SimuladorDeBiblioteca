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
    public partial class FormBuscarOpcionesAnimacion : Form
    {
        public FormBuscarOpcionesAnimacion()
        {
            InitializeComponent();
            panelContenedorBuscarAnimacion.Visible = false;
        }

        private void AbrirFormHija(object formhija)
        {
            if (this.panelContenedorBuscarAnimacion.Controls.Count > 0)
                this.panelContenedorBuscarAnimacion.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedorBuscarAnimacion.Controls.Add(fh);
            this.panelContenedorBuscarAnimacion.Tag = fh;
            fh.Show();

        }

        private void btnNombre_Click(object sender, EventArgs e)
        {
            panelContenedorBuscarAnimacion.Visible = true;
            AbrirFormHija(new FormBuscarNombreAnimacion());
        }

        private void btnCodigo_Click(object sender, EventArgs e)
        {
            panelContenedorBuscarAnimacion.Visible = true;
            AbrirFormHija(new FormBuscarCodigoAnimacion());
        }
    }
}
