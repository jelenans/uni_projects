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

public class RssController extends HttpServlet {

	private static final long serialVersionUID = 3118223609164296277L;
	
	
	@EJB
	private PostDaoLocal postDao;
	@EJB
	private CategoryDaoLocal categoryDao;

	
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		

		List<Post> posts = new ArrayList<Post>();
		
        posts = postDao.findAll();

	    Integer port = request.getServerPort();
	    String name = request.getServerName();
	    String path = request.getContextPath();
	    
	    
        
	    request.setAttribute("posts", posts);
        
        request.setAttribute("name", name);
        request.setAttribute("port", port);
        request.setAttribute("path", path);
        
        response.setContentType("application/xml+rss");
		
		getServletContext().getRequestDispatcher("/rss.jsp").forward(request, response);
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		doGet(request, response);
	}
}
