package beans;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.io.PrintWriter;
import java.io.Serializable;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.GregorianCalendar;
import java.util.HashMap;
import java.util.Iterator;
import java.util.Map;
import java.util.Scanner;
import java.util.Set;
import java.util.Vector;



public class Galerija implements Serializable{
	private String  naziv;
	private String adresa;
	private int godina;
	private HashMap<String, Delo> mapaDela;	
	private HashMap<String, Autor> mapaAutora;	
	private static Galerija instanca;
	

	public Galerija(){
		mapaDela= new HashMap<String, Delo>();	
		mapaAutora= new HashMap<String, Autor>();
	}

	public static Galerija getInstance(){
		
		if(instanca==null)
			instanca= new Galerija();
		return instanca;
	}
	
	public Galerija(String naziv, String adresa, int godina,
			HashMap<String, Delo> mapaDela, HashMap<String, Autor> mapaAutora) {
		super();
		this.naziv = naziv;
		this.adresa = adresa;
		this.godina = godina;
		this.mapaDela = mapaDela;
		this.mapaAutora = mapaAutora;
	}

	public HashMap<String, Delo> getMapaDela() {
		return mapaDela;
	}

	public void setMapaDela(HashMap<String, Delo> mapaDela) {
		this.mapaDela = mapaDela;
	}

	public HashMap<String, Autor> getMapaAutora() {
		
		return mapaAutora;
	}

	public void setMapaAutora(HashMap<String, Autor> mapaAutora) {
		this.mapaAutora = mapaAutora;
	}
	
	
	Scanner sc= new Scanner(System.in);
	

	


	public void brisiDelo(String id) throws InvalidIdException{
		
		 synchronized (mapaAutora) {
 			 synchronized(mapaDela) {
		
 				 if (!mapaDela.containsKey(id))
		{
			String izuzetak="Ne postoji delo sa tom ID oznakom";
			
			throw new InvalidIdException(izuzetak);
		}
		
			Delo d= mapaDela.get(id);
			mapaDela.remove(id);
			
			Iterator<String> iter;
			Set<String> keys = mapaAutora.keySet();
			iter= keys.iterator();
			
			while (iter.hasNext()){
				String ida = iter.next();
				Autor a= mapaAutora.get(ida);
				HashMap<String,Delo> delaA= a.getDelaAutora();
				if (delaA.containsKey(id)) {
					delaA.remove(id);
				}
				
			}
		//	System.out.println(" "+d.naslov);
 			 }}
		
	}

	public void brisiAutora(String id) throws InvalidIdException{
		 
		synchronized (mapaAutora) {
 			 synchronized(mapaDela) {
		
 			
		if (!mapaAutora.containsKey(id))
		{
			String izuzetak="Ne postoji autor sa tom ID oznakom";
			
			throw new InvalidIdException(izuzetak);
		}
	
		mapaAutora.remove(id);
		
		Iterator<String> it;
		Set<String> keys = mapaDela.keySet();
		it= keys.iterator();
		while(it.hasNext()) {	
			String key = it.next();
			Delo d = mapaDela.get(key);		
			HashMap<String, Autor> autoriDela= d.getAutoriDela();
//			String id= a.getId();
			if(autoriDela.containsKey(id)){
				autoriDela.remove(id);
			}
		
		}
		 }}
	}
	
//DODAJ..............................................................
	
     public void dodajAutora(Autor autor) throws InvalidIdException, IOException{

    	 synchronized (mapaAutora) {
 	
		if (mapaAutora.containsKey(autor.getId())){
			String izuzetak2="Vec postoji autor sa tom ID oznakom";
	
			throw new InvalidIdException(izuzetak2);
		}	
    	
    	 if (!mapaAutora.containsKey(autor.getId()))
    	 {
		mapaAutora.put(autor.getId(), new Autor(autor.getIme(),autor.getPrezime(),
				autor.getDatRodj(),autor.getDatSmrti()
				,autor.getMestoRodjenja(),autor.getMestoSmrti(),autor.getBio(),autor.getId(),autor.getDelaAutora()));
    	 }

    	 }
	}

     public void dodajDelo(Delo delo) throws InvalidIdException{


 			 synchronized(mapaDela) {
 		
    	 System.out.println("delo_ime: "+delo.getNaslov());
    	 if (!mapaDela.containsKey(delo.getId())){
    		 System.out.println("DODAVANJE_DELA_GALERIJA");
 		mapaDela.put(delo.getId(), new Delo(delo.getNaslov(), delo.getTehnika(),
 				delo.getStil(), delo.getDatNast(), delo.getMestoNast(), delo.getOpis(),
 				delo.getUri(), delo.getId(),delo.getAutoriDela()));
    	 }
 			 }
 	}
     public void dodajSliku(Slika delo) throws InvalidIdException {
    	 
    	 synchronized(mapaDela) {
    		if(mapaDela.containsKey(delo.getId()))
    			{
    				String izuzetak1="Vec postoji delo sa tom ID oznakom";
    		
    				throw new InvalidIdException(izuzetak1);
    			}
    		else{
    			/*String naslov, String tehnika, String stil, Calendar datNast,
			String mestoNast, String opis, String uri, String id,
			HashMap<String, Autor> autoriDela, double sirina, double visina*/


    			
    			Slika slika= new Slika(delo.getNaslov(), delo.getTehnika(),
    					delo.getStil(), delo.getDatNast(), delo.getMestoNast(), delo.getOpis(),
		 				delo.getUri(), delo.getId(),delo.getAutoriDela(),delo.getSirina(),delo.getVisina());
    			
    			 System.out.println("DODAVANJE_slike_GALERIJA");
    		 		mapaDela.put(delo.getId(),slika);
    		 		
//    		 		Iterator<String> it;
//    				Set<String> keys = mapaDela.keySet();
//    				it= keys.iterator();
//    				while(it.hasNext()) {	
//    					String key = it.next();
//    					Slika d = (Slika)mapaDela.get(key);	
//    					System.out.println("slikaUmapi: "+d.getVisina());
//    				}
    		}
    	 }
    	}
//     
//     public Lista getLista(){
//    	 
//    	 Lista lista= new Lista();   	 
// 		Iterator it = mapaDela.keySet().iterator();
// 		while(it.hasNext()) {	
// 			Object key = it.next();
// 			Slika s = (Slika)mapaDela.get(key);	
// 			Skulptura skulp = (Skulptura)mapaDela.get(key);	
// 			if()
// 			lista.getSlike().put(s.getId(),s);
// 		}
//    	 
// 		return lista;
//     }
     
     public void dodajSkulpturu(Skulptura delo) throws InvalidIdException {
    	 
    	 synchronized(mapaDela) {
     		if(mapaDela.containsKey(delo.getId()))
     			{
     				String izuzetak1="Vec postoji delo sa tom ID oznakom";
     		
     				throw new InvalidIdException(izuzetak1);
     			}
     		else{
     			     			
     			/*Slika slika= new Slika(delo.getNaslov(), delo.getTehnika(),
     					delo.getStil(), delo.getDatNast(), delo.getMestoNast(), delo.getOpis(),
 		 				delo.getUri(), delo.getId(),delo.getAutoriDela(),delo.getSirina(),delo.getVisina());*/
     			
     			
     			/*String naslov, String tehnika, String stil,
				Calendar datNast, String mestoNast, String opis, String uri,
				String id, HashMap<String, Autor> autoriDela, double sirina,
				double visina, double duzina*/
     			
     			Skulptura skulptura= new Skulptura(delo.getNaslov(), delo.getTehnika(),
     					delo.getStil(), delo.getDatNast(), delo.getMestoNast(), delo.getOpis(),
 		 				delo.getUri(), delo.getId(),delo.getAutoriDela(),delo.getSirina(),delo.getVisina(),delo.getDuzina());
     			
     			 System.out.println("DODAVANJE_skulpt_GALERIJA");
     		 		mapaDela.put(delo.getId(),skulptura);
     		}
     	 }
    		
    	}

    	public void dodajMulti(MultimedijalniZapis delo) throws InvalidIdException {
    		
    		 synchronized(mapaDela) {
    	    		if(mapaDela.containsKey(delo.getId()))
    	    			{
    	    				String izuzetak1="Vec postoji delo sa tom ID oznakom";
    	    		
    	    				throw new InvalidIdException(izuzetak1);
    	    				
    	    			}
    	    		else{
    	    			/*String naslov, String tehnika, String stil,
			Calendar datNast, String mestoNast, String opis, String uri,
			String id, HashMap<String, Autor> autoriDela, double trajanje, String format,Vrsta vrsta*/
    	    			
    	    			MultimedijalniZapis mm= new MultimedijalniZapis(delo.getNaslov(), delo.getTehnika(),
    	     					delo.getStil(), delo.getDatNast(), delo.getMestoNast(), delo.getOpis(),
    	 		 				delo.getUri(), delo.getId(),delo.getAutoriDela(),delo.getTrajanje(),
    	 		 				delo.getFormat(),delo.getVrstaZapisa());
    	    			
    	    			 System.out.println("DODAVANJE_multimedija_GALERIJA");
    	    		 		mapaDela.put(delo.getId(),mm);
    	    		 		
    	    		 		
    	    		 		
    	    		}
    	    	 }
    		
    	}
    	
 	public void dodajDelaAutora(String autorID,Delo delo) throws InvalidIdException {
 		 synchronized (mapaAutora) {
 			 synchronized(mapaDela) {
 		
 		Autor autor= Galerija.getInstance().nadjiAutora(autorID);
 		HashMap<String, Delo> delaAutora= autor.getDelaAutora();
 		
 		System.out.println("autor:" +autor.getIme());
 		
		 System.out.println("AUTOR KLASA dodaj delo autora:");
		if (delaAutora.containsKey(delo.getId())){
			String izuzetak1="Vec postoji delo sa tom ID oznakom";
	
			throw new InvalidIdException(izuzetak1);
		}
		
		HashMap<String, Autor> autoriDela= delo.getAutoriDela();
		autoriDela.put(autorID,autor);
		
		if(delo instanceof Slika)
		{
			System.out.println("SLIKA ");
			Slika d = (Slika)delo;
			Slika mm= new Slika(d.getNaslov(), d.getTehnika(),
 					d.getStil(), d.getDatNast(), d.getMestoNast(), d.getOpis(),
		 				delo.getUri(), delo.getId(),delo.getAutoriDela(),d.getSirina(),d.getVisina());
			
			delaAutora.put(mm.getId(), mm);
			
			Galerija.getInstance().getMapaDela().put(mm.getId(), mm);
		}
		if(delo instanceof Skulptura)
		{
			System.out.println("SKULPT ");
			Skulptura d = (Skulptura)delo;
			Skulptura mm= new Skulptura(d.getNaslov(), d.getTehnika(),
 					d.getStil(), d.getDatNast(), d.getMestoNast(), d.getOpis(),
		 				delo.getUri(), delo.getId(),delo.getAutoriDela(),d.getSirina(),d.getVisina(),d.getDuzina());
			
			delaAutora.put(mm.getId(), mm);
			
			Galerija.getInstance().getMapaDela().put(mm.getId(), mm);
		}
		if(delo instanceof MultimedijalniZapis)
		{
			System.out.println("MULTIM ");
			MultimedijalniZapis d = (MultimedijalniZapis)delo;
			MultimedijalniZapis mm= new MultimedijalniZapis(d.getNaslov(), d.getTehnika(),
 					d.getStil(), d.getDatNast(), d.getMestoNast(), d.getOpis(),
		 				delo.getUri(), delo.getId(),delo.getAutoriDela(),d.getTrajanje(),
		 				d.getFormat(),d.getVrstaZapisa());
			
			delaAutora.put(mm.getId(), mm);
			
			Galerija.getInstance().getMapaDela().put(mm.getId(), mm);
		}
		
	
	
 			 }}
	}
 		
 	public void dodajAutoraDela(String deloID,Autor autor) throws InvalidIdException {
 		
 		Delo delo= Galerija.getInstance().nadjiDelo(deloID);
 		HashMap<String, Autor> autoriDela= delo.getAutoriDela();


		if (autoriDela.containsKey(autor.getId())){
			String izuzetak1="Vec postoji autor sa tom ID oznakom";
	
			throw new InvalidIdException(izuzetak1);
		}
		
		System.out.println("delo: "+deloID);
		System.out.println("dodajAutora: "+autor.getId());
		
		
		HashMap<String, Delo> delaAutora= autor.getDelaAutora();
		delaAutora.put(deloID,delo);
		
		autoriDela.put(autor.getId(), new Autor(autor.getIme(),autor.getPrezime(),
				autor.getDatRodj(),autor.getDatSmrti()
				,autor.getMestoRodjenja(),autor.getMestoSmrti(),autor.getBio(),autor.getId(),autor.getDelaAutora()));
	
		
		Galerija.getInstance().getMapaAutora().put(autor.getId(), new Autor(autor.getIme(),autor.getPrezime(),
				autor.getDatRodj(),autor.getDatSmrti()
				,autor.getMestoRodjenja(),autor.getMestoSmrti(),autor.getBio(),autor.getId(),delaAutora));
 	}
 	
 	
     public void izmeniAutora(Autor autor2) throws InvalidIdException, IOException{

    	 synchronized (mapaAutora) {
 			 synchronized(mapaDela) {
		
		if (!(mapaAutora.containsKey(autor2.getId()))){
			String izuzetak2="Ne postoji autor sa tom ID oznakom";
	
			throw new InvalidIdException(izuzetak2);
		}
		
		Autor autor= mapaAutora.get(autor2.getId());
		
		autor.setIme(autor2.getIme()); 
		autor.setPrezime(autor2.getPrezime()); 
		autor.setDatRodj(autor2.getDatRodj());
		autor.setDatSmrti(autor2.getDatSmrti()); 
		autor.setMestoRodjenja(autor2.getMestoRodjenja()); 
		autor.setMestoSmrti(autor2.getMestoSmrti());
		autor.setBio(autor2.getBio()); 
		
		System.out.println("galerija_izmena: "+autor.getIme());
		

		String a2id= autor2.getId();
		Iterator<String> it;
		Set<String> keys = mapaDela.keySet();
		it= keys.iterator();
		while(it.hasNext()) {	
			String key = it.next();
			Delo d = mapaDela.get(key);		
			HashMap<String, Autor> autoriDela= d.getAutoriDela();
//			String id= a.getId();
			if(autoriDela.containsKey(a2id)){
				Autor autord= autoriDela.get(a2id);
				autord.setIme(autor2.getIme()); 
				autord.setPrezime(autor2.getPrezime()); 
				autord.setDatRodj(autor2.getDatRodj());
				autord.setDatSmrti(autor2.getDatSmrti()); 
				autord.setMestoRodjenja(autor2.getMestoRodjenja()); 
				autord.setMestoSmrti(autor2.getMestoSmrti());
				autord.setBio(autor2.getBio()); 
			}
		}
 			 }}
	}

		
     public void izmeniDelo(Delo delo2) throws InvalidIdException{
 		
 		 synchronized (mapaAutora) {
 			 synchronized(mapaDela) {
 		 
    	 if (!(mapaDela.containsKey(delo2.getId()))){
 			String izuzetak1="Ne postoji delo sa tom ID oznakom";
 	
 			throw new InvalidIdException(izuzetak1);
 		}
 		
 		Delo delo= mapaDela.get(delo2.getId());
		delo.setNaslov(delo2.getNaslov());
 		delo.setTehnika(delo2.getTehnika());
 		delo.setStil(delo2.getStil());
 		delo.setDatNast(delo2.getDatNast());
 		delo.setMestoNast(delo2.getMestoNast());
 		delo.setOpis(delo2.getOpis());
 		delo.setUri(delo2.getUri());
 		
 		if(delo2 instanceof Slika){
			Slika s2= (Slika)delo2;
			Slika s= (Slika)delo;
			s.setVisina(s2.getVisina());
			s.setSirina(s2.getSirina());
		}else if(delo instanceof Skulptura)
		{

			Skulptura s2=(Skulptura)delo2;
			Skulptura s=(Skulptura)delo;
			s.setVisina(s2.getVisina());
			s.setSirina(s2.getSirina());
			s.setDuzina(s2.getDuzina());
		}else if(delo instanceof MultimedijalniZapis)
		{
			MultimedijalniZapis m=(MultimedijalniZapis)delo;
			MultimedijalniZapis m2=(MultimedijalniZapis)delo2;
			m.setTrajanje(m2.getTrajanje());
			m.setFormat(m2.getFormat());
			m.setVrstaZapisa(m2.getVrstaZapisa());
			
		}
		Iterator<String> iter;
		Set<String> keys = mapaAutora.keySet();
		iter= keys.iterator();
		String idd= delo2.getId();
		
		while (iter.hasNext()){
			String ida = iter.next();
			Autor a= mapaAutora.get(ida);
			HashMap<String,Delo> delaA= a.getDelaAutora();
			if (delaA.containsKey(idd)) {
				
				Delo deloa= delaA.get(idd);
				deloa.setNaslov(delo2.getNaslov());
		 		deloa.setTehnika(delo2.getTehnika());
		 		deloa.setStil(delo2.getStil());
		 		deloa.setDatNast(delo2.getDatNast());
		 		deloa.setMestoNast(delo2.getMestoNast());
		 		deloa.setOpis(delo2.getOpis());
		 		deloa.setUri(delo2.getUri());
		 		
		 		if(delo2 instanceof Slika){
					Slika s2= (Slika)delo2;
					Slika s= (Slika)deloa;
					s.setVisina(s2.getVisina());
					s.setSirina(s2.getSirina());
				}else if(delo instanceof Skulptura)
				{

					Skulptura s2=(Skulptura)delo2;
					Skulptura s=(Skulptura)deloa;
					s.setVisina(s2.getVisina());
					s.setSirina(s2.getSirina());
				}else if(delo instanceof MultimedijalniZapis)
				{
					MultimedijalniZapis m=(MultimedijalniZapis)deloa;
					MultimedijalniZapis m2=(MultimedijalniZapis)delo2;
					m.setFormat(m2.getFormat());
					m.setVrstaZapisa(m2.getVrstaZapisa());
					
				
			}
			
		}
 		}
 		 }
 	}
     
     }

	
	public Autor nadjiAutora(String id){
		
		synchronized(mapaAutora) {
		Autor rez=null;
		
		if(mapaAutora.containsKey(id))
			rez=mapaAutora.get(id);
		
		return rez;
		}
		
	}
	
	public Delo nadjiDelo(String id){
		
 			 synchronized(mapaDela) {
		Delo rez = null;
		
		if(mapaDela.containsKey(id))
			rez=mapaDela.get(id);
		
		return rez;
 			 }
	}
	
	//pronalaženje autora na osnovu: imena i prezimena, stila u kom su nastala njegova dela u galeriji i
	//tehnike kojom su nastala njegova dela u galeriji
	
	
	public Vector<Autor> nadjiAutora2(String vrednost) throws InvalidIdException{
		
		 synchronized (mapaAutora) {
 			 synchronized(mapaDela) {
 				 

			System.out.println("nadji2_galerija");
		Vector<Autor> rez = new Vector<Autor>();
		
		
		Iterator<String> iter;
		Set<String> keys = mapaAutora.keySet();
		iter= keys.iterator();
		while (iter.hasNext()){
			System.out.println("WHILE_nadji2_galerija");
			String id = iter.next();
			
			
			Autor a= mapaAutora.get(id);
			
			
			String ime= a.getIme();
			System.out.println("nadji2_ime_mapa: "+ime);
			String prz= a.getPrezime();
			System.out.println("nadji2_prz_mapa: "+prz);
			
			System.out.println("......VREDNOST: "+vrednost);
			
			if((ime.equals(vrednost)) || (prz.equals(vrednost)))
			{
				System.out.println("if");
				System.out.println("ime: "+ime);
				System.out.println("prz: "+prz);
				if(!rez.contains(a))	
				rez.add(a);
				
			}

				
				Iterator<String> iter1;
				HashMap<String,Delo> dela= a.getDelaAutora();
				Set<String> keys1 = dela.keySet();
				iter1= keys1.iterator();
				while (iter1.hasNext()){
					String id1 = iter1.next();
					Delo d= dela.get(id1);
					String stil= d.getStil();
					String teh=d.getTehnika();
					if(stil.equals(vrednost) || teh.equals(vrednost))
					{	
						if(!rez.contains(a))
							rez.add(a);
						
					}
					
				}
//				String izuzetak="U galeriji ne postoji trazeni autor";
//				throw new InvalidIdException(izuzetak);


		}
			
		return rez;
 			 }
 			 }
	}
		
	public Vector<Autor> nadjiAutoraTeh(String vrednost) throws InvalidIdException{
		
	
		 synchronized (mapaAutora) {
 			 synchronized(mapaDela) {
 				 
 			 
		System.out.println("nadjiATeh_galerija");
	Vector<Autor> rez = new Vector<Autor>();
	
	Iterator<String> iter;
	Set<String> keys = mapaAutora.keySet();
	iter= keys.iterator();
	while (iter.hasNext()){
		System.out.println("WHILE_nadjiATeh_galerija");
		String id = iter.next();
		
		
		Autor a= mapaAutora.get(id);
					
			Iterator<String> iter1;
			HashMap<String,Delo> dela= a.getDelaAutora();
			Set<String> keys1 = dela.keySet();
			iter1= keys1.iterator();
			while (iter1.hasNext()){
				String id1 = iter1.next();
				Delo d= dela.get(id1);

				String teh=d.getTehnika();
				if(teh.equals(vrednost))
				{	
					if(!rez.contains(a))
					rez.add(a);
					
				}
				
			}
//			String izuzetak="U galeriji ne postoji trazeni autor";
//			throw new InvalidIdException(izuzetak);


	}
		
	return rez;
 			 }
 			 }
	
}
	
	public Vector<Autor> nadjiAutoraPravac(String vrednost) throws InvalidIdException{
		
		 synchronized (mapaAutora) {
 			 synchronized(mapaDela) {
		
		System.out.println("nadjiATeh_galerija");
	Vector<Autor> rez = new Vector<Autor>();
	
	Iterator<String> iter;
	Set<String> keys = mapaAutora.keySet();
	iter= keys.iterator();
	while (iter.hasNext()){
		System.out.println("WHILE_nadjiAPravac_galerija");
		String id = iter.next();
		
		
		Autor a= mapaAutora.get(id);
					
			Iterator<String> iter1;
			HashMap<String,Delo> dela= a.getDelaAutora();
			Set<String> keys1 = dela.keySet();
			iter1= keys1.iterator();
			while (iter1.hasNext()){
				String id1 = iter1.next();
				Delo d= dela.get(id1);
				String stil= d.getStil();

				if(stil.equals(vrednost))
				{
					if(!rez.contains(a))
					rez.add(a);
					
				}
				
			}
//			String izuzetak="U galeriji ne postoji trazeni autor";
//			throw new InvalidIdException(izuzetak);


	}
		
	return rez;
 			 }
 			 }
}
	public HashMap<String, Delo> nadjiDelo2(String vrednost) throws InvalidIdException{
		
		synchronized (mapaAutora) {
 			 synchronized(mapaDela) {
 				HashMap<String, Delo> rez = new HashMap<String, Delo>();
		
System.out.println("vrednostGALERIJA "+vrednost);
		Iterator<String> iter;
		Set<String> keys = mapaDela.keySet();
		iter= keys.iterator();
		while (iter.hasNext()){
			System.out.println("WHILE_nadji2_galerija");
			String id = iter.next();
			Delo d = mapaDela.get(id);
			String naslov= d.getNaslov();
System.out.println("NASLOV DELA:"+ naslov);
			String teh= d.getTehnika();
System.out.println("TEHNIKA DELA:"+ teh);			
			String stil= d.getStil();

System.out.println("STIL DELA:"+ stil);

			if(naslov.equals(vrednost) || teh.equals(vrednost) || stil.equals(vrednost))
			{
				System.out.println("if");
				System.out.println("vred: "+vrednost);
				System.out.println("nalsov: "+naslov);
				System.out.println("teh:"+ teh);
				System.out.println("stil:"+ stil);
				
				if(!rez.containsKey(d.getId()))
					rez.put(d.getId(), d);
				
			} 

			        Iterator<String> itera;						
					HashMap<String,Autor> autori= d.getAutoriDela();
					Set<String> keys2 = autori.keySet();
					itera= keys2.iterator();
					while (itera.hasNext()){
						String ida = itera.next();
						Autor a= autori.get(ida);
						String ime=a.getIme(); 
						String prz=a.getPrezime();
						
						if(ime.equals(vrednost) || prz.equals(vrednost))
						{if(
								!rez.containsKey(d.getId()))
							rez.put(d.getId(), d);
						}
					}
				}

		
		return rez;
 			 }}
	}
	
	public Vector<Delo> nadjiDeloAutor(String imea, String prza) throws InvalidIdException {
		
		 synchronized (mapaAutora) {
 			 synchronized(mapaDela) {
		Vector<Delo> rez = new Vector<Delo>();		

				Iterator<String> iter;
				Set<String> keys = mapaDela.keySet();
				iter= keys.iterator();
				while (iter.hasNext()){
					
					String id = iter.next();
					Delo d = mapaDela.get(id);
	
					        Iterator<String> itera;						
							HashMap<String,Autor> autori= d.getAutoriDela();
							Set<String> keys2 = autori.keySet();
							itera= keys2.iterator();
							while (itera.hasNext()){
								String ida = itera.next();
								Autor a= autori.get(ida);
								String ime=a.getIme(); 
								String prz=a.getPrezime();
								
								if(ime.equals(imea) && prz.equals(prza))
								{if(
										!rez.contains(d))
									rez.add(d);
								}
							}
						}

				
				return rez;
 			 }}
	}
	
	public Vector<Delo> nadjiDeloTeh(String vrednost) throws InvalidIdException{


 			 synchronized(mapaDela) {
		
 		Vector<Delo> rez = new Vector<Delo>();
		

		Iterator<String> iter;
		Set<String> keys = mapaDela.keySet();
		iter= keys.iterator();
		while (iter.hasNext()){
			System.out.println("WHILE_nadji2_galerija");
			String id = iter.next();
			Delo d = mapaDela.get(id);

			String teh= d.getTehnika();
System.out.println("TEHNIKA DELA:"+ teh);			


			if(teh.equals(vrednost))
			{
				System.out.println("if");
				System.out.println("vred: "+vrednost);

				System.out.println("teh:"+ teh);
				if(!rez.contains(d))
				rez.add(d);
				
			} 
		
		
		}
		
		return rez;
 			 }
	}	
	
	public Vector<Delo> nadjiDeloPravac(String vrednost) throws InvalidIdException{


 			 synchronized(mapaDela) {
		
 		Vector<Delo> rez = new Vector<Delo>();
		

		Iterator<String> iter;
		Set<String> keys = mapaDela.keySet();
		iter= keys.iterator();
		while (iter.hasNext()){
			System.out.println("WHILE_nadji2_galerija");
			String id = iter.next();
			Delo d = mapaDela.get(id);

			String pravac= d.getStil();
System.out.println("TEHNIKA DELA:"+ pravac);			


			if(pravac.equals(vrednost))
			{
				System.out.println("if");
				System.out.println("vred: "+vrednost);

				System.out.println("teh:"+ pravac);
				if(!rez.contains(d))
				rez.add(d);
				
			} 
		
		
		}
		
		return rez;
 			 }
	}	


	
//GET/SET...........................................
	
	public String getNaziv() {
		return naziv;
	}
	public void setNaziv(String naziv) {
		this.naziv = naziv;
	}
	public String getAdresa() {
		return adresa;
	}
	public void setAdresa(String adresa) {
		this.adresa = adresa;
	}
	public int getGodina() {
		return godina;
	}
	public void setGodina(int godina) {
		this.godina = godina;
	}

	public Galerija(String naziv, String adresa, int godina) {
		super();
		this.naziv = naziv;
		this.adresa = adresa;
		this.godina = godina;
		
	}
	
	
	public void saveAutori(ObjectOutputStream out){
		
		try {
			out.writeObject(mapaAutora);
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	
	public void saveDela(ObjectOutputStream out){
		
		try {
			out.writeObject(mapaDela);
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	
	public void loadAutori(ObjectInputStream in){
		
		try {
			mapaAutora= (HashMap<String, Autor>) in.readObject();
		} catch (ClassNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	
public void loadDela(ObjectInputStream in){
		
		try {
			mapaDela= (HashMap<String, Delo>) in.readObject();
		} catch (ClassNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}






}
