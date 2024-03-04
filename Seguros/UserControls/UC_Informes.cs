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

            // Resaltar las pólizas no liquidadas en rojo
            foreach (DataGridViewRow fila in dgvInformePolizas.Rows)
            {
                string estadoPoliza = fila.Cells["estado"].Value.ToString();
                if (estadoPoliza != "Liquidada" )
                {
                    fila.DefaultCellStyle.BackColor = Color.Red;
                }
                
            }



            // Crear un diccionario para almacenar los totales por cliente
            Dictionary<int, decimal> totalesPorCliente = new Dictionary<int, decimal>();

            // Recorrer las filas del DataGridView
            foreach (DataGridViewRow fila in dgvInformePolizas.Rows)
            {
                // Obtener el IdCliente y el importe de la fila actual
                int idCliente = Convert.ToInt32(fila.Cells["idCliente"].Value);
                decimal importe = Convert.ToDecimal(fila.Cells["importe"].Value);

                // Verificar si el IdCliente ya está en el diccionario
                if (totalesPorCliente.ContainsKey(idCliente))
                {
                    // Muestro mensaje
                    lbMensajeInforme.Text = "Importe total por clientes";
                    // Si el IdCliente ya existe, sumar el importe al total existente
                    totalesPorCliente[idCliente] += importe;

                }
                else
                {   // Quito mensaje
                    lbMensajeInforme.Text = "";
                    // Si el IdCliente no existe, agregar una nueva entrada en el diccionario con el importe
                    totalesPorCliente.Add(idCliente, importe);
                }
            }

            // Limpiar el DataGridView antes de agregar los nuevos datos
            dgvInformePorCliente.Rows.Clear();

            // Agregar los totales por cliente al DataGridView
            foreach (var totalPorCliente in totalesPorCliente)
            {
                dgvInformePorCliente.Rows.Add(totalPorCliente.Key, totalPorCliente.Value);
            }

            // Si tiene resultados que mosrar
            if (dgvInformePorCliente.RowCount > 0)
            {   // Muestro la tabla
                dgvInformePorCliente.Visible = true;
            }
            else
            {   // Sino hay resultados no muestro nada.
                dgvInformePorCliente.Visible = false;
            }


        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
