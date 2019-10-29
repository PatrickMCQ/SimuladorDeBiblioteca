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
    public partial class FormBuscarOpciones : Form
    {
        public FormBuscarOpciones()
        {
            InitializeComponent();
            panelContenedorBuscarEspiritul.Visible = false;
        }

        private void AbrirFormHija(object formhija)
        {
            if (this.panelContenedorBuscarEspiritul.Controls.Count > 0)
                this.panelContenedorBuscarEspiritul.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedorBuscarEspiritul.Controls.Add(fh);
            this.panelContenedorBuscarEspiritul.Tag = fh;
            fh.Show();

        }

        private void btnNombre_Click(object sender, EventArgs e)
        {
            panelContenedorBuscarEspiritul.Visible = true;
            AbrirFormHija(new FormBuscarNombre());
        }

        private void btnCodigo_Click(object sender, EventArgs e)
        {
            panelContenedorBuscarEspiritul.Visible = true;
            AbrirFormHija(new FormBuscarCodigo());
        }
    }
}
