/*
 * Created by SharpDevelop.
 * User: Chu
 * Date: 05/11/2019
 * Time: 10:41 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using System.Data;

namespace Proyecto_Mineria_de_Datos
{
	/// <summary>
	/// Description of formatoCSV.
	/// </summary>
	public class formatoCSV
	{
		public formatoCSV()
		{
		}
		
		public DataTable abrirCSV(string ruta)
		{
			DataTable dtCSV = new DataTable();
			//Extrae cada linea del archivo y las pone en un arreglo
			string[] lineas = System.IO.File.ReadAllLines(ruta);
			
			//
			if (lineas.Length > 0)
			{
				//Extrayendo encabezados
				
				//Extraer la primer linea que contiene los encabezados
				string primerLinea = lineas[0];
				//Ingresa la primer linea como cabecera
				string[] nombresAtributos = primerLinea.Split(',');
				
				foreach(string nombAtributo in nombresAtributos)
				{
					//if(nombAtributo != "\n")
					//{
						dtCSV.Columns.Add(new DataColumn(nombAtributo));
					//}
				}
				
				//Estrayendo datos
				for(int i = 1; i <= lineas.Length-1; i++)
				{
					string[] registro = lineas[i].Split(',');
					DataRow dr = dtCSV.NewRow();
					//dtCSV.Rows.Add(
					
					int contadorColumna = 0;
					foreach(string nombAtributo in nombresAtributos)
					{
						//if(nombAtributo != "\n")
						//{
						dr[nombAtributo] = registro[contadorColumna++];
							//dtCSV.Columns.Add(new DataColumn(nombAtributo));
						//}
					}
					dtCSV.Rows.Add(dr);
				}
				
			}
			return dtCSV;
		}
	}
}
