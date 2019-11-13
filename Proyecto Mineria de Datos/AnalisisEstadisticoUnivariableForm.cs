/*
 * Created by SharpDevelop.
 * User: Chu
 * Date: 11/11/2019
 * Time: 9:28 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_Mineria_de_Datos
{
	/// <summary>
	/// Description of AnalisisEstadisticoUnivariableForm.
	/// </summary>
	public partial class AnalisisEstadisticoUnivariableForm : Form
	{
		//esto se va a cmabiar
		//public formatoDATA cdd; // cdd = conjunto de datos
		public ConjuntoDeDatosExtendido cdd;// cdd = conjunto de datos
		
		
		public AnalisisEstadisticoUnivariableForm(ConjuntoDeDatosExtendido cddx)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.			//

			//
			cdd = new ConjuntoDeDatosExtendido();
			cdd = cddx;
			//cdd.abrirDATA("C:\\Users\\Chu\\Desktop\\ejemplo.data");
			
			for(int i = 0; i < cdd.encabezados.Count; i++)
			{
				comboBox1.Items.Add(cdd.encabezados[i]);
			}
		}
		
		//al seleccionar algun atributo busca que tipo de dato es
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			string encabezado = comboBox1.Text;
			string tipoDato = saberTipoDeDato(encabezado);
			
			if(tipoDato == "numeric")//probablemente se agregue fecha...
			{
				//hace calculos de numerico y 
				//pondra visible las cosas que se relacionen
				calculoDeNumericos(encabezado);
				mostrarDatosNumericos();
				
				
				
				
			}
			else if(tipoDato == "nominal")//probablemente se deban agregar ordinal, bool, etc,
			{
				//hace calculos de categorico y 
				//pondra visible las cosas que se relacionen
				
				calculoDeCategoricos();
				mostrarDatosCategoricos();
				
			}
			else
			{
				NOTA.Text = "No funciona";
			}
			//else que diga que el tipo de dato no es valiod?
	
		}
		
		//Saber si el tipo de dato es numerico o categorico
		private	string saberTipoDeDato(string nombreAtributo)
		{
			
			//va acomparar el atributo elegido en el comboBox con la lista de tipos
			
			//aqui obtiene el index para el atributo en la lista de encabezados
			int i = cdd.encabezados.IndexOf(nombreAtributo);
			//ese mismo index sirve para sacar el tipo de dato de la lista de tiposDatos
			
			string tipoDato;
			
			tipoDato = cdd.tiposDatos[i];
			
			return tipoDato;
		}
		
		private void calculoDeNumericos(string encabezado)
		{
			labelMedia.Text = cdd.calcularMedia(encabezado).ToString();
			labelMediana.Text = cdd.calcularMediana(encabezado).ToString();
			labelModa.Text = cdd.calcularModa(encabezado).ToString();
			labelDesviacionEstandar.Text = cdd.calcularDesviacionEstandar(encabezado).ToString();

		}
		
		private void calculoDeCategoricos()
		{
			
		}
		
		private void mostrarDatosNumericos()
		{
			ocultarDatosCategoricos();
			label2.Visible = true;
			labelMedia.Visible = true;
			label3.Visible = true;
			labelMediana.Visible = true;
			label4.Visible = true;
			labelModa.Visible = true;
			label5.Visible = true;
			labelDesviacionEstandar.Visible = true;
			label6.Visible = true;
		}
		
		private void ocultarDatosNumericos()
		{
			label2.Visible = false;
			labelMedia.Visible = false;
			label3.Visible = false;
			labelMediana.Visible = false;
			label4.Visible = false;
			labelModa.Visible = false;
			label5.Visible = false;
			labelDesviacionEstandar.Visible = false;
			label6.Visible = false;
		}
		
		private void mostrarDatosCategoricos()
		{
			ocultarDatosNumericos();
			
		}
		
		private void ocultarDatosCategoricos()
		{
			
		}

	}
}
