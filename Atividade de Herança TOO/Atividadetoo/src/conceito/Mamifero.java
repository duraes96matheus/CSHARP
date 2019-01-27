package conceito;

public class Mamifero extends Animal{
	
	private String cordopelo;
	
	public void setcordopelo(String cordopelo) {
		this.cordopelo= cordopelo ;
	}
	public String cordopelo() {
		return cordopelo;
	}
	

	@Override//Metodo de chamar a sobreescrita
	public void locomover() {
		System.out.println("Correndo");
		
	}

	@Override//Metodo de chamar a sobreescrita
	public void alimentar() {
		// TODO Auto-generated method stub
		System.out.println("Mamando");
	}

	@Override//Metodo de chamar a sobreescrita
	public void emitirsom() {
		// TODO Auto-generated method stub
		System.out.println("Som de mamifero");
	}

}
