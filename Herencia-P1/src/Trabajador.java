
public class Trabajador extends Persona{
	private int nroEspecialidades;
	private String []especialidades=new String[20];
	
	public Trabajador() {
		super();
		nroEspecialidades=4;
		especialidades[1]="abogado";
		especialidades[2]="secretaria";
		especialidades[3]="medico";
		especialidades[4]="ingeniero";
	}
	public void mostrar() {
		super.mostrar();
		for (int i = 1; i <=nroEspecialidades; i++) {
			System.out.println(especialidades[i]);
		}
	}
	//a) Ordenar alfabéticamente las especialidades del objeto trabajador.
	public void ordenar() {
		for (int i = 1; i <=nroEspecialidades; i++) {
			for (int j = i+1; j <=nroEspecialidades; j++) {
				if(especialidades[i].compareTo(especialidades[j])>0) {
					String aux =especialidades[i];
					especialidades[i]=especialidades[j];
					especialidades[j]=aux;
				}
			}
			
		}
	}
	
}
