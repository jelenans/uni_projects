package servleti;

import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.net.InetAddress;
import java.net.Socket;

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
 * Servlet implementation class NadjiDeloServlet
 */
public class NadjiDeloServlet extends HttpServlet {
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
		  

		  String id=request.getParameter("id");
		  Poruka poruka = new Poruka();
		  poruka.setKomanda("NADJI_DELO");
		  poruka.setObjekat1(id);
		  poruka.setObjekat2(null);
		

		  
		  out.writeObject(poruka);
		  
		  // procitaj odgovor
		  
			try {
					Delo d= (Delo)in.readObject();
					System.out.println("delo id:"+ d.getId());

					
					in.close();	
				    out.close();  
				    sock.close();


					if(d instanceof Slika){
						Slika s= (Slika)d;
						request.setAttribute("slika", s);
					    RequestDispatcher disp = request.getRequestDispatcher("/NadjenoDeloSlika.jsp");							
						 disp.forward(request, response);	

					return;
					}else if(d instanceof Skulptura)
					{
						Skulptura s=(Skulptura)d;
						request.setAttribute("sk", s);
					    RequestDispatcher disp = request.getRequestDispatcher("/NadjenoDeloSkulptura.jsp");							
						 disp.forward(request, response);	

					return;
					}else if(d instanceof MultimedijalniZapis)
					{
						MultimedijalniZapis m=(MultimedijalniZapis)d;
						request.setAttribute("m", m);
					    RequestDispatcher disp = request.getRequestDispatcher("/NadjenoDeloMulti.jsp");							
						 disp.forward(request, response);	

					return;
					}
				//	System.out.println("ODG:"+ odg.getIme());
			
				
			
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
