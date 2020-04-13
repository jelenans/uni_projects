package rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.session;

import java.net.URL;
import java.util.ArrayList;
import java.util.List;

import javax.ejb.Local;
import javax.ejb.Stateless;
import javax.persistence.NamedQuery;
import javax.persistence.NoResultException;
import javax.persistence.Query;

import rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.entity.Category;
import rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.entity.User;

@Stateless
@Local(CategoryDaoLocal.class)
public class CategoryDaoBean extends GenericDaoBean<Category, Integer> implements CategoryDaoLocal {

	@SuppressWarnings("unchecked")
	@Override
	public List<Category> findSubcategories(Integer parent_id) {
		try{
		Query q = em.createNamedQuery("findSubcategories");
		q.setParameter("parent_id", parent_id);
		System.out.println("AAAAAAAAA");
		System.out.println("parent_id: "+parent_id);
		List<Category> subcat=new ArrayList<Category>();
		subcat=q.getResultList();
		for(Category cat: subcat)
		{
			if(cat.getCategory().getCategoryName()!=null)
				System.out.println("cat: "+cat.getCategory().getCategoryName());
		}

		return q.getResultList();
		
		} catch(NoResultException e) {
			return null;
		}
	}
	
//	public ArrayList<String> getCategoryNames() {
//		// TODO
//		// Couldn't get Distinct to work below to so I am manually filtering the
//		// records for now.
//		HashSet<String> set = new HashSet<String>();
//
//		ArrayList<String> list = new ArrayList<String>();
//
//		PersistenceManager pm = PMF.getPersistenceManager();
//		Query query = pm.newQuery(CourseDataBean.class);
//		query.setResult("distinct category");
//		List<String> results = (List<String>) query.execute();
//		for (String s : results)
//			set.add(s);
//
//		list.addAll(set);
//
//		return list;
//
//	}

}
