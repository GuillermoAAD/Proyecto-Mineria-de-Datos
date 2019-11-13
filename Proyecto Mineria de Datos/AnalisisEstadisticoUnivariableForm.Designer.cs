/*
 * Created by SharpDevelop.
 * User: Chu
 * Date: 11/11/2019
 * Time: 9:28 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Proyecto_Mineria_de_Datos
{
	partial class AnalisisEstadisticoUnivariableForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label labelMedia;
		private System.Windows.Forms.Label labelMediana;
		private System.Windows.Forms.Label labelDesviacionEstandar;
		private System.Windows.Forms.Label labelModa;
		private System.Windows.Forms.Label NOTA;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnalisisEstadisticoUnivariableForm));
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.labelMedia = new System.Windows.Forms.Label();
			this.labelMediana = new System.Windows.Forms.Label();
			this.labelDesviacionEstandar = new System.Windows.Forms.Label();
			this.labelModa = new System.Windows.Forms.Label();
			this.NOTA = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(12, 25);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 0;
			this.comboBox1.Text = "Elija un atributo";
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(207, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Escoge un atributo para realizar el analisis:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Media:";
			this.label2.Visible = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 98);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Mediana:";
			this.label3.Visible = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 140);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Moda:";
			this.label4.Visible = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 185);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(108, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "Desviación Estándar:";
			this.label5.Visible = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(362, 28);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(45, 13);
			this.label6.TabIndex = 6;
			this.label6.Text = "Boxplot:";
			this.label6.Visible = false;
			// 
			// labelMedia
			// 
			this.labelMedia.Location = new System.Drawing.Point(12, 75);
			this.labelMedia.Name = "labelMedia";
			this.labelMedia.Size = new System.Drawing.Size(100, 23);
			this.labelMedia.TabIndex = 7;
			this.labelMedia.Text = "0";
			this.labelMedia.Visible = false;
			// 
			// labelMediana
			// 
			this.labelMediana.Location = new System.Drawing.Point(12, 117);
			this.labelMediana.Name = "labelMediana";
			this.labelMediana.Size = new System.Drawing.Size(100, 23);
			this.labelMediana.TabIndex = 8;
			this.labelMediana.Text = "0";
			this.labelMediana.Visible = false;
			// 
			// labelDesviacionEstandar
			// 
			this.labelDesviacionEstandar.Location = new System.Drawing.Point(13, 207);
			this.labelDesviacionEstandar.Name = "labelDesviacionEstandar";
			this.labelDesviacionEstandar.Size = new System.Drawing.Size(100, 23);
			this.labelDesviacionEstandar.TabIndex = 10;
			this.labelDesviacionEstandar.Text = "0";
			this.labelDesviacionEstandar.Visible = false;
			// 
			// labelModa
			// 
			this.labelModa.Location = new System.Drawing.Point(13, 162);
			this.labelModa.Name = "labelModa";
			this.labelModa.Size = new System.Drawing.Size(100, 23);
			this.labelModa.TabIndex = 9;
			this.labelModa.Text = "0";
			this.labelModa.Visible = false;
			// 
			// NOTA
			// 
			this.NOTA.Location = new System.Drawing.Point(324, 116);
			this.NOTA.Name = "NOTA";
			this.NOTA.Size = new System.Drawing.Size(100, 23);
			this.NOTA.TabIndex = 11;
			this.NOTA.Text = "NOTA";
			// 
			// AnalisisEstadisticoUnivariableForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(592, 273);
			this.Controls.Add(this.NOTA);
			this.Controls.Add(this.labelDesviacionEstandar);
			this.Controls.Add(this.labelModa);
			this.Controls.Add(this.labelMediana);
			this.Controls.Add(this.labelMedia);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AnalisisEstadisticoUnivariableForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Análisis Estadístico Univariable";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
