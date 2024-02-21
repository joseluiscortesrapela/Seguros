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
    public partial class MenuAgentes : Form
    {
        private int idAgente;
        private DataGridViewRow filaCliente;

        // Constructor.
        public MenuAgentes()
        {
            InitializeComponent();
        }

        // Autoload
        private void MenuAgentes_Load(object sender, EventArgs e)
        {
            // Obtengo los datos de la sesion 
            // Guardo id cliente
            idAgente = SesionUsuario.Id;
            // Muestro los apellidos
            lbApellidos.Text = SesionUsuario.Apellidos;
            // Muestro nombre usuario
            lbUsuario.Text = SesionUsuario.Nombre;
            // Muestro tipo o rol del usuario.
            lbTipo.Text = SesionUsuario.Tipo;
        }

        // Muestro los clientes del agente de seguros.
        private void btnClientes_Click(object sender, EventArgs e)
        {
            //Obtegno la cartera de clientes del agente de seguros.
            dgvClientes.DataSource = AdminModel.getCarteraClientes(idAgente);

            panelContenedor.Visible = true;
            // Muestro panel
            panelClientes.Visible = true;

            Console.WriteLine("Muestro la cartera de clientes del agente " + idAgente);
        }

        // Vuelvo al menu principal
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Oculto los clientes
            panelContenedor.Visible = false;
            // Oculto buscador
            panelBuscador.Visible = false;
            // Oculto el dgv de con las polias
            panelPolizas.Visible = false;
        }

        // Obtengo cliente seleccionado
        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtengo la que ha sido seleccionada en el dgv
                filaCliente = dgvClientes.Rows[e.RowIndex];
                // Obtengo el id del cliente
                int idCliente = int.Parse(filaCliente.Cells["idCliente"].Value.ToString());
                // Obtengo las polizas del cliente
                dgvPolizas.DataSource = AdminModel.getPolizasByClientID(idCliente);
                // Muestro el panel
                panelPolizas.Visible = true;
            }

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            // Oculto ventana menu jugador
            this.Hide();
            // Instancio la clase
            Login login = new Login();
            // Muestro la vengana de login/registro
            login.Show();

        }


        // Muestro buscador
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

        // Cierro la apliacion.
        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

    }
}
