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

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import beans.Autor;
import beans.Delo;
import beans.Poruka;

/**
 * Servlet implementation class DodavanjeAutoraDelaServlet
 */
public class DodavanjeAutoraDelaServlet extends HttpServlet {
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
		 
		 Autor autor= new Autor();
		 autor.setIme(ime);
		 autor.setPrezime(prezime);
		 autor.setDatRodj(datRodjenja);
		 autor.setDatSmrti(datSmrti);
		 autor.setMestoRodjenja(mestoRodjenja);
		 autor.setMestoSmrti(mestoSmrti);
		 autor.setBio(bio);
		 autor.setId(id);
		 autor.setDelaAutora(delaAutora);
		
		 String deloID=request.getParameter("deloAutora");
		 
		 
		 // odredi adresu racunara sa kojim se povezujemo
		  InetAddress addr = InetAddress.getByName(hostname);

		  // otvori socket prema drugom racunaru
		  Socket sock = new Socket(addr, TCP_PORT);

		  // inicijalizuj izlazni stream		!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
		 ObjectOutputStream out= new ObjectOutputStream(sock.getOutputStream());
		 
		 
		  // inicijalizuj ulazni stream
		 ObjectInputStream in= new ObjectInputStream(sock.getInputStream());



		  // posalji zahtev
		  
		  Poruka poruka = new Poruka();
		  poruka.setKomanda("DODAJ_AUTORA_DELA");
		  poruka.setObjekat1(autor);
		  poruka.setObjekat2(deloID);
		
		
		  
		  out.writeObject(poruka);
		  
		  // procitaj odgovor
		  
			try {
				Autor odg= (Autor)in.readObject();
				System.out.println("ODG_BIO:"+ odg.getBio());
				request.setAttribute("autor", odg);
				in.close();	
			    out.close();  
			    sock.close();

				 RequestDispatcher disp = request.getRequestDispatcher("/DodatAutor.jsp");							
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
