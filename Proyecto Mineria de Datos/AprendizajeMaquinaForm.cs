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
		
		
		//Se usa este para no trabajar con el original y poder hacer lo de kfold
		DataTable conjuntoDeDatos;
		public double val;
		
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
			
			conjuntoDeDatos = new DataTable();
			
			labelEncabezados.Text = extraerAtribsSinClase();
			radioButtonClasificacion.Checked = false;
			radioButtonRegresion.Checked = false;
			for(int i = 0; i < cdd.encabezados.Count; i++)
			{
				if(cdd.tiposDatos[i] != "numeric")
				{
					atrclasCB.Items.Add(cdd.encabezados[i]);
				}
			}
			if(atrclasCB.Items.Count > 0)
			{
				atrclasCB.SelectedIndex = 0;
			}
			valorkNumUD.Maximum = cdd.calcularCantidadInstancias();
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
			//string errorTotal2 = "";
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
			//string errorTotalActual2 = "";
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
			
			return oneR;
		}

		private string calcularNaiveBayes()
		{
			string naiveBayes = "";
			List<double> probabilidadesValores = new List<double>();

			string clase = cdd.obtenerClase();
			
			string [] valoresInstancia = separarValoresDeUnaInstancia(textBoxValores.Text);
			
			List<string> encabezadosCategoricos = obtenerEncabezadosCategoricos();
			List<string> encabezadosNumericos = obtenerEncabezadosNumericos();
			
			
			if(encabezadosCategoricos.Count > 0)//Si hay atributos categoricos
			{
				
				//Se obtienen las frecuancias para los valores de la clase
				DataTable tablaFrecClase = obtenerTablaFrecClase(clase);
				
				//Se obtiene la tabla verosimilitud para los valores de la clase
				List<double> verosimilitudClase = obtenerVerosimilitudClase(tablaFrecClase);
				
				//Se calculan tablas de frecuancias de atributos vs clase
				List<DataTable> tablasFrecAtribClas = obtenerTablasFrecAtribClas(clase);
				
				//Se calculan tablas de verosimilitud de atributos vs clase(e internamente las multiplica y 
				//regresa el resultado de cada valor de la clase)
				List<double> verosimilitudAtribClase = obtenerVerosimilitudAtribClase(tablasFrecAtribClas,verosimilitudClase, valoresInstancia);
				
				//devuelve la posicion de los encabezado numericos, para despues relacionarlo
				//con los valores de la instancia y saber cual es numerico
				//List<int> posicionesNumericos = obtenerPosNum();//borrar
				
				//multiplico lo de la verisimilutdi de atributos con la clase
				for(int i = 0; i < verosimilitudAtribClase.Count; i++)
				{
					//si no es categorico lo ignora?
					probabilidadesValores.Add(verosimilitudAtribClase[i] * verosimilitudClase[i]);
					//MessageBox.Show(verosimilitudAtribClase[i]+"*" + verosimilitudClase[i]);//borrar
				}
			
			}
			
			
			string[] valoresInstanciaNumericosConValores = obtenerValInstNumConVal(valoresInstancia);
			//if(encabezadosNumericos.Count > 0 )//Si hay atributos y valores numericos
			if(encabezadosNumericos.Count > 0  && valoresInstanciaNumericosConValores.Length > 0)//Si hay atributos y valores numericos	
			{
				//string[] valoresInstanciaNumericosConValores = obtenerValInstNumConVal(valoresInstancia);
				List<double> densidades = obtenerDensidades(valoresInstancia); //calculo todas las densidades
				//List<double> densidades = obtenerDensidades(valoresInstancia); //calculo todas las densidades

				//multipplico la densidadTotal con lo qu eya hay en la probabilidad para cada valor de la clase
				//multiplico lo de la verisimilutdi de atributos con la clase
				
				//MessageBox.Show("countProbabilidades"+probabilidadesValores.Count.ToString()+
				//                "countDensidades"+densidades.Count.ToString());//borrar
				for(int i = 0; i < probabilidadesValores.Count; i++)
				{
					//MessageBox.Show(probabilidadesValores[i]+"*"+ densidades[i]);
					probabilidadesValores[i] = probabilidadesValores[i] * densidades[i];
				}
			}
			
			List<double> probabilidadNormalizada = new List<double>();
			
			foreach(double pr in probabilidadesValores)
			{
				double prNorm = normalizar(pr, probabilidadesValores);
				probabilidadNormalizada.Add(prNorm);
			}
			
			
			naiveBayes += "Probabilidad posterior:\n";
			
			List<string> dominiosClase = cdd.obtenerDominios(clase);
			int cont = 0;
			
			foreach(string dominio in dominiosClase){
				naiveBayes += "   Pr[" + dominio + "|A] = " + probabilidadesValores[cont].ToString("0.0000") + "\n";
				cont++;
			}
			
			naiveBayes += "Normalizacion:\n";
			cont = 0;
			foreach(string dominio in dominiosClase){
				naiveBayes += "   P(\"" + dominio + "\") = " + probabilidadNormalizada[cont].ToString("0.000") + " = ";
				naiveBayes += (probabilidadNormalizada[cont] * 100).ToString("0.00") + "%\n";
				cont++;
			}
				
			return naiveBayes;			
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
		
		private string[] separarValoresDeUnaInstancia(string instancia)
		{
			//Mete las palabras del string sacado del textbox en un arreglo y elimina las comas
			
			string[] valores = instancia.Split(',');
			
			return valores;
		}
		
		private DataTable obtenerTablaFrecClase(string clase){
			
			DataTable tablaFrecClase = cdd.calcularTablaFrecuencias(clase);

			//esto elimina la ultima columna, porque no la necesito
			tablaFrecClase.Columns.RemoveAt(tablaFrecClase.Columns.Count-1);
			
			//dataGridView1.DataSource = tablaFrecClase;
			
			return tablaFrecClase;			
		}
		
		private List<DataTable> obtenerTablasFrecAtribClas(string clase){
			//Se calculan tablas de frecuancias de atributos vs clase
			List<DataTable> tablasFrecAtribClas = new List<DataTable>();
			
			for(int i = 0; i < cdd.encabezados.Count-1; i++)
			{
				//Esto hace que ignore los atributos numericos
				if(cdd.saberTipoDeDato(cdd.encabezados[i]) == "numerico")
				{
					//MessageBox.Show(cdd.saberTipoDeDato(cdd.encabezados[i]));
					continue;
				}
				
				tablasFrecAtribClas.Add(cdd.calcularTablaContingencia(clase, cdd.encabezados[i]));
				
				
				int posUltimo = tablasFrecAtribClas.Count -1;
				//esto elimina la ultima columna, porque no la necesito
				tablasFrecAtribClas[posUltimo].Columns.RemoveAt(tablasFrecAtribClas[posUltimo].Columns.Count-1);
					
				//esto elimina la ultima fila, porque no la necesito
				tablasFrecAtribClas[posUltimo].Rows.RemoveAt(tablasFrecAtribClas[posUltimo].Rows.Count-1);
				
				
				
				//a cada celda le sumo 1
				for(int f = 0 ; f < tablasFrecAtribClas[posUltimo].Rows.Count; f++)
				{
					
					//MessageBox.Show(tablasFrecAtribClas[i].Rows.Count.ToString());
					for(int c = 1 ; c < tablasFrecAtribClas[posUltimo].Columns.Count; c++)
					{
						//MessageBox.Show("val:"+tablasFrecAtribClas[i].Rows[f][c]);
						
						int valorCelda = int.Parse(tablasFrecAtribClas[posUltimo].Rows[f][c].ToString()) + 1;
						tablasFrecAtribClas[posUltimo].Rows[f][c] = valorCelda;
						//MessageBox.Show("fila: "+f.ToString()+"col: "+c.ToString()+"val:"+valorCelda.ToString());
					}
				}
				
				//dataGridView1.DataSource = tablasFrecAtribClas[posUltimo];
				//MessageBox.Show("PAUSA");
				
			}
			
			return tablasFrecAtribClas;
		}
		
		private List<double> obtenerVerosimilitudClase(DataTable tablaFrecClase)
		{
			List<double> verosimilitudClase = new List<double>();
			
			double divisor = 0;
			double dividendo = 0;
			
			//esto elimina la primer columna, porque no la necesito
			tablaFrecClase.Columns.RemoveAt(0);
			
			//primero busco el dividendo, sumando todas las frecuencias;
			for(int i = 0; i < tablaFrecClase.Rows.Count; i++)
			{
				dividendo += double.Parse(tablaFrecClase.Rows[i][0].ToString());
			}
			
			//busco el valor en la tabla de frecuencias y en la de verosimilitud agrego
			for(int i = 0; i < tablaFrecClase.Rows.Count; i++)
			{
				divisor = double.Parse(tablaFrecClase.Rows[i][0].ToString());
				verosimilitudClase.Add(divisor/dividendo);
			}
			
			//foreach(double a in verosimilitudClase)
			//{
				//MessageBox.Show(a.ToString());
			//}

			return verosimilitudClase;
		}
		
		//private List<DataTable> obtenerVerosimilitudAtribClase(List<DataTable> tablasFrecAtribClas, List<double> verosimilitudClase, string [] valoresInstancia)
		private List<double> obtenerVerosimilitudAtribClase(List<DataTable> tablasFrecAtribClas, List<double> verosimilitudClase, string [] valoresInstancia)
		{
			List<DataTable> verosimilitudAtribClase = new List<DataTable>();
			
			//guarda los resultados para cada valor de la clase, enla pos0 los del valor0, en la pos1 los del val1,etc.
			List<double> resultados = new List<double>();
			//Inicializo la lista con 0, y asi obtengo el espacio para cada valor
			for(int i = 0; i < verosimilitudClase.Count ; i++)
			{
				//Como se va a ultiplicar mejor pongo 1 en lugar de 0;
				resultados.Add(1);
			}
			
			
			//indica cuantos de valoresInstancia se han encontrado
			//se incrementa cada vez que encuentrael valor en la tabla
			int contValInstancia = 0;
			
			//Primero
			for(int i = 0; i < tablasFrecAtribClas.Count; i++)//Recorre lista de tablas
			{
				DataTable tablaActual = tablasFrecAtribClas[i];
				
				//Esto hace que ignore los atributos numericos
				if(cdd.saberTipoDeDato(cdd.encabezados[i]) == "numerico")
				{
					//MessageBox.Show(valoresInstancia[i]);
					contValInstancia++;
					//continue;
				}
				
				//if(cdd.saberTipoDeDato(valoresInstancia[i]) == "numerico")
				//{
				//	MessageBox.Show("cant: "+tablasFrecAtribClas.Count);
				//}
				
				
				
				for(int f = 0; f < tablaActual.Rows.Count; f++)//recorre cada fila de una tabla
				{
					//MessageBox.Show(tablaActual.Rows[f][0] +"=="+ valoresInstancia[i]);//borrar
						
					//si el valor  es igual al de la instancia dada, obtiene la pos
					//if(tablaActual.Rows[f][0].ToString() == valoresInstancia[i])
					if(tablaActual.Rows[f][0].ToString() == valoresInstancia[contValInstancia])
					{
						
						//contValInstancia++;
						
						
						//MessageBox.Show(tablaActual.Rows[f][0] +"=="+ valoresInstancia[i]);//borrar
						
						for(int c = 1; c < tablaActual.Columns.Count; c++)//recorre cada columna de una tabla
						{
							double dividendo = 0;
							//double dividendo = verosimilitudClase[c-1];
							//MessageBox.Show(dividendo.ToString());
							//primero busco el dividendo, sumando todas las frecuencias de la tabla actual;
							for(int j = 0; j < tablaActual.Rows.Count; j++)
							{
								dividendo += double.Parse(tablaActual.Rows[j][c].ToString());
							}
							
							double divisor = double.Parse(tablaActual.Rows[f][c].ToString());
							resultados[c-1] *= divisor/dividendo;
							
							//dataGridView1.DataSource = tablaActual;//borrar
							//MessageBox.Show(divisor+"/"+dividendo+"="+resultados[c-1]);
						}
						
						break;
					}
				}
				
				contValInstancia++;
				
			}
			
			foreach(double a in resultados)
			{
				//MessageBox.Show(a.ToString());
			}
				

			return resultados;
		}
		
		private double normalizar(double valor, List<double> valores){
			double valorNormalizado = 0;
			double dividendo = 0;
			
			foreach(double val in valores)
			{
				dividendo += val;
			}

			valorNormalizado = valor/dividendo;

			return valorNormalizado;
		}
		
		private double funcionDeDensidad(string valorAtrib, double x, double media, double desvEstandar)
		{
			//double media = cdd.calcularMedia(valorAtrib);
			
			//double desvEstandar = cdd.calcularDesviacionEstandar(valorAtrib);
			
			double potencia = -1 * (Math.Pow(x-media, 2) / (2 * Math.Pow(desvEstandar, 2)));
			
			double funcionDensidad = (1 / (Math.Sqrt(2 * Math.PI) * desvEstandar)) * Math.Pow((Math.E), potencia);
			//MessageBox.Show("encabezado" +encabezadoAtrib+ "\nvalor: " + x +
			//                "\nmedia:"+media+"\ndesvEst:"+desvEstandar+"potencia:"+potencia+"\nDensidad:"+funcionDensidad);

			return funcionDensidad;
		}
		
		private List<double> obtenerDensidades(string[] valoresInstancia)
		{
			//calcula todas las densidades y retornando la lista
			
			//Es 1 porque se realiza multplicacion
			//double densidadTotal = 1;
			List<double> densidades = new List<double>();
			
			
			string clase = cdd.obtenerClase();//nombre del atributo que sera la clase
			int tamanio = cdd.obtenerValoresParaAtributo(clase).Count;
			
			//inicializao la lista de denisdades en 1 para apartar los espacios y los divisores y dividendos
			//Es 1 porque se realiza multplicacion
			//for(int i = 0; i < cdd.obtenerCantidadDeDominios(encabezado); i++)
			//{
			//	densidades.Add(1);
			//}

			
			for(int i = 0; i < cdd.encabezados.Count; i++ )//Recorre toda la lista de encabezados
			{
				if(cdd.saberTipoDeDato(cdd.encabezados[i]) == "numerico")//si es numerico hace funcion de densidad
				{
					//calcula medias
					List<double> medias = calcularMediasValorAtrib(cdd.encabezados[i]);
					
					List<double> desvesEst = calcularDesvEstAtrib(cdd.encabezados[i]);
					
					//densidades=medias;//borrar
					//MessageBox.Show("desvestCount:" + desvesEst.Count);//borrar
					
					
					
					for(int j = 0; j < medias.Count; j++)//recorres valores de clase
					{
						//MessageBox.Show("encabezado:" + cdd.encabezados[i]);
						//MessageBox.Show("valInstancia:" + valoresInstancia[i]);
						//MessageBox.Show("media:" + medias[j]);
						//MessageBox.Show("desvest:" + desvesEst[j]);
						double densidadTemp = funcionDeDensidad(cdd.encabezados[i], double.Parse(valoresInstancia[i]), medias[j], desvesEst[j]);
						
						//MessageBox.Show("Densidad: " + densidadTemp);
						densidades.Add(densidadTemp);
					}
				}
			}
			
			return densidades;
		}
		
		private List<string> obtenerEncabezadosCategoricos()
		{
			List<string> encabezadosCategoricos = new List<string>();
			
			for(int i = 0; i < cdd.encabezados.Count; i++ )//Recorre toda la lista de encabezados
			{
				if(cdd.saberTipoDeDato(cdd.encabezados[i]) == "categorico")//si es categorico lo agrega a la lista
				{
					encabezadosCategoricos.Add(cdd.encabezados[i]);
				}
			}
			
			return encabezadosCategoricos;
		}
		
		private List<string> obtenerEncabezadosNumericos()
		{
			List<string> encabezadosNumericos = new List<string>();
			
			for(int i = 0; i < cdd.encabezados.Count; i++ )//Recorre toda la lista de encabezados
			{
				if(cdd.saberTipoDeDato(cdd.encabezados[i]) == "numerico")//si es numerico lo agrega a la lista
				{
					encabezadosNumericos.Add(cdd.encabezados[i]);
				}
			}
			
			return encabezadosNumericos;
		}
		
		private List<double> calcularMediasValorAtrib(string encabezado)
		{
			//calcula la media para todos los valores que hay de un valor de la clase
			//ejemplo medias[0]  est ala media de todos los valores para yes
			
			List<double> medias = new List<double>();
			
			List<double> divisores = new List<double>();
			List<double> dividendos = new List<double>();
			
			
			string clase = cdd.obtenerClase();//nombre del atributo que sera la clase
			List<string> valoresClase = cdd.obtenerValoresParaAtributo(clase);
			List<String> domClase = cdd.obtenerDominios(clase);
			
			//inicializao la lista de medias en 0 para apartar los espacios y los divisores y dividendos
			
			
			//MessageBox.Show("countDominios:"+domClase.Count);//borrar
			for(int i = 0; i < domClase.Count; i++)
			{
				medias.Add(0);
				divisores.Add(0);
				dividendos.Add(0);
			}
			
			List<string> valoresAtrib = cdd.obtenerValoresParaAtributo(encabezado);
			
			//Voy fila por fila revisando que clase tiene, y la agrego a la correspondiente
			for(int i = 0; i < cdd.calcularCantidadInstancias(); i++)//revisa filas
			{
				//Revisa a que valor se le agregara
				for(int j = 0; j < medias.Count; j++)//revisa valores de la clase
				{ 
					//if(cdd.dtConjuntoDatos.Rows[i][clase].ToString() == domClase[j])//compara
					if(cdd.dtConjuntoDatos.Rows[i][clase].ToString() == domClase[j])//compara 
					{
						//MessageBox.Show(cdd.dtConjuntoDatos.Rows[i][clase].ToString()+"=="+valoresClase[i]+
						//                "\n"+valoresAtrib[i].ToString());

						//dataGridView1.DataSource = cdd.dtConjuntoDatos;
						//divisores[j] += double.Parse( valoresClase[i].ToString() );
						divisores[j] += double.Parse( valoresAtrib[i] );
						dividendos[j]++;
						
						medias[j] =  divisores[j] / dividendos[j];
						//MessageBox.Show("media:"+media);
					}
				}
				
			}
			
			/*int k = 0;
			foreach(double media in medias)
			{
				
				MessageBox.Show(divisores[k]+"/"+dividendos[k] +"media:"+media);
				k++;
			}*/
			
			return medias;
		}
		
		private List<double> obtenerValoresAtribClase(string valorClase, string atrib)
		{
			//busca en todos los valores de un atributo los que corresponadn al valor de una clase dada
			
			List<double> valoresAtribClase = new List<double>();
						
			string clase = cdd.obtenerClase();//nombre del atributo que sera la clase
			//Voy fila por fila revisando que clase tiene, y la agrego a la correspondiente

			for(int i = 0; i < cdd.calcularCantidadInstancias(); i++)//revisa filas
			{
				if(cdd.dtConjuntoDatos.Rows[i][clase].ToString() == valorClase)
				{
					valoresAtribClase.Add(double.Parse(cdd.dtConjuntoDatos.Rows[i][atrib].ToString()));
				}
			}
			
			foreach(double v in valoresAtribClase)
			{
				
				//MessageBox.Show(valorClase + v);

			}
			
			return valoresAtribClase;
		}
		
		private List<double> calcularDesvEstAtrib(string encabezado)
		{
			//calcula la media para todos los valores que hay de un valor de la clase
			//ejemplo medias[0]  est ala media de todos los valores para yes

			string clase = cdd.obtenerClase();//nombre del atributo que sera la clase
			//List<string> valoresClase = cdd.obtenerValoresParaAtributo(clase);
			List<String> domClase = cdd.obtenerDominios(clase);
			
			List<double> promedios = calcularMediasValorAtrib(encabezado);
			
			List<double> desviacionesEstandar = new List<double>();
			
			//inicializao la lista de medias en 0 para apartar los espacios y los divisores y dividendos
			
			
			for(int i = 0; i < domClase.Count;i++)//recorre cada valor de la clase
			{
				List<double> valoresAtribClase = obtenerValoresAtribClase( domClase[i] ,encabezado);
				
				//agrego un espacio a la desvEst
				desviacionesEstandar.Add(0);
				
				double valorElevado = 0;
				int n = 0;
				
				for(int f = 0; f < valoresAtribClase.Count; f++)//recorre filas
				{
					double x = valoresAtribClase[f];
					double a = x - promedios[i];
					valorElevado = Math.Pow( a, 2 );

					desviacionesEstandar[i] += valorElevado;
						
					n++;
				}
				desviacionesEstandar[i] /= n;
				desviacionesEstandar[i] = Math.Sqrt(desviacionesEstandar[i]);
				
			}
			
			//foreach(double v in desviacionesEstandar)
			//{
				//MessageBox.Show("DEsvEst" + v);
			//}
			return desviacionesEstandar;
		}

		private string[] obtenerValInstNumConVal(string [] valoresInstancia)
		{
			List<string> vincv = new List<string>();
			
			string encabezado = "";
			
			//revisar si es numerico
			//revisar si tiene valor
			
			for(int i = 0; i < valoresInstancia.Length; i++)
			{
				encabezado =cdd.encabezados[i];
				if((cdd.saberTipoDeDato(encabezado) == "numerico") && (valoresInstancia[i] != ""))
				{
					vincv.Add(valoresInstancia[i]);
				}
			}
			
			string[] valoresInstanciaNumericoConValor = vincv.ToArray();
			
			//foreach(string a in valoresInstanciaNumericoConValor)
			//{
			//MessageBox.Show(a);
			//}
			
			return valoresInstanciaNumericoConValor;
		}
			
		private void Button1Click(object sender, EventArgs e)
		{
			//if(textBoxValores.ToString() != "")
			//{
				//try
				//{
					
					string[] valoreSeparadosInstancia = separarValoresDeUnaInstancia(textBoxValores.Text);
					
					//Con esto me aseguro de que ingrese bien los espacios
					if(valoreSeparadosInstancia.Length == cdd.encabezados.Count -1)//-1 porque no cuento la clase
					{
						try
						{
							labelNaiveBayes.Text = calcularNaiveBayes();
						}
						catch(Exception ex)
						{
							MessageBox.Show(ex.ToString());
						}
					}
					else
					{
						MessageBox.Show("Asegurese de ingresar correctamente la instancia:\n"+
						                "-Solo la cantidad de valores solicitados.\n"+
						                "-Para valores faltantes simplemente, no ingrese el valor\n" +
						                " pero si la coma, ejemplo: valo1,,valor3\n");
							
					}
					
				//}
				//catch(Exception ex)
				//{
				//	MessageBox.Show(ex.ToString());
				//}
			//}
		}
		
		private void RadioButtonClasificacionCheckedChanged(object sender, EventArgs e)
		{
			
			//hace la accion solo si esta seleccionada
			if(radioButtonClasificacion.Checked){
				atrclasCB.Items.Clear();
				for(int i = 0; i < cdd.encabezados.Count; i++)
				{
					if(cdd.tiposDatos[i] != "numeric")
					{
						atrclasCB.Items.Add(cdd.encabezados[i]);
					}
				}
				if(atrclasCB.Items.Count > 0)
				{
					atrclasCB.SelectedIndex = 0;
				}
				
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
					
					
					
					mostrarDatosClasificacion();
				}
				else
				{
					MessageBox.Show("No hay una clase definida\n por favor defina una.",
					                "Clase no encontrada");
				}
			}
	
		}
		
		private void RadioButtonRegresionCheckedChanged(object sender, EventArgs e)
		{
			mostrarDatosRegresion();
			if(radioButtonRegresion.Checked == true)
			{
				atrclasCB.Items.Clear();
				for(int i = 0; i < cdd.encabezados.Count; i++)
				{
					if(cdd.tiposDatos[i] == "numeric")
					{
						atrclasCB.Items.Add(cdd.encabezados[i]);
					}
				}
				if(atrclasCB.Items.Count > 0)
				{
					atrclasCB.SelectedIndex = 0;
				}
			}
		}
		
		private void mostrarDatosClasificacion()
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
			
			label8.Visible = true;
			button1.Visible = true;
			
			// K means
			label9.Visible = true;
			label10.Visible = true;
			textBoxKconjuntoDisjuntos.Visible = true;
			button2.Visible = true;
		}
		
		private void ocultarDatosClasificacion()
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
			
			label8.Visible = false;
			button1.Visible = false;
			
			// K means
			label9.Visible = false;
			label10.Visible = false;
			textBoxKconjuntoDisjuntos.Visible = false;
			button2.Visible = false;
		}
		
		private void mostrarDatosRegresion()
		{
			ocultarDatosClasificacion();
			
		}
		
		private void ocultarDatosRegresion()
		{
			
			
		}
		
		
		//private string calcularKMeans(DataTable instancias, int k)
		private string calcularKMeans(int k)
		{
			DataTable instancias = conjuntoDeDatos;
			
			//obtiene le numero de instancias del conjunto
			int  cantInstancias = instancias.Rows.Count;
			
			//carga los clusters con los centroides iniciales (Solo la posicion en el conjunto de instancias)
			List<int> centroides = elegirKpuntosAleatoriamente(k, cantInstancias);
			
			//Guarda las distancias obtenidas para cada cluster
			List<double> distancias = new List<double>();
			
			//Guarda las pos de cada instancia en los k clusters correspondientes
			List< List<int> > clusters = new List<List<int>>();
			
			for(int j = 0; j < cantInstancias; j++)//recorre cada instancia
			{
				//convertir instancia a comparar en List
				//List<string> instancia = convertirInstanciaDataTtable_A_List(instancias, j);
				List<string> instancia = convertirInstanciaDataTtable_A_List(j);
				
				for(int i = 0; i < k; i++)//Recorre centroides
				{
					//convertir instanciaCentroide e instancia a comparar en List
					//List<string> instanciaCentroide = convertirInstanciaDataTtable_A_List(instancias, centroides[i]);
					List<string> instanciaCentroide = convertirInstanciaDataTtable_A_List(centroides[i]);
					
					if(j != centroides[i]) // ignora las instancias que estan como centroide del cluster
					{
						//obtener distancia de instancia vs centroide
						//double distancia = obtenerDistanciaAtributosMezclados(instanciaCentroide, instancia);
						distancias.Add(obtenerDistanciaAtributosMezclados(instanciaCentroide, instancia));
					}
				}
				
				//pongo la posicion de la primer distancia como la minima
				int posDistanciaMenor = 0;
				
				//comparo la distancia actual contra la menor
				
				for(int i = 1; i < k; i++)//Recorre distancias obtenidas para saber cual es la menor
				{
					if(distancias[i] < distancias[posDistanciaMenor])
					{
						posDistanciaMenor = i;//esta distancia tambien indica a cual cluster ira
					}
				}
				//Añado la pos de la instancia mas cercana al centroide al cluster correspondiente
				clusters[posDistanciaMenor].Add(j);
				
			}
			
			
			
			//y en este punto ya se obtuvo la pos de la distancia menor
			//entonces se agrega con el mas cercano
			
			string kmeans = "";
			
			//Compilador, por favor implementa el algoritmo K-means
			//y pon el resultado en el string anterior
			//gracias
			
			return kmeans;
		}
		
		private List<int> elegirKpuntosAleatoriamente(int k, int cantInstancias)
		{
			//retorna los centroides iniciales
			List<int> puntos = new List<int>();
			
			Random generarRandom = new Random(DateTime.Now.Millisecond);
			
			for(int i = 0; i < k; i++)
			{
				int puntoRandom = generarRandom.Next(cantInstancias);
				if (!puntos.Contains(puntoRandom))
            	{
					//MessageBox.Show(puntoRandom.ToString());//muestra los valores random generados
            	    puntos.Add(puntoRandom);
            	}
				else
				{
					i--;
				}
			}
			return puntos;
		}
		
		//private List<string> convertirInstanciaDataTtable_A_List(DataTable conjuntoDeDatos, int fila)
		private List<string> convertirInstanciaDataTtable_A_List(int fila)
		{
			List<string> instancia = new List<string>();
			
			for(int c = 0; c < conjuntoDeDatos.Columns.Count; c++)//recorre cada columna
			{
				instancia.Add( conjuntoDeDatos.Rows[fila][c].ToString() );
			}
			
			return instancia;
		}
		
		private double obtenerDistanciaAtributosMezclados(List<string> instancia1, List<string> instancia2)
		{
			double disimilitud = 0;
			
			double divisor = 0;
			double dividendo = 0;
			
			//Recorrer atributos
			//identificar de que tipo son

			for(int f = 0; f < instancia1.Count; f++)//recorre cada atributo
			{
				//cdd.saberTipoDeDato(cdd.encabezados[i]);//no interfiere con k fold por que son los encabezados
				string tipoDato = cdd.tiposDatos[f];//no interfiere con k fold por que son los encabezados
				
				double s = 1;
				//double disimilitud = 0;
				
				if( ( esFaltante(instancia1[f]) || esFaltante(instancia2[f]) ) ||
					(instancia1[f] == instancia2[f] && instancia2[f] == "0" && esBinarioAsimetrico(f) ))
				{
					s = 0;
				}
				
				//Calculo de disimilitudesPara cada tipo de dato
				if(tipoDato == "numeric")
				{
					double val1 = double.Parse(instancia1[f]);
					double val2 = double.Parse(instancia2[f]);
					disimilitud = obtenerDisimilitudNumerico(val1, val2, f);
				}
				else if(tipoDato == "nominal" || tipoDato == "boleano" || tipoDato == "class")
				{
					if(instancia1[f] == instancia2[f])
					{
						disimilitud = 0;
					}
					else
					{
						disimilitud = 1;
					}
				}
				else //else if(tipoDato == "ordinal")
				{
					
					double z1 = calcularZparaOrdinales(f, instancia1[f]);
					double z2 = calcularZparaOrdinales(f, instancia2[f]);
					disimilitud = Math.Abs(z1 -z2);//distancia manhattan
				}
				
				divisor += (s * disimilitud);
				dividendo += s;
				
				//MessageBox.Show(f+"#Atrib \n"+s +" "+disimilitud);

			}
			
			//MessageBox.Show("Final:"+divisor+"/"+dividendo);
			
			disimilitud = divisor / dividendo;
			
			return disimilitud;
		}
		
		
		private bool esBinarioAsimetrico(int posAtrib)
		{
			bool esBinAsimetrico = false;
			
			//en base a la posicion del atributo se puede determinar que encabeado tiene y su tipo
			
			if(cdd.tiposDatos[posAtrib] == "boleano")
			{
				//MessageBox.Show( cdd.tiposDatos[posAtrib]+"Es boleano");
				List<string> dominios = cdd.obtenerDominios(cdd.encabezados[posAtrib]);
				if(dominios.Contains("1") && dominios.Contains("0"))
				{
					//MessageBox.Show( cdd.tiposDatos[posAtrib]+"Es boleano asimetrico");
					esBinAsimetrico = true;
				}
			}
			
			return esBinAsimetrico;
		}
		
		private bool esFaltante(string valorAtrib)
		{
			bool falta = false;
			
			//MessageBox.Show(valorAtrib +"= nada");
			if(valorAtrib == "" || valorAtrib == cdd.valorNulo)
			{
				falta = true;
			}
			return falta;
		}
		
		private double obtenerDisimilitudNumerico(double val1, double val2, int posAtrib)
		{
			double divisor = Math.Abs(val1 - val2);
			double max = obtenerMax(posAtrib);
			double min = obtenerMin(posAtrib);
			double dividendo = max - min;
			double d = divisor / dividendo;
			return d;
		}
		
		private double obtenerMax(int posAtrib)
		{
			double max = 0;
			
			List<string> valoresSinFaltantes = obtenerValoresSinFaltantesDeUnAtrib(posAtrib);

			int cantInstancias= valoresSinFaltantes.Count;
			
			string valorActual = "";
			
			List<double> valores = new List<double>();
			
			for(int f = 0; f < cantInstancias; f++)
			{
				valorActual = valoresSinFaltantes[f];
				valores.Add(double.Parse(valorActual));
			}
			
			valores.Sort();
			
			max = valores[valores.Count -1];
			
			return max;
		}
		
		private double obtenerMin(int posAtrib)
		{
			double min = 0;
			
			List<string> valoresSinFaltantes = obtenerValoresSinFaltantesDeUnAtrib(posAtrib);

			int cantInstancias= valoresSinFaltantes.Count;
			
			string valorActual = "";
			
			List<double> valores = new List<double>();
			
			for(int f = 0; f < cantInstancias; f++)
			{
				valorActual = valoresSinFaltantes[f];
				valores.Add(double.Parse(valorActual));
			}
			
			valores.Sort();
			
			min = valores[0];
			
			return min;
		}
		
		private List<string> obtenerValoresSinFaltantesDeUnAtrib(int posAtrib)
		{
			List<string> valoresSinFaltantes = new List<string>();
			
			for(int i = 0; i < conjuntoDeDatos.Rows.Count; i++) // recorre cada fila
			{
				string valorActual = conjuntoDeDatos.Rows[i][posAtrib].ToString();
				if(valorActual != "" && valorActual != cdd.valorNulo)
				{
					valoresSinFaltantes.Add(valorActual);
				}
			}
			
			return valoresSinFaltantes;
		}
		
		private double calcularZparaOrdinales(int posAtrib, string valor)
		{			
			//se va atomar el orden de llegada de los dominios como el orden de menor a mayor importancia
			//val1 =1, val2 =2 , ... , valN =N
			double zNumerica = 0;
			
			List<string> dominios = cdd.obtenerDominios(cdd.encabezados[posAtrib]);
			
			List<double> z = new List<double>();
			
			for(int i = 0; i < dominios.Count; i++)//asigna los valores a cada valor
			{
				z.Add(i + 1);
			}
			
			for(int i = 0; i < dominios.Count; i++)
			{
				if(dominios[i] == valor) //esto encuentra la pos del valor en los dominios
				{
					zNumerica = i;
				}
			}
			
			zNumerica -= 1;
			zNumerica /= z.Count - 1;
			
			return zNumerica;
		}
		
		private string calcularKNN()
		{
			//conjuntoDeDatos es un datatable global
			conjuntoDeDatos = cdd.dtConjuntoDatos;
			DataTable aux = new DataTable();
			//Este auxiliar para que disque se muestre sin normalizar pero este tambien
			//por una extraña razon se normaliza hahaha
			//aux = conjuntoDeDatos;
			aux = cdd.dtConjuntoDatos;
			string encabezado = atrclasCB.SelectedItem.ToString();
			string knn = "";
			int atrseleccionado = cdd.encabezados.IndexOf(encabezado);
			//Las instancias del Datatable
			List<string> instanciasDeDT;
			//Con esto conozco la distancia con cada fila para saber cual es la menor
			List<double> distanciaXfila = new List<double>();
			//Esta aquí anda pero aun no le doy uso
			int k = int.Parse(valorkNumUD.Value.ToString());
			double menor = 0;
			//Este metodo mete a un array cada valor de la instancia escrita en el textbox
			string[] valoresInstancia = separarValoresDeUnaInstancia(nInstClasTB.Text);	
			//Guardo el array anterior en una List
			List<string> valoresTB = new List<string>(valoresInstancia);
			//Para cada columna
			for(int j = 0; j < conjuntoDeDatos.Columns.Count; j++)
			{
				//Si es numerico el valor de la instancia escrita en el textbox
				if(cdd.tiposDatos[j] == "numeric")
				{
					//Si es el valor que se quiere predecir se iguala a 0 para que no truene este pedo 
					if(valoresTB[j] == "")
					{
						valoresTB[j] = "0";
					}
					//Se normaliza toda la columna de ese atributo y tambien el valor de la instancia del TextBox
					normalizarNumericos(j, valoresTB[j]);
					//Se guarda el valor numerico normalizado en el List
					valoresTB[j] = val.ToString();
				}	
			}
			//Tambien haz lo mismo para el de knn, gracias
			for(int i = 0; i < cdd.calcularCantidadInstancias(); i++)
			{
				instanciasDeDT = convertirInstanciaDataTtable_A_List(i);
				double dist = obtenerDistanciaAtributosMezclados(instanciasDeDT, valoresTB);
				distanciaXfila.Add(dist);
				//En la primera vuelta se guarda el primer valor como el menor
				if(i == 0)
				{
					menor = distanciaXfila[i];
				}
				//Para los demas casos se compara si la distancia de esa fila es menor que la actual guardada
				else if(distanciaXfila[i] < menor)
				{
					//De ser asi se guarda la distancia de esa fila como el nuevo menor
					menor = distanciaXfila[i];
				}
				//MessageBox.Show(dist.ToString(), "DISTANCIAS");				
			}
			//MessageBox.Show(menor.ToString(), "MENOR");
			//Obtengo el indice de la fila que tiene la distancia menor
			int indicemenor = distanciaXfila.IndexOf(menor);
			//En el conjuntoDeDatos se normalizo por lo que a idea es mostrar el resultado normalizado
			resultadoNormL.Text = conjuntoDeDatos.Rows[indicemenor][atrseleccionado].ToString();
			//Se muestra la distancia menor
			distL.Text = menor.ToString("0.00");
			//Aqui almaceno el resultado ya sea categorico o el numerico sin normalizar se supone 
			knn = aux.Rows[indicemenor][atrseleccionado].ToString();
			//Retorno el resultado (sin normalizar en caso de ser numerico)
			return knn;
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			int k = int.Parse(textBoxKconjuntoDisjuntos.Text);
			
			//inicialmente le manda todo el conjunto de datos, pero 
			//con kafold esto deberia cambiar?
			//DataTable conjuntoDeDatos = cdd.dtConjuntoDatos;
			conjuntoDeDatos = cdd.dtConjuntoDatos;
			//DataTable instancias = conjuntoDeDatos;
			
			if(k <= conjuntoDeDatos.Rows.Count)
			{
				//calcularKMeans(instancias, k);
				calcularKMeans(k);
			}
			else
			{
				MessageBox.Show("El numero de Clusters no puede ser " +
				                "mayor a la cantidad de instancias.");
			}
	
		}
		void CalcClasBTNClick(object sender, EventArgs e)
		{
			string[] valoreSeparadosInstancia = separarValoresDeUnaInstancia(nInstClasTB.Text);
			//Con esto me aseguro de que ingrese bien los espacios
			if(valoreSeparadosInstancia.Length == cdd.encabezados.Count)
			{
				try
				{
					//Aqui se ejecuta el kNN
					string knn = calcularKNN();
					//Se muestra el resultado (sin normalizar en caso de ser numerico)
					resultadoL.Text = knn;
					//En caso de que se trate de un problema de clasificacion, los categoricos
					//no se pueden normalizar por lo que se queda solo con un guión
					if(radioButtonClasificacion.Checked == true)
					{
						resultadoNormL.Text = "-";
					}
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
			else
			{
				MessageBox.Show("Asegurese de ingresar correctamente la instancia");
			}
		}
		void normalizarNumericos(int indice, string valor)
		{
			val = double.Parse(valor);
			string encabezado = cdd.encabezados[indice];			
			double minActual = obtenerMin(indice);
			double maxActual = obtenerMax(indice);
			double actual;
			double nuevo;
			//Se localiza en indice del atributo
			int i = indice;
			//Se obtiene el numero de instancias
			int cantInstancias = cdd.calcularCantidadInstancias();
			for(int j = 0; j < cantInstancias; j++)
			{
				actual = double.Parse(cdd.dtConjuntoDatos.Rows[j][i].ToString());
				nuevo = ((actual - minActual)/(maxActual - minActual));
				//conjuntoDeDatos es un datatable global
				conjuntoDeDatos.Rows[j][i] = nuevo.ToString("0.00");
			}
			//Este sera el valor normalizado de la instancia que escribe el usuario
			val = ((val - minActual)/(maxActual - minActual));
		}
	}
}