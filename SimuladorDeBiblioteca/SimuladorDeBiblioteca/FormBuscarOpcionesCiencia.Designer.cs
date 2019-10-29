namespace SimuladorDeBiblioteca
{
    partial class FormBuscarOpcionesCiencia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCodigo = new System.Windows.Forms.Button();
            this.btnNombre = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContenedorBuscarCiencia = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnCodigo
            // 
            this.btnCodigo.BackColor = System.Drawing.Color.Crimson;
            this.btnCodigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCodigo.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnCodigo.FlatAppearance.BorderSize = 0;
            this.btnCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCodigo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCodigo.ForeColor = System.Drawing.Color.White;
            this.btnCodigo.Location = new System.Drawing.Point(283, 186);
            this.btnCodigo.Name = "btnCodigo";
            this.btnCodigo.Size = new System.Drawing.Size(90, 37);
            this.btnCodigo.TabIndex = 45;
            this.btnCodigo.Text = "Código";
            this.btnCodigo.UseVisualStyleBackColor = false;
            this.btnCodigo.Click += new System.EventHandler(this.btnCodigo_Click);
            // 
            // btnNombre
            // 
            this.btnNombre.BackColor = System.Drawing.Color.Crimson;
            this.btnNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNombre.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnNombre.FlatAppearance.BorderSize = 0;
            this.btnNombre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNombre.ForeColor = System.Drawing.Color.White;
            this.btnNombre.Location = new System.Drawing.Point(165, 186);
            this.btnNombre.Name = "btnNombre";
            this.btnNombre.Size = new System.Drawing.Size(90, 37);
            this.btnNombre.TabIndex = 44;
            this.btnNombre.Text = "Nombre";
            this.btnNombre.UseVisualStyleBackColor = false;
            this.btnNombre.Click += new System.EventHandler(this.btnNombre_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(184, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 58);
            this.label1.TabIndex = 43;
            this.label1.Text = "Buscar";
            // 
            // panelContenedorBuscarCiencia
            // 
            this.panelContenedorBuscarCiencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorBuscarCiencia.Location = new System.Drawing.Point(0, 0);
            this.panelContenedorBuscarCiencia.Name = "panelContenedorBuscarCiencia";
            this.panelContenedorBuscarCiencia.Size = new System.Drawing.Size(548, 338);
            this.panelContenedorBuscarCiencia.TabIndex = 46;
            // 
            // FormBuscarOpcionesCiencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(548, 338);
            this.Controls.Add(this.panelContenedorBuscarCiencia);
            this.Controls.Add(this.btnCodigo);
            this.Controls.Add(this.btnNombre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBuscarOpcionesCiencia";
            this.Text = "FormBuscarOpcionesCiencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCodigo;
        private System.Windows.Forms.Button btnNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelContenedorBuscarCiencia;
    }
}