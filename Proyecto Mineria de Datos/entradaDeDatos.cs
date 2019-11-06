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
		public entradaDeDatos()
		{
		}
		
		public DataTable abrirArchivo()
		{
			//String nombreArchivo = "";
			String extension = "";
			String ruta = "";
            //String contenido = "";
            DataTable dt = new DataTable();
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
                         	//ruta = extension;
                		
                         }
                         else if(extension == ".DATA" || extension == ".data"  )
                         {
                         	//ruta = extension;
                		
                         }
                         
                  	}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            return dt;
		}
	}
}
