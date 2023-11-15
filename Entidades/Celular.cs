using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Celular:DispositivoElectronico
    {
        protected double pulgadas;
        protected int almacenamiento;
        protected int ram;
        protected int cantCamaras;

#region Getters Y Setters
        public double Pulgadas
        {
            get { return this.pulgadas; }

            set { this.pulgadas = value; }
        }
        public int Almacenamiento
        {
            get { return this.almacenamiento; }
            set { this.almacenamiento = value; }
        }
        public int Ram
        {
            get { return this.ram; }
            set { this.ram = value; }
        }
        public int CantCamaras
        {
            get { return this.cantCamaras; }
            set { this.cantCamaras = value; }
        }
#endregion

        public Celular():base()
        {
            this.pulgadas = 0;
            this.almacenamiento = 0;
            this.ram = 0;
            this.cantCamaras = 0;

        }
        public Celular(int id, int cantidad, double precio, string modelo, string marca,
            EFactura tipoFactura, int cantCamaras,  int almacenamiento, double pulgadas) : base(id,
                cantidad, precio, modelo, marca, tipoFactura)
        {
            this.pulgadas = pulgadas;
            this.almacenamiento = almacenamiento;
            this.cantCamaras = cantCamaras;
        }
        public Celular(int id, int cantidad, double precio, string modelo, string marca,
            EFactura tipoFactura, double pulgadas, int almacenamiento, int cantCamaras) : this(id,
                cantidad, precio, modelo, marca, tipoFactura, cantCamaras,almacenamiento,pulgadas) 
        {

        }
        public Celular(int id, int cantidad, double precio, string modelo, string marca, 
            EFactura tipoFactura, double pulgadas, int almacenamiento, int RAM,
            int cantCamaras) : this(id, cantidad, precio, modelo, marca, tipoFactura,pulgadas,almacenamiento,cantCamaras)
        {
            this.ram = RAM;
        }
        public override string MostrarVisor()
        {
            return ($"{base.id} - {base.marca} - {base.modelo} - {base.cantidad}Un - ${base.precioUnitario} - {this.pulgadas}In - {this.almacenamiento}Gb ROM - {this.ram}Gb ram");
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine($"PULGADAS: {this.pulgadas}");
            sb.AppendLine($"ALMACENAMIENTO: { this.almacenamiento}");
            sb.AppendLine($"CANTIDAD DE CAMARAS: { this.cantCamaras}");
            sb.AppendLine($"RAM: {this.ram}");          
            return sb.ToString();
        }
        
    }
}
