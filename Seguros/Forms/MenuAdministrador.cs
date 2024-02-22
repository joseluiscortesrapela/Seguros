using Seguros.Models;
using Seguros.UserControls;
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
    public partial class MenuAdministrador : Form
    {
        public MenuAdministrador()
        {
            InitializeComponent();
        }

        private void salir(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Salimos del programa
        private void pbMostrarBuscador_Click(object sender, EventArgs e)
        {
            if (panelBuscador.Visible)
            {
                panelBuscador.Visible = false;
            }
            else
            {
                panelBuscador.Visible = true;
            }


        }

        // Cierra la sesion actual
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            // Oculto ventana menu jugador
            this.Hide();
            // Instancio la clase
            Login login = new Login();
            // Muestro la vengana de login/registro
            login.Show();
        }


        // Auto load ventana
        private void MenuAdministrador_Load(object sender, EventArgs e)
        {
            // Obtengo los datos de la sesion 

            // Muestro nombre usuario
            lbUsuario.Text = SesionUsuario.Nombre;
            // Muestro tipo o rol del usuario.
            lbTipo.Text = SesionUsuario.Tipo;
        }

        // Muestra las polizas
        private void btnPolizas_Click(object sender, EventArgs e)
        {
            MostrarUserControl(new UC_CurdPolizas());
        }

        // Muestro los clietnes
        private void btnClientes_Click(object sender, EventArgs e)
        {

        }


        // Muestro todos los administradores
        private void btnAdministradores_Click(object sender, EventArgs e)
        {
            MostrarUserControl(new UC_CrudAdministradores());
        }


        private void btnAgentes_Click(object sender, EventArgs e)
        {

        }

        // Regreso al inico o home
        private void pbInicio_Click(object sender, EventArgs e)
        {
            panelContenedor.Visible = false;
        }

        // Método para mostrar un UserControl en el panel contenedor
        private void MostrarUserControl(UserControl userControl)
        {
            // Limpiar el panel contenedor antes de agregar un nuevo control
            panelContenedor.Controls.Clear();
            // Muestro el panel
            panelContenedor.Visible = true;
            // Ajustar el tamaño del UserControl al tamaño del panel contenedor
            userControl.Dock = DockStyle.Fill;
            // Agregar el UserControl al panel contenedor
            panelContenedor.Controls.Add(userControl);
        }

        // Cierro la aplicacion
        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
