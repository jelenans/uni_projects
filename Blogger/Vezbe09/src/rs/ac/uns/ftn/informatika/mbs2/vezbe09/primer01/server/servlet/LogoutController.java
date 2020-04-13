package rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.servlet;

import java.io.IOException;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import org.apache.log4j.Logger;

import rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.entity.User;

public class LogoutController extends HttpServlet {

	private static final long serialVersionUID = -9042476143848933537L;
	
	private static Logger log = Logger.getLogger(LogoutController.class);

	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws IOException {
		try {
			
			String logoff = request.getParameter("logoff");
			
			if (logoff != null && logoff.equals("true")) {
				User usr= (User) request.getSession().getAttribute("user");
				boolean logOut;
			 if(usr!=null)
			 {
				request.setAttribute("usr", usr);
			    HttpSession session = request.getSession();
			    session.invalidate();
			    User user= (User) request.getSession().getAttribute("user");
			    request.setAttribute("user", user);
				logOut=true;
				log.info("User " + usr.getUserName() + " logged out!");
				request.setAttribute("logOut", logOut);
				try {
					getServletContext().getRequestDispatcher("/home.jsp").forward(request, response);
				} catch (ServletException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}	
			   // response.sendRedirect(response.encodeRedirectURL("./login.jsp"));
			 } else
			 {
				 try {
					logOut=false;
					request.setAttribute("logOut", logOut);
					getServletContext().getRequestDispatcher("/home.jsp").forward(request, response);
				} catch (ServletException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
			 }
			}
		} catch (IOException e) {
			log.error(e);
			throw e;
		}
	}

	protected void doPost(HttpServletRequest request, 	HttpServletResponse response) throws ServletException, IOException {
		doGet(request, response);
	}
}
