<%@ page contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>

<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@ taglib prefix="fmt" uri="http://java.sun.com/jstl/fmt" %>

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
		<title><fmt:message key="editProfile"/></title>
		<meta HTTP-EQUIV="Pragma" CONTENT="no-cache">
		<meta HTTP-EQUIV="Expires" CONTENT="-1">
		<link href="./my.css" rel="stylesheet" type="text/css" />
	</head>
	<c:if test="${sessionScope.user==null}">
		<c:redirect url="./login2.jsp" />
	</c:if>
	<body>
		<form action="./EditProfileController" method="post" enctype="multipart/form-data" accept-charset="ISO-8859-1">
			<table class="editProfileTable">
				<tr>
					<td><fmt:message key="name"/>:</td>
					<td><input type="text" name="name"  value="${user_to_edit.userName}">				
				</tr>
				<tr>
					<td><fmt:message key="surname"/>:</td>
					<td><input type="text" name="surname" value="${user_to_edit.userSurname}">				
				</tr>		
				<tr>			
					<td><fmt:message key="pictureLocation"/>:</td>
					<td> <input type="file"  id="file" name = "uri"><img src="${user_to_edit.userPicture}_thumbnail" alt="#"/><td>
			   </tr>		
			   <tr>
			        <td></td>
			   		<td><input type="hidden" name="pass" value="${user_to_edit.userPassword}"></td>
			   </tr>
				<tr>
					<td><input type="hidden" name="id" value="${user_to_edit.id}"></td>
					<td><input type="submit" name="submit" value="<fmt:message key="change"/>"></td>				
				</tr>
			</table>											
		</form>
		   		<br/>
   				<br/> 				
				[<a href="ShowPostsController"><fmt:message key="backHome"/></a>]<br/>
				<br/>
	</body>	
</html>