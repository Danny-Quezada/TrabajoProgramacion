using Domain;
using Domain.Enum;
using Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion1
{
	public partial class FrmProducto : Form
	{
		Producto Producto;
		int i;
		ProductoModel model;
		public FrmProducto()
		{
			Producto = new Producto();
			model = new ProductoModel();

			InitializeComponent();
		}
		private void btnEnviar_Click(object sender, EventArgs e)
		{

			UnidadesMedidas Unidades = (UnidadesMedidas)CmbUnidades.SelectedIndex;

			string nombre = txtNombre.Text;
			string descripcion = txtDescripcion.Text;
			int cantidad, codigo;
			decimal precio;
			DateTime FechaDeCaducidad = new DateTime();

			if (string.IsNullOrWhiteSpace(CmbUnidades.Text) || string.IsNullOrWhiteSpace(txtCodigo.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text) || string.IsNullOrWhiteSpace(txtCantidad.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))

			{
				MessageBox.Show("No pueden estar vacío el código, Precio, Cantidad, Nombre, tiene que también seleccionar una unidad");
				return;
			}
			if (!int.TryParse(txtCodigo.Text, out codigo) || !int.TryParse(txtCantidad.Text, out cantidad) || !DateTime.TryParse(txtCaducidad.Text, out FechaDeCaducidad) || !decimal.TryParse(txtPrecio.Text, out precio))
			{
				MessageBox.Show("Error, no puede ser letras o se equivocó en la fecha: 00-00-0000");
				return;
			}
			else
			{

				cantidad = int.Parse(txtCantidad.Text);
				codigo = int.Parse(txtCodigo.Text);
				FechaDeCaducidad = DateTime.Parse(txtCaducidad.Text);
				precio = decimal.Parse(txtPrecio.Text);
			}

			Producto = new Producto()
			{
				Name = nombre,
				Descripcion = descripcion,
				Cantidad = cantidad,
				Precio = precio,
				Codigo = codigo,
				Caducidad = FechaDeCaducidad,
				Unidades = Unidades
			};
			LimpiarTextBox();
			model.add(Producto);
			lblOpciones.Visible = true;
			cmbOpciones.Visible = true;
			btnAceptar.Visible = false;

		}
		private void Verificar(int codigo, int cantidad, decimal precio, DateTime fechaDeCaducidad)
		{
			if (string.IsNullOrWhiteSpace(txtCodigo.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text) || string.IsNullOrWhiteSpace(txtCantidad.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
			{
				MessageBox.Show("No pueden estar vacío el código, Precio, Cantidad, Nombre");
				return;
			}
			else if (!int.TryParse(txtCodigo.Text, out codigo) || !int.TryParse(txtCantidad.Text, out cantidad) || !DateTime.TryParse(txtCaducidad.Text, out fechaDeCaducidad) || !decimal.TryParse(txtPrecio.Text, out precio))
			{
				MessageBox.Show("Error, no puede ser letras o se equivocó en la fecha: 00-00-0000");
				return;
			}
			else
			{

				cantidad = int.Parse(txtCantidad.Text);
				codigo = int.Parse(txtCodigo.Text);
				fechaDeCaducidad = DateTime.Parse(txtCaducidad.Text);
				precio = decimal.Parse(txtPrecio.Text);
			}

		}
		private void LimpiarTextBox()
		{
			txtCaducidad.Text = string.Empty;
			txtCantidad.Text = string.Empty;
			txtCodigo.Text = string.Empty;
			txtDescripcion.Text = string.Empty;
			txtNombre.Text = string.Empty;
			txtPrecio.Text = string.Empty;

		}

		private void button1_Click(object sender, EventArgs e) //Actualizar Producto
		{
			UnidadesMedidas u = (UnidadesMedidas)CmbUnidades.SelectedIndex;
			string name = txtNombre.Text, descripcion = txtCaducidad.Text;
			DateTime fechaDeCaducidad;
			int cantidad, codigo;
			decimal precio;
			if (string.IsNullOrWhiteSpace(CmbUnidades.Text) || !int.TryParse(txtCodigo.Text, out codigo) || !int.TryParse(txtCantidad.Text, out cantidad) || !DateTime.TryParse(txtCaducidad.Text, out fechaDeCaducidad) || !decimal.TryParse(txtPrecio.Text, out precio))
			{
				MessageBox.Show("Error, no puede ser letras o se equivocó en la fecha: 00-00-0000 o no seleccionó una Unidad");
				return;
			}


			else
			{

				cantidad = int.Parse(txtCantidad.Text);
				codigo = int.Parse(txtCodigo.Text);
				fechaDeCaducidad = DateTime.Parse(txtCaducidad.Text);
				precio = decimal.Parse(txtPrecio.Text);
				Producto = new Producto();
				Producto.Caducidad = fechaDeCaducidad;
				Producto.Cantidad = cantidad;
				Producto.Codigo = codigo;
				Producto.Name = name;
				Producto.Precio = precio;
				Producto.Descripcion = descripcion;
				Producto.Unidades = u;
				model.Actualizar(Producto);
				LimpiarTextBox();
				txtCodigo.Enabled = true;
				btnEnviar.Visible = true;
				txtBuscar.Text = string.Empty;
				button1.Visible = false;
				btnBorrar.Visible = false;
				CmbUnidades.SelectedItem = $"{string.Empty}";
			}

		}

		private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				int codigo;
				if (!int.TryParse(txtBuscar.Text, out codigo))
				{
					MessageBox.Show("Lo siento, solo número es el código");
				}
				else
				{
					codigo = int.Parse(txtBuscar.Text);
					buscar(codigo);
				}

			}
		}

		private void buscar(int codigo)
		{
			for (int i = 0; i < model.productos.Length; i++)
			{
				if (codigo == model.productos[i].Codigo)
				{
					txtCodigo.Text = $"{codigo}";
					txtCodigo.Enabled = false;
					btnEnviar.Visible = false;
					txtNombre.Text = $"{model.productos[i].Name}";
					txtPrecio.Text = $"{model.productos[i].Precio}";
					txtCantidad.Text = $"{model.productos[i].Cantidad}";
					txtCaducidad.Text = $"{model.productos[i].Caducidad}";
					txtDescripcion.Text = $"{model.productos[i].Descripcion}";
					CmbUnidades.SelectedItem = $"{model.productos[i].Unidades}";
					button1.Visible = true;
					btnBorrar.Visible = true;
				}

			}

		}

		private void txtBuscar_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnBorrar_Click(object sender, EventArgs e)
		{
			UnidadesMedidas u = (UnidadesMedidas)CmbUnidades.SelectedIndex;
			int codigo;
			int cantidad;
			decimal precio;
			string name = txtNombre.Text, descripcion = txtCaducidad.Text;
			DateTime fechaDeCaducidad;
			if (string.IsNullOrWhiteSpace(CmbUnidades.Text) || !int.TryParse(txtCodigo.Text, out codigo) || !int.TryParse(txtCantidad.Text, out cantidad) || !DateTime.TryParse(txtCaducidad.Text, out fechaDeCaducidad) || !decimal.TryParse(txtPrecio.Text, out precio))

			{
				MessageBox.Show("Error, no puede ser letras o se equivocó en la fecha: 00-00-0000 o no seleccionó una Unidad");
				return;
			}


			else
			{
				cantidad = int.Parse(txtCantidad.Text);
				codigo = int.Parse(txtCodigo.Text);
				fechaDeCaducidad = DateTime.Parse(txtCaducidad.Text);
				precio = decimal.Parse(txtPrecio.Text);
				Producto = new Producto()
				{
					Caducidad = fechaDeCaducidad,
					Cantidad = cantidad,
					Codigo = codigo,
					Name = name,
					Precio = precio,
					Descripcion = descripcion,
					Unidades = u

				};
				model.Delete(Producto);
				LimpiarTextBox();
				txtCodigo.Enabled = true;
				txtBuscar.Text = string.Empty;
				btnEnviar.Visible = true;
				button1.Visible = false;
				btnBorrar.Visible = false;
			}

		}

		private void txtCodigo_TextChanged(object sender, EventArgs e)
		{

		}

		private void FrmProducto_Load(object sender, EventArgs e)
		{

		}

		private void cmbOpciones_SelectedIndexChanged(object sender, EventArgs e)
		{


			if (cmbOpciones.SelectedIndex == 0)
			{
				btnAceptar.Visible = false;//
				Buscarla.Visible = true;
				cmbOpcionesUnidades.Visible = true;
				txtFechaCaducidad.Visible = false;
				lblFechaDeCaducidad.Visible = false;
				richte.Visible = false;

				lblPrMax.Visible = false;
				lblPrMin.Visible = false;
				txtPrecioMaximo.Visible = false;
				txtPrecioMinimo.Visible = false;
			}
			if (cmbOpciones.SelectedIndex == 1)
			{
				btnAceptar.Visible = false;//
				richte.Visible = false;
				cmbOpcionesUnidades.Visible = false;
				Buscarla.Visible = false;
				lblPrMax.Visible = false;
				lblPrMin.Visible = false;
				txtPrecioMaximo.Visible = false;
				txtPrecioMinimo.Visible = false;
				txtFechaCaducidad.Visible = true;
				lblFechaDeCaducidad.Visible = true;
			}
			if (cmbOpciones.SelectedIndex == 2)
			{
				btnAceptar.Visible = false;//
				richte.Visible = false;
				cmbOpcionesUnidades.Visible = false;
				Buscarla.Visible = false;
				lblPrMin.Visible = true;
				txtPrecioMinimo.Visible = true;
				txtFechaCaducidad.Visible = false;
				lblFechaDeCaducidad.Visible = false;

			}
			if (cmbOpciones.SelectedIndex == 3)
            {
				
				btnAceptar.Visible = true;
				richte.Visible = false;
				cmbOpcionesUnidades.Visible = false;
				Buscarla.Visible = false;
				lblFechaDeCaducidad.Visible = false;
				txtFechaCaducidad.Visible = false;
				lblFechaDeCaducidad.Visible = false;
				txtFechaCaducidad.Visible = false;
				lblPrMin.Visible = false;
				txtPrecioMinimo.Visible = false;
				lblPrMax.Visible = false;
				txtPrecioMaximo.Visible = false;
				btnAceptar.Visible = true;
            }
			if (cmbOpciones.SelectedIndex == 4)
            {
				btnAceptar.Visible = true;
				richte.Visible = false;
				cmbOpcionesUnidades.Visible = false;
				txtFechaCaducidad.Visible = false;
				lblFechaDeCaducidad.Visible = false;
				txtFechaCaducidad.Visible = false;
				lblPrMin.Visible = false;
				txtPrecioMinimo.Visible = false;
				lblPrMax.Visible = false;
				txtPrecioMaximo.Visible = false;
				Buscarla.Visible = false;
			}
		}

		private void cmbOpcionesUnidades_SelectedIndexChanged(object sender, EventArgs e)
		{
			UnidadesMedidas u;
			u = (UnidadesMedidas)cmbOpcionesUnidades.SelectedIndex;
			Producto[] Unidad = model.GetProductoByUnidadMedida(u);
			if (Unidad.Length == 0)
			{
				MessageBox.Show("No tienes Productos que tengan esta Unidad de medida");
				richte.Text = string.Empty;
				richte.Visible = false;
			}
			else
			{
				richte.Visible = true;
				if (richte.Text.Length == 0)
				{
					for (int i = 0; i < Unidad.Length; i++)
					{
						richte.Text += $"{Unidad[i].Tostring()}";
					}

				}
				else
				{
					richte.Text = string.Empty;
					for (int i = 0; i < Unidad.Length; i++)
					{

						richte.Text += $"{Unidad[i].Tostring()}";
					}
				}

			}

		}

		private void richte_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtFechaCaducidad_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				DateTime u = new DateTime();
				if (!DateTime.TryParse(txtFechaCaducidad.Text, out u))
				{
					MessageBox.Show("Escribir bien fecha: 00-00-0000");
					return;
				}
				else
				{
					u = DateTime.Parse(txtFechaCaducidad.Text);
					Producto[] Caducidad = model.GetProductoByCaducidad(u);
					if (Caducidad.Length == 0)
					{
						MessageBox.Show("No tienes Productos que tengan esta fecha de caducidad");
						richte.Text = string.Empty;
						richte.Visible = false;
					}
					else
					{
						richte.Visible = true;
						if (richte.Text.Length == 0)
						{
							for (int i = 0; i < Caducidad.Length; i++)
							{
								richte.Text += $"{Caducidad[i].Tostring()}";
							}

						}
						else
						{
							richte.Text = string.Empty;
							for (int i = 0; i < Caducidad.Length; i++)
							{

								richte.Text += $"{Caducidad[i].Tostring()}";
							}
						}

					}
				}
			}
		}

		private void txtPrecioMinimo_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtPrecioMinimo_KeyDown(object sender, KeyEventArgs e)
		{
			decimal minimo;
			if (e.KeyCode == Keys.Enter)
			{
				if (!decimal.TryParse(txtPrecioMinimo.Text, out minimo))
				{
					MessageBox.Show("Solamente números, por favor");
					return;
				}
				else
				{
					minimo = decimal.Parse(txtPrecioMinimo.Text);
					if (minimo < 0)
					{
						MessageBox.Show("No puede ser negativo");
						return;
					}
					else
					{
						txtPrecioMaximo.Visible = true;
						lblPrMax.Visible = true;
						txtPrecioMinimo.Visible = false;
						lblPrMin.Visible = false;
					}
				}
			}
		}

		private void txtPrecioMaximo_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtPrecioMaximo_KeyDown(object sender, KeyEventArgs e)
		{
			decimal maximo;
			if (e.KeyCode == Keys.Enter)
			{
				if (!decimal.TryParse(txtPrecioMaximo.Text, out maximo))
				{
					MessageBox.Show("Solamente números, por favor");
					return;
				}
				else
				{
					maximo = decimal.Parse(txtPrecioMaximo.Text);
					if (maximo < decimal.Parse(txtPrecioMinimo.Text))
					{
						MessageBox.Show("No puede ser menor que el precío minimo");
						
						return;
					}
					else
					{
						lblPrMin.Visible = true;
						lblPrMax.Visible = false;
						txtPrecioMinimo.Visible = true;
						txtPrecioMaximo.Visible = false;
						lblPrMax.Visible = false;
						Producto[] Rango = model.GetProductosByRangoPrecio(decimal.Parse(txtPrecioMinimo.Text), maximo);
						if (Rango.Length == 0)
						{
							MessageBox.Show("No tienes Productos que tengan este Rango");
							richte.Text = string.Empty;
							lblPrMax.Visible = false;
							richte.Visible = false;
						}
						else
						{
							richte.Visible = true;
							if (richte.Text.Length == 0)
							{
								for (int i = 0; i < Rango.Length; i++)
								{
									richte.Text += $"{Rango[i].Tostring()}";
								}

							}
							else
							{
								richte.Text = string.Empty;
								for (int i = 0; i < Rango.Length; i++)
								{

									richte.Text += $"{Rango[i].Tostring()}";
								}
							}

						}
					}

				}
			}
		}

        private void txtAceptar_Click(object sender, EventArgs e)
        {
			if (cmbOpciones.SelectedIndex == 3)
            {
	    			richte.Text = string.Empty;
				richte.Visible = true;
				Producto[] productoTem = model.OrdenarPrecio();
				for (int i = 0; i < productoTem.Length; i++)
				{
					if (productoTem[i] != null)
					{
						richte.Text += $"{productoTem[i].Tostring()}";
					}
				}
			}
			else if (cmbOpciones.SelectedIndex == 4)
            {
	    			richte.Text = string.Empty;
				richte.Visible = true;
				string productoTem = model.GetProductoAsJson(model.productos);
				richte.Text = productoTem;
            }
        }
    }
}
