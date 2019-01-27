package conceito;

public abstract class Animal {//crio a classe e defino que será abstrata
	
	protected float peso=0; // defino como protegido para poder usar em outras classes
	protected int idade= 0;
	protected int membros =0;
	
	public abstract void locomover();//automaticamente o metode se torna abstrato
	{
		System.out.println("Locomovendo-se");
	}
	public abstract void alimentar();
	{
		System.out.println("Alimentando-se");
	}
	public abstract void emitirsom();
	{
		System.out.println("emitindo som");
	}
	public float peso(){//os atributos são chamados por metodos publicos 
		return peso;
	}
	public void setpeso(int peso)
	{
		this.peso=peso;
	}
	public int idade(){
		return idade;
	}
	public void setidade(int idade)
	{
		this.idade=idade;
	}
	public int membros(){
		return membros;
	}
	public void setmembros(int membros)
	{
		this.membros=membros;
	}	
	
	public static void main(String[] arg) {	
		
		Mamifero leao=new Mamifero(); //instancio novos objetos
		leao.setidade(5);
		leao.setcordopelo("Amarelo");
		leao.setmembros(4);
		leao.setpeso(200);
		leao.alimentar();
		leao.locomover();
		leao.emitirsom();
		
		System.out.println(leao.toString());
		
		Reptil largato = new Reptil(); //instancio novos objetos
		largato.setidade(2);
		largato.setcorEscama("Verde");//Atributo pertencente a clasee
		largato.setmembros(4);
		largato.setpeso(5);
		largato.alimentar();
		largato.emitirsom();
		largato.locomover();
		
		System.out.println(largato.toString());
		
		Peixe carpa= new Peixe(); //instancio novos objetos
		carpa.setidade(2);
		carpa.setcorEscama("Verde");//Atributo pertencente a clasee
		carpa.setmembros(4);
		carpa.setpeso(5);
		carpa.alimentar();
		carpa.emitirsom();
		carpa.locomover();
		carpa.soltarbola();
		
		System.out.println(carpa.toString());

		Ave passaro = new Ave();
		passaro.setidade(2);
		passaro.setmembros(4);
		passaro.setpeso(5);
		passaro.alimentar();
		passaro.emitirsom();
		passaro.locomover();
		passaro.fazerninho();
		
		System.out.println(passaro.toString());
		
		Canguru canguru1= new Canguru();
		canguru1.locomover();//Metodo sobreescrito
		canguru1.usarbolsa();//metodo somente da classe
		
		System.out.println(canguru1.toString());
		
		
		Cachorro cachorro1 = new Cachorro();
		cachorro1.setcordopelo("Amarelo");
		cachorro1.setidade(5);
		cachorro1.setmembros(4);
		cachorro1.setpeso(10);
		cachorro1.abanarrabo();
		cachorro1.alimentar();
		cachorro1.locomover();
		cachorro1.enterrarosso();
		cachorro1.reagir(true);//metodo somente da classe
		cachorro1.reagir(10);//metodo somente da classe
		cachorro1.reagir("ola");//metodo somente da classe
		
		System.out.println(cachorro1.toString());
		
		
		
	

	}
}
