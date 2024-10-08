﻿using MySql.Data.MySqlClient;
using Seguros.Conexion;
using Seguros.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seguros.Models
{
    public class AdminModel
    {
        private static bool estado;

        // Obtengo todas las polizas
        public static DataTable getPolizas()
        {
            MySqlConnection conexion = ConexionBaseDatos.getConexion();
            // la abro.
            conexion.Open();
            // Consulta sql
            string sql = "SELECT * FROM polizas ORDER BY fecha DESC";

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
            string sql = "SELECT * FROM polizas WHERE idCliente = " + idCliente + " ORDER BY fecha DESC";

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

        public static DataTable getClienteById(int idCliente)
        {
            MySqlConnection conexion = ConexionBaseDatos.getConexion();
            // la abro.
            conexion.Open();
            // Consulta sql
            string sql = "SELECT * FROM clientes where idCliente = " + idCliente;

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
        public static int registrarCliente(Cliente cliente)
        {
            // Creo la conexion con la base de datos.
            MySqlConnection conexion = ConexionBaseDatos.getConexion();
            // la abro.
            conexion.Open();

            // Consulta sql
            string sql = "INSERT INTO clientes ( nombre, apellidos, dni, telefono, correo, contraseña, provincia, municipio, tipo ) " +
                                      "VALUES ( @nombre, @apellidos, @dni, @telefono, @correo, @contraseña, @provincia, @municipio, @tipo )";
            // Preparo la consulta
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            // Le paso el pago
            comando.Parameters.AddWithValue("@nombre", cliente.Nombre);
            comando.Parameters.AddWithValue("@apellidos", cliente.Apellidos);
            comando.Parameters.AddWithValue("@dni", cliente.Dni);
            comando.Parameters.AddWithValue("@telefono", cliente.Telefono);
            comando.Parameters.AddWithValue("@correo", cliente.Correo);
            comando.Parameters.AddWithValue("@contraseña", cliente.Contraseña);
            comando.Parameters.AddWithValue("@provincia", cliente.IdProvincia);
            comando.Parameters.AddWithValue("@municipio", cliente.IdMuncipio);
            comando.Parameters.AddWithValue("@tipo", cliente.Tipo);

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

        // Actualiza datos del cliente
        public static int editarCliente(Cliente cliente)
        {
            // Creo la conexion con la base de datos.
            MySqlConnection conexion = ConexionBaseDatos.getConexion();
            // la abro.
            conexion.Open();

            // Consulta sql
            // Consulta SQL para realizar un UPDATE en lugar de un INSERT
            string sql = "UPDATE clientes SET nombre = @nombre, apellidos = @apellidos, dni = @dni, telefono = @telefono, " +
                         "correo = @correo, contraseña = @contraseña, provincia = @provincia, municipio = @municipio, tipo = @tipo " +
                         "WHERE idCliente = @idCliente"; // Ajusta la condición WHERE según la estructura de tu tabla y el nombre de la columna que identifica al cliente (id en este caso)

            // Preparo la consulta
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            // Le paso el pago
            comando.Parameters.AddWithValue("@nombre", cliente.Nombre);
            comando.Parameters.AddWithValue("@apellidos", cliente.Apellidos);
            comando.Parameters.AddWithValue("@dni", cliente.Dni);
            comando.Parameters.AddWithValue("@telefono", cliente.Telefono);
            comando.Parameters.AddWithValue("@correo", cliente.Correo);
            comando.Parameters.AddWithValue("@contraseña", cliente.Contraseña);
            comando.Parameters.AddWithValue("@provincia", cliente.IdProvincia);
            comando.Parameters.AddWithValue("@municipio", cliente.IdMuncipio);
            comando.Parameters.AddWithValue("@tipo", cliente.Tipo);
            comando.Parameters.AddWithValue("@idCliente", cliente.IdCliente);

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

        // Elimina un jugador y todas sus partidas
        public static bool eliminarCliente(int idCliente)
        {
            // Creo la conexion con la base de datos.
            MySqlConnection conexion = ConexionBaseDatos.getConexion();
            // la abro.
            conexion.Open();

            bool eliminado;

            // Inicio una transacción
            MySqlTransaction transaccion = null;

            try
            {
                // Mi transaccion
                transaccion = conexion.BeginTransaction();

                // Consulta sql para eliminar todas las polizas del cliente
                string sql = "DELETE FROM polizas WHERE idCliente = @idCliente";
                // Mi sql y conexon
                MySqlCommand comandoEliminarPolizas = new MySqlCommand(sql, conexion);
                // Le paso como parametro el id del cliente a eliminar
                comandoEliminarPolizas.Parameters.AddWithValue("@idCliente", idCliente);
                // Preparo la transaccion.
                comandoEliminarPolizas.Transaction = transaccion;

                // Ejecutar la transaccion.
                comandoEliminarPolizas.ExecuteNonQuery();

                // Consulta sql para eliminar al cliente
                sql = "DELETE FROM clientes WHERE idCliente = @idCliente";
                // Mi sql y conexon
                MySqlCommand comandoEliminarCliente = new MySqlCommand(sql, conexion);
                // Le paso como parametros el id del cliente
                comandoEliminarCliente.Parameters.AddWithValue("@idCliente", idCliente);
                // Preparo la transaccion.
                comandoEliminarCliente.Transaction = transaccion;

                // Ejecutar la consulta para eliminar al jugador y obtengo un 1 si se ha realizado con exito y 0 en caso contrario
                int estado = comandoEliminarCliente.ExecuteNonQuery();

                // Convierto el int a bool
                eliminado = (estado != 0);

                // Confirmar la transacción
                transaccion.Commit();
            }
            catch (Exception ex)
            {
                // Si ocurre algún error, se realiza un rollback de la transacción
                if (transaccion != null)
                {
                    transaccion.Rollback();
                }
                eliminado = false;
            }
            finally
            {
                // Cierro la conexión
                conexion.Close();
            }

            return eliminado;

        }

        // Filtra la busqueda de los jugadores que coincidan por nombre.
        public static DataTable buscar(string tabla, string texto)
        {
            MySqlConnection conexion = ConexionBaseDatos.getConexion();
            // la abro.
            conexion.Open();
            // Mi consulta 
            string sql = $"SELECT * FROM {tabla} WHERE nombre LIKE @texto OR apellidos LIKE @texto OR correo LIKE @texto";

            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@texto", "%" + texto + "%");

            // creo el adaptador
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);

            // Instancio una tabla vacia. 
            DataTable table = new DataTable();

            try
            {
                adapter.Fill(table); // Relleno la tabla con el resulatado de la consulta.

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
        public static bool registrarPoliza(Poliza poliza)
        {
            // Creo la conexion con la base de datos.
            MySqlConnection conexion = ConexionBaseDatos.getConexion();
            // la abro.
            conexion.Open();

            // Consulta sql
            string sql = "INSERT INTO polizas (importe, tipo, estado, observaciones, fecha, idCliente) VALUES (@importe, @tipo, @estado, @observaciones, @fecha, @idCliente)";

            // Preparo la consulta
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            // Le paso el pago

            // Agregar los parámetros para importe, estado, fecha y ID del cliente
            comando.Parameters.AddWithValue("@importe", poliza.Importe);
            comando.Parameters.AddWithValue("@tipo", poliza.Tipo);
            comando.Parameters.AddWithValue("@estado", poliza.Estado);
            comando.Parameters.AddWithValue("@observaciones", poliza.Observaciones);
            comando.Parameters.AddWithValue("@fecha", poliza.Fecha);
            comando.Parameters.AddWithValue("@idCliente", poliza.IdCliente);

            bool creado;

            try
            {
                // Return value is the number of rows affected by the SQL statement.
                int estado = comando.ExecuteNonQuery();
                // Convierto el int a bool
                creado = (estado != 0);
            }
            catch (Exception ex)
            {
                creado = false;
                Console.WriteLine(ex.Message);
            }

            return creado;

        }

        // Registra un nuevo usuario
        public static bool editarPoliza(Poliza poliza)
        {
            // Creo la conexion con la base de datos.
            MySqlConnection conexion = ConexionBaseDatos.getConexion();
            // la abro.
            conexion.Open();

            // Consulta sql
            string sql = "UPDATE polizas SET importe = @importe, tipo = @tipo, estado = @estado, observaciones = @observaciones,idCliente = @idCliente, fecha = @fecha WHERE idPoliza = @idPoliza";

            // Preparo la consulta
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            // Le paso el pago

            // Agregar los parámetros para importe, estado, fecha y ID del cliente
            comando.Parameters.AddWithValue("@importe", poliza.Importe);
            comando.Parameters.AddWithValue("@tipo", poliza.Tipo);
            comando.Parameters.AddWithValue("@estado", poliza.Estado);
            comando.Parameters.AddWithValue("@observaciones", poliza.Observaciones);
            comando.Parameters.AddWithValue("@idCliente", poliza.IdCliente);
            comando.Parameters.AddWithValue("@fecha", poliza.Fecha);
            comando.Parameters.AddWithValue("@idPoliza", poliza.Id);

            bool creado;

            try
            {
                // Return value is the number of rows affected by the SQL statement.
                int estado = comando.ExecuteNonQuery();
                // Convierto el int a bool
                creado = (estado != 0);
            }
            catch (Exception ex)
            {
                creado = false;
                Console.WriteLine(ex.Message);
            }

            return creado;

        }

        // Elimina un jugador y todas sus partidas
        public static bool eliminarPoliza(int idPoliza)
        {
            // Creo la conexion con la base de datos.
            MySqlConnection conexion = ConexionBaseDatos.getConexion();
            // la abro.
            conexion.Open();

            bool eliminado;

            // Inicio una transacción
            MySqlTransaction transaccion = null;

            try
            {
                // Mi transaccion
                transaccion = conexion.BeginTransaction();

                // Consulta sql para eliminar todas las polizas del cliente
                string sql = "DELETE FROM pagos WHERE idPoliza = @idPoliza";
                // Mi sql y conexon
                MySqlCommand comandoEliminarPago = new MySqlCommand(sql, conexion);
                // Le paso como parametro el id del cliente a eliminar
                comandoEliminarPago.Parameters.AddWithValue("@idPoliza", idPoliza);
                // Preparo la transaccion.
                comandoEliminarPago.Transaction = transaccion;

                // Ejecutar la transaccion.
                comandoEliminarPago.ExecuteNonQuery();

                // Consulta sql para eliminar al cliente
                sql = "DELETE FROM polizas WHERE idPoliza = @idPoliza";
                // Mi sql y conexon
                MySqlCommand comandoEliminarPoliza = new MySqlCommand(sql, conexion);
                // Le paso como parametros el id del cliente
                comandoEliminarPoliza.Parameters.AddWithValue("@idPoliza", idPoliza);
                // Preparo la transaccion.
                comandoEliminarPoliza.Transaction = transaccion;

                // Ejecutar la consulta para eliminar al jugador y obtengo un 1 si se ha realizado con exito y 0 en caso contrario
                int estado = comandoEliminarPoliza.ExecuteNonQuery();

                // Convierto el int a bool
                eliminado = (estado != 0);

                // Confirmar la transacción
                transaccion.Commit();
            }
            catch (Exception ex)
            {
                // Si ocurre algún error, se realiza un rollback de la transacción
                if (transaccion != null)
                {
                    transaccion.Rollback();
                }
                eliminado = false;
            }
            finally
            {
                // Cierro la conexión
                conexion.Close();
            }

            return eliminado;

        }


        // Registra un nuevo usuario
        public static int pagarPoliza(decimal pago, int idPoliza)
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

        // Actualiza estado de la poliza
        public static int actualizarEstadoPoliza(int idPoliza, string estado)
        {
            // Creo la conexion con la base de datos.
            MySqlConnection conexion = ConexionBaseDatos.getConexion();
            // la abro.
            conexion.Open();

            // Consulta sql
            string sql = "UPDATE polizas SET estado = @estado WHERE idPoliza = @idPoliza";
            // Preparo la consulta
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            // Estado de la poliza
            comando.Parameters.AddWithValue("@estado", estado);
            // Id de la poliza 
            comando.Parameters.AddWithValue("@idPoliza", idPoliza);


            int actualizado;

            try
            {
                actualizado = comando.ExecuteNonQuery(); // Return value is the number of rows affected by the SQL statement.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                actualizado = 0;
            }

            return actualizado;

        }

        // Obtengo todos las provincias
        public static DataTable getProvincias()
        {
            MySqlConnection conexion = ConexionBaseDatos.getConexion();
            // la abro.
            conexion.Open();
            // Consulta sql
            string sql = "SELECT * FROM provincias";

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

        // Obtengo los muncipios de una provia.
        public static DataTable getMunicipiosPorProvincia(int idProvincia)
        {
            MySqlConnection conexion = ConexionBaseDatos.getConexion();
            // la abro.
            conexion.Open();
            // Consulta sql
            string sql = "SELECT * FROM municipios WHERE provincia = " + idProvincia;

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

        // Obtengo el nombre de la provincia
        public static string getNombresProvincia(int idProvincia)
        {
            MySqlConnection conexion = ConexionBaseDatos.getConexion();
            // la abro.
            conexion.Open();
            // Consulta SQL para obtener el nombre de la provincia
            string sql = "SELECT provincia FROM provincias WHERE id = @idProvincia";

            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@idProvincia", idProvincia);

            // Ejecuta la consulta y obtiene el nombre de la provincia
            object resultado = comando.ExecuteScalar();
            // Obtengo nombre   
            string nombreProvincia = resultado.ToString();

            // Devuelvo dato
            return nombreProvincia;

        }

        // Obtengo el nombre del municipio
        public static string getNombresMunicipio(int idMunicipio)
        {
            MySqlConnection conexion = ConexionBaseDatos.getConexion();
            // la abro.
            conexion.Open();
            // Consulta SQL 
            string sql = "SELECT municipio FROM municipios WHERE id = @idMunicipio";

            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@idMunicipio", idMunicipio);

            // Ejecuta la consulta y obtiene el nombre de la provincia
            object resultado = comando.ExecuteScalar();
            // Obtengo nombre   
            string nombreMunicipio = resultado.ToString();

            // Devuelvo dato
            return nombreMunicipio;

        }

        public static DataTable generarInformes(int idClienteMin, int idClienteMax, DateTime fechaDesde, DateTime fechaHasta )
        {

            MySqlConnection conexion = ConexionBaseDatos.getConexion();
            // la abro.
            conexion.Open();

            DataTable dataTable = new DataTable();

            // Construir la consulta SQL
            string sql = @"
                            SELECT 
                                c.idCliente,
                                c.nombre AS nombreCliente,
                                p.idPoliza,
                                p.importe,
                                p.tipo,
                                p.observaciones,
                                p.fecha,
                                p.estado
                            FROM 
                                clientes c
                            INNER JOIN 
                                polizas p ON c.idCliente = p.idCliente
                            WHERE 
                                c.idCliente BETWEEN @idClienteMin AND @idClienteMax
                                AND p.fecha BETWEEN @fechaDesde AND @fechaHasta";


            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@idClienteMin", idClienteMin);
            comando.Parameters.AddWithValue("@idClienteMax", idClienteMax);
            comando.Parameters.AddWithValue("@fechaDesde", fechaDesde);
            comando.Parameters.AddWithValue("@fechaHasta", fechaHasta);

            // Creo el adapatador
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
            adapter.Fill(dataTable);

            // Cerrar la conexión manualmente
            conexion.Close();

            return dataTable;

        }

        // Genera informa por id clientes, fecha y ademas el esatdo de la poliza.
        public static DataTable generarInformePorEstado(int idClienteMin, int idClienteMax, DateTime fechaDesde, DateTime fechaHasta, string estado)
        {

            MySqlConnection conexion = ConexionBaseDatos.getConexion();
            // la abro.
            conexion.Open();

            DataTable dataTable = new DataTable();

            // Construir la consulta SQL
            string sql = @"
                            SELECT 
                                c.idCliente,
                                c.nombre AS nombreCliente,
                                p.idPoliza,
                                p.importe,
                                p.tipo,
                                p.observaciones,
                                p.fecha,
                                p.estado
                            FROM 
                                clientes c
                            INNER JOIN 
                                polizas p ON c.idCliente = p.idCliente
                            WHERE 
                                c.idCliente BETWEEN @idClienteMin AND @idClienteMax
                                AND p.fecha BETWEEN @fechaDesde AND @fechaHasta
                                AND p.estado = @estadoPoliza";


            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@idClienteMin", idClienteMin);
            comando.Parameters.AddWithValue("@idClienteMax", idClienteMax);
            comando.Parameters.AddWithValue("@fechaDesde", fechaDesde);
            comando.Parameters.AddWithValue("@fechaHasta", fechaHasta);
            comando.Parameters.AddWithValue("@estadoPoliza", estado);

            // Creo el adapatador
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
            adapter.Fill(dataTable);

            // Cerrar la conexión manualmente
            conexion.Close();

            return dataTable;

        }


    }
}
