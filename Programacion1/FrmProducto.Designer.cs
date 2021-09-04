
namespace Programacion1
{
	partial class FrmProducto
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.txtCaducidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CmbUnidades = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cmbOpciones = new System.Windows.Forms.ComboBox();
            this.lblOpciones = new System.Windows.Forms.Label();
            this.cmbOpcionesUnidades = new System.Windows.Forms.ComboBox();
            this.Buscarla = new System.Windows.Forms.Label();
            this.richte = new System.Windows.Forms.RichTextBox();
            this.lblFechaDeCaducidad = new System.Windows.Forms.Label();
            this.txtFechaCaducidad = new System.Windows.Forms.TextBox();
            this.lblPrMin = new System.Windows.Forms.Label();
            this.lblPrMax = new System.Windows.Forms.Label();
            this.txtPrecioMinimo = new System.Windows.Forms.TextBox();
            this.txtPrecioMaximo = new System.Windows.Forms.TextBox();
            this.txtAceptar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Precio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Caducidad:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(93, 17);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 8;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(257, 158);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 9;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            // 
            // txtCaducidad
            // 
            this.txtCaducidad.Location = new System.Drawing.Point(93, 250);
            this.txtCaducidad.Name = "txtCaducidad";
            this.txtCaducidad.Size = new System.Drawing.Size(100, 20);
            this.txtCaducidad.TabIndex = 10;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(93, 163);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 11;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(93, 110);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 12;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(93, 61);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(271, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Buscar Producto";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(286, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Código:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(93, 198);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 17;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(84, 3);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 18;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(3, 3);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 21;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Visible = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.CmbUnidades);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.txtCaducidad);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 361);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del producto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 314);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Unidad de Medidas";
            // 
            // CmbUnidades
            // 
            this.CmbUnidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbUnidades.FormattingEnabled = true;
            this.CmbUnidades.Items.AddRange(new object[] {
            "Unidad",
            "Litros",
            "Mililitros",
            "Libras",
            "Gramos",
            "Kilogramo"});
            this.CmbUnidades.Location = new System.Drawing.Point(122, 306);
            this.CmbUnidades.Name = "CmbUnidades";
            this.CmbUnidades.Size = new System.Drawing.Size(121, 21);
            this.CmbUnidades.TabIndex = 18;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnBorrar);
            this.flowLayoutPanel1.Controls.Add(this.btnEnviar);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(32, 406);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(270, 32);
            this.flowLayoutPanel1.TabIndex = 23;
            // 
            // cmbOpciones
            // 
            this.cmbOpciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOpciones.FormattingEnabled = true;
            this.cmbOpciones.Items.AddRange(new object[] {
            "Mostrar Producto Por Unidad De Medida",
            "Mostrar Producto Por Caducidad",
            "Mostrar Producto Por Rango",
            "Ordenar Producto Por Precio",
            "Mostrar Producto Json"});
            this.cmbOpciones.Location = new System.Drawing.Point(406, 60);
            this.cmbOpciones.Name = "cmbOpciones";
            this.cmbOpciones.Size = new System.Drawing.Size(221, 21);
            this.cmbOpciones.TabIndex = 24;
            this.cmbOpciones.Visible = false;
            this.cmbOpciones.SelectedIndexChanged += new System.EventHandler(this.cmbOpciones_SelectedIndexChanged);
            // 
            // lblOpciones
            // 
            this.lblOpciones.AutoSize = true;
            this.lblOpciones.Location = new System.Drawing.Point(476, 44);
            this.lblOpciones.Name = "lblOpciones";
            this.lblOpciones.Size = new System.Drawing.Size(79, 13);
            this.lblOpciones.TabIndex = 25;
            this.lblOpciones.Text = "Más opciones: ";
            this.lblOpciones.Visible = false;
            // 
            // cmbOpcionesUnidades
            // 
            this.cmbOpcionesUnidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOpcionesUnidades.FormattingEnabled = true;
            this.cmbOpcionesUnidades.Items.AddRange(new object[] {
            "Unidad",
            "Litros",
            "Mililitros",
            "Libras",
            "Gramos",
            "Kilogramo"});
            this.cmbOpcionesUnidades.Location = new System.Drawing.Point(506, 99);
            this.cmbOpcionesUnidades.Name = "cmbOpcionesUnidades";
            this.cmbOpcionesUnidades.Size = new System.Drawing.Size(121, 21);
            this.cmbOpcionesUnidades.TabIndex = 20;
            this.cmbOpcionesUnidades.Visible = false;
            this.cmbOpcionesUnidades.SelectedIndexChanged += new System.EventHandler(this.cmbOpcionesUnidades_SelectedIndexChanged);
            // 
            // Buscarla
            // 
            this.Buscarla.AutoSize = true;
            this.Buscarla.Location = new System.Drawing.Point(444, 106);
            this.Buscarla.Name = "Buscarla";
            this.Buscarla.Size = new System.Drawing.Size(54, 13);
            this.Buscarla.TabIndex = 26;
            this.Buscarla.Text = "Buscarla: ";
            this.Buscarla.Visible = false;
            // 
            // richte
            // 
            this.richte.Location = new System.Drawing.Point(423, 173);
            this.richte.Name = "richte";
            this.richte.ReadOnly = true;
            this.richte.Size = new System.Drawing.Size(347, 223);
            this.richte.TabIndex = 27;
            this.richte.Text = "";
            this.richte.Visible = false;
            this.richte.TextChanged += new System.EventHandler(this.richte_TextChanged);
            // 
            // lblFechaDeCaducidad
            // 
            this.lblFechaDeCaducidad.AutoSize = true;
            this.lblFechaDeCaducidad.Location = new System.Drawing.Point(662, 44);
            this.lblFechaDeCaducidad.Name = "lblFechaDeCaducidad";
            this.lblFechaDeCaducidad.Size = new System.Drawing.Size(108, 13);
            this.lblFechaDeCaducidad.TabIndex = 28;
            this.lblFechaDeCaducidad.Text = "Fecha de caducidad:";
            this.lblFechaDeCaducidad.Visible = false;
            // 
            // txtFechaCaducidad
            // 
            this.txtFechaCaducidad.Location = new System.Drawing.Point(665, 60);
            this.txtFechaCaducidad.Name = "txtFechaCaducidad";
            this.txtFechaCaducidad.Size = new System.Drawing.Size(100, 20);
            this.txtFechaCaducidad.TabIndex = 29;
            this.txtFechaCaducidad.Visible = false;
            this.txtFechaCaducidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFechaCaducidad_KeyDown);
            // 
            // lblPrMin
            // 
            this.lblPrMin.AutoSize = true;
            this.lblPrMin.Location = new System.Drawing.Point(633, 92);
            this.lblPrMin.Name = "lblPrMin";
            this.lblPrMin.Size = new System.Drawing.Size(76, 13);
            this.lblPrMin.TabIndex = 30;
            this.lblPrMin.Text = "Precio Minimo:";
            this.lblPrMin.Visible = false;
            // 
            // lblPrMax
            // 
            this.lblPrMax.AutoSize = true;
            this.lblPrMax.Location = new System.Drawing.Point(633, 134);
            this.lblPrMax.Name = "lblPrMax";
            this.lblPrMax.Size = new System.Drawing.Size(79, 13);
            this.lblPrMax.TabIndex = 31;
            this.lblPrMax.Text = "Precio Máximo:";
            this.lblPrMax.Visible = false;
            // 
            // txtPrecioMinimo
            // 
            this.txtPrecioMinimo.Location = new System.Drawing.Point(719, 89);
            this.txtPrecioMinimo.Name = "txtPrecioMinimo";
            this.txtPrecioMinimo.Size = new System.Drawing.Size(73, 20);
            this.txtPrecioMinimo.TabIndex = 32;
            this.txtPrecioMinimo.Visible = false;
            this.txtPrecioMinimo.TextChanged += new System.EventHandler(this.txtPrecioMinimo_TextChanged);
            this.txtPrecioMinimo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrecioMinimo_KeyDown);
            // 
            // txtPrecioMaximo
            // 
            this.txtPrecioMaximo.Location = new System.Drawing.Point(719, 134);
            this.txtPrecioMaximo.Name = "txtPrecioMaximo";
            this.txtPrecioMaximo.Size = new System.Drawing.Size(69, 20);
            this.txtPrecioMaximo.TabIndex = 33;
            this.txtPrecioMaximo.Visible = false;
            this.txtPrecioMaximo.TextChanged += new System.EventHandler(this.txtPrecioMaximo_TextChanged);
            this.txtPrecioMaximo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrecioMaximo_KeyDown);
            // 
            // txtAceptar
            // 
            this.txtAceptar.Location = new System.Drawing.Point(552, 12);
            this.txtAceptar.Name = "txtAceptar";
            this.txtAceptar.Size = new System.Drawing.Size(75, 23);
            this.txtAceptar.TabIndex = 34;
            this.txtAceptar.Text = "Aceptar";
            this.txtAceptar.UseVisualStyleBackColor = true;
            this.txtAceptar.Click += new System.EventHandler(this.txtAceptar_Click);
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAceptar);
            this.Controls.Add(this.txtPrecioMaximo);
            this.Controls.Add(this.txtPrecioMinimo);
            this.Controls.Add(this.lblPrMax);
            this.Controls.Add(this.lblPrMin);
            this.Controls.Add(this.txtFechaCaducidad);
            this.Controls.Add(this.lblFechaDeCaducidad);
            this.Controls.Add(this.richte);
            this.Controls.Add(this.Buscarla);
            this.Controls.Add(this.cmbOpcionesUnidades);
            this.Controls.Add(this.lblOpciones);
            this.Controls.Add(this.cmbOpciones);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmProducto";
            this.Text = "FrmProducto";
            this.Load += new System.EventHandler(this.FrmProducto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.TextBox txtBuscar;
		private System.Windows.Forms.TextBox txtCaducidad;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.Button btnEnviar;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnBorrar;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox CmbUnidades;
		private System.Windows.Forms.ComboBox cmbOpciones;
		private System.Windows.Forms.Label lblOpciones;
		private System.Windows.Forms.ComboBox cmbOpcionesUnidades;
		private System.Windows.Forms.Label Buscarla;
		private System.Windows.Forms.RichTextBox richte;
		private System.Windows.Forms.Label lblFechaDeCaducidad;
		private System.Windows.Forms.TextBox txtFechaCaducidad;
		private System.Windows.Forms.Label lblPrMin;
		private System.Windows.Forms.Label lblPrMax;
		private System.Windows.Forms.TextBox txtPrecioMinimo;
		private System.Windows.Forms.TextBox txtPrecioMaximo;
        private System.Windows.Forms.Button txtAceptar;
    }
}