package servleti;

import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.net.InetAddress;
import java.net.Socket;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.Iterator;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import beans.Autor;
import beans.Delo;
import beans.Poruka;

/**
 * Servlet implementation class AutoriDelaServlet
 */
public class AutoriDelaServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
	 public static final int TCP_PORT = 9000;
	  String hostname = "localhost";
	  


	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		 // odredi adresu racunara sa kojim se povezujemo
		  InetAddress addr = InetAddress.getByName(hostname);

		  // otvori socket prema drugom racunaru
		  Socket sock = new Socket(addr, TCP_PORT);

		  // inicijalizuj izlazni stream		!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
		 ObjectOutputStream out= new ObjectOutputStream(sock.getOutputStream());
		 
		 
		  // inicijalizuj ulazni stream
		 ObjectInputStream in= new ObjectInputStream(sock.getInputStream());

		 
		 
		 
//DODAVANJE...................................................................................................................
		 
		 String lozinkaDodaj= request.getParameter("dodajLoz");

			if(lozinkaDodaj!=null){
				  Poruka poruka = new Poruka();
				  poruka.setKomanda("NADJI_DELO");
				  poruka.setObjekat1(lozinkaDodaj);
				  poruka.setObjekat2(null);
				

		System.out.println("DODAJ LOZ:"+lozinkaDodaj);
				  
				  out.writeObject(poruka);
				  
				  // procitaj odgovor
				  
					try {
						Delo odg= (Delo)in.readObject();
						//	System.out.println("ODG:"+ odg.getIme());
							request.setAttribute("delo2", odg);
							in.close();	
						    out.close();  
						    sock.close();
						    
					    RequestDispatcher disp = request.getRequestDispatcher("/DodavanjeAutoraDela.jsp");							
						disp.forward(request, response);
						return;
					
					} catch (ClassNotFoundException e) {
						// TODO Auto-generated catch block
						e.printStackTrace();
					}
				}
		 
//PREGLED POSETIOCI...............................................................................................

			 String lozinkaPosPregled= request.getParameter("pregledPosLoz");
			 
		  // posalji zahtev
			 if(lozinkaPosPregled!=null){
				 
		  Poruka poruka = new Poruka();
		  poruka.setKomanda("PREGLED_AUTORA_DELA");
		  poruka.setObjekat1(lozinkaPosPregled);
		  poruka.setObjekat2(null);
		
System.out.println("dela SERVLET_KOMANDA_PREGLED AUTORA DELA: "+poruka.getKomanda());	
		  
		  out.writeObject(poruka);
		  
		  // procitaj odgovor
		  
			try {
				HashMap<String, Autor> odg= (HashMap<String, Autor>)in.readObject();
				
				ArrayList<Autor> autori= new ArrayList<Autor>(odg.values());
				Iterator it = odg.keySet().iterator();
				
//				while(it.hasNext()) {	
//					Object key = it.next();
//					Delo a = odg.get(key);	
//					System.out.println("IZ_DATOTEKE__IME D AU: "+a.getNaslov());
//				}
						
				request.setAttribute("autori",autori);
				in.close();	
			    out.close();  
			    sock.close();
			    RequestDispatcher disp = request.getRequestDispatcher("/PregledAutora.jsp");							
				disp.forward(request, response);	
				return;
			
			} catch (ClassNotFoundException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
			 }	
			//PREGLED...............................................................................................

			 String lozinkaPregled= request.getParameter("pregledLoz");
			 
		  // posalji zahtev
			 if(lozinkaPregled!=null){
				 
		  Poruka poruka = new Poruka();
		  poruka.setKomanda("PREGLED_AUTORA_DELA");
		  poruka.setObjekat1(lozinkaPregled);
		  poruka.setObjekat2(null);
		
System.out.println("dela SERVLET_KOMANDA_PREGLED AUTORA DELA: "+poruka.getKomanda());	
		  
		  out.writeObject(poruka);
		  
		  // procitaj odgovor
		  
			try {
				HashMap<String, Autor> odg= (HashMap<String, Autor>)in.readObject();
				
				ArrayList<Autor> autori= new ArrayList<Autor>(odg.values());
				Iterator it = odg.keySet().iterator();
				
//				while(it.hasNext()) {	
//					Object key = it.next();
//					Delo a = odg.get(key);	
//					System.out.println("IZ_DATOTEKE__IME D AU: "+a.getNaslov());
//				}
						
				request.setAttribute("autori",autori);
				in.close();	
			    out.close();  
			    sock.close();
			    RequestDispatcher disp = request.getRequestDispatcher("/AutoriIzmBris.jsp");							
				disp.forward(request, response);	
				return;
			
			} catch (ClassNotFoundException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
			 }			
		  //String list = "";
		  //List o = (List)in.readObject();
		  
//	  request.getSession().setAttribute("lista", o);
//	  if (o.getTekst().equals("OK"))
	}


	protected void doPost(HttpServletRequest request,
			HttpServletResponse response) throws ServletException, IOException {
		doGet(request, response);
	}
}
