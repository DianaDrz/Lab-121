/*
 * Created by SharpDevelop.
 * User: pc
 * Date: 24/5/2020
 * Time: 7:25 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Prepasoejercio2
{
	/// <summary>
	/// Description of Parqueo.
	/// </summary>
	public class Parqueo
	{
		private String nombre,direccion;
		private int nroVehiculos;
		private String [,] vehiculo= new String[100,5];
			
		public Parqueo()
		{
			nombre="Real";
			direccion="av. simon bolivar";
			nroVehiculos=4;
			vehiculo[1,1]="3123FSDF";vehiculo[1,2]="toyota";vehiculo[1,3]="azul";vehiculo[1,4]="98";
			vehiculo[2,1]="123DFFG";vehiculo[2,2]="toyota";vehiculo[2,3]="negro";vehiculo[2,4]="87";
			vehiculo[3,1]="5345DFA";vehiculo[3,2]="toyota";vehiculo[3,3]="plomo";vehiculo[3,4]="98";
			vehiculo[4,1]="434DFAF";vehiculo[4,2]="dazda";vehiculo[4,3]="gris";vehiculo[4,4]="78";
		}
		
		public void mostrar(){
			Console.WriteLine("Nombre del parqueo:"+nombre);
			Console.WriteLine("Direccion: "+direccion);
			for(int i=1;i<=nroVehiculos;i++){
				Console.WriteLine(vehiculo[i,1]+"\t"+vehiculo[i,2]+"\t"+vehiculo[i,3]+"\t"+vehiculo[i,4]);
			}
		}
		
		/*
		 * Sobrecargar operadores para:
			a)	Mostrar a los vehículos de la marca X de color Y
			b)	Mostrar a los Vehículos del objeto parqueo que sean de la misma marca del objeto Vehículo
		
			

		 */
		public static Parqueo operator ++(Parqueo p){
			Console.WriteLine("Introduzca la marca:");
			String x=Console.ReadLine();
			Console.WriteLine("Introduzca la color:");
			String y=Console.ReadLine();
			for(int i=1;i<=p.nroVehiculos;i++){
				if(p.vehiculo[i,2].Equals(x)&&p.vehiculo[i,3].Equals(y))
					Console.WriteLine(p.vehiculo[i,1]+"\t"+p.vehiculo[i,2]+"\t"+p.vehiculo[i,3]+"\t"+p.vehiculo[i,4]);
			}
			return p;
		}
		
		//b)	Mostrar a los Vehículos del objeto parqueo que sean de la misma marca del objeto Vehículo
		public static Parqueo operator -(Parqueo p, Vehiculo v){
			for(int i=1;i<=p.nroVehiculos;i++){
				if(p.vehiculo[i,2].Equals(v.getMarca()))
					Console.WriteLine(p.vehiculo[i,1]+"\t"+p.vehiculo[i,2]+"\t"+p.vehiculo[i,3]+"\t"+p.vehiculo[i,4]);
			}
			return p;
		}
		/*
		 * Sobrecargar un método para:
			c)	Verificar si existe el objeto Vehículo en el objeto Parqueo
			d)	Verificar si en el parqueo existe Vehículos modelo X
		 */
		
		public void verificar(Vehiculo v){
			Boolean sw=false;
			for(int i=1;i<=nroVehiculos;i++){
				if(vehiculo[i,1].Equals(v.getPlaca())&&vehiculo[i,2].Equals(v.getMarca())&&vehiculo[i,3].Equals(v.getColor())&&vehiculo[i,4].Equals(v.getModelo()))
					sw=true;
			}
			if(sw)
				Console.WriteLine("El vehiculo SI encuentra en el parqueo");
			else
				Console.WriteLine("El vehiculo NO encuentra en el parqueo");
		}
		public void verificar(String x){
			Boolean sw=false;
			for(int i=1;i<=nroVehiculos;i++){
				if(vehiculo[i,4].Equals(x))
					sw=true;
			}
			if(sw)
				Console.WriteLine("SI existen los vehiculos de la modelo:"+x);
			else
				Console.WriteLine("No existen los vehiculos de la modelo:"+x);
		}
	}
}
