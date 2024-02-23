using Seguros.Forms;
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
        private int idCliente;

        public UC_CrudClientes()
        {
            InitializeComponent();
            // Obtengo todos los clientes  y los guardo en el dgv
            dgvClientes.DataSource = AdminModel.getClientes();
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

        // Obtengo el cliente seleccionado.
        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obtengo la fila que ha sido seleccionada en el dataGridView
            if (e.RowIndex >= 0)
            {   // Obtengo la que ha sido seleccionada en el dgv
                filaCliente = dgvClientes.Rows[e.RowIndex];
                // Obtengo el id del usuario.
                idCliente = int.Parse(filaCliente.Cells["idCliente"].Value.ToString());
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



    }




}
