using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Proveedor.Contrato.Repositorios
{
    public interface IRepositorios
    {
        Task<T> Listar<T>();
        Task<object> Insetar<T>();
        Task<object> Actualizar<T>();
        Task<object> Eliminar<T>();

    }
}
