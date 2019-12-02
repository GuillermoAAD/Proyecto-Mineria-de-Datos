/*
 * Creado por SharpDevelop.
 * Usuario: Axel
 * Fecha: 20/11/2019
 * Hora: 06:28 p. m.
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
	/// Description of llenarValoresFaltantes.
	/// </summary>
	public partial class llenarValoresFaltantes : Form
	{
		public ConjuntoDeDatosExtendido cdd;
		public double media;
		public double mediana;
		public double moda;
		public llenarValoresFaltantes(ConjuntoDeDatosExtendido cddx)
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
			sustituirCB.Items.Add("Media");
			sustituirCB.Items.Add("Mediana");
			sustituirCB.Items.Add("Moda");
			sustituirCB.SelectedIndex = 0;
			//Se cargan los atributos al combobox
			for(int i = 0; i < cdd.encabezados.Count; i++)
			{				
				atributoCB.Items.Add(cdd.encabezados[i]);									
			}
			//Si existen al menos un Item
			if(atributoCB.Items.Count > 0)
			{
				//Posiciona el combobox de atributos en el indice 0
				atributoCB.SelectedIndex = 0;
				//Si es numerico
				if(cdd.tiposDatos[0] == "numeric")
				{
					//Hará los calculos para los numericos y los mostrara, se lleva de parametro el atributo del CB
					calculoDeNumericos(atributoCB.SelectedItem.ToString());		
					labelSugerencia.Text = calcularSugerencia();
				}
				else
				{
					//Hace los calculos para los tipo categorico, se lleva de parametro el atributo del combobox
					calculoDeCategoricos(atributoCB.SelectedItem.ToString());
				}
			}
		}
		public void calculoDeNumericos(string encabezado)
		{
			//Estos serán necesarios para el calculo de la sugerencia
			media = cdd.calcularMedia(encabezado);
			mediana = cdd.calcularMediana(encabezado);
			moda = cdd.calcularModa(encabezado);
			
			//Estos los muestran en la ventana
			labelMedia.Text = cdd.calcularMedia(encabezado).ToString("0.00");
			labelMediana.Text = cdd.calcularMediana(encabezado).ToString("0.00");
			labelModa.Text = cdd.calcularModa(encabezado).ToString("0.00");			
		}
		public void calculoDeCategoricos(string encabezado)
		{
			//Se localiza en indice del atributo
			int c = cdd.encabezados.IndexOf(encabezado);
			//Se obtiene el numero de instancias
			int cantInstancias = cdd.calcularCantidadInstancias();
			//Se obtienen los dominios del atributo
			List<string> dominiosDeUnAtributo = cdd.obtenerDominios(encabezado);
			//Se obtienen los valores de ese atributo
			List<string> valoresDeAtributos = cdd.obtenerValoresParaAtributo(encabezado);			
			List<int> frecuenciaPalabras = new List<int>();
			foreach(string dominio in dominiosDeUnAtributo)
			{
				//Se guarda el numero que se repite cada uno de los dominios
				frecuenciaPalabras.Add(cdd.contarFrecuenciaPalabraColumna(dominio, valoresDeAtributos));			
			}
			calcularModa(dominiosDeUnAtributo, frecuenciaPalabras);
		}
		void AtributoCBSelectedIndexChanged(object sender, EventArgs e)
		{
			//Esto reinicia el CB de sobre lo que se quiere sustituir
			sustituirCB.Items.Clear();
			//Deja en blanco los labels para la media, moda, mediana y sugerencia
			reinicializarLabels();
			//guardamos en un string el atributo del CB seleccionado
			string atributo = atributoCB.SelectedItem.ToString();
			//Encontramos el indice de ese atributo
			int i = cdd.encabezados.IndexOf(atributo);
			//Si es numerico es posible sustituir por media, mediana y moda
			if(cdd.tiposDatos[i] == "numeric")
			{
				sustituirCB.Items.Add("Media");
				sustituirCB.Items.Add("Mediana");
				sustituirCB.Items.Add("Moda");				
				sustituirCB.SelectedIndex = 0;
				//Con esto calculamos su media, mediana y moda y muestra en los labels en los resultados
				calculoDeNumericos(atributoCB.SelectedItem.ToString());
				//Muestra la sugerencia
				labelSugerencia.Text = calcularSugerencia();
			}
			else
			{
				//En cualquier otro caso, los categoricos, solo pueden ser sustituidos por la moda
				sustituirCB.Items.Add("Moda");
				sustituirCB.SelectedIndex = 0;
				//Se calcula su moda :v
				calculoDeCategoricos(atributoCB.SelectedItem.ToString());
			}
		}
		string calcularSugerencia()
		{
			//Esto es solo para los numericos, en caso de que todos sean iguales lo ideal es que se sustituya por la media
			string sugerencia = "";
			if(media == mediana && media == moda)
			{
				sugerencia = "Media";
			}
			else
			{
				//En caso contrario la mediana
				sugerencia = "Mediana";
			}
			return sugerencia; //Esto se mostrará en el label
		}
		private void reinicializarLabels()
		{
			//Deja en blanco los labels, esto por que para los categoricos no son necesarios media y mediana
			labelSugerencia.Text = "-";
			labelMedia.Text = "-";
			labelMediana.Text = "-";
			labelModa.Text = "-";			
		}
		void AceptarBTNClick(object sender, EventArgs e)
		{
			bool existenFaltantes = false;
			//Guardamos en un string el atributo seleccionao
			string atributo = atributoCB.SelectedItem.ToString();
			//Localizamos su indice
			int i = cdd.encabezados.IndexOf(atributo);
			//Calculamos las instancias del datatable
			int cantInstancias = cdd.calcularCantidadInstancias();
			//String para saber por cual quiere sustituir el usuario
			string eleccion = "";
			//Aqui lo guardamos
			eleccion = sustituirCB.SelectedItem.ToString();
			for(int j = 0; j < cantInstancias; j++)
			{
				//Solo para los valores nulos
				if(cdd.dtConjuntoDatos.Rows[j][i].ToString() == cdd.valorNulo || cdd.dtConjuntoDatos.Rows[j][i].ToString() == "")
				{
					existenFaltantes = true;
					//If para saber que eligio el usuario
					if(eleccion == "Media")
					{
						cdd.dtConjuntoDatos.Rows[j][i] = media;
					}
					else if(eleccion == "Mediana")
					{
						cdd.dtConjuntoDatos.Rows[j][i] = mediana;	
					}
					else if(eleccion == "Moda")
					{
						//Para sustituir por la moda numerica
						if(cdd.tiposDatos[i] == "numeric")
						{
							cdd.dtConjuntoDatos.Rows[j][i] = moda;	
						}
						else
						{
							//En caso de ser categorico sustitumos por la sugerencia que es la moda que se guardó en el label
							cdd.dtConjuntoDatos.Rows[j][i] = labelSugerencia.Text;
						}						
					}
				}
			}
			if(existenFaltantes == true)
			{
				MessageBox.Show("Llenado de valores faltantes para el atributo " + atributoCB.SelectedItem + " completado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("No existe ningun valor faltante para el atributo " + atributoCB.SelectedItem, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		public void calcularModa(List<string> dominios, List<int> frecuenciaPalabras)
		{
			//Esto es para los categoricos
			int mayor = 0;
			string dominio = "";
			//Desde i hasta el numero de elementos de la lista
			for(int i = 0; i < frecuenciaPalabras.Count; i++)
			{
				//Compara el mayor actual con la frecuencia de cada una de las palabras
				if(mayor < frecuenciaPalabras[i])
				{
					//De ser menor, este se iguala
					mayor = frecuenciaPalabras[i];
					//Y guardamos el dominio para saber a que atributo pertenece esta frencuencia mayor
					dominio = dominios[i];
				}
			}
			//Mostramos el atributo con mayor frecuencia como la sugerencia (que es obligatoria :v)
			labelSugerencia.Text = dominio;
		}		
	}
}
