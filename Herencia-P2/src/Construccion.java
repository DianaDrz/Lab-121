
public class Construccion {
	protected int nroPisos,superficie;
	protected String propirtario,ubicacion;
	
	public Construccion() {
		nroPisos=3;
		propirtario="Juan";
		ubicacion="av.bolivar";
		superficie=7;
		
	}
	public Construccion(int nr) {
		nroPisos=nr;
		propirtario="Maria";
		ubicacion="av.patiño";
		superficie=5;
		
	}
	
	public void mostrar(){
		System.out.println("Numero de pisos: "+nroPisos);
		System.out.println("Propietario: "+propirtario);
		System.out.println("Ubicacion: "+ubicacion);
		System.out.println("SUperficie: "+superficie);
	}
	public int diferencia(Construccion a) {
		int dif=superficie-a.superficie;
		return dif;
	}
	

}
