package rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.entity;

import static javax.persistence.CascadeType.ALL;
import static javax.persistence.FetchType.EAGER;
import static javax.persistence.GenerationType.IDENTITY;

import java.io.Serializable;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.List;
import java.util.Date;
import java.util.HashSet;
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
@Table(name = "category")
@NamedQuery(name = "findSubcategories", query = "SELECT o FROM Category o WHERE o.category is not null AND o.category.id LIKE :parent_id")
public class Category implements Serializable {

	private static final long serialVersionUID = 3770759786667844735L;

	@Id
	@GeneratedValue(strategy = IDENTITY)
	@Column(name = "category_id", unique = true, nullable = false)
	private Integer id;

	@Column(name = "category_name", unique = false, nullable = false)
	private String categoryName;
	
	@OneToMany(cascade = { ALL }, fetch = EAGER, mappedBy = "category")
	private Set<Post> posts = new HashSet<Post>();

	@OneToMany(cascade = { ALL }, fetch = EAGER, mappedBy = "category")
	private Set<Category> subcategories = new HashSet<Category>();
	
	public void add(Category c) {
		if (c.getCategory() != null)
			c.getCategory().getSubcategories().remove(c);
		c.setCategory(this);
		subcategories.add(c);
	}

	public void addPost(Post p) {
		if (p.getCategory() != null)
			p.getCategory().getPosts().remove(p);
		p.setCategory(this);
		posts.add(p);
	}
	
	public void remove(Category c) {
		c.setCategory(null);
		subcategories.remove(c);
	}
	
	@ManyToOne
	@JoinColumn(name = "parent_category_id", referencedColumnName = "category_id", nullable = true)
	private Category category;
	
	public Integer getId() {
		return id;
	}

	public void setId(Integer id) {
		this.id = id;
	}

	public String getCategoryName() {
		return categoryName;
	}

	public void setCategoryName(String categoryName) {
		this.categoryName = categoryName;
	}

	public static long getSerialversionuid() {
		return serialVersionUID;
	}
	
	

	public Set<Post> getPosts() {
		return posts;
	}

	public void setPosts(Set<Post> posts) {
		this.posts = posts;
	}

	public Set<Category> getSubcategories() {
		return subcategories;
	}

	public void setSubcategories(Set<Category> subcategories) {
		this.subcategories = subcategories;
	}

	public Category getCategory() {
		return category;
	}

	public void setCategory(Category category) {
		this.category = category;
	}

	public Category() {
		super();
	}

	
	public Category(String categoryName, Category category) {
		super();
		this.categoryName = categoryName;
		this.category = category;
	}

	


	public Category(String categoryName, Set<Category> subcategories) {
		super();
		this.categoryName = categoryName;
		this.subcategories = subcategories;
	}

	public String toString() {
		return "(Category)[id=" + id + ",name=" + categoryName + "]";
	}

}
