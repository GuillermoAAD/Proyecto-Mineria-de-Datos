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
using System.IO;

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
		public List<String> encabezados;
		public List<String> tiposDatos;
		public List<String> dominios;
		
		//@missingValue: Variable global que se utilizará cuando haya valores nulos.
		public string missingValue;
		
		//Base de Datos
		public DataTable dtDATA;
		
		
		//Para simplificar el trabajo de analisis estadistico dividi los atributos en
		// numerico y categorico, son los mismos qu eya existen pero separados
		public List<String> atributosNumeric;
		public List<String> atributosNominal;
		
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
			
			this.atributosNumeric = new List<string>();
			this.atributosNominal = new List<string>();
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
						
						//Estrayendo datos y metiendolos al datatable
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
				remplazarCamposVaciosConValorFaltante();
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
			foreach(string infoAtributo in attribute )
			{
				//ignora espacios en blacno
				string[] campos = infoAtributo.Split(' ');

				encabezados.Add(campos[0]);
				tiposDatos.Add(campos[1]);
				
				//Esta parte extrae toda la parte de los dominios y los metera a la lista
				//ejemplo: en dominios[i] = "(tourist | first class)"
				
				string dominioCompleto = "";
				int posInicioDominio = 0;
				if(infoAtributo.IndexOf('(') != -1)
				{
					posInicioDominio = infoAtributo.IndexOf('(');
				}
				else if(infoAtributo.IndexOf('[') != -1)
				{
					posInicioDominio = infoAtributo.IndexOf('[');
				}

				dominioCompleto = infoAtributo.Substring(posInicioDominio);

				dominios.Add(dominioCompleto);
			}
			separarNumericNominal();
		}
		
		// aqui separamos los atributos numericos y los categoricos
		// solo se hace con los encabezados
		private void separarNumericNominal()
		{
			int i = 0; //Es un contador para saber que encabezado meter en alguna categoria
			foreach(string tipo in tiposDatos)
			{
				if(tipo == "numeric" )
				{
					atributosNumeric.Add(encabezados[i]);
				}
				else if(tipo == "nominal")
				{
					atributosNominal.Add(encabezados[i]);
				}
			}
		}
		
		//Busca los campos que no tengan datos y les ingresa el simbolo 
		// de valor faltante dado en el archivo DATA
		private void remplazarCamposVaciosConValorFaltante()
		{
			for(int i = 0; i < dtDATA.Rows.Count; i++)
			{
				for(int j = 0; j < dtDATA.Columns.Count; j++)
				{
					if(dtDATA.Rows[i][j].ToString() == "")
					{
						dtDATA.Rows[i][j] = missingValue;
					}
				}
			}
		}
		public void guardarDATA(ConjuntoDeDatosExtendido cdde, string ruta, DataGridView dataGridDiew1)
		{			
			int i=0;
			DataGridViewRow dr = new DataGridViewRow();
			FileInfo t = new FileInfo(ruta);
            StreamWriter swOut = t.CreateText();         
            swOut.Write("%% ");
            swOut.Write(cdde.comentarios);
            swOut.WriteLine();
            swOut.Write("@relation ");
            swOut.Write(cdde.nombreConjuntoDatos);
            swOut.WriteLine();           
            while(i<dataGridDiew1.Columns.Count)
            {
            	swOut.Write("@attribute ");
            	swOut.Write(dataGridDiew1.Columns[i].HeaderText);
            	swOut.Write(" ");
            	//swOut.Write(cdde.dominios[i]) Tipo de dato
            	swOut.Write(" ");
            	swOut.Write(cdde.dominios[i]);
            	swOut.WriteLine();            
            	i++;
            }
            swOut.Write("@missingValue ");
            swOut.Write(cdde.valorNulo);
            swOut.WriteLine();
            swOut.Write("@data ");
            swOut.WriteLine();
            for (int j = 0; j <= dataGridDiew1.Rows.Count - 2; j++)
		       {
		          if (j > 0)
		          {
		          swOut.WriteLine();
		          }
		 
		          dr = dataGridDiew1.Rows[j];
		          //----------------------------			       			     
		          for (int k = 0; k <= dataGridDiew1.Columns.Count - 1; k++)
		          {
		             if (k > 0)
		             {
		                swOut.Write(",");
		             }						             		           
		             string valor = dr.Cells[k].EditedFormattedValue.ToString();
		             //replace comma's with spaces
		             valor = valor.Replace(',', ' ');
		             //replace embedded newlines with spaces
		             valor = valor.Replace(Environment.NewLine, " ");
		             if(valor==cdde.valorNulo || valor=="")
		             {
		             	swOut.Write("");
		             }
		             else
		             {		             	
		             	swOut.Write(valor);
		             }		             
		          }
		       }
            swOut.Close();
		}
	}
}
