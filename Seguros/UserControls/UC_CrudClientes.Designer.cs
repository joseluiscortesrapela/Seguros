﻿namespace Seguros.UserControls
{
    partial class UC_CrudClientes
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_CrudClientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.pbEditar = new System.Windows.Forms.PictureBox();
            this.pbEliminar = new System.Windows.Forms.PictureBox();
            this.pbCrear = new System.Windows.Forms.PictureBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.dgvPolizas = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.pbOn = new System.Windows.Forms.PictureBox();
            this.pbOff = new System.Windows.Forms.PictureBox();
            this.lbNombreCliente = new System.Windows.Forms.Label();
            this.lbMensajeEstado = new System.Windows.Forms.Label();
            this.panelFlSuperior = new System.Windows.Forms.FlowLayoutPanel();
            this.panelNavegacionSuperior = new System.Windows.Forms.Panel();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.panelBuscador = new System.Windows.Forms.Panel();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.pbBuscador = new System.Windows.Forms.PictureBox();
            this.pbMostrarBuscador = new System.Windows.Forms.PictureBox();
            this.pbInicio = new System.Windows.Forms.PictureBox();
            this.panelCrud = new System.Windows.Forms.Panel();
            this.panelDetalle = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panelEditar = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelCrear = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pbDetalle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolizas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOff)).BeginInit();
            this.panelFlSuperior.SuspendLayout();
            this.panelNavegacionSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.panelBuscador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarBuscador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInicio)).BeginInit();
            this.panelCrud.SuspendLayout();
            this.panelDetalle.SuspendLayout();
            this.panelEditar.SuspendLayout();
            this.panelCrear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Clientes";
            // 
            // pbEditar
            // 
            this.pbEditar.Image = ((System.Drawing.Image)(resources.GetObject("pbEditar.Image")));
            this.pbEditar.Location = new System.Drawing.Point(1090, 100);
            this.pbEditar.Name = "pbEditar";
            this.pbEditar.Size = new System.Drawing.Size(34, 38);
            this.pbEditar.TabIndex = 11;
            this.pbEditar.TabStop = false;
            this.pbEditar.Click += new System.EventHandler(this.pbEditar_Click);
            // 
            // pbEliminar
            // 
            this.pbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("pbEliminar.Image")));
            this.pbEliminar.Location = new System.Drawing.Point(1090, 144);
            this.pbEliminar.Name = "pbEliminar";
            this.pbEliminar.Size = new System.Drawing.Size(34, 36);
            this.pbEliminar.TabIndex = 10;
            this.pbEliminar.TabStop = false;
            this.pbEliminar.Click += new System.EventHandler(this.pbEliminar_Click);
            // 
            // pbCrear
            // 
            this.pbCrear.Image = ((System.Drawing.Image)(resources.GetObject("pbCrear.Image")));
            this.pbCrear.Location = new System.Drawing.Point(1090, 18);
            this.pbCrear.Name = "pbCrear";
            this.pbCrear.Size = new System.Drawing.Size(34, 35);
            this.pbCrear.TabIndex = 9;
            this.pbCrear.TabStop = false;
            this.pbCrear.Click += new System.EventHandler(this.pbCrear_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToOrderColumns = true;
            this.dgvClientes.AllowUserToResizeColumns = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(36, 18);
            this.dgvClientes.Name = "dgvClientes";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientes.Size = new System.Drawing.Size(1049, 291);
            this.dgvClientes.TabIndex = 8;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            // 
            // dgvPolizas
            // 
            this.dgvPolizas.AllowUserToAddRows = false;
            this.dgvPolizas.AllowUserToDeleteRows = false;
            this.dgvPolizas.AllowUserToOrderColumns = true;
            this.dgvPolizas.AllowUserToResizeColumns = false;
            this.dgvPolizas.AllowUserToResizeRows = false;
            this.dgvPolizas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPolizas.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvPolizas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPolizas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPolizas.Location = new System.Drawing.Point(36, 361);
            this.dgvPolizas.Name = "dgvPolizas";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPolizas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPolizas.Size = new System.Drawing.Size(1049, 217);
            this.dgvPolizas.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(431, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Mostrar polizas clientes";
            // 
            // pbOn
            // 
            this.pbOn.Image = ((System.Drawing.Image)(resources.GetObject("pbOn.Image")));
            this.pbOn.Location = new System.Drawing.Point(617, -10);
            this.pbOn.Name = "pbOn";
            this.pbOn.Size = new System.Drawing.Size(70, 27);
            this.pbOn.TabIndex = 27;
            this.pbOn.TabStop = false;
            this.pbOn.Click += new System.EventHandler(this.pbMostrarPolizasCliente_Click);
            // 
            // pbOff
            // 
            this.pbOff.Image = ((System.Drawing.Image)(resources.GetObject("pbOff.Image")));
            this.pbOff.Location = new System.Drawing.Point(617, -10);
            this.pbOff.Name = "pbOff";
            this.pbOff.Size = new System.Drawing.Size(39, 23);
            this.pbOff.TabIndex = 28;
            this.pbOff.TabStop = false;
            this.pbOff.Click += new System.EventHandler(this.pbOcultarPolizasCliente_Click);
            // 
            // lbNombreCliente
            // 
            this.lbNombreCliente.AutoSize = true;
            this.lbNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreCliente.Location = new System.Drawing.Point(21, 469);
            this.lbNombreCliente.Name = "lbNombreCliente";
            this.lbNombreCliente.Size = new System.Drawing.Size(0, 17);
            this.lbNombreCliente.TabIndex = 30;
            // 
            // lbMensajeEstado
            // 
            this.lbMensajeEstado.AutoSize = true;
            this.lbMensajeEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensajeEstado.ForeColor = System.Drawing.Color.DarkGray;
            this.lbMensajeEstado.Location = new System.Drawing.Point(412, 315);
            this.lbMensajeEstado.Name = "lbMensajeEstado";
            this.lbMensajeEstado.Size = new System.Drawing.Size(260, 17);
            this.lbMensajeEstado.TabIndex = 31;
            this.lbMensajeEstado.Text = "Deactivado enlazado de datos dinamico";
            // 
            // panelFlSuperior
            // 
            this.panelFlSuperior.BackColor = System.Drawing.Color.Snow;
            this.panelFlSuperior.Controls.Add(this.panelNavegacionSuperior);
            this.panelFlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFlSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelFlSuperior.Name = "panelFlSuperior";
            this.panelFlSuperior.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panelFlSuperior.Size = new System.Drawing.Size(1127, 55);
            this.panelFlSuperior.TabIndex = 32;
            // 
            // panelNavegacionSuperior
            // 
            this.panelNavegacionSuperior.BackColor = System.Drawing.Color.Snow;
            this.panelNavegacionSuperior.Controls.Add(this.pbExit);
            this.panelNavegacionSuperior.Controls.Add(this.panelBuscador);
            this.panelNavegacionSuperior.Controls.Add(this.pbMostrarBuscador);
            this.panelNavegacionSuperior.Controls.Add(this.pbInicio);
            this.panelNavegacionSuperior.Location = new System.Drawing.Point(13, 3);
            this.panelNavegacionSuperior.Name = "panelNavegacionSuperior";
            this.panelNavegacionSuperior.Size = new System.Drawing.Size(1114, 52);
            this.panelNavegacionSuperior.TabIndex = 5;
            // 
            // pbExit
            // 
            this.pbExit.Image = ((System.Drawing.Image)(resources.GetObject("pbExit.Image")));
            this.pbExit.Location = new System.Drawing.Point(1090, 3);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(21, 21);
            this.pbExit.TabIndex = 7;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // panelBuscador
            // 
            this.panelBuscador.BackColor = System.Drawing.Color.Transparent;
            this.panelBuscador.Controls.Add(this.tbBuscar);
            this.panelBuscador.Controls.Add(this.pbBuscador);
            this.panelBuscador.Location = new System.Drawing.Point(325, 5);
            this.panelBuscador.Name = "panelBuscador";
            this.panelBuscador.Size = new System.Drawing.Size(431, 47);
            this.panelBuscador.TabIndex = 6;
            this.panelBuscador.Visible = false;
            // 
            // tbBuscar
            // 
            this.tbBuscar.BackColor = System.Drawing.Color.Snow;
            this.tbBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuscar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbBuscar.Location = new System.Drawing.Point(76, 14);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(248, 19);
            this.tbBuscar.TabIndex = 3;
            this.tbBuscar.Text = "Buscar clientes...";
            this.tbBuscar.Click += new System.EventHandler(this.limpiaPlaceholderBuscador);
            this.tbBuscar.TextChanged += new System.EventHandler(this.buscarClientes);
            // 
            // pbBuscador
            // 
            this.pbBuscador.Image = ((System.Drawing.Image)(resources.GetObject("pbBuscador.Image")));
            this.pbBuscador.Location = new System.Drawing.Point(10, 5);
            this.pbBuscador.Margin = new System.Windows.Forms.Padding(0);
            this.pbBuscador.Name = "pbBuscador";
            this.pbBuscador.Size = new System.Drawing.Size(409, 39);
            this.pbBuscador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbBuscador.TabIndex = 2;
            this.pbBuscador.TabStop = false;
            // 
            // pbMostrarBuscador
            // 
            this.pbMostrarBuscador.Image = ((System.Drawing.Image)(resources.GetObject("pbMostrarBuscador.Image")));
            this.pbMostrarBuscador.Location = new System.Drawing.Point(1018, 15);
            this.pbMostrarBuscador.Name = "pbMostrarBuscador";
            this.pbMostrarBuscador.Size = new System.Drawing.Size(36, 37);
            this.pbMostrarBuscador.TabIndex = 4;
            this.pbMostrarBuscador.TabStop = false;
            this.pbMostrarBuscador.Click += new System.EventHandler(this.pbMostrarBuscador_Click);
            // 
            // pbInicio
            // 
            this.pbInicio.Image = global::Seguros.Properties.Resources.inicio;
            this.pbInicio.Location = new System.Drawing.Point(23, 13);
            this.pbInicio.Margin = new System.Windows.Forms.Padding(3, 3, 400, 3);
            this.pbInicio.Name = "pbInicio";
            this.pbInicio.Size = new System.Drawing.Size(41, 36);
            this.pbInicio.TabIndex = 1;
            this.pbInicio.TabStop = false;
            // 
            // panelCrud
            // 
            this.panelCrud.BackColor = System.Drawing.Color.Snow;
            this.panelCrud.Controls.Add(this.dgvClientes);
            this.panelCrud.Controls.Add(this.pbCrear);
            this.panelCrud.Controls.Add(this.lbMensajeEstado);
            this.panelCrud.Controls.Add(this.pbOn);
            this.panelCrud.Controls.Add(this.pbEliminar);
            this.panelCrud.Controls.Add(this.pbEditar);
            this.panelCrud.Controls.Add(this.label4);
            this.panelCrud.Controls.Add(this.label1);
            this.panelCrud.Controls.Add(this.dgvPolizas);
            this.panelCrud.Controls.Add(this.pbOff);
            this.panelCrud.Controls.Add(this.pbDetalle);
            this.panelCrud.Location = new System.Drawing.Point(0, 99);
            this.panelCrud.Name = "panelCrud";
            this.panelCrud.Size = new System.Drawing.Size(1127, 611);
            this.panelCrud.TabIndex = 33;
            // 
            // panelDetalle
            // 
            this.panelDetalle.BackColor = System.Drawing.Color.SlateGray;
            this.panelDetalle.Controls.Add(this.label5);
            this.panelDetalle.Location = new System.Drawing.Point(0, 81);
            this.panelDetalle.Name = "panelDetalle";
            this.panelDetalle.Size = new System.Drawing.Size(1127, 516);
            this.panelDetalle.TabIndex = 33;
            this.panelDetalle.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(457, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Detalle cliente";
            // 
            // panelEditar
            // 
            this.panelEditar.BackColor = System.Drawing.Color.SlateBlue;
            this.panelEditar.Controls.Add(this.label3);
            this.panelEditar.Location = new System.Drawing.Point(0, 84);
            this.panelEditar.Name = "panelEditar";
            this.panelEditar.Size = new System.Drawing.Size(1127, 534);
            this.panelEditar.TabIndex = 34;
            this.panelEditar.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(457, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Editar cliente";
            // 
            // panelCrear
            // 
            this.panelCrear.BackColor = System.Drawing.Color.SpringGreen;
            this.panelCrear.Controls.Add(this.label2);
            this.panelCrear.Location = new System.Drawing.Point(0, 81);
            this.panelCrear.Name = "panelCrear";
            this.panelCrear.Size = new System.Drawing.Size(1127, 537);
            this.panelCrear.TabIndex = 32;
            this.panelCrear.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(479, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Crear cliente";
            // 
            // pbDetalle
            // 
            this.pbDetalle.Image = ((System.Drawing.Image)(resources.GetObject("pbDetalle.Image")));
            this.pbDetalle.Location = new System.Drawing.Point(1090, 59);
            this.pbDetalle.Name = "pbDetalle";
            this.pbDetalle.Size = new System.Drawing.Size(34, 35);
            this.pbDetalle.TabIndex = 35;
            this.pbDetalle.TabStop = false;
            this.pbDetalle.Click += new System.EventHandler(this.pbDetalle_Click);
            // 
            // UC_CrudClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.Controls.Add(this.panelCrear);
            this.Controls.Add(this.panelEditar);
            this.Controls.Add(this.panelCrud);
            this.Controls.Add(this.panelDetalle);
            this.Controls.Add(this.panelFlSuperior);
            this.Controls.Add(this.lbNombreCliente);
            this.Name = "UC_CrudClientes";
            this.Size = new System.Drawing.Size(1127, 713);
            ((System.ComponentModel.ISupportInitialize)(this.pbEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolizas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOff)).EndInit();
            this.panelFlSuperior.ResumeLayout(false);
            this.panelNavegacionSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.panelBuscador.ResumeLayout(false);
            this.panelBuscador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarBuscador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInicio)).EndInit();
            this.panelCrud.ResumeLayout(false);
            this.panelCrud.PerformLayout();
            this.panelDetalle.ResumeLayout(false);
            this.panelDetalle.PerformLayout();
            this.panelEditar.ResumeLayout(false);
            this.panelEditar.PerformLayout();
            this.panelCrear.ResumeLayout(false);
            this.panelCrear.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbEditar;
        private System.Windows.Forms.PictureBox pbEliminar;
        private System.Windows.Forms.PictureBox pbCrear;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridView dgvPolizas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbOn;
        private System.Windows.Forms.PictureBox pbOff;
        private System.Windows.Forms.Label lbNombreCliente;
        private System.Windows.Forms.Label lbMensajeEstado;
        private System.Windows.Forms.FlowLayoutPanel panelFlSuperior;
        private System.Windows.Forms.Panel panelNavegacionSuperior;
        private System.Windows.Forms.Panel panelBuscador;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.PictureBox pbBuscador;
        private System.Windows.Forms.PictureBox pbMostrarBuscador;
        private System.Windows.Forms.PictureBox pbInicio;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.Panel panelCrud;
        private System.Windows.Forms.Panel panelCrear;
        private System.Windows.Forms.Panel panelDetalle;
        private System.Windows.Forms.Panel panelEditar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbDetalle;
    }
}
