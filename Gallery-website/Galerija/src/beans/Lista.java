package beans;

import java.util.HashMap;

public class Lista {
	
	HashMap<String, Slika> slike;
	HashMap<String, Skulptura> skulpture;
	HashMap<String, MultimedijalniZapis> multi;
	
	public Lista() {
		slike= new HashMap<String, Slika>();
		skulpture= new HashMap<String, Skulptura>();
		multi= new HashMap<String, MultimedijalniZapis>();
	}

	public HashMap<String, Slika> getSlike() {
		return slike;
	}

	public void setSlike(HashMap<String, Slika> slike) {
		this.slike = slike;
	}

	public HashMap<String, Skulptura> getSkulpture() {
		return skulpture;
	}

	public void setSkulpture(HashMap<String, Skulptura> skulpture) {
		this.skulpture = skulpture;
	}

	public HashMap<String, MultimedijalniZapis> getMulti() {
		return multi;
	}

	public void setMulti(HashMap<String, MultimedijalniZapis> multi) {
		this.multi = multi;
	}
	
	
}
