using System.Text;

namespace Entidades
{
    [Serializable]
    public abstract class DispositivoElectronico
    {
        protected int id;
        protected int cantidad;
        protected string marca;
        protected string modelo;
        protected double precioUnitario;
        protected EFactura tipoFactura;

        public abstract string MostrarVisor();


        public DispositivoElectronico()
        {
            this.id = -1;
            this.cantidad = -1;
            this.precioUnitario = -1;
            this.tipoFactura = EFactura.A;
            this.marca = "NO SE INGRESO";
            this.modelo = "NO SE INGRESO";

        }
        public DispositivoElectronico(int id, int cantidad, double precio) : this()
        {
            this.id = id;
            this.cantidad = cantidad;
            this.precioUnitario = precio;

        }
        public DispositivoElectronico(int id, int cantidad, double precio, string marca, string modelo) : this(id, cantidad, precio)
        {
            this.marca = marca;
            this.modelo = modelo;
        }
        public DispositivoElectronico(int id, int cantidad, double precio,string modelo, string marca, EFactura tipoFactura) : this(id,cantidad, precio, marca, modelo)
        {
            this.tipoFactura = tipoFactura;
        }

        #region Getter y Seters
        public int Id
        {
            get { return id; }
            set { this.id = value; }
        }

        public int Cantidad
        {
            get { return this.cantidad; }
            set { this.cantidad = value;}
        }

        public string Marca
        {
            get { return this.marca; }
            set { this.marca = value; }
        }

        public string Modelo
        {
            get { return this.modelo; }
            set { this.modelo = value; }
        }
        public double PrecioUnitario
        {
            get { return this.precioUnitario; }
            set { this.precioUnitario = value;}
        }
        public EFactura TipoFactura
        {
            get { return this.tipoFactura; }
            set { this.tipoFactura = value; }
        }
        #endregion

        #region Sobrecarga de operadores

        public static bool operator ==(DispositivoElectronico a, DispositivoElectronico b)
        {
            return a.id == b.id && a.modelo == b.modelo;
        }
        public static bool operator !=(DispositivoElectronico a, DispositivoElectronico b)
        {
            return !(a == b);
        }
        #endregion 

        public override bool Equals(object? obj)
        {
            bool retorno = false;
            if (obj is DispositivoElectronico)
            {
                retorno = this == (DispositivoElectronico)obj;
            }
            return retorno;
        }

        public virtual string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"ID: {this.id}");
            sb.AppendLine($"CANTIDAD: {this.cantidad}");
            sb.AppendLine($"PRECIO UNITARIO: {this.precioUnitario.ToString()}");
            sb.AppendLine($"MARCA: {this.marca}");
            sb.AppendLine($"MODELO: {this.modelo}");
            sb.AppendLine($"FACTURA TIPO: {this.tipoFactura.ToString()}");
            return sb.ToString();
        }

    }

}