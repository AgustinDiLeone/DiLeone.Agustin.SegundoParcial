using Entidades;
using Interfaces;
using SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;
using Microsoft.VisualBasic.ApplicationServices;
using Exceptions;
using System.Reflection;

namespace WinForms
{
    public partial class FrmCrudCliente : FrmCrud, IEventosConfirmandoCUD<Cliente>
    {
        private List<Cliente> clientes;
        private List<ClienteSql> clientesSql;
        private AccesoDatos ado;
        private Usuario usuario;

        // Delegado para el evento personalizado
        public delegate void EscKeyPressedEventHandler(object sender, EventArgs e);

        // Evento personalizado que se dispara cuando se presiona la tecla "Esc"
        public event EscKeyPressedEventHandler EscKeyPressed;



        public FrmCrudCliente(Usuario usuario) : base(usuario)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            BtnCaracteristicaUno.Text = "NOMBRE";
            BtnCaracteristicaDos.Text = "CUIT";
            this.ado = new AccesoDatos();
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
            Task.Run(IniciarHiloHora);
            KeyPreview = true;
         }




        public void ActualizarVisor()
        {
            lstBox.Items.Clear();
            if (this.clientes != null)
            {
                foreach (Cliente cliente in this.clientes)
                {
                    lstBox.Items.Add(cliente.MostrarVisor());
                }
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
            Cliente cliente = this.clientes[index];
            FrmCrudDispositivos frmVer = new FrmCrudDispositivos(base.usuarioIngresado, cliente);

            this.Hide();
            frmVer.ShowDialog();
            this.clientes[index] = frmVer.ClienteModificado();
            this.Show();
        }
        public override void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmManejoCliente frmAgregarCliente = new FrmManejoCliente();
            frmAgregarCliente.ClienteAgregado += Agregado;
            frmAgregarCliente.ShowDialog();

            if (frmAgregarCliente.seCreoCliente)
            {
                try
                {
                    this.ado.AgregarCliente(frmAgregarCliente.cliente);
                }
                catch (ProblemasSql ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.clientes.Add(frmAgregarCliente.cliente);
                this.ActualizarVisor();
            }
            frmAgregarCliente.OnClienteAgregado(frmAgregarCliente.cliente);
        }
        public override void BtnEliminar_Click(object sender, EventArgs e)
        {
            int index = this.lstBox.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Selecciona el elemento que deseas eliminar", "ERROR");
                return;
            }
            Cliente cliente = this.clientes[index];
            FrmEliminar frmEliminar = new FrmEliminar("cliente", cliente);
            frmEliminar.ClienteEliminado += Eliminado;
            frmEliminar.ShowDialog();
            frmEliminar.OnClienteEliminado(this.clientes[index]);
            if (frmEliminar.Respuesta)
            {
                try
                {
                    this.ado.EliminarCliente(this.clientes[index]);
                }
                catch (ProblemasSql ex)
                {
                    MessageBox.Show(ex.Message);
                }

                this.clientes.RemoveAt(index);

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
            FrmManejoCliente frmModificarCliente = new FrmManejoCliente(this.clientes[index]);
            frmModificarCliente.ClienteActualizado += Actualizado;
            frmModificarCliente.ShowDialog();
            if (frmModificarCliente.seCreoCliente)
            {
                try
                {
                    this.ado.ModificarCliente(this.clientes[index], frmModificarCliente.cliente);
                }
                catch (ProblemasSql ex)
                {
                    MessageBox.Show(ex.Message);
                }
                frmModificarCliente.cliente.Dispositivos = this.clientes[index].Dispositivos;
                this.clientes[index] = frmModificarCliente.cliente;
                this.ActualizarVisor();
            }
            frmModificarCliente.OnClienteActualizado(frmModificarCliente.cliente);
        }
        public override void BtnOrdenar_Click(object sender, EventArgs e)
        {
            if (BtnCaracteristicaUno.Checked)
            {
                if (BtnAscendente.Checked)
                {
                    this.OrdenarClienteNombre("ascendente");
                }
                else
                {
                    this.OrdenarClienteNombre("desendiente");
                }
            }
            else
            {
                if (BtnAscendente.Checked)
                {
                    this.OrdenarClienteCuit("ascendente");
                }
                else
                {
                    this.OrdenarClienteCuit("desendiente");
                }
            }

            this.ActualizarVisor();
        }

        public void SerializaciónXml(List<Cliente> listaClientes, string nombreArchivo)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Cliente>));

                using (TextWriter writer = new StreamWriter(nombreArchivo))
                {
                    serializer.Serialize(writer, listaClientes);
                }
            }
            catch
            {
                MessageBox.Show("Error de serialización del archivo, llamar al equipo tecnico", "ERROR");
            }
        }

        public List<Cliente> DeserializacionXml(string nombreArchivo)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Cliente>));

                using (TextReader reader = new StreamReader(nombreArchivo))
                {
                    return (List<Cliente>)serializer.Deserialize(reader);
                }
            }
            catch
            {
                MessageBox.Show("Error en la deserealizacion del archivo, llamar al equipo tecnico", "ERROR");
                return this.clientes = new List<Cliente>();
            }

        }

        private void FrmCrudCliente_Load(object sender, EventArgs e)
        {
            //string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //path += @"\ListaDeClientes.xml";

            string path = @"..\..\..\..\WinForms\ListaDeClientes.xml";
            this.clientes = this.DeserializacionXml(path);

            if (this.clientes == null)
                this.clientes = new List<Cliente>();

            this.usuarios.Add(base.datosUsuarioIngresado);
            this.SerializacionLog(this.datosUsuarioIngresado, @"..\..\..\..\WinForms\Usuarios.log");

            try
            {
                this.clientesSql = this.ado.ObtenerListaCliente();
            }
            catch (ProblemasSql ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.ActualizarVisor();

        }
        private void FrmCrudCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Estas seguro de cerrar la aplicacion", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true; // Evita el cierre del formulario
            }
        }

        private void FrmCrudCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            //string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //path += @"\ListaDeClientes.xml";
            string path = @"..\..\..\..\WinForms\ListaDeClientes.xml";
            this.SerializaciónXml(this.clientes, path);
        }

        public void OrdenarClienteNombre(string orden)
        {
            if (orden == "ascendente")
                this.clientes.Sort((cliente1, cliente2) => cliente1.Nombre.CompareTo(cliente2.Nombre));
            else
                this.clientes.Sort((cliente1, cliente2) => cliente2.Nombre.CompareTo(cliente1.Nombre));
        }

        public void OrdenarClienteCuit(string orden)
        {
            if (orden == "ascendente")
                this.clientes.Sort((cliente1, cliente2) => cliente1.Cuit.CompareTo(cliente2.Cuit));
            else
                this.clientes.Sort((cliente1, cliente2) => cliente2.Cuit.CompareTo(cliente1.Cuit));
        }
        public void SerializacionLog(string datosUsuarioIngresado, string logFilePath)
        {
            try
            {
                File.AppendAllText(logFilePath, datosUsuarioIngresado + Environment.NewLine);

            }
            catch
            {
                MessageBox.Show("Error en la serealizacion del archivo, llamar al equipo tecnico", "ERROR");
                return;
            }

        }
        private void BtnBackUp_Click(object sender, EventArgs e)
        {
            try
            {
                this.clientesSql = ado.ObtenerListaCliente();
            }
            catch (ProblemasSql ex)
            {
                MessageBox.Show(ex.Message);
            }
            FrmVer frmVerBackUp = new FrmVer(this.clientesSql);
            frmVerBackUp.Show();
        }

        private async Task IniciarHiloHora()
        {
            while (true)
            {
                // Espera 1 segundo antes de actualizar la hora
                await Task.Delay(1000);

                // Actualiza la hora en el hilo principal
                BeginInvoke(new Action(() => AsignarHora()));
            }
        }
        private void AsignarHora()
        {
            // Muestra la fecha y hora actual en el formato deseado
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");
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
        public void Agregado(Cliente cliente)
        {
            // Lógica para manejar la adición de clientes desde FrmManejadorClientes
            MessageBox.Show($"Cliente agregado: {cliente.Nombre}");
        }

        public void Actualizado(Cliente cliente)
        {
            // Lógica para manejar la actualización de clientes desde FrmManejadorClientes
            MessageBox.Show($"Cliente actualizado: {cliente.Nombre}");
        }

        public void Eliminado(Cliente cliente)
        {
            // Lógica para manejar la eliminación de clientes desde FrmEliminar
            MessageBox.Show($"Cliente eliminado: {cliente.Nombre}");
        }
    }
}
