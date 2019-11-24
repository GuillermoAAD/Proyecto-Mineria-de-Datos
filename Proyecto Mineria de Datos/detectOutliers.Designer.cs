/*
 * Creado por SharpDevelop.
 * Usuario: Axel
 * Fecha: 22/11/2019
 * Hora: 10:05 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Proyecto_Mineria_de_Datos
{
	partial class detectOutliers
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox atributoCB;
		private System.Windows.Forms.Button aceptarBTN;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label cuartil3L;
		private System.Windows.Forms.Label cuartil1L;
		private System.Windows.Forms.RadioButton posibleRB;
		private System.Windows.Forms.ComboBox posibleCB;
		private System.Windows.Forms.RadioButton outlierRB;
		private System.Windows.Forms.ComboBox outlierCB;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label sugerenciaL;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label iqrL;
		private System.Windows.Forms.ComboBox sustituirCB;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label valorL;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(detectOutliers));
			this.label1 = new System.Windows.Forms.Label();
			this.atributoCB = new System.Windows.Forms.ComboBox();
			this.aceptarBTN = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cuartil1L = new System.Windows.Forms.Label();
			this.cuartil3L = new System.Windows.Forms.Label();
			this.posibleRB = new System.Windows.Forms.RadioButton();
			this.posibleCB = new System.Windows.Forms.ComboBox();
			this.outlierRB = new System.Windows.Forms.RadioButton();
			this.outlierCB = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.sugerenciaL = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.iqrL = new System.Windows.Forms.Label();
			this.sustituirCB = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.valorL = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(118, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Escoge un atributo:";
			// 
			// atributoCB
			// 
			this.atributoCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.atributoCB.Enabled = false;
			this.atributoCB.FormattingEnabled = true;
			this.atributoCB.Location = new System.Drawing.Point(136, 6);
			this.atributoCB.Name = "atributoCB";
			this.atributoCB.Size = new System.Drawing.Size(175, 21);
			this.atributoCB.TabIndex = 5;
			this.atributoCB.SelectedIndexChanged += new System.EventHandler(this.AtributoCBSelectedIndexChanged);
			// 
			// aceptarBTN
			// 
			this.aceptarBTN.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.aceptarBTN.Enabled = false;
			this.aceptarBTN.Location = new System.Drawing.Point(237, 326);
			this.aceptarBTN.Name = "aceptarBTN";
			this.aceptarBTN.Size = new System.Drawing.Size(75, 23);
			this.aceptarBTN.TabIndex = 6;
			this.aceptarBTN.Text = "Aceptar";
			this.aceptarBTN.UseVisualStyleBackColor = true;
			this.aceptarBTN.Click += new System.EventHandler(this.AceptarBTNClick);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Primer cuartil:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 58);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(87, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Tercer cuartil:";
			// 
			// cuartil1L
			// 
			this.cuartil1L.Location = new System.Drawing.Point(94, 35);
			this.cuartil1L.Name = "cuartil1L";
			this.cuartil1L.Size = new System.Drawing.Size(100, 14);
			this.cuartil1L.TabIndex = 22;
			this.cuartil1L.Text = "0";
			// 
			// cuartil3L
			// 
			this.cuartil3L.Location = new System.Drawing.Point(94, 58);
			this.cuartil3L.Name = "cuartil3L";
			this.cuartil3L.Size = new System.Drawing.Size(100, 14);
			this.cuartil3L.TabIndex = 23;
			this.cuartil3L.Text = "0";
			// 
			// posibleRB
			// 
			this.posibleRB.Location = new System.Drawing.Point(12, 87);
			this.posibleRB.Name = "posibleRB";
			this.posibleRB.Size = new System.Drawing.Size(104, 24);
			this.posibleRB.TabIndex = 24;
			this.posibleRB.TabStop = true;
			this.posibleRB.Text = "Posibles outliers";
			this.posibleRB.UseVisualStyleBackColor = true;
			this.posibleRB.CheckedChanged += new System.EventHandler(this.PosibleRBCheckedChanged);
			// 
			// posibleCB
			// 
			this.posibleCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.posibleCB.Enabled = false;
			this.posibleCB.FormattingEnabled = true;
			this.posibleCB.Location = new System.Drawing.Point(12, 117);
			this.posibleCB.Name = "posibleCB";
			this.posibleCB.Size = new System.Drawing.Size(299, 21);
			this.posibleCB.TabIndex = 25;
			// 
			// outlierRB
			// 
			this.outlierRB.Location = new System.Drawing.Point(12, 161);
			this.outlierRB.Name = "outlierRB";
			this.outlierRB.Size = new System.Drawing.Size(104, 24);
			this.outlierRB.TabIndex = 26;
			this.outlierRB.TabStop = true;
			this.outlierRB.Text = "Outliers";
			this.outlierRB.UseVisualStyleBackColor = true;
			this.outlierRB.CheckedChanged += new System.EventHandler(this.OutlierRBCheckedChanged);
			// 
			// outlierCB
			// 
			this.outlierCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.outlierCB.Enabled = false;
			this.outlierCB.FormattingEnabled = true;
			this.outlierCB.Location = new System.Drawing.Point(12, 191);
			this.outlierCB.Name = "outlierCB";
			this.outlierCB.Size = new System.Drawing.Size(299, 21);
			this.outlierCB.TabIndex = 27;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 280);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(79, 13);
			this.label4.TabIndex = 28;
			this.label4.Text = "Sustituir por:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 227);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(200, 13);
			this.label5.TabIndex = 29;
			this.label5.Text = "Se sugiere que sea sustituido por:";
			// 
			// sugerenciaL
			// 
			this.sugerenciaL.Location = new System.Drawing.Point(12, 243);
			this.sugerenciaL.Name = "sugerenciaL";
			this.sugerenciaL.Size = new System.Drawing.Size(100, 14);
			this.sugerenciaL.TabIndex = 30;
			this.sugerenciaL.Text = "-";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(160, 35);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(33, 13);
			this.label6.TabIndex = 32;
			this.label6.Text = "IQR:";
			// 
			// iqrL
			// 
			this.iqrL.Location = new System.Drawing.Point(190, 35);
			this.iqrL.Name = "iqrL";
			this.iqrL.Size = new System.Drawing.Size(100, 14);
			this.iqrL.TabIndex = 33;
			this.iqrL.Text = "0";
			// 
			// sustituirCB
			// 
			this.sustituirCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.sustituirCB.FormattingEnabled = true;
			this.sustituirCB.Location = new System.Drawing.Point(12, 297);
			this.sustituirCB.Name = "sustituirCB";
			this.sustituirCB.Size = new System.Drawing.Size(299, 21);
			this.sustituirCB.TabIndex = 34;
			this.sustituirCB.SelectedIndexChanged += new System.EventHandler(this.SustituirCBSelectedIndexChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(12, 326);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(40, 13);
			this.label7.TabIndex = 35;
			this.label7.Text = "Valor:";
			// 
			// valorL
			// 
			this.valorL.Location = new System.Drawing.Point(49, 326);
			this.valorL.Name = "valorL";
			this.valorL.Size = new System.Drawing.Size(100, 14);
			this.valorL.TabIndex = 36;
			this.valorL.Text = "0";
			// 
			// detectOutliers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(324, 360);
			this.Controls.Add(this.valorL);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.sustituirCB);
			this.Controls.Add(this.iqrL);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.sugerenciaL);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.outlierCB);
			this.Controls.Add(this.outlierRB);
			this.Controls.Add(this.posibleCB);
			this.Controls.Add(this.posibleRB);
			this.Controls.Add(this.cuartil3L);
			this.Controls.Add(this.cuartil1L);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.aceptarBTN);
			this.Controls.Add(this.atributoCB);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "detectOutliers";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Detección y corrección de outliers por atributo";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
