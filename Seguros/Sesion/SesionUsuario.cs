using System;

namespace Seguros
{
    internal class SesionUsuario
    {

        private static int id;
        private static String usuario;
        private static String tipo;


        public static int Id { get => id; set => id = value; }
        public static string Usuario { get => usuario; set => usuario = value; }
        public static string Tipo { get => tipo; set => tipo = value; }
    }
}
