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
    public partial class FrmManejoDispositivo : Form
    {
        public bool seCreo;
        public DispositivoElectronico dispositivo;
        private int id;
        private int cantidad;
        private double precio;
        public string marca;
        public string modelo;
        private EFactura tipo;
        public FrmManejoDispositivo()
        {
            InitializeComponent();
            this.CenterToScreen();
            LblTitulo.Text = "Agregar Dispositivo";
        }
        public FrmManejoDispositivo(DispositivoElectronico dispositivo) : this()
        {
            LblTitulo.Text = "Modificar Dispositivo";
            this.dispositivo = dispositivo;
            TxtId.Text = this.dispositivo.Id.ToString();
            TxtCantidad.Text = this.dispositivo.Cantidad.ToString();
            TxtMarca.Text = this.dispositivo.Marca;
            TxtModelo.Text = this.dispositivo.Modelo;
            TxtPrecio.Text = this.dispositivo.PrecioUnitario.ToString();
            foreach (TabPage tabPage in TabDispositivos.TabPages)
            {
                tabPage.Enabled = false; //bloquear las paginas 
            }
            InicializarSegunTipo();
        }

        private void FrmManejoDispositivo_Load(object sender, EventArgs e)
        {
            var tipos = EFactura.GetValues(typeof(EFactura));
            CmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbTipo.DataSource = tipos;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (true)
            {
                bool verificacion = VerificarDatosGenerales();
                if (!verificacion)
                {
                    return;
                }
                int pageIndex = TabDispositivos.SelectedIndex;
                switch (pageIndex)
                {
                    case 0:
                        var nuevoCelular = CrearCelular();
                        if (nuevoCelular.Item1 == false)
                        { return; }
                        else
                        {
                            this.seCreo = true;
                            this.dispositivo = nuevoCelular.Item2;
                            this.DialogResult = DialogResult.OK;
                        }
                        break;
                    case 1:
                        var nuevaNotebook = CrearNotebook();
                        if (nuevaNotebook.Item1 == false)
                        { return; }
                        else
                        {
                            this.seCreo = true;
                            this.dispositivo = nuevaNotebook.Item2;
                            this.DialogResult = DialogResult.OK;
                        }
                        break;
                    case 2:
                        var nuevoTelevisor = CrearTelevisor();
                        if (nuevoTelevisor.Item1 == false)
                        { return; }
                        else
                        {
                            this.seCreo = true;
                            this.dispositivo = nuevoTelevisor.Item2;
                            this.DialogResult = DialogResult.OK;
                        }
                        break;
                    case -1:
                        MessageBox.Show("Seleccione y complete el dispositivo deseado", "ERROR");
                        return;
                }
            }

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private bool VerificarDatosGenerales()
        {
            if (!int.TryParse(this.TxtId.Text, out this.id))
            {
                MessageBox.Show("Ingrese un id valido", "ERROR");
                return false;
            }
            if (!int.TryParse(this.TxtCantidad.Text, out this.cantidad))
            {
                MessageBox.Show("Ingrese una cantidad valido", "ERROR");
                return false;
            }
            if (!double.TryParse(this.TxtPrecio.Text, out this.precio))
            {
                MessageBox.Show("Ingrese un precio valido", "ERROR");
                return false;
            }

            this.marca = this.TxtMarca.Text;
            this.modelo = this.TxtModelo.Text;
            this.tipo = (EFactura)this.CmbTipo.SelectedItem;


            if (marca.Length == 0 || modelo.Length == 0 || id <= 0 || cantidad <= 0 || precio <= 0)
            {
                MessageBox.Show("Ingrese datos validos", "ERROR");
                return false;
            }
            else
                return true;
        }
        private (bool, Celular) CrearCelular()
        {

            if (!double.TryParse(this.TxtPulgadasCelular.Text, out double pulgadas))
            {
                MessageBox.Show("Ingrese pulgadas validas", "ERROR");
                return (false, null);
            }
            if (!int.TryParse(this.TxtAlmacenamientoCelular.Text, out int almacenamiento))
            {
                MessageBox.Show("Ingrese un almacenamiento  valido", "ERROR");
                return (false, null);
            }
            if (!int.TryParse(this.TxtRamCelular.Text, out int ram))
            {
                MessageBox.Show("Ingrese una cantidad de memoria ram valida", "ERROR");
                return (false, null);
            }
            if (!int.TryParse(this.TxtCantCamarasCelular.Text, out int cantCamaras))
            {
                MessageBox.Show("Ingrese una cantidad de camaras validas", "ERROR");
                return (false, null);
            }

            Celular nuevoCelular = new Celular(this.id, this.cantidad, this.precio, this.modelo, this.marca, this.tipo,
                pulgadas, almacenamiento, ram, cantCamaras);

            return (true, nuevoCelular);

        }
        private (bool, Notebook) CrearNotebook()
        {

            if (!double.TryParse(this.TxtPulgadasNote.Text, out double pulgadas))
            {
                MessageBox.Show("Ingrese pulgadas validas", "ERROR");
                return (false, null);
            }
            if (!int.TryParse(this.TxtResolucionNote.Text, out int resolucion))
            {
                MessageBox.Show("Ingrese una resolucion validas", "ERROR");
                return (false, null);
            }
            if (!int.TryParse(this.TxtAlmacenamientoNote.Text, out int almacenamiento))
            {
                MessageBox.Show("Ingrese un almacenamiento  valido", "ERROR");
                return (false, null);
            }
            if (!int.TryParse(this.TxtRamNote.Text, out int ram))
            {
                MessageBox.Show("Ingrese una cantidad de memoria ram valida", "ERROR");
                return (false, null);
            }
            string sistemaOperativo = TxtSONote.Text;
            bool SSD = checkSSD.Checked;

            if (sistemaOperativo.Length == 0)
            {
                MessageBox.Show("Ingrese un sistema operativo valido", "ERROR");
                return (false, null);
            }


            Notebook nuevaNotebook = new Notebook(this.id, this.cantidad, this.precio, this.marca, this.modelo, this.tipo,
                pulgadas, almacenamiento, ram, resolucion, sistemaOperativo, SSD);

            return (true, nuevaNotebook);

        }
        private (bool, Televisor) CrearTelevisor()
        {

            if (!double.TryParse(this.TxtPulgadasTele.Text, out double pulgadas))
            {
                MessageBox.Show("Ingrese pulgadas validas", "ERROR");
                return (false, null);
            }
            if (!int.TryParse(this.TxtResolucionTele.Text, out int resolucion))
            {
                MessageBox.Show("Ingrese una resolucion validas", "ERROR");
                return (false, null);
            }

            bool smartTv = checkSmartTv.Checked;


            Televisor nuevoTelevisor = new Televisor(this.id, this.cantidad, this.precio, this.modelo, this.marca, this.tipo,
                pulgadas, resolucion, smartTv);

            return (true, nuevoTelevisor);

        }

        private void InicializarSegunTipo()
        {
            switch (this.dispositivo)
            {
                case Celular:
                    PageCelular.Enabled = true;
                    Celular celular = this.dispositivo as Celular;
                    TxtCantCamarasCelular.Text = celular.CantCamaras.ToString();
                    TxtAlmacenamientoCelular.Text = celular.Almacenamiento.ToString();
                    TxtPulgadasCelular.Text = celular.Pulgadas.ToString();
                    TxtRamCelular.Text = celular.Ram.ToString();
                    break;
                case Notebook:
                    PageNotebook.Enabled = true;
                    Notebook notebook = this.dispositivo as Notebook;
                    TxtPulgadasNote.Text = notebook.Pulgadas.ToString();
                    TxtResolucionNote.Text = notebook.Resolucion.ToString();
                    TxtRamNote.Text = notebook.Ram.ToString();
                    TxtSONote.Text = notebook.SistemaOperativo;
                    TxtAlmacenamientoNote.Text = notebook.Almacenamiento.ToString();
                    checkSSD.Checked = notebook.Ssd;
                    break;
                case Televisor:
                    PageTelevisor.Enabled = true;
                    Televisor televisor = this.dispositivo as Televisor;
                    TxtPulgadasTele.Text = televisor.Pulgadas.ToString();
                    TxtResolucionTele.Text = televisor.Resolucion.ToString();
                    checkSmartTv.Checked = televisor.SmartTv;
                    break;

            }
        }
    }

}
