package rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.session;

import java.net.URL;

import rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.entity.User;





public interface UserDaoLocal extends GenericDaoLocal<User, Integer> {

	public User findUserWithUsernameAndPassword(
			String korisnickoIme, String lozinka);
	
	public void insertUser(User user);

}
