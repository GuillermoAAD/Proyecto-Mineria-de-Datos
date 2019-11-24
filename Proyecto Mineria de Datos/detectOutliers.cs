/*
 * Creado por SharpDevelop.
 * Usuario: Axel
 * Fecha: 22/11/2019
 * Hora: 10:05 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Proyecto_Mineria_de_Datos
{
	/// <summary>
	/// Description of detectOutliers.
	/// </summary>
	public partial class detectOutliers : Form
	{
		public ConjuntoDeDatosExtendido cdd;
		public double rangoInterQ;
		public double[] cuartiles = new double[3];
		public double media;
		public double mediana;
		public double moda;
		public double sustitucion;
		public detectOutliers(ConjuntoDeDatosExtendido cddx)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			cdd = cddx;
			for(int i = 0; i < cdd.encabezados.Count; i++)
			{
				if(cdd.tiposDatos[i] == "numeric")
				{
					atributoCB.Items.Add(cdd.encabezados[i]);
				}
			}
			//En caso de que existan elementos en el CB se posiciona en el indice 0
			if(atributoCB.Items.Count > 0)
			{
				atributoCB.Enabled = true;
				atributoCB.SelectedIndex = 0;
				//Lleno el combobox de valores a sustituir
				sustituirCB.Items.Add("Media");
				sustituirCB.Items.Add("Mediana");
				sustituirCB.Items.Add("Moda");
				sustituirCB.SelectedIndex = 0;
			}
			else
			{
				//Todos los controles se inhabilitan
				posibleRB.Enabled = false;
				outlierRB.Enabled = false;
				sustituirCB.Enabled = false;
				MessageBox.Show("No existe ningun tipo de dato numerico en el conjunto de datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		private int indice(string encabezado)
		{
			//Retorna el indice del atributo seleccionado en el combobox
			return cdd.encabezados.IndexOf(encabezado);
		}		
		public double[] obtenerCuartiles(string nombreAtrib)
		{
			//aqui obtiene el index para el atributo en la lista de encabezados
			int c = cdd.encabezados.IndexOf(nombreAtrib);
			//ese mismo index sirve para sacar la posicion de columna de donde se saccan datos
			
			int cantInstancias= cdd.calcularCantidadInstancias();
			
			string valorCelda = "";
			
			List<double> valores = new List<double>();
			
			for(int f = 0; f < cantInstancias; f++)
			{
				valorCelda = cdd.dtConjuntoDatos.Rows[f][c].ToString();
				if(valorCelda != "" && valorCelda != cdd.valorNulo)
				{
					valores.Add(double.Parse(valorCelda));
				}
			}
			
			valores.Sort();
			
			int n = valores.Count;
			int valorEntero = 0;
			double valorDecimal = 0;
			double valorCuartil =0;
			
			cuartiles[0] = (n+1)/4;
			valorCuartil = cuartiles[0];
			
			cuartiles[1] = cdd.calcularMediana(nombreAtrib);
			cuartiles[2] = 3 * cuartiles[0];
			
			//Se revisa si el cuartil es entero
			if((cuartiles[0] % 1).ToString() == (0).ToString())
			{
				//extraigo el valor del cuartil 1
				valorEntero = int.Parse(cuartiles[0].ToString());
				//busco el valor en la posicion de la formula
				//cuartil y la meto al valor de cuartil
				cuartiles[0] = valores[valorEntero];
			}
			else //entonces si tiene decimales
			{
				valorDecimal = cuartiles[0] % 1;
				valorEntero = int.Parse((cuartiles[0] - valorDecimal).ToString());
				
				//cuartiles[0] = valores[valorEntero] + valorDecimal * (valores[valorEntero+1] - valores[valorEntero]);
				//cuartiles[0] = (valorEntero * valorCuartil);
				//cuartiles[0] += (cuartiles[0] * (valorDecimal * valorCuartil) );
				
				
				cuartiles[0] = valores[valorEntero + 1];
			}
			
			//se remplaza el valor obtenido con el valor de los 
			//datosen la posicion obtenidoa por el cuartil
			
			valorCuartil = cuartiles[2];
			if((cuartiles[2] % 1).ToString() == (0).ToString())
			{
				//extraigo el valor del cuartil 1
				valorEntero = int.Parse(cuartiles[2].ToString());
				//busco el valor en la posicion de la formula
				//cuartil y la meto al valor de cuartil
				cuartiles[2] = valores[valorEntero];
			}
			else //entonces si tiene decimales
			{
				valorDecimal = cuartiles[2] % 1;
				valorEntero = int.Parse((cuartiles[2] - valorDecimal).ToString());
				
				//cuartiles[2] = valores[valorEntero] + valorDecimal * (valores[valorEntero+1] - valores[valorEntero]);
				//cuartiles[2] = (valorEntero * valorCuartil);
				//cuartiles[2] += (cuartiles[2] * (valorDecimal * valorCuartil) );
				
				cuartiles[0] = valores[valorEntero];
			}
			
			return cuartiles;
		}
		void AtributoCBSelectedIndexChanged(object sender, EventArgs e)
		{
			//Se desmarcan todos los roundbuttons
			posibleRB.Checked = false;			
			outlierRB.Checked = false;
			//Se inhabulitan los combobox de posibles outliers y outliers
			posibleCB.Enabled = false;
			outlierCB.Enabled = false;
			//Tambien el boton aceptar para que no truene
			aceptarBTN.Enabled = false;		
			double[] cuartiles = obtenerCuartiles(atributoCB.Text);
			cuartil1L.Text = cuartiles[0].ToString();
			cuartil3L.Text = cuartiles[2].ToString();
			rangoInterQ = cuartiles[2] - cuartiles[0];
			iqrL.Text = rangoInterQ.ToString();		
			int i = indice(atributoCB.SelectedItem.ToString());
			calcularNumericos(atributoCB.SelectedItem.ToString());
			sugerenciaL.Text = sugerencia();
			detectarPosiblesOutliers(i);
			detectarOutliers(i);
			//Actualiza el Label del valor de la sugerencia
			string aux = sustituirCB.Text;
			if(aux == "Media")
			{
				valorL.Text = media.ToString("0.00");				
			}
			else if(aux == "Mediana")
			{
				valorL.Text = mediana.ToString("0.00");
			}
			else if(aux == "Moda")
			{
				valorL.Text = moda.ToString("0.00");
			}			
		}
		void PosibleRBCheckedChanged(object sender, EventArgs e)
		{
			//Esto habilita el combobox de posibles y el boton aceptar en caso de existir posibles Outliers
			if(posibleCB.Items.Count > 0)
			{
				posibleCB.Enabled = true;
				aceptarBTN.Enabled = true;
			}			
			else
			{
				aceptarBTN.Enabled = false;
			}
			outlierCB.Enabled = false;
		}
		void OutlierRBCheckedChanged(object sender, EventArgs e)
		{
			//Esto habilita el combobox de outliers y el boton aceptar en caso de existir Outliers
			if(outlierCB.Items.Count > 0)
			{
				outlierCB.Enabled = true;
				aceptarBTN.Enabled = true;
			}
			else
			{
				aceptarBTN.Enabled = false;
			}
			posibleCB.Enabled = false;
		}
		private void detectarPosiblesOutliers(int indice)
		{			
			posibleCB.Items.Clear();
			double metrica1 = rangoInterQ*1.5;
			double metrica2 = rangoInterQ*3;
			int numeroInstancias = cdd.calcularCantidadInstancias();
			for(int i = 0; i < numeroInstancias; i++)
			{
				double aux = double.Parse(cdd.dtConjuntoDatos.Rows[i][indice].ToString());
				if(aux > cuartiles[2]+metrica1 && aux < cuartiles[2]+metrica2 || aux < cuartiles[0]-metrica1 && aux > cuartiles[0]-metrica2)
				{
					posibleCB.Items.Add(cdd.dtConjuntoDatos.Rows[i][indice].ToString());
				}
			}
			if(posibleCB.Items.Count > 0)
			{
				posibleCB.SelectedIndex = 0;
			}
		}
		private void detectarOutliers(int indice)
		{
			outlierCB.Items.Clear();						
			double metrica2 = rangoInterQ*3;
			int numeroInstancias = cdd.calcularCantidadInstancias();
			for(int i = 0; i < numeroInstancias; i++)
			{
				double aux = double.Parse(cdd.dtConjuntoDatos.Rows[i][indice].ToString());
				if(aux > cuartiles[2]+metrica2 || aux < cuartiles[0]-metrica2)
				{
					outlierCB.Items.Add(cdd.dtConjuntoDatos.Rows[i][indice].ToString());
				}
			}
			if(outlierCB.Items.Count > 0)
			{
				outlierCB.SelectedIndex = 0;
			}
		}
		private string sugerencia()
		{
			//Esto es solo para los numericos, en caso de que todos sean iguales lo ideal es que se sustituya por la media			
			if(media == mediana && media == moda)
			{
				//sugerencia = "Media";
				return "Media = " + media.ToString();
			}
			else
			{
				//En caso contrario la mediana
				//sugerencia = "Mediana";
				return "Mediana = " + mediana.ToString();
			}
			//return sugerencia; //Esto se mostrará en el label
		}
		private void calcularNumericos(string encabezado)
		{
			//Estos serán necesarios para el calculo de la sugerencia
			media = cdd.calcularMedia(encabezado);
			mediana = cdd.calcularMediana(encabezado);
			moda = cdd.calcularModa(encabezado);
		}
		void SustituirCBSelectedIndexChanged(object sender, EventArgs e)
		{
			string aux = sustituirCB.SelectedItem.ToString();
			if(aux == "Media")
			{
				valorL.Text = media.ToString("0.00");				
			}
			else if(aux == "Mediana")
			{
				valorL.Text = mediana.ToString("0.00");
			}
			else if(aux == "Moda")
			{
				valorL.Text = moda.ToString("0.00");
			}
		}
		void AceptarBTNClick(object sender, EventArgs e)
		{
			int i = indice(atributoCB.SelectedItem.ToString());
			int numInstancias = cdd.calcularCantidadInstancias();
			//Bandera para mostrar ventana de si se sustituyeron los outliers
			bool existenOutliers = false;
			string seleccion = "";
			string valor = "";
			//Con esto sabremos por cual valor se sustituiran los outliers o posibles outliers
			if(sustituirCB.SelectedItem.ToString() == "Media")
			{
				valor = media.ToString("0.00");
			}
			else if(sustituirCB.SelectedItem.ToString() == "Mediana")
			{
				valor = mediana.ToString();
			}
			else if(sustituirCB.SelectedItem.ToString() == "Moda")
			{
				valor = moda.ToString();
			}
			//Con esto sabremos si sustituiremos un valor de posibles o de outliers
			if(posibleRB.Checked == true && posibleCB.Items.Count > 0)
			{
				seleccion = "Posibles";
			}
			else if(outlierRB.Checked == true && outlierCB.Items.Count > 0)
			{
				seleccion = "Outliers";
			}
			//Recorremos cada instancia
			for(int j = 0; j < numInstancias; j++)
			{
				//Comparamos si se eligio cambiar posibles o Outliers 
				if(seleccion == "Posibles")
				{
					existenOutliers = true;
					//Comparamos si en la instancia j actual, es igual al valor que queremos sustituir
					if(posibleCB.SelectedItem.ToString() == cdd.dtConjuntoDatos.Rows[j][i].ToString())
					{
						//En caso de ser asi, se sustituye por el valor a sustituir xd
						cdd.dtConjuntoDatos.Rows[j][i] = valor;
					}
				}
				//Actua de la misma manera que con los posibles pero con los Outliers
				else if(seleccion == "Outliers")
				{
					existenOutliers = true;
					if(outlierCB.SelectedItem.ToString() == cdd.dtConjuntoDatos.Rows[j][i].ToString())
					{
						cdd.dtConjuntoDatos.Rows[j][i] = valor;
					}
				}
			}
			//Muestra la ventana de sustitucion exitosa
			if(existenOutliers == true)
			{
				MessageBox.Show("Los outliers del atributo " + atributoCB.SelectedItem.ToString() + " han sido sustituidos con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}