package rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.servlet;

import java.awt.Image;
import java.awt.image.BufferedImage;
import java.io.File;
import java.io.IOException;
import java.net.MalformedURLException;
import java.net.URL;
import java.util.List;

import javax.ejb.EJB;
import javax.ejb.EJBException;
import javax.imageio.ImageIO;
import javax.persistence.NoResultException;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import org.apache.log4j.Logger;

import rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.entity.User;
import rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.session.UserDaoLocal;
import org.apache.commons.fileupload.FileItem;
import org.apache.commons.fileupload.FileUploadException;
import org.apache.commons.fileupload.disk.DiskFileItemFactory;
import org.apache.commons.fileupload.servlet.ServletFileUpload;



public class RegistrationController extends HttpServlet {

	private static final long serialVersionUID = -7345471861052209628L;
	
	private static Logger log = Logger.getLogger(RegistrationController.class);
 
	private static final String UPLOAD_DIRECTORY = "upload";
    private static final int THRESHOLD_SIZE = 1024 * 1024 * 3; // 3MB
    private static final int REQUEST_SIZE = 1024 * 1024 * 50; // 50MB

	@EJB
	private UserDaoLocal userDao;
	
	private  void saveScaledImage(String filePath,String outputFile){
	    try {

	        BufferedImage sourceImage = ImageIO.read(new File(filePath));
	        int width = sourceImage.getWidth();
	        int height = sourceImage.getHeight();

	        if(width>height){
	            float extraSize=    height-50;
	            float percentHight = (extraSize/height)*50;
	            float percentWidth = width - ((width/50)*percentHight);
	            BufferedImage img = new BufferedImage((int)percentWidth, 50, BufferedImage.TYPE_INT_RGB);
	            Image scaledImage = sourceImage.getScaledInstance((int)percentWidth, 50, Image.SCALE_SMOOTH);
	            img.createGraphics().drawImage(scaledImage, 0, 0, null);
	            BufferedImage img2 = new BufferedImage(50, 50 ,BufferedImage.TYPE_INT_RGB);
	            img2 = img.getSubimage((int)((percentWidth-50)/2), 0, 50, 50);

	            ImageIO.write(img2, "jpg", new File(outputFile));    
	        }else{
	            float extraSize=    width-50;
	            float percentWidth = (extraSize/width)*50;
	            float  percentHight = height - ((height/50)*percentWidth);
	            BufferedImage img = new BufferedImage(50, (int)percentHight, BufferedImage.TYPE_INT_RGB);
	            Image scaledImage = sourceImage.getScaledInstance(50,(int)percentHight, Image.SCALE_SMOOTH);
	            img.createGraphics().drawImage(scaledImage, 0, 0, null);
	            BufferedImage img2 = new BufferedImage(50, 50 ,BufferedImage.TYPE_INT_RGB);
	            img2 = img.getSubimage(0, (int)((percentHight-50)/2), 50, 50);

	            ImageIO.write(img2, "jpg", new File(outputFile));
	        }
	        
	    }catch (Exception e) {
				// TODO: handle exception
		}
	 }

	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {

	
	}

	protected void doPost(HttpServletRequest request, 	HttpServletResponse response) throws ServletException, IOException {
		
		String name = "";
		String surname = "";
		String username = "";
		String password = "";
		String uri="";
		
        DiskFileItemFactory factory = new DiskFileItemFactory();
        factory.setSizeThreshold(THRESHOLD_SIZE);
        factory.setRepository(new File(System.getProperty("java.io.tmpdir")));
         
        ServletFileUpload upload = new ServletFileUpload(factory);
        upload.setSizeMax(REQUEST_SIZE);

			List<FileItem> items = null;
			
			try {
				items = upload.parseRequest(request);
			} catch (FileUploadException e1) {
				e1.printStackTrace();
			}
			for (FileItem item : items) {

                if (item.isFormField())
                {
					String fname = item.getFieldName();
					String value = item.getString();
                	if(fname.equals("name")){
						name=value;
				
					} else if(fname.equals("surname")){
						surname=value;
				
					}  else if(fname.equals("username")){
						username=value;
				
					} else if(fname.equals("password")){
						password=value;				
					} 
                	
                }else{  
                	
					String fileName = item.getName();
					if(fileName!= null && !fileName.equals(""))
					{
				    String filePath;
				    File uploadedFile = new File(getServletContext().getRealPath("")+"/files/"+ fileName);
				    filePath = uploadedFile.getCanonicalPath();

				    try {
						item.write(uploadedFile);
					} catch (Exception e) {
						e.printStackTrace();
					}
				    saveScaledImage(filePath, getServletContext().getRealPath("")+"/files/"+ fileName+"_thumbnail");
				    uri="/Vezbe09/files/"+ fileName;
                    }

					}

			}
			
			try {
				
				if ((username == null) || (username.equals("")) || (password == null) || (password.equals(""))) {
				    int msg=1;
					request.setAttribute("msg", msg);
					getServletContext().getRequestDispatcher("/login.jsp").forward(request, response);
					return;
				}
				System.out.println("........................REGISTRATION");		
				
				User usr=userDao.findUserWithUsernameAndPassword(username, password);			
				
				if(usr!=null)
				{
					request.setAttribute("msg", 2);
					getServletContext().getRequestDispatcher("/login.jsp").forward(request, response);
					return;
				}
				else
				{
				User user= new User(name,surname,username,password,uri);
				userDao.insertUser(user);

				User usr2=userDao.findUserWithUsernameAndPassword(user.getUserUsername(), user.getUserPassword());
				if (usr2 != null) {	
					System.out.println(".......USER!=null..............");
					if(usr2.getUserPicture()!=null)
					   System.out.println("....................................url: "+usr2.getUserPicture());
					HttpSession session = request.getSession(true);
					log.info("User " + usr2.getUserName() + " registered!");
					request.getSession().setAttribute("reg_user", usr2.getUserUsername());
					request.setAttribute("reg", 1);
					request.setAttribute("regu", usr2.getUserUsername());
					getServletContext().getRequestDispatcher("/home.jsp").forward(request, response);
				}
				}
				
			} catch (EJBException e) {
				if (e.getCause().getClass().equals(NoResultException.class)) {
					response.sendRedirect(response.encodeRedirectURL("./login.jsp"));
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
}