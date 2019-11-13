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
	/// Description of entradaDeDatos.
	/// </summary>
	public class entradaDeDatos
	{
		public string nombreConjuntoDatos;
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
			String extension = "";
			String ruta = "";
			
            try
            {
                OpenFileDialog oFD = new OpenFileDialog();
                oFD.Filter =  "Todas los archivos permitidos (*.csv;*.data)|*.CSV;*.DATA" +
                	"|Archivos CSV (*.csv)|*.CSV" +
                	"|Archivos DATA (*.data)|*.DATA";
                if (oFD.ShowDialog() == DialogResult.OK)
                {
                	if (System.IO.File.Exists(oFD.FileName))
                  	{
                		ruta = oFD.FileName;
                		//ruta = System.IO.File.ReadAllText(oFD.FileName);
                		extension = System.IO.Path.GetExtension(oFD.FileName);
 
                        if(extension == ".CSV" || extension == ".csv"  )
                        {
                       		formatoCSV fCSV = new formatoCSV();
                         	
                         	dt = fCSV.abrirCSV(ruta);
                         	nombreConjuntoDatos = System.IO.Path.GetFileNameWithoutExtension(oFD.FileName);
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
                  	}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            return cdde;
		}

	}
}
