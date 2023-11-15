using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class FrmCrud : Form
    {
        public List<string> usuarios;
        public Usuario usuarioIngresado;
        public string datosUsuarioIngresado;
        public FrmCrud()
        {
            InitializeComponent();
        }
        public FrmCrud(Usuario usuario):this()
        {
            BtnCaracteristicaUno.Checked = true;
            BtnAscendente.Checked = true;
            this.usuarioIngresado = usuario;
            this.datosUsuarioIngresado = this.usuarioIngresado.nombre + " - " + DateTime.Now.ToString();
        }

        public virtual void BtnVer_Click(object sender, EventArgs e) { }

        public virtual void BtnAgregar_Click(object sender, EventArgs e) { }

        public virtual void BtnModificar_Click(object sender, EventArgs e) { }

        public virtual void BtnEliminar_Click(object sender, EventArgs e) { }

        private void lstBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public virtual void BtnOrdenar_Click(object sender, EventArgs e) { }

        public virtual void LblUsuarioConectado_Click(object sender, EventArgs e)
        {

        }

        public virtual void FrmCrud_Load(object sender, EventArgs e)
        {
            LblUsuarioConectado.Text = this.datosUsuarioIngresado;
            this.usuarios = this.DeserializacionLog(@"..\..\..\..\WinForms\Usuarios.log");

        }

        private void BtnCaracteristicaUno_CheckedChanged(object sender, EventArgs e)
        {

        }

        public virtual void BtnUsuarios_Click(object sender, EventArgs e)
        {
            FrmVer frmVer = new FrmVer(this.usuarios);
            frmVer.ShowDialog();
        }
        public List<string> DeserializacionLog(string logFilePath)
        {
            List<string> usuarios = new();
            try
            {
                string[] usuariosLogueados = File.ReadAllLines(logFilePath);


                // Recorrer y procesar los mensajes de registro
                foreach (string user in usuariosLogueados)
                {
                    usuarios.Add(user);
                }
                return usuarios;
            }
            catch
            {
                MessageBox.Show("Error en la deserealizacion del archivo, llamar al equipo tecnico", "ERROR");
                return usuarios;
            }

        }
        
    }
}

