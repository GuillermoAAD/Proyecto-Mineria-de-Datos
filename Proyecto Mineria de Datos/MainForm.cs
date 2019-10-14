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
 			
			if ( MessageBox.Show ( "¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1 ) == System.Windows.Forms.DialogResult.Yes )
 			{
 				this.Close();
			}
		}
		
		
		//funciones activadas por eventos
		
		void CargarArchivoToolStripMenuItemClick(object sender, EventArgs e)
		{
	
		}
		void GuardarToolStripMenuItemClick(object sender, EventArgs e)
		{
	
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
		
		
		
	}
}
