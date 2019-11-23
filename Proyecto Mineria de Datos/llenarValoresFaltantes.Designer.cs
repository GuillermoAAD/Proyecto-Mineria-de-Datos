/*
 * Creado por SharpDevelop.
 * Usuario: Axel
 * Fecha: 20/11/2019
 * Hora: 06:28 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Proyecto_Mineria_de_Datos
{
	partial class llenarValoresFaltantes
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox atributoCB;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label labelMedia;
		private System.Windows.Forms.Label labelMediana;
		private System.Windows.Forms.Label labelModa;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label labelSugerencia;
		private System.Windows.Forms.ComboBox sustituirCB;
		private System.Windows.Forms.Button aceptarBTN;
		private System.Windows.Forms.Label label6;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(llenarValoresFaltantes));
			this.label1 = new System.Windows.Forms.Label();
			this.atributoCB = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.labelMedia = new System.Windows.Forms.Label();
			this.labelMediana = new System.Windows.Forms.Label();
			this.labelModa = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.labelSugerencia = new System.Windows.Forms.Label();
			this.sustituirCB = new System.Windows.Forms.ComboBox();
			this.aceptarBTN = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(118, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Escoge un atributo:";
			// 
			// atributoCB
			// 
			this.atributoCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.atributoCB.FormattingEnabled = true;
			this.atributoCB.Location = new System.Drawing.Point(136, 6);
			this.atributoCB.Name = "atributoCB";
			this.atributoCB.Size = new System.Drawing.Size(207, 21);
			this.atributoCB.TabIndex = 0;
			this.atributoCB.SelectedIndexChanged += new System.EventHandler(this.AtributoCBSelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Media:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 113);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Moda: ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 82);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Mediana:";
			// 
			// labelMedia
			// 
			this.labelMedia.Location = new System.Drawing.Point(12, 64);
			this.labelMedia.Name = "labelMedia";
			this.labelMedia.Size = new System.Drawing.Size(100, 18);
			this.labelMedia.TabIndex = 8;
			this.labelMedia.Text = "0";
			// 
			// labelMediana
			// 
			this.labelMediana.Location = new System.Drawing.Point(12, 95);
			this.labelMediana.Name = "labelMediana";
			this.labelMediana.Size = new System.Drawing.Size(100, 18);
			this.labelMediana.TabIndex = 9;
			this.labelMediana.Text = "0";
			// 
			// labelModa
			// 
			this.labelModa.Location = new System.Drawing.Point(12, 126);
			this.labelModa.Name = "labelModa";
			this.labelModa.Size = new System.Drawing.Size(100, 18);
			this.labelModa.TabIndex = 10;
			this.labelModa.Text = "0";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(136, 51);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(193, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "Se sugiere que se sustituya por: ";
			// 
			// labelSugerencia
			// 
			this.labelSugerencia.Location = new System.Drawing.Point(136, 64);
			this.labelSugerencia.Name = "labelSugerencia";
			this.labelSugerencia.Size = new System.Drawing.Size(100, 18);
			this.labelSugerencia.TabIndex = 12;
			// 
			// sustituirCB
			// 
			this.sustituirCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.sustituirCB.FormattingEnabled = true;
			this.sustituirCB.Location = new System.Drawing.Point(136, 113);
			this.sustituirCB.Name = "sustituirCB";
			this.sustituirCB.Size = new System.Drawing.Size(207, 21);
			this.sustituirCB.TabIndex = 13;
			// 
			// aceptarBTN
			// 
			this.aceptarBTN.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.aceptarBTN.Location = new System.Drawing.Point(268, 140);
			this.aceptarBTN.Name = "aceptarBTN";
			this.aceptarBTN.Size = new System.Drawing.Size(75, 23);
			this.aceptarBTN.TabIndex = 14;
			this.aceptarBTN.Text = "Aceptar";
			this.aceptarBTN.UseVisualStyleBackColor = true;
			this.aceptarBTN.Click += new System.EventHandler(this.AceptarBTNClick);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(136, 97);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(83, 13);
			this.label6.TabIndex = 15;
			this.label6.Text = "Sustituir por: ";
			// 
			// llenarValoresFaltantes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(355, 172);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.aceptarBTN);
			this.Controls.Add(this.sustituirCB);
			this.Controls.Add(this.labelSugerencia);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.labelModa);
			this.Controls.Add(this.labelMediana);
			this.Controls.Add(this.labelMedia);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.atributoCB);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "llenarValoresFaltantes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Llenar valores faltantes por atributo";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
