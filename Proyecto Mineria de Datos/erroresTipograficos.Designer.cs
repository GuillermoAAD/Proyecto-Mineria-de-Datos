/*
 * Creado por SharpDevelop.
 * Usuario: Axel
 * Fecha: 21/11/2019
 * Hora: 10:49 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Proyecto_Mineria_de_Datos
{
	partial class erroresTipograficos
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ComboBox atributoCB;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button aceptarBTN;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(erroresTipograficos));
			this.label1 = new System.Windows.Forms.Label();
			this.aceptarBTN = new System.Windows.Forms.Button();
			this.atributoCB = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(118, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Escoge un atributo:";
			// 
			// aceptarBTN
			// 
			this.aceptarBTN.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.aceptarBTN.Location = new System.Drawing.Point(136, 39);
			this.aceptarBTN.Name = "aceptarBTN";
			this.aceptarBTN.Size = new System.Drawing.Size(191, 23);
			this.aceptarBTN.TabIndex = 4;
			this.aceptarBTN.Text = "Aceptar";
			this.aceptarBTN.UseVisualStyleBackColor = true;
			this.aceptarBTN.Click += new System.EventHandler(this.AceptarBTNClick);
			// 
			// atributoCB
			// 
			this.atributoCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.atributoCB.Enabled = false;
			this.atributoCB.FormattingEnabled = true;
			this.atributoCB.Location = new System.Drawing.Point(136, 12);
			this.atributoCB.Name = "atributoCB";
			this.atributoCB.Size = new System.Drawing.Size(191, 21);
			this.atributoCB.TabIndex = 0;
			// 
			// erroresTipograficos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(339, 74);
			this.Controls.Add(this.aceptarBTN);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.atributoCB);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "erroresTipograficos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Detección de errores tipográficos";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
