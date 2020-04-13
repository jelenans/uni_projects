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


public class AddCategoryController extends HttpServlet {

	private static final long serialVersionUID = -2544396238785425302L;
	
	private static Logger log = Logger.getLogger(AddCategoryController.class);


	@EJB
	private CategoryDaoLocal categoryDao;

	/**
	 * 
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
		try {
			
			String name = null;
			Integer catId = null;

			if ((request.getSession().getAttribute("user")) == null) {
				response.sendRedirect(response.encodeURL("./login2.jsp"));
				return;
			}
			
			if (request.getParameter("name") != null) {
				name = request.getParameter("name");
			}
			
			if("".equals(name))
		    {
		              
				  request.setAttribute("msg", 1);	
				  request.setAttribute("categories", categoryDao.findAll());
				  getServletContext().getRequestDispatcher("/add_category.jsp").forward(request, response);	
		          return;
		              
		    } 



			Category category= new Category();

			if (name != null)
				category.setCategoryName(name);
			
			if ((request.getParameter("category") != null) && (!"".equals(request.getParameter("category")))) {
				catId = new Integer(request.getParameter("category"));
//				Category parentCat= new Category();
//				parentCat.setId(new Integer(catId));
//				parentCat.add(category);
//				categoryDao.merge(parentCat);
			} 
//			else
//			{
//				categoryDao.persist(category);
//			}
			

			if (catId != null)
			{
				Category parentCat=categoryDao.findById(catId);
				category.setCategory(parentCat);
			//	parentCat.add(category);
			//	categoryDao.merge(parentCat);
			}
			categoryDao.persist(category);
			log.info("Category " + category.getCategoryName() + " added!");

			getServletContext().getRequestDispatcher("/ViewCategoriesController").forward(request, response);
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
