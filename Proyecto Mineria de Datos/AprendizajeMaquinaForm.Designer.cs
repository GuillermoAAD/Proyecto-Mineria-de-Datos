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
		private System.Windows.Forms.ComboBox atrclasCB;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button calcClasBTN;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox nInstClasTB;
		private System.Windows.Forms.NumericUpDown valorkNumUD;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label resultadoL;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label distL;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label resultadoNormL;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label labelKMeans;
		
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
			this.valorkNumUD = new System.Windows.Forms.NumericUpDown();
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
			this.labelKMeans = new System.Windows.Forms.Label();
			this.tabPageKNN = new System.Windows.Forms.TabPage();
			this.resultadoNormL = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.distL = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.resultadoL = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.calcClasBTN = new System.Windows.Forms.Button();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.nInstClasTB = new System.Windows.Forms.TextBox();
			this.atrclasCB = new System.Windows.Forms.ComboBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.valorkNumUD)).BeginInit();
			this.tabControlClasificacion.SuspendLayout();
			this.tabPageZeroR.SuspendLayout();
			this.tabPageOneR.SuspendLayout();
			this.tabPageNaiveBayes.SuspendLayout();
			this.tabPageKMeans.SuspendLayout();
			this.tabPageKNN.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
			this.panel2.Controls.Add(this.valorkNumUD);
			this.panel2.Controls.Add(this.radioButton3);
			this.panel2.Controls.Add(this.radioButton4);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Location = new System.Drawing.Point(257, 10);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(437, 53);
			this.panel2.TabIndex = 19;
			// 
			// valorkNumUD
			// 
			this.valorkNumUD.Location = new System.Drawing.Point(272, 27);
			this.valorkNumUD.Minimum = new decimal(new int[] {
			1,
			0,
			0,
			0});
			this.valorkNumUD.Name = "valorkNumUD";
			this.valorkNumUD.Size = new System.Drawing.Size(43, 20);
			this.valorkNumUD.TabIndex = 30;
			this.valorkNumUD.Value = new decimal(new int[] {
			1,
			0,
			0,
			0});
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
			this.tabControlClasificacion.Location = new System.Drawing.Point(10, 69);
			this.tabControlClasificacion.Name = "tabControlClasificacion";
			this.tabControlClasificacion.SelectedIndex = 0;
			this.tabControlClasificacion.Size = new System.Drawing.Size(684, 298);
			this.tabControlClasificacion.TabIndex = 1;
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
			this.tabPageKMeans.Controls.Add(this.labelKMeans);
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
			// labelKMeans
			// 
			this.labelKMeans.AutoSize = true;
			this.labelKMeans.Location = new System.Drawing.Point(27, 87);
			this.labelKMeans.Name = "labelKMeans";
			this.labelKMeans.Size = new System.Drawing.Size(102, 13);
			this.labelKMeans.TabIndex = 28;
			this.labelKMeans.Text = "Instancias X cluster:";
			this.labelKMeans.Visible = false;
			// 
			// tabPageKNN
			// 
			this.tabPageKNN.Controls.Add(this.resultadoNormL);
			this.tabPageKNN.Controls.Add(this.label12);
			this.tabPageKNN.Controls.Add(this.distL);
			this.tabPageKNN.Controls.Add(this.label21);
			this.tabPageKNN.Controls.Add(this.resultadoL);
			this.tabPageKNN.Controls.Add(this.label20);
			this.tabPageKNN.Controls.Add(this.label19);
			this.tabPageKNN.Controls.Add(this.calcClasBTN);
			this.tabPageKNN.Controls.Add(this.label14);
			this.tabPageKNN.Controls.Add(this.label15);
			this.tabPageKNN.Controls.Add(this.nInstClasTB);
			this.tabPageKNN.Controls.Add(this.atrclasCB);
			this.tabPageKNN.Controls.Add(this.label13);
			this.tabPageKNN.Controls.Add(this.label11);
			this.tabPageKNN.Location = new System.Drawing.Point(4, 22);
			this.tabPageKNN.Name = "tabPageKNN";
			this.tabPageKNN.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageKNN.Size = new System.Drawing.Size(676, 272);
			this.tabPageKNN.TabIndex = 5;
			this.tabPageKNN.Text = "kNN";
			this.tabPageKNN.UseVisualStyleBackColor = true;
			// 
			// resultadoNormL
			// 
			this.resultadoNormL.AutoSize = true;
			this.resultadoNormL.Location = new System.Drawing.Point(180, 119);
			this.resultadoNormL.Name = "resultadoNormL";
			this.resultadoNormL.Size = new System.Drawing.Size(10, 13);
			this.resultadoNormL.TabIndex = 36;
			this.resultadoNormL.Text = "-";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(177, 106);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(139, 13);
			this.label12.TabIndex = 35;
			this.label12.Text = "Resultado normalizado:";
			// 
			// distL
			// 
			this.distL.AutoSize = true;
			this.distL.Location = new System.Drawing.Point(27, 145);
			this.distL.Name = "distL";
			this.distL.Size = new System.Drawing.Size(10, 13);
			this.distL.TabIndex = 34;
			this.distL.Text = "-";
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label21.Location = new System.Drawing.Point(27, 132);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(64, 13);
			this.label21.TabIndex = 33;
			this.label21.Text = "Distancia:";
			// 
			// resultadoL
			// 
			this.resultadoL.AutoSize = true;
			this.resultadoL.Location = new System.Drawing.Point(27, 119);
			this.resultadoL.Name = "resultadoL";
			this.resultadoL.Size = new System.Drawing.Size(10, 13);
			this.resultadoL.TabIndex = 32;
			this.resultadoL.Text = "-";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label20.Location = new System.Drawing.Point(27, 106);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(68, 13);
			this.label20.TabIndex = 31;
			this.label20.Text = "Resultado:";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.label19.Location = new System.Drawing.Point(27, 93);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(281, 13);
			this.label19.TabIndex = 30;
			this.label19.Text = "NOTA: Debe incluirse la coma que separa al valor faltante";
			// 
			// calcClasBTN
			// 
			this.calcClasBTN.Location = new System.Drawing.Point(430, 68);
			this.calcClasBTN.Name = "calcClasBTN";
			this.calcClasBTN.Size = new System.Drawing.Size(75, 23);
			this.calcClasBTN.TabIndex = 29;
			this.calcClasBTN.Text = "Calcular";
			this.calcClasBTN.UseVisualStyleBackColor = true;
			this.calcClasBTN.Click += new System.EventHandler(this.CalcClasBTNClick);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(27, 41);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(394, 13);
			this.label14.TabIndex = 26;
			this.label14.Text = "Ingrese los valores para los atributos separados por coma exceptuando el faltante" +
	":";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(27, 54);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(136, 13);
			this.label15.TabIndex = 28;
			this.label15.Text = "ejemplo: atrib1,,atrib3,atrib4";
			// 
			// nInstClasTB
			// 
			this.nInstClasTB.Location = new System.Drawing.Point(27, 70);
			this.nInstClasTB.Name = "nInstClasTB";
			this.nInstClasTB.Size = new System.Drawing.Size(372, 20);
			this.nInstClasTB.TabIndex = 27;
			// 
			// atrclasCB
			// 
			this.atrclasCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.atrclasCB.FormattingEnabled = true;
			this.atrclasCB.Location = new System.Drawing.Point(491, 13);
			this.atrclasCB.Name = "atrclasCB";
			this.atrclasCB.Size = new System.Drawing.Size(179, 21);
			this.atrclasCB.TabIndex = 25;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(364, 16);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(121, 13);
			this.label13.TabIndex = 16;
			this.label13.Text = "Atributo a clasificar:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(27, 16);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(33, 13);
			this.label11.TabIndex = 24;
			this.label11.Text = "KNN";
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
			// AprendizajeMaquinaForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(707, 375);
			this.Controls.Add(this.tabControlClasificacion);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AprendizajeMaquinaForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Aprendizaje máquina";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.valorkNumUD)).EndInit();
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
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
