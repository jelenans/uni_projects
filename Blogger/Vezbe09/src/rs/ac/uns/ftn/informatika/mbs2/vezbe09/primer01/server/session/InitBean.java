package rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.session;

import java.net.MalformedURLException;
import java.net.URL;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Date;

import javax.ejb.Remote;
import javax.ejb.Stateless;
import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;
import javax.xml.registry.infomodel.User;

import rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.entity.Category;
import rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.entity.Post;

@Stateless
@Remote(Init.class)
public class InitBean implements Init {

	@PersistenceContext(unitName = "Vezbe09")
	EntityManager em;
	
	public void init() {
		

		rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.entity.User user= new rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.entity.User("a", "a", "a", "a", null);
		em.persist(user);

		
		Category category= new Category();
		category.setCategoryName("sport");
		em.persist(category);
		
		Category category2= new Category();
		category2.setCategoryName("movie");
		em.persist(category2);
		
		Category category3= new Category();
		category3.setCategoryName("science");
		em.persist(category3);
		
		Category category4= new Category();
		category4.setCategoryName("fashion");
		em.persist(category4);
		
		Post post= new Post();
		post.setPostTitle("post_title1");
		try {
			Date date= new SimpleDateFormat("dd/MM/yyyy").parse("02/02/2011");
			post.setPostDate(date);
		} catch (ParseException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

		post.setPostSummary("post_summary1");
		post.setPostContent("post_content1");
		post.setPostVisitors(0);
		post.setUser(user);
        post.setComments(null);
        post.setCategory(null);
		em.persist(post);
		
		Post post1= new Post();
		post1.setPostTitle("post_title2");
		try {
			Date date1= new SimpleDateFormat("dd/MM/yyyy").parse("03/02/2011");
			post1.setPostDate(date1);
		} catch (ParseException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

		post1.setPostSummary("post_summary2");
		post1.setPostContent("post_content2");
		post1.setPostVisitors(0);
		post1.setUser(user);
        post1.setComments(null);
        post1.setCategory(null);
		em.persist(post1);
		
		Post post2= new Post();
		post2.setPostTitle("post_title3");
		try {
			Date date2= new SimpleDateFormat("dd/MM/yyyy").parse("04/02/2011");
			post2.setPostDate(date2);
		} catch (ParseException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

		post2.setPostSummary("post_summary3");
		post2.setPostContent("post_content3");
		post2.setPostVisitors(0);
		post2.setUser(user);
        post2.setComments(null);
        post2.setCategory(null);
		em.persist(post2);
		
		Post post3= new Post();
		post3.setPostTitle("post_title4");
		try {
			Date date2= new SimpleDateFormat("dd/MM/yyyy").parse("05/02/2011");
			post3.setPostDate(date2);
		} catch (ParseException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

		post3.setPostSummary("post_summary4");
		post3.setPostContent("post_content4");
		post3.setPostVisitors(0);
		post3.setUser(user);
        post3.setComments(null);
        post3.setCategory(null);
		em.persist(post3);
		
		Post post4= new Post();
		post4.setPostTitle("post_title5");
		try {
			Date date2= new SimpleDateFormat("dd/MM/yyyy").parse("06/02/2011");
			post4.setPostDate(date2);
		} catch (ParseException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

		post4.setPostSummary("post_summary5");
		post4.setPostContent("post_content5");
		post4.setPostVisitors(0);
		post4.setUser(user);
        post4.setComments(null);
        post4.setCategory(null);
		em.persist(post4);
		
		Post post5= new Post();
		post5.setPostTitle("post_title6");
		try {
			Date date2= new SimpleDateFormat("dd/MM/yyyy").parse("07/02/2011");
			post5.setPostDate(date2);
		} catch (ParseException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

		post5.setPostSummary("post_summary6");
		post5.setPostContent("post_content6");
		post5.setPostVisitors(0);
		post5.setUser(user);
        post5.setComments(null);
        post5.setCategory(null);
		em.persist(post5);


	}
}
