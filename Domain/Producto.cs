using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Producto
    {
        public int Codigo { get; set; }
        public string Name { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public DateTime Caducidad { get; set; }

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
    }
}
