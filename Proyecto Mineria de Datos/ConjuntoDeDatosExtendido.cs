/*
 * Created by SharpDevelop.
 * User: Chu
 * Date: 12/11/2019
 * Time: 2:27 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Proyecto_Mineria_de_Datos
{
	/// <summary>
	/// Description of ConjuntoDeDatosExtendido.
	/// </summary>
	public class ConjuntoDeDatosExtendido
	{
		//Esta clase rescata todos los datos obtenidos para trabajar con ellos
		//Algunos de estos valores son extraidos de lo obtenido por las clases formatoDATA,
		//formatoCSV, y entrada de datos. y algunos otros son obtenidos aqui mismo.
		
		
		public string nombreConjuntoDatos;
		public string comentarios;
		
		//Variables que en realidad son los campos  de informacion de attribute(Por eso no 
		//hay variable attribute, ya que se conforma de los siguientes 3)
		public List<String> encabezados;
		public List<String> tiposDatos;
		public List<String> dominios;//aqui se alamcenanlas expresiones regulares
		
		//Variable que se utiliza cuando hay valores nulos
		public string valorNulo;
		
		//Son los atributos ya existentes pero separados en
		// numerico y categorico
		public List<String> atributosNumeric;// tal vez no se ocupen
		public List<String> atributosNominal;//
		
		//Base de Datos (Aqui se encuentran los datos con los que se va a trabajar)
		public DataTable dtConjuntoDatos;
		
		public ConjuntoDeDatosExtendido()
		{
			this.nombreConjuntoDatos = "";
			this.comentarios = "";
			this.encabezados = new List<string>();
			this.tiposDatos = new List<string>();
			this.dominios = new List<string>();
			this.valorNulo = "";
			this.atributosNumeric = new List<string>();
			this.atributosNominal = new List<string>();
			this.dtConjuntoDatos = new DataTable();
		}
		
		public int calcularCantidadInstancias()
		{
			return dtConjuntoDatos.Rows.Count;
		}
		
		public int calcularCantidadAtributos()
		{
			return dtConjuntoDatos.Columns.Count;
		}
		
		public int calcularValoresFaltantes()
		{
			int cantidadInstancias = calcularCantidadInstancias();
			int cantidadAtributos = calcularCantidadAtributos();
			int numeroValoresFaltantes = 0;
			
			for(int i = 0; i < cantidadInstancias; i++)
			{
				for(int j = 0; j < cantidadAtributos; j ++)
				{
					if(dtConjuntoDatos.Rows[i][j].ToString() == "" ||
					   dtConjuntoDatos.Rows[i][j].ToString() == valorNulo)
					{
						numeroValoresFaltantes ++;
					}
				}
			}
			
			return numeroValoresFaltantes;
		}
		
		public double calcularProporcionValoresFaltantes()
		{
			int cantidadInstancias = calcularCantidadInstancias();
			int cantidadAtributos = calcularCantidadAtributos();
			int numeroValoresFaltantes = calcularValoresFaltantes();
			
			double numValoresTotales = cantidadInstancias * cantidadAtributos;
			double proporcionValoresFaltantes = 0;
			
			
			proporcionValoresFaltantes = numeroValoresFaltantes * 100;
			proporcionValoresFaltantes /= numValoresTotales;
			
			return proporcionValoresFaltantes;
		}
		
		
		//#######Para atributos con valores NUMERICOS#######
		
		public double calcularMedia(string encabezadoAtributo)
		{
			//aqui obtiene el index para el atributo en la lista de encabezados
			int c = encabezados.IndexOf(encabezadoAtributo);
			//ese mismo index sirve para sacar la posicion de columna de donde se saccan datos
			int cantInstancias= calcularCantidadInstancias();
			
			//cuenta las celdas donde si exista un valor
			int contador = 0;
			
			double media = 0;
			
			string valorCelda = "";
			
			for(int f = 0; f < cantInstancias; f++)
			{
				valorCelda = dtConjuntoDatos.Rows[f][c].ToString();
				if(valorCelda != "" && valorCelda != valorNulo)
				{
					media += double.Parse(valorCelda);
					contador++;
				}
			}
			media /= contador;
			
			return media;
		}
		
		public double calcularMediana(string encabezadoAtributo)
		{
			//aqui obtiene el index para el atributo en la lista de encabezados
			int c = encabezados.IndexOf(encabezadoAtributo);
			//ese mismo index sirve para sacar la posicion de columna de donde se saccan datos
			int cantInstancias= calcularCantidadInstancias();
			
			double mediana = 0;
			
			List<double> valores = new List<double>();
			
			string valorCelda = "";
			
			for(int f = 0; f < cantInstancias; f++)
			{
				valorCelda = dtConjuntoDatos.Rows[f][c].ToString();
				if(valorCelda != "" && valorCelda != valorNulo)
				{
					valores.Add(double.Parse(valorCelda));
				}
			}
			valores.Sort();
			
			mediana = valores[valores.Count/2];
			
			return mediana;
		}
		
		public double calcularModa(string encabezadoAtributo)
		{
			//aqui obtiene el index para el atributo en la lista de encabezados
			int c = encabezados.IndexOf(encabezadoAtributo);
			//ese mismo index sirve para sacar la posicion de columna de donde se saccan datos
			int cantInstancias= calcularCantidadInstancias();
			
			double moda = 0;
			
			int mayor = 0;
			int pos = 0;
			
			List<double> valores = new List<double>();
			
			//van a estar relacionadas los valores de las siguientes dos tablas por su indice
			List<double> valoresSimples = new List<double>();
			List<int> repeticiones = new List<int>();
			
			string valorCelda = "";
			
			for(int f = 0; f < cantInstancias; f++)
			{
				valorCelda = dtConjuntoDatos.Rows[f][c].ToString();
				if(valorCelda != "" && valorCelda != valorNulo)
				{
					valores.Add(double.Parse(valorCelda));
				}
			}
			valores.Sort();
			
			valoresSimples.Add(valores[0]);
			repeticiones.Add(1);
			
			moda=valoresSimples[0];
			
			for(int i = 1; i < valores.Count; i++)
			{
				if(valores[i].ToString() == valoresSimples[pos].ToString())
				{
					repeticiones[pos] += 1;
				}
				else{
					valoresSimples.Add(valores[i]);
					repeticiones.Add(1);
					pos++;
				}
			}

			for(int i = 0; i < repeticiones.Count; i++)
			{
				if(repeticiones[i] >= mayor)
				{
					mayor = repeticiones[i];
					moda = valoresSimples[i];
					
				}
			}

			return moda;
		}
		
		public double calcularDesviacionEstandar(string encabezadoAtributo)
		{
			double promedio = calcularMedia(encabezadoAtributo);
			int n = 0;
			
			double desviacionEstandar = 0;

			//aqui obtiene el index para el atributo en la lista de encabezados
			int c = encabezados.IndexOf(encabezadoAtributo);
			//ese mismo index sirve para sacar la posicion de columna de donde se saccan datos
			int cantInstancias= calcularCantidadInstancias();
			
			double valorElevado = 0;
			
			string valorCelda;
			
			for(int f = 0; f < cantInstancias; f++)
			{
				valorCelda = dtConjuntoDatos.Rows[f][c].ToString();
				if(valorCelda != "" && valorCelda != valorNulo)
				{
					double x = double.Parse(valorCelda);
					double a = x - promedio;
					valorElevado = Math.Pow( a, 2 );

					desviacionEstandar += valorElevado;
						
					n++;
				}
			}
			
			desviacionEstandar /= n;
			
			desviacionEstandar = Math.Sqrt(desviacionEstandar);
			
			return desviacionEstandar;
		}
		
		
		//#######Para atributos con valores CATEGORICOS#######
		
		public DataTable calcularTablaFrecuencias(string encabezadoAtributo)
		{
			//aqui obtiene el index para el atributo en la lista de encabezados
			int c = encabezados.IndexOf(encabezadoAtributo);
			//ese mismo index sirve para sacar la posicion de columna de donde se saccan datos
			
			int cantInstancias= calcularCantidadInstancias();
			
			DataTable tablaDeFrecuencias = new DataTable();
			
			tablaDeFrecuencias.Columns.Add(new DataColumn(encabezadoAtributo));
			tablaDeFrecuencias.Columns.Add(new DataColumn("Conteo"));
			tablaDeFrecuencias.Columns.Add(new DataColumn("% Conteo"));
			
			List<string> dominiosDeUnAtributo = obtenerDominios(encabezadoAtributo);
			
			List<string> valoresDeAtributos = obtenerValoresParaAtributo(encabezadoAtributo);
							
			foreach(string dominio in dominiosDeUnAtributo)
			{
				DataRow dr = tablaDeFrecuencias.NewRow();
				dr[0] = dominio;
				
				
				int frecuenciaPalabra = contarFrecuenciaPalabraColumna(dominio, valoresDeAtributos);
				int numNulos = contarValoresNulosEnColumna(valoresDeAtributos);
				
				double porcentaje = calcularPorcentajeFrencuencia(frecuenciaPalabra, numNulos);
			
				dr[1] = frecuenciaPalabra;
				dr[2] = porcentaje.ToString("0.00");
				tablaDeFrecuencias.Rows.Add(dr);
			}

			return tablaDeFrecuencias;
		}
		
		
		//obtiene todos los valores posibles para un atributo categorico
		public List<string> obtenerDominios(string encabezadoAtributo)
		{
			//aqui obtiene el index para el atributo en la lista de encabezados
			int c = encabezados.IndexOf(encabezadoAtributo);
			//ese mismo index sirve para sacar la posicion de columna de donde se saccan datos
			
			string dominiosAtrib = dominios[c];
			
			List<string> dominiosDeUnAtributo = new List<string>();
			
			dominiosAtrib = dominiosAtrib.Replace("(","");
			dominiosAtrib = dominiosAtrib.Replace(")","");
			
			string[] dominiosSinSeparador = dominiosAtrib.Split('|');
			
			string dominioSinEspaciosExtras = "";
			
			for(int i = 0; i < dominiosSinSeparador.Length; i++)
			{
				dominioSinEspaciosExtras = dominiosSinSeparador[i];
				if(dominioSinEspaciosExtras[0] == ' ')
				{
					dominioSinEspaciosExtras = dominioSinEspaciosExtras.TrimStart(' ');
				}
				
				if(dominioSinEspaciosExtras[dominioSinEspaciosExtras.Length-1] == ' ')
				{
					dominioSinEspaciosExtras = dominioSinEspaciosExtras.TrimEnd(' ');
				}
				
				dominiosDeUnAtributo.Add(dominioSinEspaciosExtras);
			}
			
			return dominiosDeUnAtributo;
		}
		
		
		//Separa todos los dominios Correspondientes a una columna
		public List<string> separarDominios(string domExtraidos)
		{
			string dominiosAtrib = domExtraidos;
						
			List<string> dominiosDeUnAtributo = new List<string>();
			
			dominiosAtrib = dominiosAtrib.Replace("(","");
			dominiosAtrib = dominiosAtrib.Replace(")","");
			
			string[] dominiosSinSeparador = dominiosAtrib.Split('|');
			
			string dominioSinEspaciosExtras = "";
			
			for(int i = 0; i < dominiosSinSeparador.Length; i++)
			{
				dominioSinEspaciosExtras = dominiosSinSeparador[i];
				if(dominioSinEspaciosExtras[0] == ' ')
				{
					dominioSinEspaciosExtras = dominioSinEspaciosExtras.TrimStart(' ');
				}
				
				if(dominioSinEspaciosExtras[dominioSinEspaciosExtras.Length-1] == ' ')
				{
					dominioSinEspaciosExtras = dominioSinEspaciosExtras.TrimEnd(' ');
				}
				
				dominiosDeUnAtributo.Add(dominioSinEspaciosExtras);
			}
			
			return dominiosDeUnAtributo;
		}
		
		//En el caso de manejo de archivos csv, se llegan a obtener duplicados  para los
		//dominios, este funcion los elimina para que sea mas facil ver la informacion
		public List<string> eliminarDominiosDuplicados(List<string> domExtraidos)
		{
			
			List<string> dominiosDeAtributo = new List<string>();
			
			//Lista con los dominios sin duplicado
			List<string> dominiosSinDuplicado= new List<string>();
			
			//EstaCadena Guardara l anueva expresion regular sin duplicados
			string expRegDom = "";
			
			for(int c = 0; c < domExtraidos.Count; c++)
			{
				dominiosDeAtributo = separarDominios(domExtraidos[c]);
				dominiosDeAtributo.Sort();
				
				expRegDom = "(";
				
				//Recorre todos los dominios de un atributo para meterlos al string
				for(int i = 0; i < dominiosDeAtributo.Count -1; i++)
				{
					//Si el dominio en la pos actual es distinto al siguiente se agrega al string
					if(dominiosDeAtributo[i] != dominiosDeAtributo[i+1])
					{
						//Para saber si i es <= ala penultima posicion
						//Si se cumple se agrega el string y la barra divisora(ya que aun queda el valor final)
						if( i <= dominiosDeAtributo.Count - 1)
	                    {
							expRegDom += dominiosDeAtributo[i];
	                    	expRegDom += " | ";
	                    }
					}
					
					//Con esto sabemo si la posicion siguiente seria la ultima
					//si es asi se ingresa al string (Al ser el ultimo, esto se cumple una sola vez)
					if(i+1 == dominiosDeAtributo.Count - 1)
					{
						expRegDom += dominiosDeAtributo[i+1];
					}
				}
				
				expRegDom += ")";
				
				dominiosSinDuplicado.Add(expRegDom);					
			}

			return dominiosSinDuplicado;
		}
		
		//Regresa una lista con todos los campos para un atributo dado
		public List<string> obtenerValoresParaAtributo(string encabezadoAtributo)
		{
			List<string> valoresDeUnAtributo = new List<string>();
			
			//aqui obtiene el index para el atributo en la lista de encabezados
			int c = encabezados.IndexOf(encabezadoAtributo);
			//ese mismo index sirve para sacar la posicion de columna de donde se saccan datos
			
			int cantInstancias = calcularCantidadInstancias();
			
			for(int f = 0; f < cantInstancias; f ++)
			{
				valoresDeUnAtributo.Add(dtConjuntoDatos.Rows[f][c].ToString());
			}
			
			return valoresDeUnAtributo;
		}
		
		//Cuenta el numero de veces que se repite una palabra en una lista de strings
		// recibe la palabra y la lista
		public int contarFrecuenciaPalabraColumna(string palabra, List<string> listaStrings)
		{
			int contador = 0;
			
			for(int i = 0; i < listaStrings.Count; i++)
			{
				if(listaStrings[i] == palabra)
				{
					contador++;
				}
			}
			
			return contador;
		}
		
		//Calcula el procentaje de fecuancia de una palabra
		public Double calcularPorcentajeFrencuencia(int frecuencia, int numNulos)
		{
			double numValoresTotales = calcularCantidadInstancias();
			double porcentaje = (frecuencia * 100) / (numValoresTotales - numNulos) ;
			return porcentaje;
		}
		
		//Cuenta el numero de veces que se repite un valor nulo en una lista de strings
		// recibe la lista
		public int contarValoresNulosEnColumna(List<string> listaStrings)
		{
			int contador = 0;
			
			for(int i = 0; i < listaStrings.Count; i++)
			{
				if(listaStrings[i] == "" || listaStrings[i] == valorNulo)
				{
					contador++;
				}
			}
			
			return contador;
		}
		
		
		//Saber si el tipo de dato es numerico o categorico
		public string saberTipoDeDato(string nombreAtributo)
		{
			//va acomparar el atributo obtenido por parametro
			//(el cual deberia obtenerse de un comboBox con la lista de tipos
			//aunque esto puede cambiar conforme crece el programa)
			
			//aqui obtiene el index para el atributo en la lista de encabezados
			int i = encabezados.IndexOf(nombreAtributo);
			//ese mismo index sirve para sacar el tipo de dato de la lista de tiposDatos
			
			string tipoDato;
			
			tipoDato = tiposDatos[i];
			
			
			//aqui en este punto divido los tipos de datos en 2
			//categoricos: nominal, ordinal, boleano
			//numericos: numeric, fecha
			
			if(tipoDato == "nominal" || tipoDato == "ordinal" || tipoDato == "boleano")
			{
				tipoDato = "categorico";
			}
			else if(tipoDato == "numeric" || tipoDato == "fecha")
			{
				tipoDato = "numerico";
			}
			
			return tipoDato;
		}
		
		//Especialmente util en los categoricos
		//regresa cuantos posibles valores puede tener un atributo
		public int obtenerCantidadDeDominios(string nombreAtributo)
		{
			List<string> dominiosAtrib = obtenerDominios(nombreAtributo);
			
			int cantidadDominios = dominiosAtrib.Count;
			
			return cantidadDominios;
		}
		
		//esto retornara una lista con las posiciones de aquellos campos
		//del datable que no cumplan con el dominio dado por su atributo
		public List<string> validarCamposConDominioTotal(string encabezadoAtributo)
		{
			//este arreglo contendra las posiciones en el datatable de los valores no esperados
			//int f = calcularCantidadAtributos
			//int[,] valoresNoEsperados = new int[2,2];
			
			List<string> valoresNoEsperados = new List<string>();
			
			//si dominios es igual a 0 entonces no hay datos que validar
			if(dominios.Count > 0)
			{
				
			}
			
			
			return valoresNoEsperados;
		}
		
		//Retorna la posicion(fila) de los valores que no cumplen con
		//el dominio para un atributo dado
		public List<int> validarCamposDominio(string encabezadoAtributo)
		{
			//aqui obtiene el index para el atributo en la lista de encabezados
			int c = encabezados.IndexOf(encabezadoAtributo);
			//ese mismo index sirve para sacar la posicion de columna de donde se saccan datos
			
			int cantInstancias = calcularCantidadInstancias();
			
			List<int> valoresNoEsperados = new List<int>();
			
			string valorCelda = "";
			
			//Esta variable guardara la expresion regular que despues
			//se usara para validar el campo
			Regex expReg = new Regex(@dominios[c]);
			
			
			
			for(int f = 0; f < cantInstancias; f++)
			{
				valorCelda = dtConjuntoDatos.Rows[f][c].ToString();
				
				if(expReg.IsMatch(valorCelda))
				{
					valoresNoEsperados.Add(f);
				}
			}

			return valoresNoEsperados;
		}
		
	}
}
