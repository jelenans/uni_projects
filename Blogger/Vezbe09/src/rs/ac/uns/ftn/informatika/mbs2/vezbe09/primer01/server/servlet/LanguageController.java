package rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.servlet;

import java.io.IOException;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Comparator;
import java.util.List;

import javax.ejb.EJB;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import org.apache.log4j.Logger;

import rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.entity.Post;
import rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.session.CategoryDaoLocal;
import rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.session.PostDaoLocal;

public class LanguageController extends HttpServlet {

	private static final long serialVersionUID = 5161949512237886627L;

	private static Logger log = Logger.getLogger(LanguageController.class);

	@EJB
	private PostDaoLocal postDao;

	protected void doGet(HttpServletRequest request,
			HttpServletResponse response) throws ServletException, IOException {

	     boolean srb= request.getParameter("srb") != null;
	     boolean eng= request.getParameter("eng") != null;
	     
	     if(srb)
	     {
	    	 System.out.println("SRB");
	    	 request.getSession().setAttribute("lng", 0);
	     }
	     else if(eng)
	     {
	    	 System.out.println("ENG");
	    	 request.getSession().setAttribute("lng", 1);
	     }
	     
		
		getServletContext().getRequestDispatcher("/home.jsp").forward(request,
				response);

	}

	protected void doPost(HttpServletRequest request,
			HttpServletResponse response) throws ServletException, IOException {
		doGet(request, response);
	}
}
