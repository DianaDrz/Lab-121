import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.util.Scanner;

public class ArchMedico {
	private String na;
	private Medico med;

	public ArchMedico(String na) {
		this.na = na;
	}

	public void crear() throws ClassNotFoundException, IOException {
		ObjectOutputStream arch = new ObjectOutputStream(new FileOutputStream(na));
		arch.close();
	}

	public void adicionar() throws ClassNotFoundException, IOException {
		String op;
		Scanner lee = new Scanner(System.in);
		ObjectOutputStream arch = null;
		try {
			arch = new ObjectOutputStream(new FileOutputStream(na));
			do {
				med = new Medico();
				med.leer();
				arch.writeObject(med);
				System.out.println("\nDesea adicionar s/n");
				op = lee.next();
			} while (op.equals("s"));
			arch.close();
		} catch (Exception e) {
			System.out.println("\nfin adiciona");
		}
	}

	public void listar() throws ClassNotFoundException, IOException {
		ObjectInputStream arch = null;
		try {
			arch = new ObjectInputStream(new FileInputStream(na));
			while (true) {
				med = new Medico();
				med = (Medico) arch.readObject();
				med.mostrar();
			}
		} catch (Exception e) {
			System.out.println("\nfin listar");
		} finally {
			arch.close();
		}
	}

	public void contar() throws ClassNotFoundException, IOException {
		int cont = 0, n = 0;
		ObjectInputStream arch = null;
		String v[] = new String[10];
		try {
			arch = new ObjectInputStream(new FileInputStream(na));
			Medico aux;
			n = 0;
			for (int i = 1; i <= arch.hashCode(); i++) {
				aux = (Medico) arch.readObject();
				v[i] = aux.getEspecialidad();
				n++;
			}

		} catch (Exception e) {
			System.out.println("\nfin listado");
		} finally {
			arch.close();
		}
		int c = 0;
		for (int i = 1; i <= n; i++) {
			c = 1;
			String a = v[i];
			if (!a.equals("-")) {
				for (int j = i + 1; j <= n; j++)
					if (a.equals(v[j])) {
						c++;
						v[j] = "-";
					}
				System.out.println(a + "-" + c);
			}

		}
	}

	// b. Mostrar los médicos que tienen mas de dos especialidades

	public void mostrarEspecialidad() throws ClassNotFoundException,
			IOException {
		int cont = 0, n = 0;
		ObjectInputStream arch = null;
		String v[] = new String[10];
		try {
			arch = new ObjectInputStream(new FileInputStream(na));
			Medico aux;
			n = 0;
			for (int i = 1; i <= arch.hashCode(); i++) {
				aux = (Medico) arch.readObject();
				v[i] = aux.getNombre();
				n++;
			}

		} catch (Exception e) {
			System.out.println("\n fin mostrar");
		} finally {
			arch.close();
		}
		int c = 0;
		for (int i = 1; i <= n; i++) {
			c = 1;
			String a = v[i];
			if (!a.equals("-")) {
				for (int j = i + 1; j <= n; j++)
					if (a.equals(v[j])) {
						c++;
						v[j] = "-";
					}
				if (c > 2)
					System.out.println("Nombre: " + a + "aux");
			}
		}

	}

	public boolean Eliminar(String codMed)throws ClassNotFoundException,IOException{   
		boolean sw = false;    
		ObjectInputStream aMedico = null;    
		ObjectOutputStream aCopia = null;    
		try {      
			aMedico = new ObjectInputStream(new FileInputStream(na));      
			aCopia = new ObjectOutputStream(new FileOutputStream("copia.dat",true));     
			while(true){       
				med = new Medico();        
				med = (Medico)aMedico.readObject();        
				if(med.getCodmed().equals(codMed))          
					sw = true;       
				else          
					aCopia.writeObject(med);     
				}    
			} catch (Exception e) {   
				System.out.println("Fin Elimina");    
			}finally{    
				aMedico.close();      
				aCopia.close();     
				File f1 = new File(na);      
				File f2 = new File("copia.dat");      
				f1.delete();      
				f2.renameTo(f1);    
				}   
			return sw;  
			}
	}
