/*
-nroEspecialidades
-especialidades [20]
 */
public class Administrativo extends Persona{
	private String cargo;
	private int item;
	
	public Administrativo(String exp) {
		super(exp);
		cargo= "doctor";
		item=232;
	}
	public void mostrar() {
		super.mostrar();
		System.out.println("Cargo: "+cargo);
		System.out.println("Item: "+item);
	}
	

}
