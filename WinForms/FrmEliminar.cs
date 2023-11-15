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
    public partial class FrmEliminar : Form
    {
        protected string tipo;
        protected bool respuesta;
        protected Cliente ?cliente;
        protected DispositivoElectronico ?dispositivo;

        public bool Respuesta
        {
            get { return this.respuesta; }
        }

        public FrmEliminar(string tipo)
        {
            InitializeComponent();
            this.CenterToScreen();       
            this.tipo = tipo;
        }
        public FrmEliminar(string tipo, Cliente cliente) : this(tipo)
        { 
            this.cliente = cliente;
            this.dispositivo = null;
        }
        public FrmEliminar(string tipo, DispositivoElectronico dispositivo) : this(tipo)
        {
            this.cliente = null;
            this.dispositivo = dispositivo;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            this.respuesta = true;
            this.Close();

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.respuesta = false;
            this.Close();
        }

        private void FrmEliminar_Load(object sender, EventArgs e)
        {
            this.ActualizarVisor();
        }
        private void ActualizarVisor()
        {
            if (this.tipo == "cliente") //&& (this.cliente.ToString() != null))
            {
                txtClientes.Text = this.cliente.ToString(true);
            }
            else if(this.tipo == "dispositivo")// && (this.dispositivo.ToString() != null))
            {
                txtClientes.Text = this.dispositivo.ToString();
            }
        }

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
