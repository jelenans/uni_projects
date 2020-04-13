package rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.entity;

import static javax.persistence.CascadeType.ALL;
import static javax.persistence.FetchType.EAGER;
import static javax.persistence.GenerationType.IDENTITY;

import java.io.Serializable;
import java.net.URL;
import java.util.ArrayList;
import java.util.HashSet;
import java.util.List;
import java.util.Set;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.Id;
import javax.persistence.NamedQueries;
import javax.persistence.NamedQuery;
import javax.persistence.OneToMany;
import javax.persistence.Table;

@Entity
@Table(name = "user")
@NamedQuery(name = "findUserWithUsernameAndPassword", query = "SELECT k FROM User k WHERE k.userUsername like :username AND k.userPassword LIKE :password")
public class User implements Serializable {

	private static final long serialVersionUID = 3770759786667844735L;

	@Id
	@GeneratedValue(strategy = IDENTITY)
	@Column(name = "user_id", unique = true, nullable = false)
	private Integer id;

	@Column(name = "user_name", unique = false, nullable = false)
	private String userName;

	@Column(name = "user_surname", unique = false, nullable = false)
	private String userSurname;

	@Column(name = "user_username", unique = true, nullable = false)
	private String userUsername;

	@Column(name = "user_password", unique = false, nullable = false)
	private String userPassword;
	
	@Column(name = "user_picture", unique = false, nullable = true)
	private String userPicture;
	
	@OneToMany(cascade = { ALL }, fetch = EAGER, mappedBy = "user")
	private Set<Post> posts = new HashSet<Post>();
	
	@OneToMany(cascade = { ALL }, fetch = EAGER, mappedBy = "user")
	private Set<Comment> comments = new HashSet<Comment>();

	public Integer getId() {
		return id;
	}

	public void setId(Integer id) {
		this.id = id;
	}

	public String getUserName() {
		return userName;
	}

	public void setUserName(String userName) {
		this.userName = userName;
	}

	public String getUserSurname() {
		return userSurname;
	}

	public void setUserSurname(String userSurname) {
		this.userSurname = userSurname;
	}

	public String getUserUsername() {
		return userUsername;
	}

	public void setUserUsername(String userUsername) {
		this.userUsername = userUsername;
	}

	public String getUserPassword() {
		return userPassword;
	}

	public void setUserPassword(String userPassword) {
		this.userPassword = userPassword;
	}

	

	public Set<Post> getPosts() {
		return posts;
	}

	public void setPosts(Set<Post> posts) {
		this.posts = posts;
	}

	public Set<Comment> getComments() {
		return comments;
	}

	public void setComments(Set<Comment> comments) {
		this.comments = comments;
	}



	public String getUserPicture() {
		return userPicture;
	}

	public void setUserPicture(String userPicture) {
		this.userPicture = userPicture;
	}

	public User() {
		super();
	}

	public User(String imeKorisnika, String prezimeKorisnika, String korisnickoImeKorisnika, String lozinkaKorisnika, String picture) {
		super();
		this.userName = imeKorisnika;
		this.userUsername = korisnickoImeKorisnika;
		this.userPassword = lozinkaKorisnika;
		this.userSurname = prezimeKorisnika;
		this.userPicture=picture;
	}

	public String toString() {
		return userName+" "+userSurname;
	}

}
