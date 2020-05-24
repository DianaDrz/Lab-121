/*
 * Created by SharpDevelop.
 * User: pc
 * Date: 24/5/2020
 * Time: 7:23 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Prepasoejercio2
{
	class Program
	{
		public static void Main(string[] args)
		{
			Vehiculo v=new Vehiculo();
			Parqueo p=new Parqueo();
			v.mostrar();
			Console.WriteLine("--------------------------------------");
			p.mostrar();
			Console.WriteLine("-----------------sobrecarga operador a)---------------------");
			//p++;
			Console.WriteLine("-----------------sobrecarga operador b)---------------------");
			p=p-v;
			Console.WriteLine("-----------------sobrecarga metodo a)---------------------");
			p.verificar(v);
			Console.WriteLine("-----------------sobrecarga metodo b)---------------------");
			p.verificar("13");
			
			Console.ReadKey(true);
		}
	}
}