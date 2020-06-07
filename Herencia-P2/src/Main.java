
public class Main {
	public static void main(String[] args) {
		CasaDomestica cd=new CasaDomestica();
		Hotel h=new Hotel(3);
		System.out.println("---------------a)CasaDomestica---------------");
		cd.mostrar();
		System.out.println("----------------a)HOTEL--------------");
		h.mostrar();
		System.out.println("---------------b)---------------");
		h.mayor(100);
		System.out.println("---------------c)---------------");
		System.out.println("la diferencia es: "+cd.diferencia(h));
	}

}
