package rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.servlet;

import java.io.IOException;

import javax.ejb.EJB;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import org.apache.log4j.Logger;

import rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.entity.User;
import rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.session.UserDaoLocal;

public class PrepareEditProfileController extends HttpServlet {

	private static final long serialVersionUID = 1069341894540010096L;
	
	private static Logger log = Logger.getLogger(PrepareEditProfileController.class);

	
	@EJB
	private UserDaoLocal userDao;

	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
		try {
			
			User user_to_edit=  (User) request.getSession().getAttribute("user");
			
			if (user_to_edit == null) {
				response.sendRedirect(response.encodeURL("./login2.jsp"));
				return;
			}

			Integer userId =  user_to_edit.getId();  //request.getParameter("userId");

			if (userId != null) {
				request.setAttribute("user_to_edit", userDao.findById(userId));
				System.out.println("jaoooooooooo:  "+userDao.findById(userId).getUserPicture());
				getServletContext().getRequestDispatcher("/edit_profile.jsp").forward(request, response);
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