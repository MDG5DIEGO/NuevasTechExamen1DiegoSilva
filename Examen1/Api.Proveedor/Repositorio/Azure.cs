using Api.Proveedor.Contrato.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Proveedor.Repositorio
{
    public class Azure: IRepositorios
    {
        private string cadenaConexion;
        private string tableName;

        public Azure(string cadena, string tabla)
        {
            this.cadenaConexion = cadena;
            this.tableName = tabla;
        }

        public Task<object> Actualizar<T>()
        {
            throw new NotImplementedException();
        }

        public Task<object> Eliminar<T>()
        {
            throw new NotImplementedException();
        }

        public Task<object> Insetar<T>()
        {
            throw new NotImplementedException();
        }

        public Task<T> Listar<T>()
        {
            throw new NotImplementedException();
        }
    }
}
