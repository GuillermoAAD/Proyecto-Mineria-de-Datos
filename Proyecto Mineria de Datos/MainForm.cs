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

namespace Proyecto_Mineria_de_Datos
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			// Esta parte es para el SplashScreen
			Thread t=new Thread(new ThreadStart(StartForm));
			t.Start();
			Thread.Sleep(7000);
			
			InitializeComponent();
			
			//Finaliza el thread del SplashScreen
			t.Abort();
			
			this.Show();
			this.Activate();
			
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
			//dataGridView1.
			
			//if (label1.Text != "No hay datos")
			if (dataGridView1.Rows.Count != 0)
			{
				if ( MessageBox.Show ( "Hay un conjunto de datos en memoria,\n" +
				                      "¿Desea guardar cambios y cargar uno nuevo?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1 ) == System.Windows.Forms.DialogResult.Yes )
 				{
					//agregar codigo para guardar
					//reinicializar todas las variables
					
					//Abre el nuevo archivo y carga en el dataGridView
					//label1.Text = edd.abrirArchivo();
					dataGridView1.DataSource = null;
					dataGridView1.DataSource = edd.abrirArchivo();
				}
			}
			else{
				dataGridView1.DataSource = edd.abrirArchivo();
			}
			
			labelNombreConjuntoDatos.Text = edd.nombreConjuntoDatos;
			
			labelCantidadInstancias.Text = edd.cantidadInstancias.ToString();
			
			labelCantidadAtributos.Text = edd.cantidadAtributos.ToString();
			
			labelNumeroValoresFaltantes.Text = edd.numeroValoresFaltantes.ToString();
			
			//string cadena = edd.proporcionValoresFaltantes.ToString() + "a";
			labelProporcionValoresFaltantes.Text = edd.proporcionValoresFaltantes.ToString() + "%";
			

			
			//esto agrega el numero de fila como encabezado de filas
			for(int i = 0; i<dataGridView1.Rows.Count; i++)
			{
				dataGridView1.Rows[i].HeaderCell.Value = (i + 1).ToString();
			}
			//Esto valida el que se habiliten los botones de guardar solo cuando se cargue un archivo exitosamente
			if(dataGridView1.Rows.Count==0){
				guardarToolStripMenuItem.Enabled=false;
				guardarComoToolStripMenuItem.Enabled=false;
			}
			else{
				guardarToolStripMenuItem.Enabled=true;
				guardarComoToolStripMenuItem.Enabled=true;
			}
		}
		void GuardarToolStripMenuItemClick(object sender, EventArgs e)
		{
			formatoCSV guardar = new formatoCSV();
			guardar.guardarCSV(dataGridView1);
		}
		
		void GuardarComoToolStripMenuItemClick(object sender, EventArgs e)
		{
	
		}
		
		//Abre un form con informacion general acerca del programa
		void AcercaDeToolStripMenuItemClick(object sender, EventArgs e)
		{
			AcercaDeForm ad = new AcercaDeForm();
			ad.Show();
		}
		
		void SalirToolStripMenuItemClick(object sender, EventArgs e)
		{
			alertaSalir();
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
		
	}
}
