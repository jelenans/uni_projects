<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="ISO-8859-1"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@ taglib prefix="fmt" uri="http://java.sun.com/jstl/fmt" %>

<jsp:useBean id="categories" type="java.util.List" scope="request"/>

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
			<title><fmt:message key="view_categories"/></title>
		<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
		<meta HTTP-EQUIV="Pragma" CONTENT="no-cache">
		<meta HTTP-EQUIV="Expires" CONTENT="-1">
		<link href="./my.css" rel="stylesheet" type="text/css" />
	</head>
	<c:if test="${sessionScope.user==null}">
		<c:redirect url="./login2.jsp" />
	</c:if>
	<body>
			<table border="1" style="background-color: gray;">
				<tr>
					<th><fmt:message key="name"/></th>
					<th><fmt:message key="edit"/></th>
					<th><fmt:message key="remove"/></th>
					<th><fmt:message key="remove"/></th>
				</tr>	
			<c:forEach items="${categories}" var="category">
				<tr>
					<td>${category.categoryName}</td>
					<td><a href="./PrepareEditCategoryController?catId=${category.id}"><fmt:message key="edit"/></a></td>
					<td><a href="./DeleteCategoryController?catId=${category.id}"><fmt:message key="remove"/></a></td>			
                    <td>
						<a href="./PrepareSubCategoriesController?catId=${category.id}"><fmt:message key="subcat"/></a>	
					</td>

				</tr>
				</c:forEach>
		</table>

	<br/>
	<br/>
		
	[<a href="./PrepareAddCategoryController"><fmt:message key="add_cat"/></a>]<br/>
	<br/>

	<a href="/Vezbe09/search_posts.jsp"><fmt:message key="searchposts"/></a><br/>
	<a href="PrepareBrowsePostsController"><fmt:message key="broweposts"/></a><br/>		
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
			
	<c:choose>
	<c:when test="${sub==true}" >
		[<a href="./ViewCategoriesController"><fmt:message key="back"/></a>]<br/>
	</c:when>
	<c:otherwise>
	    [<a href="/Vezbe09/home.jsp"><fmt:message key="back"/></a>]<br/>
	</c:otherwise>
	</c:choose>	
	</body>	
</html>