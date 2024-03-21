using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Producto.Repositorio
{
    public class AzureStorageService
    {
        private string cadenaConexion;
        private string tableName;

        public AzureStorageService(string cadena, string tabla)
        {
            this.cadenaConexion = cadena;
            this.tableName = tabla;
        }
    }
}
