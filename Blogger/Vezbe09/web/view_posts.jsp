<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="ISO-8859-1"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@ taglib prefix="fmt" uri="http://java.sun.com/jstl/fmt" %>

<jsp:useBean id="posts" type="java.util.List" scope="request"/>
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
	   <title><fmt:message key="posts"/></title>
		<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
		<meta HTTP-EQUIV="Pragma" CONTENT="no-cache">
		<meta HTTP-EQUIV="Expires" CONTENT="-1">
		<link href="./my.css" rel="stylesheet" type="text/css" />
	</head>
	<body>
		<table border="1" style="background-color: gray;">
			<tr>
			<th><fmt:message key="title"/></th>
			<th><fmt:message key="author"/></th>
			<th><fmt:message key="date"/></th>
			<th><fmt:message key="category"/></th>
			<th><fmt:message key="summary"/></th>
			</tr>
			<c:forEach items="${posts}" var="post">
				<tr>
					<td><a href="./ViewPostController?postId=${post.id}&page=${ppage}">${post.postTitle}</a></td>
					<td><input type="text" name="author" value="${post.user.userName} ${post.user.userSurname}" readonly></td>				
					<td><input type="text" name="date" value="${post.dateNow}" readonly></td>				
					<td><input type="text" name="title" value="${post.category.categoryName}" readonly></td>				
					<td><input type="text" name="summary" value="${post.postSummary}" readonly></td>		
				</tr>
				</c:forEach>
		</table>
<br/>
<br/>
  <c:choose>
	  <c:when test="${user!=null}">
	      [<a href="LogoutController?logoff=true"><fmt:message key="logout"/></a>]<br/>
	      [<a href="PrepareEditProfileController"><fmt:message key="editProfile"/></a>]<br/>
		  [<a href="PrepareChangePasswordController"><fmt:message key="changePassword"/></a>]<br/>  
	  </c:when>
	  <c:otherwise>
	       [<a href="LoginController"><fmt:message key="login"/></a>]<br/>
      </c:otherwise>
  </c:choose>
<c:choose>
  	<c:when test="${reg_user==null && user==null}">
       [<a href="/Vezbe09/login.jsp"><fmt:message key="register"/></a>]<br/>
  	</c:when>
</c:choose>	
			
<br/>
<br/>
	[<a href="/Vezbe09/search_posts.jsp"><fmt:message key="back"/></a>]<br/>


	</body>	
</html>