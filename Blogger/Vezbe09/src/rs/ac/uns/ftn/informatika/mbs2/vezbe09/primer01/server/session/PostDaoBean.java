package rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.session;

import java.net.URL;
import java.util.ArrayList;
import java.util.List;

import javax.ejb.Local;
import javax.ejb.Stateless;
import javax.persistence.NamedQuery;
import javax.persistence.NoResultException;
import javax.persistence.Query;

import rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.entity.Post;



@Stateless
@Local(PostDaoLocal.class)
public class PostDaoBean extends GenericDaoBean<Post, Integer> implements PostDaoLocal {

	@SuppressWarnings("unchecked")
	@Override
	public List<Post> findPostsByCategory(Integer category_id) {
		try{			
			Query q = em.createNamedQuery("findPostsByCategory");
			q.setParameter("category_id", category_id);
			System.out.println("POST BY CAT");
			System.out.println("category_id: "+category_id);
			List<Post> posts=new ArrayList<Post>();
			posts=q.getResultList();
			for(Post p: posts)
			{
				if(p.getCategory().getCategoryName()!=null)
					System.out.println(": "+p.getCategory().getCategoryName());
			}

			return q.getResultList();
			
			} catch(NoResultException e) {
				return null;
			}
	}

	

}
