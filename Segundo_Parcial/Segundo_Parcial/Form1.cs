using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Segundo_Parcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AbrirFormEnPanel(object formHijo)
        {
            if (this.PanelContenedorPrincipal.Controls.Count > 0)
                this.PanelContenedorPrincipal.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedorPrincipal.Controls.Add(fh);
            this.PanelContenedorPrincipal.Tag = fh;
            fh.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Clientes fm = new Clientes();
            fm.FormClosed += new FormClosedEventHandler(MostrarFrmCineAlCerrarForms);
            AbrirFormEnPanel(fm);
        }
        private void MostrarFrmCineAlCerrarForms(object sender, FormClosedEventArgs e)
        {
            FrmCine();
        }
        private void FrmCine()
        {
            AbrirFormEnPanel(new FrmCine());
        }

        private void btnPeliculas_Click(object sender, EventArgs e)
        {
           //
        }

        private void btnAlquiler_Click(object sender, EventArgs e)
        {
            Alquiler fm = new Alquiler();
            fm.FormClosed += new FormClosedEventHandler(MostrarFrmCineAlCerrarForms);
            AbrirFormEnPanel(fm);
        }
    }
}
