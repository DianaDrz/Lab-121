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
	/// Description of Vehiculo.
	/// </summary>
	public class Vehiculo
		
	{
		private String placa,marca,color,modelo;
		
		public Vehiculo()
		{
			placa="3123FSDF";
			marca="toyota";
			color="azul";
			modelo="98";
		}
		public void mostrar(){
			Console.WriteLine(placa+"\t"+marca+"\t"+color+"\t"+modelo);
			
		}
		
		public String getPlaca(){
			return placa;
		}
		public String getMarca(){
			return marca;
		}
		public String getColor(){
			return color;
		}
		public String getModelo(){
			return modelo;
		}
	}
}
