using Seguros.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seguros.Forms
{
    public partial class MenuCliente : Form
    {
        private int idCliente;

        // Constructor
        public MenuCliente()
        {
            InitializeComponent();
        }

        // Autoload
        private void MenuCliente_Load(object sender, EventArgs e)
        {
            // Obtengo los datos de la sesion 
            // Guardo id cliente
            idCliente = SesionUsuario.Id;
            // Muestro los apellidos
            lbApellidos.Text = SesionUsuario.Apellidos;
            // Muestro nombre usuario
            lbUsuario.Text = SesionUsuario.Nombre;
            // Muestro tipo o rol del usuario.
            lbTipo.Text = SesionUsuario.Tipo;
        }


        // Muestra el buscador
        private void pbMostrarBuscador_Click(object sender, EventArgs e)
        {
            // Si el buscador era visible
            if (panelBuscador.Visible)
            {   // Oculto busacador
                panelBuscador.Visible = false;
            }
            else
            { // Si estaba oculto lo muestro
                panelBuscador.Visible = true;
            }

        }


        private void btnMisPolizas_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Muestro las polizas del cliente con id: " + idCliente);

            // Muestro panel 
            panelPolizas.Visible = true;
            // Muestro las polizas del cliente.
            dgvPolizas.DataSource = AdminModel.getLasPolizasDelCliente(idCliente);
        }

        // Muestro panel principal
        private void pbInicio_Click(object sender, EventArgs e)
        {
            // Oculto las polizas
            panelPolizas.Visible = false;
            // Oculto buscador
            panelBuscador.Visible = false;
        }

        // Cierro sesion 
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            // Oculto ventana menu jugador
            this.Hide();
            // Instancio la clase
            Login login = new Login();
            // Muestro la vengana de login/registro
            login.Show();
        }


        // Se cierra el programa
        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
