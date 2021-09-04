using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enum
{
	public enum UnidadesMedidas
	{
		Unidad,
		Litros,
		Mililitros,
		Libras,
		Gramos,
		Kilogramo
	}
	public enum Opciones
	{
		MostrarProductoPorUnidadDeMedida,
		MostrarProductoPorCaducidad,
		MostrarProductoPorRango,
		OrdenarProductoPorPrecio,
		MostrarProductoJson
	}
	public enum Sexo
	{
		Masculino,
		Femenino
	}
}
