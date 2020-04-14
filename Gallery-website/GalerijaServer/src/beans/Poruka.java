package beans;

import java.io.Serializable;

public class Poruka implements Serializable{
	
	String komanda="";
	Object objekat1=null;
	Object objekat2=null;
	
	public Poruka(){}

	public String getKomanda() {
		return komanda;
	}

	public void setKomanda(String komanda) {
		this.komanda = komanda;
	}

	public Object getObjekat1() {
		return objekat1;
	}

	public void setObjekat1(Object objekat) {
		this.objekat1 = objekat;
	}

	public Object getObjekat2() {
		return objekat2;
	}

	public void setObjekat2(Object objekat2) {
		this.objekat2 = objekat2;
	}
	
	
}
