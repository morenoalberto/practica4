using System;
using System.IO;
namespace Practica4
{
	public class Archivoc
	{
		public string archivo1;
		public string archivo2;
		public Archivoc (){}

			public void LeeArchivo (){
				Console.Write("Ingrese La Ruta Del Archivo A: ");
				string archivo1 = Console.ReadLine();
				Console.Write("Ingrese La Ruta Del Archivo B: ");
				string archivo2 = Console.ReadLine();
			}
			public void CreaArchivo(){
				if (File.Exists(archivo1) && File.Exists(archivo2))
				{
					Console.WriteLine("\n\n\t El Archivo " + archivo1 + " SI EXISTE Y CONTIENE:\n\n");
					FileStream fs = new FileStream(archivo1, FileMode.Open);
					StreamReader reader = new StreamReader(fs);
					Console.WriteLine(reader.ReadToEnd());
					
					Console.WriteLine("\n\n\t El Archivo " + archivo2 + " SI EXISTE Y CONTIENE:\n\n");
					FileStream fs2 = new FileStream(archivo2, FileMode.Open);
					StreamReader reader2 = new StreamReader(fs2);
					Console.WriteLine(reader2.ReadToEnd());
				}
				else
				{
					Console.WriteLine("\n\n\t *****ERROR EN EL SISTEMA***** \n LO SENTIMOS ALGUN ARCHIVO NO EXISTE");
				}
				
				Console.ReadKey();
			}
		}
	}
	


