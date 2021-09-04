using Domain;
using Domain.Enum;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion1
{
	public partial class Form1 : Form
	{
		Empleado Empleado;
		EmpleadoModel model;
		public Form1()
		{
			model = new EmpleadoModel();
			Empleado = new Empleado();
			InitializeComponent();
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			
			string dni, nombres, apellidos;
			decimal salario;
			int id = 0;
			id++;
			dni = txtDNI.Text;
			nombres = txtNombres.Text;
			apellidos = txtApellidos.Text;
			Sexo sexo = (Sexo)cmbSexo.SelectedIndex;
			if (string.IsNullOrWhiteSpace(cmbSexo.Text))
			{
				MessageBox.Show("Error, seleccionar sexo");
			}
		
			if (txtApellidos.Text.Length > 20 && txtNombres.Text.Length > 20)
			{
				MessageBox.Show("Demasiadas letras, solo 20 letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			string PatterDni = @"001-\d{6}-\d{4}[A-Z]{1}";
			Regex regex = new Regex(PatterDni);
			MatchCollection elmatch = regex.Matches(txtDNI.Text);
			if (string.IsNullOrWhiteSpace(txtDNI.Text))
			{
				MessageBox.Show("Error, DNI no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (elmatch.Count > 0)
			{

			}
			else
			{
				MessageBox.Show("Error, esto no es una dni", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (string.IsNullOrWhiteSpace(txtSueldo.Text))
			{
				MessageBox.Show("Error, no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else if (!decimal.TryParse(txtSueldo.Text, out salario))
			{
				MessageBox.Show($@"Esto {txtSueldo.Text} no es un salario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{
				salario = decimal.Parse(txtSueldo.Text);
			}

			Empleado = new Empleado
			{
				Nombres = nombres,
				Apellidos = apellidos,
				Sueldo = salario,
				DNI = dni,
				Sexo = sexo
				
			};
			MessageBox.Show($@"	Nombres: {Empleado.Nombres}
									Apellidos{Empleado.Apellidos}
									Dni: {Empleado.DNI}
									Salario: {Empleado.Sueldo}
									Sexo: {Empleado.Sexo}");

			model.add(Empleado);
			txtApellidos.Text = string.Empty;
			txtDNI.Text = string.Empty;
			txtNombres.Text = string.Empty;
			txtSueldo.Text = string.Empty;

		}

		private void btnPromedio_Click(object sender, EventArgs e)
		{
			MessageBox.Show($"Promedio: {model.promedio()}");
		}

		private void button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show($"Salario minimo: {model.sueldoMinimo()}");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			MessageBox.Show($"Salario Máximo: {model.SueldoMaximo()}");
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
