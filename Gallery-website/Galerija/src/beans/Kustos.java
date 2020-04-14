package beans;

import java.io.Serializable;




public class Kustos implements Serializable {

	private String ime="";
	private String lozinka="";
	private boolean logged=false;
	
	
	public Kustos(){
		ime="";
		lozinka="";
		logged=false;		
	}
	


	public Kustos(String ime, String lozinka, boolean logged) {
		super();
		this.ime = ime;
		this.lozinka = lozinka;
		this.logged = logged;
		
	}




	public String getIme() {
		return ime;
	}

	public void setIme(String ime) {
		this.ime = ime;
	}

	public String getLozinka() {
		return lozinka;
	}

	public void setLozinka(String lozinka) {
		this.lozinka = lozinka;
	}



	public boolean isLogged() {
		return logged;
	}



	public void setLogged(boolean logged) {
		this.logged = logged;
	}

	
	
	
}
