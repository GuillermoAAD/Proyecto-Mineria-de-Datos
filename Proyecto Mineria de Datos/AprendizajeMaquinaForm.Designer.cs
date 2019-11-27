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
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBoxKfold;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBoxKconjuntoDisjuntos;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TabControl tabControlClasificacion;
		private System.Windows.Forms.TabPage tabPageZeroR;
		private System.Windows.Forms.TabPage tabPageOneR;
		private System.Windows.Forms.TabPage tabPageNaiveBayes;
		private System.Windows.Forms.TabPage tabPageKMeans;
		private System.Windows.Forms.TabPage tabPageKNN;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Label label12;
		
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
			this.textBoxKfold = new System.Windows.Forms.TextBox();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.textBoxKconjuntoDisjuntos = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.tabControlClasificacion = new System.Windows.Forms.TabControl();
			this.tabPageZeroR = new System.Windows.Forms.TabPage();
			this.tabPageOneR = new System.Windows.Forms.TabPage();
			this.tabPageNaiveBayes = new System.Windows.Forms.TabPage();
			this.tabPageKMeans = new System.Windows.Forms.TabPage();
			this.tabPageKNN = new System.Windows.Forms.TabPage();
			this.label11 = new System.Windows.Forms.Label();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.label12 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.tabControlClasificacion.SuspendLayout();
			this.tabPageZeroR.SuspendLayout();
			this.tabPageOneR.SuspendLayout();
			this.tabPageNaiveBayes.SuspendLayout();
			this.tabPageKMeans.SuspendLayout();
			this.tabPageKNN.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(27, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 13);
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
			this.dataGridView1.Location = new System.Drawing.Point(254, 430);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.Size = new System.Drawing.Size(436, 131);
			this.dataGridView1.TabIndex = 1;
			// 
			// labelZeroR
			// 
			this.labelZeroR.AutoSize = true;
			this.labelZeroR.Location = new System.Drawing.Point(82, 16);
			this.labelZeroR.Name = "labelZeroR";
			this.labelZeroR.Size = new System.Drawing.Size(79, 13);
			this.labelZeroR.TabIndex = 2;
			this.labelZeroR.Text = "\"No hay clase\"";
			this.labelZeroR.Visible = false;
			// 
			// labelOneR
			// 
			this.labelOneR.AutoSize = true;
			this.labelOneR.Location = new System.Drawing.Point(82, 16);
			this.labelOneR.Name = "labelOneR";
			this.labelOneR.Size = new System.Drawing.Size(79, 13);
			this.labelOneR.TabIndex = 4;
			this.labelOneR.Text = "\"No hay clase\"";
			this.labelOneR.Visible = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(27, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "One-R:";
			this.label2.Visible = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(451, 63);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "Calcular";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Visible = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// labelNaiveBayes
			// 
			this.labelNaiveBayes.AutoSize = true;
			this.labelNaiveBayes.Location = new System.Drawing.Point(27, 126);
			this.labelNaiveBayes.Name = "labelNaiveBayes";
			this.labelNaiveBayes.Size = new System.Drawing.Size(123, 13);
			this.labelNaiveBayes.TabIndex = 7;
			this.labelNaiveBayes.Text = "\"instancia no ingresada\"";
			this.labelNaiveBayes.Visible = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(27, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(84, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Naïve Bayes:";
			this.label3.Visible = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(27, 36);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(373, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Ingrese los siguientes valores para los guientes atributos separados por coma:";
			this.label4.Visible = false;
			// 
			// textBoxValores
			// 
			this.textBoxValores.Location = new System.Drawing.Point(27, 65);
			this.textBoxValores.Name = "textBoxValores";
			this.textBoxValores.Size = new System.Drawing.Size(372, 20);
			this.textBoxValores.TabIndex = 9;
			this.textBoxValores.Text = "vhigh,low,4,more";
			this.textBoxValores.Visible = false;
			// 
			// labelEncabezados
			// 
			this.labelEncabezados.AutoSize = true;
			this.labelEncabezados.Location = new System.Drawing.Point(27, 49);
			this.labelEncabezados.Name = "labelEncabezados";
			this.labelEncabezados.Size = new System.Drawing.Size(133, 13);
			this.labelEncabezados.TabIndex = 10;
			this.labelEncabezados.Text = "ejemplo: atrib1,atrib2,atrib3";
			this.labelEncabezados.Visible = false;
			// 
			// radioButtonRegresion
			// 
			this.radioButtonRegresion.AutoSize = true;
			this.radioButtonRegresion.Location = new System.Drawing.Point(121, 25);
			this.radioButtonRegresion.Name = "radioButtonRegresion";
			this.radioButtonRegresion.Size = new System.Drawing.Size(73, 17);
			this.radioButtonRegresion.TabIndex = 12;
			this.radioButtonRegresion.TabStop = true;
			this.radioButtonRegresion.Text = "Regresión";
			this.radioButtonRegresion.UseVisualStyleBackColor = true;
			this.radioButtonRegresion.CheckedChanged += new System.EventHandler(this.RadioButtonRegresionCheckedChanged);
			// 
			// radioButtonClasificacion
			// 
			this.radioButtonClasificacion.AutoSize = true;
			this.radioButtonClasificacion.Location = new System.Drawing.Point(121, 3);
			this.radioButtonClasificacion.Name = "radioButtonClasificacion";
			this.radioButtonClasificacion.Size = new System.Drawing.Size(84, 17);
			this.radioButtonClasificacion.TabIndex = 11;
			this.radioButtonClasificacion.TabStop = true;
			this.radioButtonClasificacion.Text = "Clasificación";
			this.radioButtonClasificacion.UseVisualStyleBackColor = true;
			this.radioButtonClasificacion.CheckedChanged += new System.EventHandler(this.RadioButtonClasificacionCheckedChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(3, 15);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(112, 13);
			this.label5.TabIndex = 14;
			this.label5.Text = "El problema es de:";
			// 
			// panel1
			// 
			this.panel1.AutoSize = true;
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.radioButtonRegresion);
			this.panel1.Controls.Add(this.radioButtonClasificacion);
			this.panel1.Location = new System.Drawing.Point(10, 10);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(217, 46);
			this.panel1.TabIndex = 17;
			// 
			// panel2
			// 
			this.panel2.AutoSize = true;
			this.panel2.Controls.Add(this.textBoxKfold);
			this.panel2.Controls.Add(this.radioButton3);
			this.panel2.Controls.Add(this.radioButton4);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Location = new System.Drawing.Point(257, 10);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(437, 53);
			this.panel2.TabIndex = 19;
			// 
			// textBoxKfold
			// 
			this.textBoxKfold.Enabled = false;
			this.textBoxKfold.Location = new System.Drawing.Point(272, 27);
			this.textBoxKfold.Name = "textBoxKfold";
			this.textBoxKfold.Size = new System.Drawing.Size(60, 20);
			this.textBoxKfold.TabIndex = 15;
			this.textBoxKfold.Text = "1";
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.Checked = true;
			this.radioButton3.Location = new System.Drawing.Point(138, 27);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(128, 17);
			this.radioButton3.TabIndex = 12;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "K-fold cross-validation";
			this.radioButton3.UseVisualStyleBackColor = true;
			// 
			// radioButton4
			// 
			this.radioButton4.AutoSize = true;
			this.radioButton4.Enabled = false;
			this.radioButton4.Location = new System.Drawing.Point(138, 5);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(65, 17);
			this.radioButton4.TabIndex = 11;
			this.radioButton4.Text = "Hold-out";
			this.radioButton4.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(3, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(129, 26);
			this.label6.TabIndex = 14;
			this.label6.Text = "Metrica de validacion\r\nde desempeño:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 68);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(17, 13);
			this.label7.TabIndex = 21;
			this.label7.Text = "A:";
			this.label7.Visible = false;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label8.Location = new System.Drawing.Point(27, 96);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(646, 26);
			this.label8.TabIndex = 22;
			this.label8.Text = resources.GetString("label8.Text");
			this.label8.Visible = false;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(26, 46);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(102, 13);
			this.label9.TabIndex = 24;
			this.label9.Text = "Número de Clusters:";
			this.label9.Visible = false;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(27, 16);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(60, 13);
			this.label10.TabIndex = 23;
			this.label10.Text = "K-Means:";
			this.label10.Visible = false;
			// 
			// textBoxKconjuntoDisjuntos
			// 
			this.textBoxKconjuntoDisjuntos.Location = new System.Drawing.Point(128, 43);
			this.textBoxKconjuntoDisjuntos.Name = "textBoxKconjuntoDisjuntos";
			this.textBoxKconjuntoDisjuntos.Size = new System.Drawing.Size(60, 20);
			this.textBoxKconjuntoDisjuntos.TabIndex = 25;
			this.textBoxKconjuntoDisjuntos.Text = "1";
			this.textBoxKconjuntoDisjuntos.Visible = false;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(197, 41);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 26;
			this.button2.Text = "Calcular";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Visible = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// tabControlClasificacion
			// 
			this.tabControlClasificacion.Controls.Add(this.tabPageZeroR);
			this.tabControlClasificacion.Controls.Add(this.tabPageOneR);
			this.tabControlClasificacion.Controls.Add(this.tabPageNaiveBayes);
			this.tabControlClasificacion.Controls.Add(this.tabPageKMeans);
			this.tabControlClasificacion.Controls.Add(this.tabPageKNN);
			this.tabControlClasificacion.Controls.Add(this.tabPage1);
			this.tabControlClasificacion.Location = new System.Drawing.Point(10, 69);
			this.tabControlClasificacion.Name = "tabControlClasificacion";
			this.tabControlClasificacion.SelectedIndex = 0;
			this.tabControlClasificacion.Size = new System.Drawing.Size(684, 298);
			this.tabControlClasificacion.TabIndex = 0;
			// 
			// tabPageZeroR
			// 
			this.tabPageZeroR.Controls.Add(this.labelZeroR);
			this.tabPageZeroR.Controls.Add(this.label1);
			this.tabPageZeroR.Location = new System.Drawing.Point(4, 22);
			this.tabPageZeroR.Name = "tabPageZeroR";
			this.tabPageZeroR.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageZeroR.Size = new System.Drawing.Size(676, 272);
			this.tabPageZeroR.TabIndex = 0;
			this.tabPageZeroR.Text = "Zero-R";
			this.tabPageZeroR.UseVisualStyleBackColor = true;
			// 
			// tabPageOneR
			// 
			this.tabPageOneR.Controls.Add(this.labelOneR);
			this.tabPageOneR.Controls.Add(this.label2);
			this.tabPageOneR.Location = new System.Drawing.Point(4, 22);
			this.tabPageOneR.Name = "tabPageOneR";
			this.tabPageOneR.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageOneR.Size = new System.Drawing.Size(676, 272);
			this.tabPageOneR.TabIndex = 1;
			this.tabPageOneR.Text = "One-R";
			this.tabPageOneR.UseVisualStyleBackColor = true;
			// 
			// tabPageNaiveBayes
			// 
			this.tabPageNaiveBayes.Controls.Add(this.label4);
			this.tabPageNaiveBayes.Controls.Add(this.label8);
			this.tabPageNaiveBayes.Controls.Add(this.button1);
			this.tabPageNaiveBayes.Controls.Add(this.label7);
			this.tabPageNaiveBayes.Controls.Add(this.label3);
			this.tabPageNaiveBayes.Controls.Add(this.labelNaiveBayes);
			this.tabPageNaiveBayes.Controls.Add(this.labelEncabezados);
			this.tabPageNaiveBayes.Controls.Add(this.textBoxValores);
			this.tabPageNaiveBayes.Location = new System.Drawing.Point(4, 22);
			this.tabPageNaiveBayes.Name = "tabPageNaiveBayes";
			this.tabPageNaiveBayes.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageNaiveBayes.Size = new System.Drawing.Size(676, 272);
			this.tabPageNaiveBayes.TabIndex = 3;
			this.tabPageNaiveBayes.Text = "Naive Bayes";
			this.tabPageNaiveBayes.UseVisualStyleBackColor = true;
			// 
			// tabPageKMeans
			// 
			this.tabPageKMeans.Controls.Add(this.textBoxKconjuntoDisjuntos);
			this.tabPageKMeans.Controls.Add(this.button2);
			this.tabPageKMeans.Controls.Add(this.label10);
			this.tabPageKMeans.Controls.Add(this.label9);
			this.tabPageKMeans.Location = new System.Drawing.Point(4, 22);
			this.tabPageKMeans.Name = "tabPageKMeans";
			this.tabPageKMeans.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageKMeans.Size = new System.Drawing.Size(676, 272);
			this.tabPageKMeans.TabIndex = 4;
			this.tabPageKMeans.Text = "K-Means";
			this.tabPageKMeans.UseVisualStyleBackColor = true;
			// 
			// tabPageKNN
			// 
			this.tabPageKNN.Controls.Add(this.label11);
			this.tabPageKNN.Location = new System.Drawing.Point(4, 22);
			this.tabPageKNN.Name = "tabPageKNN";
			this.tabPageKNN.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageKNN.Size = new System.Drawing.Size(676, 272);
			this.tabPageKNN.TabIndex = 5;
			this.tabPageKNN.Text = "KNN (Clasificación)";
			this.tabPageKNN.UseVisualStyleBackColor = true;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(27, 16);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(120, 13);
			this.label11.TabIndex = 24;
			this.label11.Text = "KNN (clasificación):";
			this.label11.Visible = false;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.label12);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(676, 272);
			this.tabPage1.TabIndex = 6;
			this.tabPage1.Text = "KNN (Regresión)";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(27, 16);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(106, 13);
			this.label12.TabIndex = 25;
			this.label12.Text = "KNN (Regresión):";
			this.label12.Visible = false;
			// 
			// AprendizajeMaquinaForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(707, 545);
			this.Controls.Add(this.tabControlClasificacion);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AprendizajeMaquinaForm";
			this.Text = "Aprendizaje máquina";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.tabControlClasificacion.ResumeLayout(false);
			this.tabPageZeroR.ResumeLayout(false);
			this.tabPageZeroR.PerformLayout();
			this.tabPageOneR.ResumeLayout(false);
			this.tabPageOneR.PerformLayout();
			this.tabPageNaiveBayes.ResumeLayout(false);
			this.tabPageNaiveBayes.PerformLayout();
			this.tabPageKMeans.ResumeLayout(false);
			this.tabPageKMeans.PerformLayout();
			this.tabPageKNN.ResumeLayout(false);
			this.tabPageKNN.PerformLayout();
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
