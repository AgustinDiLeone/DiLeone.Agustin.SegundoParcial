using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class FrmCrudDispositivos : FrmCrud
    {
        protected Cliente cliente;
        public FrmCrudDispositivos(Usuario usuario,Cliente cliente):base(usuario)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.cliente = cliente;
            BtnCaracteristicaUno.Text = "ID";
            BtnCaracteristicaDos.Text = "MARCA";
            if (usuario.perfil == "supervisor")
            {
                BtnEliminar.Enabled = false;
            }
            else if (usuario.perfil == "vendedor")
            {
                BtnEliminar.Enabled = false;
                BtnModificar.Enabled = false;
                BtnAgregar.Enabled = false;
            }
        }

        private void ActualizarVisor()
        {
            lstBox.Items.Clear();
            foreach (DispositivoElectronico dispo in this.cliente.Dispositivos)
            {
                lstBox.Items.Add(dispo.MostrarVisor());
            }

        }
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void FrmVer_Load(object sender, EventArgs e)
        {
            lblCliente.Text = this.cliente.ToString();
            this.ActualizarVisor();
        }

        public Cliente ClienteModificado()
        {
            return this.cliente;
        }

        public override void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmManejoDispositivo frmAgregarDispositivo = new FrmManejoDispositivo();
            frmAgregarDispositivo.ShowDialog();
            if (frmAgregarDispositivo.seCreo)
            {
                this.cliente.Dispositivos.Add(frmAgregarDispositivo.dispositivo);
                this.ActualizarVisor();
            }

        }
        public override void BtnEliminar_Click(object sender, EventArgs e)
        {
            int index = this.lstBox.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Selecciona el elemento que deseas eliminar", "ERROR");
                return;
            }
            DispositivoElectronico dispo = this.cliente.Dispositivos[index];
            FrmEliminar frmEliminar = new FrmEliminar("dispositivo", dispo);
            frmEliminar.ShowDialog();
            if (frmEliminar.Respuesta)
            {
                this.cliente.Dispositivos.Remove(dispo);//  RemoveAt(index);
                this.ActualizarVisor();
            }
        }
        public override void BtnModificar_Click(object sender, EventArgs e)
        {
            int index = this.lstBox.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Selecciona el elemento que deseas modificar", "ERROR");
                return;
            }
            FrmManejoDispositivo frmAgregarDispositivo = new FrmManejoDispositivo(this.cliente.Dispositivos[index]);
            frmAgregarDispositivo.ShowDialog();
            if (frmAgregarDispositivo.seCreo)
            {
                this.cliente.Dispositivos[index] = frmAgregarDispositivo.dispositivo;
                this.ActualizarVisor();
            }
        }

        public override void BtnVer_Click(object sender, EventArgs e)
        {
            int index = this.lstBox.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Selecciona el elemento que deseas ver", "ERROR");
                return;
            }
            FrmVer frmVer = new FrmVer(this.cliente.Dispositivos[index]);
            frmVer.ShowDialog();
        }
        public override void BtnOrdenar_Click(object sender, EventArgs e)
        {
            if (BtnCaracteristicaUno.Checked)
            {
                if(BtnAscendente.Checked)
                {
                    this.cliente.OrdenarDispositivosId("ascendente");
                }
                else
                {
                    this.cliente.OrdenarDispositivosId("desendiente");
                }
            }
            else
            {
                if (BtnAscendente.Checked)
                {
                    this.cliente.OrdenarDispositivosMarca("ascendente");
                }
                else
                {
                    this.cliente.OrdenarDispositivosMarca("desendiente");
                }
            }


            this.ActualizarVisor();
        }

    }
}
