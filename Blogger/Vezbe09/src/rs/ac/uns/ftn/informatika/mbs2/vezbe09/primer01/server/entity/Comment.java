package rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.entity;

import static javax.persistence.GenerationType.IDENTITY;

import java.io.Serializable;
import java.text.SimpleDateFormat;
import java.util.Date;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.NamedQuery;
import javax.persistence.Table;

@Entity
@Table(name = "comment")
@NamedQuery(name = "findPostComments", query = "SELECT o FROM Comment o WHERE o.post.id LIKE :post_id")
public class Comment implements Serializable {

	private static final long serialVersionUID = 3770759786667844735L;

	@Id
	@GeneratedValue(strategy = IDENTITY)
	@Column(name = "comment_id", unique = true, nullable = false)
	private Integer id;

	@Column(name = "comment_title", unique = false, nullable = false)
	private String commentTitle;

	@Column(name = "comment_date", unique = false, nullable = false)
	private Date commentDate;

	private String dateNow;
	
	@Column(name = "comment_content", unique = false, nullable = false)
	private String commentContent;

	@ManyToOne
	@JoinColumn(name = "user_id", referencedColumnName = "user_id", nullable = true)
	private User user;
		
	@ManyToOne
	@JoinColumn(name = "post_id", referencedColumnName = "post_id", nullable = false)
	private Post post;
	
	public Post getPost() {
		return post;
	}

	public void setPost(Post post) {
		this.post = post;
	}

	public User getUser() {
		return user;
	}

	public void setUser(User user) {
		this.user = user;
	}

	public Integer getId() {
		return id;
	}

	public void setId(Integer id) {
		this.id = id;
	}
	
	public String getCommentTitle() {
		return commentTitle;
	}

	public void setCommentTitle(String commentTitle) {
		this.commentTitle = commentTitle;
	}

	public Date getCommentDate() {
		return commentDate;
	}

	public void setCommentDate(Date commentDate) {
		this.commentDate = commentDate;
	}

	public String getCommentContent() {
		return commentContent;
	}

	public void setCommentContent(String commentContent) {
		this.commentContent = commentContent;
	}

	public static long getSerialversionuid() {
		return serialVersionUID;
	}

	public Comment() {
		super();
	}


	public Comment(Integer id, String commentTitle, Date commentDate,
			String commentContent) {
		super();
		this.id = id;
		this.commentTitle = commentTitle;
		this.commentDate = commentDate;
		this.commentContent = commentContent;
	}

	public String toString() {
		return "(Comment)[id=" + id + ",title=" + commentTitle + "]";
	}

	public String getDateNow(){
		
		  SimpleDateFormat formatter= new SimpleDateFormat("dd/MM/yyyy");
		  dateNow = formatter.format(commentDate);
		  
		  return dateNow;
	}
}
