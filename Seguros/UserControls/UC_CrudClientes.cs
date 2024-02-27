using Seguros.Forms;
using Seguros.Helper;
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

namespace Seguros.UserControls
{
    public partial class UC_CrudClientes : UserControl
    {
        private DataGridViewRow filaCliente;
        private bool estado;

        // Contruc por por defecto,
        public UC_CrudClientes()
        {
            InitializeComponent();
            // Obtengo todos los clientes  y los guardo en el dgv
            dgvClientes.DataSource = AdminModel.getClientes();        
        }

        // Constructor que recibe el id del agente
        public UC_CrudClientes(int idAgente)
        {
            InitializeComponent();
            // Obtengo solo los clientes del agente de seguros
            dgvClientes.DataSource = AdminModel.getCarteraClientes(idAgente);
        }


        // Obtengo el cliente seleccionado.
        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obtengo la fila que ha sido seleccionada en el dataGridView
            if (e.RowIndex >= 0)
            {
                // Obtengo la que ha sido seleccionada en el dgv
                filaCliente = dgvClientes.Rows[e.RowIndex];
                // Obtengo el id del usuario.
                int idCliente = int.Parse(filaCliente.Cells["idCliente"].Value.ToString());
                // Obtengo nombre cliente
                string nombre = filaCliente.Cells["nombre"].Value.ToString();
                // Muestro botones de accion del crud clientes.
                mostrarBotonesAccion();

                // si se ha habilitado
                if (estado)
                {
                    // Obtengo las polizas de los clietnes
                    DataTable tablaPolizas = AdminModel.getPolizasByClientID(idCliente);

                    // Compruebo que no este vacio
                    if (tablaPolizas.Rows.Count >= 1)
                    {
                        // Muestro las polizas del clietne en el dgv
                        dgvPolizas.DataSource = tablaPolizas;
                        // Cambio color a las filas segun su estado
                        GestorInterfaz.CambiarColorFilas(dgvPolizas);
                        // Muestro nombre cliente
                        lbNombreCliente.Text = nombre;
                    }
                    else
                    {
                        limpiarDgvPolizas();
                    }
                }


            }

        }


        private void pbCrear_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Crear cliente");
        }

        private void pbEditar_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Editar cliente");
        }

        private void pbEliminar_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Eliminar cliente");
        }



        private void limpiarDgvPolizas()
        {
            dgvPolizas.DataSource = null;
            lbNombreCliente.Text = "";
        }


        // Muestra botones de accion
        private void mostrarBotonesAccion()
        {
            pbEditar.Visible = true;
            pbEliminar.Visible = true;
        }

        // Habilito la posibilidad de mostrar los pagos por poliza.
        private void pbMostrarPolizasCliente_Click(object sender, EventArgs e)
        {
            estado = true;
            pbOn.Visible = false;
            pbOff.Visible = true;
            lbMensajeEstado.Text = "Acabas de activar el enlazado de datos dinamico, ahora seleccione un cliente";
            Console.WriteLine("On");
        }

        // Desactivo la posibilidad de mostrar los pagos de cada poliza
        private void pbOcultarPolizasCliente_Click(object sender, EventArgs e)
        {
            estado = false;
            pbOn.Visible = true;
            pbOff.Visible = false;
            dgvPolizas.DataSource = null;
            lbMensajeEstado.Text = "Acabas de deshabilitar el enlazado de datos dinamico";
            Console.WriteLine("off");
        }

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

        // Realiza la busqueda un cliente  por nombre, apellidos o correo.
        private void buscarClientes(object sender, EventArgs e)
        {
            // Obtengo lo que ha escrito en el buscador
            string texto = tbBuscar.Text;
            // Obtengo los clientes que coincidan por los criterios de busqueda.
            dgvClientes.DataSource = AdminModel.buscar("clientes", texto);
        }

        // Limpia contendio del campo de texto del buscador, mensaje placeholder
        private void limpiaPlaceholderBuscador(object sender, EventArgs e)
        {
            tbBuscar.Text = "";
        }
    }




}
