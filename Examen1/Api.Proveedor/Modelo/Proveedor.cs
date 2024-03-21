using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Api.Shared;
using Azure;
using Azure.Data.Tables;

namespace Api.Proveedor.Modelo
{
    internal class Proveedor : IIProveedor, ITableEntity
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string PartitionKey { get; set; }
        public string RowKey { get; set; }
        public DateTimeOffset? Timestamp { get; set; }
        public ETag ETag { get; set; }
    }
}