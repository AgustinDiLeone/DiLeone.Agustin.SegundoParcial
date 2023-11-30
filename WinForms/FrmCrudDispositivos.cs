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

        // Delegado para el evento personalizado
        public delegate void EscKeyPressedEventHandler(object sender, EventArgs e);

        // Evento personalizado que se dispara cuando se presiona la tecla "Esc"
        public event EscKeyPressedEventHandler EscKeyPressed;
        public FrmCrudDispositivos(Usuario usuario, Cliente cliente) : base(usuario)
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
            KeyPreview = true; // Habilita la recepción de eventos de teclado en el formulario
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
            frmAgregarDispositivo.DispositivoAgregado += Agregado;
            frmAgregarDispositivo.ShowDialog();
            if (frmAgregarDispositivo.seCreo)
            {
                this.cliente.Dispositivos.Add(frmAgregarDispositivo.dispositivo);
                this.ActualizarVisor();
            }
            frmAgregarDispositivo.OnDispositivoAgregado(frmAgregarDispositivo.dispositivo);

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
            frmEliminar.DispositivoEliminado += Eliminado;
            frmEliminar.ShowDialog();
            frmEliminar.OnDispositivoEliminado(dispo);
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
            FrmManejoDispositivo frmModificarDispositivo = new FrmManejoDispositivo(this.cliente.Dispositivos[index]);
            frmModificarDispositivo.DispositivoActualizado += Actualizado; 
            frmModificarDispositivo.ShowDialog();
            if (frmModificarDispositivo.seCreo)
            {
                this.cliente.Dispositivos[index] = frmModificarDispositivo.dispositivo;
                this.ActualizarVisor();
            }
            frmModificarDispositivo.OnDispositivoActualizado(frmModificarDispositivo.dispositivo);

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
                if (BtnAscendente.Checked)
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

        protected virtual void OnEscKeyPressed()
        {
            EscKeyPressed?.Invoke(this, EventArgs.Empty);
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            // Verifica si se presionó la tecla "Esc"
            if (e.KeyCode == Keys.Escape)
            {
                // Dispara el evento personalizado
                this.OnEscKeyPressed();

                // Cierra el formulario actual
                this.Close();
            }
        }
        private void Agregado(DispositivoElectronico dispositivo )
        {
            // Lógica para manejar la adición de clientes desde FrmManejadorClientes
            MessageBox.Show($"Producto agregado: {dispositivo.Marca}, {dispositivo.Modelo}");
        }

        private void Actualizado(DispositivoElectronico dispositivo)
        {
            // Lógica para manejar la actualización de clientes desde FrmManejadorClientes
            MessageBox.Show($"Producto actualizado: {dispositivo.Marca}, {dispositivo.Modelo}");
        }

        private void Eliminado(DispositivoElectronico dispositivo)
        {
            // Lógica para manejar la eliminación de clientes desde FrmEliminar
            MessageBox.Show($"Producto eliminado: {dispositivo.Marca}, {dispositivo.Modelo}");
        }
    }
}
