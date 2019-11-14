/*
 * Created by SharpDevelop.
 * User: Chu
 * Date: 13/10/2019
 * Time: 5:04 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Proyecto_Mineria_de_Datos
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem entradaDeDatosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cargarArchivoToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
		public System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem análisisEstadísticoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem univariableToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bivariableToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem limpiezaDeDatosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aprendizajeMáquinaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelNombreConjuntoDatos;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label labelCantidadInstancias;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label labelCantidadAtributos;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label labelNumeroValoresFaltantes;
		private System.Windows.Forms.Label labelProporcionValoresFaltantes;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.entradaDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cargarArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.análisisEstadísticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.univariableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bivariableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.limpiezaDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aprendizajeMáquinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.labelNombreConjuntoDatos = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.labelCantidadInstancias = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.labelCantidadAtributos = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.labelNumeroValoresFaltantes = new System.Windows.Forms.Label();
			this.labelProporcionValoresFaltantes = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.entradaDeDatosToolStripMenuItem,
			this.análisisEstadísticoToolStripMenuItem,
			this.limpiezaDeDatosToolStripMenuItem,
			this.aprendizajeMáquinaToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(892, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// entradaDeDatosToolStripMenuItem
			// 
			this.entradaDeDatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.cargarArchivoToolStripMenuItem,
			this.guardarToolStripMenuItem,
			this.guardarComoToolStripMenuItem,
			this.acercaDeToolStripMenuItem,
			this.salirToolStripMenuItem});
			this.entradaDeDatosToolStripMenuItem.Name = "entradaDeDatosToolStripMenuItem";
			this.entradaDeDatosToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
			this.entradaDeDatosToolStripMenuItem.Text = "Entrada de datos";
			// 
			// cargarArchivoToolStripMenuItem
			// 
			this.cargarArchivoToolStripMenuItem.Name = "cargarArchivoToolStripMenuItem";
			this.cargarArchivoToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.cargarArchivoToolStripMenuItem.Text = "Cargar archivo";
			this.cargarArchivoToolStripMenuItem.Click += new System.EventHandler(this.CargarArchivoToolStripMenuItemClick);
			// 
			// guardarToolStripMenuItem
			// 
			this.guardarToolStripMenuItem.Enabled = false;
			this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
			this.guardarToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.guardarToolStripMenuItem.Text = "Guardar";
			this.guardarToolStripMenuItem.Click += new System.EventHandler(this.GuardarToolStripMenuItemClick);
			// 
			// guardarComoToolStripMenuItem
			// 
			this.guardarComoToolStripMenuItem.Enabled = false;
			this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
			this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.guardarComoToolStripMenuItem.Text = "Guardar como...";
			this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.GuardarComoToolStripMenuItemClick);
			// 
			// acercaDeToolStripMenuItem
			// 
			this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
			this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.acercaDeToolStripMenuItem.Text = "Acerca de...";
			this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.AcercaDeToolStripMenuItemClick);
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.salirToolStripMenuItem.Text = "Salir";
			this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItemClick);
			// 
			// análisisEstadísticoToolStripMenuItem
			// 
			this.análisisEstadísticoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.univariableToolStripMenuItem,
			this.bivariableToolStripMenuItem});
			this.análisisEstadísticoToolStripMenuItem.Enabled = false;
			this.análisisEstadísticoToolStripMenuItem.Name = "análisisEstadísticoToolStripMenuItem";
			this.análisisEstadísticoToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
			this.análisisEstadísticoToolStripMenuItem.Text = " Análisis Estadístico";
			// 
			// univariableToolStripMenuItem
			// 
			this.univariableToolStripMenuItem.Name = "univariableToolStripMenuItem";
			this.univariableToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
			this.univariableToolStripMenuItem.Text = "Univariable";
			this.univariableToolStripMenuItem.Click += new System.EventHandler(this.UnivariableToolStripMenuItemClick);
			// 
			// bivariableToolStripMenuItem
			// 
			this.bivariableToolStripMenuItem.Name = "bivariableToolStripMenuItem";
			this.bivariableToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
			this.bivariableToolStripMenuItem.Text = "Bivariable";
			// 
			// limpiezaDeDatosToolStripMenuItem
			// 
			this.limpiezaDeDatosToolStripMenuItem.Enabled = false;
			this.limpiezaDeDatosToolStripMenuItem.Name = "limpiezaDeDatosToolStripMenuItem";
			this.limpiezaDeDatosToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
			this.limpiezaDeDatosToolStripMenuItem.Text = "Limpieza de datos";
			// 
			// aprendizajeMáquinaToolStripMenuItem
			// 
			this.aprendizajeMáquinaToolStripMenuItem.Enabled = false;
			this.aprendizajeMáquinaToolStripMenuItem.Name = "aprendizajeMáquinaToolStripMenuItem";
			this.aprendizajeMáquinaToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
			this.aprendizajeMáquinaToolStripMenuItem.Text = "Aprendizaje máquina";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
			this.dataGridView1.Location = new System.Drawing.Point(292, 24);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(600, 549);
			this.dataGridView1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(20, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(220, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Nombre del conjunto de datos:";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(19, 87);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(218, 24);
			this.label2.TabIndex = 4;
			this.label2.Text = "Cantidad de  instancias:";
			// 
			// labelNombreConjuntoDatos
			// 
			this.labelNombreConjuntoDatos.Location = new System.Drawing.Point(20, 63);
			this.labelNombreConjuntoDatos.Name = "labelNombreConjuntoDatos";
			this.labelNombreConjuntoDatos.Size = new System.Drawing.Size(217, 24);
			this.labelNombreConjuntoDatos.TabIndex = 5;
			this.labelNombreConjuntoDatos.Text = "No hay un conjunto de datos cargado.";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(20, 135);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(218, 24);
			this.label4.TabIndex = 6;
			this.label4.Text = "Cantidad de  atributos:";
			// 
			// labelCantidadInstancias
			// 
			this.labelCantidadInstancias.Location = new System.Drawing.Point(19, 111);
			this.labelCantidadInstancias.Name = "labelCantidadInstancias";
			this.labelCantidadInstancias.Size = new System.Drawing.Size(118, 24);
			this.labelCantidadInstancias.TabIndex = 7;
			this.labelCantidadInstancias.Text = "0";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(19, 183);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(218, 24);
			this.label6.TabIndex = 8;
			this.label6.Text = "Numero de valores faltantes:";
			// 
			// labelCantidadAtributos
			// 
			this.labelCantidadAtributos.Location = new System.Drawing.Point(20, 159);
			this.labelCantidadAtributos.Name = "labelCantidadAtributos";
			this.labelCantidadAtributos.Size = new System.Drawing.Size(118, 24);
			this.labelCantidadAtributos.TabIndex = 9;
			this.labelCantidadAtributos.Text = "0";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(19, 231);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(249, 27);
			this.label8.TabIndex = 10;
			this.label8.Text = "Proporcion de valores faltantes\r\nrespecto a los valores totales:";
			// 
			// labelNumeroValoresFaltantes
			// 
			this.labelNumeroValoresFaltantes.Location = new System.Drawing.Point(19, 207);
			this.labelNumeroValoresFaltantes.Name = "labelNumeroValoresFaltantes";
			this.labelNumeroValoresFaltantes.Size = new System.Drawing.Size(118, 24);
			this.labelNumeroValoresFaltantes.TabIndex = 11;
			this.labelNumeroValoresFaltantes.Text = "0";
			// 
			// labelProporcionValoresFaltantes
			// 
			this.labelProporcionValoresFaltantes.Location = new System.Drawing.Point(19, 268);
			this.labelProporcionValoresFaltantes.Name = "labelProporcionValoresFaltantes";
			this.labelProporcionValoresFaltantes.Size = new System.Drawing.Size(118, 23);
			this.labelProporcionValoresFaltantes.TabIndex = 12;
			this.labelProporcionValoresFaltantes.Text = "0%";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(892, 573);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.labelProporcionValoresFaltantes);
			this.Controls.Add(this.labelNumeroValoresFaltantes);
			this.Controls.Add(this.labelCantidadAtributos);
			this.Controls.Add(this.labelCantidadInstancias);
			this.Controls.Add(this.labelNombreConjuntoDatos);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Proyecto Mineria de Datos";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
