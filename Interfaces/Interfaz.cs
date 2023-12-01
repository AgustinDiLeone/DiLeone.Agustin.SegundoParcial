using System.Reflection.Metadata;
namespace Interfaces
{
    /// <summary>
    /// Interfaz para usar eventos cuando se haga algun CUD 
    /// ya sea de dispositivo o clientes
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IEventosConfirmandoCUD<T>
    {
        void Agregado(T entidad);
        void Actualizado(T entidad);
        void Eliminado(T entidad);
    }
}