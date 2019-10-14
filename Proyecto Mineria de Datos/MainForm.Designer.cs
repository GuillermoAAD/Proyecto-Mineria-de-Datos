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
		private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem análisisEstadísticoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem univariableToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bivariableToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem limpiezaDeDatosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aprendizajeMáquinaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
		
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
			this.menuStrip1.SuspendLayout();
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
			this.menuStrip1.Size = new System.Drawing.Size(481, 24);
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
			this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
			this.guardarToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.guardarToolStripMenuItem.Text = "Guardar";
			this.guardarToolStripMenuItem.Click += new System.EventHandler(this.GuardarToolStripMenuItemClick);
			// 
			// guardarComoToolStripMenuItem
			// 
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
			this.análisisEstadísticoToolStripMenuItem.Name = "análisisEstadísticoToolStripMenuItem";
			this.análisisEstadísticoToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
			this.análisisEstadísticoToolStripMenuItem.Text = " Análisis Estadístico";
			// 
			// univariableToolStripMenuItem
			// 
			this.univariableToolStripMenuItem.Name = "univariableToolStripMenuItem";
			this.univariableToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
			this.univariableToolStripMenuItem.Text = "Univariable";
			// 
			// bivariableToolStripMenuItem
			// 
			this.bivariableToolStripMenuItem.Name = "bivariableToolStripMenuItem";
			this.bivariableToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
			this.bivariableToolStripMenuItem.Text = "Bivariable";
			// 
			// limpiezaDeDatosToolStripMenuItem
			// 
			this.limpiezaDeDatosToolStripMenuItem.Name = "limpiezaDeDatosToolStripMenuItem";
			this.limpiezaDeDatosToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
			this.limpiezaDeDatosToolStripMenuItem.Text = "Limpieza de datos";
			// 
			// aprendizajeMáquinaToolStripMenuItem
			// 
			this.aprendizajeMáquinaToolStripMenuItem.Name = "aprendizajeMáquinaToolStripMenuItem";
			this.aprendizajeMáquinaToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
			this.aprendizajeMáquinaToolStripMenuItem.Text = "Aprendizaje máquina";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(481, 273);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Proyecto Mineria de Datos";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
