package conceito;

public class Cachorro extends Mamifero {
	
	public void enterrarosso() { //Metodo da classe
		System.out.println("Enterrando Osso");
	}
	public void abanarrabo() {//Metodo da classe
		System.out.println("Abanando rabo");
	}
	public void reagir(String frase) {//Metodo da classe com assinatura diferentes (Sobrecarga)
		if(frase=="toma comida"||frase=="ola") {
			System.out.println("Abanar e latir");
		}else
			System.out.println("Rosnar");
		
	}
	public void reagir(int hora) {//Metodo da classe com assinatura diferentes (Sobrecarga)
		if(hora<12) {
			System.out.println("Abanar");
		}else {
			System.out.println("Rosnar");
		}
		
	
	}	
	public void reagir(boolean dono) {//Metodo da classe com assinatura diferentes (Sobrecarga)
		if(dono==true) {
			System.out.println("Abanar");
		}else {
			System.out.println("Rosnar");
		}
		
		
	
	}
	public void reagir(float peso) {//Metodo da classe com assinatura diferentes(Sobrecarga)
		if(peso<10) {
			System.out.println("Abanar");
		}else {
			System.out.println("rosnar");
		}
		
	}
}
