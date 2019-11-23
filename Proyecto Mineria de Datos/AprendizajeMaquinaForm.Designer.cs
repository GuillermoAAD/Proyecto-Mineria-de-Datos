/*
 * Created by SharpDevelop.
 * User: Chu
 * Date: 20/11/2019
 * Time: 4:51 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Proyecto_Mineria_de_Datos
{
	partial class AprendizajeMaquinaForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label labelZeroR;
		private System.Windows.Forms.Label labelOneR;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label labelNaiveBayes;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxValores;
		private System.Windows.Forms.Label labelEncabezados;
		private System.Windows.Forms.RadioButton radioButtonClasificacion;
		private System.Windows.Forms.RadioButton radioButtonRegresion;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.DataGridView dataGridViewResultados;
		private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Resultado;
		private System.Windows.Forms.DataGridViewTextBoxColumn Exactitud;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sensibilidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn Especifidad;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AprendizajeMaquinaForm));
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.labelZeroR = new System.Windows.Forms.Label();
			this.labelOneR = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.labelNaiveBayes = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxValores = new System.Windows.Forms.TextBox();
			this.labelEncabezados = new System.Windows.Forms.Label();
			this.radioButtonRegresion = new System.Windows.Forms.RadioButton();
			this.radioButtonClasificacion = new System.Windows.Forms.RadioButton();
			this.label5 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.dataGridViewResultados = new System.Windows.Forms.DataGridView();
			this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Resultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Exactitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sensibilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Especifidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultados)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Zero-R:";
			this.label1.Visible = false;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.AllowUserToResizeColumns = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(418, 35);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.Size = new System.Drawing.Size(321, 180);
			this.dataGridView1.TabIndex = 1;
			// 
			// labelZeroR
			// 
			this.labelZeroR.AutoSize = true;
			this.labelZeroR.Location = new System.Drawing.Point(67, 80);
			this.labelZeroR.Name = "labelZeroR";
			this.labelZeroR.Size = new System.Drawing.Size(79, 13);
			this.labelZeroR.TabIndex = 2;
			this.labelZeroR.Text = "\"No hay clase\"";
			this.labelZeroR.Visible = false;
			// 
			// labelOneR
			// 
			this.labelOneR.AutoSize = true;
			this.labelOneR.Location = new System.Drawing.Point(67, 103);
			this.labelOneR.Name = "labelOneR";
			this.labelOneR.Size = new System.Drawing.Size(79, 13);
			this.labelOneR.TabIndex = 4;
			this.labelOneR.Text = "\"No hay clase\"";
			this.labelOneR.Visible = false;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(13, 103);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 19);
			this.label2.TabIndex = 3;
			this.label2.Text = "One-R:";
			this.label2.Visible = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(664, 325);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "Calcular";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// labelNaiveBayes
			// 
			this.labelNaiveBayes.AutoSize = true;
			this.labelNaiveBayes.Location = new System.Drawing.Point(13, 277);
			this.labelNaiveBayes.Name = "labelNaiveBayes";
			this.labelNaiveBayes.Size = new System.Drawing.Size(79, 13);
			this.labelNaiveBayes.TabIndex = 7;
			this.labelNaiveBayes.Text = "\"No hay clase\"";
			this.labelNaiveBayes.Visible = false;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 166);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 19);
			this.label3.TabIndex = 6;
			this.label3.Text = "Naïve Bayes:";
			this.label3.Visible = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 185);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(373, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Ingrese los siguientes valores para los guientes atributos separados por coma:";
			this.label4.Visible = false;
			// 
			// textBoxValores
			// 
			this.textBoxValores.Location = new System.Drawing.Point(13, 218);
			this.textBoxValores.Name = "textBoxValores";
			this.textBoxValores.Size = new System.Drawing.Size(382, 20);
			this.textBoxValores.TabIndex = 9;
			this.textBoxValores.Text = "sunny,cool,high,true";
			this.textBoxValores.Visible = false;
			// 
			// labelEncabezados
			// 
			this.labelEncabezados.AutoSize = true;
			this.labelEncabezados.Location = new System.Drawing.Point(13, 202);
			this.labelEncabezados.Name = "labelEncabezados";
			this.labelEncabezados.Size = new System.Drawing.Size(133, 13);
			this.labelEncabezados.TabIndex = 10;
			this.labelEncabezados.Text = "ejemplo: atrib1,atrib2,atrib3";
			this.labelEncabezados.Visible = false;
			// 
			// radioButtonRegresion
			// 
			this.radioButtonRegresion.Location = new System.Drawing.Point(113, 23);
			this.radioButtonRegresion.Name = "radioButtonRegresion";
			this.radioButtonRegresion.Size = new System.Drawing.Size(104, 24);
			this.radioButtonRegresion.TabIndex = 12;
			this.radioButtonRegresion.TabStop = true;
			this.radioButtonRegresion.Text = "Regresión";
			this.radioButtonRegresion.UseVisualStyleBackColor = true;
			this.radioButtonRegresion.CheckedChanged += new System.EventHandler(this.RadioButtonRegresionCheckedChanged);
			// 
			// radioButtonClasificacion
			// 
			this.radioButtonClasificacion.Location = new System.Drawing.Point(113, 0);
			this.radioButtonClasificacion.Name = "radioButtonClasificacion";
			this.radioButtonClasificacion.Size = new System.Drawing.Size(104, 24);
			this.radioButtonClasificacion.TabIndex = 11;
			this.radioButtonClasificacion.TabStop = true;
			this.radioButtonClasificacion.Text = "Clasificación";
			this.radioButtonClasificacion.UseVisualStyleBackColor = true;
			this.radioButtonClasificacion.CheckedChanged += new System.EventHandler(this.RadioButtonClasificacionCheckedChanged);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(3, 6);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 14;
			this.label5.Text = "El problema es de:";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.radioButtonRegresion);
			this.panel1.Controls.Add(this.radioButtonClasificacion);
			this.panel1.Location = new System.Drawing.Point(13, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(217, 52);
			this.panel1.TabIndex = 17;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.radioButton3);
			this.panel2.Controls.Add(this.radioButton4);
			this.panel2.Location = new System.Drawing.Point(178, 296);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(217, 52);
			this.panel2.TabIndex = 19;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(3, 6);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 14;
			this.label6.Text = "El problema es de:";
			// 
			// radioButton3
			// 
			this.radioButton3.Location = new System.Drawing.Point(113, 23);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(104, 24);
			this.radioButton3.TabIndex = 12;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "Regresión";
			this.radioButton3.UseVisualStyleBackColor = true;
			// 
			// radioButton4
			// 
			this.radioButton4.Location = new System.Drawing.Point(113, 0);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(104, 24);
			this.radioButton4.TabIndex = 11;
			this.radioButton4.TabStop = true;
			this.radioButton4.Text = "Clasificación";
			this.radioButton4.UseVisualStyleBackColor = true;
			// 
			// dataGridViewResultados
			// 
			this.dataGridViewResultados.AllowUserToAddRows = false;
			this.dataGridViewResultados.AllowUserToDeleteRows = false;
			this.dataGridViewResultados.AllowUserToOrderColumns = true;
			this.dataGridViewResultados.AllowUserToResizeColumns = false;
			this.dataGridViewResultados.AllowUserToResizeRows = false;
			this.dataGridViewResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridViewResultados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridViewResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.Modelo,
			this.Resultado,
			this.Exactitud,
			this.Sensibilidad,
			this.Especifidad});
			this.dataGridViewResultados.Location = new System.Drawing.Point(428, 239);
			this.dataGridViewResultados.Name = "dataGridViewResultados";
			this.dataGridViewResultados.RowHeadersVisible = false;
			this.dataGridViewResultados.Size = new System.Drawing.Size(321, 86);
			this.dataGridViewResultados.TabIndex = 20;
			// 
			// Modelo
			// 
			this.Modelo.HeaderText = "Modelo";
			this.Modelo.Name = "Modelo";
			this.Modelo.Width = 67;
			// 
			// Resultado
			// 
			this.Resultado.HeaderText = "Resultado";
			this.Resultado.Name = "Resultado";
			this.Resultado.Width = 80;
			// 
			// Exactitud
			// 
			this.Exactitud.HeaderText = "Exactitud";
			this.Exactitud.Name = "Exactitud";
			this.Exactitud.Width = 76;
			// 
			// Sensibilidad
			// 
			this.Sensibilidad.HeaderText = "Sensibilidad";
			this.Sensibilidad.Name = "Sensibilidad";
			this.Sensibilidad.Width = 88;
			// 
			// Especifidad
			// 
			this.Especifidad.HeaderText = "Especifidad";
			this.Especifidad.Name = "Especifidad";
			this.Especifidad.Width = 87;
			// 
			// AprendizajeMaquinaForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(751, 360);
			this.Controls.Add(this.dataGridViewResultados);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.labelEncabezados);
			this.Controls.Add(this.textBoxValores);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.labelNaiveBayes);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.labelOneR);
			this.Controls.Add(this.labelZeroR);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AprendizajeMaquinaForm";
			this.Text = "Aprendizaje máquina";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultados)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
