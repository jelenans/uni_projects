package server;
import java.io.*;
import java.net.*;
import java.util.*;

import javax.security.auth.login.LoginContext;

import beans.Autor;
import beans.Delo;
import beans.Galerija;
import beans.InvalidIdException;
import beans.Kustos;
import beans.MultimedijalniZapis;
import beans.Poruka;
import beans.Skulptura;
import beans.Slika;

public class UServerThread extends Thread {

	 String request;
	
  public UServerThread(Socket sock, Vector<Kustos> kustosi) {
    this.sock = sock;
    this.kustosi=kustosi;
    
//    for(int i=0;i<kustosi.size();i++)
//    {
//    	Kustos kk= (Kustos)kustosi.get(i);
//    	System.out.println("kustos_ime: "+kk.getIme());
//    	if(!kk.isLogged())
//    	  System.out.println("kustos_LOG: NIJE");
//    }
    
   
    try {
      // inicijalizuj ulazni stream
    	 System.out.println("IN");
        in = new ObjectInputStream(sock.getInputStream());
        System.out.println(" IN2");
     // inicijalizuj izlazni stream
        System.out.println(" OUT");
        out = new ObjectOutputStream(sock.getOutputStream());
        System.out.println(" OUT2");
       
      // pokreni thread
      start();
      
    } catch (Exception ex) {
      ex.printStackTrace();
    }
  }

  public void run() {
   boolean response=false;
    try {
 
      poruka= (Poruka)in.readObject();
     
      request= poruka.getKomanda();
      
      System.out.println("request: "+request);
      
      if(request.equals("NADJI_AUTORA")){
    	  System.out.println(request);
    	  Autor response2= nadji(); 
    	// posalji odgovor
    	  out.writeObject(response2);
      }
      if(request.equals("NADJI_DELO")){
    	  System.out.println(request);
    	  Delo response2= nadjiDelo(); 
    	// posalji odgovor
    	  out.writeObject(response2);
      }
 
      if(request.equals("NADJI_AUTORA2")){
    	  System.out.println(request);
    	  Vector<Autor> response2= nadji2(); 
    	// posalji odgovor
    	  out.writeObject(response2);
      }
      
      if(request.equals("NADJI_AUTORA_TEHNIKA")){
    	  System.out.println(request);
    	  Vector<Autor> response2= nadjiAutoraTeh(); 
    	// posalji odgovor
    	  out.writeObject(response2);
      }
      if(request.equals("NADJI_AUTORA_PRAVAC")){
    	  System.out.println(request);
    	  Vector<Autor> response2= nadjiAutoraPravac(); 
    	// posalji odgovor
    	  out.writeObject(response2);
      }
      if(request.equals("NADJI_DELO2")){
    	  System.out.println(request);
    	  HashMap<String, Delo> response2= nadjiDelo2(); 
    	// posalji odgovor
    	  out.writeObject(response2);
      }
      if(request.equals("NADJI_DELO_TEHNIKA")){
    	  System.out.println(request);
    	  Vector<Delo> response2= nadjiDeloTeh(); 
    	// posalji odgovor
    	  out.writeObject(response2);
      }
      if(request.equals("NADJI_DELO_PRAVAC")){
    	  System.out.println(request);
    	  Vector<Delo> response2= nadjiDeloPravac(); 
    	// posalji odgovor
    	  out.writeObject(response2);
      }
      if(request.equals("NADJI_DELO_AUTOR")){
    	  System.out.println(request);
    	  Vector<Delo> response2= nadjiDeloAutor(); 
    	// posalji odgovor
    	  out.writeObject(response2);
      }
      if (request.equals("LOGIN")){
    	  response=LoginKustos();
          out.writeObject(response);
      }
      if (request.equals("DODAJ_AUTORA")){
    	  Autor resp=null;
    	  resp=dodajAutora();
    	//  System.out.print("respDodaj:"+resp.getBio());
          out.writeObject(resp);
      }
      if (request.equals("DODAJ_DELO")){
    	  Delo resp=null;
    	  resp=dodajDelo();
    	  System.out.println("respDodaj:"+resp.getNaslov());
          out.writeObject(resp);
      }
      if (request.equals("DODAJ_DELO_AUTORA")){
    	  Delo resp=null;
    	  resp=dodajDeloAutora();
    	  System.out.println("respDodaj delo autora:"+resp.getNaslov());
          out.writeObject(resp);
      }
      if (request.equals("DODAJ_AUTORA_DELA")){
    	  Autor resp=null;
    	  resp=dodajAutoraDela();
    	  System.out.print("respDodaj AUTORA DELA:"+resp.getIme());
          out.writeObject(resp);
      }
      if (request.equals("PREGLED_AUTORA")){
    	  HashMap<String,Autor> resp=null;
    	  System.out.println(""+request);
    	  resp=listaAutora();
    	  System.out.println("LISTA_AUTORA");
    	  Iterator it = resp.keySet().iterator();
			while(it.hasNext()) {	
				Object key = it.next();
				Autor a = resp.get(key);	
				System.out.println("REZ_FJE__IME A: "+a.getIme());
			}
    	 
          out.writeObject(resp);
      }
      if (request.equals("PREGLED_DELA")){
    	  HashMap<String,Delo> resp=null;
    	  System.out.println("PREGLED? "+request);
    	  resp=listaDela();
    	  System.out.println("LISTA_DELA");
    	  Iterator it = resp.keySet().iterator();
			while(it.hasNext()) {	
				Object key = it.next();
				Delo d = resp.get(key);	
				System.out.println("delo: "+d.getNaslov());
			}
    	 
          out.writeObject(resp);
      }
      if (request.equals("PREGLED_DELA_AUTORA")){
    	  HashMap<String,Delo> resp=null;
    	  System.out.println("PREGLED_dela_aut "+request);
    	  resp=listaDelaAutora();
    	  Iterator it = resp.keySet().iterator();
			while(it.hasNext()) {	
				Object key = it.next();
				Delo d = resp.get(key);	
				System.out.println("delo: "+d.getNaslov());
			}
    	 
          out.writeObject(resp);
      }
      if (request.equals("PREGLED_AUTORA_DELA")){
    	  HashMap<String,Autor> resp=null;
    	  System.out.println(""+request);
    	  resp=listaAutoraDela();
    	  System.out.println("LISTA_AUTORA");
    	  Iterator it = resp.keySet().iterator();
			while(it.hasNext()) {	
				Object key = it.next();
				Autor a = resp.get(key);	
				System.out.println("REZ_FJE__IME A: "+a.getIme());
			}
    	 
          out.writeObject(resp);
      }
      if (request.equals("BRISI_AUTORA")){
    	  System.out.println(""+request);
    	 boolean resp;
    	  resp=brisiAutora();
    	  if(resp==true)
    	  System.out.println("brisi_odg: "+resp);
          out.writeObject(resp);
      }
      
      if (request.equals("BRISI_DELO")){
    	  System.out.println(""+request);
    	 boolean resp;
    	  resp=brisiDelo();
    	  if(resp==true)
    	  System.out.println("brisiDELO_odg: "+resp);
          out.writeObject(resp);
      }
      
      if (request.equals("IZMENI_AUTORA")){
    	  Autor resp=null;
    	  resp=izmeniAutora();
    	 // System.out.println("respDodaj:"+resp.getIme());
          out.writeObject(resp);
      }
      if (request.equals("IZMENI_DELO")){
    	  Delo resp=null;
    	  resp=izmeniDelo();
    	 // System.out.println("respDodaj:"+resp.getIme());
          out.writeObject(resp);
      }
      // zatvori konekciju
      in.close();
      out.close();
      sock.close();
    } catch (Exception ex) {
      ex.printStackTrace();
    }
  }

private boolean LoginKustos() {
	  boolean rez=false;
	  
		
			 Kustos k= (Kustos)poruka.getObjekat1();
			// System.out.println("A0: "+k.getIme());	
			synchronized (kustosi) {
				
					 for(Kustos kk:kustosi) {
						 String ime= kk.getIme();
						 String loz= kk.getLozinka();
					//	 System.out.println("AAAA: "+kk.getIme());	      					      
					if(ime.equals(k.getIme()) && loz.equals(k.getLozinka()))
					{
					//	System.out.println("JESTE");
					//	System.out.println("A2: "+kk.getIme());
						rez= true;
						break;	 
					}			
				  
				}		 
			}
//		if(rez==false)
//			System.out.println("rez:NE");
//		else {
//			System.out.println("DA");
//		}
	
   return rez;

}
  
  private Autor nadji() {
		Autor rez=null;
		String lozinka = (String)poruka.getObjekat1();
		HashMap<String, Autor> autori= Galerija.getInstance().getMapaAutora();
		
				
			rez= Galerija.getInstance().nadjiAutora(lozinka);
			//System.out.println("nadjen: " +rez.getIme());
			
		
		return rez;
	}
  
 private Delo nadjiDelo() {
	  Delo rez=null;
		String lozinka = (String)poruka.getObjekat1();
		HashMap<String,Delo> dela= Galerija.getInstance().getMapaDela();
			
				
			rez= Galerija.getInstance().nadjiDelo(lozinka);
			//System.out.println("nadjen: " +rez.getIme());
			
		
		return rez;
	}
  
private Vector<Autor> nadji2() {
	  Vector<Autor> rez=null;
		String vrednost = (String)poruka.getObjekat1();
		System.out.println("nadji2_VREDNOST: "+vrednost);
		
		HashMap<String, Autor> autori= Galerija.getInstance().getMapaAutora();
			
				
			try {
				System.out.println("nadji2_try");
				rez= Galerija.getInstance().nadjiAutora2(vrednost);
			} catch (InvalidIdException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
			//System.out.println("nadjen: " +rez.getIme());
		
		
		return rez;
}

private HashMap<String, Delo> nadjiDelo2() {
	HashMap<String, Delo> rez=null;
			String vrednost = (String)poruka.getObjekat1();
			System.out.println("nadji2_VREDNOST: "+vrednost);
			
			HashMap<String,Delo> dela= Galerija.getInstance().getMapaDela();
			
			
					
				try {
					System.out.println("nadjiDelo2_try");
					rez= Galerija.getInstance().nadjiDelo2(vrednost);
				} catch (InvalidIdException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
				//System.out.println("nadjen: " +rez.getIme());
				
			
			return rez;
}

private Vector<Delo> nadjiDeloTeh() {
	  Vector<Delo> rez=null;
		String vrednost = (String)poruka.getObjekat1();
		System.out.println("nadjiTEH_VREDNOST: "+vrednost);


				
			try {
				System.out.println("nadjiDeloTEH_try");
				rez= Galerija.getInstance().nadjiDeloTeh(vrednost);
			} catch (InvalidIdException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
			//System.out.println("nadjen: " +rez.getIme());
			
		
		return rez;
}

private Vector<Delo> nadjiDeloPravac() {
	  Vector<Delo> rez=null;
			String vrednost = (String)poruka.getObjekat1();
			System.out.println("nadjiPRAVAC_VREDNOST: "+vrednost);
		
					
				try {
					System.out.println("nadjiDeloPRAVAC_try");
					rez= Galerija.getInstance().nadjiDeloPravac(vrednost);
				} catch (InvalidIdException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
				//System.out.println("nadjen: " +rez.getIme());
				
			
			return rez;
}

private Vector<Delo> nadjiDeloAutor() {
	 Vector<Delo> rez=null;
		String imea = (String)poruka.getObjekat1();
		String prza = (String)poruka.getObjekat2();
	//	System.out.println("nadjiDELO-AUTOR: "+vrednost);



				
			try {
				System.out.println("nadjiDeloAUTOR_try");
				rez= Galerija.getInstance().nadjiDeloAutor(imea,prza);
			} catch (InvalidIdException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
			//System.out.println("nadjen: " +rez.getIme());
	
		
		return rez;
}

private Vector<Autor> nadjiAutoraTeh() {
	  Vector<Autor> rez=null;
			String vrednost = (String)poruka.getObjekat1();
			System.out.println("nadji A TEH_VREDNOST: "+vrednost);
			HashMap<String, Autor> autori= Galerija.getInstance().getMapaAutora();
			HashMap<String,Delo> dela= Galerija.getInstance().getMapaDela();
			


					
				try {
					System.out.println("nadji autTEH_try");
					rez= Galerija.getInstance().nadjiAutoraTeh(vrednost);
				} catch (InvalidIdException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
				//System.out.println("nadjen: " +rez.getIme());
		
			return rez;
}

private Vector<Autor> nadjiAutoraPravac() {
	  Vector<Autor> rez=null;
			String vrednost = (String)poruka.getObjekat1();
			System.out.println("nadji A PRAV_VREDNOST: "+vrednost);
			


					
				try {
					System.out.println("nadji autora prav_try");
					rez= Galerija.getInstance().nadjiAutoraPravac(vrednost);
				} catch (InvalidIdException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
				//System.out.println("nadjen: " +rez.getIme());
			
			
			return rez;
}

private Autor dodajAutora() {
	 
	 // System.out.println("A:IME"+ autor.getIme());
		Autor rez=null;
		Autor autor = (Autor)poruka.getObjekat1();
	
	  try {
     			ObjectOutputStream dat;			 
				dat = new ObjectOutputStream(new FileOutputStream("autori.dat"));
				
//					
				try {
					Galerija.getInstance().dodajAutora(autor);
				} catch (InvalidIdException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}				
			    Galerija.getInstance().saveAutori(dat);
			    dat.close();
			    rez=autor;	
					    
			} catch (FileNotFoundException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			} catch (IOException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
				

	return rez;
}

private Delo dodajDelo() {

	System.out.println("FJA DODAVANJE DELA");

		Delo rez=null;
		
		String vrsta= (String)poruka.getObjekat2();		
		System.out.println("vrsta: "+vrsta);

		
	  try {
    			ObjectOutputStream dat;			 
				dat = new ObjectOutputStream(new FileOutputStream("dela.dat"));
				
//					
				try {
					if(vrsta.equals("slika"))
					{
						System.out.println("SLIKA ");
						Slika delo = (Slika)poruka.getObjekat1();
						System.out.println("naziv: "+delo.getNaslov());
						Galerija.getInstance().dodajSliku(delo);
					    rez=delo;
					}
					if(vrsta.equals("skulptura"))
					{
						System.out.println("SKULPT ");
						Skulptura delo = (Skulptura)poruka.getObjekat1();
						Galerija.getInstance().dodajSkulpturu(delo);
					    rez=delo;
					}
					if(vrsta.equals("multimedija"))
					{
						System.out.println("MULTIM ");
						MultimedijalniZapis delo = (MultimedijalniZapis)poruka.getObjekat1();
						System.out.println("deloooMulti: "+delo.getNaslov());
						Galerija.getInstance().dodajMulti(delo);
					    rez=delo;
					}


				} catch (InvalidIdException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}				
			    Galerija.getInstance().saveDela(dat);
			    dat.close();
						    
			} catch (FileNotFoundException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			} catch (IOException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
 
 //   System.out.println("reeezDELo_DODATO: "+rez.getNaslov());
    
	return rez;
}

private Delo dodajDeloAutora() {
	System.out.println("FJA DODAVANJE DELA AUTORA");

	Delo rez=null;
	Delo delo = (Delo)poruka.getObjekat1();
	String autorID= (String)poruka.getObjekat2();
//	System.out.println("delo: "+delo.getNaslov());
//	System.out.println("autor ID: "+autorID);


	
  try {
			ObjectOutputStream dat;			 
			dat = new ObjectOutputStream(new FileOutputStream("dela.dat"));
			
//				
			try {
			
					
					Galerija.getInstance().dodajDelaAutora(autorID, delo);
				    rez=delo;


			} catch (InvalidIdException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}				
		    Galerija.getInstance().saveDela(dat);
		    dat.close();
					    
		} catch (FileNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

return rez;
}

private Autor dodajAutoraDela() {
	Autor rez=null;
	Autor autor = (Autor)poruka.getObjekat1();
	String deloID= (String)poruka.getObjekat2();
	System.out.println("AU_DELA: "+autor.getIme());
	System.out.println("DELO ID: "+deloID);


	
  try {
			ObjectOutputStream dat;	
			ObjectOutputStream dat2;			 
			dat = new ObjectOutputStream(new FileOutputStream("autori.dat"));
			dat2 = new ObjectOutputStream(new FileOutputStream("dela.dat"));


//				
			try {
				System.out.println("del0 autora _fja TRY ");
				
				Galerija.getInstance().dodajAutoraDela(deloID,autor);
				
			} catch (InvalidIdException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}				
		    Galerija.getInstance().saveAutori(dat);
		    Galerija.getInstance().saveDela(dat2);
		    dat.close();
		    dat2.close();
		    
		    rez=autor;	


		} catch (FileNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

System.out.println("reeez_autor_dela_DODATO: "+rez.getIme());

return rez;
}

private Autor izmeniAutora() {
	  Autor rez=null;

     
  	try {
  		Autor autor = (Autor)poruka.getObjekat1();

	
	try {
		
		Galerija.getInstance().izmeniAutora(autor);
		rez=autor;
		System.out.println("RET_IZM: "+rez.getIme());
		
		} catch (InvalidIdException e) {
							// TODO Auto-generated catch block
			e.printStackTrace();
		}
			
			 ObjectOutputStream dat = new ObjectOutputStream(new FileOutputStream("autori.dat"));	
			 ObjectOutputStream dat2 = new ObjectOutputStream(new FileOutputStream("dela.dat"));	
			 Galerija.getInstance().saveAutori(dat);
			 Galerija.getInstance().saveDela(dat2);
			 dat.close();	
			 dat2.close();			
		
			
	} catch (FileNotFoundException e) {
		
		e.printStackTrace();
	} catch (IOException e) {
		
		e.printStackTrace();
	}
      return rez;
}

private Delo izmeniDelo() {
	
	 Delo rez=null;

  
				
	try {
 		String vrsta= (String)poruka.getObjekat2();
 		System.out.println("vrsta IZMENI: "+vrsta);
 		if(vrsta.equals("slika"))
		{
			System.out.println("SLIKA IZMENI ");
			Slika delo = (Slika)poruka.getObjekat1();
			try {
				Galerija.getInstance().izmeniDelo(delo);
			} catch (InvalidIdException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		    rez=delo;
		}
		if(vrsta.equals("skulptura"))
		{
			System.out.println("SKULPT ");
			Skulptura delo = (Skulptura)poruka.getObjekat1();
			try {
				Galerija.getInstance().izmeniDelo(delo);
			} catch (InvalidIdException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		    rez=delo;
		}
		if(vrsta.equals("multimedija"))
		{
			System.out.println("MULTIM ");
			MultimedijalniZapis delo = (MultimedijalniZapis)poruka.getObjekat1();
			try {
				Galerija.getInstance().izmeniDelo(delo);
			} catch (InvalidIdException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		    rez=delo;
		}
	
				
			 ObjectOutputStream dat = new ObjectOutputStream(new FileOutputStream("dela.dat"));	
			 ObjectOutputStream dat2 = new ObjectOutputStream(new FileOutputStream("autori.dat"));	
			 Galerija.getInstance().saveDela(dat);
			 Galerija.getInstance().saveAutori(dat2);
			 dat.close();		
			 dat2.close();
			
	} catch (FileNotFoundException e) {
		
		e.printStackTrace();
	} catch (IOException e) {
		
		e.printStackTrace();
	}
	
     return rez;
}

private boolean brisiAutora() {
	  
	  
	  boolean rez=false;
	  String lozinka = (String)poruka.getObjekat1();

  
	  	try {
				ObjectOutputStream dat = new ObjectOutputStream(new FileOutputStream("autori.dat"));
				ObjectOutputStream dat2 = new ObjectOutputStream(new FileOutputStream("dela.dat"));


				try {
					Galerija.getInstance().brisiAutora(lozinka);
					rez=true;
					System.out.println("BRISI_rez=TRUE");
				} catch (InvalidIdException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}			
			    Galerija.getInstance().saveAutori(dat);
			    Galerija.getInstance().saveDela(dat2);
			    dat.close();
			    dat2.close();
							
			
				
		} catch (FileNotFoundException e) {
			
			e.printStackTrace();
		} catch (IOException e) {
			
			e.printStackTrace();
		}

	return rez;
}

private boolean brisiDelo() {
	 
	  boolean rez=false;
	  String lozinka = (String)poruka.getObjekat1();


	  
	  	try {
				ObjectOutputStream dat = new ObjectOutputStream(new FileOutputStream("dela.dat"));
				ObjectOutputStream dat2 = new ObjectOutputStream(new FileOutputStream("autori.dat"));


				try {
					Galerija.getInstance().brisiDelo(lozinka);
					rez=true;
					System.out.println("BRISI_DELO_rez=TRUE");
				} catch (InvalidIdException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}			
			    Galerija.getInstance().saveDela(dat);
			    Galerija.getInstance().saveAutori(dat2);
			    dat.close();
			    dat2.close();

			
			
				
		} catch (FileNotFoundException e) {
			
			e.printStackTrace();
		} catch (IOException e) {
			
			e.printStackTrace();
		}

	return rez;
}

private HashMap<String, Autor> listaAutora() {
	  
	  HashMap<String, Autor> autori= Galerija.getInstance().getMapaAutora();
	  
	 
//			Iterator it = autori.keySet().iterator();
//			while(it.hasNext()) {	
//				Object key = it.next();
//				Autor a = autori.get(key);	
//				System.out.println("IZ_DATOTEKE__IME A: "+a.getIme());
//			}
			
	
	return autori;
}

private HashMap<String, Delo> listaDela() {
	
	  HashMap<String, Delo> dela= Galerija.getInstance().getMapaDela();
	  
		 
//		Iterator it = dela.keySet().iterator();
//		while(it.hasNext()) {	
//			Object key = it.next();
//			Delo a = dela.get(key);	
//			System.out.println("IZ_DATOTEKE__NASLOV DELA: "+a.getNaslov());
//		}
		
	
return dela;
}

private HashMap<String, Delo> listaDelaAutora() {
	 
	String lozinka = (String)poruka.getObjekat1();
	Autor autor= Galerija.getInstance().nadjiAutora(lozinka);
	
	HashMap<String, Delo> dela= autor.getDelaAutora();
//	
//	Iterator it = dela.keySet().iterator();
//	while(it.hasNext()) {	
//		Object key = it.next();
//		Delo a = dela.get(key);	
//		System.out.println("IZ_DATOTEKE__NASLOV DELA AUTORA: "+a.getNaslov());
//	}
	
return dela;
}


private HashMap<String, Autor> listaAutoraDela() {
	String lozinka = (String)poruka.getObjekat1();
	Delo d= Galerija.getInstance().nadjiDelo(lozinka);
	
	HashMap<String, Autor> autori= d.getAutoriDela();
	
//	Iterator it = dela.keySet().iterator();
//	while(it.hasNext()) {	
//		Object key = it.next();
//		Delo a = dela.get(key);	
//		System.out.println("IZ_DATOTEKE__NASLOV DELA AUTORA: "+a.getNaslov());
//	}
	
 return autori;
}




  private Socket sock;
  private ObjectInputStream in;
  private ObjectOutputStream out;
  private Vector<Kustos> kustosi;
  
  private Poruka poruka;

}
