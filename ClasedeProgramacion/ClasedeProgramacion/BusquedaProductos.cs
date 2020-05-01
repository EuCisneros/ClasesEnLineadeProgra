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
    public partial class BusquedaProductos : Form
    {
        Conexion objConexion = new Conexion();
        public int _IdPelicula;

        public BusquedaProductos()
        {
            InitializeComponent();
        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            if (grdBusquedaPeliculas.RowCount > 0)
            {
                _IdPelicula = int.Parse(grdBusquedaPeliculas.CurrentRow.Cells[0].Value.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "Busqueda de Clientes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void BusquedaProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet_sistema_peliculas.peliculas1' Puede moverla o quitarla según sea necesario.
            this.peliculas1TableAdapter.Fill(this.dataSet_sistema_peliculas.peliculas1);
          

        }
        void filtrar_datos(String valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = grdBusquedaPeliculas.DataSource;
            bs.Filter = "Alquiler like '%" + valor + "%'" + "or Descripcion like '%" + valor + "%'" + "or Sinopsis like '%" + valor + "%'" + "or Duracion like '%" + valor + "%'" + "or Costo like '%" + valor + "%'";
            grdBusquedaPeliculas.DataSource = bs;
        }
    }
}
