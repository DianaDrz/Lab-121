
public class Edificio extends Construccion{
	protected int nroSalidaEmer,nroAsensores,capacidadMax;
	
	public Edificio(int nr) {
		super(nr);
		nroSalidaEmer=2;
		nroAsensores=2;
		capacidadMax=6;
	}
	
	public void mostrar() {
		super.mostrar();
		System.out.println("Nro de salidas de emergencia: "+nroSalidaEmer);
		System.out.println("Nro de asensores: "+nroAsensores);
		System.out.println("capacidad maxima : "+capacidadMax);
	}
	
}
