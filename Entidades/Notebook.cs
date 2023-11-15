using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Notebook:DispositivoElectronico
    {
        protected double pulgadas;
        protected int resolucion;
        protected int almacenamiento;
        protected int RAM;
        protected string sistemaOperativo;
        protected bool SSD;

        #region Getters Y Setters
        public double Pulgadas
        {
            get { return this.pulgadas; }

            set { this.pulgadas = value; }
        }
        public int Resolucion
        {
            get { return this.resolucion; }
            set { this.resolucion = value; }
        }
        public int Almacenamiento
        {
            get { return this.almacenamiento; }
            set { this.almacenamiento = value; }
        }
        public int Ram
        {
            get { return this.RAM; }
            set { this.RAM = value; }
        }
        public string SistemaOperativo
        {
            get { return this.sistemaOperativo; }
            set { this.sistemaOperativo = value; }
        }
        public bool Ssd
        {
            get { return this.SSD; }
            set { this.SSD = value; }
        }

        #endregion
        public Notebook() : base()
        {

            this.pulgadas = 0;
            this.almacenamiento = 0;
            this.resolucion = 0;
            this.RAM = 0;
            this.sistemaOperativo = "NO SE INGRESO";

        }
        public Notebook(int id, int cantidad, double precio, string modelo, string marca,
            EFactura tipoFactura, double pulgadas, int almacenamiento,
            int resolucion) : base(id, cantidad, precio, marca, modelo, tipoFactura)
        {
            this.pulgadas = pulgadas;
            this.almacenamiento = almacenamiento;
            this.resolucion = resolucion;
            this.sistemaOperativo = "NO SE INGRESO";
        }
        public Notebook(int id, int cantidad, double precio, string modelo, string marca,
            EFactura tipoFactura, double pulgadas, int almacenamiento,
            int RAM, int resolucion, bool SSD) : this(id, cantidad, precio, modelo, marca, tipoFactura,
                pulgadas,almacenamiento,resolucion)
        {

            this.RAM = RAM;
            this.SSD = SSD;
        }
        public Notebook(int id, int cantidad, double precio, string modelo, string marca,
            EFactura tipoFactura, double pulgadas, int almacenamiento, int RAM,
             int resolucion, string sistemaOperativo, bool SSD) : this(id, cantidad, precio, modelo, marca, tipoFactura,pulgadas,almacenamiento,RAM,resolucion,SSD)
        {
            this.sistemaOperativo = sistemaOperativo;
        }
        public override string MostrarVisor()
        {
            return ($"{base.id} - {base.marca} - {base.modelo} - {base.cantidad}Un - ${base.precioUnitario} -" +
                $" {this.pulgadas}In - {this.resolucion}px - {this.sistemaOperativo}");
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine($"PULGADAS: {this.pulgadas}");
            sb.AppendLine($"ALMACENAMIENTO: {this.almacenamiento}");
            sb.AppendLine($"RAM: {this.RAM}");
            sb.AppendLine($"RESOLUCION: {this.resolucion}");
            sb.AppendLine($"SISTEMA OPERATIVO: {this.sistemaOperativo}");
            if (this.SSD)
            {
                sb.AppendLine($"SSD: SI");
            }
            else
            {
                sb.AppendLine($"SSD: NO");
            }

            return sb.ToString();
        }
    }
}
