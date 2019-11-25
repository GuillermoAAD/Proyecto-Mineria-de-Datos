/*
 * Creado por SharpDevelop.
 * Usuario: Axel
 * Fecha: 24/11/2019
 * Hora: 04:43 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Proyecto_Mineria_de_Datos
{
	/// <summary>
	/// Description of transformacionDatos.
	/// </summary>
	public partial class transformacionDatos : Form
	{
		public ConjuntoDeDatosExtendido cdd;
		public transformacionDatos(ConjuntoDeDatosExtendido cddx)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			cdd = cddx;
			for(int i = 0; i < cdd.encabezados.Count; i++)
			{
				if(cdd.tiposDatos[i] == "numeric")
				{
					atributoCB.Items.Add(cdd.encabezados[i]);
				}
			}
			//En caso de que existan elementos en el CB se posiciona en el indice 0
			if(atributoCB.Items.Count > 0)
			{
				atributoCB.Enabled = true;
				atributoCB.SelectedIndex = 0;
				desviacionCB.Items.Add("Desviación estandar");
				desviacionCB.Items.Add("Desviación media absoluta");
				desviacionCB.SelectedIndex = 0;
				//Lleno el combobox de valores a sustituir
			}
			else
			{
				minmaxRB.Enabled = false;
				zscoreRB.Enabled = false;
				noexisL.Visible = true;
			}
		}
		void MinmaxRBCheckedChanged(object sender, EventArgs e)
		{
			maximoactL.Visible = true;
			minactL.Visible = true;
			valorMaxL.Visible = true;
			valorMinL.Visible = true;
			nuevoMaxL.Visible = true;
			nuevoMaxTB.Visible = true;
			nuevoMinL.Visible = true;
			nuevoMinTB.Visible = true;
			utilizarL.Visible = false;
			desviacionCB.Visible = false;
			aceptarBTN.Enabled = false;
			
		}
		void ZscoreRBCheckedChanged(object sender, EventArgs e)
		{
			maximoactL.Visible = false;
			minactL.Visible = false;
			valorMaxL.Visible = false;
			valorMinL.Visible = false;
			nuevoMaxL.Visible = false;
			nuevoMaxTB.Visible = false;
			nuevoMaxTB.Text = "";
			nuevoMinL.Visible = false;
			nuevoMinTB.Visible = false;
			nuevoMinTB.Text = "";
			utilizarL.Visible = true;
			desviacionCB.Visible = true;
			aceptarBTN.Enabled = true;
		}
		void NuevoMinTBTextChanged(object sender, EventArgs e)
		{
			if(nuevoMaxTB.Text.Length > 0 && nuevoMinTB.Text.Length > 0)
			{
				aceptarBTN.Enabled = true;
			}
			else
			{
				aceptarBTN.Enabled = false;
			}
		}
		void NuevoMaxTBTextChanged(object sender, EventArgs e)
		{
			if(nuevoMaxTB.Text.Length > 0 && nuevoMinTB.Text.Length > 0)
			{
				aceptarBTN.Enabled = true;
			}
			else
			{
				aceptarBTN.Enabled = false;
			}
		}
		void AtributoCBSelectedIndexChanged(object sender, EventArgs e)
		{
			actualizarLabelsMinMax(atributoCB.SelectedItem.ToString());
		}
		double obtenerMax(string encabezado)
		{
			double max = 0;
			
			//aqui obtiene el index para el atributo en la lista de encabezados
			int c = cdd.encabezados.IndexOf(encabezado);
			//ese mismo index sirve para sacar la posicion de columna de donde se saccan datos
			
			int cantInstancias= cdd.calcularCantidadInstancias();
			
			string valorCelda = "";
			
			List<double> valores = new List<double>();
			
			for(int f = 0; f < cantInstancias; f++)
			{
				valorCelda = cdd.dtConjuntoDatos.Rows[f][c].ToString();
				if(valorCelda != "" && valorCelda != cdd.valorNulo)
				{
					valores.Add(double.Parse(valorCelda));
				}
			}
			
			valores.Sort();
			
			max = valores[valores.Count -1];
			
			return max;
		}
		public double obtenerMin(string encabezado)
		{
			double min = 0;
			
			//aqui obtiene el index para el atributo en la lista de encabezados
			int c = cdd.encabezados.IndexOf(encabezado);
			//ese mismo index sirve para sacar la posicion de columna de donde se saccan datos
			
			int cantInstancias= cdd.calcularCantidadInstancias();
			
			string valorCelda = "";
			
			List<double> valores = new List<double>();
			
			for(int f = 0; f < cantInstancias; f++)
			{
				valorCelda = cdd.dtConjuntoDatos.Rows[f][c].ToString();
				if(valorCelda != "" && valorCelda != cdd.valorNulo)
				{
					valores.Add(double.Parse(valorCelda));
				}
			}
			
			valores.Sort();
			
			min = valores[0];
			
			return min;
		}
		public double obtenerNuevoMin()
		{
			return double.Parse(nuevoMinTB.Text);;
		}
		public double obtenerNuevoMax()
		{
			return double.Parse(nuevoMaxTB.Text);
		}
		void actualizarLabelsMinMax(string encabezado)
		{
			double minActual = obtenerMin(encabezado);
			double maxActual = obtenerMax(encabezado);
			valorMinL.Text = minActual.ToString();
			valorMaxL.Text = maxActual.ToString();
		}
		void normalizarMinMax(string encabezado)
		{
			double minActual = obtenerMin(encabezado);
			double maxActual = obtenerMax(encabezado);
			double minNuevo = double.Parse(nuevoMinTB.Text);
			double maxNuevo = double.Parse(nuevoMaxTB.Text);
			double actual;
			double nuevo;
			//Se localiza en indice del atributo
			int i = cdd.encabezados.IndexOf(encabezado);
			//Se obtiene el numero de instancias
			int cantInstancias = cdd.calcularCantidadInstancias();
			for(int j = 0; j < cantInstancias; j++)
			{
				actual = double.Parse(cdd.dtConjuntoDatos.Rows[j][i].ToString());
				nuevo = ((actual - minActual)/(maxActual - minActual)) * (maxNuevo - minNuevo) + minNuevo;
				cdd.dtConjuntoDatos.Rows[j][i] = nuevo.ToString("0.00");
			}
		}
		void AceptarBTNClick(object sender, EventArgs e)
		{
			if(minmaxRB.Checked == true)
			{
				normalizarMinMax(atributoCB.SelectedItem.ToString());
			}
		}
	}
}