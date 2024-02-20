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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbTipo = new System.Windows.Forms.Label();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelBuscador = new System.Windows.Forms.Panel();
            this.pbBuscador = new System.Windows.Forms.PictureBox();
            this.pbMostrarBuscador = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panelFlSuperior = new System.Windows.Forms.FlowLayoutPanel();
            this.button6 = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.paneLaterallNavegacion = new System.Windows.Forms.FlowLayoutPanel();
            this.lbApellidos = new System.Windows.Forms.Label();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelBuscador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarBuscador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelFlSuperior.SuspendLayout();
            this.paneLaterallNavegacion.SuspendLayout();
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
            this.panelLogo.Size = new System.Drawing.Size(239, 155);
            this.panelLogo.TabIndex = 0;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(72, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bienvenido/a";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbUsuario.Location = new System.Drawing.Point(79, 57);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(79, 25);
            this.lbUsuario.TabIndex = 8;
            this.lbUsuario.Text = "Usuario";
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipo.ForeColor = System.Drawing.Color.Orange;
            this.lbTipo.Location = new System.Drawing.Point(9, 92);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(71, 13);
            this.lbTipo.TabIndex = 10;
            this.lbTipo.Text = "Tipo: Clientes";
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
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pbExit);
            this.panel1.Controls.Add(this.panelBuscador);
            this.panel1.Controls.Add(this.pbMostrarBuscador);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(13, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1114, 83);
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
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Seguros.Properties.Resources.inicio;
            this.pictureBox3.Location = new System.Drawing.Point(18, 36);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 3, 400, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 36);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // panelFlSuperior
            // 
            this.panelFlSuperior.BackColor = System.Drawing.SystemColors.WindowText;
            this.panelFlSuperior.Controls.Add(this.panel1);
            this.panelFlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFlSuperior.Location = new System.Drawing.Point(246, 0);
            this.panelFlSuperior.Name = "panelFlSuperior";
            this.panelFlSuperior.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panelFlSuperior.Size = new System.Drawing.Size(1127, 86);
            this.panelFlSuperior.TabIndex = 6;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(3, 191);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(239, 45);
            this.button6.TabIndex = 16;
            this.button6.Text = "Mis polizas";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.DarkGray;
            this.btnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Image")));
            this.btnCerrarSesion.Location = new System.Drawing.Point(3, 609);
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
            this.paneLaterallNavegacion.Controls.Add(this.button6);
            this.paneLaterallNavegacion.Controls.Add(this.btnCerrarSesion);
            this.paneLaterallNavegacion.Dock = System.Windows.Forms.DockStyle.Left;
            this.paneLaterallNavegacion.Location = new System.Drawing.Point(0, 0);
            this.paneLaterallNavegacion.Name = "paneLaterallNavegacion";
            this.paneLaterallNavegacion.Size = new System.Drawing.Size(246, 704);
            this.paneLaterallNavegacion.TabIndex = 5;
            // 
            // lbApellidos
            // 
            this.lbApellidos.AutoSize = true;
            this.lbApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellidos.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbApellidos.Location = new System.Drawing.Point(79, 31);
            this.lbApellidos.Name = "lbApellidos";
            this.lbApellidos.Size = new System.Drawing.Size(92, 25);
            this.lbApellidos.TabIndex = 11;
            this.lbApellidos.Text = "Apellidos";
            // 
            // MenuCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1373, 704);
            this.Controls.Add(this.panelFlSuperior);
            this.Controls.Add(this.paneLaterallNavegacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuCliente";
            this.Load += new System.EventHandler(this.MenuCliente_Load);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelBuscador.ResumeLayout(false);
            this.panelBuscador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarBuscador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelFlSuperior.ResumeLayout(false);
            this.paneLaterallNavegacion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelBuscador;
        private System.Windows.Forms.PictureBox pbBuscador;
        private System.Windows.Forms.PictureBox pbMostrarBuscador;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.FlowLayoutPanel panelFlSuperior;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.FlowLayoutPanel paneLaterallNavegacion;
        private System.Windows.Forms.Label lbApellidos;
    }
}