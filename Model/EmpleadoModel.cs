using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public class EmpleadoModel
	{
		Empleado[] empleados;
		public void add(Empleado e)
		{

			if (e == null)
			{

				throw new ArgumentNullException("Error, no puede ser null");
			}
			else if (empleados == null)
			{
				empleados = new Empleado[1];
				empleados[0] = e;

			}
			else
			{


				Empleado[] tmp = new Empleado[empleados.Length + 1];
				Array.Copy(empleados, tmp, empleados.Length);
				empleados = new Empleado[tmp.Length];
				Array.Copy(tmp, empleados, tmp.Length - 1);
				empleados[tmp.Length - 1] = e;
			}
		}
		public decimal SueldoMaximo()
		{
			decimal max = decimal.MinValue;
			for (int i = 0; i < empleados.Length; i++)
			{
				if (max < empleados[i].Sueldo)
				{
					max = empleados[i].Sueldo;

				}
			}
			return max;
		}
		public decimal sueldoMinimo()
		{

			decimal min = decimal.MaxValue;
			for (int i = 0; i < empleados.Length; i++)
			{

				if (min > empleados[i].Sueldo)
				{
					min = empleados[i].Sueldo;

				}
			}
			return min;
		}
		public decimal promedio()
		{
			decimal promedio = 0;
			for (int i = 0; i < empleados.Length; i++)
			{
				promedio += empleados[i].Sueldo;

			}
			promedio = promedio / empleados.Length;
			return promedio;
		}
	}
}
