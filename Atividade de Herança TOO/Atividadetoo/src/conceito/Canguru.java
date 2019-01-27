package conceito;

public class Canguru extends Mamifero{
	@Override//Forma de chamar a sobreescrita de metodo
	public void locomover() {
		System.out.println("Saltando");
	}
	public void usarbolsa() {
		System.out.println("Usando bolsa");
	}
	

}
