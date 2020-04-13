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

import rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.entity.Comment;
import rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.entity.Post;
import rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.session.CategoryDaoLocal;
import rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.session.CommentDaoLocal;
import rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.session.PostDaoLocal;

public class CommentController extends HttpServlet {

	private static final long serialVersionUID = -6820366488786163882L;
	
	private static Logger log = Logger.getLogger(CommentController.class);

	@EJB
	private PostDaoLocal postDao;
	
	@EJB
	private CommentDaoLocal commentDao;
	
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
		try {
			
			Date date=null;
			String postId= request.getParameter("postId");
			//String pageId= request.getParameter("pagee");
			System.out.println(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
		//	System.out.println("COMMEMMMENT pagee: "+pageId);
			System.out.println(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
			String title = request.getParameter("title");
			String content = request.getParameter("content");
			
			
			Post post= postDao.findById(Integer.parseInt(postId));
			
			 if("".equals(title) || "".equals(content.trim()))
		     {
		    	  request.setAttribute("msg", 1);	 
		    	  request.setAttribute("post", post);	
				  getServletContext().getRequestDispatcher("/comment_post.jsp").forward(request, response); 
		          return;
		     }
			
			Comment comment= new Comment();
			
			comment.setCommentTitle(title);
			comment.setCommentContent(content);
			comment.setPost(post);
			
			  Calendar currentDate = Calendar.getInstance();
			  SimpleDateFormat formatter= new SimpleDateFormat("dd/MM/yyyy");
			  String dateNow = formatter.format(currentDate.getTime());
			  

				try {
					date = new SimpleDateFormat("dd/MM/yyyy").parse(dateNow);
					comment.setCommentDate(date);
				} catch (ParseException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}

			  //SET USER!!!!
			if(post!=null)
			{
			System.out.println(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
			System.out.println("post: "+post.getPostTitle());
			System.out.println(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
			}
			//post.addComment(comment);


		    commentDao.persist(comment);
			log.info("Comment to post " + post.getPostTitle() + " added!");
		    String visited="visited";
			request.setAttribute("postId", postId);		
			request.setAttribute("visit", visited);	
		//	request.setAttribute("pageId", pageId);	
			getServletContext().getRequestDispatcher("/ViewPostController").forward(request, response);
		
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