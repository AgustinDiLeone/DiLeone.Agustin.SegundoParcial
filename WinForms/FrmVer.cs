using Entidades;
using SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class FrmVer : Form
    {
        private DispositivoElectronico dispositivo;
        private List<string> usuarios;
        private List<ClienteSql> listaClientes;
        public FrmVer()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }
        public FrmVer(DispositivoElectronico dispositivo) : this()
        {
            this.dispositivo = dispositivo;
        }
        public FrmVer(List<string> usuarios) : this()
        {
            this.usuarios = usuarios;
        }
        public FrmVer(List<ClienteSql> listaClientes) : this()
        {
            this.listaClientes = listaClientes;
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmVer_Load(object sender, EventArgs e)
        {
            TxtDispositivos.SelectionStart = 0;
            TxtDispositivos.SelectionLength = 0;
            if (this.usuarios != null)
            {
                foreach (string user in this.usuarios)
                {
                    TxtDispositivos.Text += (user + Environment.NewLine);
                }

            }
            else if (this.dispositivo != null)
            {
                TxtDispositivos.Text = this.dispositivo.ToString();
            }
            else
            {
                TxtDispositivos.Text = "Clientes registrados \n \n";
                TxtDispositivos.Text += "-----------------------------\n";
                foreach (ClienteSql cliente in this.listaClientes)
                {
                    TxtDispositivos.Text += (cliente.ToString() + Environment.NewLine);
                    TxtDispositivos.Text += "----------------------------\n";
                }

            }
        }

    }
}
