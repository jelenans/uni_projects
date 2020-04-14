package beans;
import java.util.Calendar;
import java.util.HashMap;



public class MultimedijalniZapis extends Delo {
	

	private double trajanje;
	private String format;
	private Vrsta vrstaZapisa;

	public MultimedijalniZapis() {
		super();
		// TODO Auto-generated constructor stub
	}

	

	public MultimedijalniZapis(String naslov, String tehnika, String stil,
			Calendar datNast, String mestoNast, String opis, String uri,
			String id, HashMap<String, Autor> autoriDela, double trajanje, String format,Vrsta vrsta) {
		
		super(naslov, tehnika, stil, datNast, mestoNast, opis, uri, id, autoriDela);

this.trajanje=trajanje;
this.format=format;
this.vrstaZapisa=vrsta;
	}

	public Vrsta getVrstaZapisa() {
		return vrstaZapisa;
	}

	public void setVrstaZapisa(Vrsta vrstaZapisa) {
		this.vrstaZapisa = vrstaZapisa;
	}

	public double getTrajanje() {
		return trajanje;
	}
	public void setTrajanje(double trajanje) {
		this.trajanje = trajanje;
	}
	public String getFormat() {
		return format;
	}
	public void setFormat(String format) {
		this.format = format;
	}
	
}
