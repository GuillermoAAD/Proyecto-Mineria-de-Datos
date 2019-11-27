/*
 * Creado por SharpDevelop.
 * Usuario: Axel
 * Fecha: 24/11/2019
 * Hora: 04:43 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Proyecto_Mineria_de_Datos
{
	partial class transformacionDatos
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ComboBox atributoCB;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton minmaxRB;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RadioButton zscoreRB;
		private System.Windows.Forms.Label maximoactL;
		private System.Windows.Forms.Label minactL;
		private System.Windows.Forms.Label valorMaxL;
		private System.Windows.Forms.Label valorMinL;
		private System.Windows.Forms.Button aceptarBTN;
		private System.Windows.Forms.Label nuevoMaxL;
		private System.Windows.Forms.Label nuevoMinL;
		private System.Windows.Forms.TextBox nuevoMinTB;
		private System.Windows.Forms.TextBox nuevoMaxTB;
		private System.Windows.Forms.Label utilizarL;
		private System.Windows.Forms.ComboBox desviacionCB;
		private System.Windows.Forms.Label noexisL;
		private System.Windows.Forms.Label desvEstL;
		private System.Windows.Forms.Label desvMedL;
		private System.Windows.Forms.Label valorDesvEstL;
		private System.Windows.Forms.Label valorDesvMedL;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(transformacionDatos));
			this.atributoCB = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.minmaxRB = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.zscoreRB = new System.Windows.Forms.RadioButton();
			this.maximoactL = new System.Windows.Forms.Label();
			this.minactL = new System.Windows.Forms.Label();
			this.valorMaxL = new System.Windows.Forms.Label();
			this.valorMinL = new System.Windows.Forms.Label();
			this.aceptarBTN = new System.Windows.Forms.Button();
			this.nuevoMaxL = new System.Windows.Forms.Label();
			this.nuevoMinL = new System.Windows.Forms.Label();
			this.nuevoMinTB = new System.Windows.Forms.TextBox();
			this.nuevoMaxTB = new System.Windows.Forms.TextBox();
			this.utilizarL = new System.Windows.Forms.Label();
			this.desviacionCB = new System.Windows.Forms.ComboBox();
			this.noexisL = new System.Windows.Forms.Label();
			this.desvEstL = new System.Windows.Forms.Label();
			this.desvMedL = new System.Windows.Forms.Label();
			this.valorDesvEstL = new System.Windows.Forms.Label();
			this.valorDesvMedL = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// atributoCB
			// 
			this.atributoCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.atributoCB.Enabled = false;
			this.atributoCB.FormattingEnabled = true;
			this.atributoCB.Location = new System.Drawing.Point(138, 12);
			this.atributoCB.Name = "atributoCB";
			this.atributoCB.Size = new System.Drawing.Size(175, 21);
			this.atributoCB.TabIndex = 7;
			this.atributoCB.SelectedIndexChanged += new System.EventHandler(this.AtributoCBSelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(118, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Escoge un atributo:";
			// 
			// minmaxRB
			// 
			this.minmaxRB.Location = new System.Drawing.Point(12, 71);
			this.minmaxRB.Name = "minmaxRB";
			this.minmaxRB.Size = new System.Drawing.Size(104, 24);
			this.minmaxRB.TabIndex = 8;
			this.minmaxRB.Text = "Min-Max";
			this.minmaxRB.UseVisualStyleBackColor = true;
			this.minmaxRB.CheckedChanged += new System.EventHandler(this.MinmaxRBCheckedChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(232, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "Selecciona el metodo de normalización:";
			// 
			// zscoreRB
			// 
			this.zscoreRB.Location = new System.Drawing.Point(169, 71);
			this.zscoreRB.Name = "zscoreRB";
			this.zscoreRB.Size = new System.Drawing.Size(104, 24);
			this.zscoreRB.TabIndex = 10;
			this.zscoreRB.Text = "Z-Score";
			this.zscoreRB.UseVisualStyleBackColor = true;
			this.zscoreRB.CheckedChanged += new System.EventHandler(this.ZscoreRBCheckedChanged);
			// 
			// maximoactL
			// 
			this.maximoactL.AutoSize = true;
			this.maximoactL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.maximoactL.Location = new System.Drawing.Point(12, 97);
			this.maximoactL.Name = "maximoactL";
			this.maximoactL.Size = new System.Drawing.Size(92, 13);
			this.maximoactL.TabIndex = 11;
			this.maximoactL.Text = "Máximo actual:";
			this.maximoactL.Visible = false;
			// 
			// minactL
			// 
			this.minactL.AutoSize = true;
			this.minactL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.minactL.Location = new System.Drawing.Point(12, 117);
			this.minactL.Name = "minactL";
			this.minactL.Size = new System.Drawing.Size(89, 13);
			this.minactL.TabIndex = 12;
			this.minactL.Text = "Minimo actual:";
			this.minactL.Visible = false;
			// 
			// valorMaxL
			// 
			this.valorMaxL.Location = new System.Drawing.Point(111, 97);
			this.valorMaxL.Name = "valorMaxL";
			this.valorMaxL.Size = new System.Drawing.Size(100, 13);
			this.valorMaxL.TabIndex = 13;
			this.valorMaxL.Text = "0";
			this.valorMaxL.Visible = false;
			// 
			// valorMinL
			// 
			this.valorMinL.Location = new System.Drawing.Point(111, 117);
			this.valorMinL.Name = "valorMinL";
			this.valorMinL.Size = new System.Drawing.Size(100, 17);
			this.valorMinL.TabIndex = 14;
			this.valorMinL.Text = "0";
			this.valorMinL.Visible = false;
			// 
			// aceptarBTN
			// 
			this.aceptarBTN.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.aceptarBTN.Enabled = false;
			this.aceptarBTN.Location = new System.Drawing.Point(238, 185);
			this.aceptarBTN.Name = "aceptarBTN";
			this.aceptarBTN.Size = new System.Drawing.Size(75, 23);
			this.aceptarBTN.TabIndex = 15;
			this.aceptarBTN.Text = "Aceptar";
			this.aceptarBTN.UseVisualStyleBackColor = true;
			this.aceptarBTN.Click += new System.EventHandler(this.AceptarBTNClick);
			// 
			// nuevoMaxL
			// 
			this.nuevoMaxL.AutoSize = true;
			this.nuevoMaxL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nuevoMaxL.Location = new System.Drawing.Point(169, 143);
			this.nuevoMaxL.Name = "nuevoMaxL";
			this.nuevoMaxL.Size = new System.Drawing.Size(93, 13);
			this.nuevoMaxL.TabIndex = 16;
			this.nuevoMaxL.Text = "Nuevo máximo:";
			this.nuevoMaxL.Visible = false;
			// 
			// nuevoMinL
			// 
			this.nuevoMinL.AutoSize = true;
			this.nuevoMinL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nuevoMinL.Location = new System.Drawing.Point(12, 143);
			this.nuevoMinL.Name = "nuevoMinL";
			this.nuevoMinL.Size = new System.Drawing.Size(90, 13);
			this.nuevoMinL.TabIndex = 17;
			this.nuevoMinL.Text = "Nuevo minimo:";
			this.nuevoMinL.Visible = false;
			// 
			// nuevoMinTB
			// 
			this.nuevoMinTB.Location = new System.Drawing.Point(12, 159);
			this.nuevoMinTB.Name = "nuevoMinTB";
			this.nuevoMinTB.Size = new System.Drawing.Size(118, 20);
			this.nuevoMinTB.TabIndex = 18;
			this.nuevoMinTB.Visible = false;
			this.nuevoMinTB.TextChanged += new System.EventHandler(this.NuevoMinTBTextChanged);
			// 
			// nuevoMaxTB
			// 
			this.nuevoMaxTB.Location = new System.Drawing.Point(169, 159);
			this.nuevoMaxTB.Name = "nuevoMaxTB";
			this.nuevoMaxTB.Size = new System.Drawing.Size(118, 20);
			this.nuevoMaxTB.TabIndex = 19;
			this.nuevoMaxTB.Visible = false;
			this.nuevoMaxTB.TextChanged += new System.EventHandler(this.NuevoMaxTBTextChanged);
			// 
			// utilizarL
			// 
			this.utilizarL.AutoSize = true;
			this.utilizarL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.utilizarL.Location = new System.Drawing.Point(12, 141);
			this.utilizarL.Name = "utilizarL";
			this.utilizarL.Size = new System.Drawing.Size(50, 13);
			this.utilizarL.TabIndex = 20;
			this.utilizarL.Text = "Utilizar:";
			this.utilizarL.Visible = false;
			// 
			// desviacionCB
			// 
			this.desviacionCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.desviacionCB.FormattingEnabled = true;
			this.desviacionCB.Location = new System.Drawing.Point(12, 158);
			this.desviacionCB.Name = "desviacionCB";
			this.desviacionCB.Size = new System.Drawing.Size(301, 21);
			this.desviacionCB.TabIndex = 21;
			this.desviacionCB.Visible = false;
			// 
			// noexisL
			// 
			this.noexisL.AutoSize = true;
			this.noexisL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.noexisL.Location = new System.Drawing.Point(32, 121);
			this.noexisL.Name = "noexisL";
			this.noexisL.Size = new System.Drawing.Size(259, 13);
			this.noexisL.TabIndex = 22;
			this.noexisL.Text = "No existen atributos númericos en el dataset";
			this.noexisL.Visible = false;
			// 
			// desvEstL
			// 
			this.desvEstL.AutoSize = true;
			this.desvEstL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.desvEstL.Location = new System.Drawing.Point(12, 97);
			this.desvEstL.Name = "desvEstL";
			this.desvEstL.Size = new System.Drawing.Size(127, 13);
			this.desvEstL.TabIndex = 23;
			this.desvEstL.Text = "Desviación estandar:";
			this.desvEstL.Visible = false;
			// 
			// desvMedL
			// 
			this.desvMedL.AutoSize = true;
			this.desvMedL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.desvMedL.Location = new System.Drawing.Point(12, 119);
			this.desvMedL.Name = "desvMedL";
			this.desvMedL.Size = new System.Drawing.Size(163, 13);
			this.desvMedL.TabIndex = 24;
			this.desvMedL.Text = "Desviación media absoluta:";
			this.desvMedL.Visible = false;
			// 
			// valorDesvEstL
			// 
			this.valorDesvEstL.Location = new System.Drawing.Point(141, 97);
			this.valorDesvEstL.Name = "valorDesvEstL";
			this.valorDesvEstL.Size = new System.Drawing.Size(100, 17);
			this.valorDesvEstL.TabIndex = 25;
			this.valorDesvEstL.Text = "0";
			this.valorDesvEstL.Visible = false;
			// 
			// valorDesvMedL
			// 
			this.valorDesvMedL.Location = new System.Drawing.Point(175, 119);
			this.valorDesvMedL.Name = "valorDesvMedL";
			this.valorDesvMedL.Size = new System.Drawing.Size(100, 17);
			this.valorDesvMedL.TabIndex = 26;
			this.valorDesvMedL.Text = "0";
			this.valorDesvMedL.Visible = false;
			// 
			// transformacionDatos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(325, 215);
			this.Controls.Add(this.valorDesvMedL);
			this.Controls.Add(this.valorDesvEstL);
			this.Controls.Add(this.desvMedL);
			this.Controls.Add(this.desvEstL);
			this.Controls.Add(this.noexisL);
			this.Controls.Add(this.desviacionCB);
			this.Controls.Add(this.utilizarL);
			this.Controls.Add(this.nuevoMaxTB);
			this.Controls.Add(this.nuevoMinTB);
			this.Controls.Add(this.nuevoMinL);
			this.Controls.Add(this.nuevoMaxL);
			this.Controls.Add(this.aceptarBTN);
			this.Controls.Add(this.valorMinL);
			this.Controls.Add(this.valorMaxL);
			this.Controls.Add(this.minactL);
			this.Controls.Add(this.maximoactL);
			this.Controls.Add(this.zscoreRB);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.minmaxRB);
			this.Controls.Add(this.atributoCB);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "transformacionDatos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Transformación de datos";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
