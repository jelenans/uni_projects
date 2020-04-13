package rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.servlet;

import java.io.IOException;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Date;

import javax.ejb.EJB;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import org.apache.log4j.Logger;

import rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.entity.Category;
import rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.entity.Post;
import rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.entity.User;
import rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.session.CategoryDaoLocal;
import rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.session.PostDaoLocal;

public class PostController extends HttpServlet {

	private static final long serialVersionUID = -2544396238785425302L;
	
	private static Logger log = Logger.getLogger(PostController.class);

	@EJB
	private PostDaoLocal postDao;

	@EJB
	private CategoryDaoLocal categoryDao;

	/**
	 * 
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
		try {
			
			String title = null;
			String summary = null;
			String content = null;
			Integer catId = null;
			Date date=null;

			if ((request.getSession().getAttribute("user")) == null) {
				response.sendRedirect(response.encodeURL("./login2.jsp"));
				return;
			}

			if (request.getParameter("title") != null) {
				title = request.getParameter("title");
			}

			if (request.getParameter("summary") != null) {
				summary = request.getParameter("summary");
			}

			if (request.getParameter("content") != null) {
				content = request.getParameter("content");
			}
			
		     if("".equals(title) || "".equals(summary) || "".equals(content.trim()))
		     {
		    	  request.setAttribute("msg", 1);	 
		    	  request.setAttribute("categories", categoryDao.findAll());
				  getServletContext().getRequestDispatcher("/post.jsp").forward(request, response); 
		          return;
		     }
		     


			if ((request.getParameter("category") != null) && (!"".equals(request.getParameter("category")))) {
				catId = new Integer(request.getParameter("category"));
			}
			
			  Calendar currentDate = Calendar.getInstance();
			  SimpleDateFormat formatter= new SimpleDateFormat("dd/MM/yyyy");
			  String dateNow = formatter.format(currentDate.getTime());

			  System.out.println("...................................................................");

			  System.out.println("getTime: "+currentDate.getTime().toString());
			  System.out.println("...................................................................");
			  System.out.println("Now the date is :=>  " + dateNow);
			  System.out.println("...................................................................");
			  
			  try {
				date = new SimpleDateFormat("dd/MM/yyyy").parse(dateNow);
			} catch (ParseException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}

		   User blogger= (User) (request.getSession().getAttribute("user"));
		   Category category= null;
			Post post= new Post();

			if (title != null)
				post.setPostTitle(title);

			if (summary != null)
				post.setPostSummary(summary);

			if (content != null)
				post.setPostContent(content);

			if (catId != null)
			{
				category= categoryDao.findById(catId);
				post.setCategory(category);
				//category.addPost(post);
				//categoryDao.merge(category);
			}
			else
			   post.setCategory(null);
			
			if (date != null)
				post.setPostDate(date);
			
			if(blogger!=null)
				post.setUser(blogger);
			
	        post.setComments(null);
			postDao.persist(post);
			log.info("Post " + post.getPostTitle() + " added!");
		 	request.setAttribute("post", post.getPostTitle());
			getServletContext().getRequestDispatcher("/post_added.jsp").forward(request, response);
			return;
			
		} catch (ServletException e) {
			log.error(e);
			throw e;
		} catch (IOException e) {
			log.error(e);
			throw e;
		} 
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		doGet(request, response);
	}
}
