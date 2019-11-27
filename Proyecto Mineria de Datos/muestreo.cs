/*
 * Creado por SharpDevelop.
 * Usuario: Axel
 * Fecha: 26/11/2019
 * Hora: 12:16 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;

namespace Proyecto_Mineria_de_Datos
{
	/// <summary>
	/// Description of muestreo.
	/// </summary>
	public partial class muestreo : Form
	{
		string extension;
		string ruta;
		public ConjuntoDeDatosExtendido cdd;
		public DataGridView dataGridDiew1;
		public muestreo(ConjuntoDeDatosExtendido cddx, DataGridView data)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			cdd = cddx;
			dataGridDiew1 = data;
		}
		void NMuestraLTextChanged(object sender, EventArgs e)
		{			
			if(nMuestraTB.Text.Length > 0)
			{
				guardarBTN.Enabled = true;
			}
			else
			{
				guardarBTN.Enabled = false;
			}
		}
		//En este muestreo pueden repetirse las instancias
		void conRemplazo(string ruta)
		{
			int nMuestras = int.Parse(nMuestraTB.Text);
			int cantInstancias= cdd.calcularCantidadInstancias();			
			Random random = new Random(Guid.NewGuid().GetHashCode());
			int i=0;
			DataGridViewRow dr = new DataGridViewRow();
			FileInfo t = new FileInfo(ruta);
            StreamWriter swOut = t.CreateText();         
            swOut.Write("%% ");
            swOut.Write(cdd.comentarios + "(MUESTREO CON REMPLAZO)");
            swOut.WriteLine();
            swOut.Write("@relation ");
            swOut.Write(cdd.nombreConjuntoDatos);
            swOut.WriteLine();           
            while(i<dataGridDiew1.Columns.Count)
            {
            	swOut.Write("@attribute ");
            	swOut.Write(dataGridDiew1.Columns[i].HeaderText);
            	swOut.Write(" ");
            	swOut.Write(cdd.tiposDatos[i]);
            	swOut.Write(" ");
            	swOut.Write(cdd.dominios[i]);
            	swOut.WriteLine();            
            	i++;
            }
            swOut.Write("@missingValue ");
            swOut.Write(cdd.valorNulo);
            swOut.WriteLine();
            swOut.Write("@data ");
            swOut.WriteLine();
            for (int j = 0; j < nMuestras; j++)
		       {
            	int value = random.Next(0, cantInstancias - 1);
            	//MessageBox.Show(value.ToString(), "Debug Random");
            	if (j > 0)
            	{
		        swOut.WriteLine();
		        }
            	dr = dataGridDiew1.Rows[value];
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
		             if(valor==cdd.valorNulo || valor=="")
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
		//En este muestreo no pueden repetirse las instancias
		void sinRemplazo(string ruta)
		{
			List<int> aleatorios = new List<int>();
			int value;
			int nMuestras = int.Parse(nMuestraTB.Text);
			int cantInstancias= cdd.calcularCantidadInstancias();			
			Random random = new Random(Guid.NewGuid().GetHashCode());
			int i=0;
			DataGridViewRow dr = new DataGridViewRow();
			FileInfo t = new FileInfo(ruta);
            StreamWriter swOut = t.CreateText();         
            swOut.Write("%% ");
            swOut.Write(cdd.comentarios + "(MUESTREO SIN REMPLAZO)");
            swOut.WriteLine();
            swOut.Write("@relation ");
            swOut.Write(cdd.nombreConjuntoDatos);
            swOut.WriteLine();           
            while(i<dataGridDiew1.Columns.Count)
            {
            	swOut.Write("@attribute ");
            	swOut.Write(dataGridDiew1.Columns[i].HeaderText);
            	swOut.Write(" ");
            	swOut.Write(cdd.tiposDatos[i]);
            	swOut.Write(" ");
            	swOut.Write(cdd.dominios[i]);
            	swOut.WriteLine();            
            	i++;
            }
            swOut.Write("@missingValue ");
            swOut.Write(cdd.valorNulo);
            swOut.WriteLine();
            swOut.Write("@data ");
            swOut.WriteLine();
            for (int j = 0; j < nMuestras; j++)
		       {
            	value = 0;
            	do
            	{
            		value = random.Next(0, cantInstancias - 1);            		
            	} while(aleatorios.Contains(value));
            	aleatorios.Add(value);
            	//MessageBox.Show(value.ToString(), "Debug Random");
            	if (j > 0)
            	{
		        swOut.WriteLine();
		        }
            	dr = dataGridDiew1.Rows[value];
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
		             if(valor==cdd.valorNulo || valor=="")
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
		void GuardarBTNClick(object sender, EventArgs e)
		{
			int nMuestras = int.Parse(nMuestraTB.Text);
			int cantInstancias= cdd.calcularCantidadInstancias();
			if(nMuestras < cantInstancias)
			{
				SaveFileDialog saveFileDialog1 = new SaveFileDialog();
				saveFileDialog1.Filter = "Archivos DATA (*.data)|*.data";		
    	        if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK
    	            && saveFileDialog1.FileName.Length > 0)	
				{
					extension = System.IO.Path.GetExtension(saveFileDialog1.FileName);
					if(extension == ".DATA" || extension == ".data")
					{
						ruta = saveFileDialog1.FileName;
						if(conRemRB.Checked == true)
						{
							conRemplazo(ruta);
							MessageBox.Show("Muestreo con remplazo guardado con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
						else if(sinRemRB.Checked == true)
						{
							sinRemplazo(ruta);
							MessageBox.Show("Muestreo sin remplazo guardado con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
					}
				}
				else
				{
					MessageBox.Show("No se pudo crear el archivo. Intente de Nuevo", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Question);
				}
			}
			else
			{
				MessageBox.Show("El número para la muestra es igual o mayor al número de instancias del Dataset. Intente de Nuevo", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}