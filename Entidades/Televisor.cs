using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Televisor : DispositivoElectronico
    {
        protected double pulgadas;
        protected double resolucion;
        protected bool smartTv;

        #region Getters Y Setters
        public double Pulgadas
        {
            get { return this.pulgadas; }

            set { this.pulgadas = value; }
        }
        public double Resolucion
        {
            get { return this.resolucion; }
            set { this.resolucion = value; }
        }
        public bool SmartTv
        {
            get { return this.smartTv; }
            set { this.smartTv = value; }
        }
        #endregion

        public Televisor(): base()
        {
            this.pulgadas = 0;
            this.resolucion = 0;

        }
        public Televisor(int id, int cantidad, double precio, string modelo, string marca,
            EFactura tipoFactura, int resolucion, double pulgadas) : base(id, cantidad, precio, modelo, marca, tipoFactura)
        {
            this.pulgadas = pulgadas;
            this.resolucion = resolucion;
        }
        public Televisor(int id, int cantidad, double precio, string modelo, string marca,
            EFactura tipoFactura, double pulgadas, int resolucion) : this(id, cantidad, precio, modelo, marca, tipoFactura,resolucion,pulgadas)
        {

        }
        public Televisor(int id, int cantidad, double precio, string modelo, string marca,
            EFactura tipoFactura, double pulgadas, int resolucion,
            bool smartTv) : this(id, cantidad, precio, modelo, marca, tipoFactura,pulgadas,resolucion)
        {
            this.smartTv = smartTv;
        }
        public override string MostrarVisor()
        {
            string visor = ($"{base.id} - {base.marca} - {base.modelo} - {base.cantidad}Un - ${base.precioUnitario} - {this.pulgadas}In - {this.resolucion}px ");
            if (this.smartTv)
            {
                visor += "- SMART TV: SI";
            }
            else
            {
                visor += "- SMART TV: NO";
            }
            return visor;

        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine($"PULGADAS: {this.pulgadas}");
            sb.AppendLine($"RESOLUCION: {this.resolucion}px");
            if ( this.smartTv )
            {
                sb.AppendLine($"SMART TV: SI");
            }
            else
            {
                sb.AppendLine($"SMART TV: NO");
            }

            return sb.ToString();
        }

    }
}
