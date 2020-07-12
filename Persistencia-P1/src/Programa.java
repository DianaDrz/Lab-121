import java.io.IOException;
import java.util.Scanner;


public class Programa {

	public static void main(String[] args) throws ClassNotFoundException, IOException {
		// TODO Auto-generated method stub
		ArchMedico a=new ArchMedico("d:\\medico.dat");
		Scanner lee= new Scanner(System.in);
		int op;
		do{ 	
			System.out.print("\n--MENU DEL ARCHIVO MEDICO--");
			System.out.print("\n 1. Crear" + 
							 "\n 2. Adicionar"+
							 "\n 3. Listar"+
							 "\n 4. Mostrar la cantidad de médicos por especialidad "+
							 "\n 5. Mostrar los médicos que tienen mas de dos especialidades"+
							 "\n 6. Eliminar al médico con códMedico 987635RD");
			
			/*
			 a. Mostrar la cantidad de médicos por especialidad 
			 b. Mostrar los médicos que tienen mas de dos especialidades 
			 c. Eliminar al médico con códMedico 987635RD
			 */
			op=lee.nextInt();
			switch (op) {
			case 1:
				a.crear();
				break;
			case 2:
				a.adicionar();
				break;
			case 3:
				a.listar();
				break;
			case 4:
				a.contar();
				break;
			case 5:
				a.mostrarEspecialidad();
				break;
			  case 6:            
				  System.out.print("Intr. Codigo de medico a eliminar: ");      
				  if(a.Eliminar(lee.next()))          
					  System.out.print("\n Registro eliminado");    
				  else          
					  System.out.println("\n Registro NO eliminado");      
				  break;   
			default:
				break;
			}
		}while(op != 7);
	}

}
