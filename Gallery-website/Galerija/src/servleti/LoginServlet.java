package servleti;

import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.net.InetAddress;
import java.net.Socket;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import org.apache.catalina.User;

import beans.Kustos;
import beans.Poruka;
import beans.Tip;

public class LoginServlet  extends javax.servlet.http.HttpServlet implements javax.servlet.Servlet{

	  public static final int TCP_PORT = 9000;
	  String hostname = "localhost";
	  ObjectInputStream in;
	  ObjectOutputStream out;
	
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
		
		String ime = request.getParameter("ime");
		String lozinka = request.getParameter("lozinka");
		String logoff = request.getParameter("logoff");
		Kustos kustos = (Kustos)request.getSession().getAttribute("kustos");
		
		System.out.println("ime:"+ime);

		System.out.println("pass "+lozinka);
		//System.out.println(" kustos "+kustos.getIme());
		
		if (kustos != null) {
			if (logoff != null && logoff.equals("true")) {
				// ako je poslat parametar za logoff, odjavimo se
				kustos.setLogged(false);
				request.getSession().setAttribute("kustos",null);
				// i odemo na login stranicu
				RequestDispatcher disp = request
						.getRequestDispatcher("/login.jsp");
				// redirektovacemo na login stranicu
				disp.forward(request, response);
				return;
			}
		} else {
			
			if (ime != null && lozinka!= null && !ime.equals("") &&  !lozinka.equals("")) {
				// user session bean postoji, uname i passwd postoje,
				// pa cemo pokusati da se prijavimo i
			
				Kustos k= new Kustos(ime, lozinka, false);

				
				 // odredi adresu racunara sa kojim se povezujemo
				  InetAddress addr = InetAddress.getByName(hostname);
	System.out.println("ADDR");
				  // otvori socket prema drugom racunaru
				  Socket sock = new Socket(addr, TCP_PORT);
	System.out.println("SOCK");

		//inicijalizuj izlazni stream
					out= new ObjectOutputStream(sock.getOutputStream());
	System.out.println("OUT");

				  // inicijalizuj ulazni stream
				  in= new ObjectInputStream(sock.getInputStream());
	System.out.println("IN");
				  
				  // posalji zahtev
				  
				  Poruka poruka = new Poruka();
				  poruka.setKomanda("LOGIN");
				  poruka.setObjekat1(k);
				  poruka.setObjekat2(null);
				  
	//  System.out.println("poruka: "+poruka.getKomanda());
				  
				  out.writeObject(poruka);
				  
	//System.out.println("poruka");
				  // procitaj odgovor
	 
					try {
						boolean odg= (Boolean)in.readObject();
						
						if(odg==true){
							System.out.println("odgLOGIN: DA");
							  in.close();	
						      out.close();  
						      sock.close();
						    k.setLogged(true);
						    request.getSession().setAttribute("kustos",k);
						    
							RequestDispatcher disp = request.getRequestDispatcher("/kustosMain.jsp");
							// redirektovacemo na login stranicu
							disp.forward(request, response);
							return;
						}else{
							response.sendRedirect("/Galerija/error.jsp");
							return;
						}
					} catch (ClassNotFoundException e) {
						// TODO Auto-generated catch block
						e.printStackTrace();
					}
//					  in.close();	
//				      out.close();  
//				      sock.close();
//				      System.out.println("odgLOGIN: NIJE");
//					response.sendRedirect("/Galerija/login.jsp");
				//	request.setAttribute("por","Niste registrovani!");
	//				return;

			} else {
				// ne postoji uname ili passwd, pa idemo na login


				RequestDispatcher disp = request.getRequestDispatcher("/login.jsp");				
				disp.forward(request, response);
				return;
			}
	}
		
}
		
		
		
		

//.............................................................................................................
			
		
	



	protected void doPost(HttpServletRequest request,
			HttpServletResponse response) throws ServletException, IOException {
		doGet(request, response);
	}

}
