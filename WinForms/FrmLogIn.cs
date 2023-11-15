using Microsoft.VisualBasic.ApplicationServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using Entidades;

namespace WinForms
{
    public partial class FrmLogIn : Form
    {
        public bool validacionClaveUsuario = false;
        public int intentos = 0;
        private Usuario usuarioIngresado;

        public Usuario Usuario
        {
            get { return usuarioIngresado; }
        }
        public FrmLogIn()
        {
            InitializeComponent();
            this.CenterToScreen();
            txtClave.Text = "12345678";
            txtCorreo.Text = "admin@admin.com";

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (txtClave.Text == "" || txtCorreo.Text == "")
            {
                MessageBox.Show("Ingresa datos validos", "ERROR");
                return;
            }
            List<Usuario> list = DeserealizarUsuarios();

            if (this.intentos <= 3)
            {
                foreach (Usuario usuario in list)
                {
                    if (txtCorreo.Text == usuario.correo)
                    {
                        if (txtClave.Text == usuario.clave)
                        {
                            this.validacionClaveUsuario = true;
                            this.usuarioIngresado = usuario;

                            this.Close();
                            return;
                        }
                    }
                }
            }
            MessageBox.Show("El usuario es invalido", "ERROR");
            this.intentos++;
        }
        private static List<Usuario> DeserealizarUsuarios()
        {
            //string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = @"..\..\..\..\WinForms\MOCK_DATA.json";


            // Lee el contenido del archivo JSON en una cadena
            string jsonString = File.ReadAllText(path);

            // Deserializa la cadena JSON en una lista de objetos de tipo Usuario
            List<Usuario> listaUsuarios = JsonSerializer.Deserialize<List<Usuario>>(jsonString);

            return listaUsuarios;
        }

        private void FrmLogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!validacionClaveUsuario)
            {
                DialogResult result = MessageBox.Show("¿Deseas cerrar el formulario?", "Confirmar Cierre", MessageBoxButtons.YesNo);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtClave.UseSystemPasswordChar = false;
            }
            else
            {
                txtClave.UseSystemPasswordChar = true;
            }

        }

        private void FrmLogIn_Load(object sender, EventArgs e)
        {

        }
    }
}