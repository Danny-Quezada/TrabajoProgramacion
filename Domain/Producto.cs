using Domain.Enum;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Producto
    {
        [JsonProperty]
        public int Codigo { get; set; }
        [JsonProperty]
        public string Name { get; set; }
        [JsonProperty]
        public string Descripcion { get; set; }
        [JsonProperty]
        public int Cantidad { get; set; }
        [JsonProperty]
        public decimal Precio { get; set; }
        [JsonProperty]
        public DateTime Caducidad { get; set; }
        [JsonProperty]
        public UnidadesMedidas Unidades{get; set;}
        public string Tostring()
		{
            return $@"Nombre: {Name} 
Precio: {Precio}
Descripción: {Descripcion}
Cantidad: {Cantidad}
Caducidad: {Caducidad}
Unidad de Medida: {Unidades}
Código: {Codigo}

"; 
		}
        public class CompararPrecio: IComparer<Producto>
        {
            public int Compare(Producto x, Producto y)
            {
                if (x.Precio > y.Precio)
                {
                    return 1;
                }
                else if (x.Precio < y.Precio)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
