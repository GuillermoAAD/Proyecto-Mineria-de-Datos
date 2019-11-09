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
		public int cantidadInstancias;
		public int cantidadAtributos;
		public int numeroValoresFaltantes;
		public float proporcionValoresFaltantes;
		DataTable dt;
			
		public entradaDeDatos()
		{
			nombreConjuntoDatos = "";
			cantidadInstancias = 0;
			cantidadAtributos = 0;
			numeroValoresFaltantes = 0;
			proporcionValoresFaltantes = 0;
			dt = new DataTable();
		}
		
		public DataTable abrirArchivo()
		{
			//String nombreArchivo = "";
			String extension = "";
			String ruta = "";
            //String contenido = "";
            //DataTable dt = new DataTable();
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
                		//str = System.IO.File.

                         //dataGrid1.Text = System.IO.File.ReadAllText(oFD.FileName);
                         
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
                         	
                         }
                         
                  	}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            cantidadInstancias = dt.Rows.Count;
            cantidadAtributos = dt.Columns.Count;
            calcularValoresFaltantes();
            calcularProporcionValoresFaltantes();
            
            return dt;
		}
		
		public void calcularValoresFaltantes()
		{
			for(int i = 0; i < cantidadInstancias; i++)
			{
				for(int j = 0; j < cantidadAtributos; j ++)
				{
					if(dt.Rows[i][j] == "")
					{
						numeroValoresFaltantes ++;
					}
				}
			}
		}
		
		public void calcularProporcionValoresFaltantes()
		{
			float numValoresTotales = cantidadInstancias * cantidadAtributos;
			
			proporcionValoresFaltantes = numValoresTotales / 100;
			
			proporcionValoresFaltantes *= numeroValoresFaltantes;
			
		}
		
	}
}
