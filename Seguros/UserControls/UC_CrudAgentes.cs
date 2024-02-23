using Seguros.Models;
using System;
using System.Windows.Forms;

namespace Seguros.UserControls
{
    public partial class UC_CrudAgentes : UserControl
    {

        private DataGridViewRow filaAgente, filaCliente;
        private bool estado;

        public UC_CrudAgentes()
        {
            InitializeComponent();
            // Obtengo todos los agentes y los gaurdo en el dgv
            dgvAgentes.DataSource = AdminModel.getAgentes();
        }


        // Obtengo el agente que ha sido seleccionado.
        private void dgvAgentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obtengo la fila que ha sido seleccionada en el dataGridView
            if (e.RowIndex >= 0)
            {   // Obtengo la que ha sido seleccionada en el dgv
                filaAgente = dgvAgentes.Rows[e.RowIndex];
                // Obtengo el id del usuario.
                int idAgente = int.Parse(filaAgente.Cells["idAgente"].Value.ToString());


                // Si quiere ver clientes y polizas
                if (estado)
                {
                    // Obtengo la cartera de clientes del agente y los gaurdo en un dgv.
                    dgvClientes.DataSource = AdminModel.getCarteraClientes(idAgente);
            
                    // Obtengo el nombre del agente
                    string nombre = filaAgente.Cells["nombre"].Value.ToString();
                    // Obtengo los apellidos del agente
                    string apellido = filaAgente.Cells["apellidos"].Value.ToString();
                    // Concateno nombre y apellidos y los muestro
                    lbNombreAgente.Text = apellido + ", " + nombre;
                    // Muestro panel
                    panelCarteraClientes.Visible = true;

                }

                // Muestro botones de accion
                mostrarBotonesAccion();
            }
        }





        // Muestra botones de accion
        private void mostrarBotonesAccion()
        {
            pbEditar.Visible = true;
            pbEliminar.Visible = true;
        }

        // Muestra formulario para crear un nuevo agente
        private void pbCrear_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Crear agente");

        }

        // Muestra formulario para editar los datos del agente
        private void pbEditar_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Editar agente");
        }

        // Muestra formulario para eliminar un agente
        private void pbEliminar_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Eliminar agente");
        }


        private void pbMostrarCarterClientes_Click(object sender, EventArgs e)
        {
            estado = true;
            pbOn.Visible = false;
            pbOff.Visible = true;
            panelCarteraClientes.Visible = true;
            lbEstado.Text = "Acabas de activar el enlazado de datos dinamico";
            Console.WriteLine("On");
        }


        private void pbOcultarCarteraClientes_Click(object sender, EventArgs e)
        {
            estado = false;
            pbOn.Visible = true;
            pbOff.Visible = false;
            panelCarteraClientes.Visible = false;
            lbEstado.Text = "Acabas de destivar el enlazado de datos dinamico";
            Console.WriteLine("off");
        }

        // Obtengo el cliente que ha sido seleccionado en el dgv

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Si no esta vacia
            if (e.RowIndex >= 0)
            {   // Obtengo la fila y la guardo
                filaCliente = dgvClientes.Rows[e.RowIndex];
                // Obtengo el id del usuario.
                int idCliente = int.Parse(filaCliente.Cells["idCliente"].Value.ToString());
                // Muestro el nombre 
                lbNombreCliente.Text = filaCliente.Cells["nombre"].Value.ToString();
                // Obtengo las polizas del cliente y las muestro en el dgv
                dgvPolizas.DataSource = AdminModel.getPolizasByClientID(idCliente);

                Console.WriteLine("mostrar polizas del cliente id " + idCliente);
                // Muestro botones de accion
                // mostrarBotonesAccion();
            }
        }

    }
}
