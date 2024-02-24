
using Seguros.Forms;
using Seguros.Models;
using System;
using System.Windows.Forms;

namespace Seguros
{
    public partial class Login : Form
    {
        private LoginModel loginModel;


        public Login()
        {
            InitializeComponent();
            // Intencio el modelo de datos que controlara las peticiones  con la base de datos.
            loginModel = new LoginModel();
        }


        // Login usuario
        private void login_Click(object sender, EventArgs e)
        {
            // Obtengo correo
            string correo = tbCorreo.Text;
            // Obtengo la contraseña
            string contraseña = tbContraseña.Text;

            // Si el formulario es valido    
            if (siValidarFormularioLogin(correo, contraseña))
            {
                // Compruebo si existe el usaurio
                bool existe = loginModel.login(correo, contraseña);

                // Si usuario existe.
                if (existe)
                {
                    // Oculto la ventana de login
                    this.Hide();
                    var menuPrincipal = new MenuPrincipal();
                    menuPrincipal.Show();
                }
                else
                {
                    labelMensajeLogin.Text = "El login es incorrecto";
                }
                Console.WriteLine("LOGIN: el usuario: " + correo + " con contraseña: " + contraseña + " ¿Existe? " + existe);
            }
        }

        // Registra un nuevo jugador
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Obtengo nombre y le quito los espacios en blanco a derecha e izquierda
            string email = tbEmail.Text.Trim();
            // Obtengo la contraseña
            string contraseña = tbPassword.Text;

            // Si datos formulario son correctos
            if (siValidarFormularioRegistro(email, contraseña))
            {
                // Guardo un nuevo usuario en la base de datos.
                loginModel.registrarJugador(email, contraseña);
                // Muestro mensaje al usuario
                lbMensajeRegistro.Text = "Acabas de registrarte.";
                // Limpio los campos del formulario de registro
                resetearFormulario();
            }
        }

        // Valida los campos del formulario de login
        private bool siValidarFormularioLogin(string nombre, string contraseña)
        {

            bool valido = true;

            // Si el nombre de usuario no esta vacio
            if (nombre.Length == 0)
            {
                valido = false;
                error.SetError(tbCorreo, "El nombre del usuario no puede estar vacio.");
            }
            else
            {
                error.SetError(tbCorreo, "");
            }

            // Si el campo contraseña no esta vacio
            if (contraseña.Length == 0)
            {
                valido = false;
                error.SetError(tbContraseña, "La contraseña no puede estar vacia.");
            }
            else
            {
                error.SetError(tbContraseña, "");
            }


            return valido;


        }

        // Valida los campos del formulario de registro
        private bool siValidarFormularioRegistro(string nombre, string contraseña)
        {

            bool valido = true;

            // Si el nombre de usuario no esta vacio o tiene un valor nulo.
            if (nombre.Length == 0 || string.IsNullOrWhiteSpace(nombre))
            {
                valido = false;
                error.SetError(tbEmail, "El nombre del usuario no puede estar vacio.");
            }
            else
            { // Si el campo nombre no esta vacio

                error.SetError(tbEmail, "");

                // Compruebo si existe un usuario con el mismo nombre en la base de datos.
                if (loginModel.isUserExist(nombre))
                {
                    valido = false;
                    error.SetError(tbEmail, "El nombre " + nombre + " ya existe."); // Muestro error al usuario
                }
                else
                {
                    error.SetError(tbEmail, "");
                }

            }

            // Si el campo contraseña no esta vacio
            if (contraseña.Length == 0)
            {
                valido = false;
                error.SetError(tbPassword, "La contraseña no puede estar vacia.");
            }
            else
            {
                error.SetError(tbPassword, "");
            }


            return valido;

        }

        // Muestro ventana de registro
        private void lbMostrarPanelRegistro_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = false;
            panelRegistro.Visible = true;
        }

        // Muestro ventan de login
        private void lbVolverLogin_Click(object sender, EventArgs e)
        {
            panelRegistro.Visible = false;
            panelLogin.Visible = true;
        }


        private void resetearFormulario()
        {
            tbCorreo.Text = "";
            tbContraseña.Text = "";
        }

        // Se cierra el programa
        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }


    } // Final clase Login



} // Final nameespace
