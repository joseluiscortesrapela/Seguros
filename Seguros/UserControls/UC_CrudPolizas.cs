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
        private int idCliente, idPoliza;
        private DataGridViewRow filaPoliza;

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
            // Guardo el id
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
            pbEditar.Visible = true;
            pbEliminar.Visible = true;
        }

    }
}
