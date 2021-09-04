using Domain;
using Domain.Enum;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ProductoModel
    {
        public Producto[] productos { get; set; }

        public void add(Producto e)
		{
			if (e == null)
			{
				throw new ArgumentNullException("Error, no puede ser null");
			}
			if (productos == null)
			{
				productos = new Producto[1];
				productos[0] = e;
			}
			else
			{
				Producto[] tmp = new Producto[productos.Length + 1];
				Array.Copy(productos, tmp, productos.Length);
				tmp[tmp.Length - 1] = e;
				productos = tmp;
			}
		}
		public void Actualizar(Producto p)
		{
			for (int i = 0; i < productos.Length; i++)
			{
				if (p.Codigo == productos[i].Codigo)
				{
					productos[i] = p;
				}
			}
		}
		public void Delete(Producto p)
		{
			for (int i = 0; i < productos.Length; i++)
			{
				if (p.Codigo == productos[i].Codigo)
				{
					productos[i] = productos[productos.Length - 1];
					Producto[] tmp = new Producto[productos.Length - 1];
					Array.Copy(productos, tmp, productos.Length - 1);
					productos = tmp;

				}
			}
		}
		public Producto[] GetProductoByUnidadMedida(UnidadesMedidas u)
		{
			Producto[] UnidadMedidas=new Producto[0];
			for(int i=0; i<productos.Length; i++)
			{
				if (u == productos[i].Unidades)
				{
					if (UnidadMedidas == null)
					{
						UnidadMedidas = new Producto[1];
						UnidadMedidas[0] = productos[i];
						
					}
					else
					{
						Producto[] tmp = new Producto[UnidadMedidas.Length + 1];
						Array.Copy(UnidadMedidas, tmp, UnidadMedidas.Length);
						tmp[tmp.Length - 1] = productos[i];
						UnidadMedidas = tmp;
					
					}
				}	
			}
			return UnidadMedidas;
		}
		public Producto[] GetProductoByCaducidad(DateTime dt)
		{
			Producto[] Caducidad= new Producto[0];
			for (int i = 0; i < productos.Length; i++)
			{
				if (dt == productos[i].Caducidad)
				{
					if (Caducidad == null)
					{
						Caducidad= new Producto[1];
						Caducidad[0] = productos[i];

					}
					else
					{
						Producto[] tmp = new Producto[Caducidad.Length + 1];
						Array.Copy(Caducidad, tmp,Caducidad.Length);
						tmp[tmp.Length - 1] = productos[i];
						Caducidad = tmp;

					}
				}
			}
			return Caducidad;
		}
		public Producto[] GetProductosByRangoPrecio(decimal menor,decimal mayor)
		{
			Producto[] Rango = new Producto[0];
			for(int i=0; i<productos.Length; i++)
			{
				if ( productos[i].Precio>=menor && productos[i].Precio<=mayor)
				{

					if (Rango == null)
					{
						Rango = new Producto[1];
						Rango[0] = productos[i];

					}
					else
					{
						Producto[] tmp = new Producto[Rango.Length + 1];
						Array.Copy(Rango, tmp, Rango.Length);
						tmp[tmp.Length - 1] = productos[i];
						Rango= tmp;

					}
				}
			}
			return Rango;

		}
		public string GetProductoAsJson(Producto[] e)
		{
			string tmp = string.Empty;
			for (int i = 0; i < productos.Length; i++)
			{
				Producto productoTmp = new Producto()
				{
					Codigo = productos[i].Codigo,
					Name = productos[i].Name,
					Descripcion = productos[i].Descripcion,
					Cantidad = productos[i].Cantidad,
					Precio = productos[i].Precio,
					Caducidad = productos[i].Caducidad,
					Unidades = productos[i].Unidades
				};
				e = new Producto[productos.Length + 1];
				Array.Copy(productos, e, productos.Length);
				e[e.Length - 1] = productoTmp;
				e = productos;
			}
			for (int i = 0; i < productos.Length; i++)
			{
				tmp = JsonConvert.SerializeObject(e[i]) + "" + tmp;
			}
			return tmp;
		}
		public Producto[] OrdenarPrecio()
		{
			Producto e;
			Producto[] orden = new Producto[1];
			Array.Sort(productos, new Producto.CompararPrecio());

			for (int i = 0; i < productos.Length; i++)
			{
				e = new Producto()
				{
					Codigo = productos[i].Codigo,
					Name = productos[i].Name,
					Descripcion = productos[i].Descripcion,
					Cantidad = productos[i].Cantidad,
					Precio = productos[i].Precio,
					Caducidad = productos[i].Caducidad,
					Unidades = productos[i].Unidades
				};
				Producto[] tmp = new Producto[orden.Length + 1];
				Array.Copy(orden, tmp, orden.Length);
				tmp[tmp.Length - 1] = e;
				orden = tmp;
			}
			return orden;
		}
	}
	
}
