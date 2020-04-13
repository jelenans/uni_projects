package rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.servlet;

import java.io.IOException;
import java.util.ArrayList;
import java.util.HashSet;
import java.util.List;
import java.util.Set;

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

public class DeleteCatSubController extends HttpServlet {

	private static final long serialVersionUID = -6495686002772669396L;
	
	private static Logger log = Logger.getLogger(DeleteCatSubController.class);
	
	@EJB
	private CategoryDaoLocal categoryDao;
	
	@EJB
	private PostDaoLocal postDao;

	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
		try {
			
			if ((request.getSession().getAttribute("user")) == null) {
				response.sendRedirect(response.encodeURL("./login2.jsp"));
				return;
			}

			String catId = null;
			catId = request.getParameter("id");

			Category category = categoryDao.findById(Integer.parseInt(catId));
			
			if(category.getCategory()!=null)
				category.getCategory().getSubcategories().remove(category);
			
			for(Category sub: category.getSubcategories())
			{
				sub.setCategory(null);
				categoryDao.merge(sub);
			}
			for(Post p: category.getPosts())
			{
				p.setCategory(null);
				postDao.merge(p);
			}
		
			categoryDao.remove(category);
			log.info("Category " + category.getCategoryName() + " deleted!");
			getServletContext().getRequestDispatcher("/ViewCategoriesController").forward(request, response);
			
			
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
