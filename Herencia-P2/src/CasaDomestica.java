
public class CasaDomestica extends Construccion{
	private int nroHabitantes, NroCuartos,NroBanos;
	
	public CasaDomestica() {
		super();
		nroHabitantes=6;
		NroCuartos=5;
		NroBanos=2;
	}
	public void mostrar(){
		super.mostrar();
		System.out.println("Nro de habitantes: "+nroHabitantes);
		System.out.println("Nro de cuartos: "+NroCuartos);
		System.out.println("Nro de baños: "+NroBanos);
	}
	
}
