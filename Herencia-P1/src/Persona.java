
public class Persona {
	protected String nombre,apellidos,fechaNacimiento,expedido;
	protected int cedulaIdentidad;
	
	public Persona() {
		nombre="Ana";
		apellidos="Quispe";
		fechaNacimiento="12-06-1995";
		cedulaIdentidad=234234;
		expedido="lp";
	}
	
	public Persona(String exp) {
		nombre="ELias";
		apellidos="Apaza";
		fechaNacimiento="12-06-1998";
		cedulaIdentidad=223434;
		expedido=exp;
	}
	public void mostrar() {
		System.out.println("Nombre: "+nombre);
		System.out.println("Apellidos: "+apellidos);
		System.out.println("Fecha de nacimiento: "+fechaNacimiento);
		System.out.println("CI: "+cedulaIdentidad);
		System.out.println("Expedido: "+expedido);
	}
	//b) Realizar un método para mostrar la edad
	
	public int edad() {
		return 2020-Integer.parseInt(fechaNacimiento.substring(fechaNacimiento.length()-4, fechaNacimiento.length()));
	}
	//c) Verificar si el administrativo y trabajador son del mismo departamento.
	public void verificar(Persona a) {
		boolean sw=false;
		if (expedido.equals(a.expedido))
			sw = true;
		if(sw)
			System.out.println("Son del mismo lugar");
		else
			System.out.println("No son del mismo lugar");
	}
	
}
