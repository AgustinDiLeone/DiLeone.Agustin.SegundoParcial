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
        public string nombre;
        public long cuit;
        public string ubicacion;
        public ETipos tipo;

        public FrmManejoCliente()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public FrmManejoCliente(Cliente cliente) : this()
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
            bool verificacion = VerificarDatosGenerales();
            if (verificacion)
            {
                this.seCreoCliente = true;
                this.cliente = new Cliente(this.cuit, this.nombre, this.tipo, this.ubicacion);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                return;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private bool VerificarDatosGenerales()
        {
            if (!(long.TryParse(this.TxtCuit.Text, out this.cuit)))
            {
                MessageBox.Show("Ingrese un cuit valido", "ERROR");
                return false;
            }
            if (!(Enum.TryParse(this.CmbTipo.SelectedItem.ToString(), out this.tipo)))
            {
                MessageBox.Show("Ingrese un tipo valido", "ERROR");
                return false;
            }

            this.nombre = this.TxtNombre.Text;
            this.ubicacion = this.TxtUbicacion.Text;


            if (this.nombre.Length == 0 || this.ubicacion.Length == 0 || this.cuit <= 0)
            {
                MessageBox.Show("Ingrese datos validos", "ERROR");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
