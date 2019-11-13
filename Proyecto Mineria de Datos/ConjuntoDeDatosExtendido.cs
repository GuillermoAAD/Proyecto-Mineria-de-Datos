﻿/*
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
		public List<String> dominios;
		
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
		
		public float calcularProporcionValoresFaltantes()
		{
			int cantidadInstancias = calcularCantidadInstancias();
			int cantidadAtributos = calcularCantidadAtributos();
			int numeroValoresFaltantes = calcularValoresFaltantes();
			
			float numValoresTotales = cantidadInstancias * cantidadAtributos;
			float proporcionValoresFaltantes;
			
			
			proporcionValoresFaltantes = numeroValoresFaltantes * 100;
			proporcionValoresFaltantes /= numValoresTotales;
			
			return proporcionValoresFaltantes;
		}
		
		
		
		public float calcularMedia(string encabezadoAtributo)
		{
			//aqui obtiene el index para el atributo en la lista de encabezados
			int c = encabezados.IndexOf(encabezadoAtributo);
			//ese mismo index sirve para sacar la posicion de columna de donde se saccan datos
			int cantInstancias= calcularCantidadInstancias();
			
			//cuenta las celdas donde si exista un valor
			int contador = 0;
			
			float media = 0;
			
			string valorCelda = "";
			
			for(int f = 0; f < cantInstancias; f++)
			{
				valorCelda = dtConjuntoDatos.Rows[f][c].ToString();
				if(valorCelda != "" && valorCelda != valorNulo)
				{
					media += float.Parse(valorCelda);
					contador++;
				}
			}
			media /= contador;
			
			return media;
		}
		
		public float calcularMediana(string encabezadoAtributo)
		{
			//aqui obtiene el index para el atributo en la lista de encabezados
			int c = encabezados.IndexOf(encabezadoAtributo);
			//ese mismo index sirve para sacar la posicion de columna de donde se saccan datos
			int cantInstancias= calcularCantidadInstancias();
			
			float mediana = 0;
			
			List<float> valores = new List<float>();
			
			string valorCelda = "";
			
			for(int f = 0; f < cantInstancias; f++)
			{
				valorCelda = dtConjuntoDatos.Rows[f][c].ToString();
				if(valorCelda != "" && valorCelda != valorNulo)
				{
					valores.Add(float.Parse(valorCelda));
				}
			}
			valores.Sort();
			
			mediana = valores[valores.Count/2];
			
			return mediana;
		}
		
		public float calcularModa(string encabezadoAtributo)
		{
			//aqui obtiene el index para el atributo en la lista de encabezados
			int c = encabezados.IndexOf(encabezadoAtributo);
			//ese mismo index sirve para sacar la posicion de columna de donde se saccan datos
			int cantInstancias= calcularCantidadInstancias();
			
			float moda = 0;
			
			int mayor = 0;
			int pos = 0;
			
			List<float> valores = new List<float>();
			
			//van a estar relacionadas los valores de las siguientes dos tablas por su indice
			List<float> valoresSimples = new List<float>();
			List<int> repeticiones = new List<int>();
			
			string valorCelda = "";
			
			for(int f = 0; f < cantInstancias; f++)
			{
				valorCelda = dtConjuntoDatos.Rows[f][c].ToString();
				if(valorCelda != "" && valorCelda != valorNulo)
				{
					valores.Add(float.Parse(valorCelda));
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
		
		public float calcularDesviacionEstandar(string encabezadoAtributo)
		{
			float desviacionEstandar = 0;
			return desviacionEstandar;
		}
		
	}
}