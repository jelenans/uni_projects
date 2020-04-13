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

public class PrepareHomeController extends HttpServlet {

	private static final long serialVersionUID = 5161949512237886627L;
	
	private static Logger log = Logger.getLogger(PrepareHomeController.class);

	
	@EJB
	private PostDaoLocal postDao;

	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		

		List<Post> posts= new ArrayList<Post>();
		List<Post> topPosts= new ArrayList<Post>();
		
		if(postDao.findAll()!=null)
		{
			//posts=  postDao.findAll();
			
			for(Post p: postDao.findAll())
			{
				posts.add(p);
			}
			
			Collections.sort(posts, new Comparator<Post>() {
				  public int compare(Post p1, Post p2) {
				      if (p1.getPostDate() == null || p2.getPostDate() == null)
				        return 0;
				      return p2.getPostDate().compareTo(p1.getPostDate());
				  }
				});	
		}
			
		for(int i=0;i<posts.size();i++)
		{
			if(i==9)
				break;
			topPosts.add(posts.get(i));
		}
		getServletContext().setAttribute("topposts", topPosts);
		getServletContext().setAttribute("ssel", "date");
		getServletContext().setAttribute("lng", 0);
		
		
		request.getSession().setAttribute("reg_user", null);
		request.getSession().setAttribute("user", null);
		request.setAttribute("home", 1);

	//	request.setAttribute("sel", "date");
		String pageTipe= "home";
		getServletContext().setAttribute("ppage", pageTipe);
		getServletContext().getRequestDispatcher("/home.jsp").forward(request, response);


	}

	protected void doPost(HttpServletRequest request, 	HttpServletResponse response) throws ServletException, IOException {
		doGet(request, response);
	}
}
