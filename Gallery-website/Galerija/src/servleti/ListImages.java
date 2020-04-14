package servleti;

import java.io.File;
import java.io.IOException;
import java.io.ObjectOutputStream;
import java.io.PrintWriter;
import java.net.InetAddress;
import java.net.Socket;

import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;



import beans.Galerija;

/**
 * Servlet implementation class ListImages
 */
public class ListImages extends HttpServlet {
	private static final long serialVersionUID = 1L;
    private static final int TCP_PORT = 8081;
    /**
     * @see HttpServlet#HttpServlet()
     */
    public ListImages() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
	//	response.setContentType("text/html");
	//	PrintWriter pout = response.getWriter();
		HttpSession session = request.getSession();
		Galerija galerija = Galerija.getInstance();
		try{
			InetAddress addr = InetAddress.getByName("localhost");
			Socket sock = new Socket(addr, TCP_PORT);
		String files;		
		  File folder = new File(getServletContext().getRealPath("")+ "/files/");
		  File[] listOfFiles = folder.listFiles(); 
		// pout.println("<html><body><ol>");
		  for (int i = 0; i < listOfFiles.length; i++){
			   if (listOfFiles[i].isFile()) {
				   files = listOfFiles[i].getName();
				   Object object = new Object();
								
				   System.out.println(files);
				  
				   ObjectOutputStream outStream = new ObjectOutputStream(sock.getOutputStream());
				   outStream.writeObject(files);

				   sock.close();
				   response.sendRedirect("/Galerija/PregledSvihSlikaServlet");
		//		   pout.println("<li><img src=\"/ImageUpload/files/"+files+"\"></li>");
			   }
		  }
		}catch(Exception e) {
			e.printStackTrace();
		}
	//	  pout.println("</ol></body></html>");
		
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
	}

}
