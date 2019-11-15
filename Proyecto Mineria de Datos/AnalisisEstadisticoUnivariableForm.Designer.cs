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
		private System.Windows.Forms.DataGridView dataGridViewTablaDeFrecuencias;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartBoxplot;
		private System.Windows.Forms.Label labelCuartil3;
		private System.Windows.Forms.Label labelCuartil1;
		private System.Windows.Forms.Label labelMax;
		private System.Windows.Forms.Label labelMin;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label15;
		
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
			this.dataGridViewTablaDeFrecuencias = new System.Windows.Forms.DataGridView();
			this.label7 = new System.Windows.Forms.Label();
			this.chartBoxplot = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.labelCuartil3 = new System.Windows.Forms.Label();
			this.labelCuartil1 = new System.Windows.Forms.Label();
			this.labelMax = new System.Windows.Forms.Label();
			this.labelMin = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTablaDeFrecuencias)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartBoxplot)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(283, 16);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(293, 21);
			this.comboBox1.TabIndex = 0;
			this.comboBox1.Text = "Elija un atributo";
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(252, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Escoge un atributo para realizar el analisis:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(15, 59);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Media:";
			this.label2.Visible = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(14, 104);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Mediana:";
			this.label3.Visible = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(14, 146);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(42, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Moda:";
			this.label4.Visible = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(14, 191);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(128, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "Desviación Estándar:";
			this.label5.Visible = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(363, 59);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(53, 13);
			this.label6.TabIndex = 6;
			this.label6.Text = "Boxplot:";
			this.label6.Visible = false;
			// 
			// labelMedia
			// 
			this.labelMedia.Location = new System.Drawing.Point(14, 81);
			this.labelMedia.Name = "labelMedia";
			this.labelMedia.Size = new System.Drawing.Size(100, 23);
			this.labelMedia.TabIndex = 7;
			this.labelMedia.Text = "0";
			this.labelMedia.Visible = false;
			// 
			// labelMediana
			// 
			this.labelMediana.Location = new System.Drawing.Point(14, 123);
			this.labelMediana.Name = "labelMediana";
			this.labelMediana.Size = new System.Drawing.Size(100, 23);
			this.labelMediana.TabIndex = 8;
			this.labelMediana.Text = "0";
			this.labelMediana.Visible = false;
			// 
			// labelDesviacionEstandar
			// 
			this.labelDesviacionEstandar.Location = new System.Drawing.Point(14, 213);
			this.labelDesviacionEstandar.Name = "labelDesviacionEstandar";
			this.labelDesviacionEstandar.Size = new System.Drawing.Size(100, 23);
			this.labelDesviacionEstandar.TabIndex = 10;
			this.labelDesviacionEstandar.Text = "0";
			this.labelDesviacionEstandar.Visible = false;
			// 
			// labelModa
			// 
			this.labelModa.Location = new System.Drawing.Point(14, 168);
			this.labelModa.Name = "labelModa";
			this.labelModa.Size = new System.Drawing.Size(100, 23);
			this.labelModa.TabIndex = 9;
			this.labelModa.Text = "0";
			this.labelModa.Visible = false;
			// 
			// dataGridViewTablaDeFrecuencias
			// 
			this.dataGridViewTablaDeFrecuencias.AllowUserToAddRows = false;
			this.dataGridViewTablaDeFrecuencias.AllowUserToDeleteRows = false;
			this.dataGridViewTablaDeFrecuencias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewTablaDeFrecuencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewTablaDeFrecuencias.Location = new System.Drawing.Point(13, 86);
			this.dataGridViewTablaDeFrecuencias.Name = "dataGridViewTablaDeFrecuencias";
			this.dataGridViewTablaDeFrecuencias.ReadOnly = true;
			this.dataGridViewTablaDeFrecuencias.RowHeadersVisible = false;
			this.dataGridViewTablaDeFrecuencias.Size = new System.Drawing.Size(567, 318);
			this.dataGridViewTablaDeFrecuencias.TabIndex = 12;
			this.dataGridViewTablaDeFrecuencias.Visible = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(228, 59);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(131, 13);
			this.label7.TabIndex = 13;
			this.label7.Text = "Tabla de frecuencias:";
			this.label7.Visible = false;
			// 
			// chartBoxplot
			// 
			this.chartBoxplot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			chartArea1.Name = "ChartArea1";
			this.chartBoxplot.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chartBoxplot.Legends.Add(legend1);
			this.chartBoxplot.Location = new System.Drawing.Point(198, 86);
			this.chartBoxplot.Name = "chartBoxplot";
			this.chartBoxplot.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.BoxPlot;
			series1.Legend = "Legend1";
			series1.Name = "s1";
			series1.YValuesPerPoint = 6;
			this.chartBoxplot.Series.Add(series1);
			this.chartBoxplot.Size = new System.Drawing.Size(381, 318);
			this.chartBoxplot.TabIndex = 14;
			this.chartBoxplot.Text = "chart1";
			this.chartBoxplot.Visible = false;
			// 
			// labelCuartil3
			// 
			this.labelCuartil3.Location = new System.Drawing.Point(14, 390);
			this.labelCuartil3.Name = "labelCuartil3";
			this.labelCuartil3.Size = new System.Drawing.Size(100, 23);
			this.labelCuartil3.TabIndex = 22;
			this.labelCuartil3.Text = "0";
			this.labelCuartil3.Visible = false;
			// 
			// labelCuartil1
			// 
			this.labelCuartil1.Location = new System.Drawing.Point(14, 345);
			this.labelCuartil1.Name = "labelCuartil1";
			this.labelCuartil1.Size = new System.Drawing.Size(100, 23);
			this.labelCuartil1.TabIndex = 21;
			this.labelCuartil1.Text = "0";
			this.labelCuartil1.Visible = false;
			// 
			// labelMax
			// 
			this.labelMax.Location = new System.Drawing.Point(14, 300);
			this.labelMax.Name = "labelMax";
			this.labelMax.Size = new System.Drawing.Size(100, 23);
			this.labelMax.TabIndex = 20;
			this.labelMax.Text = "0";
			this.labelMax.Visible = false;
			// 
			// labelMin
			// 
			this.labelMin.Location = new System.Drawing.Point(14, 258);
			this.labelMin.Name = "labelMin";
			this.labelMin.Size = new System.Drawing.Size(100, 23);
			this.labelMin.TabIndex = 19;
			this.labelMin.Text = "0";
			this.labelMin.Visible = false;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(14, 368);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(88, 13);
			this.label12.TabIndex = 18;
			this.label12.Text = "Tercer Cuartil:";
			this.label12.Visible = false;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(14, 323);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(86, 13);
			this.label13.TabIndex = 17;
			this.label13.Text = "Primer Cuartil:";
			this.label13.Visible = false;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(14, 281);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(53, 13);
			this.label11.TabIndex = 16;
			this.label11.Text = "Máximo:";
			this.label11.Visible = false;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(14, 236);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(52, 13);
			this.label15.TabIndex = 15;
			this.label15.Text = "Mínimo:";
			this.label15.Visible = false;
			// 
			// AnalisisEstadisticoUnivariableForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(592, 416);
			this.Controls.Add(this.labelCuartil3);
			this.Controls.Add(this.labelCuartil1);
			this.Controls.Add(this.labelMax);
			this.Controls.Add(this.labelMin);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.chartBoxplot);
			this.Controls.Add(this.label7);
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
			this.Controls.Add(this.dataGridViewTablaDeFrecuencias);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AnalisisEstadisticoUnivariableForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Análisis Estadístico Univariable";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTablaDeFrecuencias)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartBoxplot)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
