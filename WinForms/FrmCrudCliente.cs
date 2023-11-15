using Entidades;
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

namespace WinForms
{
    public partial class FrmCrudCliente : FrmCrud
    {
        private List<Cliente> clientes;
        private List<Cliente> clientesSql;
        private AccesoDatos ado;
        private Usuario usuario;


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

            /*

            Cliente data = new Cliente(5181818182, "Ricardo",  ETipos.ConsumidorFinal,"Buenos Aires");
            //Cliente data2 = new Cliente(201685479584,"Agustin",ETipos.ResponsableInscripto, "Buenos Aires");
            //bool x = ado.AgregarCliente(data2);

            //Cliente data1 = new Cliente(201685479584, "Agustin", ETipos.ResponsableInscripto, "Buenos Aires");
            Cliente data2 = new Cliente(10,"Agustin",ETipos.Exento, "Buenos Aires");
            //bool x = ado.AgregarCliente(data2);
            //bool y = ado.ModificarCliente(data1 ,data2);

            bool z = ado.EliminarCliente(data);

            List<ClienteSql> listaDatos = ado.ObtenerListaCliente();

            foreach (ClienteSql dato in listaDatos)
            {
                MessageBox.Show(dato.ToString());
            }
            */
        }

        private void ActualizarVisor()
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
            frmAgregarCliente.ShowDialog();
            if (frmAgregarCliente.seCreoCliente)
            {
                this.clientes.Add(frmAgregarCliente.cliente);
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
            Cliente cliente = this.clientes[index];
            FrmEliminar frmEliminar = new FrmEliminar("cliente", cliente);
            frmEliminar.ShowDialog();
            if (frmEliminar.Respuesta)
            {
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
            FrmManejoCliente frmAgregarCliente = new FrmManejoCliente(this.clientes[index]);
            frmAgregarCliente.ShowDialog();
            if (frmAgregarCliente.seCreoCliente)
            {
                this.ado.ModificarCliente(this.clientes[index], frmAgregarCliente.cliente);
                frmAgregarCliente.cliente.Dispositivos = this.clientes[index].Dispositivos;
                this.clientes[index] = frmAgregarCliente.cliente;
                this.ActualizarVisor();
            }
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
            this.clientesSql = this.ado.ObtenerListaCliente();
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


    }
}
