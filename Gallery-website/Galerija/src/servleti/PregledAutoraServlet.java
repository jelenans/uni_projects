package servleti;

import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.net.InetAddress;
import java.net.Socket;
import java.util.ArrayList;
import java.util.HashMap;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import beans.Autor;
import beans.Poruka;

/**
 * Servlet implementation class PregledAutoraServlet
 */
public class PregledAutoraServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
	public static final int TCP_PORT = 9000;
	String hostname = "localhost";


	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {

		 
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
		  poruka.setKomanda("PREGLED_AUTORA");
		  poruka.setObjekat1(null);
		  poruka.setObjekat2(null);
		

		  

		  out.writeObject(poruka);
		  
		  // procitaj odgovor
		  
			try {
				HashMap<String, Autor> odg= (HashMap<String, Autor>)in.readObject();
				
				ArrayList<Autor> autori= new ArrayList<Autor>(odg.values());
//				Iterator it = odg.keySet().iterator();
//				while(it.hasNext()) {	
//					Object key = it.next();
//					Autor a = odg.get(key);	
//					System.out.println("IZ_DATOTEKE__IME A: "+a.getIme());
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

	protected void doPost(HttpServletRequest request,
			HttpServletResponse response) throws ServletException, IOException {
		doGet(request, response);
	}

}
