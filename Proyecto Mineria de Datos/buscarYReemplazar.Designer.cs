/*
 * Creado por SharpDevelop.
 * Usuario: Axel
 * Fecha: 22/11/2019
 * Hora: 05:09 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Proyecto_Mineria_de_Datos
{
	partial class buscarYReemplazar
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox atributoCB;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox buscarTB;
		private System.Windows.Forms.TextBox reemplazarTB;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buscarYReemplazar));
			this.label1 = new System.Windows.Forms.Label();
			this.atributoCB = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.buscarTB = new System.Windows.Forms.TextBox();
			this.reemplazarTB = new System.Windows.Forms.TextBox();
			this.aceptarBTN = new System.Windows.Forms.Button();
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
			this.atributoCB.FormattingEnabled = true;
			this.atributoCB.Location = new System.Drawing.Point(136, 6);
			this.atributoCB.Name = "atributoCB";
			this.atributoCB.Size = new System.Drawing.Size(149, 21);
			this.atributoCB.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Buscar:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 83);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(99, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Reemplazar por:";
			// 
			// buscarTB
			// 
			this.buscarTB.Location = new System.Drawing.Point(12, 48);
			this.buscarTB.Name = "buscarTB";
			this.buscarTB.Size = new System.Drawing.Size(273, 20);
			this.buscarTB.TabIndex = 8;
			this.buscarTB.TextChanged += new System.EventHandler(this.BuscarTBTextChanged);
			// 
			// reemplazarTB
			// 
			this.reemplazarTB.Location = new System.Drawing.Point(12, 99);
			this.reemplazarTB.Name = "reemplazarTB";
			this.reemplazarTB.Size = new System.Drawing.Size(273, 20);
			this.reemplazarTB.TabIndex = 9;
			this.reemplazarTB.TextChanged += new System.EventHandler(this.ReemplazarTBTextChanged);
			// 
			// aceptarBTN
			// 
			this.aceptarBTN.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.aceptarBTN.Enabled = false;
			this.aceptarBTN.Location = new System.Drawing.Point(210, 125);
			this.aceptarBTN.Name = "aceptarBTN";
			this.aceptarBTN.Size = new System.Drawing.Size(75, 23);
			this.aceptarBTN.TabIndex = 10;
			this.aceptarBTN.Text = "Aceptar";
			this.aceptarBTN.UseVisualStyleBackColor = true;
			this.aceptarBTN.Click += new System.EventHandler(this.AceptarBTNClick);
			// 
			// buscarYReemplazar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(297, 159);
			this.Controls.Add(this.aceptarBTN);
			this.Controls.Add(this.reemplazarTB);
			this.Controls.Add(this.buscarTB);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.atributoCB);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "buscarYReemplazar";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Buscar y reemplazar por atributo";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
