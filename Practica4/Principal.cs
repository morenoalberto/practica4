using System;

namespace Practica4
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Archivoc objeto = new Archivoc ();
			Console.WriteLine("Ingrese Los Archivos a Localizar en .txt \n\n[ ejemplo C:\\\\prueba.txt ]\n");
			objeto.LeeArchivo ();
			objeto.CreaArchivo ();
		}
	}
}
