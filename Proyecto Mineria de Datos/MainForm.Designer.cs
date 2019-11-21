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
		private System.Windows.Forms.TextBox comentarioTXT;
		private System.Windows.Forms.Label comentarioLa;
		public System.Windows.Forms.ComboBox atributoCB;
		private System.Windows.Forms.Label atributoL;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox tipoCB;
		private System.Windows.Forms.Label debugL;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox dominioTB;
		private System.Windows.Forms.ToolStripMenuItem llenarValoresFaltantesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem correcciónDeOutliersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem buscarYReemplazarPorAtributoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem detecciónToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem muestreoDeDatosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem transformaciónDeDatosToolStripMenuItem;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.DataGridView dataGridView3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DataGridView dataGridView2;
		
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
			this.llenarValoresFaltantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.correcciónDeOutliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.buscarYReemplazarPorAtributoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.detecciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.muestreoDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.transformaciónDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
			this.comentarioTXT = new System.Windows.Forms.TextBox();
			this.comentarioLa = new System.Windows.Forms.Label();
			this.atributoCB = new System.Windows.Forms.ComboBox();
			this.atributoL = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tipoCB = new System.Windows.Forms.ComboBox();
			this.debugL = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.dominioTB = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.dataGridView3 = new System.Windows.Forms.DataGridView();
			this.label7 = new System.Windows.Forms.Label();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
			this.bivariableToolStripMenuItem.Click += new System.EventHandler(this.BivariableToolStripMenuItemClick);
			// 
			// limpiezaDeDatosToolStripMenuItem
			// 
			this.limpiezaDeDatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.llenarValoresFaltantesToolStripMenuItem,
			this.correcciónDeOutliersToolStripMenuItem,
			this.buscarYReemplazarPorAtributoToolStripMenuItem,
			this.detecciónToolStripMenuItem,
			this.muestreoDeDatosToolStripMenuItem,
			this.transformaciónDeDatosToolStripMenuItem});
			this.limpiezaDeDatosToolStripMenuItem.Enabled = false;
			this.limpiezaDeDatosToolStripMenuItem.Name = "limpiezaDeDatosToolStripMenuItem";
			this.limpiezaDeDatosToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
			this.limpiezaDeDatosToolStripMenuItem.Text = "Limpieza de datos";
			// 
			// llenarValoresFaltantesToolStripMenuItem
			// 
			this.llenarValoresFaltantesToolStripMenuItem.Name = "llenarValoresFaltantesToolStripMenuItem";
			this.llenarValoresFaltantesToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
			this.llenarValoresFaltantesToolStripMenuItem.Text = "Llenar valores faltantes";
			this.llenarValoresFaltantesToolStripMenuItem.Click += new System.EventHandler(this.LlenarValoresFaltantesToolStripMenuItemClick);
			// 
			// correcciónDeOutliersToolStripMenuItem
			// 
			this.correcciónDeOutliersToolStripMenuItem.Name = "correcciónDeOutliersToolStripMenuItem";
			this.correcciónDeOutliersToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
			this.correcciónDeOutliersToolStripMenuItem.Text = "Corrección de outliers";
			// 
			// buscarYReemplazarPorAtributoToolStripMenuItem
			// 
			this.buscarYReemplazarPorAtributoToolStripMenuItem.Name = "buscarYReemplazarPorAtributoToolStripMenuItem";
			this.buscarYReemplazarPorAtributoToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
			this.buscarYReemplazarPorAtributoToolStripMenuItem.Text = "Buscar y reemplazar por atributo";
			// 
			// detecciónToolStripMenuItem
			// 
			this.detecciónToolStripMenuItem.Name = "detecciónToolStripMenuItem";
			this.detecciónToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
			this.detecciónToolStripMenuItem.Text = "Detección de errores tipográficos";
			// 
			// muestreoDeDatosToolStripMenuItem
			// 
			this.muestreoDeDatosToolStripMenuItem.Name = "muestreoDeDatosToolStripMenuItem";
			this.muestreoDeDatosToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
			this.muestreoDeDatosToolStripMenuItem.Text = "Muestreo de datos";
			// 
			// transformaciónDeDatosToolStripMenuItem
			// 
			this.transformaciónDeDatosToolStripMenuItem.Name = "transformaciónDeDatosToolStripMenuItem";
			this.transformaciónDeDatosToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
			this.transformaciónDeDatosToolStripMenuItem.Text = "Transformación de datos";
			// 
			// aprendizajeMáquinaToolStripMenuItem
			// 
			this.aprendizajeMáquinaToolStripMenuItem.Enabled = false;
			this.aprendizajeMáquinaToolStripMenuItem.Name = "aprendizajeMáquinaToolStripMenuItem";
			this.aprendizajeMáquinaToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
			this.aprendizajeMáquinaToolStripMenuItem.Text = "Aprendizaje máquina";
			this.aprendizajeMáquinaToolStripMenuItem.Click += new System.EventHandler(this.AprendizajeMáquinaToolStripMenuItemClick);
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(292, 24);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(600, 500);
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
			// comentarioTXT
			// 
			this.comentarioTXT.Enabled = false;
			this.comentarioTXT.Location = new System.Drawing.Point(20, 309);
			this.comentarioTXT.Multiline = true;
			this.comentarioTXT.Name = "comentarioTXT";
			this.comentarioTXT.Size = new System.Drawing.Size(248, 47);
			this.comentarioTXT.TabIndex = 13;
			this.comentarioTXT.TextChanged += new System.EventHandler(this.ComentarioTXTTextChanged);
			// 
			// comentarioLa
			// 
			this.comentarioLa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comentarioLa.Location = new System.Drawing.Point(20, 291);
			this.comentarioLa.Name = "comentarioLa";
			this.comentarioLa.Size = new System.Drawing.Size(220, 15);
			this.comentarioLa.TabIndex = 14;
			this.comentarioLa.Text = "Comentario:";
			// 
			// atributoCB
			// 
			this.atributoCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.atributoCB.Enabled = false;
			this.atributoCB.FormattingEnabled = true;
			this.atributoCB.Location = new System.Drawing.Point(20, 382);
			this.atributoCB.Name = "atributoCB";
			this.atributoCB.Size = new System.Drawing.Size(248, 21);
			this.atributoCB.TabIndex = 15;
			this.atributoCB.SelectedIndexChanged += new System.EventHandler(this.AtributoCBSelectedIndexChanged);
			// 
			// atributoL
			// 
			this.atributoL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.atributoL.Location = new System.Drawing.Point(20, 364);
			this.atributoL.Name = "atributoL";
			this.atributoL.Size = new System.Drawing.Size(220, 15);
			this.atributoL.TabIndex = 16;
			this.atributoL.Text = "Atributo:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(20, 415);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(220, 15);
			this.label3.TabIndex = 17;
			this.label3.Text = "Tipo:";
			// 
			// tipoCB
			// 
			this.tipoCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.tipoCB.Enabled = false;
			this.tipoCB.FormattingEnabled = true;
			this.tipoCB.Location = new System.Drawing.Point(20, 433);
			this.tipoCB.Name = "tipoCB";
			this.tipoCB.Size = new System.Drawing.Size(248, 21);
			this.tipoCB.TabIndex = 18;
			this.tipoCB.SelectedIndexChanged += new System.EventHandler(this.TipoCBSelectedIndexChanged);
			// 
			// debugL
			// 
			this.debugL.Location = new System.Drawing.Point(19, 538);
			this.debugL.Name = "debugL";
			this.debugL.Size = new System.Drawing.Size(100, 23);
			this.debugL.TabIndex = 19;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(20, 467);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(220, 15);
			this.label5.TabIndex = 20;
			this.label5.Text = "Dominio:";
			// 
			// dominioTB
			// 
			this.dominioTB.Enabled = false;
			this.dominioTB.Location = new System.Drawing.Point(20, 485);
			this.dominioTB.Multiline = true;
			this.dominioTB.Name = "dominioTB";
			this.dominioTB.Size = new System.Drawing.Size(248, 47);
			this.dominioTB.TabIndex = 21;
			this.dominioTB.TextChanged += new System.EventHandler(this.DominioTBTextChanged);
			// 
			// label9
			// 
			this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(526, 544);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(212, 13);
			this.label9.TabIndex = 31;
			this.label9.Text = "Celda que no cumple con el valor esperado";
			// 
			// dataGridView3
			// 
			this.dataGridView3.AllowUserToAddRows = false;
			this.dataGridView3.AllowUserToDeleteRows = false;
			this.dataGridView3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.dataGridView3.BackgroundColor = System.Drawing.Color.Red;
			this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView3.Location = new System.Drawing.Point(505, 542);
			this.dataGridView3.Name = "dataGridView3";
			this.dataGridView3.ReadOnly = true;
			this.dataGridView3.Size = new System.Drawing.Size(15, 15);
			this.dataGridView3.TabIndex = 30;
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(350, 544);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(119, 13);
			this.label7.TabIndex = 29;
			this.label7.Text = "Celda con valor faltante";
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToAddRows = false;
			this.dataGridView2.AllowUserToDeleteRows = false;
			this.dataGridView2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.dataGridView2.BackgroundColor = System.Drawing.Color.Orange;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(329, 542);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.ReadOnly = true;
			this.dataGridView2.Size = new System.Drawing.Size(15, 15);
			this.dataGridView2.TabIndex = 28;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(892, 573);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.dataGridView3);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.dominioTB);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.debugL);
			this.Controls.Add(this.tipoCB);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.atributoL);
			this.Controls.Add(this.atributoCB);
			this.Controls.Add(this.comentarioLa);
			this.Controls.Add(this.comentarioTXT);
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
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
