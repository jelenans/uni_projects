package beans;
import java.util.Calendar;
import java.util.HashMap;


public class Skulptura extends Delo {
	
		private double sirina;
		private double visina;
		private double duzina;
		
		
		
		public Skulptura() {
			super();
			// TODO Auto-generated constructor stub
		}
		public Skulptura(String naslov, String tehnika, String stil,
				Calendar datNast, String mestoNast, String opis, String uri,
				String id, HashMap<String, Autor> autoriDela, double sirina,
				double visina, double duzina) {
			super(naslov, tehnika, stil, datNast, mestoNast, opis, uri, id,
					autoriDela);
			this.sirina = sirina;
			this.visina = visina;
			this.duzina = duzina;
		}
		public double getSirina() {
			return sirina;
		}
		public void setSirina(double sirina) {
			this.sirina = sirina;
		}
		public double getVisina() {
			return visina;
		}
		public void setVisina(double visina) {
			this.visina = visina;
		}
		public double getDuzina() {
			return duzina;
		}
		public void setDuzina(double duzina) {
			this.duzina = duzina;
		}
		
	
		
	
		
	}


