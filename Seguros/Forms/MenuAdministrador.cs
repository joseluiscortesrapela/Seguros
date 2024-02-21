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

        // Cierro la aplicacion
        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Muestra las polizas
        private void btnPolizas_Click(object sender, EventArgs e)
        {   // Obtengo todas las polizas
            dgvTodasLasPolizas.DataSource = AdminModel.getAllPolizas();
            // Muestro el panel
            mostrarPanel("polizas");
        }

        // Muestro los clietnes
        private void btnClientes_Click(object sender, EventArgs e)
        {
            //Obtegno la cartera de clientes del agente de seguros.
            dgvClientes.DataSource = AdminModel.getAllClients();
            // Muestro el panel
            mostrarPanel("clientes");
        }

        // Muestra el conenido del panel que se ha seleccionado desdel el menu de navegacion
        private void mostrarPanel(string panel)
        {
            switch (panel)
            {
                case "administradores":
                    panelAdministradores.Visible = true;
                    panelPolizas.Visible = false;
                    panelClientes.Visible = false;
                    panelAgenetes.Visible = true;
                    Console.WriteLine("Muestro panel administradores");
                    break;

                case "agentes":
                    panelAdministradores.Visible = false;
                    panelAgenetes.Visible = true;
                    panelClientes.Visible = false;
                    panelPolizas.Visible = false;
                    Console.WriteLine("Muestro panel agentes");
                    break;

                case "clientes":
                    panelAdministradores.Visible = false;
                    panelAgenetes.Visible = false;
                    panelClientes.Visible = true;
                    panelPolizas.Visible = false;
                    Console.WriteLine("Muestro panel clientes");
                    break;
                case "polizas":
                    panelAdministradores.Visible = false;
                    panelAgenetes.Visible = false;
                    panelClientes.Visible = false;
                    panelPolizas.Visible = true;
                    Console.WriteLine("Muestro panel polizas");
                    break;

            }

            // Muestro el contenedor principal
            panelContenedor.Visible = true;
        }

        // Muestro todos los administradores
        private void btnAdministradores_Click(object sender, EventArgs e)
        {
            // Obtengo los administradores y los cargo en el dgv
            dgvAdministradores.DataSource = AdminModel.getAllAdministradores();
            mostrarPanel("administradores");
        }

        private void btnAgentes_Click(object sender, EventArgs e)
        {
            dgvTodosLosAgentes.DataSource = AdminModel.getAllAgentes();
            mostrarPanel("agentes");
        }

        // Regreso al inico o home
        private void pbInicio_Click(object sender, EventArgs e)
        {
            panelContenedor.Visible = false;
        }
    }
}
