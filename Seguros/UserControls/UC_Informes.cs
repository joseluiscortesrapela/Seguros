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
    public partial class UC_Informes : UserControl
    {
        public UC_Informes()
        {
            InitializeComponent();
        }

        // Realizo el informe
        private void btnGenerarInforme_Click(object sender, EventArgs e)
        {
            // Obtegno datos formulario informe
            int desdeIdeCliente = int.Parse(idCliente1.Value.ToString());
            int hastaIdCliente = int.Parse(idCliente2.Value.ToString());
            DateTime fechaDesde = dtpFechaDetalle.Value;
            DateTime fechaHasta = dtpFechaHasta.Value;
            string estado = cbEstadosInforme.Text;

            // Si estado de la poliza es 
            if (estado == "Todas")
            {   // Obtengo todas las polizas independientemente de su estado
                dgvInformePolizas.DataSource = AdminModel.generarInformes(desdeIdeCliente, hastaIdCliente, fechaDesde, fechaHasta);
            }
            else
            {   
                // Obtengo las polizas por su estado
                dgvInformePolizas.DataSource = AdminModel.generarInformePorEstado(desdeIdeCliente, hastaIdCliente, fechaDesde, fechaHasta, estado);
            }


            Console.WriteLine("idDesde: " + desdeIdeCliente + " idHasta: " + hastaIdCliente + " fecha desde: " + fechaDesde + " fecha hasta: " + fechaHasta + " estado: " + estado);

        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
