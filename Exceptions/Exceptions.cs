namespace Exceptions
{
    public class ProblemasSql : Exception
    {
        public ProblemasSql() : base("Hubo un problema con la base de datos SQL")
        {
        }
        public ProblemasSql(string mensaje) : base(mensaje)
        {
        }
    }
    public class NombreNoValido : Exception
    {
        public NombreNoValido() : base("Se ingreso un nombre no valido") { }
    }
    public class CuitNoValido : Exception
    {
        public CuitNoValido() : base("Se ingreso un cuit no valido") { }
    }
    public class UbicacionNoValido : Exception
    {
        public UbicacionNoValido() : base("Se ingreso una ubicacion no valida") { }
    }
    public class TipoNoValido : Exception
    {
        public TipoNoValido() : base("Se ingreso un tipo no valido") { }
    }
}