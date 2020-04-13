package rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.servlet;

import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

import javax.ejb.EJB;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import org.apache.log4j.Logger;

import rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.entity.Category;
import rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.entity.Post;
import rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.session.CategoryDaoLocal;
import rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.session.PostDaoLocal;


public class BrowsePostsController extends HttpServlet {

	private static final long serialVersionUID = -6820366488786163882L;
	
	private static Logger log = Logger.getLogger(BrowsePostsController.class);


	@EJB
	private CategoryDaoLocal categoryDao;
	
	@EJB
	private PostDaoLocal postDao;
	
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
		try {
			
			String catId = null;
			catId = request.getParameter("category");
	
			List<Post> posts=new ArrayList<Post>();
			if(catId!=null || !"".equals(catId))
				posts= postDao.findPostsByCategory(Integer.parseInt(catId));
            if(posts.size()!=0)
            	request.setAttribute("posts", posts);
            else
            	request.setAttribute("posts", new ArrayList<Category>());

			String pageTipe= "browse";
			getServletContext().setAttribute("ppage", pageTipe);
			request.setAttribute("view", true);
			request.setAttribute("cid", Integer.parseInt(catId));
			request.setAttribute("categories", categoryDao.findAll());		
			getServletContext().getRequestDispatcher("/browse_posts.jsp").forward(request, response);
		
		} catch (ServletException e) {
			log.error(e);
			throw e;
		} catch (IOException e) {
			log.error(e);
			throw e;
		}		
	}

	protected void doPost(HttpServletRequest request, 	HttpServletResponse response) throws ServletException, IOException {
		doGet(request, response);
	}
}