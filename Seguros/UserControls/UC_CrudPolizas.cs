using Seguros.Entidades;
using Seguros.Helper;
using Seguros.Models;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Seguros.UserControls
{
    public partial class UC_CrudPolizas : UserControl
    {
        private Poliza polizaSeleccinada;
        private int idPoliza;
        private DataGridViewRow filaPoliza;
        private int importe, totalPagado, deboPagar;

        // Constructor
        public UC_CrudPolizas()
        {
            InitializeComponent();
            // Obtengo todas las polizas y las muestro en el dgv
            cargarPolizasDGV();
        }

        // Sobrecarga del constructor, recibe el id del cliente
        public UC_CrudPolizas(int idCliente)
        {
            InitializeComponent();
            // Obtengo solo las polizas del cliente y las muestro en el dgv
            dgvPolizas.DataSource = AdminModel.getPolizasByClientID(idCliente);
        }

        // Autoload ventana polizas
        private void UC_CrudPolizas_Load(object sender, EventArgs e)
        {   // Cambia color filas del dgv de polizas segun su estado
            CambiarColorFilas();
        }

        // Obtengo la poliza que ha sido seleccionada en el dgv de polizas.
        private void dgvPolizas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obtengo la fila que ha sido seleccionada en el dataGridView
            if (e.RowIndex >= 0)
            {
                // Obtengo la que ha sido seleccionada en el dgv
                filaPoliza = dgvPolizas.Rows[e.RowIndex];
                // Obtengo el id del usuario.
                idPoliza = int.Parse(filaPoliza.Cells["idPoliza"].Value.ToString());
                // Obtengo estado 
                string estado = filaPoliza.Cells["estado"].Value.ToString();
                // Obtengo el importe 
                importe = int.Parse(filaPoliza.Cells["importe"].Value.ToString());
                // Fecha de la poliza
                DateTime fechaPôliza = DateTime.Parse(filaPoliza.Cells["fecha"].Value.ToString());
                // Tipo de poliza
                string tipo = filaPoliza.Cells["tipo"].Value.ToString();
                // Obtengo el comentario
                string observaciones = filaPoliza.Cells["observaciones"].Value.ToString();
                // Obtengo el id del cliente de esta poliza.
                int idCliente = int.Parse(filaPoliza.Cells["idCliente"].Value.ToString());

                // Encapsulo los datos de la poliza en un objeto tipo Poliza
                polizaSeleccinada = new Poliza(idPoliza, importe, tipo, estado, fechaPôliza, observaciones, idCliente);

                // Obtengo el cliente de la poliza.
                DataTable clienteData = AdminModel.getClienteById(idCliente);
                // Obtengo el nobmre
                string nombre = clienteData.Rows[0]["nombre"].ToString();
                // Obtengo los apellidos
                string apellidos = clienteData.Rows[0]["apellidos"].ToString();

                // Obtengo los pagos de la poliza seleccionada
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

        // Muestra el panel que contiene el formulario para crear una nueva poliza.
        private void pbMostrarFormularioCrearPoliza_Click(object sender, EventArgs e)
        {
            // Muestro formulario para crear una poliza.
            mostrarFormulario("CrearPoliza");
            // Cargo la lista de clientes en el select
            cargarSelectConLosClientes(cbClientes);
        }


        // Muestra el panel que contiene el formulario para editar una nueva poliza.
        private void pbMostrarFormularioEditarPoliza_Click(object sender, EventArgs e)
        {
            // Muestro formulario para editar una poliza
            mostrarFormulario("EditarPoliza");

            // Cargo la lista de clientes en el select
            cargarSelectConLosClientes(cbClientesEditar);
            lbIdPolizaEditar.Text = polizaSeleccinada.Id.ToString();
            tbImporteEditar.Text = polizaSeleccinada.Importe.ToString();
            cbTipoEditar.Text = polizaSeleccinada.Tipo;
            cbEstadosEditar.Text = polizaSeleccinada.Estado;
            //cbClientesEditar.SelectedIndex = 8;
            tbObservacionesEdiitar.Text = polizaSeleccinada.Observaciones;
            dtpFechaEditar.Value = polizaSeleccinada.Fecha;

            Console.WriteLine("Muestro formulario editar poliza: ");
        }

        // Añade los clietnes al select
        private void cargarSelectConLosClientes(System.Windows.Forms.ComboBox select)
        {
            // Obtengo los clientes y los guardo en select
            select.DisplayMember = "nombre";
            select.ValueMember = "idCliente";
            select.DataSource = AdminModel.getClientes();
        }

        // Muestra el panel y formulario que necesite
        private void mostrarFormulario(string formulario)
        {
            if (formulario == "CrearPoliza")
            {
                panelCrudPolizas.Visible = false;
                panelEditarPoliza.Visible = false;
                panelCrearPoliza.Visible = true;
            }
            else if (formulario == "EditarPoliza")
            {
                panelCrearPoliza.Visible = false;
                panelCrudPolizas.Visible = false;
                panelEditarPoliza.Visible = true;
            }

        }

        // Eliminar poliza
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
            pbMostrarFormularioEditarPoliza.Visible = true;
            pbEliminarPoliza.Visible = true;
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
                        lbMensajeCrearPoliza.Text = "Acabas de pagar el importe total de tu poliza";
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
                    lbMensajeCrearPoliza.Text = "El pago se ha realizado con exito";
                }
            }
            else
            {   // Cantidad ingresada mayor de lo que debe.
                error.SetError(tbPago, "La cantidad introducida es mayor que lo que debe");
            }

        }

        private void btnCrearPoliza_Click(object sender, EventArgs e)
        {

            // Obtengo datos del formulario
            int importe = int.Parse(tbImporte.Text.ToString());
            string tipo = cbTipo.Text.ToString();
            string estado = cbEstados.Text.ToString();
            int idCliente = int.Parse(cbClientes.SelectedValue.ToString());
            DateTime fecha = dtpFecha.Value;
            string observaciones = tbObservaciones.Text.ToString();

            // Encapsulo los datos en un objeto del tipo Poliza.
            Poliza poliza = new Poliza(importe, tipo, estado, fecha, observaciones, idCliente);

            // Si la poliza se ha registrado correctamente en la base de datos.
            if (AdminModel.registrarPoliza(poliza))
            {
                // Limpio el formulario
                limpiarFormularioCrearPoliza();
                // Muestro mensaje
                lbMensajeCrearPoliza.Text = "Acabas de crear una nueva poliza";
            }

            Console.WriteLine("Crear poliza: importe: " + importe + " tipo: " + tipo + " estado: " + estado + "idCliente: " + idCliente + " fecha " + fecha + " obsevaciones: " + observaciones);

        }

        // Limpia contendio del fomulario para crear una poliza
        private void limpiarFormularioCrearPoliza()
        {
            tbImporte.Text = "0";
            cbTipo.Text = "tipo";
            cbEstados.Text = "Selecciona estado";
            cbClientes.Text = "Selecciona cliente";
            dtpFecha.Text = "";
            lbMensajeCrearPoliza.Text = "";
        }

        private void btnEditarPoliza_Click(object sender, EventArgs e)
        {
            // Obtengo el id de la poliza que fue seleccionada
            int idPoliza = polizaSeleccinada.Id;
            // Obtengo valores formulario editar poliza
            int importe = int.Parse(tbImporteEditar.Text.ToString());
            string tipo = cbTipoEditar.Text.ToString();
            string estado = cbEstadosEditar.Text.ToString();
            int idCliente = int.Parse(cbClientesEditar.SelectedValue.ToString());
            DateTime fecha = dtpFechaEditar.Value;
            string observaciones = tbObservacionesEdiitar.Text.ToString();

            // Encapsulo los datos en un objeto del tipo Poliza.
            Poliza poliza = new Poliza(idPoliza, importe, tipo, estado, fecha, observaciones, idCliente);

            // Si ha actualizado la poliza en la basde de datos
            if (AdminModel.editarPoliza(poliza))
            {
                // Muestro mensaje
                lbMensajeEdtiarPoliza.Text = "Acaba de actualizar la poliza";
            }


            /*
            // Si la poliza se ha registrado correctamente en la base de datos.
            if (AdminModel.registrarPoliza(poliza))
            {   // Muestro mensaje
                lbMenasjeCrearPoliza.Text = "Acabas de crear una nueva poliza";
            }
            */
            Console.WriteLine("Editar poliza: idPoliza: " + poliza.Id + " importe: " + importe + " tipo: " + tipo + " estado: " + estado +
                "idCliente: " + idCliente + " fecha " + fecha + " observaciones: " + observaciones);

        }

        // Cambia el color de las polizas segun su estado.
        private void CambiarColorFilas()
        {
            GestorInterfaz.CambiarColorFilas(dgvPolizas);
        }

        private void cbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtengo el indice de la provincia
            int idCliente = Convert.ToInt32(cbClientes.SelectedValue);
            Console.WriteLine("Cliente " + idCliente + "  seleccionado añadir a la poliza");
        }

        // Limpia mensaje placeholder de los campos del formulario una vez que haces click sobre uno
        private void limpiarPlaceholder(object sender, EventArgs e)
        {
            // Limpia el texto del TextBox que desencadenó el evento
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;
            if (textBox != null)
            {
                textBox.Text = string.Empty;
            }

        }

        // Carga el dgv con las polizas y las muestra de colores
        private void cargarPolizasDGV()
        {
            // Obtengo todas las polizas y las muestro en el dgv
            dgvPolizas.DataSource = AdminModel.getPolizas();
            // Cambio color polizas segun su estado
            cambiarColorPolizas();
        }

        private void pbMostraFormularioDetallePoliza_Click(object sender, EventArgs e)
        {

        }

        // Vuelve al crud principal de polizas, contenedor principal
        private void btnVolver_Click(object sender, EventArgs e)
        {
            // Oculto los paneles  para editar y crear polizas.
            panelCrearPoliza.Visible = false;
            panelEditarPoliza.Visible = false;
            // Actualizo, me traigo todas las polizas de la base de datos.
            cargarPolizasDGV();
            // Muestro el contenedor 
            panelCrudPolizas.Visible = true;
        }

        // Cierro la aplicacion
        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }


}
