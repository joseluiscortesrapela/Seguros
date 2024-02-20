using System;

namespace Seguros
{
    internal class SesionUsuario
    {

        private static int id;
        private static String nombre;
        private static String apellidos;
        private static String tipo;


        public static int Id { get => id; set => id = value; }
        public static string Nombre { get => nombre; set => nombre = value; }
        public static string Tipo { get => tipo; set => tipo = value; }
        public static string Apellidos { get => apellidos; set => apellidos = value; }
    }
}
