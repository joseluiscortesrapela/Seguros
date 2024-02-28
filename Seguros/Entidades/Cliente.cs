using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguros.Entidades
{
    public class Cliente
    {
        private string nombre;
        private string apellidos;
        private string dni;
        private string telefono;
        private string correo;
        private string contraseña;
        private int idProvincia;
        private int idMuncipio;
        private string tipo;

        public Cliente(string nombre, string apellidos, string dni, string telefono, string correo, string contraseña, int idProvincia, int idMuncipio, string tipo)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.dni = dni;
            this.telefono = telefono;
            this.correo = correo;
            this.contraseña = contraseña;
            this.idProvincia = idProvincia;
            this.idMuncipio = idMuncipio;
            this.tipo = tipo;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public int IdProvincia { get => idProvincia; set => idProvincia = value; }
        public int IdMuncipio { get => idMuncipio; set => idMuncipio = value; }
        public string Tipo { get => tipo; set => tipo = value; }
    }
}
