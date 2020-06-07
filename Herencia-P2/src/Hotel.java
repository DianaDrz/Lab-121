
public class Hotel extends Edificio{
	
	private int nroHabitaciones;
	private String [][] h=new String [30][5];
	
	public Hotel(int nr) {
		super(nr);
		nroHabitaciones=3;
		h[1][1]="1";h[1][2]="4";h[1][3]="300";h[1][4]="si";
		h[2][1]="2";h[2][2]="6";h[2][3]="200";h[2][4]="si";
		h[3][1]="5";h[3][2]="7";h[3][3]="100";h[3][4]="no";
	}
	public void mostrar(){
		super.mostrar();
		for (int i = 1; i <=nroHabitaciones; i++) {
			System.out.println(h[i][1]+"\t"+h[i][2]+"\t"+h[i][3]+"\t"+h[i][4]);
		}
		
	}
	
	//b) Mostrar todas las Habitaciones del hotel que tengan un precio menor o igual a x.
	
	public void mayor(int x) {
		for (int i = 1; i <=nroHabitaciones; i++) {
			if(Integer.parseInt(h[i][3])<=x)
				System.out.println(h[i][1]+"\t"+h[i][2]+"\t"+h[i][3]+"\t"+h[i][4]);
		}
	}
}
