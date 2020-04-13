package rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.session;

import java.net.URL;
import java.util.List;

import rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.entity.Category;


public interface CategoryDaoLocal extends GenericDaoLocal<Category, Integer> {

	List<Category> findSubcategories(Integer parent_id);


}
