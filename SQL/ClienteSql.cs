using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL
{
    public class ClienteSql
    {
        public int id;
        public string nombre;
        public long cuit;
        public string ubicacion;
        public string tipo;

        public ClienteSql() { }
        public ClienteSql(int id, string nombre, long cuit, string ubicacion,  string tipo):this()
        { 
            this.id = id;
            this.nombre = nombre;
            this.cuit = cuit;
            this.ubicacion = ubicacion;
            this.tipo = tipo;
                                
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Cuit: {cuit}");
            sb.AppendLine($"Ubicacion: {ubicacion}");
            sb.AppendLine($"Tipo: {tipo}");
            return sb.ToString();
        }
    }
}
