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
    public partial class FormBuscarOpcionesRomance : Form
    {
        public FormBuscarOpcionesRomance()
        {
            InitializeComponent();
            panelContenedorBuscarRomance.Visible = false;
        }

        private void AbrirFormHija(object formhija)
        {
            if (this.panelContenedorBuscarRomance.Controls.Count > 0)
                this.panelContenedorBuscarRomance.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedorBuscarRomance.Controls.Add(fh);
            this.panelContenedorBuscarRomance.Tag = fh;
            fh.Show();

        }

        private void btnNombre_Click(object sender, EventArgs e)
        {
            panelContenedorBuscarRomance.Visible = true;
            AbrirFormHija(new FormBuscarNombreRomance());
        }

        private void btnCodigo_Click(object sender, EventArgs e)
        {
            panelContenedorBuscarRomance.Visible = true;
            AbrirFormHija(new FormBuscarCodigoRomance());
        }
    }
}
