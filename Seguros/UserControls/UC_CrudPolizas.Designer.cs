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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_CrudPolizas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.pbCrearPoliza = new System.Windows.Forms.PictureBox();
            this.pbEliminarPoliza = new System.Windows.Forms.PictureBox();
            this.pbEditarPoliza = new System.Windows.Forms.PictureBox();
            this.dgvPolizas = new System.Windows.Forms.DataGridView();
            this.lbPago = new System.Windows.Forms.Label();
            this.panelPago = new System.Windows.Forms.Panel();
            this.pbPagar = new System.Windows.Forms.PictureBox();
            this.tbPago = new System.Windows.Forms.TextBox();
            this.dgvPagos = new System.Windows.Forms.DataGridView();
            this.lbMensaje = new System.Windows.Forms.Label();
            this.lbPagos = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelNavegacionSuperior = new System.Windows.Forms.Panel();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.pbInicio = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrearPoliza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminarPoliza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditarPoliza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolizas)).BeginInit();
            this.panelPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.panelNavegacionSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Polizas";
            // 
            // pbCrearPoliza
            // 
            this.pbCrearPoliza.Image = ((System.Drawing.Image)(resources.GetObject("pbCrearPoliza.Image")));
            this.pbCrearPoliza.Location = new System.Drawing.Point(1082, 132);
            this.pbCrearPoliza.Name = "pbCrearPoliza";
            this.pbCrearPoliza.Size = new System.Drawing.Size(35, 35);
            this.pbCrearPoliza.TabIndex = 9;
            this.pbCrearPoliza.TabStop = false;
            this.pbCrearPoliza.Click += new System.EventHandler(this.pbCrear_Click);
            // 
            // pbEliminarPoliza
            // 
            this.pbEliminarPoliza.Image = ((System.Drawing.Image)(resources.GetObject("pbEliminarPoliza.Image")));
            this.pbEliminarPoliza.Location = new System.Drawing.Point(1082, 217);
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
            this.pbEditarPoliza.Location = new System.Drawing.Point(1082, 173);
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
            this.dgvPolizas.AllowUserToResizeColumns = false;
            this.dgvPolizas.AllowUserToResizeRows = false;
            this.dgvPolizas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPolizas.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvPolizas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPolizas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPolizas.Location = new System.Drawing.Point(45, 130);
            this.dgvPolizas.Name = "dgvPolizas";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPolizas.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPolizas.Size = new System.Drawing.Size(1031, 310);
            this.dgvPolizas.TabIndex = 8;
            this.dgvPolizas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPolizas_CellClick);
            // 
            // lbPago
            // 
            this.lbPago.AutoSize = true;
            this.lbPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPago.Location = new System.Drawing.Point(27, 460);
            this.lbPago.Name = "lbPago";
            this.lbPago.Size = new System.Drawing.Size(0, 20);
            this.lbPago.TabIndex = 15;
            // 
            // panelPago
            // 
            this.panelPago.Controls.Add(this.pbPagar);
            this.panelPago.Controls.Add(this.tbPago);
            this.panelPago.Location = new System.Drawing.Point(880, 446);
            this.panelPago.Name = "panelPago";
            this.panelPago.Size = new System.Drawing.Size(211, 34);
            this.panelPago.TabIndex = 36;
            this.panelPago.Visible = false;
            // 
            // pbPagar
            // 
            this.pbPagar.Image = ((System.Drawing.Image)(resources.GetObject("pbPagar.Image")));
            this.pbPagar.Location = new System.Drawing.Point(176, 3);
            this.pbPagar.Name = "pbPagar";
            this.pbPagar.Size = new System.Drawing.Size(29, 26);
            this.pbPagar.TabIndex = 38;
            this.pbPagar.TabStop = false;
            this.pbPagar.Click += new System.EventHandler(this.pbPagar_Click);
            // 
            // tbPago
            // 
            this.tbPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPago.Location = new System.Drawing.Point(27, 3);
            this.tbPago.Name = "tbPago";
            this.tbPago.Size = new System.Drawing.Size(122, 26);
            this.tbPago.TabIndex = 1;
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
            this.dgvPagos.Location = new System.Drawing.Point(45, 492);
            this.dgvPagos.Name = "dgvPagos";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPagos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPagos.Size = new System.Drawing.Size(1031, 140);
            this.dgvPagos.TabIndex = 14;
            // 
            // lbMensaje
            // 
            this.lbMensaje.AutoSize = true;
            this.lbMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensaje.Location = new System.Drawing.Point(457, 683);
            this.lbMensaje.Name = "lbMensaje";
            this.lbMensaje.Size = new System.Drawing.Size(0, 17);
            this.lbMensaje.TabIndex = 13;
            // 
            // lbPagos
            // 
            this.lbPagos.AutoSize = true;
            this.lbPagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPagos.Location = new System.Drawing.Point(-608, 497);
            this.lbPagos.Name = "lbPagos";
            this.lbPagos.Size = new System.Drawing.Size(0, 17);
            this.lbPagos.TabIndex = 37;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            this.error.Icon = ((System.Drawing.Icon)(resources.GetObject("error.Icon")));
            // 
            // panelNavegacionSuperior
            // 
            this.panelNavegacionSuperior.BackColor = System.Drawing.Color.Snow;
            this.panelNavegacionSuperior.Controls.Add(this.pbExit);
            this.panelNavegacionSuperior.Controls.Add(this.pbInicio);
            this.panelNavegacionSuperior.Location = new System.Drawing.Point(31, 3);
            this.panelNavegacionSuperior.Name = "panelNavegacionSuperior";
            this.panelNavegacionSuperior.Size = new System.Drawing.Size(1093, 52);
            this.panelNavegacionSuperior.TabIndex = 38;
            // 
            // pbExit
            // 
            this.pbExit.Image = ((System.Drawing.Image)(resources.GetObject("pbExit.Image")));
            this.pbExit.Location = new System.Drawing.Point(1072, 3);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(21, 21);
            this.pbExit.TabIndex = 7;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // pbInicio
            // 
            this.pbInicio.Image = global::Seguros.Properties.Resources.inicio;
            this.pbInicio.Location = new System.Drawing.Point(5, 13);
            this.pbInicio.Margin = new System.Windows.Forms.Padding(3, 3, 400, 3);
            this.pbInicio.Name = "pbInicio";
            this.pbInicio.Size = new System.Drawing.Size(41, 36);
            this.pbInicio.TabIndex = 1;
            this.pbInicio.TabStop = false;
            // 
            // UC_CrudPolizas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.Controls.Add(this.panelNavegacionSuperior);
            this.Controls.Add(this.lbPagos);
            this.Controls.Add(this.panelPago);
            this.Controls.Add(this.lbPago);
            this.Controls.Add(this.dgvPagos);
            this.Controls.Add(this.lbMensaje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbEditarPoliza);
            this.Controls.Add(this.pbEliminarPoliza);
            this.Controls.Add(this.pbCrearPoliza);
            this.Controls.Add(this.dgvPolizas);
            this.Name = "UC_CrudPolizas";
            this.Size = new System.Drawing.Size(1127, 732);
            this.Load += new System.EventHandler(this.UC_CrudPolizas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCrearPoliza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminarPoliza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditarPoliza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolizas)).EndInit();
            this.panelPago.ResumeLayout(false);
            this.panelPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.panelNavegacionSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInicio)).EndInit();
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
        private System.Windows.Forms.Panel panelPago;
        private System.Windows.Forms.TextBox tbPago;
        private System.Windows.Forms.DataGridView dgvPagos;
        private System.Windows.Forms.Label lbMensaje;
        private System.Windows.Forms.Label lbPagos;
        private System.Windows.Forms.PictureBox pbPagar;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Panel panelNavegacionSuperior;
        private System.Windows.Forms.PictureBox pbInicio;
        private System.Windows.Forms.PictureBox pbExit;
    }
}
