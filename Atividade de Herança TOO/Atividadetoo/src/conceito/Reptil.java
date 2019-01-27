package conceito;

public class Reptil extends Animal{//herdando atributos e metodos
	
	private String corEscama;
	
	public void setcorEscama(String corEscama) {//atributo proprio da classe
		this.corEscama=corEscama;
	}
	public String corEscama(){
		return corEscama;
	}

	@Override//sobreescrevendo
	public void locomover() {
		// TODO Auto-generated method stub
		System.out.println("Rastejando");
	}

	@Override//sobreescrevendo
	public void alimentar() {
		System.out.println("Comendo Vegetais");
		// TODO Auto-generated method stub
		
	}

	@Override//sobreescrevendo
	public void emitirsom() {
		// TODO Auto-generated method
		System.out.println("Som de reptil");
		
	}

}
