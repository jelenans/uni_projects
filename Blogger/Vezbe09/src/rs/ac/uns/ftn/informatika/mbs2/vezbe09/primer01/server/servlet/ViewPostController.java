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
import rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.entity.Comment;
import rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.entity.Post;
import rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.session.CategoryDaoLocal;
import rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.session.CommentDaoLocal;
import rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.session.PostDaoLocal;

public class ViewPostController extends HttpServlet {

	private static final long serialVersionUID = -6820366488786163882L;
	
	private static Logger log = Logger.getLogger(ViewPostController.class);

	@EJB
	private PostDaoLocal postDao;
	
	@EJB
	private CommentDaoLocal commentDao;
	
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
		try {
			
			String postId = null;
			postId = request.getParameter("postId");
//			if(postId!=null)
//			{
//			System.out.println(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
//			System.out.println("postId COMMENT CONTROLLER AAA: "+postId);
//			System.out.println(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
//			}
			
			String page= (String) getServletContext().getAttribute("ppage");
//			String pageId= (String) request.getAttribute("pageId");	
			if(page!=null)
			{
				System.out.println("VIEW POS----->PAGE: "+page);
			    request.setAttribute("pageId", page);
			}
//			 else if(pageId!=null)
//			 {
//				request.setAttribute("pageId", pageId);	
//				System.out.println("PAGE NUUUUL");
//			 }
			
			Post post= postDao.findById(Integer.parseInt(postId));
            request.setAttribute("post", post);
            
        	List<Comment> comments=new ArrayList<Comment>();
        	comments= commentDao.findPostComments(Integer.parseInt(postId));
            if(comments.size()!=0)
            	request.setAttribute("comments", comments);
            else
            	request.setAttribute("comments", new ArrayList<Comment>());
            
            String svisit=(String) request.getAttribute("visit");

			
           if(svisit==null || !svisit.equals("visited"))
           {
		    post.addPostVisitor();
		    postDao.merge(post);
           }
           
            
			getServletContext().getRequestDispatcher("/view_post.jsp").forward(request, response);
		
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