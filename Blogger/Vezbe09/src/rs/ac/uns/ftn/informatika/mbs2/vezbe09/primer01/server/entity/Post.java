package rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.entity;

import static javax.persistence.CascadeType.ALL;
import static javax.persistence.FetchType.EAGER;
import static javax.persistence.GenerationType.IDENTITY;

import java.io.Serializable;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.HashSet;
import java.util.List;
import java.util.Set;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.NamedQuery;
import javax.persistence.OneToMany;
import javax.persistence.Table;

@Entity
@Table(name = "post")
@NamedQuery(name = "findPostsByCategory", query = "SELECT o FROM Post o WHERE o.category is not null AND o.category.id LIKE :category_id")
public class Post implements Serializable {

	private static final long serialVersionUID = 3770759786667844735L;

	@Id
	@GeneratedValue(strategy = IDENTITY)
	@Column(name = "post_id", unique = true, nullable = false)
	private Integer id;

	@Column(name = "post_title", unique = false, nullable = false)
	private String postTitle;

	@Column(name = "post_date", unique = false, nullable = false)
	private Date postDate;
	
	private String dateNow;

	@Column(name = "post_summary", unique = true, nullable = false)
	private String postSummary;

	@Column(name = "post_content", unique = false, nullable = false)
	private String postContent;
	
	@Column(name = "post_visitors", unique = false, nullable = true)
	private int postVisitors;

	@ManyToOne
	@JoinColumn(name = "category_id", referencedColumnName = "category_id", nullable = true)
	private Category category;
	
	@ManyToOne
	@JoinColumn(name = "user_id", referencedColumnName = "user_id", nullable = false)
	private User user;
	
	@OneToMany(cascade = { ALL }, fetch = EAGER, mappedBy = "post")
	private Set<Comment> comments = new HashSet<Comment>();
	
	public void addComment(Comment c) {
		comments.add(c);
	}
	
	public Integer getId() {
		return id;
	}

	public void setId(Integer id) {
		this.id = id;
	}

	public String getPostTitle() {
		return postTitle;
	}

	public void setPostTitle(String postTitle) {
		this.postTitle = postTitle;
	}

	public Date getPostDate() {
		return postDate;
	}

	public void setPostDate(Date postDate) {
		this.postDate = postDate;
	}

	public String getPostSummary() {
		return postSummary;
	}

	public void setPostSummary(String postSummary) {
		this.postSummary = postSummary;
	}

	public String getPostContent() {
		return postContent;
	}

	public void setPostContent(String postContent) {
		this.postContent = postContent;
	}

	public int getPostVisitors() {
		return postVisitors;
	}

	public void setPostVisitors(int postVisitors) {
		this.postVisitors = postVisitors;
	}

	public User getUser() {
		return user;
	}

	public void setUser(User user) {
		this.user = user;
	}

	public Category getCategory() {
		return category;
	}

	public void setCategory(Category category) {
		this.category = category;
	}


	public Set<Comment> getComments() {
		return comments;
	}

	public void setComments(Set<Comment> comments) {
		this.comments = comments;
	}

	public Post() {
		super();
	}




	public Post(Integer id, String postTitle, Date postDate,
			String postSummary, String postContent, int postVisitors,
			Category category) {
		super();
		this.id = id;
		this.postTitle = postTitle;
		this.postDate = postDate;
		this.postSummary = postSummary;
		this.postContent = postContent;
		this.postVisitors = postVisitors;
		this.category = category;
	}

	public String toString() {
		return "(Post)[id=" + id + ",title=" + postTitle + "]";
	}
	
	public String getDateNow(){
		
		  SimpleDateFormat formatter= new SimpleDateFormat("dd/MM/yyyy");
		  dateNow = formatter.format(postDate);
		  
		  return dateNow;
	}

	public void addPostVisitor() {
		
		postVisitors++;
	}

}
