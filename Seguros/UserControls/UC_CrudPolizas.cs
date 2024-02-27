using Seguros.Helper;
using Seguros.Models;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Seguros.UserControls
{
    public partial class UC_CrudPolizas : UserControl
    {
        private int idPoliza;
        private DataGridViewRow filaPoliza;
        private int importe, totalPagado, deboPagar;

        // Constructor
        public UC_CrudPolizas()
        {
            InitializeComponent();
            // Obtengo todas las polizas y las muestro en el dgv
            dgvPolizas.DataSource = AdminModel.getPolizas();
        }

        // Sobrecarga del constructor, recibe el id del cliente
        public UC_CrudPolizas(int idCliente)
        {
            InitializeComponent();
            // Obtengo solo las polizas del cliente y las muestro en el dgv
            dgvPolizas.DataSource = AdminModel.getPolizasByClientID(idCliente);
        }

        // Obtengo la poliza que ha sido seleccionada
        private void dgvPolizas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obtengo la fila que ha sido seleccionada en el dataGridView
            if (e.RowIndex >= 0)
            {   // Obtengo la que ha sido seleccionada en el dgv
                filaPoliza = dgvPolizas.Rows[e.RowIndex];
                // Obtengo el id del usuario.
                idPoliza = int.Parse(filaPoliza.Cells["idPoliza"].Value.ToString());
                // Obtengo estado 
                string estado = filaPoliza.Cells["estado"].Value.ToString();
                // Obtengo el importe 
                importe = int.Parse(filaPoliza.Cells["importe"].Value.ToString());
                // Obtengo el id del cliente de esta poliza.
                int idCliente = int.Parse(filaPoliza.Cells["idCliente"].Value.ToString());
                // Obtengo el cliente de la poliza.
                DataTable clienteData = AdminModel.getClienteById(idCliente);
                // Obtengo el nobmre
                string nombre = clienteData.Rows[0]["nombre"].ToString();
                // Obtengo los apellidos
                string apellidos = clienteData.Rows[0]["apellidos"].ToString();

                // Obtengo los pagos de la poliza seleccionada.
                dgvPagos.DataSource = AdminModel.getPagosByPoliza(idPoliza);

                // Si aun queda por pagar
                if (estado == "A cuenta")
                {
                    // Calculo lo que se ha pagado
                    totalPagado = calcularTotalPagado();
                    // Calculo el importe total que debo
                    deboPagar = importe - totalPagado;
                    // Muestro mensaje al usuario del total que ha pagado hasta el momento
                    lbPago.Text = "Póliza nº " + idPoliza + " del cliente " + nombre + ",  " + apellidos + " lleva pagado " + totalPagado + " € y aun debe un importe de " + deboPagar + " €";
                    // Le doy el valor al campo de pago lo que aun debe de la poliza.
                    tbPago.Text = deboPagar.ToString();
                    // Muestro formulario
                    panelPago.Visible = true;

                }
                else
                {
                    // Muestro mensaje al usuario de que no es necesario pago alguno.
                    lbPago.Text = "La poliza nº " + idPoliza + " al encontrarse " + estado + " no require ningun pago adicional.";
                    // Oculto panel de pago
                    panelPago.Visible = false;
                }

                // Muestro botones editar y eliminar.
                mostrarBotonesAccion();
            }

        }


        private void pbCrear_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Crear poliza");
        }

        private void pbEditar_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Editar poliza " + idPoliza);
        }

        private void pbEliminar_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Eliminar poliza " + idPoliza);
        }


        // Calcula lo que se ha pagado
        private int calcularTotalPagado()
        {
            int total = 0;

            // Recorro el dgv
            foreach (DataGridViewRow row in dgvPagos.Rows)
            {   // Si es la fila vacia por defecto para añadir la salto
                if (row.IsNewRow) continue; // Ignorar la fila de nueva entrada, si está presente
                // Obtengo el valor de la columna pagado, lo convierto a numero y lo voy concatenando.
                total += int.Parse(row.Cells["pagado"].Value.ToString());
            }

            // Devuelvo el total 
            return total;
        }


        // Estado de las polizas por colores, cambia el color de fondo de la fila segun su estado.
        private void cambiarColorPolizas()
        {
            GestorInterfaz.CambiarColorFilas(dgvPolizas);
            Console.WriteLine("Cambiar color a todas las polizas segun su estado");
        }

        // Muestra botones de accion
        private void mostrarBotonesAccion()
        {
            pbEditarPoliza.Visible = true;
            pbEliminarPoliza.Visible = true;
        }

        private void UC_CrudPolizas_Load(object sender, EventArgs e)
        {
            CambiarColorFilas();
        }

        private void CambiarColorFilas()
        {
            GestorInterfaz.CambiarColorFilas(dgvPolizas);
        }
        // Realiza el pago 
        private void pbPagar_Click(object sender, EventArgs e)
        {
            // Obtengo la cantidad a pagar
            int pago = int.Parse(tbPago.Text.ToString());

            // Si paga lo que debe
            if (pago == deboPagar)
            {
                // Si se ha realizado el pago 
                if (AdminModel.pagarPoliza(pago, idPoliza) == 1)
                {
                    // Si ha conseguido actualizar el estado de la poliza a cobrada
                    if (AdminModel.actualizarEstadoPoliza(idPoliza, "Cobrada") == 1)
                    {   // Actualizo las polizas del dgv
                        dgvPolizas.DataSource = AdminModel.getPolizas();
                        // Muestro las filas de las polizas por color segun su estado
                        cambiarColorPolizas();
                        // Muestro mensaje
                        lbMensaje.Text = "Acabas de pagar el importe total de tu poliza";
                    }

                }

            }
            // Si paga una cantidad pero aun sigue debiendo
            else if (pago < deboPagar)
            {
                // Realizo pago
                if (AdminModel.pagarPoliza(pago, idPoliza) == 1)
                {
                    // Actualizo los pagos de la poliza y los muestro en el dgv
                    dgvPagos.DataSource = AdminModel.getPagosByPoliza(idPoliza);
                    // Muestro mensaje
                    lbMensaje.Text = "El pago se ha realizado con exito";
                }
            }
            else
            {   // Cantidad ingresada mayor de lo que debe.
                error.SetError(tbPago, "La cantidad introducida es mayor que lo que debe");
            }

        }

        // Cierro la aplicacion
        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }


}
