package conceito;

public class Tartaruga extends Reptil {//herdando herança
	@Override//com isso defino que pode ser sobreescrito
	public void locomover()
	{
		System.out.println("Bem devagarinho");
	}

}
