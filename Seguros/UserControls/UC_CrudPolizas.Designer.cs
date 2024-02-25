namespace Seguros.UserControls
{
    partial class UC_CrudPolizas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_CrudPolizas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.pbCrearPoliza = new System.Windows.Forms.PictureBox();
            this.pbEliminarPoliza = new System.Windows.Forms.PictureBox();
            this.pbEditarPoliza = new System.Windows.Forms.PictureBox();
            this.dgvPolizas = new System.Windows.Forms.DataGridView();
            this.lbPago = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbOn = new System.Windows.Forms.PictureBox();
            this.pbOff = new System.Windows.Forms.PictureBox();
            this.lbMensajeEstado = new System.Windows.Forms.Label();
            this.pbMostrarPanelRealizarPago = new System.Windows.Forms.PictureBox();
            this.lbMensajePago = new System.Windows.Forms.Label();
            this.panelRealizarPago = new System.Windows.Forms.Panel();
            this.tbIngresao = new System.Windows.Forms.TextBox();
            this.dgvPagos = new System.Windows.Forms.DataGridView();
            this.lbMensaje = new System.Windows.Forms.Label();
            this.lbPagos = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrearPoliza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminarPoliza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditarPoliza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolizas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarPanelRealizarPago)).BeginInit();
            this.panelRealizarPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Polizas";
            // 
            // pbCrearPoliza
            // 
            this.pbCrearPoliza.Image = ((System.Drawing.Image)(resources.GetObject("pbCrearPoliza.Image")));
            this.pbCrearPoliza.Location = new System.Drawing.Point(1089, 57);
            this.pbCrearPoliza.Name = "pbCrearPoliza";
            this.pbCrearPoliza.Size = new System.Drawing.Size(35, 35);
            this.pbCrearPoliza.TabIndex = 9;
            this.pbCrearPoliza.TabStop = false;
            this.pbCrearPoliza.Click += new System.EventHandler(this.pbCrear_Click);
            // 
            // pbEliminarPoliza
            // 
            this.pbEliminarPoliza.Image = ((System.Drawing.Image)(resources.GetObject("pbEliminarPoliza.Image")));
            this.pbEliminarPoliza.Location = new System.Drawing.Point(1089, 142);
            this.pbEliminarPoliza.Name = "pbEliminarPoliza";
            this.pbEliminarPoliza.Size = new System.Drawing.Size(35, 34);
            this.pbEliminarPoliza.TabIndex = 10;
            this.pbEliminarPoliza.TabStop = false;
            this.pbEliminarPoliza.Visible = false;
            this.pbEliminarPoliza.Click += new System.EventHandler(this.pbEliminar_Click);
            // 
            // pbEditarPoliza
            // 
            this.pbEditarPoliza.Image = ((System.Drawing.Image)(resources.GetObject("pbEditarPoliza.Image")));
            this.pbEditarPoliza.Location = new System.Drawing.Point(1089, 98);
            this.pbEditarPoliza.Name = "pbEditarPoliza";
            this.pbEditarPoliza.Size = new System.Drawing.Size(35, 38);
            this.pbEditarPoliza.TabIndex = 11;
            this.pbEditarPoliza.TabStop = false;
            this.pbEditarPoliza.Visible = false;
            this.pbEditarPoliza.Click += new System.EventHandler(this.pbEditar_Click);
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
            this.dgvPolizas.Location = new System.Drawing.Point(35, 55);
            this.dgvPolizas.Name = "dgvPolizas";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPolizas.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPolizas.Size = new System.Drawing.Size(1048, 310);
            this.dgvPolizas.TabIndex = 8;
            this.dgvPolizas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPolizas_CellClick);
            // 
            // lbPago
            // 
            this.lbPago.AutoSize = true;
            this.lbPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPago.Location = new System.Drawing.Point(34, 385);
            this.lbPago.Name = "lbPago";
            this.lbPago.Size = new System.Drawing.Size(0, 17);
            this.lbPago.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(467, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Mostrar pagos";
            // 
            // pbOn
            // 
            this.pbOn.Image = ((System.Drawing.Image)(resources.GetObject("pbOn.Image")));
            this.pbOn.Location = new System.Drawing.Point(606, 29);
            this.pbOn.Name = "pbOn";
            this.pbOn.Size = new System.Drawing.Size(48, 23);
            this.pbOn.TabIndex = 30;
            this.pbOn.TabStop = false;
            this.pbOn.Click += new System.EventHandler(this.pbOn_Click);
            // 
            // pbOff
            // 
            this.pbOff.Image = ((System.Drawing.Image)(resources.GetObject("pbOff.Image")));
            this.pbOff.Location = new System.Drawing.Point(606, 29);
            this.pbOff.Name = "pbOff";
            this.pbOff.Size = new System.Drawing.Size(39, 23);
            this.pbOff.TabIndex = 31;
            this.pbOff.TabStop = false;
            this.pbOff.Click += new System.EventHandler(this.pbOff_Click);
            // 
            // lbMensajeEstado
            // 
            this.lbMensajeEstado.AutoSize = true;
            this.lbMensajeEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensajeEstado.ForeColor = System.Drawing.Color.DarkGray;
            this.lbMensajeEstado.Location = new System.Drawing.Point(660, 35);
            this.lbMensajeEstado.Name = "lbMensajeEstado";
            this.lbMensajeEstado.Size = new System.Drawing.Size(260, 17);
            this.lbMensajeEstado.TabIndex = 33;
            this.lbMensajeEstado.Text = "Deactivado enlazado de datos dinamico";
            // 
            // pbMostrarPanelRealizarPago
            // 
            this.pbMostrarPanelRealizarPago.Image = ((System.Drawing.Image)(resources.GetObject("pbMostrarPanelRealizarPago.Image")));
            this.pbMostrarPanelRealizarPago.Location = new System.Drawing.Point(815, 381);
            this.pbMostrarPanelRealizarPago.Name = "pbMostrarPanelRealizarPago";
            this.pbMostrarPanelRealizarPago.Size = new System.Drawing.Size(29, 25);
            this.pbMostrarPanelRealizarPago.TabIndex = 34;
            this.pbMostrarPanelRealizarPago.TabStop = false;
            this.pbMostrarPanelRealizarPago.Click += new System.EventHandler(this.pbMostrarPanelRealizarPago_Click);
            // 
            // lbMensajePago
            // 
            this.lbMensajePago.AutoSize = true;
            this.lbMensajePago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensajePago.Location = new System.Drawing.Point(713, 385);
            this.lbMensajePago.Name = "lbMensajePago";
            this.lbMensajePago.Size = new System.Drawing.Size(90, 17);
            this.lbMensajePago.TabIndex = 35;
            this.lbMensajePago.Text = " pagar ahora";
            // 
            // panelRealizarPago
            // 
            this.panelRealizarPago.Controls.Add(this.tbIngresao);
            this.panelRealizarPago.Location = new System.Drawing.Point(862, 376);
            this.panelRealizarPago.Name = "panelRealizarPago";
            this.panelRealizarPago.Size = new System.Drawing.Size(173, 26);
            this.panelRealizarPago.TabIndex = 36;
            this.panelRealizarPago.Visible = false;
            // 
            // tbIngresao
            // 
            this.tbIngresao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIngresao.Location = new System.Drawing.Point(18, 0);
            this.tbIngresao.Name = "tbIngresao";
            this.tbIngresao.Size = new System.Drawing.Size(108, 26);
            this.tbIngresao.TabIndex = 1;
            // 
            // dgvPagos
            // 
            this.dgvPagos.AllowUserToAddRows = false;
            this.dgvPagos.AllowUserToDeleteRows = false;
            this.dgvPagos.AllowUserToOrderColumns = true;
            this.dgvPagos.AllowUserToResizeColumns = false;
            this.dgvPagos.AllowUserToResizeRows = false;
            this.dgvPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPagos.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvPagos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagos.Location = new System.Drawing.Point(35, 417);
            this.dgvPagos.Name = "dgvPagos";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPagos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPagos.Size = new System.Drawing.Size(1048, 140);
            this.dgvPagos.TabIndex = 14;
            // 
            // lbMensaje
            // 
            this.lbMensaje.AutoSize = true;
            this.lbMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensaje.Location = new System.Drawing.Point(467, 495);
            this.lbMensaje.Name = "lbMensaje";
            this.lbMensaje.Size = new System.Drawing.Size(0, 17);
            this.lbMensaje.TabIndex = 13;
            // 
            // lbPagos
            // 
            this.lbPagos.AutoSize = true;
            this.lbPagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPagos.Location = new System.Drawing.Point(-601, 394);
            this.lbPagos.Name = "lbPagos";
            this.lbPagos.Size = new System.Drawing.Size(0, 17);
            this.lbPagos.TabIndex = 37;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1041, 376);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 30);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // UC_CrudPolizas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbPagos);
            this.Controls.Add(this.panelRealizarPago);
            this.Controls.Add(this.lbMensajePago);
            this.Controls.Add(this.pbMostrarPanelRealizarPago);
            this.Controls.Add(this.lbMensajeEstado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbOn);
            this.Controls.Add(this.pbOff);
            this.Controls.Add(this.lbPago);
            this.Controls.Add(this.dgvPagos);
            this.Controls.Add(this.lbMensaje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbEditarPoliza);
            this.Controls.Add(this.pbEliminarPoliza);
            this.Controls.Add(this.pbCrearPoliza);
            this.Controls.Add(this.dgvPolizas);
            this.Name = "UC_CrudPolizas";
            this.Size = new System.Drawing.Size(1127, 618);
            this.Load += new System.EventHandler(this.UC_CurdPolizas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCrearPoliza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminarPoliza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditarPoliza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolizas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarPanelRealizarPago)).EndInit();
            this.panelRealizarPago.ResumeLayout(false);
            this.panelRealizarPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbCrearPoliza;
        private System.Windows.Forms.PictureBox pbEliminarPoliza;
        private System.Windows.Forms.PictureBox pbEditarPoliza;
        private System.Windows.Forms.DataGridView dgvPolizas;
        private System.Windows.Forms.Label lbPago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbOn;
        private System.Windows.Forms.PictureBox pbOff;
        private System.Windows.Forms.Label lbMensajeEstado;
        private System.Windows.Forms.PictureBox pbMostrarPanelRealizarPago;
        private System.Windows.Forms.Label lbMensajePago;
        private System.Windows.Forms.Panel panelRealizarPago;
        private System.Windows.Forms.TextBox tbIngresao;
        private System.Windows.Forms.DataGridView dgvPagos;
        private System.Windows.Forms.Label lbMensaje;
        private System.Windows.Forms.Label lbPagos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
