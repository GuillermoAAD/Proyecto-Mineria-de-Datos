/*
 * Created by SharpDevelop.
 * User: Chu
 * Date: 13/10/2019
 * Time: 5:04 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Proyecto_Mineria_de_Datos
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		ConjuntoDeDatosExtendido cdde;// 
		public string ruta;
		public string extension;
		public string tipoActual;		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			// Esta parte es para el SplashScreen
			Thread t=new Thread(new ThreadStart(StartForm));
			t.Start();
			Thread.Sleep(5000);
			
			InitializeComponent();
			
			//Finaliza el thread del SplashScreen
			t.Abort();
			
			this.Show();
			this.Activate();
			
			cdde = new ConjuntoDeDatosExtendido();					
			tipoCB.Items.Add("numeric");
			tipoCB.Items.Add("nominal");
			tipoCB.Items.Add("ordinal");
			tipoCB.Items.Add("class");
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		//Funciones generales
		
		//Iniciar SplashScreen
		public void StartForm()
		{
			Application.Run(new SplashScreenForm());
		}
		
		//Alerta que preguntar si desea guardar antes de salir
		public void alertaSalir()
		{
			//FALTA AGREGAR LA PARTE EN LA QUE PREGUNTA SI DESEA GUARDAR LOS CAMBIOS HECHOS
			//Revisar como saber si se hicieron cambios, tal vez con un bool?
 			
			if ( MessageBox.Show ( "¿Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1 ) == System.Windows.Forms.DialogResult.Yes )
 			{
 				this.Close();
			}
			
		}
		
		
		//funciones activadas por eventos
		
		void CargarArchivoToolStripMenuItemClick(object sender, EventArgs e)
		{
			entradaDeDatos edd = new entradaDeDatos();			
			
			if (dataGridView1.Rows.Count != 0)
			{
				if ( MessageBox.Show ( "Hay un conjunto de datos en memoria.\n" +
				                       "Si carga un nuevo conjuto de datos se perderan los cambios no guardados.\n" +
				                       "¿Desea cargar uno nuevo sin guardar cambios?", "Cargar archivo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1 ) == System.Windows.Forms.DialogResult.Yes )
 				{
					//agregar codigo para guardar
					
					//reinicializar todas las variables
					cdde = new ConjuntoDeDatosExtendido();					
					//Abre el nuevo archivo y carga en el dataGridView
					dataGridView1.DataSource = null;					
					//dataGridView1.DataSource = edd.abrirArchivo();
					cdde = edd.abrirArchivo();
					dataGridView1.DataSource = cdde.dtConjuntoDatos;					
					ruta = edd.rRuta();
					extension = edd.rExt();
				}
			}
			else{
				//dataGridView1.DataSource = edd.abrirArchivo();				
				cdde = edd.abrirArchivo();
				dataGridView1.DataSource = cdde.dtConjuntoDatos;
				ruta = edd.rRuta();
				extension = edd.rExt();
			}
			
			//labelNombreConjuntoDatos.Text = edd.nombreConjuntoDatos;
			labelNombreConjuntoDatos.Text = cdde.nombreConjuntoDatos;
			
			//labelCantidadInstancias.Text = edd.cantidadInstancias.ToString();
			labelCantidadInstancias.Text = cdde.calcularCantidadInstancias().ToString();
			
			//labelCantidadAtributos.Text = edd.cantidadAtributos.ToString();
			labelCantidadAtributos.Text = cdde.calcularCantidadAtributos().ToString();
			
			//labelNumeroValoresFaltantes.Text = edd.numeroValoresFaltantes.ToString();
			labelNumeroValoresFaltantes.Text = cdde.calcularValoresFaltantes().ToString();
			
			//string cadena = edd.proporcionValoresFaltantes.ToString() + "a";
			labelProporcionValoresFaltantes.Text = cdde.calcularProporcionValoresFaltantes().ToString("0.00") + "%";
			
			comentarioTXT.Text = cdde.comentarios;			
			//Esto agrega los items al combobox de atributos
			atributoCB.Items.Clear();
			for(int contador = 0; contador < dataGridView1.Columns.Count; contador++)
			{
				atributoCB.Items.Add(cdde.encabezados[contador]);
			}
			//Esto valida que no truene el programa en caso de que se cancele la carga de un archivo xd
			if(cdde.encabezados.Count > 0)
			{
				atributoCB.SelectedIndex = 0;
				dominioTB.Text = cdde.dominios[0];
			}						
			//esto agrega el numero de fila como encabezado de filas
			for(int i = 0; i<dataGridView1.Rows.Count; i++)
			{
				dataGridView1.Rows[i].HeaderCell.Value = (i + 1).ToString();
			}
			//Esto valida el que se habiliten los botones de guardar solo cuando se cargue un archivo exitosamente
			//Y tambien los menus de aanalisis estadistico, limpieza de datos y aprendizaje maquina
			if(dataGridView1.Rows.Count==0){
				guardarToolStripMenuItem.Enabled=false;
				guardarComoToolStripMenuItem.Enabled=false;
				análisisEstadísticoToolStripMenuItem.Enabled = false;
				limpiezaDeDatosToolStripMenuItem.Enabled = false;
				aprendizajeMáquinaToolStripMenuItem.Enabled = false;
				comentarioTXT.Enabled = false;
				atributoCB.Enabled = false;
				tipoCB.Enabled = false;
				dominioTB.Enabled = false;				
			}
			else{
				guardarToolStripMenuItem.Enabled=true;
				guardarComoToolStripMenuItem.Enabled=true;
				análisisEstadísticoToolStripMenuItem.Enabled = true;
				limpiezaDeDatosToolStripMenuItem.Enabled = true;
				aprendizajeMáquinaToolStripMenuItem.Enabled = true;
				comentarioTXT.Enabled = true;
				atributoCB.Enabled = true;
				tipoCB.Enabled = true;
				dominioTB.Enabled = true;								
			}
		}
		void GuardarToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(extension == ".CSV" || extension == ".csv"  )
            {
			formatoCSV guardar = new formatoCSV();
			guardar.guardarCSV(dataGridView1, ruta);
			}
			else if(extension == ".DATA" || extension == ".data"  )
			{
				formatoDATA guardar = new formatoDATA();
				guardar.guardarDATA(cdde, ruta, dataGridView1);
			}
		}
		
		void GuardarComoToolStripMenuItemClick(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog1 = new SaveFileDialog();
			saveFileDialog1.Filter = "Archivos CSV (*.csv)|*.csv" + "|Archivos DATA (*.data)|*.data";		
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK
                && saveFileDialog1.FileName.Length > 0)	
			{ 				
				extension = System.IO.Path.GetExtension(saveFileDialog1.FileName);				
				if(extension == ".CSV" || extension == ".csv")
				{
					formatoCSV guardar = new formatoCSV();
					ruta = saveFileDialog1.FileName;
					guardar.guardarCSV(dataGridView1,ruta);					
				}
				else if(extension == ".DATA" || extension == ".data")
				{
					ruta = saveFileDialog1.FileName;
					formatoDATA guardar = new formatoDATA();
					guardar.guardarDATA(cdde, ruta, dataGridView1);
				}
			}
			else
				{
					MessageBox.Show("No se pudo crear el archivo. Intente de Nuevo", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Question);
				}
		}
		
		//Abre un form con informacion general acerca del programa
		void AcercaDeToolStripMenuItemClick(object sender, EventArgs e)
		{
			AcercaDeForm ad = new AcercaDeForm();
			ad.Show();
		}
		
		void SalirToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Close();
			//alertaSalir();
		}
		
		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			//alertaSalir(e);
    		DialogResult dialogo = MessageBox.Show("¿Desea cerrar el programa?",
               "Cerrar el programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
    		if (dialogo == DialogResult.No)
    		{
        		e.Cancel = true;
    		}
    		else
    		{
        		e.Cancel = false;
    		}
		}
		
		void UnivariableToolStripMenuItemClick(object sender, EventArgs e)
		{
			AnalisisEstadisticoUnivariableForm aeu = new AnalisisEstadisticoUnivariableForm(cdde);
			//Se inicializa el conjunto de datos que va a haber en el analisis 
			//estadistico Univariable con el conjunto de este form, para poder 
			//trabajar con los mismos datos
			aeu.Show();
		}
		
		void BivariableToolStripMenuItemClick(object sender, EventArgs e)
		{
			AnalisisEstadisticoBivariableForm aeb = new AnalisisEstadisticoBivariableForm(cdde);
			//Se inicializa el conjunto de datos que va a haber en el analisis 
			//estadistico Univariable con el conjunto de este form, para poder 
			//trabajar con los mismos datos
			aeb.Show();
		}		
		
		void AprendizajeMáquinaToolStripMenuItemClick(object sender, EventArgs e)
		{
			AprendizajeMaquinaForm am = new AprendizajeMaquinaForm();
			
			am.Show();			
			
		}
		
		void AtributoCBSelectedIndexChanged(object sender, EventArgs e)
		{
			//va acomparar el atributo elegido en el comboBox con la lista de tipos
			string atributo = atributoCB.SelectedItem.ToString();
			//aqui obtiene el index para el atributo en la lista de encabezados
			int i = cdde.encabezados.IndexOf(atributo);
			//ese mismo index sirve para sacar el tipo de dato de la lista de tiposDatos
			
			string tipoDato;
			
			tipoDato = cdde.tiposDatos[i];
			tipoActual = tipoDato;
			//debugL.Text = tipoDato;
			tipoCB.SelectedItem = tipoDato;
			dominioTB.Text = cdde.dominios[i];
		}
		void TipoCBSelectedIndexChanged(object sender, EventArgs e)
		{			
			//va acomparar el atributo elegido en el comboBox con la lista de tipos
			string atributo = atributoCB.SelectedItem.ToString();
			//aqui obtiene el index para el atributo en la lista de encabezados
			int i = cdde.encabezados.IndexOf(atributo);
			string nuevoTipo;
			nuevoTipo = tipoCB.SelectedItem.ToString();
			cdde.tiposDatos[i] = nuevoTipo;			
		}		
		void ComentarioTXTTextChanged(object sender, EventArgs e)
		{
			cdde.comentarios = comentarioTXT.Text.ToString();
		}
		void DominioTBTextChanged(object sender, EventArgs e)
		{
			//va acomparar el atributo elegido en el comboBox con la lista de tipos
			string atributo = atributoCB.SelectedItem.ToString();
			//aqui obtiene el index para el atributo en la lista de encabezados
			int i = cdde.encabezados.IndexOf(atributo);
			//ese mismo index sirve para sacar el tipo de dato de la lista de tiposDatos
			cdde.dominios[i] = dominioTB.Text.ToString();
		}
		void LlenarValoresFaltantesToolStripMenuItemClick(object sender, EventArgs e)
		{
			llenarValoresFaltantes lvf = new llenarValoresFaltantes(cdde);						
			DialogResult res = lvf.ShowDialog();
			if(res == DialogResult.OK)
			{
				cdde = new ConjuntoDeDatosExtendido();
				cdde = lvf.cdd;
				dataGridView1.DataSource = null;				
				dataGridView1.DataSource = cdde.dtConjuntoDatos;					
				//esto agrega el numero de fila como encabezado de filas
				for(int i = 0; i<dataGridView1.Rows.Count; i++)
				{
					dataGridView1.Rows[i].HeaderCell.Value = (i + 1).ToString();
				}
			}
		}						
	}
}
