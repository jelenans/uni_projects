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
import beans.MultimedijalniZapis;
import beans.Poruka;
import beans.Skulptura;
import beans.Slika;

/**
 * Servlet implementation class DelaServlet
 */
public class DelaServlet extends HttpServlet {
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
				  poruka.setKomanda("NADJI_DELO");
				  poruka.setObjekat1(lozinkaIzm);
				  poruka.setObjekat2(null);
				
		System.out.println("DELO SERVLET_KOMANDA_IZMENA: "+poruka.getKomanda());	
				  
				  out.writeObject(poruka);
				  
				  // procitaj odgovor
				  
					try {
						Delo d= (Delo)in.readObject();
						//	System.out.println("ODG:"+ odg.getIme());
						
					
			
							if(d instanceof Slika){
								Slika s= (Slika)d;
								request.setAttribute("delo2", d);
								
							    RequestDispatcher disp = request.getRequestDispatcher("/IzmenaDelaSlika.jsp");							
								disp.forward(request, response);			    
							return;
							}else if(d instanceof Skulptura)
							{
								Skulptura s=(Skulptura)d;
								request.setAttribute("delo2", d);
								
							    RequestDispatcher disp = request.getRequestDispatcher("/IzmenaDelaSkulptura.jsp");							
								disp.forward(request, response);			    
							return;
							}else if(d instanceof MultimedijalniZapis)
							{
								MultimedijalniZapis m=(MultimedijalniZapis)d;
								request.setAttribute("delo2", d);
								
							    RequestDispatcher disp = request.getRequestDispatcher("/IzmenaDelaMulti.jsp");							
								disp.forward(request, response);			    
							return;
							}
						
						




						
						
							
							in.close();	
						    out.close();  
						    sock.close();
					
						
					
					} catch (ClassNotFoundException e) {
						// TODO Auto-generated catch block
						e.printStackTrace();
					}
				}
		 
		 
//BRISANJE...................................................................................................................
		 String lozinka= request.getParameter("brisiLoz");
			
			if(lozinka!=null){
			
				  Poruka poruka = new Poruka();
				  poruka.setKomanda("BRISI_DELO");
				  poruka.setObjekat1(lozinka);
				  poruka.setObjekat2(null);
				
		System.out.println("DELA SERVLET_KOMANDA_BRISANJE: "+poruka.getKomanda());	
				  
				  out.writeObject(poruka);
				  
				  // procitaj odgovor
				  
					try {
						boolean odg= (Boolean)in.readObject();
						System.out.println("ODG_BRISI: "+odg);
						in.close();	
					    out.close();  
					    sock.close();
					    request.setAttribute("odg", odg);
					    

					    RequestDispatcher disp = request.getRequestDispatcher("/ObrisanoDelo.jsp");							
						disp.forward(request, response);						    
						return;
					
					} catch (ClassNotFoundException e) {
						// TODO Auto-generated catch block
						e.printStackTrace();
					}
				}



		  // posalji zahtev
		  
		  Poruka poruka = new Poruka();
		  poruka.setKomanda("PREGLED_DELA");
		  poruka.setObjekat1(null);
		  poruka.setObjekat2(null);
		
System.out.println("dela SERVLET_KOMANDA_PREGLED: "+poruka.getKomanda());	
		  
		  out.writeObject(poruka);
		  
		  // procitaj odgovor
		  
			try {
				HashMap<String, Delo> odg= (HashMap<String, Delo>)in.readObject();
				
			//	ArrayList<Delo> dela= new ArrayList<Delo>(odg.values());
	
				ArrayList<Slika> slike=new ArrayList<>();
				ArrayList<Skulptura> skulpture= new ArrayList<>();
				ArrayList<MultimedijalniZapis> multi= new ArrayList<>();
				
				Iterator it = odg.keySet().iterator();
				while(it.hasNext()) {	
					Object key = it.next();
					Delo d = odg.get(key);
					if(d instanceof Slika){
						Slika s= (Slika)d;
						slike.add(s);
					}else if(d instanceof Skulptura)
					{
						Skulptura s=(Skulptura)d;
						skulpture.add(s);
					}else if(d instanceof MultimedijalniZapis)
					{
						MultimedijalniZapis m=(MultimedijalniZapis)d;
						multi.add(m);
					}
				}
				




				
				request.setAttribute("slike",slike);
				request.setAttribute("skulpture",skulpture);
				request.setAttribute("multi",multi);
				in.close();	
			    out.close();  
			    sock.close();
			    RequestDispatcher disp = request.getRequestDispatcher("/DelaIzmBris.jsp");							
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
