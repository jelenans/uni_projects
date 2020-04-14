package beans;


import java.io.Serializable;
import java.util.Calendar;
import java.util.HashMap;
import java.util.Iterator;
import java.util.Set;






public class Autor implements Serializable{
	private String ime;
	private String prezime;
	private Calendar datRodj;
	private Calendar datSmrti;
	private String mestoRodjenja;
	private String mestoSmrti;
	private String bio;
	private String id;
	private HashMap<String, Delo> delaAutora;
	
	
	public Autor(){
		delaAutora= new HashMap<String,Delo>();
	}
	
	public Autor(String ime, String prezime, Calendar datRodj,
			Calendar datSmrti, String mestoRodjenja, String mestoSmrti,
			String bio, String id, HashMap<String, Delo> delaAutora) {
		super();
		this.ime = ime;
		this.prezime = prezime;
		this.datRodj = datRodj;
		this.datSmrti = datSmrti;
		this.mestoRodjenja = mestoRodjenja;
		this.mestoSmrti = mestoSmrti;
		this.bio = bio;
		this.id = id;
		this.delaAutora = delaAutora;
	}

	public String toString(){
		String autor= "\nid:" + id + "\nime:" + ime + "\nprezime:" + prezime
			+ "\ndatumRodjenja:" + datRodj.toString()+ ", \ndatumSmrti"
			+ datSmrti.toString() + "\nmestoRodjenja=" + mestoRodjenja
			+ "\nmestoSmrti=" + mestoSmrti + "\nbiografija=" + bio
			+ "\n";
		
		return autor;
				
	}
	
	public Calendar getDatRodj() {
		return datRodj;
	}
	
	public String getDatRodjTekstualno() {
		return datRodj.get(Calendar.MONTH) + "-"+datRodj.get(Calendar.DAY_OF_MONTH) + "-" +datRodj.get(Calendar.YEAR); 
	}
	
	public void setDatRodj(Calendar datRodj) {
		this.datRodj = datRodj;
	}
	public Calendar getDatSmrti() {
		return datSmrti;
	}
	
	public String getDatSmrtiTekstualno() {
		return datSmrti.get(Calendar.MONTH) + "-"+datSmrti.get(Calendar.DAY_OF_MONTH) + "-" +datSmrti.get(Calendar.YEAR); 
	}
	
	public void setDatSmrti(Calendar datSmrti) {
		this.datSmrti = datSmrti;
	}
	public String getIme() {
		return ime;
	}
	public void setIme(String ime) {
		this.ime = ime;
	}
	public String getPrezime() {
		return prezime;
	}
	public void setPrezime(String prezime) {
		this.prezime = prezime;
	}


	public String getMestoRodjenja() {
		return mestoRodjenja;
	}
	public void setMestoRodjenja(String mestoRodjenja) {
		this.mestoRodjenja = mestoRodjenja;
	}
	public String getMestoSmrti() {
		return mestoSmrti;
	}
	public void setMestoSmrti(String mestoSmrti) {
		this.mestoSmrti = mestoSmrti;
	}
	public String getBio() {
		return bio;
	}
	public void setBio(String bio) {
		this.bio = bio;
	}
	public String getId() {
		return id;
	}
	public void setId(String id) {
		this.id = id;
	}

	public HashMap<String, Delo> getDelaAutora() {
		return delaAutora;
	}

	public void setDelaAutora(HashMap<String, Delo> delaAutora) {
		this.delaAutora = delaAutora;
	}

	public Delo nadjiDeloAutora(String id){
		Delo rez = null;
		
		if(delaAutora.containsKey(id))
			rez=delaAutora.get(id);
		
		return rez;
		
	}



	
	public void pregledDelaAutora() {

		Iterator<String> iter;
		Set<String> keys = delaAutora.keySet();
		iter= keys.iterator();
		int i=1;
		while (iter.hasNext()){
			String id = iter.next();
			Delo d = delaAutora.get(id);
			System.out.println("\ndelo"+i+":"+d.toString());
			i++;
			
		}
	}
	

	
	

}
