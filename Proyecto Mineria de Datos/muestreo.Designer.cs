/*
 * Creado por SharpDevelop.
 * Usuario: Axel
 * Fecha: 26/11/2019
 * Hora: 12:16 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Proyecto_Mineria_de_Datos
{
	partial class muestreo
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox nMuestraTB;
		private System.Windows.Forms.RadioButton conRemRB;
		private System.Windows.Forms.RadioButton sinRemRB;
		private System.Windows.Forms.Button guardarBTN;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(muestreo));
			this.label4 = new System.Windows.Forms.Label();
			this.nMuestraTB = new System.Windows.Forms.TextBox();
			this.conRemRB = new System.Windows.Forms.RadioButton();
			this.sinRemRB = new System.Windows.Forms.RadioButton();
			this.guardarBTN = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(225, 18);
			this.label4.TabIndex = 7;
			this.label4.Text = "Número de instancias para la muestra:";
			// 
			// nMuestraTB
			// 
			this.nMuestraTB.Location = new System.Drawing.Point(243, 7);
			this.nMuestraTB.Name = "nMuestraTB";
			this.nMuestraTB.Size = new System.Drawing.Size(89, 20);
			this.nMuestraTB.TabIndex = 8;
			this.nMuestraTB.TextChanged += new System.EventHandler(this.NMuestraLTextChanged);
			// 
			// conRemRB
			// 
			this.conRemRB.Checked = true;
			this.conRemRB.Location = new System.Drawing.Point(12, 30);
			this.conRemRB.Name = "conRemRB";
			this.conRemRB.Size = new System.Drawing.Size(104, 24);
			this.conRemRB.TabIndex = 9;
			this.conRemRB.TabStop = true;
			this.conRemRB.Text = "Con remplazo";
			this.conRemRB.UseVisualStyleBackColor = true;
			// 
			// sinRemRB
			// 
			this.sinRemRB.Location = new System.Drawing.Point(122, 30);
			this.sinRemRB.Name = "sinRemRB";
			this.sinRemRB.Size = new System.Drawing.Size(104, 24);
			this.sinRemRB.TabIndex = 10;
			this.sinRemRB.Text = "Sin remplazo";
			this.sinRemRB.UseVisualStyleBackColor = true;
			// 
			// guardarBTN
			// 
			this.guardarBTN.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.guardarBTN.Enabled = false;
			this.guardarBTN.Location = new System.Drawing.Point(12, 64);
			this.guardarBTN.Name = "guardarBTN";
			this.guardarBTN.Size = new System.Drawing.Size(320, 23);
			this.guardarBTN.TabIndex = 11;
			this.guardarBTN.Text = "Guardar muestra...";
			this.guardarBTN.UseVisualStyleBackColor = true;
			this.guardarBTN.Click += new System.EventHandler(this.GuardarBTNClick);
			// 
			// muestreo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(344, 100);
			this.Controls.Add(this.guardarBTN);
			this.Controls.Add(this.sinRemRB);
			this.Controls.Add(this.conRemRB);
			this.Controls.Add(this.nMuestraTB);
			this.Controls.Add(this.label4);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "muestreo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Muestreo de datos";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
