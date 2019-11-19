/*
 * Created by SharpDevelop.
 * User: Chu
 * Date: 17/11/2019
 * Time: 12:44 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;

namespace Proyecto_Mineria_de_Datos
{
	/// <summary>
	/// Description of AnalisisEstadisticoBivariableForm.
	/// </summary>
	public partial class AnalisisEstadisticoBivariableForm : Form
	{
		public ConjuntoDeDatosExtendido cdd;// cdd = conjunto de datos
		
		public AnalisisEstadisticoBivariableForm(ConjuntoDeDatosExtendido cddx)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			cdd = new ConjuntoDeDatosExtendido();
			cdd = cddx;
			
			//esto agrega los encabezados al combobox
			for(int i = 0; i < cdd.encabezados.Count; i++)
			{
				comboBox1.Items.Add(cdd.encabezados[i]);
				comboBox2.Items.Add(cdd.encabezados[i]);
			}
		}
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			string encabezado1 = comboBox1.Text;
			string encabezado2 = comboBox2.Text;
			
			//revisa si en el otro combobox ya se escogio un atributo
			//Si no, no realiza ninguna operacion
			if(encabezado2 != "Elija un atributo")
			{
				//Revisa si los atributos de ambos combobox son categoricos o numericos
				
				//si son del mismo tipo se hacen las operaciones correspondientes
				if(sonDelMismoTipo(encabezado1, encabezado2))
				{
					//en caso de que anteriormente se haya hecho una comparacion de
					//numerico con categorico, quedaria visible el mensaje, entonces se oculta
					labelOperacionNoValida.Visible = false;
					
					//Para saber el tipo elijo a cualquiera de los dos para obtener su tipo
					//No importa cual porque son iguales
					string tipoDato = cdd.saberTipoDeDato(encabezado1);
					//ahora con esto ya puedo saber si hara las operaciones de
					//categorico : chi cuadrada + tschuprow o
					//numerico: pearson
					
					if(tipoDato == "numerico")
					{
						//hace calculos de numerico y 
						//pondra visible las cosas que se relacionen
						calculoDeNumericos(encabezado1, encabezado2);
						mostrarDatosNumericos();
					}
					else if(tipoDato == "categorico")
					{
						//hace calculos de categorico y 
						//pondra visible las cosas que se relacionen
						calculoDeCategoricos(encabezado1, encabezado2);
						mostrarDatosCategoricos();
					}
				}
				else//si no se muestra un mensaje de que no se puede realizar la operacion
				{
					ocultarDatosNumericos();
					ocultarDatosCategoricos();
					labelOperacionNoValida.Visible = true;
				}
			}
		}
		
		//Es casi lo mismo que para el combobox1
		//Esto hace que se sienta instantaneos los calculos, sin necesidad de un boton
		void ComboBox2SelectedIndexChanged(object sender, EventArgs e)
		{
			string encabezado1 = comboBox1.Text;
			string encabezado2 = comboBox2.Text;
			
			//revisa si en el otro combobox ya se escogio un atributo
			//Si no, no realiza ninguna operacion
			if(encabezado1 != "Elija un atributo")
			{
				//Revisa si los atributos de ambos combobox son categoricos o numericos
				
				//si son del mismo tipo se hacen las operaciones correspondientes
				if(sonDelMismoTipo(encabezado1, encabezado2))
				{
					//en caso de que anteriormente se haya hecho una comparacion de
					//numerico con categorico, quedaria visible el mensaje, entonces se oculta
					labelOperacionNoValida.Visible = false;
					
					//Para saber el tipo elijo a cualquiera de los dos para obtener su tipo
					//No importa cual porque son iguales
					string tipoDato = cdd.saberTipoDeDato(encabezado1);
					//ahora con esto ya puedo saber si hara las operaciones de
					//categorico : chi cuadrada + tschuprow o
					//numerico: pearson
					
					if(tipoDato == "numerico")
					{
						//hace calculos de numerico y 
						//pondra visible las cosas que se relacionen
						calculoDeNumericos(encabezado1, encabezado2);
						mostrarDatosNumericos();
					}
					else if(tipoDato == "categorico")
					{
						//hace calculos de categorico y 
						//pondra visible las cosas que se relacionen
						calculoDeCategoricos(encabezado1, encabezado2);
						mostrarDatosCategoricos();
					}
				}
				else//si no se muestra un mensaje de que no se puede realizar la operacion
				{
					ocultarDatosNumericos();
					ocultarDatosCategoricos();
					labelOperacionNoValida.Visible = true;
				}
			}
		}
		
		private bool sonDelMismoTipo(string atrib1, string atrib2)
		{
			bool iguales = false;
			string tipoDato1 = cdd.saberTipoDeDato(atrib1);
			string tipoDato2 = cdd.saberTipoDeDato(atrib2);
			
			if(tipoDato1 == tipoDato2)
			{
				iguales = true;
			}
			return iguales;
		}
		
		private void calculoDeNumericos(string encabezado1, string encabezado2)
		{
			labelPearson.Text = calcularPearson(encabezado1, encabezado2).ToString("0.000");
		}
		
		private void calculoDeCategoricos(string encabezado1, string encabezado2)
		{
			dataGridView1.DataSource = null;
			
			double chiCuadrada = calcularChiCuadrada(encabezado1, encabezado2);
			labelChiCuadrada.Text = calcularChiCuadrada(encabezado1, encabezado2).ToString("0.000");
			
			//Hago esto aqui por que tschuprow necesita estos valores
			DataTable tablaContingencia = calcularTablaContingencia(encabezado1, encabezado2);
			int n = calcularNumeroTuplas(tablaContingencia);
			
			labelTschuprow.Text = calcularTschuprow(chiCuadrada, n, encabezado1, encabezado2).ToString("0.000");
		}
		
		private void mostrarDatosNumericos()
		{
			ocultarDatosCategoricos();
			label2.Visible = true;
			labelPearson.Visible = true;
		}
		
		private void ocultarDatosNumericos()
		{
			label2.Visible = false;
			labelPearson.Visible = false;
		}
		
		private void mostrarDatosCategoricos()
		{
			ocultarDatosNumericos();
			
			label3.Visible = true;
			labelChiCuadrada.Visible = true;
			label4.Visible = true;
			labelTschuprow.Visible = true;
			
			//dataGridView1 = true;
		}
		
		private void ocultarDatosCategoricos()
		{
			label3.Visible = false;
			labelChiCuadrada.Visible = false;
			label4.Visible = false;
			labelTschuprow.Visible = false;
			
			//dataGridView1.Visible = false;
		}
		
		private double calcularPearson(string encabezado1, string encabezado2)
		{
			//obtener los valores para ambos atributos
			List<string> valoresAtrib1 = new List<string>();
			List<string> valoresAtrib2 = new List<string>();
			
			valoresAtrib1 = cdd.obtenerValoresParaAtributo(encabezado1);
			valoresAtrib2 = cdd.obtenerValoresParaAtributo(encabezado2);

			//calcular promedio para cada atributo
			double prom1 = cdd.calcularMedia(encabezado1);
			double prom2 = cdd.calcularMedia(encabezado2);
			
			// obtener n(numero de instancias)
			double n = cdd.calcularCantidadInstancias();
			
			//aqui se guardaran los valores multiplicados
			List<double> valMutlpilicados = new List<double>();
			
			//aqui se guarda lasumatoria de los valores multiplicados
			double sumatoria = 0;
			
			//Aqui se guardan las desviaciones estandar de cada atributo
			double desv1 = cdd.calcularDesviacionEstandar(encabezado1);
			double desv2 = cdd.calcularDesviacionEstandar(encabezado2);
			
			//guardara la parte del divisor de la formula
			double divisor = 0;
			//guardara la parte del dividendo de la formula
			double dividendo = 0;
			
			//guardara r(es el valor de la formula)
			double r = divisor / dividendo;
			
			//variable temporal que guardara los valores del primer atributo
			double val1 = 0;
			//variable temporal que guardara los valores del segundo atributo
			double val2 = 0;
			
			try
			{
				//para cada valor de un atributo:
				//valor i -el promedio
				for(int i = 0; i < n; i++)
				{
					//Revisa que el valor extraido pueda ser convertido oa double
					//ignorando los valores faltantes(en los valores faltantes agrega 0)
					//double a = 0;
					//if(double.TryParse(valoresAtrib1[i], out a))
					//{
					//try
	            	//{
						valoresAtrib1[i] = (double.Parse(valoresAtrib1[i]) - prom1).ToString();
					//}
					//catch (Exception ex)
	            	//{
	                //	MessageBox.Show(ex.ToString());
	            	//}
				}
				
				//hacer lo mismo con el otro atributo
				for(int i = 0; i < n; i++)
				{
					//double a = 0;
					//if(double.TryParse(valoresAtrib2[i], out a))
					
					//try
					//{
						valoresAtrib2[i] = (double.Parse(valoresAtrib2[i]) - prom2).ToString();
					//}
					//catch (Exception ex)
	            	//{
	                //	MessageBox.Show(ex.ToString());
	            	//}
				}
				
				//multiplicar el valor i de ambos atributos y agregarlos a una sumatoria
				for(int i = 0; i < n; i++)
				{
					//MessageBox.Show(valoresAtrib1[i] + "*" + valoresAtrib2[i], "N",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
					
					//try
					//{
						val1 = double.Parse(valoresAtrib1[i]);
						val2 = double.Parse(valoresAtrib2[i]);
					//}
					//catch (Exception ex)
	            	//{
	                //	MessageBox.Show(ex.ToString());
	            	//}
					
					valMutlpilicados.Add(val1 * val2);
					
					sumatoria += valMutlpilicados[i];
				}
				
				divisor = sumatoria;
				
				//obtener el dividendo
				//se multiplica el numero de instancias por la desviacion de
				//estandar de cada atributo
				
				desv1 = cdd.calcularDesviacionEstandar(encabezado1);
				desv2 = cdd.calcularDesviacionEstandar(encabezado2);
				
				dividendo = n * desv1 * desv2;
	
				r = divisor / dividendo;
			}
			//catch (Exception ex)
			catch (Exception ex)
            {
               	//MessageBox.Show("Hay valores nulos en los atributos. \n" + ex.ToString());
               	MessageBox.Show("No se puede calcular el coeficiente de correlación de Pearson." +
               	               "\nHay valores nulos en los atributos. \n");
            }
			
			return r;
		}
		
		private double calcularChiCuadrada(string encabezado1, string encabezado2)
		{
			double chiCuadrada = 0;

			DataTable tablaContingencia = calcularTablaContingencia(encabezado1, encabezado2);
			//dataGridView1.DataSource = tablaContingencia;
			
			//o = frecuencia observada
			//e = frecuencia esperada
			//n = numero de tuplas
			
			List<int> o = calcularFrecuenciaObservada(tablaContingencia);
			List<double> e = calcularFrecuenciaEsperada(tablaContingencia);
			int n =calcularNumeroTuplas(tablaContingencia);
			
			//Sumatoria de ((o - e)^2 / o)
			
			//idealmente las listas frecuencia Observada y la esperada deberian de tener
			//la misma cantidad de valores, por lo que se pide el tamano de cualquiera
			for(int i = 0; i < o.Count; i++)
			{
				chiCuadrada += Math.Pow((o[i] - e[i]), 2) / e[i];
			}
			
			return chiCuadrada;
		}
		
		private DataTable calcularTablaContingencia(string encabezado1, string encabezado2)
		{
			//aqui obtiene el index para el atributo en la lista de encabezados
			int c1 = cdd.encabezados.IndexOf(encabezado1);
			int c2 = cdd.encabezados.IndexOf(encabezado2);
			//ese mismo index sirve para sacar la posicion de columna de donde se sacan datos
			
			int cantInstancias = cdd.calcularCantidadInstancias();
			
			DataTable tablaContingencia= new DataTable();
			
			//en la tabla de contingencia
			//las columnas seran del atributo 1
			//y las filas del atributo 2
			
			//dominios para el atributo1
			List<string> dominios1 = cdd.obtenerDominios(encabezado1);
			List<string> dominios2 = cdd.obtenerDominios(encabezado2);
			
			//dominios1.Sort();
			//dominios2.Sort();
			
			//agrega una columna que es odnde estaran los valores posibles para el atributo2
			tablaContingencia.Columns.Add(new DataColumn(" "));
			
			//Agrega los dominios al datatable
			foreach(string dom1 in dominios1)
			{
				tablaContingencia.Columns.Add(new DataColumn(dom1));
			}
			//agrega la columna total al final
			tablaContingencia.Columns.Add(new DataColumn("Total"));
			
			//esto agrega los valores del segundo atributo como "encabezado" de filas
			foreach(string dom2 in dominios2)
			{
				DataRow dr = tablaContingencia.NewRow();
				dr[0] = dom2;
				foreach(string dom1 in dominios1)
				{
					//agrega cero enlas posiciones de conteo
					dr[dom1] = 0;
				}
				tablaContingencia.Rows.Add(dr);
			}
			tablaContingencia.Rows.Add("Total");
			
			//Ahora obtengo los valores que hay en cada celda para cada atributo
			//En el orden que estan, estan relacionados por sus posiciones
			List<string> valores1 = cdd.obtenerValoresParaAtributo(encabezado1);
			List<string> valores2 = cdd.obtenerValoresParaAtributo(encabezado2);
			

			//Recorro cada posicion del data table y muesto las cabeceras de columna y fila
			
			
			for (int f = 0; f < dominios2.Count; f++)
			{
				for (int c = 1; c <= dominios1.Count; c++)
				{

					// checar si la cabecera de columna y fila son iguales a los valores
					// de atributos
					//Para hacerlo recorre todos los valores y los compara con la pos actual
					for(int i = 0; i < valores1.Count; i++)
					{
						if(valores1[i] == tablaContingencia.Columns[c].ColumnName &&
						   valores2[i] == tablaContingencia.Rows[f][0].ToString())
						{
							int contador = int.Parse(tablaContingencia.Rows[f][c].ToString());
							contador++;
							tablaContingencia.Rows[f][c] = contador.ToString();
						}
					}

				}
			}
			
			
			int totalFila = 0;
			int totalCol = 0;
			int totalDeTotales = 0;
			
			
			//sumar los totales de fila y agregarlos a la datatable
			for (int f = 0; f < dominios2.Count; f++)
			{
				totalCol = 0;
				totalFila = 0;
				for (int c = 1; c <= dominios1.Count; c++)
				{
					totalFila += int.Parse(tablaContingencia.Rows[f][c].ToString());
						
				}
				//Esto lo imprime en la posicion que requiero
				tablaContingencia.Rows[f]["Total"] = totalFila;
			}
			
			for (int c = 1; c <= dominios1.Count; c++)
			{
				totalCol = 0;
				totalFila = 0;
				for (int f = 0; f < dominios2.Count; f++)
				{
					totalCol += int.Parse(tablaContingencia.Rows[f][c].ToString());
						
				}
				//Esto lo imprime en la posicion que requiero
				tablaContingencia.Rows[dominios2.Count][c] = totalCol;
			}
			
			//Sumando total de totales
	
			for (int f = 0; f < dominios2.Count; f++)
			{
				totalDeTotales += int.Parse(tablaContingencia.Rows[f]["Total"].ToString());
			}
			//Esto lo imprime en la posicion que requiero
			tablaContingencia.Rows[dominios2.Count]["Total"] = totalDeTotales;

			return tablaContingencia;
		}
		
		//Recibe la tabla de contingencia
		//y retorna una lista con las frecuencias esperadas ordenadas primero por fila y 
		//luego por columna
		private List<double> calcularFrecuenciaEsperada(DataTable tablaContingencia)
		{
			List<double> valoresEsperados = new List<double>();
			
			//Extraigo los totales de la filas y las columnas  
			List<double> totalesCol = new List<double>();
			List<double> totalesFil = new List<double>();

			int ultimaFila = tablaContingencia.Rows.Count - 1;
			int ultimaCol = tablaContingencia.Columns.Count - 1;
			
			int n = calcularNumeroTuplas(tablaContingencia);
			
			//extrae totales filas(los de a lado en la tabla de contingencia)
			for(int i = 0; i < tablaContingencia.Rows.Count-1; i++)
			{
				totalesFil.Add(double.Parse(tablaContingencia.Rows[i][ultimaCol].ToString()));
			}
			
			//extrae totales columnas(los de abajo en la tabla de contingencia)
			for(int i = 1; i < tablaContingencia.Columns.Count-1; i++)
			{
				totalesCol.Add(double.Parse(tablaContingencia.Rows[ultimaFila][i].ToString()));
			}
		
			
			//ahora calculo la fecuencia esperada
			//recorro los totales de filas y dentro  los de columnas
			for(int f = 0; f < totalesFil.Count; f++)
			{
				for(int c = 0; c < totalesCol.Count; c++)
				{
					valoresEsperados.Add( (totalesFil[f] * totalesCol[c]) / n);
				}
			}
			//foreach(double a in valoresEsperados)
			//{
			//	MessageBox.Show(a.ToString());
			//}
			return valoresEsperados;
		}
		
		private List<int> calcularFrecuenciaObservada(DataTable tablaContingencia)
		{
			List<int> valoresObservados = new List<int>();
			
			for(int f = 0; f < tablaContingencia.Rows.Count-1; f++)
			{
				for(int c = 1; c < tablaContingencia.Columns.Count-1; c++)
				{
					valoresObservados.Add(int.Parse(tablaContingencia.Rows[f][c].ToString()));
				}
			}
			
			return valoresObservados;
		}
		
		//Se hace esta por que se puede dar el caso de que haya valores faltantes
		//entonces saca el total de totales de la tablaContingencia
		private int calcularNumeroTuplas(DataTable tablaContingencia)
		{
			int ultimaFila = tablaContingencia.Rows.Count - 1;
			int ultimaCol = tablaContingencia.Columns.Count - 1;
			
			int n = int.Parse(tablaContingencia.Rows[ultimaFila][ultimaCol].ToString());

			return n;
		}
		
		private double calcularTschuprow(double chiCuadrada, int n, string encabezado1, string encabezado2)
		{
			double tschuprow = 0;
			//primero extraigo el indice
			int r = cdd.obtenerCantidadDeDominios(encabezado1);
			int c = cdd.obtenerCantidadDeDominios(encabezado2);
			
			//MessageBox.Show(r.ToString() + " " + c.ToString() );
			
			//la parte de abajo de la formula
			double dividendo = (c - 1) * (r - 1);
			
			dividendo = n * Math.Sqrt(dividendo);
	
			tschuprow = Math.Sqrt(chiCuadrada / dividendo);
			
			return tschuprow;
		}

	}
}
