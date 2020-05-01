using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasedeProgramacion
{
    public partial class BusquedaCategorias : Form
    {

        Conexion objConexion = new Conexion();
        public int _IdAlquiler;

        public BusquedaCategorias()
        {
            InitializeComponent();
        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            if (grdBusquedaCategorias.RowCount > 0)
            {
                _IdAlquiler = int.Parse(grdBusquedaCategorias.CurrentRow.Cells[0].Value.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "Busqueda de Clientes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void BusquedaCategorias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet_sistema_peliculas.alquiler' Puede moverla o quitarla según sea necesario.
            this.alquilerTableAdapter.Fill(this.dataSet_sistema_peliculas.alquiler);

        }

        void filtrar_datos(String valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = grdBusquedaCategorias.DataSource;
            bs.Filter = "Cliente like '%" + valor + "%'" + "or Pelicula like '%" + valor + "%'" + "or Fecha de Prestamo like '%" + valor + "%'" + "or Fecha de Devolucion like '%" + valor + "%'";
            grdBusquedaCategorias.DataSource = bs;
        }
    }
}
