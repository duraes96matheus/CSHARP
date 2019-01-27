package conceito;

public class Peixe extends Animal{
	
	private String corEscama;//Atributo da classe 
	
	public void setcorEscama(String corEscama) {//metodo get e set
		this.corEscama=corEscama;
	}
	public String corEscama() {
		return corEscama;
	}
	public void soltarbola()
	{
		System.out.println("Sontando bolha");
	}

	@Override//Metodo de chamar a sobreescrita
	public void locomover() {
		// TODO Auto-generated method stub
		System.out.println("Nadando");
	}

	@Override//Metodo de chamar a sobreescrita
	public void alimentar() {
		// TODO Auto-generated method stub
		System.out.println("Comendo Substâncias");
		
	}

	@Override//Metodo de chamar a sobreescrita
	public void emitirsom() {
		// TODO Auto-generated method stub
		System.out.println("Peixe não faz som");
	}

}
