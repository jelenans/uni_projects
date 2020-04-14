package servleti;

import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.net.InetAddress;
import java.net.Socket;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.Vector;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import beans.Delo;
import beans.MultimedijalniZapis;
import beans.Poruka;
import beans.Skulptura;
import beans.Slika;

/**
 * Servlet implementation class NadjiDeloAutorServlet
 */
public class NadjiDeloAutorServlet extends HttpServlet {
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
		  

		  String imeA=request.getParameter("imeA");
		  String przA=request.getParameter("przA");
		  
	//	  System.out.println("thread_NADJI_VREDNOST: "+vrednost);
		  Poruka poruka = new Poruka();
		  poruka.setKomanda("NADJI_DELO_AUTOR");
		  poruka.setObjekat1(imeA);
		  poruka.setObjekat2(przA);
		  
		
		  String vr= (String)poruka.getObjekat1();
		  System.out.println("thread_NADJI_pravac_GETTER: "+vr );
		  
		  out.writeObject(poruka);
		  
		  // procitaj odgovor
		  
			try {

				Vector<Delo> odg= ( Vector<Delo>)in.readObject();
				
				ArrayList<Slika> slike=new ArrayList<>();
				ArrayList<Skulptura> skulpture= new ArrayList<>();
				ArrayList<MultimedijalniZapis> multi= new ArrayList<>();
				
				//Iterator it = odg.iterator();
				for(Delo d:odg) {	
					
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

				    RequestDispatcher disp = request.getRequestDispatcher("/PregledDela.jsp");							
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
