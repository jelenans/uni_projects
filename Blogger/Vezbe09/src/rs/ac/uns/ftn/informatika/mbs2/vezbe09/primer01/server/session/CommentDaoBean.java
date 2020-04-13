package rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.session;

import java.net.URL;
import java.util.ArrayList;
import java.util.List;

import javax.ejb.Local;
import javax.ejb.Stateless;
import javax.persistence.NamedQuery;
import javax.persistence.NoResultException;
import javax.persistence.Query;
import rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.entity.Comment;
import rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.entity.Post;


@Stateless
@Local(CommentDaoLocal.class)
public class CommentDaoBean extends GenericDaoBean<Comment, Integer> implements CommentDaoLocal {

	@Override
	public List<Comment> findPostComments(Integer post_id) {
		try{			
			Query q = em.createNamedQuery("findPostComments");
			q.setParameter("post_id", post_id);
			System.out.println("POST COMMENTS");
			System.out.println("post_id: "+post_id);
			List<Comment> comments=new ArrayList<Comment>();
			comments=q.getResultList();
			for(Comment c: comments)
			{
				if(c.getPost().getPostTitle()!=null)
					System.out.println("POSSST: "+c.getPost().getPostTitle());
			}

			return q.getResultList();
			
			} catch(NoResultException e) {
				return null;
			}
	}

	

}
