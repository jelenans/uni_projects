<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@ taglib prefix="fmt" uri="http://java.sun.com/jstl/fmt" %>

<jsp:useBean id="post" type="rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.entity.Post" scope="request"/>

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
<script  type="text/javascript">
function provera()
{
	   var  title = document.frm.title.value;
       var  content = document.frm.content.value.trim();
     
       if(title=="" && content==="" )
       {
     	  alert("Please enter comment title and content");	  
           return false;
       }
       else if(title=="")
       {
    	  alert("Please enter comment title");	  
          return false;
       }
       else if(content==="")
       {
              
    	  alert("Please enter comment content");	  
              return false;
              
       } 
        return true;
        
}
</script>
		<title><fmt:message key="comment"/></title>
		<meta HTTP-EQUIV="Pragma" CONTENT="no-cache">
		<meta HTTP-EQUIV="Expires" CONTENT="-1">
		<link href="./my.css" rel="stylesheet" type="text/css" />
	</head>
	<body>
	
	<c:choose>  
	 <c:when test="${msg!=null}">
	    <h3><fmt:message key="comerr"/>:</h3>
	  <c:choose>
	     <c:when test="${msg==1}">
	       <h4><fmt:message key="msg1"/></h4>
	     </c:when>     	  
	 </c:choose>
	  </c:when>
	</c:choose>
		<form name="frm" action="./CommentController" method="post" accept-charset="ISO-8859-1" onsubmit="return provera()">
				<table border="1" style="background-color: gray;">
				<tr>
					<td><fmt:message key="title"/>:</td>
					<td><input type="text" name="title" ></td>			
				</tr>		
				<tr>
					<td><fmt:message key="content"/>:</td>
					<td> 
					<textarea rows="10" cols="25" name = "content">
					</textarea>
					</td>		
				</tr>	
				<tr>
					<td><input type="hidden" name="postId" value="${post.id}"></td>
					<td><input type="submit" name="submit" value="<fmt:message key="comment"/>"></td>				
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
			
	<body>
</html>