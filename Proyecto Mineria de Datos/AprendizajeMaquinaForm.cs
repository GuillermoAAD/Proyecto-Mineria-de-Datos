/*
 * Created by SharpDevelop.
 * User: Chu
 * Date: 20/11/2019
 * Time: 4:51 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;

namespace Proyecto_Mineria_de_Datos
{
	/// <summary>
	/// Description of AprendizajeMaquinaForm.
	/// </summary>
	public partial class AprendizajeMaquinaForm : Form
	{
		
		public ConjuntoDeDatosExtendido cdd;// cdd = conjunto de datos
		
		public AprendizajeMaquinaForm(ConjuntoDeDatosExtendido cddx)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			cdd = new ConjuntoDeDatosExtendido();
			cdd = cddx;
			
			
			//Revisa si existe una clase definida, si no, no puede realizar ninguna operacion
			/*
 			* if( cdd.obtenerClase() != "")
			{
				button1.Enabled = true;
			}
			else
			{
				button1.Enabled = false;
				MessageBox.Show("No hay una clase definida\n por favor defina una.",
				                "Clase no encontrada");
				
			
			}
			*/
		}
		
		private string calcularZeroR ()
		{
			string clase = cdd.obtenerClase();
			
			string valorClase = "";
			
			DataTable tablaFrec = cdd.calcularTablaFrecuencias(clase);
			
			//esto me deja solo con las columnas necesarias
			tablaFrec.Columns.RemoveAt(2);
			
			//Se que en la segunda col estan los datos que necesito
			//entonces con un for busco el mas repetido			
			
			int mayor = 0;
			
			for(int i = 0; i < tablaFrec.Rows.Count; i++)
			{
				string valorCelda = tablaFrec.Rows[i][1].ToString();
				int celdaInt = int.Parse(valorCelda);
				
				if(celdaInt >= mayor){
					mayor = celdaInt;
					valorClase = tablaFrec.Rows[i][0].ToString();
				}
			}
			
			//esto muestra la tabla de frecuencia en el datagridview
			//dataGridView1.DataSource = tablaFrec;

			return valorClase;			
		}
		
		private void calcularOneR(){
			
			string clase = cdd.obtenerClase();
			
			//para la tabla de frecuencia de atrib vs clase
			
			
			
			//Se calculan tablas de frecuancias de atributos vs clase
			
			for(int i = 0; i < cdd.encabezados.Count; i++)
			{
				//evita que se haga la tabla clase vs clase
				if(clase != cdd.encabezados[i])
				{
					DataTable tablaFrec = cdd.calcularTablaContingencia(clase, cdd.encabezados[i]);
					
					//esto elimina la ultima columna, porque no la necesito
					tablaFrec.Columns.RemoveAt(tablaFrec.Columns.Count-1);
					
					//esto elimina la ultima fila, porque no la necesito
					tablaFrec.Rows.RemoveAt(tablaFrec.Rows.Count-1);
					
					
					//esto muestra la tabla de frecuencia en el datagridview
					dataGridView1.DataSource = tablaFrec;
					
					//Es una pausa para ver todas las tablas generadas
					MessageBox.Show("PAUSA");
					
					//Ahora
					//Encuentra la relación de atributo-clase más frecuente.
					//Construye reglas que asignen la clase más
					//frecuente a dicho valor del atributo.
					
					
					//del datatable cada fila es un valor de atributo
					//y cada clase un valor de clase
					
					for(int f = 0; f < tablaFrec.Rows.Count-1; f++)
					{
						for(int c = 1; c < tablaFrec.Columns.Count-1; c++)
						{
							
						}
					}
				}
			}
		}
		void Button1Click(object sender, EventArgs e)
		{
			labelZeroR.Text = calcularZeroR();
			calcularOneR();
			
	
		}
		
	}
}
