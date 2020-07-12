import java.util.Scanner;
public class Medico implements java.io.Serializable{
	private String nombre;
	private String codmed;
	private String especialidad;
	
	public Medico() {
		this.nombre = "";
		this.codmed = "";
		this.especialidad = "";
	}
	
    public void leer(){
    	Scanner lee= new Scanner(System.in);
    	System.out.print("Nombre: ");
    	this.nombre=lee.next();
    	System.out.print("codmedico: ");
    	this.codmed=lee.next();
    	System.out.print("Especialidad: ");
    	this.especialidad=lee.next();
    }
    public void mostrar(){
    	System.out.println("\n Datos del medico");
    	System.out.println("Nombre: "+ nombre);
    	System.out.println("CODIGO : "+ codmed);
    	System.out.println("ESPECIALIDAD: "+ especialidad);
    }

	public String getNombre() {
		return nombre;
	}

	public void setNombre(String nombre) {
		this.nombre = nombre;
	}

	public String getCodmed() {
		return codmed;
	}

	public void setCodmed(String codmed) {
		this.codmed = codmed;
	}

	public String getEspecialidad() {
		return especialidad;
	}

	public void setEspecialidad(String especialidad) {
		this.especialidad = especialidad;
	}
}
