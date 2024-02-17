using MySql.Data.MySqlClient;
using System;
using Seguros.Conexion;
using System.Windows.Forms;

namespace Seguros.Models
{
    internal class LoginModel
    {

        // Comprueba si existe un usuario
        public bool login(string correo, string contraseña)
        {
            // Creo la conexion con la base de datos.
            MySqlConnection conexion = ConexionBaseDatos.getConexion();
            // la abro.
            conexion.Open();
            // Consulta sql
            string sql = @"
                            SELECT 'administradores' AS tipo, nombre, apellidos, idAdministrador AS id 
                            FROM administradores 
                            WHERE correo = @correo AND contraseña = @contraseña 

                            UNION ALL 

                            SELECT 'agentes' AS tipo, nombre, apellidos, idAgente AS id 
                            FROM agentes 
                            WHERE correo = @correo AND contraseña = @contraseña 

                            UNION ALL 

                            SELECT 'clientes' AS tipo, nombre, apellidos, idCliente AS id
                            FROM clientes 
                            WHERE correo = @correo AND contraseña = @contraseña;";

            // Preparo la consulta
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            // Le paso como parametro el correo del usuario
            comando.Parameters.AddWithValue("@correo", correo);
            // Le paso como parametro la contraseña del usaurio.
            comando.Parameters.AddWithValue("@contraseña", contraseña);

            // Obtengo los resultado de la consulta
            MySqlDataReader reader = comando.ExecuteReader();
            // Si el numero de filas es false, no se ha encontrado el usuario.
            bool existe = reader.HasRows;
        
            // Si existe el usuario
            if (existe)
            {
                crearSesion(reader); // Creo una sesion para el usuario, para mantener los datos en cache.
            }

            // Devuelvo resultado 
            return existe;

        }

        // Compruebo si existe el usuario
        public bool isUserExist(string jugador)
        {
            // Creo la conexion con la base de datos.
            MySqlConnection conexion = ConexionBaseDatos.getConexion();
            // la abro.
            conexion.Open();
            // Consulta sql
            string sql = "SELECT * FROM jugadores WHERE jugador = @jugador";
            // Preparo la consulta
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            // Le paso como parametro el nombre del jugador o de la palabra
            comando.Parameters.AddWithValue("@jugador", jugador);
            // Obtengo los resultado de la consulta
            MySqlDataReader reader = comando.ExecuteReader();
            // Si el numero de filas es false, no se ha encontrado el usuario.
            bool existe = reader.HasRows;

            // Devuelvo resultado
            return existe;

        }

        // Registra un nuevo usuario
        public int registrarJugador(string jugador, string contraseña)
        {
            // Creo la conexion con la base de datos.
            MySqlConnection conexion = ConexionBaseDatos.getConexion();
            // la abro.
            conexion.Open();

            // Consulta sql
            string sql = "INSERT INTO jugadores ( jugador, contraseña ) VALUES ( @jugador, @contraseña )";
            // Preparo la consulta
            MySqlCommand comando = new MySqlCommand(sql, conexion);

            // Le paso como parametro el nombre del usuario.
            comando.Parameters.AddWithValue("@jugador", jugador);
            // Le como parametro la contraseña
            comando.Parameters.AddWithValue("@contraseña", contraseña);


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

        // Crea la sesion del usuario
        public void crearSesion(MySqlDataReader reader)
        {
            // Mientra haya que leer
            while (reader.Read())
            {
                // Obtengo datos usuario 
                int id = reader.GetInt32("id");         
                string nombre = reader.GetString("nombre");
                string apellidos = reader.GetString("apellidos");
                string tipo = reader.GetString("tipo");

                Console.WriteLine("id: " + id + " nombre: " + nombre + " apellidos: " + apellidos + " tipo: " + tipo);

                // Creo la sesion con los datos basico del usaurio que se acaba de logear con exito.
                SesionUsuario.Id = id;
                SesionUsuario.Usuario = nombre;
                SesionUsuario.Tipo = tipo;

            }

        }


    }
}
