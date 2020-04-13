package rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.servlet;

import java.io.IOException;
import java.net.MalformedURLException;
import java.net.URL;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;

import javax.ejb.EJB;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import org.apache.log4j.Logger;

import rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.entity.User;
import rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.session.UserDaoLocal;

public class ChangePasswordController extends HttpServlet {
	
	private static final long serialVersionUID = 4676416691336033321L;
	
	private static Logger log = Logger.getLogger(ChangePasswordController.class);

	@EJB
	private UserDaoLocal userDao;
	
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
				
		try {
			
			

			String userId = null;
			String name = null;
			String surname = null;
			String pass = null;
			String url = null;
			
			String  realPass = null;
			String  oldPass = null;
			String  confPass= null;

			
			realPass= request.getParameter("real_pass");
			oldPass= request.getParameter("old_pass");
			pass = request.getParameter("new_pass");
			confPass= request.getParameter("conf_pass");
			
			User user_to_edit=null;
			Integer userIdd=null;
					
			 if(!"".equals(oldPass) && !"".equals(pass) && !"".equals(confPass))
			{
				 System.out.println("realPass: "+realPass);
				 System.out.println("oldPass: "+oldPass);
				 System.out.println("newPass: "+pass);
				 System.out.println("confPass: "+confPass);
			 }
			
			 if("".equals(oldPass) ||"".equals(pass) || "".equals(confPass))
		     {
					user_to_edit=  (User) request.getSession().getAttribute("user");
					
					if (user_to_edit == null) {
						response.sendRedirect(response.encodeURL("./login2.jsp"));
						return;
					}

					request.setAttribute("users", userDao.findAll());

					userIdd =  user_to_edit.getId();  //request.getParameter("userId");
					System.out.println("USER TO EDIIIIT: "+userDao.findById(userIdd).getUserName());

					if (userIdd != null) 
						request.setAttribute("user_to_edit", userDao.findById(userIdd));
				 request.setAttribute("msg", 1); 
				 getServletContext().getRequestDispatcher("/change_password.jsp").forward(request, response);
				 return;

		     }

		     else  if(!realPass.equals(oldPass))
		       {
					user_to_edit=  (User) request.getSession().getAttribute("user");
					
					if (user_to_edit == null) {
						response.sendRedirect(response.encodeURL("./login2.jsp"));
						return;
					}

					request.setAttribute("users", userDao.findAll());

				    userIdd =  user_to_edit.getId();  //request.getParameter("userId");
					System.out.println("USER TO EDIIIIT: "+userDao.findById(userIdd).getUserName());

					if (userIdd != null) 
						request.setAttribute("user_to_edit", userDao.findById(userIdd));

		    	   request.setAttribute("msg", 4);
				   getServletContext().getRequestDispatcher("/change_password.jsp").forward(request, response);
		           return;
		       }

		     else if(!pass.equals(confPass))
		      {
					user_to_edit=  (User) request.getSession().getAttribute("user");
					
					if (user_to_edit == null) {
						response.sendRedirect(response.encodeURL("./login2.jsp"));
						return;
					}

					request.setAttribute("users", userDao.findAll());

					userIdd =  user_to_edit.getId();  //request.getParameter("userId");
					System.out.println("USER TO EDIIIIT: "+userDao.findById(userIdd).getUserName());

					if (userIdd != null) 
						request.setAttribute("user_to_edit", userDao.findById(userIdd));       
		    	  request.setAttribute("msg", 5);	  
				  getServletContext().getRequestDispatcher("/change_password.jsp").forward(request, response);
		          return;
		              
		      } 
			
			userId = request.getParameter("id");
			User userCheck= userDao.findById(Integer.parseInt(userId));
			name= userCheck.getUserName();
			surname=userCheck.getUserSurname();
			if ((userId!=null) && (!userId.equals(""))) {
				
				User user= new User();
				
				user.setId(new Integer(userId));
				
				if (name != null)
					user.setUserName(name);
				
				if (surname != null)
					user.setUserSurname(surname);

			
				 
				user.setUserPassword(pass);

				
				User joj= (User) request.getSession().getAttribute("user"); 
				user.setUserUsername(joj.getUserUsername());
				
				userDao.merge(user);
				
				log.info("Password for user  " + user.getUserName() + " updated!");
			}
			

			
			System.out.println("userrrrr...NAME....: "+userCheck.getUserName());
			System.out.println("userrrrr...SURNAME.....: "+userCheck.getUserSurname());
			System.out.println("userrrrr...PASS.....: "+userCheck.getUserPassword());
			System.out.println("userrrrr...ID.....: "+userCheck.getId());
			
			request.setAttribute("userId", userId);
			
			getServletContext().getRequestDispatcher("/user_data_changed.jsp").forward(request, response);
		
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
