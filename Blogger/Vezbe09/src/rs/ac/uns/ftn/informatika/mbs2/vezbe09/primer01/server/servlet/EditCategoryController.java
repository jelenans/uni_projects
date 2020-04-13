package rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.servlet;

import java.io.IOException;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;

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

public class EditCategoryController extends HttpServlet {
	
	private static final long serialVersionUID = 4676416691336033321L;
	
	private static Logger log = Logger.getLogger(EditCategoryController.class);
	
	@EJB
	private CategoryDaoLocal categoryDao;
	
	@EJB
	private PostDaoLocal postDao;
	
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
				
		try {
			
			String catId = null;
			String name = null;
			//Category oldCat= categoryDao.findById(Integer.parseInt(catId));

			
			if ((request.getSession().getAttribute("user")) == null) {
				response.sendRedirect(response.encodeURL("./login2.jsp"));
		    	return;
		    }
			
			catId = request.getParameter("id");
			
			if ((request.getParameter("name")!=null)&&(!"".equals(request.getParameter("name")))){
				name = request.getParameter("name");
			}
	
			if ((catId!=null) && (!catId.equals(""))) {
				
				Category category= new Category();
				category.setId(new Integer(catId));
				
				if (name != null)
					category.setCategoryName(name);
				
//			if(oldCat.getCategory()!=null)	
//			{
//
//				System.out.println(" ......EDIT CAT.....parent cat: "+oldCat.getCategory().getCategoryName());
//				oldCat.getCategory().add(category);
//				categoryDao.merge(oldCat.getCategory());
//			}	
//		   for(Category sub: category.getSubcategories())
//		   {
//					sub.setCategory(category);
//					categoryDao.merge(sub);
//		   }
//				
//		   for(Post p: category.getPosts())
//		   {
//					p.setCategory(category);
//					postDao.merge(p);
//		   }
				
		   categoryDao.merge(category);
		   log.info("Category " + category.getCategoryName() + " updated!");

			}
			
			getServletContext().getRequestDispatcher("/ViewCategoriesController").forward(request, response);
		
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
