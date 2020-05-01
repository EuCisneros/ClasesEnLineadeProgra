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
    public partial class Productos : Form
    {
        Conexion objConexion = new Conexion();
        int posicion = 0;
        string accion = "nuevo";
        DataTable tbl = new DataTable();

        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            actualizarDs();
            mostrarDatos();
        }
        void actualizarDs()
        {
            tbl = objConexion.obtener_datos().Tables["peliculas"];
            tbl.PrimaryKey = new DataColumn[] { tbl.Columns["IdPelicula"] };
        }

         void mostrarDatos()
        {
            try
            {
                lblidProducto.Text = tbl.Rows[posicion].ItemArray[0].ToString();
                txtalquiler.Text = tbl.Rows[posicion].ItemArray[1].ToString();
                txtdescripcion.Text = tbl.Rows[posicion].ItemArray[2].ToString();
                txtsinopsis.Text = tbl.Rows[posicion].ItemArray[3].ToString();
                cboGeneroPeliculas.Text = tbl.Rows[posicion].ItemArray[4].ToString();
                txtduracion.Text = tbl.Rows[posicion].ItemArray[5].ToString();
                txtcosto.Text = tbl.Rows[posicion].ItemArray[6].ToString();


                lblnregistros.Text = (posicion + 1) + " de " + tbl.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay Datos que mostrar", "Registros de Cliente",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar_cajas();
            }
        }

       


        //limpiar caja
        void limpiar_cajas()
        {

            txtalquiler.Text = "";
            txtdescripcion.Text = "";
            txtsinopsis.Text = "";
            cboGeneroPeliculas.Text = "";
            txtduracion.Text = "";
            txtcosto.Text = "";


        }
        // añadir, modif, elim datos
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (btnNuevo.Text == "Nuevo")
            {//boton de nuevo
                btnNuevo.Text = "Guardar";
                btnModificar.Text = "Cancelar";
                accion = "nuevo";

                limpiar_cajas();
                controles(false);
            }
            else
            { //boton de guardar
                String[] valores = {
                    lblidProducto.Text,
                    txtalquiler.Text,
                    txtdescripcion.Text,
                    txtsinopsis.Text,
                    cboGeneroPeliculas.Text,
                    txtduracion.Text,
                    txtdescripcion.Text
                };
                objConexion.mantenimiento_datos_peliculas (valores, accion);
                actualizarDs();
                posicion = tbl.Rows.Count - 1;
                mostrarDatos();

                controles(true);

                btnNuevo.Text = "Nuevo";
                btnModificar.Text = "Modificar";
            }
        }
        //controles
        void controles(Boolean valor)
        {
            grbNavegacion.Enabled = valor;
            btneliminar.Enabled = valor;
            btnBuscar.Enabled = valor;
            grbDatosProductos.Enabled = !valor;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (btnModificar.Text == "Modificar")
            {//boton de modificar
                btnNuevo.Text = "Guardar";
                btnModificar.Text = "Cancelar";
                accion = "modificar";

                controles(false);

                btnNuevo.Text = "Guardar";
                btnModificar.Text = "Cancelar";

            }
            else
            { //boton de cancelar
                controles(true);
                mostrarDatos();

                btnNuevo.Text = "Nuevo";
                btnModificar.Text = "Modificar";
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de elimina a " + txtalquiler.Text, "Registro de Clientes",
              MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                String[] valores = { lblidProducto.Text };
                objConexion.mantenimiento_datos(valores, "eliminar");

                actualizarDs();
                posicion = posicion > 0 ? posicion - 1 : 0;
                mostrarDatos();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BusquedaProductos frmBusquedaAlquiler = new BusquedaProductos();
            frmBusquedaAlquiler.ShowDialog();

            if (frmBusquedaAlquiler._IdPelicula > 0)
            {
                posicion = tbl.Rows.IndexOf(tbl.Rows.Find(frmBusquedaAlquiler._IdPelicula));
                mostrarDatos();
            }
        }
        //botones
        private void btnprimero_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatos();
        }

        private void btnanterior_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Primer Registro...", "Registros de Cliente",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            if (posicion < tbl.Rows.Count - 1)
            {
                posicion++;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Ultimo Registro...", "Registros de Cliente",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnultimo_Click(object sender, EventArgs e)
        {
            posicion = tbl.Rows.Count - 1;
            mostrarDatos();
        }

        private void btnBuscarCategoriaProductos_Click(object sender, EventArgs e)
        {
            Categorias Alquiler = new Categorias();
            Alquiler.ShowDialog();
        }
    }
}
