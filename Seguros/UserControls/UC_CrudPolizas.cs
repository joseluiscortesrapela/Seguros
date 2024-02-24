﻿using Seguros.Helper;
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
    public partial class UC_CrudPolizas : UserControl
    {
        private int idPoliza;
        private DataGridViewRow filaPoliza;
        private bool estado;

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

        // Obtengo la poliza que ha sido seleccionada
        private void dgvPolizas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obtengo la fila que ha sido seleccionada en el dataGridView
            if (e.RowIndex >= 0)
            {   // Obtengo la que ha sido seleccionada en el dgv
                filaPoliza = dgvPolizas.Rows[e.RowIndex];
                // Obtengo el id del usuario.
                idPoliza = int.Parse(filaPoliza.Cells["idPoliza"].Value.ToString());
                // Muestro botones de accion
                mostrarBotonesAccion();

                // si se ha habilitado
                if (estado)
                {
                    // Obtengo los pagos de la poliza
                    DataTable tablaPagos = AdminModel.getPagosByPoliza(idPoliza);

                    // Compruebo que no este vacio
                    if (tablaPagos.Rows.Count >= 1)
                    {
                        // Muestro mensaje
                        lbPago.Text = "Pagos asociados a la poliza " + idPoliza;
                        // Muestro las polizas del clietne en el dgv
                        dgvPagos.DataSource = tablaPagos;
                    }
                    
                }
            }

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

        private void pbOn_Click(object sender, EventArgs e)
        {
            estado = true;
            pbOn.Visible = false;
            pbOff.Visible = true;
            lbMensajeEstado.Text = "Acabas de activar el enlazado de datos dinamico, ahora seleccione una poliza";
            Console.WriteLine("On mostrar pagos");
        }

        private void pbOff_Click(object sender, EventArgs e)
        {
            estado = false;
            pbOn.Visible = true;
            pbOff.Visible = false;
            dgvPolizas.DataSource = null;
            lbMensajeEstado.Text = "Acabas de deshabilitar el enlazado de datos dinamico";
            Console.WriteLine("off no muestra pagos");
        }
    }
}
