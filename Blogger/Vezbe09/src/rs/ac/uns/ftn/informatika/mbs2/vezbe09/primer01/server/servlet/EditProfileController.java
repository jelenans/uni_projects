package rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.servlet;

import java.awt.Image;
import java.awt.image.BufferedImage;
import java.io.File;
import java.io.IOException;
import java.util.List;

import javax.ejb.EJB;
import javax.imageio.ImageIO;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import org.apache.commons.fileupload.FileItem;
import org.apache.commons.fileupload.FileUploadException;
import org.apache.commons.fileupload.disk.DiskFileItemFactory;
import org.apache.commons.fileupload.servlet.ServletFileUpload;
import org.apache.log4j.Logger;

import rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.entity.User;
import rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.session.UserDaoLocal;


public class EditProfileController extends HttpServlet {
	
	private static final long serialVersionUID = 4676416691336033321L;
	
	private static Logger log = Logger.getLogger(EditProfileController.class);

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
		String userId="";
		
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
						System.out.println("name: "+value);
				
					} else if(fname.equals("surname")){
						surname=value;
						System.out.println("surname: "+value);
				
					} else if(fname.equals("id"))
					{
						userId=value;
						System.out.println("OMG: "+value);
					}
                }else
					{  
                	
					String fileName = item.getName();
					if(fileName!= null && !fileName.equals(""))
					{
					System.out.println("FILENAMEEE|: "+fileName);
				    String filePath;
				    File uploadedFile = new File(getServletContext().getRealPath("")+"/files/"+ fileName);
				    filePath = uploadedFile.getCanonicalPath();
				    try {
						item.write(uploadedFile);
					} catch (Exception e) {
						e.printStackTrace();
					}
				    saveScaledImage(filePath, getServletContext().getRealPath("") 
							+"/files/"+ fileName+"_thumbnail");
				    uri="/Vezbe09/files/"+ fileName;
                    }
					}

			}
			
		try {
			
			if ((request.getSession().getAttribute("user")) == null) {
				response.sendRedirect(response.encodeURL("./login2.jsp"));
		    	return;
		    }
			
			
		
	
			if ((userId!=null) && (!userId.equals(""))) {
				
				
				System.out.println("(userId!=null) "+userId);
				
				User user= new User();
				
				user.setId(new Integer(userId));
				
				if (name != null)
					user.setUserName(name);
				
				if (surname != null)
					user.setUserSurname(surname);
					
				if (surname != null)
					user.setUserSurname(surname);	
				
				if ((password!=null) && (!password.equals("")))
					user.setUserPassword(password);

				
				// -------------------->USER SET PICTURE!!!!!!!!!
				
				if ((uri!=null) && (!uri.equals("")))		
					user.setUserPicture(uri);
				
				
				User joj= (User) request.getSession().getAttribute("user"); 
				user.setUserUsername(joj.getUserUsername());

				
				userDao.merge(user);
			    log.info("Data for user " + user.getUserName() + " updated!");
			}
			
			User userCheck= userDao.findById(Integer.parseInt(userId));
			
			System.out.println("userrrrr...NAME....: "+userCheck.getUserName());
			System.out.println("userrrrr...SURNAME.....: "+userCheck.getUserSurname());
			System.out.println("userrrrr...PASS.....: "+userCheck.getUserPassword());
			System.out.println("userrrrr...ID.....: "+userCheck.getId());
			
			request.setAttribute("userId", userId);
			
//			if()		
				getServletContext().getRequestDispatcher("/user_data_changed.jsp").forward(request, response);
//			else
//				getServletContext().getRequestDispatcher("/user_data_error.jsp").forward(request, response);
		
		} catch (ServletException e) {
			log.error(e);
			throw e;
		} catch (IOException e) {
			log.error(e);
			throw e;
		}
	}
	
}
