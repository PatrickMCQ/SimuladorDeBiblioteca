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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pnlButton.Height = btnEspiritual.Height;
            pnlButton.Top = btnEspiritual.Top;
            AbrirFormHija(new FormEspiritual());
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Visible = false;
                picMinimizar.Visible = true;
            }
        }


        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AbrirFormHija(object formhija)
        {
            if(this.panelContenedorP.Controls.Count > 0)
                this.panelContenedorP.Controls.RemoveAt(0);
                Form fh = formhija as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.panelContenedorP.Controls.Add(fh);
                this.panelContenedorP.Tag = fh;
                fh.Show();
            
        }

        private void btnHistoria_Click(object sender, EventArgs e)
        {
           
            pnlButton.Height = btnHistoria.Height;
            pnlButton.Top = btnHistoria.Top;
            AbrirFormHija(new FormHistoria());
        }

        private void btnCiencia_Click(object sender, EventArgs e)
        {
            
            pnlButton.Height = btnCiencia.Height;
            pnlButton.Top = btnCiencia.Top;
            AbrirFormHija(new FormCiencia());
        }

        private void btnEspiritual_Click(object sender, EventArgs e)
        {
            
            pnlButton.Height = btnEspiritual.Height;
            pnlButton.Top = btnEspiritual.Top;
            AbrirFormHija(new FormEspiritual());
        }

        private void btnRomance_Click(object sender, EventArgs e)
        {
            pnlButton.Height = btnRomance.Height;
            pnlButton.Top = btnRomance.Top;
            AbrirFormHija(new FormRomance());
        }

        private void btnAnimacion_Click(object sender, EventArgs e)
        {
            pnlButton.Height = btnAnimacion.Height;
            pnlButton.Top = btnAnimacion.Top;
            AbrirFormHija(new FormAnimacion());
        }

        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnlWandaName_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
