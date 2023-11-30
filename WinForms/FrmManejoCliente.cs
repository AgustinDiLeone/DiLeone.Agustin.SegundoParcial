using Entidades;
using Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinForms
{
    public partial class FrmManejoCliente : Form
    {
        public Entidades.Cliente cliente;
        public bool modificarCliente;
        public bool seCreoCliente;
        public string nombre;
        public long cuit;
        public string ubicacion;
        public ETipos tipo;

        // Delegados y eventos de FrmManejadorClientes
        public delegate void ClienteAgregadoEventHandler(Cliente cliente);
        public delegate void ClienteActualizadoEventHandler(Cliente cliente);

        public event ClienteAgregadoEventHandler ClienteAgregado;
        public event ClienteActualizadoEventHandler ClienteActualizado;

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
            this.modificarCliente = true;


        } 

        private void FrmAgregarCliente_Load(object sender, EventArgs e)
        {
            var tipos = ETipos.GetNames(typeof(ETipos));
            CmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbTipo.DataSource = tipos;
            if (modificarCliente)
            {
                CmbTipo.SelectedItem = this.cliente.TipoCliente.ToString();
            }

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                VerificarDatosGenerales();
                this.seCreoCliente = true;
                this.cliente = new Cliente(this.cuit, this.nombre, this.tipo, this.ubicacion);
                this.DialogResult = DialogResult.OK;
            }
            catch(Exception mensaje)
            {
                MessageBox.Show(mensaje.Message,"Error!!");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void VerificarDatosGenerales()
        {
            this.nombre = this.TxtNombre.Text;
            if (this.nombre.Length == 0) 
            {
                throw new NombreNoValido();
            }
            if (!(long.TryParse(this.TxtCuit.Text, out this.cuit)))
            {
                throw new CuitNoValido();
            }
            if (this.cuit <= 1000000)
            {
                throw new CuitNoValido();
            }

            this.ubicacion = this.TxtUbicacion.Text;
            if (this.ubicacion.Length == 0)
            {
                throw new UbicacionNoValido();
            }

            if (!(Enum.TryParse(this.CmbTipo.SelectedItem.ToString(), out this.tipo)))
            {
                throw new TipoNoValido();
            }
        }
    }
}
