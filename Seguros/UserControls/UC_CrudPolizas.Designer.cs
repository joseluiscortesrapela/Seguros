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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            ((System.ComponentModel.ISupportInitialize)(this.pbCrearPoliza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminarPoliza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditarPoliza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolizas)).BeginInit();
            this.panelPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
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
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPolizas.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPolizas.Size = new System.Drawing.Size(1048, 310);
            this.dgvPolizas.TabIndex = 8;
            this.dgvPolizas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPolizas_CellClick);
            // 
            // lbPago
            // 
            this.lbPago.AutoSize = true;
            this.lbPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPago.Location = new System.Drawing.Point(34, 385);
            this.lbPago.Name = "lbPago";
            this.lbPago.Size = new System.Drawing.Size(0, 20);
            this.lbPago.TabIndex = 15;
            // 
            // panelPago
            // 
            this.panelPago.Controls.Add(this.pbPagar);
            this.panelPago.Controls.Add(this.tbPago);
            this.panelPago.Location = new System.Drawing.Point(878, 379);
            this.panelPago.Name = "panelPago";
            this.panelPago.Size = new System.Drawing.Size(205, 26);
            this.panelPago.TabIndex = 36;
            this.panelPago.Visible = false;
            // 
            // pbPagar
            // 
            this.pbPagar.Image = ((System.Drawing.Image)(resources.GetObject("pbPagar.Image")));
            this.pbPagar.Location = new System.Drawing.Point(178, 0);
            this.pbPagar.Name = "pbPagar";
            this.pbPagar.Size = new System.Drawing.Size(29, 26);
            this.pbPagar.TabIndex = 38;
            this.pbPagar.TabStop = false;
            this.pbPagar.Click += new System.EventHandler(this.pbPagar_Click);
            // 
            // tbPago
            // 
            this.tbPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPago.Location = new System.Drawing.Point(12, 0);
            this.tbPago.Name = "tbPago";
            this.tbPago.Size = new System.Drawing.Size(132, 26);
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
            this.dgvPagos.Location = new System.Drawing.Point(35, 417);
            this.dgvPagos.Name = "dgvPagos";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPagos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPagos.Size = new System.Drawing.Size(1048, 140);
            this.dgvPagos.TabIndex = 14;
            // 
            // lbMensaje
            // 
            this.lbMensaje.AutoSize = true;
            this.lbMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensaje.Location = new System.Drawing.Point(464, 580);
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
            // error
            // 
            this.error.ContainerControl = this;
            this.error.Icon = ((System.Drawing.Icon)(resources.GetObject("error.Icon")));
            // 
            // UC_CrudPolizas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
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
            this.Size = new System.Drawing.Size(1127, 618);
            this.Load += new System.EventHandler(this.UC_CurdPolizas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCrearPoliza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminarPoliza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditarPoliza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolizas)).EndInit();
            this.panelPago.ResumeLayout(false);
            this.panelPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
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
    }
}
