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
	
	//DELO....................................................................
	

	

   
    
  

	public void pregledDela(){
		
		Iterator<String> iter;
		Set<String> keys = mapaDela.keySet();
		iter= keys.iterator();
		int i=1;
		while (iter.hasNext()){
			String id = iter.next();
			Delo d = mapaDela.get(id);
			System.out.println("delo"+i+":"+d.toString());
			i++;
			
		}
	}
	
	public void brisiDelo(String id) throws InvalidIdException{
		if (!mapaDela.containsKey(id))
		{
			String izuzetak="Ne postoji delo sa tom ID oznakom";
			
			throw new InvalidIdException(izuzetak);
		}
		
			Delo d= mapaDela.get(id);
			mapaDela.remove(id);
		//	System.out.println(" "+d.naslov);
		
		
	}

	
//DODAJ..............................................................
	
     public void dodajAutora(Autor autor) throws InvalidIdException, IOException{

		if (mapaAutora.containsKey(autor.getId())){
			String izuzetak2="Vec postoji autor sa tom ID oznakom";
	
			throw new InvalidIdException(izuzetak2);
		}
//			
//			HashMap<String, Autor> autoriDela= new HashMap<String, Autor>();
//			
//			autoriDela.put(autor.getId(),autor);
//			Delo delo = new Delo(naslov,tehnika,stil,datNast,mestoNast,opis,uri,id,autoriDela);
//			autor.dodajDelaAutora(delo);
//			mapaDela.put(delo.getId(), new Delo(delo.getNaslov(),delo.getTehnika(),delo.getStil(),delo.getDatNast(),
//					delo.getMestoNast(),delo.getOpis(),delo.getUri(),delo.getId(),delo.getAutoriDela()));
//			
//		} while(odgDelo.equals("d"));
//	
    	
    	 if (!mapaAutora.containsKey(autor.getId()))
    	 {
		mapaAutora.put(autor.getId(), new Autor(autor.getIme(),autor.getPrezime(),
				autor.getDatRodj(),autor.getDatSmrti()
				,autor.getMestoRodjenja(),autor.getMestoSmrti(),autor.getBio(),autor.getId(),autor.getDelaAutora()));
    	 }


	}

     public void dodajDelo(Delo delo) throws InvalidIdException{
 		
// 		if (mapaDela.containsKey(delo.getId())){
// 			String izuzetak1="Vec postoji delo sa tom ID oznakom";
 //	
// 			throw new InvalidIdException(izuzetak1);
// 		}
// 		
// 		String odgAutor="";
// 		do{
// 			
// 			do{
// 				System.out.println("Da li zelite da unesete autora dela?[d/n]");
// 				odgAutor= sc.nextLine();
// 			}while(!(odgAutor.equals("d")|| odgAutor.equals("n")));
 //
// 			if(odgAutor.equals("n"))
// 				break;
// 			
// 		
// 		System.out.print("Unesite ime autora: ");
// 		String ime = sc.nextLine();
// 		
// 		System.out.print("Unesite prezime autora: ");
// 		String prezime = sc.nextLine();
// 		
// 		System.out.println("Unesite mesto rodjenja autora: ");
// 		String mestoRodjenja = sc.nextLine();
// 		
// 		System.out.println("Unesite mesto smrti autora: ");
// 		String mestoSmrti = sc.nextLine();
// 		
// 		System.out.println("Unesite datum rodjenja autora: ");
// 		String dr = sc.nextLine();
// 		
// 		Calendar datRodjenja=new GregorianCalendar();
// 		try {
// 			datRodjenja.setTime((new SimpleDateFormat("dd.MM.yyyy.").parse(dr)));
// 		} catch (ParseException e) {
// 			// TODO Auto-generated catch block
// 			e.printStackTrace();
// 		}
// 		System.out.println(datRodjenja.getTime());
// 		
// 		System.out.println("Unesite datum smrti autora: ");
// 		String ds = sc.nextLine();
// 		Calendar datSmrti= new GregorianCalendar();
// 		try {
// 			datSmrti.setTime((new SimpleDateFormat("dd.MM.yyyy.").parse(ds)));
// 		} catch (ParseException e) {
// 			// TODO Auto-generated catch block
// 			e.printStackTrace();
// 		}
// 		System.out.println(datSmrti.getTime());
// 		
 //	
// 		System.out.println("Unesite id autora: ");
// 		String id = sc.nextLine();
// 		String sth="";
// 		System.out.println("Unesite biografiju autora: ");
// 	//	while (!(sth= stdin.readLine()).equals("END")){
// 			String biografija = sc.nextLine();
// 		//	}
// 		
// 	    HashMap<String, Delo> delaAutora= new HashMap<String, Delo>();
// 		Autor autor = new Autor(ime,prezime,datRodjenja,datSmrti,mestoRodjenja,
// 					mestoSmrti,biografija,id,delaAutora);
// 		delo.dodajAutoreDela(autor);
// 		
// 		mapaAutora.put(autor.getId(), new Autor(autor.getIme(),autor.getPrezime(),
// 				autor.getDatRodj(),autor.getDatSmrti()
// 				,autor.getMestoRodjenja(),autor.getMestoSmrti(),autor.getBio(),autor.getId(),autor.getDelaAutora()));
// 		} while(odgAutor.equals("d"));
// 		
// 		
    	 System.out.println("delo_ime: "+delo.getNaslov());
    	 if (!mapaDela.containsKey(delo.getId())){
    		 System.out.println("DODAVANJE_DELA_GALERIJA");
 		mapaDela.put(delo.getId(), new Delo(delo.getNaslov(), delo.getTehnika(),
 				delo.getStil(), delo.getDatNast(), delo.getMestoNast(), delo.getOpis(),
 				delo.getUri(), delo.getId(),delo.getAutoriDela()));
    	 }

 	}
	
 	public void dodajDelaAutora(String autorID,Delo delo) throws InvalidIdException {
 		
 		
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
		
		
		delaAutora.put(delo.getId(), new Delo(delo.getNaslov(), delo.getTehnika(),
				delo.getStil(), delo.getDatNast(), delo.getMestoNast(), delo.getOpis(),
				delo.getUri(), delo.getId(),delo.getAutoriDela()));
		
		Galerija.getInstance().getMapaDela().put(delo.getId(), new Delo(delo.getNaslov(),delo.getTehnika(),delo.getStil(),delo.getDatNast(),
				delo.getMestoNast(),delo.getOpis(),delo.getUri(),delo.getId(),autoriDela));
	}
 	
 	
     public void izmeniAutora(Autor autor2) throws InvalidIdException, IOException{

		
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
//		Scanner sc= new Scanner(System.in);
//		
//		System.out.print("Unesite ime autora: ");
//		String ime = sc.nextLine();
//		System.out.print("ime autora: "+ime);
//		
//		System.out.print("Unesite prezime autora: ");
//		String prezime = sc.nextLine();
//		
//		System.out.println("Unesite mesto rodjenja autora: ");
//		String mestoRodjenja = sc.nextLine();
//		
//		System.out.println("Unesite mesto smrti autora: ");
//		String mestoSmrti = sc.nextLine();
//		
//		System.out.println("Unesite datum rodjenja autora: ");
//		String dr = sc.nextLine();
//		
//		Calendar datRodjenja= new GregorianCalendar();
//		try {
//			datRodjenja.setTime((new SimpleDateFormat("dd.MM.yyyy.").parse(dr)));
//		} catch (ParseException e) {
//			// TODO Auto-generated catch block
//			e.printStackTrace();
//		}
//		System.out.println(datRodjenja.getTime());
//		
//		System.out.println("Unesite datum smrti autora: ");
//		String ds = sc.nextLine();
//		Calendar datSmrti=new GregorianCalendar();
//		try {
//			datSmrti.setTime((new SimpleDateFormat("dd.MM.yyyy.").parse(ds)));
//		} catch (ParseException e) {
//			// TODO Auto-generated catch block
//			e.printStackTrace();
//		}
//		System.out.println(datSmrti.getTime());
//		//String sth="";
//		System.out.println("Unesite biografiju autora: ");
//	//	while (!(sth= stdin.readLine()).equals("END")){
//			String biografija = sc.nextLine();
//		//	}
//
//			String odgDelo="";
//			do{
//				
//				do{
//					System.out.println("Da li zelite da unesete delo autora?[d/n]");
//					odgDelo= sc.nextLine();
//				}while(!(odgDelo.equals("d")|| odgDelo.equals("n")));
//
//				if(odgDelo.equals("n"))
//					break;
//				
//				System.out.print("Unesite naslov dela: ");
//				String naslov = sc.nextLine();
//				
//				System.out.print("Unesite tehniku dela: ");
//				String tehnika = sc.nextLine();
//				
//				System.out.println("Unesite stil dela: ");
//				String stil = sc.nextLine();
//				
//				System.out.println("Unesite datum nastanka dela: ");
//				
//				String dn = sc.nextLine();
//				
//				Calendar datNast = new GregorianCalendar();
//				try {
//					datNast.setTime((new SimpleDateFormat("dd.MM.yyyy.").parse(dn)));
//				} catch (ParseException e) {
//					// TODO Auto-generated catch block
//					e.printStackTrace();
//				}
//				System.out.println(datNast.getTime());
//				
//				System.out.println("Unesite mesto nastanka dela: ");
//				
//				String mestoNast = sc.nextLine();
//				
//				System.out.println("Unesite opis dela: ");
//				String opis = sc.nextLine();
//				
//				System.out.println("Unesite uri dela: ");
//				String uri = sc.nextLine();
//				
//				System.out.println("Unesite id dela: ");
//				String id1 = sc.nextLine();
//				
//				HashMap<String, Autor> autoriDela= new HashMap<String, Autor>();
//				
//				autoriDela.put(autor.getId(),autor);
//				Delo delo = new Delo(naslov,tehnika,stil,datNast,mestoNast,opis,uri,id1,autoriDela);
//				autor.dodajDelaAutora(delo);
//				
//				mapaDela.put(delo.getId(), new Delo(delo.getNaslov(),delo.getTehnika(),delo.getStil(),delo.getDatNast(),
//						delo.getMestoNast(),delo.getOpis(),delo.getUri(),delo.getId(),delo.getAutoriDela()));
//				
//			} while(odgDelo.equals("d"));
			

 
	}

     public void izmeniDelo(Delo delo2) throws InvalidIdException{
 		
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
 		
// 		Scanner sc= new Scanner(System.in);
// 		
// 		System.out.print("Unesite naslov dela: ");
// 		String naslov = sc.nextLine();
// 		System.out.print("ime autora: "+naslov);
// 		
// 		System.out.print("Unesite tehniku dela: ");
// 		String tehnika = sc.nextLine();
// 		
// 		System.out.println("Unesite stil dela: ");
// 		String stil = sc.nextLine();
// 		
// 		System.out.println("Unesite datum nastanka dela: ");
// 		
// 		String dr = sc.nextLine();
// 		
// 		Calendar datNast = new GregorianCalendar();
// 		try {
// 			datNast.setTime((new SimpleDateFormat("dd.MM.yyyy.").parse(dr)));
// 		} catch (ParseException e) {
// 			// TODO Auto-generated catch block
// 			e.printStackTrace();
// 		}
// 		System.out.println(datNast.getTime());
// 		
// 		System.out.println("Unesite mesto nastanka dela: ");
// 		
// 		String mestoNast = sc.nextLine();
// 		
// 		System.out.println("Unesite opis dela: ");
// 		String opis = sc.nextLine();
// 		
// 		System.out.println("Unesite uri dela: ");
// 		String uri = sc.nextLine();
// 		
// 		String odgAutor="";
// 		do{
// 			
// 			do{
// 				System.out.println("Da li zelite da unesete autora dela?[d/n]");
// 				odgAutor= sc.nextLine();
// 			}while(!(odgAutor.equals("d")|| odgAutor.equals("n")));
//
// 			if(odgAutor.equals("n"))
// 				break;
// 			
// 		
// 		System.out.print("Unesite ime autora: ");
// 		String ime = sc.nextLine();
// 		
// 		System.out.print("Unesite prezime autora: ");
// 		String prezime = sc.nextLine();
// 		
// 		System.out.println("Unesite mesto rodjenja autora: ");
// 		String mestoRodjenja = sc.nextLine();
// 		
// 		System.out.println("Unesite mesto smrti autora: ");
// 		String mestoSmrti = sc.nextLine();
// 		
// 		System.out.println("Unesite datum rodjenja autora: ");
// 		String dr1 = sc.nextLine();
// 		
// 		Calendar datRodjenja=new GregorianCalendar();
// 		try {
// 			datRodjenja.setTime((new SimpleDateFormat("dd.MM.yyyy.").parse(dr1)));
// 		} catch (ParseException e) {
// 			// TODO Auto-generated catch block
// 			e.printStackTrace();
// 		}
// 		System.out.println(datRodjenja.getTime());
// 		
// 		System.out.println("Unesite datum smrti autora: ");
// 		String ds = sc.nextLine();
// 		Calendar datSmrti= new GregorianCalendar();
// 		try {
// 			datSmrti.setTime((new SimpleDateFormat("dd.MM.yyyy.").parse(ds)));
// 		} catch (ParseException e) {
// 			// TODO Auto-generated catch block
// 			e.printStackTrace();
// 		}
// 		System.out.println(datSmrti.getTime());
// 		
// 	
// 		System.out.println("Unesite id autora: ");
// 		String id1 = sc.nextLine();
// 		String sth="";
// 		System.out.println("Unesite biografiju autora: ");
// 	//	while (!(sth= stdin.readLine()).equals("END")){
// 			String biografija = sc.nextLine();
// 		//	}
// 		
// 	    HashMap<String, Delo> delaAutora= new HashMap<String, Delo>();
// 		Autor autor = new Autor(ime,prezime,datRodjenja,datSmrti,mestoRodjenja,
// 					mestoSmrti,biografija,id1,delaAutora);
// 		delo.dodajAutoreDela(autor);
// 		
// 		mapaAutora.put(autor.getId(), new Autor(autor.getIme(),autor.getPrezime(),
// 				autor.getDatRodj(),autor.getDatSmrti()
// 				,autor.getMestoRodjenja(),autor.getMestoSmrti(),autor.getBio(),autor.getId(),autor.getDelaAutora()));
// 		} while(odgAutor.equals("d"));

		

 	}
     
	public void pregledAutora(){
		
		Iterator<String> iter;
		Set<String> keys = mapaAutora.keySet();
		iter= keys.iterator();
		int i=1;
		while (iter.hasNext()){
			String id = iter.next();
			Autor a= mapaAutora.get(id);
			System.out.println("autor"+i+":"+a.toString());
			i++;
		}
	}

	
	public Autor nadjiAutora(String id){
		
		Autor rez=null;
		
		if(mapaAutora.containsKey(id))
			rez=mapaAutora.get(id);
		
		return rez;
		
	}
	
	public Delo nadjiDelo(String id){
		Delo rez = null;
		
		if(mapaDela.containsKey(id))
			rez=mapaDela.get(id);
		
		return rez;
		
	}
	
	//pronalaženje autora na osnovu: imena i prezimena, stila u kom su nastala njegova dela u galeriji i
	//tehnike kojom su nastala njegova dela u galeriji
	
	
	public Vector<Autor> nadjiAutora2(String vrednost) throws InvalidIdException{
		
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
				
				rez.add(a);
				
			}
//			else{
//				
//				Iterator<String> iter1;
//				Set<String> keys1 = a.getDelaAutora().keySet();
//				iter1= keys1.iterator();
//				while (iter1.hasNext()){
//					String id1 = iter1.next();
//					Delo d= a.getDelaAutora().get(id1);
//					if(d.getStil().contains(vrednost) || d.getTehnika().contains(vrednost))
//					{	
//						rez=a;
//						break;
//					}
//					
//				}
//				String izuzetak="U galeriji ne postoji trazeni autor";
//				throw new InvalidIdException(izuzetak);
			}

		for(Autor a:rez)
		{
			System.out.println("a: "+a.getIme());
		}	
			
		return rez;
		
	}
		
	public Vector<Delo> nadjiDelo2(String vrednost) throws InvalidIdException{
		Vector<Delo> rez = new Vector<Delo>();
		

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
				rez.add(d);
				
			} 
//			else{
//					
//					Iterator<String> iter1;
//					Set<String> keys1 = mapaAutora.keySet();
//					iter1= keys1.iterator();
//					while (iter.hasNext()){
//						
//						String id1 = iter1.next();
//						Autor a= mapaAutora.get(id1);
//						if(a.getIme().contains(vrednost) || a.getPrezime().contains(vrednost))
//						{
//							rez=d;
//							break;
//						}
//					}
//				}
		
		
		}
		
		return rez;
		
	}
	
		
	public Vector<Delo> nadjiDeloTeh(String vrednost) throws InvalidIdException{
		
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

				rez.add(d);
				
			} 
		
		
		}
		
		return rez;
		
	}	
	
	public Vector<Delo> nadjiDeloPravac(String vrednost) throws InvalidIdException{
		
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

				rez.add(d);
				
			} 
		
		
		}
		
		return rez;
		
	}	

	public void brisiAutora(String id) throws InvalidIdException{
		if (!mapaAutora.containsKey(id))
		{
			String izuzetak="Ne postoji autor sa tom ID oznakom";
			
			throw new InvalidIdException(izuzetak);
		}
//		Iterator it = autori.keySet().iterator();
//		while(it.hasNext()) {	
//			Object key = it.next();
//			Autor a = autori.get(key);									
//			String id= a.getId();
//			if(id.equals(lozinka)){
//				 System.out.println("JEDNAKE_LOZINKE    id: "+id+"druga: "+lozinka);
//				ObjectOutputStream dat = new ObjectOutputStream(new FileOutputStream("autori.dat"));
//				try {
//					Galerija.getInstance().brisiAutora(id);
//					rez=true;
//					System.out.println("BRISI_rez=TRUE");
//				} catch (InvalidIdException e) {
//					// TODO Auto-generated catch block
//					e.printStackTrace();
//				}			
//			    Galerija.getInstance().saveAutori(dat);
//			    dat.close();
//		}
//			
//		}
			Autor aut= mapaAutora.get(id);
			mapaAutora.remove(id);
		
		
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
