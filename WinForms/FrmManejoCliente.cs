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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinForms
{
    public partial class FrmManejoCliente : Form
    {
        public Entidades.Cliente cliente;
        public bool seCreoCliente;
        public FrmManejoCliente()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public FrmManejoCliente( Cliente cliente):this() 
        {
            this.cliente = cliente;
            TxtNombre.Text = this.cliente.Nombre;
            TxtCuit.Text = this.cliente.Cuit.ToString();
            TxtUbicacion.Text = this.cliente.Ubicacion;
            var tipos = ETipos.GetNames(typeof(ETipos));
            CmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbTipo.DataSource = tipos;
            CmbTipo.SelectedItem = this.cliente.TipoCliente.ToString();
        }

        private void FrmAgregarCliente_Load(object sender, EventArgs e)
        {

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (!(long.TryParse(this.TxtCuit.Text, out long cuit)))
            {
                MessageBox.Show("Ingrese un cuit valido", "ERROR");
                return;
            }
            if (!(Enum.TryParse(this.CmbTipo.SelectedItem.ToString(), out ETipos tipo)))
            {
                MessageBox.Show("Ingrese un tipo valido", "ERROR");
                return;
            }

            string nombre = this.TxtNombre.Text;
            string ubicacion = this.TxtUbicacion.Text;
                      

            if (nombre.Length == 0 || ubicacion.Length == 0 || cuit <= 0)
            {
                MessageBox.Show("Ingrese datos validos", "ERROR");
                return;
            }
            else
            {
                this.seCreoCliente = true;
                this.cliente = new Cliente(cuit, nombre, tipo, ubicacion);
                this.DialogResult = DialogResult.OK;
            }
            
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

    }
}
