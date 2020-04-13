<%@ page contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>

<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@ taglib prefix="fmt" uri="http://java.sun.com/jstl/fmt" %>

<jsp:useBean id="post" type="rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.entity.Post" scope="request"/>
<jsp:useBean id="comments" type="java.util.List" scope="request"/>



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
		<title><fmt:message key="post"/></title>
		<meta HTTP-EQUIV="Pragma" CONTENT="no-cache">
		<meta HTTP-EQUIV="Expires" CONTENT="-1">
		<link href="./my.css" rel="stylesheet" type="text/css" />
	</head>
	<body>
			<table border="1" style=" background-color: gray;">
				<tr>
					<th><fmt:message key="title"/>:</th>
					<td><input type="text" name="title" value="${post.postTitle}" readonly style="width: 179px; "></td>			
				</tr>
				<tr>
					<th colspan="2"><fmt:message key="author"/>:</th>
				</tr>
				<tr>
					<td colspan="2"><input type="text" name="author" value="${post.user.userName} ${post.user.userSurname}" readonly>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="${post.user.userPicture}"><img src="${post.user.userPicture}_thumbnail" alt="#" style="height: 29px; "/></a>&nbsp;</td>
				</tr>	
				<tr>
					<th><fmt:message key="date"/>:</th>
					<td><input type="text" name="date" value="${post.dateNow}" readonly style="width: 179px; "></td>				
				</tr>	
				<tr>
					<th><fmt:message key="category"/>:</th>
					<td><input type="text" name="categoryName" value="${post.category.categoryName}" readonly style="width: 179px; "></td>		
				</tr>
			    <tr>
					<th><fmt:message key="summary"/>:</th>
					<td><input type="text" name="summary" value="${post.postSummary}" readonly style="width: 179px; "></td>				
				</tr>
				<tr>
					<th><fmt:message key="content"/>:</th>
					<td> 
					<textarea rows="10" cols="25" name = "content" readonly style="width: 179px; ">
						${post.postContent}
					</textarea>
					</td>
				</tr>	
				<tr>
					<td colspan="2"></td>		
				</tr>	
				<tr>
					<th colspan="2"><fmt:message key="comments"/>:</th>		
				</tr>	
				<c:forEach items="${comments}" var="comment">
				<tr>
				<td colspan="2">${comment.commentTitle}</td>
	     		</tr>
	     		<tr>
	     		<td colspan="2">
					<textarea rows="10" cols="31" name = "comContent" readonly>
						${comment.commentContent}
					</textarea>
				</td>
				</tr>
				<tr>
				<td colspan="2">${comment.dateNow}</td>
				</tr>
				</c:forEach>							
			</table>		
				<br/>
				[<a href="PrepareCommentController?postId=${post.id}"><fmt:message key="addcom"/></a>]<br/>
<br/>
<br/>
  <c:choose>
	  <c:when test="${user!=null}">
	      [<a href="LogoutController?logoff=true"><fmt:message key="logout"/></a>]<br/>
	      [<a href="PrepareEditProfileController"><fmt:message key="editProfile"/></a>]<br/>
		  [<a href="PrepareChangePasswordController"><fmt:message key="changePassword"/></a>]<br/>  
	  </c:when>
	  <c:otherwise>
	       [<a href="/Vezbe09/login2.jsp"><fmt:message key="login"/></a>]<br/>
      </c:otherwise>
  </c:choose>
<c:choose>
  	<c:when test="${reg_user==null && user==null}">
       [<a href="/Vezbe09/login.jsp"><fmt:message key="register"/></a>]<br/>
  	</c:when>
</c:choose>	
			
   				 
   				<br/>
   				<br/>
				[<a href="BackController?page=${pageId}&category=${post.category.id}"><fmt:message key="back"/></a>]<br/>
				<br/>				

	<body>
</html>