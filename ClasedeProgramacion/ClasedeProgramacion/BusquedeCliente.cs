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
    public partial class BusquedeCliente : Form
    {
        Conexion objConexion = new Conexion();
        public int _IdCliente;

        public BusquedeCliente()
        {
            InitializeComponent();
        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            if (grdBusquedaClientes.RowCount > 0)
            {
                _IdCliente = int.Parse(grdBusquedaClientes.CurrentRow.Cells[0].Value.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "Busqueda de Clientes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BusquedeCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet_sistema_peliculas.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.dataSet_sistema_peliculas.clientes);
            grdBusquedaClientes.DataSource =
              objConexion.obtener_datos().Tables["clientes"].DefaultView;
        }
        void filtrar_datos(String valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = grdBusquedaClientes.DataSource;
            bs.Filter = "Nombre like '%" + valor + "%'" + "or Direccion like '%" + valor + "%'" + "or Telefono like '%" + valor + "%'" + "or DUI like '%" + valor + "%'";
            grdBusquedaClientes.DataSource = bs;
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            filtrar_datos(txtbuscar.Text);
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
