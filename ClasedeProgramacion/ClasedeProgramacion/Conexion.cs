using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Libreria para trabajar con BD
using System.Data;
using System.Data.SqlClient; //Libreria para conectarse una BD de SQL Server



namespace ClasedeProgramacion
{
    class Conexion
    {
        SqlConnection miConexion = new SqlConnection();
        SqlCommand comandosSQL = new SqlCommand();
        SqlDataAdapter miAdaptadorDatos = new SqlDataAdapter();

        DataSet ds = new DataSet();

        public Conexion()
        {
            String cadena = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_sistema_peliculas.mdf;Integrated Security=True";
            miConexion.ConnectionString = cadena;
            miConexion.Open();
        }
        public DataSet obtener_datos()
        {
            ds.Clear();
            comandosSQL.Connection = miConexion;

            comandosSQL.CommandText = "select * from clientes";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "clientes");

            comandosSQL.CommandText = "select * from peliculas";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "productos");

            comandosSQL.CommandText = "select alquiler.IdAlquiler, peliculas.idPelicula, pelicula.descripcion, peliculas.sinopsis, peliculas.generp from peliculas inner join alquiler on(alquiler.idAlquiler=peliculas.IdAlquiler)";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "peliculas_alquiler");

            comandosSQL.CommandText = "select * from alquiler";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "alquiler");

            return ds;
        }
        public void mantenimiento_datos(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO clientes (nombre,direccion,telefono,dui) VALUES(" +
                    "'" + datos[1] + "'," +
                    "'" + datos[2] + "'," +
                    "'" + datos[3] + "'," +
                    "'" + datos[4] + "'" +
                   
                    ")";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE clientes SET " +
                    "nombre       = '" + datos[1] + "'," +
                    "direccion         = '" + datos[2] + "'," +
                    "telefono      = '" + datos[3] + "'," +
                    "dui       = '" + datos[4] + "'" +
                    "WHERE IdCliente = '" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE clientes FROM clientes WHERE IdCliente='" + datos[0] + "'";
            }
            procesarSQL(sql);
        }
        public void mantenimiento_datos_peliculas(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO productos (IdAlquiler,descripcion,sinopsis,genero,duracion,costo) VALUES(" +
                    "'" + datos[1] + "'," +
                    "'" + datos[2] + "'," +
                    "'" + datos[3] + "'," +
                    "'" + datos[4] + "'," +
                    "'" + datos[5] + "'," +
                    "'" + datos[6] + "'" +
                    ")";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE productos SET " +
                    "IdAlquiler     = '" + datos[1] + "'," +
                    "descripcion      = '" + datos[2] + "'," +
                    "sinopsis          = '" + datos[3] + "'," +
                    "genero          = '" + datos[4] + "'," +
                    "duracion     = '" + datos[5] + "'," +
                    "costo     = '" + datos[6] + "'" +
                    "WHERE IdPelicula = '" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE productos FROM peliculas WHERE IdPelicula='" + datos[0] + "'";
            }
            procesarSQL(sql);
        }
        public void mantenimiento_datos_alquiler(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO alquiler (IdCliente,IdPelicula,fecha_prestamo,fecha_devolucion) VALUES(" +
                    "'" + datos[1] + "'," +
                    "'" + datos[2] + "'," +
                    "'" + datos[3] + "'," +
                    "'" + datos[4] + "'" +
                    ")";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE alquiler SET " +
                    "IdCliente            = '" + datos[1] + "'," +
                    "IdPelicula            = '" + datos[2] + "'," +
                    "fecha_prestamo            = '" + datos[3] + "'" +
                    "fecha_devolucion            = '" + datos[4] + "'" +
                    "WHERE IdAlquiler = '" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE productos FROM alquiler WHERE IdAlquiler='" + datos[0] + "'";
            }
            procesarSQL(sql);
        }
        void procesarSQL(String sql)
        {
            comandosSQL.Connection = miConexion;
            comandosSQL.CommandText = sql;
            comandosSQL.ExecuteNonQuery();
        }
    }
}
