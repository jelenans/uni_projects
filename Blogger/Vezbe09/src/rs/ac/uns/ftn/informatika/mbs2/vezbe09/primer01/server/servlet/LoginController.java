package rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.servlet;

import java.io.IOException;

import javax.ejb.EJB;
import javax.ejb.EJBException;
import javax.persistence.NoResultException;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import org.apache.log4j.Logger;

import rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.entity.User;
import rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.session.UserDaoLocal;

public class LoginController extends HttpServlet {

	private static final long serialVersionUID = -7345471861052209628L;
	
	private static Logger log = Logger.getLogger(LoginController.class);

	@EJB
	private UserDaoLocal userDao;

	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {

		try {
			
			

		 User usr= (User) request.getSession().getAttribute("user");
//		 if(usr==null)
//		 {
			String korisnickoIme = request.getParameter("korisnickoIme");
			String lozinka = request.getParameter("lozinka");
			if ((korisnickoIme == null) || (korisnickoIme.equals("")) || (lozinka == null) || (lozinka.equals(""))) {
				request.setAttribute("msg", 1);
				getServletContext().getRequestDispatcher("/login2.jsp").forward(request, response);
				return;
			}
			System.out.println("LOGIN");
			User user= userDao.findUserWithUsernameAndPassword(korisnickoIme, lozinka);
			
			if (user != null) {	
				HttpSession session = request.getSession(true);
				session.setAttribute("user", user);
				log.info("User " + user.getUserName() + " logged in!");
				boolean logIn=true;
				request.setAttribute("logIn", logIn);
				getServletContext().getRequestDispatcher("/home.jsp").forward(request, response);
			} else
			{
				request.setAttribute("msg", 3);
				getServletContext().getRequestDispatcher("/login2.jsp").forward(request, response);
			}
//		 }else
//		 	{
//				response.sendRedirect(response.encodeRedirectURL("./already_logged.jsp"));
//			}
		} catch (EJBException e) {
			if (e.getCause().getClass().equals(NoResultException.class)) {
				response.sendRedirect(response.encodeRedirectURL("./login2.jsp"));
			} else {
				throw e;
			}
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
