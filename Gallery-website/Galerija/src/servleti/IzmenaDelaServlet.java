package servleti;

import java.awt.Image;
import java.awt.image.BufferedImage;
import java.io.File;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.net.InetAddress;
import java.net.Socket;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.GregorianCalendar;
import java.util.HashMap;
import java.util.List;

import javax.imageio.ImageIO;
import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import org.apache.commons.fileupload.FileItem;
import org.apache.commons.fileupload.FileUploadException;
import org.apache.commons.fileupload.disk.DiskFileItemFactory;
import org.apache.commons.fileupload.servlet.ServletFileUpload;
import org.apache.commons.fileupload.servlet.ServletRequestContext;

import beans.Autor;
import beans.Delo;
import beans.MultimedijalniZapis;
import beans.Poruka;
import beans.Skulptura;
import beans.Slika;
import beans.Vrsta;

/**
 * Servlet implementation class IzmenaDelaServlet
 */
public class IzmenaDelaServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
	
	
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

       
	  public static final int TCP_PORT = 9000;
	  String hostname = "localhost";

	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
//
//		 String naslov= request.getParameter("naslov");
//		 String tehnika=request.getParameter("tehnika");
//		 String stil=request.getParameter("stil");
//		 Calendar dat=new GregorianCalendar();
//		 
//			try {
//				dat.setTime((new SimpleDateFormat("mm-dd-yyyy").parse(request.getParameter("datumNastanka"))));
//			} catch (java.text.ParseException e) {
//				// TODO Auto-generated catch block
//				e.printStackTrace();
//			}
//		 String mesto=request.getParameter("mestoNastanka");
//		 String opis=request.getParameter("opis");
//		 String id=request.getParameter("id");
//		 String uri=request.getParameter("uri");
//		 
//
//
//		 String vrsta=request.getParameter("vrsta");
//		 System.out.println("vrsta: "+vrsta);
//		  Poruka poruka = new Poruka();
//		  poruka.setKomanda("IZMENI_DELO");
//
//		  poruka.setObjekat2(vrsta);
//		 
//if(vrsta.equals("slika"))
//{
//	System.out.println("slika");
//	
//	String sir= request.getParameter("sirina");
//	String vis= request.getParameter("visina");
//	
//	double sirina= Double.parseDouble(sir);
//	double visina= Double.parseDouble(vis);
//	
//	Slika s= new Slika(naslov, tehnika, stil, dat, mesto, opis, uri, id, null, sirina, visina);
//	  poruka.setObjekat1(s);
//
//}else if (vrsta.equals("skulptura"))
//{
//	String sir= request.getParameter("sirina");
//	String vis= request.getParameter("visina");
//	String duz= request.getParameter("duzina");
//	System.out.println("duzSKULP:"+duz);
//	double sirina= Double.parseDouble(sir);
//	double visina= Double.parseDouble(vis);
//	
//	double duzina= Double.parseDouble(duz);
//	System.out.println("duzinaaa "+duzina);
//	Skulptura sk= new Skulptura(naslov, tehnika, stil, dat, mesto, opis, uri, id, null, sirina, visina, duzina);
//	  poruka.setObjekat1(sk);
//}else
//{
//	String tr= request.getParameter("trajanje");
//	double trajanje= Double.parseDouble(tr);
//	 String format=request.getParameter("format");
//	 String tip=request.getParameter("tip");
//	 Vrsta audvid;
//	 if(tip.equals("audio"))
//	 {
//		audvid= Vrsta.Audio;
//	 }else{
//		 audvid= Vrsta.Video;
//		 /*String naslov, String tehnika, String stil,
//			Calendar datNast, String mestoNast, String opis, String uri,
//			String id, HashMap<String, Autor> autoriDela, double trajanje, String format,Vrsta vrsta*/
//			MultimedijalniZapis m= new MultimedijalniZapis(naslov, tehnika, stil, dat, mesto, 
//					opis, uri, id, null, trajanje, format, audvid);
//			  poruka.setObjekat1(m);
//	 }
//
//}		 
		 
//		 // odredi adresu racunara sa kojim se povezujemo
//		  InetAddress addr = InetAddress.getByName(hostname);
//
//		  // otvori socket prema drugom racunaru
//		  Socket sock = new Socket(addr, TCP_PORT);
//
//
//		  // inicijalizuj izlazni stream
//		 ObjectOutputStream out= new ObjectOutputStream(sock.getOutputStream());
//		 
//		  // inicijalizuj ulazni stream
//		 ObjectInputStream in= new ObjectInputStream(sock.getInputStream());
//
//
//		  // posalji zahtev
//		  
//		
//		  
//		  out.writeObject(poruka);
//		  
//		  System.out.println("poruka");
//		  // procitaj odgovor
//		  
//			try {
//					Delo odg= (Delo)in.readObject();		
//					String id3= odg.getId();
//				   	request.setAttribute("id3", id3);
//					  in.close();	
//				      out.close();  
//				      sock.close();
//
//						 RequestDispatcher disp = request.getRequestDispatcher("/IzmenjenoDelo.jsp");							
//						 disp.forward(request, response);						 
//					return;
//				
//			} catch (ClassNotFoundException e) {
//				// TODO Auto-generated catch block
//				e.printStackTrace();
//			}
//		
//		
		  //String list = "";
		  //List o = (List)in.readObject();
		  
//	  request.getSession().setAttribute("lista", o);
//	  if (o.getTekst().equals("OK"))
	}

	
	protected void doPost(HttpServletRequest request,
			HttpServletResponse response) throws ServletException, IOException {
		 String naslov="";
		 String tehnika="";
		 String stil="";
		 String datum= "";
				
			
		 String mesto="";
		 String opis="";
		 String id="";
		 String uri="";
		
		 
		 String tr= "";
		 String sir="";
		 String duz="";
		 String vis="";
		 
			String tip= "";
			String format= "";
		 
		 Calendar dat=new GregorianCalendar();
		 
		 HashMap<String, Autor> autoriDela= new HashMap<String, Autor>();
		 String vrsta="";
           
		 
		  Poruka poruka = new Poruka();
		  poruka.setKomanda("IZMENI_DELO");

		Delo d= new Delo();
		
		// enctype="multipart/form-data" !!!!!!!!!!!!!!!!!!!
		
		 String ext = "";
		 
		 ServletRequestContext ctx = new ServletRequestContext(request);
			if(ServletFileUpload.isMultipartContent(ctx)){
			
				// Create a factory for disk-based file items
				DiskFileItemFactory factory = new DiskFileItemFactory();
				// Set factory constraints
				factory.setSizeThreshold(2000000);
				// Create a new file upload handler
				ServletFileUpload upload = new ServletFileUpload(factory);
				// Set overall request size constraint
				upload.setSizeMax(3000000);
				// Parse the request
				try {
					List<FileItem> items = upload.parseRequest(request);
					for (FileItem item : items) {

						String name = item.getFieldName();
						String value = item.getString();
						
						if (item.isFormField())
						{
							if(name.equals("naslov")){
								naslov=value;
								System.out.println("naslov: "+value);
						
							}
							
							if(name.equals("tehnika")){
								tehnika=value;
								System.out.println("teh: "+value);
							
							}
							if(name.equals("stil")){
								stil=value;
								
							}
							if(name.equals("id")){
								id=value;
								
							}
							
							if(name.equals("opis")){
								opis=value;
								
							}
							if(name.equals("mestoNastanka")){
								mesto=value;
								
							}
							if(name.equals("datumNastanka")){
								datum=value;
								System.out.println("dat: "+value);
								
								
									try {
										dat.setTime((new SimpleDateFormat("mm-dd-yyyy").parse(datum)));
									} catch (java.text.ParseException e) {
										// TODO Auto-generated catch block
										e.printStackTrace();
									}
									 d.setDatNast(dat);
							}
							if(name.equals("vrsta")){
								vrsta=value;
								poruka.setObjekat2(vrsta);
								System.out.println("vrsta: "+value);
				
							}

								
								if(name.equals("sirina"))
								{
									sir= value;
								System.out.println("sir: "+value);
								}
								
//								String vis="";
								if(name.equals("visina"))
								{
									vis= value;
							        System.out.println("vis: "+value);
							  }
//								double sirina= Double.parseDouble(sir);
//								double visina= Double.parseDouble(vis);
								
//								Slika s= new Slika(naslov, tehnika, stil, dat, mesto, opis, uri, id, autoriDela, 2,1);
//								  poruka.setObjekat1(s);

								
								if(name.equals("duzina"))
								{
									duz= value;
									 System.out.println("vis: "+value);
								}


								
//								double sirina= Double.parseDouble(sir);
//								double visina= Double.parseDouble(vis);
//								
//								double duzina= Double.parseDouble(duz);
								

								
								if(name.equals("trajanje"))
									tr= value;
							
								if(name.equals("format"))
									format= value;

								if(name.equals("tip"))
									tip= value;
								
//								double trajanje= Double.parseDouble(tr);
							
								

							
						}else{
							String fileName = item.getName();
							String filePath= new String();
//							String fieldName = item.getFieldName();
//							
//							if(ext.equals(""))
//								ext = fileName.substring(fileName.length()-4);

							
							long sizeInBytes = item.getSize();
							int idx = fileName.lastIndexOf("\\");
							if (idx != -1)
								fileName = fileName.substring(idx + 1);
							if (sizeInBytes != 0) {
								System.out.println("<<"
										+ getServletContext().getRealPath("") + ">>");
								
								File uploadedFile = new File(getServletContext().getRealPath("") 
										+"/files/"+ fileName);
								
									//+ request.getParameter("id")+ ext)
								//File f = new File("/data/" + id + "." + ext);
								filePath = uploadedFile.getCanonicalPath();
								System.out.println("<<"
										+ uploadedFile.getCanonicalPath());
								item.write(uploadedFile);

								uri="/Galerija/files/"+ fileName;
								
								saveScaledImage(filePath, getServletContext().getRealPath("") 
										+"/files/"+ fileName+"_thumbnail");
							}
						}
					}
			
				} catch (FileUploadException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
				// Process the uploaded items
				catch (Exception e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
			}

			
			if(vrsta.equals("slika"))
			{
				System.out.println("slika");
				
//				if(name.equals("sirina"))
//					sir= value;
//				System.out.println("sir: "+value);
//				String vis="";
//				if(name.equals("visina"))
//					vis= value;
				
				System.out.println("vis: "+vis);

				System.out.println("sir:" +sir);
//				double sirina= Double.parseDouble(sir);
//				double visina= Double.parseDouble(vis);
				
				Slika s= new Slika(naslov, tehnika, stil, dat, mesto, opis, uri, id, autoriDela,33,44);
				  poruka.setObjekat1(s);

			}else if (vrsta.equals("skulptura"))
			{
				


				
//				double sirina= Double.parseDouble(sir);
//				double visina= Double.parseDouble(vis);
//				
//				double duzina= Double.parseDouble(duz);
				
				Skulptura sk= new Skulptura(naslov, tehnika, stil, dat, mesto, opis, uri, id, autoriDela,1,2,3);
				  poruka.setObjekat1(sk);
			}else
			{
				

				
				//double trajanje= Double.parseDouble(tr);
			
				
				 Vrsta audvid;
				 if(tip.equals("audio"))
				 {
					audvid= Vrsta.Audio;
				 }else{
					 audvid= Vrsta.Video;
				 }
					 /*String naslov, String tehnika, String stil,
						Calendar datNast, String mestoNast, String opis, String uri,
						String id, HashMap<String, Autor> autoriDela, double trajanje, String format,Vrsta vrsta*/
						MultimedijalniZapis m= new MultimedijalniZapis(naslov, tehnika, stil, dat, mesto, 
								opis, uri, id, autoriDela, 34, format, audvid);
						  poruka.setObjekat1(m);
						  
						  System.out.println("multi:" + m.getNaslov());

						  System.out.println("multiID:" + m.getId());
			}
			
			
			 // odredi adresu racunara sa kojim se povezujemo
			  InetAddress addr = InetAddress.getByName(hostname);

			  // otvori socket prema drugom racunaru
			  Socket sock = new Socket(addr, TCP_PORT);


			  // inicijalizuj izlazni stream
			 ObjectOutputStream out= new ObjectOutputStream(sock.getOutputStream());
			 
			  // inicijalizuj ulazni stream
			 ObjectInputStream in= new ObjectInputStream(sock.getInputStream());


			  // posalji zahtev
			  
			
			  
			  out.writeObject(poruka);
			  
			  System.out.println("poruka");
			  // procitaj odgovor
			  
				try {
						Delo odg= (Delo)in.readObject();		
						String id3= odg.getId();
					   	request.setAttribute("id3", id3);
						  in.close();	
					      out.close();  
					      sock.close();

							 RequestDispatcher disp = request.getRequestDispatcher("/IzmenjenoDelo.jsp");							
							 disp.forward(request, response);						 
						return;
					
				} catch (ClassNotFoundException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
			
			
	}

}
