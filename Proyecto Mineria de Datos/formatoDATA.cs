/*
 * Created by SharpDevelop.
 * User: Chu
 * Date: 07/11/2019
 * Time: 8:46 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Proyecto_Mineria_de_Datos
{
	/// <summary>
	/// Description of formatoDATA.
	/// </summary>
	public class formatoDATA
	{
		
		//Informacion general
		//Ejemplo:
		//%% Monthly totals of international airline passengers (in thousands) for
		//%% 1949-1960.
		// %% es para representar comentarios
		public string comentarios;
		
		//Descripcion de la Base de Datos
		//@relation: Define el nombre del conjunto de datos
		public string relation;
		 
		//@attribute: Define la información de los atributos del conjunto de datos, los campos que
		//la componen nos 'nombreAtributo' 'tipoDato' 'dominio'.
		//• nombreAtributo: Indica el nombre del atributo.
		//• tipoDato: Define el tipo de dato del atributo (numérico, nominal, ordinal, boleano,
		//fecha).
		//• dominio: Define, usando expresiones regulares, los conjuntos de valores que se
		//esperan en dicho dominio.
		public List<String> attribute;
		//string[] attribute;
		
		//Variables que en realidad son los campos  de informacion de attribute
		List<String> encabezados;
		List<String> tiposDatos;
		List<String> dominios;
		
		//@missingValue: Variable global que se utilizará cuando haya valores nulos.
		string missingValue;
		
		//Base de Datos
		public DataTable dtDATA;
		
		public formatoDATA()
		{
			this.comentarios = "";
			this.relation = "";
			this.attribute = new List<string>();
			this.encabezados = new List<string>();
			this.tiposDatos = new List<string>();
			this.dominios = new List<string>();
			
			this.missingValue = "";
			
			dtDATA = new DataTable();
			
		}
		
		public void abrirDATA(string ruta)
		{
			//Extrae cada linea del archivo y las pone en un arreglo
			string[] lineas = System.IO.File.ReadAllLines(ruta);
			
			//
			if (lineas.Length > 0)
			{
				//Extraccion de datos
				
				int i = 0;
				
				while(i < lineas.Length){
					
					//Mete las palabras de una linea en un arreglo y elimina los espacios
					string[] linea = lineas[i].Split(' ');
					
					//Extrayendo comentarios
					if(linea[0] == "%%")
					{
						comentarios += extraerOracion(linea);
					}
					//Extrayendo el nombre del conjunto de datos
					else if(linea[0] == "@relation")
					{
						relation = extraerOracion(linea);
					}
					//Extrayendo un atributo(al estar dentro del while, en realidad extrae todos los atributos)
					else if(linea[0] == "@attribute")
					{
						string infoAtributo = extraerOracion(linea);
						attribute.Add(infoAtributo);
					}
					//Extrayendo la variable para los valores nulos
					else if(linea[0] == "@missingValue")
					{
						missingValue =extraerOracion(linea);
					}
					//Extrayendo el conjunto de datos
					else if(linea[0] == "@data")
					{
						extraerInfoCamposAtributo();
						foreach(string encabezado in encabezados)
						{
							dtDATA.Columns.Add(new DataColumn(encabezado));
						}
						
						//sacar lineas restantes
						
						//Estrayendo datos
						i++;
						while (i < lineas.Length)
						{
							string[] registro = lineas[i].Split(',');
							DataRow dr = dtDATA.NewRow();
							
							int contadorColumna = 0;
							foreach(string encabezado in encabezados)
							{
								dr[encabezado] = registro[contadorColumna++];
							}
							i++;
							dtDATA.Rows.Add(dr);
						}
						break;
						
						
					}

					i++;
				}
			}
		}
		
		private string extraerOracion(string[] linea)
		{
			string oracion = "";
			foreach(string palabra in linea)
			{
				if(palabra != linea[0])
				{
					oracion += palabra + " ";
				}
			}
			return oracion;
		}
		
		//Extrae los encabezados de los atributos para ponerlos en las columnas del datatable
		private void extraerInfoCamposAtributo()
		{
			int i = 0;
			foreach(string infoAtributo in attribute )
			{
				string[] campos = infoAtributo.Split(' ');
				
				encabezados.Add(campos[0]);
				tiposDatos.Add(campos[1]);
				dominios.Add(campos[2]);
				
				i++;
			}
			
		}
	}
}
