package beans;

import java.io.Serializable;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.HashMap;
import java.util.Iterator;
import java.util.Set;


public class Delo implements Serializable{
	protected String naslov;
	protected String tehnika;
	protected String stil;
	protected Calendar datNast;
	protected String mestoNast;
	protected String opis;
	protected String uri;
	protected String id;
	protected HashMap<String, Autor> autoriDela;
	
	public Delo(){
		
		autoriDela= new HashMap<String, Autor>();
	}
	
	public Delo(String naslov, String tehnika, String stil, Calendar datNast,
			String mestoNast, String opis, String uri, String id,
			HashMap<String, Autor> autoriDela) {
		super();
		this.naslov = naslov;
		this.tehnika = tehnika;
		this.stil = stil;
		this.datNast = datNast;
		this.mestoNast = mestoNast;
		this.opis = opis;
		this.uri = uri;
		this.id = id;
		this.autoriDela = autoriDela;
	}
	
	
	public void dodajAutoreDela(Autor autor) throws InvalidIdException {
		if (autoriDela.containsKey(autor.getId())){
			String izuzetak1="Vec postoji delo sa tom ID oznakom";
	
			throw new InvalidIdException(izuzetak1);
		}
		autoriDela.put(autor.getId(), new Autor(autor.getIme(),autor.getPrezime(),
				autor.getDatRodj(),autor.getDatSmrti()
				,autor.getMestoRodjenja(),autor.getMestoSmrti(),autor.getBio(),autor.getId(),autor.getDelaAutora()));
	}
	
	public void pregledAutoraDela() {

		Iterator<String> iter;
		Set<String> keys = autoriDela.keySet();
		iter= keys.iterator();
		int i=1;
		while (iter.hasNext()){
			String id = iter.next();
			Autor a = autoriDela.get(id);
			System.out.println("\nautor"+i+":"+a.toString());
			i++;
		}
		}
	
	public String getOpis() {
		return opis;
	}
	public void setOpis(String opis) {
		this.opis = opis;
	}
	public HashMap<String, Autor> getAutoriDela() {
		return autoriDela;
	}
	public void setAutoriDela(HashMap<String, Autor> autoriDela) {
		this.autoriDela = autoriDela;
	}
	public String getNaslov() {
		return naslov;
	}
	public void setNaslov(String naslov) {
		this.naslov = naslov;
	}
	public String getTehnika() {
		return tehnika;
	}
	public void setTehnika(String tehnika) {
		this.tehnika = tehnika;
	}
	public String getStil() {
		return stil;
	}
	public void setStil(String stil) {
		this.stil = stil;
	}
	public Calendar getDatNast() {
		return datNast;
	}
	public void setDatNast(Calendar datNast) {
		this.datNast = datNast;
	}
	
	public String getDatNastTekstualno() {
		return datNast.get(Calendar.MONTH) + "-"+datNast.get(Calendar.DAY_OF_MONTH) + "-" +datNast.get(Calendar.YEAR); 
	}
	public String getMestoNast() {
		return mestoNast;
	}
	public void setMestoNast(String mestoNast) {
		this.mestoNast = mestoNast;
	}
	public String getUri() {
		return uri;
	}
	public void setUri(String uri) {
		this.uri = uri;
	}
	public String getId() {
		return id;
	}
	public void setId(String id) {
		this.id = id;
	}
	
	public String toString(){
		String delo= "\nnaslov: " + naslov + "\ntehnika: " + tehnika
			+ "\nstil: " + stil + "\ndatumNastanka: " + datNast
			+ "\nmestoNastanka: " + mestoNast + "\nopis:" + opis
			+ "\nURI: " +uri + "\nid:" + id;
		return delo;
		
	}
	

	
}
