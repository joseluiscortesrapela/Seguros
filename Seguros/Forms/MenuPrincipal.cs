﻿using MySqlX.XDevAPI;
using Seguros.Models;
using Seguros.Sesion;
using Seguros.UserControls;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Seguros.Forms
{
    public partial class MenuPrincipal : Form
    {
        private int idUsuario;
        private string tipo;

        public MenuPrincipal()
        {
            InitializeComponent();
            // Obtengo el id
            idUsuario = SesionUsuario.Id;
            // Obtengo el tipo o rol
            tipo = SesionUsuario.Tipo;
            // Muestro el menu principal segun tipo usuario.
            prepararInterfazUsuario(tipo);

        }

        // Prepara interfaz del usuaqrio dependiendo del tipo o rol 
        private void prepararInterfazUsuario(string tipo)
        {
            // Tipo usuario
            switch (tipo)
            {
                case "administradores":
                    btnAdministradores.Visible = true;
                    btnAgentes.Visible = true;
                    btnClientes.Visible = true;
                    btnPolizas.Visible = true;
                    btnInformes.Visible = true;
                    break;
                case "agentes":
                    btnMisClientes.Visible = true;
                    btnInformes.Visible = true;
                    break;
                case "clientes":
                    btnMisPolizas.Visible = true;
                    break;
            }

        }

 


        // Auto load ventana
        private void MenuAdministrador_Load(object sender, EventArgs e)
        {
            // Muestro nombre usuario
            lbUsuario.Text = SesionUsuario.Nombre;
            // Muestro tipo o rol del usuario.
            lbTipo.Text = SesionUsuario.Tipo;
        }

        // Muestra las polizas
        private void btnPolizas_Click(object sender, EventArgs e)
        {
            mostrarUserControl(new UC_CrudPolizas());
        }

        // Muestro los clietnes
        private void btnClientes_Click(object sender, EventArgs e)
        {
            // Muestro la vengana 
            mostrarUserControl(new UC_CrudClientes());
        }


        // Muestro la venana con los administradores
        private void btnAdministradores_Click(object sender, EventArgs e)
        {          
            // Muestro la ventana 
            mostrarUserControl(new UC_CrudAdministradores());
        }

        // Muestro ventana con los agentes
        private void btnAgentes_Click(object sender, EventArgs e)
        {
            // Muestro la ventana
            mostrarUserControl(new UC_CrudAgentes());
        }

        // Regreso al inico o home
        private void pbInicio_Click(object sender, EventArgs e)
        {
            panelContenedor.Visible = false;
        }
 


        // Método para mostrar un UserControl en el panel contenedor
        private  void mostrarUserControl(UserControl userControl)
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

        // Muestra las polizas de un cliente
        private void btnMisPolizas_Click(object sender, EventArgs e)
        {
            mostrarUserControl(new UC_CrudPolizas(idUsuario));
        }

        // Muestro ventana clientes
        private void btnMisClientes_Click(object sender, EventArgs e)
        {
            mostrarUserControl(new UC_CrudClientes(idUsuario));

        }

        // Cierro programa
        private void pbExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Muestro ventana informes
        private void btnInformes_Click(object sender, EventArgs e)
        {
            mostrarUserControl(new UC_Informes());
        }
    }
}
