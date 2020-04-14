package servleti;

import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.net.InetAddress;
import java.net.Socket;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.GregorianCalendar;
import java.util.HashMap;
import java.util.Vector;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;



import beans.Autor;
import beans.Delo;
import beans.Poruka;


/**
 * Servlet implementation class IzmenaAutoraServlet
 */
public class IzmenaAutoraServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
	
	  public static final int TCP_PORT = 9000;
	  String hostname = "localhost";

   
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
		
	
		 String ime= request.getParameter("ime");
		 String prezime=request.getParameter("prezime");
		 Calendar datRodjenja=new GregorianCalendar();
		 
				try {
					datRodjenja.setTime((new SimpleDateFormat("mm-dd-yyyy").parse(request.getParameter("datumRodjenja"))));
				} catch (java.text.ParseException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
		
		 
		 Calendar datSmrti=new GregorianCalendar();
		 
				try {
					datSmrti.setTime((new SimpleDateFormat("mm-dd-yyyy").parse(request.getParameter("datumSmrti"))));
				} catch (java.text.ParseException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
			
		 String mestoRodjenja=request.getParameter("mestoRodjenja");
		 String mestoSmrti=request.getParameter("mestoSmrti");
		 String bio=request.getParameter("bio");
		 String id=request.getParameter("id");
		 
		 HashMap<String, Delo> delaAutora= new HashMap<String, Delo>();
		 
		 Autor autor= new Autor(ime, prezime, datRodjenja, datSmrti, mestoRodjenja, mestoSmrti, bio, id, delaAutora);
		 
		 System.out.println("ime:"+autor.getId());
		 
		 // odredi adresu racunara sa kojim se povezujemo
		  InetAddress addr = InetAddress.getByName(hostname);

		  // otvori socket prema drugom racunaru
		  Socket sock = new Socket(addr, TCP_PORT);


		  // inicijalizuj izlazni stream
		 ObjectOutputStream out= new ObjectOutputStream(sock.getOutputStream());
		 
		  // inicijalizuj ulazni stream
		 ObjectInputStream in= new ObjectInputStream(sock.getInputStream());


		  // posalji zahtev
		  
		  Poruka poruka = new Poruka();
		  poruka.setKomanda("IZMENI_AUTORA");
		  poruka.setObjekat1(autor);
		  poruka.setObjekat2(null);
		  
		  System.out.println("poruka: "+poruka.getKomanda());
		  
		  out.writeObject(poruka);
		  
		  System.out.println("poruka");
		  // procitaj odgovor
		  
			try {
				Autor odg= (Autor)in.readObject();	
				String id2= odg.getId();
			   	request.setAttribute("id2", id2);
			
					  in.close();	
				      out.close();  
				      sock.close();

					 RequestDispatcher disp = request.getRequestDispatcher("/IzmenjenAutor.jsp");							
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
