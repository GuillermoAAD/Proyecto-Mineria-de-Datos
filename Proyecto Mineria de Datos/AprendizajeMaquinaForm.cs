/*
 * Created by SharpDevelop.
 * User: Chu
 * Date: 20/11/2019
 * Time: 4:51 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;

namespace Proyecto_Mineria_de_Datos
{
	/// <summary>
	/// Description of AprendizajeMaquinaForm.
	/// </summary>
	public partial class AprendizajeMaquinaForm : Form
	{
		
		public ConjuntoDeDatosExtendido cdd;// cdd = conjunto de datos
		
		public AprendizajeMaquinaForm(ConjuntoDeDatosExtendido cddx)
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
			
			labelEncabezados.Text = extraerAtribsSinClase();
			radioButtonClasificacion.Checked = false;
			radioButtonRegresion.Checked = false;

		}
		
		private string calcularZeroR ()
		{
			string clase = cdd.obtenerClase();
			
			string valorClase = "";
			
			DataTable tablaFrec = cdd.calcularTablaFrecuencias(clase);
			
			//esto me deja solo con las columnas necesarias
			tablaFrec.Columns.RemoveAt(2);
			
			//Se que en la segunda col estan los datos que necesito
			//entonces con un for busco el mas repetido			
			
			int mayor = 0;
			
			for(int i = 0; i < tablaFrec.Rows.Count; i++)
			{
				string valorCelda = tablaFrec.Rows[i][1].ToString();
				int celdaInt = int.Parse(valorCelda);
				
				if(celdaInt >= mayor){
					mayor = celdaInt;
					valorClase = tablaFrec.Rows[i][0].ToString();
				}
			}
			
			//esto muestra la tabla de frecuencia en el datagridview
			//dataGridView1.DataSource = tablaFrec;

			return valorClase;			
		}
		
		private string calcularOneR(){
			
			string clase = cdd.obtenerClase();
			
			//para la tabla de frecuencia de atrib vs clase
			
			
			//los siguientes variables se llenaran conlos valores correspondientes
			//al modelo final
			//se extraen para cada atributo en cada ciclo, y ahi mismo se eavlua cual es el 
			// atributo con el error total mas pequeno
			
			//Las siguientes tres listas se relacionan por su posicion
			//las dos primeras en conjunto conforman las reglas
			
			
			//nombre del atributo con el error total mas pequeno
			string nombreAtribFinal = "";
			//guarda losposibles valores para el atributo con el error mas pequeno
			List<string> valoresAtrib = new List<string>();
			//guarda los valores que corresponde con los valores de atrib
			List<string> valoresClass= new List<string>();
			//guarda los errores(en base a las reglas) para cada valor posible del atrib,, 
			List<string> errores = new List<string>();
			//guarda el valor del error total
			string errorTotal2 = "";
			double errorTotal = 0;
			
			//valores para la pos actual
			//nombre del atributo con el error total mas pequeno
			string nombreAtrib = "";
			//guarda losposibles valores para el atributo con el error mas pequeno
			List<string> valoresAtribActual = new List<string>();
			//guarda los valores que corresponde con los valores de atrib
			List<string> valoresClassActual= new List<string>();
			//guarda los errores(en base a las reglas) para cada valor posible del atrib,, 
			List<string> erroresActual = new List<string>();
			//guarda el valor del error total
			string errorTotalActual2 = "";
			double errorTotalActual = 0;
			
			int divisorTotal = 0;
			int dividendoTotal = 0;
			
			
			

			//Se calculan tablas de frecuancias de atributos vs clase
			
			for(int i = 0; i < cdd.encabezados.Count; i++) // este for me cambie entre atributos
			{
				//extrae el nombre del artib
				nombreAtrib =cdd.encabezados[i];
				
				//evita que se haga la tabla clase vs clase
				if(clase != cdd.encabezados[i])
				{
					DataTable tablaFrec = cdd.calcularTablaContingencia(clase, cdd.encabezados[i]);
					
					//esto elimina la ultima columna, porque no la necesito
					tablaFrec.Columns.RemoveAt(tablaFrec.Columns.Count-1);
					
					//esto elimina la ultima fila, porque no la necesito
					tablaFrec.Rows.RemoveAt(tablaFrec.Rows.Count-1);
					
					
					//esto muestra la tabla de frecuencia en el datagridview
					//dataGridView1.DataSource = tablaFrec;
					
					//Es una pausa para ver todas las tablas generadas
					//MessageBox.Show("PAUSA");
					
					divisorTotal = 0;
					dividendoTotal = 0;
					
					//Ahora
					//Encuentra la relación de atributo-clase más frecuente.
					//Construye reglas que asignen la clase más
					//frecuente a dicho valor del atributo.
					
					
					//del datatable cada fila es un valor de atributo
					//y cada clase un valor de clase
					
					
					//comentar para ver todas las reglas
					valoresAtribActual = new List<string>();
					valoresClassActual = new List<string>();
					
					for(int f = 0; f < tablaFrec.Rows.Count; f++) // cambia entre filas
					{
						
						//por defecto inicializa las variables con la primer posicion
						
						int mayor = int.Parse(tablaFrec.Rows[f][1].ToString());
						int fPosMayor = f;
						int cPosMayor = 1;
						
						//esto agrega los nombres de los posibles valores al a lista de la pos actual
						
						string celdaActual = tablaFrec.Rows[f][0].ToString();
						
						valoresAtribActual.Add(celdaActual);
						
						//valoresAtrib.Add( tablaFrec.Rows[f][0].ToString());
						//MessageBox.Show(celdaActual);
						
						int dividendo = 0;
						int divisor = 0;
							
						
						for(int c = 1; c < tablaFrec.Columns.Count; c++)//cambia entre columnas
						{
							int actual = int.Parse(tablaFrec.Rows[f][c].ToString());
							//obtener el mayor de cada valor de atributo-clase
							//si guardo la posicion del mas frecuente puedo obtener
							//- valor atributo
							//- valor clase
							//- frecuencia donde coinciden los dos anteriores
							
							//MessageBox.Show("Nuevo mayor: " + actual.ToString()  + ">" + mayor.ToString());
							
							 
							//si el valor de la celda actual es mayor al mayor, llena las variables con los datos de la actual
							if(actual > mayor)
							{
								mayor = actual;								
								cPosMayor = c;
							}
							//si no las variables siguen siendo las mismas
							
							dividendo += actual;
							divisor = dividendo - mayor;
							//MessageBox.Show("divisor: "+ divisor + "\ndividendo: " + dividendo + "\nactual: " + actual + "\nmayor:" + mayor);
							
						}
						//MessageBox.Show("divisor: "+ divisor + "dividendo: " + dividendo);
						
						divisorTotal+= divisor;
						dividendoTotal+= dividendo;
						errorTotalActual = double.Parse(divisorTotal.ToString()) / double.Parse(dividendoTotal.ToString());
						//MessageBox.Show("divisor: "+ divisorTotal + "dividendo: " + dividendoTotal);
							
						//valoresClassActual.Add(tablaFrec.Rows[f][cPosMayor].ToString());
						valoresClassActual.Add(tablaFrec.Columns[cPosMayor].ColumnName);
						
						//revisa sila frecuenciaMayor es igual a otra frecuencia del mismo valor del trib para cada clase
						//con el fin de agregarle un  * si encuentra coincidencias
						for(int r = 1; r < tablaFrec.Columns.Count; r++)
						{
							
							//ignora la celda de la pos mayor
							if(r == cPosMayor)
							{
								//MessageBox.Show("ignoro:" + r);
								continue;
							}
							
							//MessageBox.Show(tablaFrec.Rows[f][r] +"=="+ tablaFrec.Rows[f][cPosMayor]);
							if (tablaFrec.Rows[f][r].ToString() == tablaFrec.Rows[f][cPosMayor].ToString())
							{
								valoresClassActual[valoresClassActual.Count - 1] += "*";
							}
						}
						
						//MessageBox.Show(nombreAtrib + " -> " + tablaFrec.Columns[cPosMayor].ColumnName);

						//MessageBox.Show("CLASs mayor: " + tablaFrec.Columns[cPosMayor].ColumnName);
						
					}
					
					//ponemos el primer errortotal en la variable, ya que 0 hace qu eno se cumpla
					if(i == 0)
					{
						//hago mas grande el error total  que el erorr total del primer atributo para que pueda entrar
						//al siguiente if
						errorTotal = errorTotalActual + 1;
					}
					
					//Aqui se ponen los valores en las variables finales
					//MessageBox.Show("errAct: " + errorTotalActual + " errtot: " + errorTotal);
					if(errorTotalActual < errorTotal )
					{
						errorTotal = errorTotalActual;
						
						valoresAtrib = new List<string>();
						valoresAtrib = valoresAtribActual;
						nombreAtribFinal = nombreAtrib;
						valoresClass = new List<string>();
						valoresClass = valoresClassActual;						
					}
					
					//valoresAtrib = valoresAtribActual;
				}
			}
						
			string oneR = nombreAtribFinal + " \n";
			
			for(int i = 0; i < valoresAtrib.Count; i++)
			{
				oneR += valoresAtrib[i] + " -> " + valoresClass[i] + "\n";
			}
			
			//labelOneR.Text = oneR;
			return oneR;
		}

		
		private void calcularNaiveBayes()
		{
			labelNaiveBayes.Text = textBoxValores.Text;
			
		}
		
		private string extraerAtribsSinClase()
		{
			string encabezadosString = "";
			for(int i = 0; i < cdd.encabezados.Count-1 ; i++)
			{
				encabezadosString += cdd.encabezados[i];
				if(i < cdd.encabezados.Count -2)
				{
					encabezadosString += ",";
				}
			}
			return encabezadosString;
		}
		
		
		///private bool revisarSiValorE
		
		void Button1Click(object sender, EventArgs e)
		{
			
			
			
		}
		void RadioButtonClasificacionCheckedChanged(object sender, EventArgs e)
		{
			
			//hace la accion solo si esta seleccionada
			if(radioButtonClasificacion.Checked){
				//Revisa si existe una clase definida, si no, no puede realizar ninguna operacion
			// y no abre el form de aprendizaje maquina
	 			if( cdd.obtenerClase() != "")
				{
					labelZeroR.Text = calcularZeroR();
				
				
					//si todos los atributos son categoricos hace este
					foreach(string atrib in cdd.encabezados)
					{
						if(cdd.saberTipoDeDato(atrib) == "categorico")
						{
							labelOneR.Text = calcularOneR();
							
						}
						else
						{
							labelOneR.Text = "No se puede calcular porque no todos los atributos son categoricos";
						}
					}
					calcularNaiveBayes();
					
					
					mostrarDatosClasificacion();
				}
				else
				{
					MessageBox.Show("No hay una clase definida\n por favor defina una.",
					                "Clase no encontrada");
				}
			}
	
		}
		void RadioButtonRegresionCheckedChanged(object sender, EventArgs e)
		{
			mostrarDatosRegresion();
	
		}
		
		void mostrarDatosClasificacion()
		{
			ocultarDatosRegresion();
			
			label1.Visible = true;
			labelZeroR.Visible =true;
			label2.Visible = true;
			labelOneR.Visible = true;
			
			label3.Visible = true;
			label4.Visible = true;
			
			labelEncabezados.Visible = true;
			textBoxValores.Visible = true;
			labelNaiveBayes.Visible = true;
			
			
		}
		
		void ocultarDatosClasificacion()
		{
			label1.Visible = false;
			labelZeroR.Visible = false;
			label2.Visible = false;
			labelOneR.Visible = false;
			
			label3.Visible = false;
			label4.Visible = false;
			
			labelEncabezados.Visible = false;
			textBoxValores.Visible = false;
			labelNaiveBayes.Visible = false;
		}
		
		void mostrarDatosRegresion()
		{
			ocultarDatosClasificacion();
			
		}
		
		void ocultarDatosRegresion()
		{
			
		}
		
	}
}
