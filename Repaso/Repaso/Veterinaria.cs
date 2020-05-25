/*
 * Created by SharpDevelop.
 * User: pc
 * Date: 24/5/2020
 * Time: 6:19 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Repaso
{
	/// <summary>
	/// Description of Veterinaria.
	/// </summary>
	public class Veterinaria
	{
		private String nombreVeterinaria;
		private int nroAnimales, nroAtencion;
		private String [,] dueñoMascota= new String[4,100];
		private String [,] atencion =new String[100,3];
		
		public Veterinaria()
		{
			nombreVeterinaria="Coquito";
			nroAnimales=3;
			dueñoMascota[1,1]="juan";dueñoMascota[2,1]="pelusa";dueñoMascota[3,1]="gato";
			dueñoMascota[1,2]="juan";dueñoMascota[2,2]="matias";dueñoMascota[3,2]="loro";
			dueñoMascota[1,3]="luis";dueñoMascota[2,3]="napoleon";dueñoMascota[3,3]="perro";
			nroAtencion=4;
			atencion[1,1]="2";atencion[1,2]="resfrio";
			atencion[2,1]="2";atencion[2,2]="vacuna antirrabica";
			atencion[3,1]="2";atencion[3,2]="corte de uñas";
			atencion[4,1]="2";atencion[4,2]="limpieza de dientes";
		}
		public void mostrar(){
			Console.WriteLine("Nombre veterinaria: "+nombreVeterinaria);
			for(int i=1;i<=nroAnimales;i++){
				Console.WriteLine(dueñoMascota[1,i]+"\t"+dueñoMascota[2,i]+"\t"+dueñoMascota[3,i]);
			}
			for(int j=1;j<=nroAtencion;j++){
				Console.WriteLine(atencion[j,1]+"\t"+atencion[j,2]);
			}
		}
		/*
		 * Sobrecargar operadores para:

		a)	Mostrar de cada mascota sus atenciones
		
		Sobrecargar un método para:
		•	Cuantas mascotas tiene el dueño con nombre X
		
		 */
		public static Veterinaria operator --(Veterinaria v){
			for(int i=1;i<=v.nroAnimales;i++){
				for(int j=1;j<=v.nroAtencion;j++){
					if(i==int.Parse(v.atencion[j,1]))
						Console.WriteLine("Nombre de la mascota: "+v.dueñoMascota[2,i]+"  Atencion: "+v.atencion[j,2]);
				}
			}
			return v;
		}
		//b)Cuantas veces se atendió a la mascota con nombre X
		public static Veterinaria operator -(Veterinaria v,String x){
			int contador=0;
			for(int i=1;i<=v.nroAnimales;i++){
				if(v.dueñoMascota[2,i].Equals(x)){
					for(int j=1;j<=v.nroAtencion;j++){
						if(i==int.Parse(v.atencion[j,1]))
							contador=contador+1;
					}
				}
			}
			Console.WriteLine("contador:"+contador);
			return v;
		}
		
		//•	Cuantas mascotas tiene el dueño con nombre X
		public void mostrar(String x){
			int contador=0;
			for(int i=1;i<=nroAnimales;i++){
				if(dueñoMascota[1,i].Equals(x))
					contador=contador+1;
			}
			Console.WriteLine("El nombre del dueño "+x+" cuenta con "+contador);
		}
		//•	Mostrar al i-esimo dueño y su mascota y las atenciones que tuvo esa mascota.
		public void mostrar(Aniamal v){
			Console.WriteLine("Dueño: "+dueñoMascota[1,i]);
			Console.WriteLine("Mascota: "+dueñoMascota[2,i]);
			for (int j=1;j<=nroAtencion;j++){
				if(i==int.Parse(atencion[j,1]))
					Console.WriteLine("Atencion"+atencion[j,2]);
			}
		}
		
	}
}
