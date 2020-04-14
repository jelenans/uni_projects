package servleti;

import java.io.IOException;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class VrsteDelaServlet
 */
public class VrsteDelaServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;


	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {

		String vrsta = request.getParameter("vrsta");	
		
		if(vrsta.equals("slika")){
			request.setAttribute("vrsta", vrsta);

		    RequestDispatcher disp = request.getRequestDispatcher("/DodavanjeDelaSlika.jsp");							
			disp.forward(request, response);	
		}
		if(vrsta.equals("skulptura")){
			request.setAttribute("vrsta", vrsta);

		    RequestDispatcher disp = request.getRequestDispatcher("/DodavanjeDelaSkulptura.jsp");							
			disp.forward(request, response);	
		}
		if(vrsta.equals("multimedija")){
			request.setAttribute("vrsta", vrsta);

		    RequestDispatcher disp = request.getRequestDispatcher("/DodavanjeDelaMulti.jsp");							
			disp.forward(request, response);	
		}
	}

	protected void doPost(HttpServletRequest request,
			HttpServletResponse response) throws ServletException, IOException {
		doGet(request, response);
	}
	
}
