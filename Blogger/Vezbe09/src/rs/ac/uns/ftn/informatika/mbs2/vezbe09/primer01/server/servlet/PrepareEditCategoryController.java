package rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.servlet;

import java.io.IOException;

import javax.ejb.EJB;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import org.apache.log4j.Logger;

import rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.session.CategoryDaoLocal;

public class PrepareEditCategoryController extends HttpServlet {

	private static final long serialVersionUID = 1069341894540010096L;
	
	private static Logger log = Logger.getLogger(PrepareEditCategoryController.class);

	
	@EJB
	private CategoryDaoLocal categoryDao;
	

	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
		try {
			
			if ((request.getSession().getAttribute("user")) == null) {
				response.sendRedirect(response.encodeURL("./login2.jsp"));
				return;
			}

			request.setAttribute("categories", categoryDao.findAll());


			String catId = request.getParameter("catId");

			if ((catId != null) && (!catId.equals(""))) {
				request.setAttribute("category", categoryDao.findById(Integer.parseInt(catId)));
				getServletContext().getRequestDispatcher("/edit_category.jsp").forward(request, response);
			}
			
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