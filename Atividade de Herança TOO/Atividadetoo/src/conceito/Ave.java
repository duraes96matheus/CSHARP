package conceito;

public class Ave extends Animal{//Herdando atributos e metodos da classe pai
	private String corPena;//Atributo proprio da classe
	
	public void setcorPena(String corPena) {
		this.corPena=corPena;
	}
	public String corPena() {
		return corPena;
	}

	@Override //Forma de chamar a sobreescrita de metodo
	public void locomover() {
		// TODO Auto-generated method stub
		System.out.println("Voando");
	}

	@Override//Forma de chamar a sobreescrita de metodo
	public void alimentar() {
		System.out.println("Comendo frutas");
		// TODO Auto-generated method stub
		
	}

	@Override//Forma de chamar a sobreescrita de metodo
	public void emitirsom() {
		System.out.println("som de ave");
		// TODO Auto-generated method stub
		
	}
	public void fazerninho() {//metodo proprio da classe
		System.out.println("Construindo ninho");
	}

}
