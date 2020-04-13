package rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.servlet;

import java.io.IOException;
import java.text.ParseException;
import java.text.SimpleDateFormat;
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

import rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.entity.Category;
import rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.entity.Post;
import rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.session.CategoryDaoLocal;
import rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.session.PostDaoLocal;

public class ShowPostsController extends HttpServlet {

	private static final long serialVersionUID = -6820366488786163882L;
	
	private static Logger log = Logger.getLogger(ShowPostsController.class);


	@EJB
	private CategoryDaoLocal categoryDao;
	
	@EJB
	private PostDaoLocal postDao;
	
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
		try {
			
			String criteria= request.getParameter("criteria");
			if(criteria!=null)
			{
				getServletContext().setAttribute("criteria", criteria);
				//request.getSession().setAttribute("criteria", criteria);
			} else
			{
				criteria= (String) getServletContext().getAttribute("criteria");
				if(criteria==null)
				{
					String date="date";
					getServletContext().setAttribute("criteria", date);
					//request.getSession().setAttribute("criteria", date);
					//criteria= (String) request.getSession().getAttribute("criteria");
				}
			}
			System.out.println("########################################################");
			System.out.println((String) getServletContext().getAttribute("criteria"));
			System.out.println("########################################################");
			List<Post> posts= new ArrayList<Post>();
			List<Post> topPosts= new ArrayList<Post>();
			
			if(postDao.findAll()!=null)
			{
				//posts=  postDao.findAll();
				
				for(Post p: postDao.findAll())
				{
					posts.add(p);
				}
			}
			
//			String sel= request.getParameter("sel");
//			if(sel!=null)
//			{
//				getServletContext().setAttribute("sel", sel);
//			} else
//				sel= (String) getServletContext().getAttribute("sel");
//			System.out.println("********************************************");
//			System.out.println("SEL: "+sel);
//			System.out.println("********************************************");
			
			criteria= (String) getServletContext().getAttribute("criteria");
			if(criteria.equals("date"))
			{

					
					Collections.sort(posts, new Comparator<Post>() {
						  public int compare(Post p1, Post p2) {
						      if (p1.getPostDate() == null || p2.getPostDate() == null)
						        return 0;
						      return p2.getPostDate().compareTo(p1.getPostDate());
						  }
						});	
					
					//request.setAttribute("sel", "date");
					getServletContext().setAttribute("ssel", "date");
					
			}
			else if(criteria.equals("comment"))
		    {
		    	Collections.sort(posts, new Comparator<Post>() {
		    		
					  public int compare(Post p1, Post p2) {
					      if (p1.getComments() == null || p2.getComments() == null)
					        return 0;
					      return (p2.getComments().size())-(p1.getComments().size());
					  }
					  
					});			
		    	
		    	//request.setAttribute("sel", "comment");
		    	getServletContext().setAttribute("ssel", "comment");
		    	
		    }
			else if(criteria.equals("visit"))
			{
				Collections.sort(posts, new Comparator<Post>() {
					  public int compare(Post p1, Post p2) {
					      if (p1.getPostDate() == null || p2.getPostDate() == null)
					        return 0;
					      return p2.getPostVisitors()-p1.getPostVisitors();
					  }
					});		
				
		    	//request.setAttribute("sel", "visit");
				getServletContext().setAttribute("ssel", "visit");
			}
			
			for(int i=0;i<posts.size();i++)
			{
				if(i==9)
					break;
				topPosts.add(posts.get(i));
			}
			
			System.out.println("********************************************");
			System.out.println("SEL: "+getServletContext().getAttribute("ssel").toString());
			System.out.println("********************************************");
			
			String pageTipe= "home";
			getServletContext().setAttribute("ppage", pageTipe);
			getServletContext().setAttribute("topposts", topPosts);
			request.setAttribute("home", 1);
			getServletContext().getRequestDispatcher("/home.jsp").forward(request, response);
		
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