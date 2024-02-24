namespace Seguros.UserControls
{
    partial class UC_CrudAgentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_CrudAgentes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbMensaje = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbEditar = new System.Windows.Forms.PictureBox();
            this.pbEliminar = new System.Windows.Forms.PictureBox();
            this.pbCrear = new System.Windows.Forms.PictureBox();
            this.dgvAgentes = new System.Windows.Forms.DataGridView();
            this.pbOn = new System.Windows.Forms.PictureBox();
            this.panelCarteraClientes = new System.Windows.Forms.Panel();
            this.lbNombreCliente = new System.Windows.Forms.Label();
            this.dgvPolizas = new System.Windows.Forms.DataGridView();
            this.lbNombreAgente = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.pbOff = new System.Windows.Forms.PictureBox();
            this.lbMensajeEstado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOn)).BeginInit();
            this.panelCarteraClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolizas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOff)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMensaje
            // 
            this.lbMensaje.AutoSize = true;
            this.lbMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensaje.Location = new System.Drawing.Point(484, 438);
            this.lbMensaje.Name = "lbMensaje";
            this.lbMensaje.Size = new System.Drawing.Size(0, 17);
            this.lbMensaje.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Agentes";
            // 
            // pbEditar
            // 
            this.pbEditar.Image = ((System.Drawing.Image)(resources.GetObject("pbEditar.Image")));
            this.pbEditar.Location = new System.Drawing.Point(1091, 83);
            this.pbEditar.Name = "pbEditar";
            this.pbEditar.Size = new System.Drawing.Size(34, 38);
            this.pbEditar.TabIndex = 17;
            this.pbEditar.TabStop = false;
            this.pbEditar.Visible = false;
            this.pbEditar.Click += new System.EventHandler(this.pbEditar_Click);
            // 
            // pbEliminar
            // 
            this.pbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("pbEliminar.Image")));
            this.pbEliminar.Location = new System.Drawing.Point(1091, 127);
            this.pbEliminar.Name = "pbEliminar";
            this.pbEliminar.Size = new System.Drawing.Size(34, 36);
            this.pbEliminar.TabIndex = 16;
            this.pbEliminar.TabStop = false;
            this.pbEliminar.Visible = false;
            this.pbEliminar.Click += new System.EventHandler(this.pbEliminar_Click);
            // 
            // pbCrear
            // 
            this.pbCrear.Image = ((System.Drawing.Image)(resources.GetObject("pbCrear.Image")));
            this.pbCrear.Location = new System.Drawing.Point(1091, 42);
            this.pbCrear.Name = "pbCrear";
            this.pbCrear.Size = new System.Drawing.Size(35, 35);
            this.pbCrear.TabIndex = 15;
            this.pbCrear.TabStop = false;
            this.pbCrear.Click += new System.EventHandler(this.pbCrear_Click);
            // 
            // dgvAgentes
            // 
            this.dgvAgentes.AllowUserToAddRows = false;
            this.dgvAgentes.AllowUserToDeleteRows = false;
            this.dgvAgentes.AllowUserToOrderColumns = true;
            this.dgvAgentes.AllowUserToResizeColumns = false;
            this.dgvAgentes.AllowUserToResizeRows = false;
            this.dgvAgentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAgentes.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvAgentes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAgentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgentes.Location = new System.Drawing.Point(38, 42);
            this.dgvAgentes.Name = "dgvAgentes";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAgentes.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAgentes.Size = new System.Drawing.Size(1047, 133);
            this.dgvAgentes.TabIndex = 14;
            this.dgvAgentes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgentes_CellClick);
            // 
            // pbOn
            // 
            this.pbOn.Image = ((System.Drawing.Image)(resources.GetObject("pbOn.Image")));
            this.pbOn.Location = new System.Drawing.Point(645, 16);
            this.pbOn.Name = "pbOn";
            this.pbOn.Size = new System.Drawing.Size(48, 23);
            this.pbOn.TabIndex = 20;
            this.pbOn.TabStop = false;
            this.pbOn.Click += new System.EventHandler(this.pbMostrarCarterClientes_Click);
            // 
            // panelCarteraClientes
            // 
            this.panelCarteraClientes.BackColor = System.Drawing.Color.Snow;
            this.panelCarteraClientes.Controls.Add(this.lbNombreCliente);
            this.panelCarteraClientes.Controls.Add(this.dgvPolizas);
            this.panelCarteraClientes.Controls.Add(this.lbNombreAgente);
            this.panelCarteraClientes.Controls.Add(this.dgvClientes);
            this.panelCarteraClientes.Location = new System.Drawing.Point(3, 204);
            this.panelCarteraClientes.Name = "panelCarteraClientes";
            this.panelCarteraClientes.Size = new System.Drawing.Size(1121, 411);
            this.panelCarteraClientes.TabIndex = 22;
            this.panelCarteraClientes.Visible = false;
            // 
            // lbNombreCliente
            // 
            this.lbNombreCliente.AutoSize = true;
            this.lbNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreCliente.Location = new System.Drawing.Point(32, 226);
            this.lbNombreCliente.Name = "lbNombreCliente";
            this.lbNombreCliente.Size = new System.Drawing.Size(0, 17);
            this.lbNombreCliente.TabIndex = 27;
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
            this.dgvPolizas.Location = new System.Drawing.Point(35, 246);
            this.dgvPolizas.Name = "dgvPolizas";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPolizas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPolizas.Size = new System.Drawing.Size(1047, 165);
            this.dgvPolizas.TabIndex = 25;
            // 
            // lbNombreAgente
            // 
            this.lbNombreAgente.AutoSize = true;
            this.lbNombreAgente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreAgente.Location = new System.Drawing.Point(32, 2);
            this.lbNombreAgente.Name = "lbNombreAgente";
            this.lbNombreAgente.Size = new System.Drawing.Size(0, 17);
            this.lbNombreAgente.TabIndex = 24;
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
            this.dgvClientes.Location = new System.Drawing.Point(35, 22);
            this.dgvClientes.Name = "dgvClientes";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClientes.Size = new System.Drawing.Size(1047, 195);
            this.dgvClientes.TabIndex = 23;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(444, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Mostrar clientes y polizas";
            // 
            // pbOff
            // 
            this.pbOff.Image = ((System.Drawing.Image)(resources.GetObject("pbOff.Image")));
            this.pbOff.Location = new System.Drawing.Point(645, 14);
            this.pbOff.Name = "pbOff";
            this.pbOff.Size = new System.Drawing.Size(39, 23);
            this.pbOff.TabIndex = 21;
            this.pbOff.TabStop = false;
            this.pbOff.Click += new System.EventHandler(this.pbOcultarCarteraClientes_Click);
            // 
            // lbMensajeEstado
            // 
            this.lbMensajeEstado.AutoSize = true;
            this.lbMensajeEstado.BackColor = System.Drawing.Color.Snow;
            this.lbMensajeEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensajeEstado.ForeColor = System.Drawing.Color.DarkGray;
            this.lbMensajeEstado.Location = new System.Drawing.Point(431, 184);
            this.lbMensajeEstado.Name = "lbMensajeEstado";
            this.lbMensajeEstado.Size = new System.Drawing.Size(271, 17);
            this.lbMensajeEstado.TabIndex = 28;
            this.lbMensajeEstado.Text = "Desactivado enlazado de datos dinamico.";
            // 
            // UC_CrudAgentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.Controls.Add(this.lbMensajeEstado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelCarteraClientes);
            this.Controls.Add(this.pbOn);
            this.Controls.Add(this.lbMensaje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbEditar);
            this.Controls.Add(this.pbEliminar);
            this.Controls.Add(this.pbCrear);
            this.Controls.Add(this.dgvAgentes);
            this.Controls.Add(this.pbOff);
            this.Name = "UC_CrudAgentes";
            this.Size = new System.Drawing.Size(1127, 618);
            ((System.ComponentModel.ISupportInitialize)(this.pbEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOn)).EndInit();
            this.panelCarteraClientes.ResumeLayout(false);
            this.panelCarteraClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolizas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMensaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbEditar;
        private System.Windows.Forms.PictureBox pbEliminar;
        private System.Windows.Forms.PictureBox pbCrear;
        private System.Windows.Forms.DataGridView dgvAgentes;
        private System.Windows.Forms.PictureBox pbOn;
        private System.Windows.Forms.Panel panelCarteraClientes;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridView dgvPolizas;
        private System.Windows.Forms.Label lbNombreAgente;
        private System.Windows.Forms.Label lbNombreCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbOff;
        private System.Windows.Forms.Label lbMensajeEstado;
    }
}
