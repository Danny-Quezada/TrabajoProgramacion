
namespace Programacion1
{
	partial class Form1
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtNombres = new System.Windows.Forms.TextBox();
			this.txtApellidos = new System.Windows.Forms.TextBox();
			this.txtDNI = new System.Windows.Forms.TextBox();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.txtSueldo = new System.Windows.Forms.TextBox();
			this.btnPromedio = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.cmbSexo = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombres: ";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(26, 108);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Apellidos: ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(26, 175);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "DNI: ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(26, 230);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(46, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Sueldo: ";
			// 
			// txtNombres
			// 
			this.txtNombres.Location = new System.Drawing.Point(106, 33);
			this.txtNombres.Name = "txtNombres";
			this.txtNombres.Size = new System.Drawing.Size(124, 20);
			this.txtNombres.TabIndex = 4;
			// 
			// txtApellidos
			// 
			this.txtApellidos.Location = new System.Drawing.Point(106, 108);
			this.txtApellidos.Name = "txtApellidos";
			this.txtApellidos.Size = new System.Drawing.Size(124, 20);
			this.txtApellidos.TabIndex = 5;
			// 
			// txtDNI
			// 
			this.txtDNI.Location = new System.Drawing.Point(106, 175);
			this.txtDNI.Name = "txtDNI";
			this.txtDNI.Size = new System.Drawing.Size(124, 20);
			this.txtDNI.TabIndex = 6;
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(125, 3);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(75, 23);
			this.btnAceptar.TabIndex = 7;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// txtSueldo
			// 
			this.txtSueldo.Location = new System.Drawing.Point(106, 223);
			this.txtSueldo.Name = "txtSueldo";
			this.txtSueldo.Size = new System.Drawing.Size(124, 20);
			this.txtSueldo.TabIndex = 8;
			// 
			// btnPromedio
			// 
			this.btnPromedio.Location = new System.Drawing.Point(206, 3);
			this.btnPromedio.Name = "btnPromedio";
			this.btnPromedio.Size = new System.Drawing.Size(75, 23);
			this.btnPromedio.TabIndex = 9;
			this.btnPromedio.Text = "Promedio";
			this.btnPromedio.UseVisualStyleBackColor = true;
			this.btnPromedio.Click += new System.EventHandler(this.btnPromedio_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(287, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(127, 23);
			this.button1.TabIndex = 10;
			this.button1.Text = "Salario Minimo";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(3, 3);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(116, 23);
			this.button2.TabIndex = 11;
			this.button2.Text = "Salario Máximo";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.cmbSexo);
			this.groupBox1.Controls.Add(this.txtSueldo);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtNombres);
			this.groupBox1.Controls.Add(this.txtDNI);
			this.groupBox1.Controls.Add(this.txtApellidos);
			this.groupBox1.Location = new System.Drawing.Point(29, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(345, 320);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Datos Personales";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.button2);
			this.flowLayoutPanel1.Controls.Add(this.btnAceptar);
			this.flowLayoutPanel1.Controls.Add(this.btnPromedio);
			this.flowLayoutPanel1.Controls.Add(this.button1);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(29, 338);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(420, 100);
			this.flowLayoutPanel1.TabIndex = 13;
			// 
			// cmbSexo
			// 
			this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSexo.FormattingEnabled = true;
			this.cmbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
			this.cmbSexo.Location = new System.Drawing.Point(106, 262);
			this.cmbSexo.Name = "cmbSexo";
			this.cmbSexo.Size = new System.Drawing.Size(121, 21);
			this.cmbSexo.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(29, 269);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(31, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Sexo";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtNombres;
		private System.Windows.Forms.TextBox txtApellidos;
		private System.Windows.Forms.TextBox txtDNI;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.TextBox txtSueldo;
		private System.Windows.Forms.Button btnPromedio;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cmbSexo;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
	}
}

