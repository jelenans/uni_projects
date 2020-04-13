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

public class BackController extends HttpServlet {

	private static final long serialVersionUID = 5161949512237886627L;
	
	private static Logger log = Logger.getLogger(BackController.class);

	
	@EJB
	private PostDaoLocal postDao;

	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
		String page= request.getParameter("page");
		String catId = request.getParameter("category");

		
		if(page.equals("search"))
		{
			request.setAttribute("sback", catId);
			getServletContext().getRequestDispatcher("/SearchPostsController").forward(request, response);
//			response.sendRedirect(response.encodeURL("./SearchPostsController"));
		}
		else if(page.equals("browse"))
		{
			request.setAttribute("category", catId);
			getServletContext().getRequestDispatcher("/BrowsePostsController").forward(request, response);
		}
		else if(page.equals("home"))
		{
			response.sendRedirect(response.encodeURL("./home.jsp"));
		}
		else
		   System.out.println("BACK CONTROLLER----->>PAGE PAARAM NULLL");
		




	}

	protected void doPost(HttpServletRequest request, 	HttpServletResponse response) throws ServletException, IOException {
		doGet(request, response);
	}
}
