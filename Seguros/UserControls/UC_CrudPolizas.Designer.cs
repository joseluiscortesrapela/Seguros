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
            this.lbMensaje = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbCrear = new System.Windows.Forms.PictureBox();
            this.pbEliminar = new System.Windows.Forms.PictureBox();
            this.pbEditar = new System.Windows.Forms.PictureBox();
            this.dgvPolizas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolizas)).BeginInit();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Polizas";
            // 
            // pbCrear
            // 
            this.pbCrear.Image = ((System.Drawing.Image)(resources.GetObject("pbCrear.Image")));
            this.pbCrear.Location = new System.Drawing.Point(1089, 43);
            this.pbCrear.Name = "pbCrear";
            this.pbCrear.Size = new System.Drawing.Size(35, 35);
            this.pbCrear.TabIndex = 9;
            this.pbCrear.TabStop = false;
            this.pbCrear.Click += new System.EventHandler(this.pbCrear_Click);
            // 
            // pbEliminar
            // 
            this.pbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("pbEliminar.Image")));
            this.pbEliminar.Location = new System.Drawing.Point(1089, 128);
            this.pbEliminar.Name = "pbEliminar";
            this.pbEliminar.Size = new System.Drawing.Size(35, 34);
            this.pbEliminar.TabIndex = 10;
            this.pbEliminar.TabStop = false;
            this.pbEliminar.Visible = false;
            this.pbEliminar.Click += new System.EventHandler(this.pbEliminar_Click);
            // 
            // pbEditar
            // 
            this.pbEditar.Image = ((System.Drawing.Image)(resources.GetObject("pbEditar.Image")));
            this.pbEditar.Location = new System.Drawing.Point(1089, 84);
            this.pbEditar.Name = "pbEditar";
            this.pbEditar.Size = new System.Drawing.Size(35, 38);
            this.pbEditar.TabIndex = 11;
            this.pbEditar.TabStop = false;
            this.pbEditar.Visible = false;
            this.pbEditar.Click += new System.EventHandler(this.pbEditar_Click);
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
            this.dgvPolizas.Location = new System.Drawing.Point(35, 43);
            this.dgvPolizas.Name = "dgvPolizas";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPolizas.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPolizas.Size = new System.Drawing.Size(1048, 552);
            this.dgvPolizas.TabIndex = 8;
            this.dgvPolizas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPolizas_CellClick);
            // 
            // UC_CurdPolizas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.Controls.Add(this.lbMensaje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbEditar);
            this.Controls.Add(this.pbEliminar);
            this.Controls.Add(this.pbCrear);
            this.Controls.Add(this.dgvPolizas);
            this.Name = "UC_CurdPolizas";
            this.Size = new System.Drawing.Size(1127, 618);
            this.Load += new System.EventHandler(this.UC_CurdPolizas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCrear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolizas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMensaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbCrear;
        private System.Windows.Forms.PictureBox pbEliminar;
        private System.Windows.Forms.PictureBox pbEditar;
        private System.Windows.Forms.DataGridView dgvPolizas;
    }
}
