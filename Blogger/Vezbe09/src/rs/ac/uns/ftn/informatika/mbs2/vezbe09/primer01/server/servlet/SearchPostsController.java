package rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.servlet;

import java.io.IOException;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;

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

public class SearchPostsController extends HttpServlet {

	private static final long serialVersionUID = -6820366488786163882L;
	
	private static Logger log = Logger.getLogger(SearchPostsController.class);


	@EJB
	private CategoryDaoLocal categoryDao;
	
	@EJB
	private PostDaoLocal postDao;
	
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
		try {
			
			String title = null;
			String author = null;
			Date start_date = null;
			Date end_date = null;
			String category = null;
			boolean filter=false;
			List<Object> criterias=new ArrayList<Object>();
			
			if ((request.getParameter("title")!=null)&&(!"".equals(request.getParameter("title")))){
				title = request.getParameter("title");
				//request.getSession().setAttribute("stitle", title);
				criterias.add(title);
			} else
				criterias.add(0);
			
			if ((request.getParameter("author")!=null) && (!"".equals(request.getParameter("author")))){
				author = request.getParameter("author");
				//request.getSession().setAttribute("sauthor", author);
				criterias.add(author);
			} else
				criterias.add(0);
			
			if ((request.getParameter("start_date")!=null)&&(!"".equals(request.getParameter("start_date")))){
				
				   String rdate= request.getParameter("start_date");
				   String[] rdateAr=rdate.split("/");
				   
				   if(rdate!="" && rdateAr.length!=3)
				   {
				     	  request.setAttribute("msg", 7);	
						  getServletContext().getRequestDispatcher("/search_posts.jsp").forward(request, response);	
				           return;
				   }
				   
				try {
					start_date = new SimpleDateFormat("dd/MM/yyyy").parse(request.getParameter("start_date"));
					//request.getSession().setAttribute("sstart_date", start_date);
					criterias.add(start_date);
				} catch (ParseException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
			} else
				criterias.add(new Date());
			
			if ((request.getParameter("end_date")!=null) && (!"".equals(request.getParameter("end_date")))){
				
				   String rdate= request.getParameter("end_date");
				   String[] rdateAr=rdate.split("/");
				   
				   if(rdate!="" && rdateAr.length!=3)
				   {
				     	  request.setAttribute("msg", 7);	
						  getServletContext().getRequestDispatcher("/search_posts.jsp").forward(request, response);	
				           return;
				   }
				try {
					end_date = new SimpleDateFormat("dd/MM/yyyy").parse(request.getParameter("end_date"));
					//request.getSession().setAttribute("send_date", end_date);
					criterias.add(end_date);
				} catch (ParseException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
			} else
				criterias.add(new Date());
			
			if ((request.getParameter("category")!=null) && (!"".equals(request.getParameter("category")))){
				category = request.getParameter("category");
				//request.getSession().setAttribute("scategory", category);
			//	System.out.println("SEARCH CATEGORY:..................."+category);
				criterias.add(category);
			} else
				criterias.add(0);
		
			
			List<Post> posts=new ArrayList<Post>();
			posts= postDao.findAll();
			List<Post> filteredPosts=new ArrayList<Post>();

//			String postTitle = null;
//			String postAuthor = null;
//			String postDate = null;
//			String postCategory = null;
//			System.out.println("STAAAART DATEEE: "+start_date);
//			System.out.println("EEEEEND DATEEE: "+end_date);
			for(Post p: posts)
			{
//				if(p.getPostDate()!=null)
//					System.out.println("POST DATEEE: "+p.getPostDate());
//				else
//					System.out.println("JOOOOOOOOOOOJ");
				if(p.getUser()!=null)
					System.out.println("....AUTOOR "+p.getUser());
				    System.out.println("..AUTOOR FIEEELD "+author);
				if((title!=null && (p.getPostTitle()).equals(title)) || (author!=null && (p.getUser().toString().trim()).equals(author.trim()))
				  || (category!=null && p.getCategory()!=null && (p.getCategory().getCategoryName()).equals(category))|| 
				 (start_date!=null && end_date!=null && 
				 ( (p.getPostDate()).equals(start_date) || (p.getPostDate()).after(start_date) ) && 
				 ( (p.getPostDate()).equals(end_date) || (p.getPostDate()).before(end_date) ) ))
				{
					filter=true;
					System.out.println("AUTOOR "+p.getUser());
				    System.out.println("AUTOOR FIEEELD "+author);
//						  SimpleDateFormat formatter= new SimpleDateFormat("dd/MM/yyyy");
//						  String dateNow = formatter.format(p.getPostDate());

//						  System.out.println("...................................................................");
//
//						  System.out.println("getTime: "+p.getPostDate().toString());
//						  System.out.println("...................................................................");
//						  System.out.println("Now the date is :=>  " + dateNow);
//						  System.out.println("...................................................................");
						  

					filteredPosts.add(p);
					getServletContext().setAttribute("criterias", criterias);
				}
			

			}
			if(filter)
			{
				request.setAttribute("posts", filteredPosts);
			}
			else if( ((request.getParameter("title")==null) || ("".equals(request.getParameter("title"))) ) &&
					( (request.getParameter("author")==null) || ("".equals(request.getParameter("author"))) ) &&
					( (request.getParameter("start_date")==null) ||("".equals(request.getParameter("start_date"))) ) &&
					( (request.getParameter("end_date")==null) || ("".equals(request.getParameter("end_date"))) ) &&	
					( (request.getParameter("category")==null) || ("".equals(request.getParameter("category"))) )	
					)
			{
				      System.out.println("NOTHIIIING");
				        request.setAttribute("posts", posts);
			}
		    else
			{
				   request.setAttribute("posts", filteredPosts);
		    }
			
			
			String sback= (String) request.getAttribute("sback");
			if(sback!=null)
			{
				System.out.println("SBACK NOT NUUUUUUL");
				List<Object> criterias1=new ArrayList<Object>();
				criterias1=  (List<Object>) getServletContext().getAttribute("criterias");

//				for(Object o: criterias1)
//				{
//					System.out.println("critttt: "+o.toString());
//				}
//				System.out.println("category: "+category);
		    if(criterias1!=null && criterias1.size()!=0)
				for(Post pp: posts)
				{
//						if(pp.getPostDate()!=null)
//							System.out.println("POST DATEEE: "+pp.getPostDate());
//						else
//							System.out.println("JOOOOOOOOOOOJ");
//					if(pp.getCategory()!=null)
//						System.out.println("post category: "+pp.getCategory().getCategoryName());
					
						if((criterias1.get(0)!=null && (pp.getPostTitle()).equals(criterias1.get(0))) || (criterias1.get(1)!=null && (pp.getUser().toString().trim()).equals(criterias1.get(1).toString().trim()))
						 || (criterias1.get(2)!=null && criterias1.get(3)!=null && 
						 ( (pp.getPostDate()).equals((Date)criterias1.get(2)) || (pp.getPostDate()).after((Date)criterias1.get(2)) ) && 
						 ( (pp.getPostDate()).equals((Date)criterias1.get(3)) || (pp.getPostDate()).before((Date)criterias1.get(3)) ) )
						 || (criterias1.get(4)!=null && pp.getCategory()!=null && (pp.getCategory().getCategoryName()).equals(criterias1.get(4))) )
						{
							filter=true;
							
//								  SimpleDateFormat formatter= new SimpleDateFormat("dd/MM/yyyy");
//								  String dateNow = formatter.format(p.getPostDate());

//								  System.out.println("...................................................................");
		//
//								  System.out.println("getTime: "+p.getPostDate().toString());
//								  System.out.println("...................................................................");
//								  System.out.println("Now the date is :=>  " + dateNow);
//								  System.out.println("...................................................................");
								  

							filteredPosts.add(pp);
						}

					}
		    if(filter)
			{
				request.setAttribute("posts", filteredPosts);
			} else
				request.setAttribute("posts", posts);
							
			}else
			{
				System.out.println("SBACK NUUUUUUL");
				
			}
			
//			if(filter)
//			{
//				System.out.println("FILTEEEEEEEEEEEEEEEEEEEEEEEEEEEEER");
//				request.setAttribute("posts", filteredPosts);
//			}
//			
		
			
			String pageTipe= "search";
			getServletContext().setAttribute("ppage", pageTipe);
			getServletContext().getRequestDispatcher("/view_posts.jsp").forward(request, response);
		
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