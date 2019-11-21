/*
 * Created by SharpDevelop.
 * User: Chu
 * Date: 11/11/2019
 * Time: 9:28 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections.Generic;


namespace Proyecto_Mineria_de_Datos
{
	/// <summary>
	/// Description of AnalisisEstadisticoUnivariableForm.
	/// </summary>
	public partial class AnalisisEstadisticoUnivariableForm : Form
	{
		//esto se va a cmabiar
		//public formatoDATA cdd; // cdd = conjunto de datos
		public ConjuntoDeDatosExtendido cdd;// cdd = conjunto de datos
		
		
		public AnalisisEstadisticoUnivariableForm(ConjuntoDeDatosExtendido cddx)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.			//

			//
			cdd = new ConjuntoDeDatosExtendido();
			cdd = cddx;
			//cdd.abrirDATA("C:\\Users\\Chu\\Desktop\\ejemplo.data");
			
			for(int i = 0; i < cdd.encabezados.Count; i++)
			{
				comboBox1.Items.Add(cdd.encabezados[i]);
			}
		}
		
		//al seleccionar algun atributo busca que tipo de dato es
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			string encabezado = comboBox1.Text;
			//string tipoDato = saberTipoDeDato(encabezado);
			string tipoDato = cdd.saberTipoDeDato(encabezado);
			
			//if(tipoDato == "numeric")//probablemente se agregue fecha...
			if(tipoDato == "numerico")//probablemente se agregue fecha...
			{
				//hace calculos de numerico y 
				//pondra visible las cosas que se relacionen
				calculoDeNumericos(encabezado);
				mostrarDatosNumericos();
			}
			//else if(tipoDato == "nominal" || tipoDato == "ordinal")//probablemente se deban agregar ordinal, bool, etc,
			else if(tipoDato == "categorico")
			{
				//hace calculos de categorico y 
				//pondra visible las cosas que se relacionen
				calculoDeCategoricos(encabezado);
				mostrarDatosCategoricos();
			}
		}
		
		//Saber si el tipo de dato es numerico o categorico
		/*
		private	string saberTipoDeDato(string nombreAtributo)
		{
			//va acomparar el atributo elegido en el comboBox con la lista de tipos
			
			//aqui obtiene el index para el atributo en la lista de encabezados
			int i = cdd.encabezados.IndexOf(nombreAtributo);
			//ese mismo index sirve para sacar el tipo de dato de la lista de tiposDatos
			
			string tipoDato;
			
			tipoDato = cdd.tiposDatos[i];
			
			return tipoDato;
		}
		*/
		
		private void calculoDeNumericos(string encabezado)
		{
			labelMedia.Text = cdd.calcularMedia(encabezado).ToString("0.00");
			labelMediana.Text = cdd.calcularMediana(encabezado).ToString("0.00");
			labelModa.Text = cdd.calcularModa(encabezado).ToString("0.00");
			labelDesviacionEstandar.Text = cdd.calcularDesviacionEstandar(encabezado).ToString("0.00");
			
			
			labelMin.Text = obtenerMin(encabezado).ToString();
			labelMax.Text = obtenerMax(encabezado).ToString();
			double[] cuartiles = obtenerCuartiles(encabezado);
			
			labelCuartil1.Text = cuartiles[0].ToString();
			labelCuartil3.Text = cuartiles[2].ToString();
			
			//esto llena el boxplot
			calcularBoxplot();
		}
		
		private void calculoDeCategoricos(string encabezado)
		{
			dataGridViewTablaDeFrecuencias.DataSource = null;
			dataGridViewTablaDeFrecuencias.DataSource = cdd.calcularTablaFrecuencias(encabezado);
		}
		
		private void mostrarDatosNumericos()
		{
			ocultarDatosCategoricos();
			label2.Visible = true;
			labelMedia.Visible = true;
			label3.Visible = true;
			labelMediana.Visible = true;
			label4.Visible = true;
			labelModa.Visible = true;
			label5.Visible = true;
			labelDesviacionEstandar.Visible = true;
			label6.Visible = true;
			chartBoxplot.Visible =true;
			
			//datos relacionados al boxplot
			label15.Visible = true;
			labelMin.Visible = true;
			label11.Visible = true;
			labelMax.Visible = true;
			label13.Visible = true;
			labelCuartil1.Visible = true;
			label12.Visible = true;
			labelCuartil3.Visible = true;
		}
		
		private void ocultarDatosNumericos()
		{
			label2.Visible = false;
			labelMedia.Visible = false;
			label3.Visible = false;
			labelMediana.Visible = false;
			label4.Visible = false;
			labelModa.Visible = false;
			label5.Visible = false;
			labelDesviacionEstandar.Visible = false;
			label6.Visible = false;
			chartBoxplot.Visible = false;
			
			//datos relacionados al boxplot
			label15.Visible = false;
			labelMin.Visible = false;
			label11.Visible = false;
			labelMax.Visible = false;
			label13.Visible = false;
			labelCuartil1.Visible = false;
			label12.Visible = false;
			labelCuartil3.Visible = false;
		}
		
		private void mostrarDatosCategoricos()
		{
			ocultarDatosNumericos();
			label7.Visible = true;
			dataGridViewTablaDeFrecuencias.Visible = true;
		}
		
		private void ocultarDatosCategoricos()
		{
			label7.Visible=false;
			dataGridViewTablaDeFrecuencias.Visible = false;
		}
		
		private void calcularBoxplot()
		{
			string nombreAtrib = comboBox1.Text;
			double min = obtenerMin(nombreAtrib);
			double max = obtenerMax(nombreAtrib);
			double media = cdd.calcularMedia(nombreAtrib);
			double mediana = cdd.calcularMediana(nombreAtrib);
			double moda = cdd.calcularModa(nombreAtrib);
			
			//double rango = max - min;
			
			double[] cuartiles = obtenerCuartiles(nombreAtrib);
			double cuartil1 = cuartiles[0];
			double cuartil2 = cuartiles[1];
			double cuartil3 = cuartiles[2];
			
			
			chartBoxplot.Series.Clear();
			chartBoxplot.Series.Add(nombreAtrib);

			//Se elige el tipo de grafico, en este caso boxplot
			chartBoxplot.Series[nombreAtrib].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.BoxPlot;
			
			//aqui se ingresan los valores que necesita para el boxplot
			//Son en el siguiente orden
			// min, max, 
			//chartBoxplot.Series[nombreAtrib].Points.AddXY(0, 3, 8, 4, 7,4);
			//chartBoxplot.Series[nombreAtrib].Points.AddXY(min, max, cuartil1, cuartil3, media, mediana);
			
			chartBoxplot.Series[nombreAtrib].Points.AddXY(0, min, max, cuartil1, cuartil3, media, cuartil2);
		}
		
		public double obtenerMin(string nombreAtrib)
		{
			double min = 0;
			
			//aqui obtiene el index para el atributo en la lista de encabezados
			int c = cdd.encabezados.IndexOf(nombreAtrib);
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
		
		public double obtenerMax(string nombreAtrib)
		{
			double max = 0;
			
			//aqui obtiene el index para el atributo en la lista de encabezados
			int c = cdd.encabezados.IndexOf(nombreAtrib);
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
		
		
		//el metodo usado para obtener cuaritles es el de Mendenhall y Sincich
		public double[] obtenerCuartiles(string nombreAtrib)
		{
			
			double[] cuartiles = new double[3];
			
			//aqui obtiene el index para el atributo en la lista de encabezados
			int c = cdd.encabezados.IndexOf(nombreAtrib);
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
			
			int n = valores.Count;
			int valorEntero = 0;
			double valorDecimal = 0;
			double valorCuartil =0;
			
			cuartiles[0] = (n+1)/4;
			valorCuartil = cuartiles[0];
			
			cuartiles[1] = cdd.calcularMediana(nombreAtrib);
			cuartiles[2] = 3 * cuartiles[0];
			
			//Se revisa si el cuartil es entero
			if((cuartiles[0] % 1).ToString() == (0).ToString())
			{
				//extraigo el valor del cuartil 1
				valorEntero = int.Parse(cuartiles[0].ToString());
				//busco el valor en la posicion de la formula
				//cuartil y la meto al valor de cuartil
				cuartiles[0] = valores[valorEntero];
			}
			else //entonces si tiene decimales
			{
				valorDecimal = cuartiles[0] % 1;
				valorEntero = int.Parse((cuartiles[0] - valorDecimal).ToString());
				
				//cuartiles[0] = valores[valorEntero] + valorDecimal * (valores[valorEntero+1] - valores[valorEntero]);
				//cuartiles[0] = (valorEntero * valorCuartil);
				//cuartiles[0] += (cuartiles[0] * (valorDecimal * valorCuartil) );
				
				
				cuartiles[0] = valores[valorEntero + 1];
			}
			
			//se remplaza el valor obtenido con el valor de los 
			//datosen la posicion obtenidoa por el cuartil
			
			valorCuartil = cuartiles[2];
			if((cuartiles[2] % 1).ToString() == (0).ToString())
			{
				//extraigo el valor del cuartil 1
				valorEntero = int.Parse(cuartiles[2].ToString());
				//busco el valor en la posicion de la formula
				//cuartil y la meto al valor de cuartil
				cuartiles[2] = valores[valorEntero];
			}
			else //entonces si tiene decimales
			{
				valorDecimal = cuartiles[2] % 1;
				valorEntero = int.Parse((cuartiles[2] - valorDecimal).ToString());
				
				//cuartiles[2] = valores[valorEntero] + valorDecimal * (valores[valorEntero+1] - valores[valorEntero]);
				//cuartiles[2] = (valorEntero * valorCuartil);
				//cuartiles[2] += (cuartiles[2] * (valorDecimal * valorCuartil) );
				
				cuartiles[0] = valores[valorEntero];
			}
			
			return cuartiles;
		}
		
	}
}
