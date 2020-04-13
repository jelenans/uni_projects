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

public class DeleteCategoryController extends HttpServlet {

	private static final long serialVersionUID = -6495686002772669396L;
	
	private static Logger log = Logger.getLogger(DeleteCategoryController.class);
	
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
			catId = request.getParameter("catId");

			Category category = categoryDao.findById(Integer.parseInt(catId));
			//Category parentCat= category.getCategory();
			List<Category> subcat=new ArrayList<Category>();
            subcat= categoryDao.findSubcategories(Integer.parseInt(catId));
            //List<Post> catposts=new ArrayList<Post>();
            //catposts= postDao.findPostsByCategory(Integer.parseInt(catId));
            if(subcat.size()==0)
            {
           //	parentCat.getSubcategories().remove(category);
          // 	categoryDao.merge(parentCat);
			categoryDao.remove(category);

			getServletContext().getRequestDispatcher("/ViewCategoriesController").forward(request, response);
            }
            else
            {
               	request.setAttribute("category", category);
            	request.setAttribute("subcategories", subcat);
            	request.setAttribute("posts", category.getPosts());
               	getServletContext().getRequestDispatcher("/remove_cat_warning.jsp").forward(request, response);
            }
			log.info("Category " + category.getCategoryName() + " deleted!");		
			
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
