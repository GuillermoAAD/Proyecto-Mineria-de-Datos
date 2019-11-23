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
using System.Collections.Generic;


namespace Proyecto_Mineria_de_Datos
{
	/// <summary>
	/// Description of entradaDeDatos.
	/// </summary>
	public class entradaDeDatos
	{
		public string nombreConjuntoDatos;
		public string ruta = "";
		public string extension = "";
		DataTable dt;
		
		ConjuntoDeDatosExtendido cdde;
			
		public entradaDeDatos()
		{
			nombreConjuntoDatos = "";
			dt = new DataTable();
			cdde = new ConjuntoDeDatosExtendido();
		}
		
		public ConjuntoDeDatosExtendido abrirArchivo()
		{
			//String extension = "";
			//String ruta = "";
			
            try
            {
                OpenFileDialog oFD = new OpenFileDialog();
                oFD.Filter =  "Todas los archivos permitidos (*.csv;*.data)|*.csv;*.data" +
                	"|Archivos CSV (*.csv)|*.csv" +
                	"|Archivos DATA (*.data)|*.data";
                if (oFD.ShowDialog() == DialogResult.OK)
                {                	
                	if (System.IO.File.Exists(oFD.FileName))
                  	{
                		ruta = oFD.FileName;
                		//ruta = System.IO.File.ReadAllText(oFD.FileName);
                		extension = System.IO.Path.GetExtension(oFD.FileName);
                		//atributoCB.clear();
 
                        if(extension == ".CSV" || extension == ".csv"  )
                        {
                       		formatoCSV fCSV = new formatoCSV();
                         	
                         	dt = fCSV.abrirCSV(ruta);
                         	nombreConjuntoDatos = System.IO.Path.GetFileNameWithoutExtension(oFD.FileName);
                         	
                         	int c = 0;
                         	//cdde.encabezados = dt.Columns.;
                         	
                         	List<string> domExtraidos = new List<string>();
                         	
                         	foreach(DataColumn column in dt.Columns)
           					{
                         		cdde.encabezados.Add(column.ColumnName);
                         		cdde.tiposDatos.Add("nominal");
                         		
                         		//cdde.dominios.Add("(");
                         		domExtraidos.Add("(");
                         		//esto va a extraer todos los campos, y los toma como el dominio
                         		// es propenso a poner valores repetidos en dominios, esos se  eliminan
                         		//en el conjuntoDeDatoExtendido
                         		for(int f = 0; f < dt.Rows.Count ; f++)
                         		{
                         			if(dt.Rows[f][c].ToString() != "")
                         			{
                         				//cdde.dominios[c] +=  dt.Rows[f][c].ToString();
                         				domExtraidos[c] +=  dt.Rows[f][c].ToString();
                         				
                         				if(f < dt.Rows.Count - 1)
                         				{
                         					//cdde.dominios[c] += " | ";
                         					domExtraidos[c] += " | ";
                         				}
                         			}
                         		}                         		
                         		//cdde.dominios[c] += ")";
                         		domExtraidos[c] += ")";
                         		
                         		c++;
				          	}
                         	cdde.dominios = cdde.eliminarDominiosDuplicados(domExtraidos);
                         	//cdde.eliminarDominiosDuplicados(domExtraidos);                         	
                         }
                         else if(extension == ".DATA" || extension == ".data"  )
                         {
                         	formatoDATA fDATA = new formatoDATA();
                         	
                         	fDATA.abrirDATA(ruta);
                         	dt = fDATA.dtDATA;
                         	nombreConjuntoDatos= fDATA.relation;
                         	
                         	//estos van adentro porque solo el data posee estos datos
                         	
                         	cdde.comentarios = fDATA.comentarios;
                         	cdde.encabezados = fDATA.encabezados;
                         	cdde.tiposDatos = fDATA.tiposDatos;
                         	cdde.dominios = fDATA.dominios;
                         	cdde.valorNulo = fDATA.missingValue;
                         	cdde.atributosNumeric = fDATA.atributosNumeric;
                         	cdde.atributosNominal = fDATA.atributosNominal;                         	
                         }

                         //Estos se ponen afuera por que el csv y el data comparten ambos atributos
                         cdde.nombreConjuntoDatos = nombreConjuntoDatos;                         
                         cdde.dtConjuntoDatos = dt;
                         //cdde.eliminarDominiosDuplicados();

                  	}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            return cdde;
		}
		public string rRuta()
		{
			return ruta;	
		}
		public string rExt()
		{
			return extension;
		}

	}
}
