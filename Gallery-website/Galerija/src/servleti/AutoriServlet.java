package servleti;

import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.net.InetAddress;
import java.net.Socket;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.Iterator;
import java.util.Vector;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;



import beans.Autor;
import beans.Kustos;
import beans.Poruka;

/**
 * Servlet implementation class AutoriServlet
 */
public class AutoriServlet extends HttpServlet {
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

		 
		 
		 
//IZMENA...................................................................................................................
		 
		 String lozinkaIzm= request.getParameter("izmLoz");
			
			if(lozinkaIzm!=null){
			
				  Poruka poruka = new Poruka();
				  poruka.setKomanda("NADJI_AUTORA");
				  poruka.setObjekat1(lozinkaIzm);
				  poruka.setObjekat2(null);
				
		System.out.println("AUTORI SERVLET_KOMANDA_IZMENA: "+poruka.getKomanda());	
				  
				  out.writeObject(poruka);
				  
				  // procitaj odgovor
				  
					try {
						Autor odg= (Autor)in.readObject();
						//	System.out.println("ODG:"+ odg.getIme());
							request.setAttribute("autor2", odg);
							in.close();	
						    out.close();  
						    sock.close();
						
							 RequestDispatcher disp = request.getRequestDispatcher("/IzmenaAutora.jsp");							
							 disp.forward(request, response);
							 return;					

					
					} catch (ClassNotFoundException e) {
						// TODO Auto-generated catch block
						e.printStackTrace();
					}
				}
		 
		 
//BRISANJE...................................................................................................................
		 String lozinka= request.getParameter("brisiLoz");
			
			if(lozinka!=null){
			
				  Poruka poruka = new Poruka();
				  poruka.setKomanda("BRISI_AUTORA");
				  poruka.setObjekat1(lozinka);
				  poruka.setObjekat2(null);
				
		System.out.println("AUTORI SERVLET_KOMANDA_BRISANJE: "+poruka.getKomanda());	
				  
				  out.writeObject(poruka);
				  
				  // procitaj odgovor
				  
					try {
						boolean odg= (Boolean)in.readObject();
						System.out.println("ODG_BRISI: "+odg);
						in.close();	
					    out.close();  
					    sock.close();
					    request.getSession().setAttribute("odg", odg);
						response.sendRedirect("/Galerija/ObrisanAutor.jsp");
						return;
					
					} catch (ClassNotFoundException e) {
						// TODO Auto-generated catch block
						e.printStackTrace();
					}
				}



		  // posalji zahtev
		  
		  Poruka poruka = new Poruka();
		  poruka.setKomanda("PREGLED_AUTORA");
		  poruka.setObjekat1(null);
		  poruka.setObjekat2(null);
		
System.out.println("AUTORI SERVLET_KOMANDA_PREGLED: "+poruka.getKomanda());	
		  
		  out.writeObject(poruka);
		  
		  // procitaj odgovor
		  
			try {
				HashMap<String, Autor> odg= (HashMap<String, Autor>)in.readObject();
				
				ArrayList<Autor> autori= new ArrayList<Autor>(odg.values());
				Iterator it = odg.keySet().iterator();
				while(it.hasNext()) {	
					Object key = it.next();
					Autor a = odg.get(key);	
					System.out.println("IZ_DATOTEKE_ZA PREGLED BIO: "+a.getBio());
				}
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
