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
    public partial class UC_CrudAdministradores : UserControl
    {
        // Constructor
        public UC_CrudAdministradores()
        {
            InitializeComponent();
        }

        // Autoload
        private void UC_CrudAdministradores_Load(object sender, EventArgs e)
        {
            dgvAdministradores.DataSource = AdminModel.getAdministradores();
        }

        private void pbCrear_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Crear administrador");
        }

        private void pbEditar_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Editar administrador");
        }

        private void pbEliminar_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Eliminar administrador");
        }

        
    }
}
