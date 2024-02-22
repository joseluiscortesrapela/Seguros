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
    public partial class UC_CurdPolizas : UserControl
    {
        private int idCliente;

        // Constructor
        public UC_CurdPolizas()
        {
            InitializeComponent();
            // Obtengo todas las polizas y las muestro en el dgv
            dgvPolizas.DataSource = AdminModel.getAllPolizas();
        }

        // Sobrecarga del constructor, recibe el id del cliente
        public UC_CurdPolizas(int idCliente)
        {   // Guardo el id
            this.idCliente = idCliente;
            // Obtengo solo las polizas del cliente y las muestro en el dgv
            dgvPolizas.DataSource = AdminModel.getPolizasByClientID(idCliente);
        }

        private void pbCrear_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Crear poliza");
        }

        private void pbEditar_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Editar poliza");
        }

        private void pbEliminar_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Eliminar poliza");
        }
    }
}
