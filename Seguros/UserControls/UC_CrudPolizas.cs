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
            // Preparo ventana para el cliente
            prepararInterfazUsuario();
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
                    lbPago.Text = "Póliza nº " + idPoliza + " del cliente " + nombre + ",  " + apellidos +  " lleva pagado " + totalPagado + " € y aun debe un importe de " + deboPagar + " €";
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

        // Preparo interfaz para el cliente.
        private void prepararInterfazUsuario()
        {   // El cliente no podra crear polizas.
            pbCrearPoliza.Visible = false;
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


        private void limpiarDgvPagos()
        {
            dgvPagos.DataSource = null;
            lbPago.Text = "";
        }

        // Estado de las polizas por colores, cambia el color de fondo de la fila segun su estado.
        private void CambiarColorFilas()
        {
            GestorInterfaz.CambiarColorFilas(dgvPolizas);
        }


        private void UC_CurdPolizas_Load(object sender, EventArgs e)
        {
            CambiarColorFilas();
        }

        // Muestra botones de accion
        private void mostrarBotonesAccion()
        {
            pbEditarPoliza.Visible = true;
            pbEliminarPoliza.Visible = true;
        }


        // Realiza el pago 
        private void pbPagar_Click(object sender, EventArgs e)
        {
            // Obtengo la cantidad a pagar
            int pago = int.Parse(tbPago.Text.ToString());

            // Si lo que ha pagado es menor que lo que debo
            if (pago <= deboPagar)
            {
                // Si el pago se ha podigo guardar en la base de datos
                if (AdminModel.registrarPagoPoliza(pago, idPoliza) == 1)
                {
                    lbMensaje.Text = "El pago se ha realizado con exito";


                }
            }
            else
            {
                error.SetError(tbPago, "La cantidad introducida es mayor que lo que debe");
            }




        }

    }


}
