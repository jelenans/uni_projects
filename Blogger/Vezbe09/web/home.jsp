<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="ISO-8859-1"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@ taglib prefix="fmt" uri="http://java.sun.com/jstl/fmt" %>

<jsp:useBean id="topposts" type="java.util.List" scope="application"/>
<jsp:useBean id="ssel" type="java.lang.String" scope="application"/>
<jsp:useBean id="ppage" type="java.lang.String" scope="application"/>

<c:choose>  
<c:when test="${lng!=null && lng==1}">  
<fmt:setLocale value="en"/>  
</c:when>  
<c:otherwise>  
<fmt:setLocale value="sr"/>  
</c:otherwise>  
</c:choose> 

<fmt:setBundle basename="messages.messages"/>

<html>
	<head>
		<title><fmt:message key="homepage"/></title>
		<meta HTTP-EQUIV="Pragma" CONTENT="no-cache">
		<meta HTTP-EQUIV="Expires" CONTENT="-1">
		<link href="./my.css" rel="stylesheet" type="text/css" />
	</head>
	<body>
		<h2><fmt:message key="homepage"/></h2>
		<c:choose>
	  	<c:when test="${regu!=null}">
	       	<h5><fmt:message key="regsucc"/>: "${regu}" !</h5>
	  	</c:when>
	  	<c:otherwise>
        	<c:choose>
	 			 <c:when test="${ reg_user==null && logOut==null && logIn==null && reg!=null}">
	  	       		<h5><fmt:message key="regunsucc"/>!</h5>
	 			 </c:when>
	  		</c:choose>
	 	 </c:otherwise>
	  </c:choose>
	  
	   <c:choose>
	    <c:when test="${ reg_user==null && logOut!=null && logOut==true && user==null}">
	       <h5><fmt:message key="logsucc"/>: "${usr.userName} " !</h5>
	    </c:when>
		<c:otherwise>
        	<c:choose>
        		 <c:when test="${ reg_user==null && logOut!=null && logOut==false}">
	       			<h5><fmt:message key="logunsucc"/>: "${usr.userName}"!</h5>
	 			 </c:when>
	  		</c:choose>
	 	 </c:otherwise>
	  </c:choose>
	<form action="./ShowPostsController" method="get" accept-charset="ISO-8859-1">		
			<fmt:message key="show_posts"/>:
			<select name="criteria">
    			<option value="date" <c:if test='${ssel=="date"}'> selected </c:if> ><fmt:message key="pdate"/></option>
    			<option value="comment"  <c:if test='${ssel=="comment"}'> selected </c:if>><fmt:message key="pcomment"/></option>
   			    <option value="visit"  <c:if test='${ssel=="visit"}'> selected </c:if>><fmt:message key="pvisit"/></option>
			</select>
			<input type="submit" name="submit" value="<fmt:message key="pshow"/>">
	</form>
<ul>
	<c:forEach items="${topposts}" var="post">
		<li><a href="./ViewPostController?postId=${post.id}&page=${ppage}">${post.postTitle}</a></li>
	</c:forEach>
</ul>


<br/>
<br/>

	<a href="/Vezbe09/search_posts.jsp"><fmt:message key="searchposts"/></a><br/>
	<a href="PrepareBrowsePostsController"><fmt:message key="broweposts"/></a><br/>
<c:choose>
  	<c:when test="${reg_user!=null || user!=null}" >
      	<a href="PreparePostController"><fmt:message key="posting"/></a><br/>	
	    <a href="ViewCategoriesController"><fmt:message key="viewcat"/></a><br/>
<br/>
<br/>
	      [<a href="PrepareEditProfileController"><fmt:message key="editProfile"/></a>]<br/>
		  [<a href="PrepareChangePasswordController"><fmt:message key="changePassword"/></a>]<br/>  
	  </c:when>
  </c:choose>
<br/>
<br/>
 <c:choose>
	      <c:when test="${user==null}">
	      [<a href="/Vezbe09/login2.jsp"><fmt:message key="login"/></a>]<br/>
	      </c:when>
          <c:otherwise>
	       [<a href="LogoutController?logoff=true"><fmt:message key="logout"/></a>]<br/> 
          </c:otherwise>
 </c:choose>	  
<c:choose>
  	<c:when test="${reg_user==null && user==null}">
       [<a href="/Vezbe09/login.jsp"><fmt:message key="register"/></a>]<br/>
  	</c:when>
</c:choose>
<br/>
<br/>
<a href="RssController">RSS feed</a><br/>
<br/>
<fmt:message key="chlng"/>
<c:choose>  
<c:when test="${lng!=null && lng==1}">  
<a href="LanguageController?srb=true"><fmt:message key="srpski"/></a><br/>
</c:when>  
<c:otherwise>  
<a href="LanguageController?eng=true"><fmt:message key="eng"/></a>
</c:otherwise>  
</c:choose> 
</body>	
</html>