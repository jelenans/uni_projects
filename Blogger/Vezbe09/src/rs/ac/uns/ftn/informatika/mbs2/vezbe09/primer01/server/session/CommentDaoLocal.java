package rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.session;

import java.net.URL;
import java.util.List;

import rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.entity.Comment;
import rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.entity.Post;


public interface CommentDaoLocal extends GenericDaoLocal<Comment, Integer> {

	List<Comment> findPostComments(Integer post_id);

}
