using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
	public class Empleado
	{
		public string Nombres { get; set; }
		public string Apellidos { get; set; }
		public decimal Sueldo { get; set; }
		public string DNI { get; set; }
		public Sexo Sexo { get; set; }
	}
}
