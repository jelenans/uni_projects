<%@ page contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>

<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@ taglib prefix="fmt" uri="http://java.sun.com/jstl/fmt" %>

<jsp:useBean id="category" type="rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.entity.Category" scope="request"/>
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
		<title><fmt:message key="edit_category"/></title>
		<meta HTTP-EQUIV="Pragma" CONTENT="no-cache">
		<meta HTTP-EQUIV="Expires" CONTENT="-1">
		<link href="./my.css" rel="stylesheet" type="text/css" />
	</head>
	<c:if test="${sessionScope.user==null}">
		<c:redirect url="./login2.jsp" />
	</c:if>
	<body>
		<form action="./EditCategoryController" method="post" class="promenaVozilaForma" accept-charset="ISO-8859-1">
			<table class="promenaVozilaTabela">
				<tr>
					<td><fmt:message key="name"/>:</td>
					<td><input type="text" name="name" value="${category.categoryName}"></td>			
				</tr>
				<tr>
					<td><input type="hidden" name="id" value="${category.id}"></td>
					<td><input type="submit" name="submit" value="<fmt:message key="promeni"/>"></td>				
				</tr>
			</table>											
		</form>
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
			
	</body>	
</html>