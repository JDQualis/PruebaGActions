﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;
using System.IO;

namespace Qualis_Bot_SalesNavigator
{
	public partial class ObtenerNumeroDeIteraciones
	{
		/// <summary>
		/// This method gets called right after the recording has been started.
		/// It can be used to execute recording specific initialization code.
		/// </summary>
		private void Init()
		{
			// Your recording specific initialization code goes here.
		}

		public void ObtenerNombrePuestoYLinkSale()
		{
			
			int cantidadIteraciones = Convert.ToInt32(cantidadDeResultados);
			
			for(int indice=1; indice<=cantidadIteraciones; indice++){
				
				Convert.ToString(indice);//convierto el indice en un string
				
				//string xpathLI="/dom[@domain='www.linkedin.com']//div[#'search-results-container']//li["+indice+"]"; //Genero el Xpath
				
				//IList<Element> Lita = repo.InicioSalesNavigator.LiList.FindSingle("/li["+indice+"]");// Nos trae un elemnto de la lista.
				
				//WebElement nombre = repo.InicioSalesNavigator.LiList.FindSingle("/li["+Convert.ToString(indice)+"]//a[@data-anonymize='person-name']");
				
				nombrePersona = Host.Local.FindSingle("/dom[@domain='www.linkedin.com']//div[#'search-results-container']/?/?/ol/li["+Convert.ToString(indice)+"]//a[@data-anonymize='person-name']").GetAttributeValueText("InnerText");
				
				Report.Info(nombrePersona);
				
				/*
				Object xpathNombre= new Object();
				xpathNombre="/dom[@domain='www.linkedin.com']//div[#'search-results-container']//ol/li["+indice+"]//a[@data-anonymize='person-name']" ;
				
				string nombrePersona = repo.InicioSalesNavigator.LiSegunIndice.Element.SetAttributeValue(xpathNombre);
				
				nombrePersona=xpathNombre.GetAttributeValueText("InnerText");
				
				Report.Log(nombrePersona);
				*/
				
			}
			
		}

        public void CrearCSV()
        {
        	float cantResultados = float.Parse(cantidadDeResultados);
        	float div = cantResultados/25;
        	// Redondeamos el resultado hacia arriba
        	double cantidad = 0;
        	if (div>1){
        		cantidad = Math.Ceiling(div);
        		cantPage = cantidad.ToString();     	
        	}
        	else{
        		cantPage = "1";
        		cantidad = 1;
        	}
        	
			//Ruta en la que voy a guardar el archivo
			string path = @"C:\TEMP\CantidadPage.csv";
			
			//Borra el archivo existente
			File.Delete(@"C:\TEMP\CantidadPage");
			
			//Cabecera que indica las variables en cada "columna del csv" + una nueva linea para que siga abajo
			string cabecera = "CantidadPage" + System.Environment.NewLine;
			//Datos que voy a agregar (son variables del recording) + una nueva linea
			string datos = cantPage + System.Environment.NewLine;
			
			//Crea el archivo, agrega la cabecera y los datos dependiendo de la cantidad de paginas
			try {
				Report.Info("Info", "Se creó el archivo CantidadPage.csv");
				File.WriteAllText(path,cabecera);
				
				for (int i=1; i<= cantidad; i++){
				File.AppendAllText(path,datos);
				}
			}
			catch (Exception e) {
				Report.Failure("Fail", "Error al crear el archivo o guardar los datos\r\nError: " + e);
				throw;
			}
        }
	}
}
