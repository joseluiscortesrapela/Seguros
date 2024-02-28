using Seguros.Entidades;
using Seguros.Helper;
using Seguros.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace Seguros.UserControls
{
    public partial class UC_CrudClientes : UserControl
    {
        private DataGridViewRow filaCliente;
        private Cliente cliente;
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
                // Obtengo los apellidos
                string apellidos = filaCliente.Cells["apellidos"].Value.ToString();
                // Obtengo el dni
                string dni = filaCliente.Cells["dni"].Value.ToString();
                // Obtengo el telefono
                string telefono = filaCliente.Cells["telefono"].Value.ToString();
                // Obtengo el correo 
                string correo = filaCliente.Cells["correo"].Value.ToString();
                // Obtengo la contraseña 
                string contraseña = filaCliente.Cells["contraseña"].Value.ToString();
                // Obtengo el id de la provincia
                int idProvincia = int.Parse(filaCliente.Cells["provincia"].Value.ToString());
                // Obtengo el id del municipio
                int idMunicipio = int.Parse(filaCliente.Cells["municipio"].Value.ToString());
                // Obtengo el tipo 
                string tipo = filaCliente.Cells["tipo"].Value.ToString();

                // Instancio e inicializo un nuevo objeto de tipo Cliente
                cliente = new Cliente(nombre, apellidos, dni, telefono, correo, contraseña, idProvincia, idMunicipio, tipo);
               
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


        // Muestra formulario para crear un nuevo cliente.
        private void pbMostrarPanelCrear_Click(object sender, EventArgs e)
        {
            // Oculto los paneles
            panelCrudClientes.Visible = false;
            panelEditar.Visible = false;
            panelDetalle.Visible = false;

            // Obtengo las provincias y las cargo en el combobox
            cbProvinciasCrear.DisplayMember = "provincia";
            cbProvinciasCrear.ValueMember = "id";
            cbProvinciasCrear.DataSource = AdminModel.getProvincias();

            // Muestro el pandel con el formulario
            panelCrear.Visible = true;

            Console.WriteLine("Muestro panel Crear cliente");
        }

        // Muestra formulario con los datos del cliente
        private void pbMostrarPanelDetalle_Click(object sender, EventArgs e)
        {
            // Oculto paneles
            panelCrudClientes.Visible = false;
            panelCrear.Visible = false;
            panelEditar.Visible = false;

            // Cargo el formulario con los datos del cliente
            tbNombreDetalle.Text = cliente.Nombre;
            tbApellidosDetalle.Text = cliente.Apellidos;
            tbDniDetalle.Text = cliente.Dni;
            tbTelefonoDetalle.Text = cliente.Telefono; 
            tbCorreoDetalle.Text = cliente.Correo;
            tbContraseñaDetalle.Text = cliente.Contraseña;
            cbTipoDetalle.Text = cliente.Tipo;
            // Obtengo de la base de datos el nombre de la provincia y lo guardo en el campo de texto
            tbProvincia.Text = AdminModel.getNombresProvincia( cliente.IdProvincia );
            // Obtengo de la base de datos el nombre del municipio y lo guardo en el campo de texto
            tbMunicipio.Text = AdminModel.getNombresMunicipio(cliente.IdMuncipio );

            // Muestro el panel que contiene el formulario
            panelDetalle.Visible = true;

            Console.WriteLine("Muestro panel detalle cliente");

        }

        // Muestra formulario para editar cliente
        private void pbMostrarPanelEditar_Click(object sender, EventArgs e)
        {
            panelCrudClientes.Visible = false;
            panelCrear.Visible = false;
            panelDetalle.Visible = false;


            tbNombreEditar.Text = "Serena";
            tbApellidosEditar.Text = "Agina";
            tbTelefonoEditar.Text = "555665544";
            tbDniEditar.Text = "7856677T";
            tbCorreoEditar.Text = "serena@hotmail.com";



            panelEditar.Visible = true;



            Console.WriteLine("Muestro panel para Editar cliente");
        }

        // Muestra ventan emergente para eliminar cliente
        private void pbEliminar_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Eliminar cliente");
        }

        private void limpiarDgvPolizas()
        {
            dgvPolizas.DataSource = null;
            lbNombreCliente.Text = "";
        }

        // Muestra botones de accion ver, editar y elimianr
        private void mostrarBotonesAccion()
        {
            pbDetalle.Visible = true;
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

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        // Lipia el place holder de los campos del formualario
        private void limpiarPlaceholder(object sender, EventArgs e)
        {
            // Limpia el texto del TextBox que desencadenó el evento
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                textBox.Text = string.Empty;
            }
        }

        // Vuelve al crud de clientes
        private void btnVolver_Click(object sender, EventArgs e)
        {
            panelEditar.Visible = false;
            panelCrear.Visible = false;
            panelDetalle.Visible = false;
            panelCrudClientes.Visible = true;
        }

        // Creo un nuevo cliente
        private void btnCrear_Click(object sender, EventArgs e)
        {
            // Recoje los datos del formulario
            string nombre = tbNombreCrear.Text;
            string apellidos = tbApellidosCrear.Text;
            string dni = tbDniCrear.Text;
            string telefono = tbTelefonoCrear.Text;
            string correo = tbCorreoCrear.Text;
            string contraseña = tbContraseñaCrear.Text;
            int idProvincia = int.Parse(cbProvinciasCrear.SelectedValue.ToString());
            int idMunicipio = int.Parse(cbMunicipiosCrear.SelectedValue.ToString());
            string tipo = cbTipoCrear.Text;

            Console.WriteLine("Crear cliente  nombre " + nombre + " apellidos: " + apellidos
                + " dni: " + dni + " telefono: " + telefono + " correo:" + correo + " contraseña: " + contraseña +
                " id provincia: " + idProvincia + " id municipio: " + idMunicipio + " tipo: " + tipo);

            // Instancio e inicializo un nuevo objeto de tipo Cliente
            Cliente cliente = new Cliente(nombre, apellidos, dni, telefono, correo, contraseña, idProvincia, idMunicipio, tipo);
            
            // Si consigie guardar al cliente en la base de datos
            if( AdminModel.registrarCliente(cliente) == 1 )
            {   // Muestro mensaje
                lbMensajeCrear.Text = "Acabas de crear un nuevo cliente";
            }
            else
            {   // En caso de error, muestro este mensaje
                lbMensajeCrear.Text = "Error al crear un nuevo cliente";
            }

        }

        // El usuario ha seleccionado una provinca desde el formulario crar nuevo cliente.
        private void cbProvinciasCrear_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idProvincia = Convert.ToInt32(cbProvinciasCrear.SelectedValue);
            CargarMunicipios(idProvincia, cbMunicipiosCrear);
        }

        // Carga las provincias en el combbox que le indiquemos
        private void CargarMunicipios(int idProvincia, ComboBox cbMunicipios)
        {
            // Obtener los municipios correspondientes al ID de la provincia seleccionada
            DataTable municipios = AdminModel.getMunicipiosPorProvincia(idProvincia);

            // Asignar los municipios al ComboBox cbMunicipios
            cbMunicipios.DataSource = municipios;
            cbMunicipios.DisplayMember = "municipio"; // Suponiendo que el nombre de los municipios está en una columna llamada "nombre"
            cbMunicipios.ValueMember = "id"; // Suponiendo que el ID de los municipios está en una columna llamada "id"
        }



    }




}
