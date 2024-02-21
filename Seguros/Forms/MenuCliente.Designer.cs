namespace Seguros.Forms
{
    partial class MenuCliente
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuCliente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelBuscador = new System.Windows.Forms.Panel();
            this.pbBuscador = new System.Windows.Forms.PictureBox();
            this.pbMostrarBuscador = new System.Windows.Forms.PictureBox();
            this.pbInicio = new System.Windows.Forms.PictureBox();
            this.panelFlSuperior = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMisPolizas = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.paneLaterallNavegacion = new System.Windows.Forms.FlowLayoutPanel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lbApellidos = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTipo = new System.Windows.Forms.Label();
            this.panelPolizas = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPolizas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelBuscador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarBuscador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInicio)).BeginInit();
            this.panelFlSuperior.SuspendLayout();
            this.paneLaterallNavegacion.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelPolizas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolizas)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Snow;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.BlueViolet;
            this.textBox1.Location = new System.Drawing.Point(35, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(319, 19);
            this.textBox1.TabIndex = 3;
            // 
            // pbExit
            // 
            this.pbExit.Image = ((System.Drawing.Image)(resources.GetObject("pbExit.Image")));
            this.pbExit.Location = new System.Drawing.Point(1081, 9);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(21, 21);
            this.pbExit.TabIndex = 5;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.pbExit);
            this.panel1.Controls.Add(this.panelBuscador);
            this.panel1.Controls.Add(this.pbMostrarBuscador);
            this.panel1.Controls.Add(this.pbInicio);
            this.panel1.Location = new System.Drawing.Point(13, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1154, 83);
            this.panel1.TabIndex = 5;
            // 
            // panelBuscador
            // 
            this.panelBuscador.BackColor = System.Drawing.Color.Transparent;
            this.panelBuscador.Controls.Add(this.textBox1);
            this.panelBuscador.Controls.Add(this.pbBuscador);
            this.panelBuscador.Location = new System.Drawing.Point(325, 5);
            this.panelBuscador.Name = "panelBuscador";
            this.panelBuscador.Size = new System.Drawing.Size(431, 79);
            this.panelBuscador.TabIndex = 6;
            this.panelBuscador.Visible = false;
            // 
            // pbBuscador
            // 
            this.pbBuscador.Image = ((System.Drawing.Image)(resources.GetObject("pbBuscador.Image")));
            this.pbBuscador.Location = new System.Drawing.Point(10, 19);
            this.pbBuscador.Margin = new System.Windows.Forms.Padding(0);
            this.pbBuscador.Name = "pbBuscador";
            this.pbBuscador.Size = new System.Drawing.Size(409, 63);
            this.pbBuscador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbBuscador.TabIndex = 2;
            this.pbBuscador.TabStop = false;
            // 
            // pbMostrarBuscador
            // 
            this.pbMostrarBuscador.Image = ((System.Drawing.Image)(resources.GetObject("pbMostrarBuscador.Image")));
            this.pbMostrarBuscador.Location = new System.Drawing.Point(1012, 39);
            this.pbMostrarBuscador.Name = "pbMostrarBuscador";
            this.pbMostrarBuscador.Size = new System.Drawing.Size(36, 48);
            this.pbMostrarBuscador.TabIndex = 4;
            this.pbMostrarBuscador.TabStop = false;
            this.pbMostrarBuscador.Click += new System.EventHandler(this.pbMostrarBuscador_Click);
            // 
            // pbInicio
            // 
            this.pbInicio.Image = global::Seguros.Properties.Resources.inicio;
            this.pbInicio.Location = new System.Drawing.Point(18, 36);
            this.pbInicio.Margin = new System.Windows.Forms.Padding(3, 3, 400, 3);
            this.pbInicio.Name = "pbInicio";
            this.pbInicio.Size = new System.Drawing.Size(41, 36);
            this.pbInicio.TabIndex = 1;
            this.pbInicio.TabStop = false;
            this.pbInicio.Click += new System.EventHandler(this.pbInicio_Click);
            // 
            // panelFlSuperior
            // 
            this.panelFlSuperior.BackColor = System.Drawing.Color.Transparent;
            this.panelFlSuperior.Controls.Add(this.panel1);
            this.panelFlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFlSuperior.Location = new System.Drawing.Point(253, 0);
            this.panelFlSuperior.Name = "panelFlSuperior";
            this.panelFlSuperior.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panelFlSuperior.Size = new System.Drawing.Size(1120, 86);
            this.panelFlSuperior.TabIndex = 6;
            // 
            // btnMisPolizas
            // 
            this.btnMisPolizas.FlatAppearance.BorderSize = 0;
            this.btnMisPolizas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMisPolizas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMisPolizas.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnMisPolizas.Image = ((System.Drawing.Image)(resources.GetObject("btnMisPolizas.Image")));
            this.btnMisPolizas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMisPolizas.Location = new System.Drawing.Point(3, 146);
            this.btnMisPolizas.Name = "btnMisPolizas";
            this.btnMisPolizas.Size = new System.Drawing.Size(239, 45);
            this.btnMisPolizas.TabIndex = 16;
            this.btnMisPolizas.Text = "Mis polizas";
            this.btnMisPolizas.UseVisualStyleBackColor = true;
            this.btnMisPolizas.Click += new System.EventHandler(this.btnMisPolizas_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.DarkGray;
            this.btnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Image")));
            this.btnCerrarSesion.Location = new System.Drawing.Point(3, 564);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(3, 370, 3, 3);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(239, 83);
            this.btnCerrarSesion.TabIndex = 15;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // paneLaterallNavegacion
            // 
            this.paneLaterallNavegacion.BackColor = System.Drawing.SystemColors.ControlText;
            this.paneLaterallNavegacion.Controls.Add(this.panelLogo);
            this.paneLaterallNavegacion.Controls.Add(this.btnMisPolizas);
            this.paneLaterallNavegacion.Controls.Add(this.btnCerrarSesion);
            this.paneLaterallNavegacion.Dock = System.Windows.Forms.DockStyle.Left;
            this.paneLaterallNavegacion.Location = new System.Drawing.Point(0, 0);
            this.paneLaterallNavegacion.Name = "paneLaterallNavegacion";
            this.paneLaterallNavegacion.Size = new System.Drawing.Size(253, 704);
            this.paneLaterallNavegacion.TabIndex = 5;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.lbApellidos);
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Controls.Add(this.lbUsuario);
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Controls.Add(this.lbTipo);
            this.panelLogo.Location = new System.Drawing.Point(3, 3);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(239, 110);
            this.panelLogo.TabIndex = 17;
            // 
            // lbApellidos
            // 
            this.lbApellidos.AutoSize = true;
            this.lbApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellidos.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbApellidos.Location = new System.Drawing.Point(75, 39);
            this.lbApellidos.Name = "lbApellidos";
            this.lbApellidos.Size = new System.Drawing.Size(92, 25);
            this.lbApellidos.TabIndex = 12;
            this.lbApellidos.Text = "Apellidos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 74);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbUsuario.Location = new System.Drawing.Point(75, 62);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(79, 25);
            this.lbUsuario.TabIndex = 8;
            this.lbUsuario.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(74, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bienvenido/a";
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipo.ForeColor = System.Drawing.Color.Orange;
            this.lbTipo.Location = new System.Drawing.Point(5, 90);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(73, 13);
            this.lbTipo.TabIndex = 10;
            this.lbTipo.Text = "Tipo: Agentes";
            // 
            // panelPolizas
            // 
            this.panelPolizas.BackColor = System.Drawing.Color.Transparent;
            this.panelPolizas.Controls.Add(this.label2);
            this.panelPolizas.Controls.Add(this.dgvPolizas);
            this.panelPolizas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPolizas.Location = new System.Drawing.Point(253, 86);
            this.panelPolizas.Name = "panelPolizas";
            this.panelPolizas.Size = new System.Drawing.Size(1120, 618);
            this.panelPolizas.TabIndex = 7;
            this.panelPolizas.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Listada polizas contratadas";
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
            this.dgvPolizas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPolizas.Location = new System.Drawing.Point(13, 50);
            this.dgvPolizas.Name = "dgvPolizas";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPolizas.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPolizas.Size = new System.Drawing.Size(1078, 536);
            this.dgvPolizas.TabIndex = 0;
            // 
            // MenuCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1373, 704);
            this.Controls.Add(this.panelPolizas);
            this.Controls.Add(this.panelFlSuperior);
            this.Controls.Add(this.paneLaterallNavegacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuCliente";
            this.Load += new System.EventHandler(this.MenuCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelBuscador.ResumeLayout(false);
            this.panelBuscador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarBuscador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInicio)).EndInit();
            this.panelFlSuperior.ResumeLayout(false);
            this.paneLaterallNavegacion.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelPolizas.ResumeLayout(false);
            this.panelPolizas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolizas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelBuscador;
        private System.Windows.Forms.PictureBox pbBuscador;
        private System.Windows.Forms.PictureBox pbMostrarBuscador;
        private System.Windows.Forms.PictureBox pbInicio;
        private System.Windows.Forms.FlowLayoutPanel panelFlSuperior;
        private System.Windows.Forms.Button btnMisPolizas;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.FlowLayoutPanel paneLaterallNavegacion;
        private System.Windows.Forms.Panel panelPolizas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPolizas;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lbApellidos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTipo;
    }
}