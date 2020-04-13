package rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.session;

import java.net.URL;
import java.util.List;

import rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.entity.Post;

public interface PostDaoLocal extends GenericDaoLocal<Post, Integer> {

	List<Post> findPostsByCategory(Integer category_id);
}
