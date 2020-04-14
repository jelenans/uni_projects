package servleti;

import java.io.IOException;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class VrsteDelaAutorServlet
 */
public class VrsteDelaAutorServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
 
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		String vrsta = request.getParameter("vrsta");	
		String id = request.getParameter("id");	
		String ime = request.getParameter("ime");	
		String prz = request.getParameter("prz");	
		
		if(vrsta.equals("slika")){
			request.setAttribute("vrsta", vrsta);
			request.setAttribute("ime", ime);
			request.setAttribute("prezime", prz);
			request.setAttribute("id", id);
		    RequestDispatcher disp = request.getRequestDispatcher("/DodavanjeDelaASlika.jsp");							
			disp.forward(request, response);	
		}
		if(vrsta.equals("skulptura")){
			request.setAttribute("vrsta", vrsta);
			request.setAttribute("ime", ime);
			request.setAttribute("prezime", prz);
			request.setAttribute("id", id);
		    RequestDispatcher disp = request.getRequestDispatcher("/DodavanjeDelaASkulptura.jsp");							
			disp.forward(request, response);	
		}
		if(vrsta.equals("multimedija")){
			request.setAttribute("vrsta", vrsta);
			request.setAttribute("ime", ime);
			request.setAttribute("prezime", prz);
			request.setAttribute("id", id);
		    RequestDispatcher disp = request.getRequestDispatcher("/DodavanjeDelaAMulti.jsp");							
			disp.forward(request, response);	
		}
	}

	protected void doPost(HttpServletRequest request,
			HttpServletResponse response) throws ServletException, IOException {
		doGet(request, response);
	}	

}
