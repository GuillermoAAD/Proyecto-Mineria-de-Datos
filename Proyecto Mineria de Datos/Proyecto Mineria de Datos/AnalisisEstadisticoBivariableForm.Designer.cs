/*
 * Created by SharpDevelop.
 * User: Chu
 * Date: 17/11/2019
 * Time: 12:43 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Proyecto_Mineria_de_Datos
{
	partial class AnalisisEstadisticoBivariableForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label labelOperacionNoValida;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelPearson;
		private System.Windows.Forms.Label labelChiCuadrada;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label labelTschuprow;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView dataGridView1;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnalisisEstadisticoBivariableForm));
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.labelOperacionNoValida = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.labelPearson = new System.Windows.Forms.Label();
			this.labelChiCuadrada = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.labelTschuprow = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(264, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Escoge dos atributos para realizar el analisis:";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(12, 50);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(264, 21);
			this.comboBox1.TabIndex = 3;
			this.comboBox1.Text = "Elija un atributo";
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(12, 77);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(264, 21);
			this.comboBox2.TabIndex = 4;
			this.comboBox2.Text = "Elija un atributo";
			this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.ComboBox2SelectedIndexChanged);
			// 
			// labelOperacionNoValida
			// 
			this.labelOperacionNoValida.AutoSize = true;
			this.labelOperacionNoValida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelOperacionNoValida.Location = new System.Drawing.Point(27, 131);
			this.labelOperacionNoValida.Name = "labelOperacionNoValida";
			this.labelOperacionNoValida.Size = new System.Drawing.Size(232, 26);
			this.labelOperacionNoValida.TabIndex = 5;
			this.labelOperacionNoValida.Text = "No se puede hacer análisis estadístico \r\nbivariable de Categórico vs Numérico";
			this.labelOperacionNoValida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelOperacionNoValida.Visible = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(10, 115);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(228, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Coeficiente de correlación de Pearson:";
			this.label2.Visible = false;
			// 
			// labelPearson
			// 
			this.labelPearson.Location = new System.Drawing.Point(10, 134);
			this.labelPearson.Name = "labelPearson";
			this.labelPearson.Size = new System.Drawing.Size(100, 23);
			this.labelPearson.TabIndex = 7;
			this.labelPearson.Text = "0";
			this.labelPearson.Visible = false;
			// 
			// labelChiCuadrada
			// 
			this.labelChiCuadrada.Location = new System.Drawing.Point(10, 134);
			this.labelChiCuadrada.Name = "labelChiCuadrada";
			this.labelChiCuadrada.Size = new System.Drawing.Size(100, 23);
			this.labelChiCuadrada.TabIndex = 9;
			this.labelChiCuadrada.Text = "0";
			this.labelChiCuadrada.Visible = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(10, 115);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(87, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Chi-Cuadrada:";
			this.label3.Visible = false;
			// 
			// labelTschuprow
			// 
			this.labelTschuprow.Location = new System.Drawing.Point(10, 176);
			this.labelTschuprow.Name = "labelTschuprow";
			this.labelTschuprow.Size = new System.Drawing.Size(100, 23);
			this.labelTschuprow.TabIndex = 11;
			this.labelTschuprow.Text = "0";
			this.labelTschuprow.Visible = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(10, 157);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(254, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "Coeficiente de contingencia de Tschuprow:";
			this.label4.Visible = false;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(287, 49);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.Size = new System.Drawing.Size(0, 0);
			this.dataGridView1.TabIndex = 12;
			this.dataGridView1.Visible = false;
			// 
			// AnalisisEstadisticoBivariableForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(289, 199);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.labelChiCuadrada);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.labelPearson);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.labelOperacionNoValida);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.labelTschuprow);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AnalisisEstadisticoBivariableForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Análisis Estadístico Bivariable";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
