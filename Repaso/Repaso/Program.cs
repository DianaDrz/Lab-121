/*
 * Created by SharpDevelop.
 * User: pc
 * Date: 24/5/2020
 * Time: 5:49 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Repaso
{
	class Program
	{
		public static void Main(string[] args)
		{
			Veterinaria v=new Veterinaria();
			v.mostrar();
			Console.WriteLine("---------------a)-------------");
			v--;
			Console.WriteLine("---------------b)-------------");
			v=v-"napoleon";
			//int x=v-"napoleon";
			//Console.WriteLine("contador"+x);
			Console.WriteLine("---------------sobrecarga de metodos a)-------------");
			v.mostrar("juan");
			Console.WriteLine("---------------sobrecarga de metodos b)-------------");
			v.mostrar(2);
			Console.ReadKey(true);
		}
	}
}