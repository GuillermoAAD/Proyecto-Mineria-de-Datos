/*
 * Creado por SharpDevelop.
 * Usuario: Axel
 * Fecha: 22/11/2019
 * Hora: 05:09 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_Mineria_de_Datos
{
	/// <summary>
	/// Description of buscarYReemplazar.
	/// </summary>
	public partial class buscarYReemplazar : Form
	{
		public ConjuntoDeDatosExtendido cdd;
		public buscarYReemplazar(ConjuntoDeDatosExtendido cddx)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//			
			cdd = cddx;
			//Agregamos solo los categoricos al ComboBox
			for(int i = 0; i < cdd.encabezados.Count; i++)
			{
				atributoCB.Items.Add(cdd.encabezados[i]);
			}
			//En caso de que existan elementos en el CB se posiciona en el indice 0
			if(atributoCB.Items.Count > 0)
			{
				atributoCB.SelectedIndex = 0;
			}
		}
		void AceptarBTNClick(object sender, EventArgs e)
		{
			reemplazo(buscarTB.Text.ToString(), reemplazarTB.Text.ToString());
		}
		private void reemplazo(string buscar, string reemplazar)
		{
			bool existe = false;
			int i = indice(atributoCB.SelectedItem.ToString());
			int cantInstancias = cdd.calcularCantidadInstancias();
			for(int j = 0; j < cantInstancias; j++)
			{
				if(cdd.dtConjuntoDatos.Rows[j][i].ToString() == buscarTB.Text.ToString())
				{
					existe = true;
					cdd.dtConjuntoDatos.Rows[j][i] = reemplazarTB.Text;
				}
			}
			if(existe == false)
			{
				MessageBox.Show("La palabra " + buscarTB.Text + " no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				MessageBox.Show("La palabra " + buscarTB.Text + " ha sido reemplazada correctamente", "Reemplazo con exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		private int indice(string encabezado)
		{
			return cdd.encabezados.IndexOf(encabezado);
		}
		void BuscarTBTextChanged(object sender, EventArgs e)
		{
			if(buscarTB.Text.Length > 0 && reemplazarTB.Text.Length > 0)
			{
				aceptarBTN.Enabled = true;
			}
			else
			{
				aceptarBTN.Enabled = false;
			}
		}
		void ReemplazarTBTextChanged(object sender, EventArgs e)
		{
			if(buscarTB.Text.Length > 0 && reemplazarTB.Text.Length > 0)
			{
				aceptarBTN.Enabled = true;
			}
			else
			{
				aceptarBTN.Enabled = false;
			}
		}
	}
}
