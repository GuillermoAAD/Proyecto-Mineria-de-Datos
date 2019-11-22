/*
 * Creado por SharpDevelop.
 * Usuario: Axel
 * Fecha: 21/11/2019
 * Hora: 10:49 p. m.
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
	/// Description of erroresTipograficos.
	/// </summary>
	public partial class erroresTipograficos : Form
	{
		public ConjuntoDeDatosExtendido cdd;
		public erroresTipograficos(ConjuntoDeDatosExtendido cddx)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//			
			cdd = cddx;
			//Agregamos solo los categoricos al ComboBox
			for(int i = 0; i < cdd.encabezados.Count; i++)
			{
				if(cdd.tiposDatos[i] != "numeric")
				{
					atributoCB.Items.Add(cdd.encabezados[i]);
				}
			}
			//En caso de que existan elementos en el CB se posiciona en el indice 0
			if(atributoCB.Items.Count > 0)
			{
				atributoCB.SelectedIndex = 0;
			}
		}
		public void detectFueraDom(string encabezado)
		{		
			bool esDominio;
			//Guardamos en un string el atributo seleccionao
			string atributo = atributoCB.SelectedItem.ToString();
			//Localizamos su indice
			int i = cdd.encabezados.IndexOf(encabezado);
			//Calculamos las instancias del datatable
			int cantInstancias = cdd.calcularCantidadInstancias();
			//Este sirve para almacenar de manera auxiliar cual ha sido el dominio con menor distancia
			string dominioSelec = "";
			//Enteros que serviran para comparar las distancias
			int distanciaActual = 0;
			int distanciaNueva = 0;
			//Necesario para obtener los dominios del atributo
			List<string> dominios;
			dominios = cdd.obtenerDominios(encabezado);
			//Desde 0 hasta el numero de instancias
			for(int j = 0; j < cantInstancias; j++)
			{
				//Reinicializar bandera y distancia para cada atributo de la fila que se compare
				esDominio = false;
				distanciaActual = 0;
				dominioSelec = "";
				//Se itera cuantos dominios haya
				for(int k = 0; k < dominios.Count; k++)
				{
					//Se compara el atributo de la fila j con cada uno de los dominios del atributo para saber si está dentro del dominio
					if(cdd.dtConjuntoDatos.Rows[j][i].ToString() == dominios[k])
					{
						esDominio = true;
					}
				}
				//Entra aquí en caso de que se detecte que el atributo de la fila j no es dominio
				if(esDominio == false)
				{
					//Se itera cuantos dominios haya
					for(int l = 0; l < dominios.Count; l++)
					{
						//Se obtiene la distancia entre el atributo de la fila j y el dominio l
						distanciaNueva = distanciaDeLevenshtein(cdd.dtConjuntoDatos.Rows[j][i].ToString(), dominios[l]);
						//Esto es para debug
						MessageBox.Show("Distancia nueva: " + distanciaNueva + "\nDistancia actual: " + distanciaActual + "\nDominio menor actual: " + dominioSelec, cdd.dtConjuntoDatos.Rows[j][i].ToString() + " -> " + dominios[l], MessageBoxButtons.OK, MessageBoxIcon.Information);
						
						//Entra aquí la primera vez que se itera pues no se ha obtenido niguna distancia aun
						if(distanciaActual == 0)
						{
							//Se guarda en actual para posteriormente cada nueva instancia compararla
							distanciaActual = distanciaNueva;
							//Guardamos el dominio de la primera distancia medida, ya que podria darse el caso
							//de que el primer dominio sea el de menor distancia, este posteriormente se asigna al atributo en j
							dominioSelec = dominios[l];
						}
						//Compara si la nueva distancia comparada es menor que la actual
						if(distanciaNueva < distanciaActual)
						{
							//De ser asi, se guarda esa nueva distancia menor como la actual
							distanciaActual = distanciaNueva;
							//Guardamos el dominio potencialmente menor
							dominioSelec = dominios[l];
						}
					}
					//Finalmente se asigna el dominio de menor distancia encontrado en el datatable
					cdd.dtConjuntoDatos.Rows[j][i] = dominioSelec;
				}
			}
		}
		public int distanciaDeLevenshtein(string s, string t)
		{
			int n = s.Length;
			int m = t.Length;
			int[,] d = new int[n + 1, m + 1];			
			if (n == 0)
			{
				return m;
			}
			if (m == 0)
			{
				return n;
			}			
			for (int i = 0; i <= n; d[i, 0] = i++)
			{
			}			
			for (int j = 0; j <= m; d[0, j] = j++)
			{
			}
			for (int i = 1; i <= n; i++)
			{				
				for (int j = 1; j <= m; j++)
				{					
					int cost = (t[j - 1] == s[i - 1]) ? 0 : 1;					
					d[i, j] = Math.Min(Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1), d[i - 1, j - 1] + cost);
				}
			}			
			return d[n, m];
		}
		void AceptarBTNClick(object sender, EventArgs e)
		{
			detectFueraDom(atributoCB.SelectedItem.ToString());			
		}
	}
}
