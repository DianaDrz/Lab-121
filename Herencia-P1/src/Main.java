
public class Main {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		//Persona p=new Persona();
		//p.mostrar();
		Trabajador t=new Trabajador();
		Administrativo a= new Administrativo("lp");
		System.out.println("-------------Datos del trabajador----------------");
		t.mostrar();
		System.out.println("---------------Datos del administrativo--------------");
		a.mostrar();
		System.out.println("---------------a)--------------");
		t.ordenar();
		t.mostrar();
		System.out.println("---------------b)--------------");
		System.out.println("Edad trabajador: "+t.edad());
		System.out.println("Edad administrativo: "+a.edad());
		System.out.println("---------------c)--------------");
		t.verificar(a);
	}

}
