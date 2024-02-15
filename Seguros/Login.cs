
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
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // Obtengo nombre 
            string usuario = tbNombre.Text;
            // Obtengo la contraseña
            string contraseña = tbContraseña.Text;

            // Si el formulario es valido    
            if (siValidarFormularioLogin(usuario, contraseña))
            {
                // Compruebo si existe el usaurio
                bool existe = loginModel.login(usuario, contraseña);

                // Si usuario existe.
                if (existe)
                {
                    // Oculto la ventana de login
                    this.Hide();
                    // Obtengo el usuario logeado
                    string tipoUsuario = Seguros.SesionUsuario.Tipo;

                   
                    if (tipoUsuario.Equals("Administrador"))
                    {
                        // Intancia
                        var menuAdministrador = new MenuAdministrador();
                        // Muestro la ventana del jugador
                        menuAdministrador.Show();
                    } // Si quien se logea es un administrador
                    else if (tipoUsuario.Equals("Comercial"))
                    {
                         
                    }
                    else
                    {
                        var menuCliente = new MenuCliente();
                        menuCliente.Show();
                    }
                }
                else
                {
                    labelMensajeLogin.Text = "El login es incorrecto";
                }
                Console.WriteLine("LOGIN: el usuario: " + usuario + " con contraseña: " + contraseña + " ¿Existe? " + existe);
            }

        }


        // Registra un nuevo jugador
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Obtengo nombre y le quito los espacios en blanco a derecha e izquierda
            string nombre = tbUsuario.Text.Trim();
            // Obtengo la contraseña
            string contraseña = tbPassword.Text;

            // Si datos formulario son correctos
            if (siValidarFormularioRegistro(nombre, contraseña))
            {   
                // Guardo un nuevo usuario en la base de datos.
                loginModel.registrarJugador(nombre, contraseña);
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
                error.SetError(tbNombre, "El nombre del usuario no puede estar vacio.");
            }
            else
            {
                error.SetError(tbNombre, "");
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
                error.SetError(tbUsuario, "El nombre del usuario no puede estar vacio.");
            }
            else
            { // Si el campo nombre no esta vacio

                error.SetError(tbUsuario, "");

                // Compruebo si existe un usuario con el mismo nombre en la base de datos.
                if (loginModel.isUserExist(nombre))
                {
                    valido = false;
                    error.SetError(tbUsuario, "El nombre " + nombre + " ya existe."); // Muestro error al usuario
                }
                else
                {
                    error.SetError(tbUsuario, "");
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
            tbNombre.Text = "";
            tbContraseña.Text = "";
        }

        // Se cierra el programa
        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
 

    } // Final clase Login



} // Final nameespace
