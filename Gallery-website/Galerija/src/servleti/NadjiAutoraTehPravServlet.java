package servleti;

import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.net.InetAddress;
import java.net.Socket;
import java.util.Vector;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import beans.Autor;
import beans.Poruka;

/**
 * Servlet implementation class NadjiAutoraTehPravServlet
 */
public class NadjiAutoraTehPravServlet extends HttpServlet {
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
		  

		  String pravac=request.getParameter("pravacA");
		  
		  if(pravac!=null)
		  {
		 // System.out.println("thread_NADJI_VREDNOST: "+vrednost);
		  Poruka poruka = new Poruka();
		  poruka.setKomanda("NADJI_AUTORA_PRAVAC");
		  poruka.setObjekat1(pravac);
		  poruka.setObjekat2(null);
		  
		  String vr= (String)poruka.getObjekat1();
		  System.out.println("thread_NADJI_VREDNOST_GETTER: "+vr );
		  
		  out.writeObject(poruka);
		  
		  // procitaj odgovor
		  
			try {

				Vector<Autor> odg= ( Vector<Autor>)in.readObject();
				//	System.out.println("ODG:"+ odg.getIme());
					request.setAttribute("autori", odg);
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

//TEH...............................................................................
		  String teh=request.getParameter("tehnikaA");
		  
		  if(teh!=null)
		  {
		//  System.out.println("thread_NADJI_VREDNOST: "+vrednost);
		  Poruka poruka = new Poruka();
		  poruka.setKomanda("NADJI_AUTORA_TEHNIKA");
		  poruka.setObjekat1(teh);
		  poruka.setObjekat2(null);
		  
		  String vr= (String)poruka.getObjekat1();
		  System.out.println("thread_NADJI_VREDNOST_GETTER: "+vr );
		  
		  out.writeObject(poruka);
		  
		  // procitaj odgovor
		  
			try {

				Vector<Autor> odg= ( Vector<Autor>)in.readObject();
				//	System.out.println("ODG:"+ odg.getIme());
					request.setAttribute("autori", odg);
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
	}


	protected void doPost(HttpServletRequest request,
			HttpServletResponse response) throws ServletException, IOException {
		doGet(request, response);
	}

}
