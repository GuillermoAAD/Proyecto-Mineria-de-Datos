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
using System.IO;

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
		public void guardarCSV(DataGridView dataGridView1)
		{
			SaveFileDialog saveFileDialog1 = new SaveFileDialog();
			saveFileDialog1.Filter = "csv files (*.csv)|*.csv";

            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK
                && saveFileDialog1.FileName.Length > 0)
            {
				//test to see if the DataGridView has any rows
				DataGridView gridIn = new DataGridView();
				gridIn = dataGridView1;
			    if (dataGridView1.RowCount > 0)
			    {			           
			       DataGridViewRow dr = new DataGridViewRow();			    
			       FileInfo t = new FileInfo(saveFileDialog1.FileName);
                   StreamWriter swOut = t.CreateText();
			 
			       //write header rows to csv
			       for (int i = 0; i <= gridIn.Columns.Count - 1; i++)
			       {
			          if (i > 0)
			          {
			             swOut.Write(",");
			          }
			          swOut.Write(gridIn.Columns[i].HeaderText);
			       }
			 
			       swOut.WriteLine();
			 
			       //write DataGridView rows to csv
			       //------------------------------------			    
			       for (int j = 0; j <= gridIn.Rows.Count - 2; j++)
			       {
			          if (j > 0)
			          {
			          swOut.WriteLine();
			          }
			 
			          dr = gridIn.Rows[j];
			          //----------------------------			       			     
			          for (int i = 0; i <= gridIn.Columns.Count - 1; i++)
			          {
			             if (i > 0)
			             {
			                swOut.Write(",");
			             }						             		           
			             string valor = dr.Cells[i].EditedFormattedValue.ToString();
			             //replace comma's with spaces
			             valor = valor.Replace(',', ' ');
			             //replace embedded newlines with spaces
			             valor = valor.Replace(Environment.NewLine, " ");
			 
			             swOut.Write(valor);
			          }
			       }
			       swOut.Close();					
			    }
			}
			else{
				MessageBox.Show("No se pudo crear el archivo. Intente de Nuevo");
			}
		}
	}
}
