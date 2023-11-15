using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [Serializable]
    [XmlInclude(typeof(DispositivoElectronico))]
    [XmlInclude(typeof(Celular))]
    [XmlInclude(typeof(Notebook))]
    [XmlInclude(typeof(Televisor))]
    public class Cliente
    {
        protected string nombreEmpresa;
        protected string ubicacion;
        protected long cuit;
        protected ETipos tipoCliente;

        private List<DispositivoElectronico> dispositivos;

        #region Getters y Setters
        public long Cuit
        {
            get { return this.cuit; }

            set { this.cuit = value; }
        }
        public string Nombre
        {
            get { return this.nombreEmpresa; }
            set { this.nombreEmpresa = value; }
        }
        public ETipos TipoCliente
        {
            get { return tipoCliente; }
            set { this.tipoCliente = value; }
        }
        public string Ubicacion
        {
            get { return this.ubicacion; }
            set { this.ubicacion = value; }
        }

        public List<DispositivoElectronico> Dispositivos
        {
            get { return this.dispositivos; }
            set { this.dispositivos = value;}
        }
        #endregion
        public Cliente() 
        {   
            this.cuit = 10000000001;
            this.nombreEmpresa = "NO SE INGRESO";
            this.tipoCliente = ETipos.ConsumidorFinal;
            this.ubicacion = "NO SE INGRESO";
            this.dispositivos = new List<DispositivoElectronico>();
        }
        public Cliente(long cuit):this()
        {
            this.cuit = cuit;
        }
        public Cliente(long cuit, string nombreEmpresa, ETipos tipoCliente):this(cuit)
        {
            this.nombreEmpresa = nombreEmpresa;
            this.tipoCliente = tipoCliente;
        }
        public Cliente(string nombreEmpresa, long cuit) : this(cuit)
        {
            this.nombreEmpresa = nombreEmpresa;
        }
        public Cliente(long cuit, string nombreEmpresa,  ETipos tipoCliente, string ubicacion):this (cuit, nombreEmpresa, tipoCliente) 
        {
            this.ubicacion = ubicacion;
        }
        #region Sobrecarga de operadores              
        public static Cliente operator +(Cliente cliente, DispositivoElectronico dispo)
        {
            if (cliente != dispo)
            {
                cliente.dispositivos.Add(dispo);

            }
            else
            {
                Console.WriteLine("El cliente ya lo compro");
            }
            return cliente;
        }
        public static Cliente operator -(Cliente cliente, DispositivoElectronico dispo)
        {
            if (cliente == dispo)
            {
                cliente.dispositivos.Remove(dispo);
            }
            else
            {
                Console.WriteLine("No se encontro");
            }
            return cliente;
        }
        public static bool operator ==(Cliente cliente, DispositivoElectronico dispositivo)
        {

            return cliente.dispositivos.Contains(dispositivo); // tiene que tener el Equals

        }
        public static bool operator !=(Cliente cliente, DispositivoElectronico dispositivo)
        {
            return !(cliente == dispositivo);
        }
        #endregion

        public override bool Equals(object? obj)
        {
            bool retorno = false;
            if (obj is Cliente)
            {
                retorno = this == (Cliente)obj;
            }
            return base.Equals(obj);
        }
        public string MostrarVisor()
        {
            return ($"{this.nombreEmpresa} - {this.cuit} - {this.tipoCliente.ToString()}");
            
        }
        public string MostrarVisorDispositivos()
        {
            if (this.dispositivos != null)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < this.Dispositivos.Count; i++)
                    sb.AppendLine(this.Dispositivos[i].MostrarVisor());
                return sb.ToString();
            }
            return "";

        }
        public virtual string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"NOMBRE / EMPRESA: {this.nombreEmpresa}");
            sb.AppendLine($"CUIT: {this.cuit}");
            sb.AppendLine($"TIPO: {this.tipoCliente.ToString()}");
            sb.AppendLine($"UBICACION: {this.ubicacion}");
            return sb.ToString();
        }
        public virtual string ToString(bool paraConsola)
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"-----------------------------------------");
            sb.Append(this.ToString());
            sb.AppendLine($"-----------------------------------------");

            if (this.dispositivos != null)
            {
                for (int i = 0; i < this.dispositivos.Count; i++)
                    sb.AppendLine(this.dispositivos[i].ToString());
            }
            return sb.ToString();
        }
        public void OrdenarDispositivosId(string orden)
        {
            if (orden == "ascendente")
                this.dispositivos.Sort((dispositivo1, dispositivo2) => dispositivo1.Id.CompareTo(dispositivo2.Id)); 
            else
                this.dispositivos.Sort((dispositivo1, dispositivo2) => dispositivo2.Id.CompareTo(dispositivo1.Id));
        }
        public void OrdenarDispositivosMarca(string orden)
        {
            if (orden == "ascendente")
                this.dispositivos.Sort((dispositivo1, dispositivo2) => dispositivo1.Marca.CompareTo(dispositivo2.Marca));
            else
                this.dispositivos.Sort((dispositivo1, dispositivo2) => dispositivo2.Marca.CompareTo(dispositivo1.Marca));
        }


    }
}
