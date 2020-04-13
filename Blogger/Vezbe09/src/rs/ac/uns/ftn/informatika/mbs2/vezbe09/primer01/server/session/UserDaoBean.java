package rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.session;

import java.net.URL;

import javax.ejb.Local;
import javax.ejb.Stateless;
import javax.persistence.NamedQuery;
import javax.persistence.NoResultException;
import javax.persistence.Query;

import rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.entity.User;



@Stateless
@Local(UserDaoLocal.class)
public class UserDaoBean extends GenericDaoBean<User, Integer>
		implements UserDaoLocal {

	@Override
	public User findUserWithUsernameAndPassword(String username,
			String password) {
		try{
		Query q = em.createNamedQuery("findUserWithUsernameAndPassword");
		q.setParameter("username", username);
		q.setParameter("password", password);
		return (User) q.getSingleResult();
		} catch(NoResultException e) {
			return null;
		}
	}

	
	public void insertUser(User user)
	{
		em.persist(user);
		System.out.println("............INSERT USER...........");
	}

}
