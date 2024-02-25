using MySql.Data.MySqlClient;
using Seguros.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seguros.Models
{
    public class AdminModel
    {

        // Obtengo todas las polizas
        public static DataTable getPolizas()
        {
            MySqlConnection conexion = ConexionBaseDatos.getConexion();
            // la abro.
            conexion.Open();
            // Consulta sql
            string sql = "SELECT * FROM polizas";

            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conexion);
            DataTable table = new DataTable();

            try
            {
                adapter.Fill(table);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            return table;
        }

        // Obtengo las polias del cliente
        public static DataTable getPolizasByClientID(int idCliente)
        {
            MySqlConnection conexion = ConexionBaseDatos.getConexion();
            // la abro.
            conexion.Open();
            // Consulta sql
            string sql = "SELECT * FROM polizas WHERE idCliente = " + idCliente;

            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conexion);
            DataTable table = new DataTable();

            try
            {
                adapter.Fill(table);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            return table;
        }

        // Obtengo todos los clientes
        public static DataTable getClientes()
        {
            MySqlConnection conexion = ConexionBaseDatos.getConexion();
            // la abro.
            conexion.Open();
            // Consulta sql
            string sql = "SELECT * FROM clientes";

            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conexion);
            DataTable table = new DataTable();

            try
            {
                adapter.Fill(table);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            return table;
        }


        public static DataTable getAdministradores()
        {
            MySqlConnection conexion = ConexionBaseDatos.getConexion();
            // la abro.
            conexion.Open();
            // Consulta sql
            string sql = "SELECT * FROM administradores";

            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conexion);
            DataTable table = new DataTable();

            try
            {
                adapter.Fill(table);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            return table;
        }

        public static DataTable getAgentes()
        {
            MySqlConnection conexion = ConexionBaseDatos.getConexion();
            // la abro.
            conexion.Open();
            // Consulta sql
            string sql = "SELECT * FROM agentes";

            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conexion);
            DataTable table = new DataTable();

            try
            {
                adapter.Fill(table);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            return table;
        }


        // Obtengo los pagos efectuados para cada poliza.
        public static DataTable getPagosByPoliza(int idPoliza)
        {
            MySqlConnection conexion = ConexionBaseDatos.getConexion();
            // la abro.
            conexion.Open();
            // Consulta sql
            string sql = "SELECT * FROM pagos WHERE idPoliza =" + idPoliza;

            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conexion);
            DataTable table = new DataTable();

            try
            {
                adapter.Fill(table);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            return table;
        }


        // Obtengo las polias del cliente
        public static DataTable getCarteraClientes(int idAgente)
        {
            MySqlConnection conexion = ConexionBaseDatos.getConexion();
            // la abro.
            conexion.Open();
            // Consulta sql
            string sql = "SELECT * FROM clientes WHERE idAgente = " + idAgente;

            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conexion);
            DataTable table = new DataTable();

            try
            {
                adapter.Fill(table);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            return table;
        }


        // Registra un nuevo usuario
        public static int registrarPagoPoliza(decimal pago, int idPoliza )
        {
            // Creo la conexion con la base de datos.
            MySqlConnection conexion = ConexionBaseDatos.getConexion();
            // la abro.
            conexion.Open();

            // Consulta sql
            string sql = "INSERT INTO pagos ( pagado, idPoliza ) VALUES ( @pago, @idPoliza )";
            // Preparo la consulta
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            // Le paso el pago
            comando.Parameters.AddWithValue("@pago", pago);
            // Le paso como parametro el id de la poliza
            comando.Parameters.AddWithValue("@idPoliza", idPoliza);
  

            int creado;

            try
            {
                // Return value is the number of rows affected by the SQL statement.
                creado = comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                creado = 0;
                MessageBox.Show(ex.Message);
            }

            return creado;

        }



    }
}
