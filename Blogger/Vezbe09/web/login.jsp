<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib prefix="fmt" uri="http://java.sun.com/jstl/fmt" %>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">

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
		<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
		<meta HTTP-EQUIV="Pragma" CONTENT="no-cache">
		<meta HTTP-EQUIV="Expires" CONTENT="-1">
		<link href="./my.css" rel="stylesheet" type="text/css" />
<script  type="text/javascript">
function provera()
{
	   var  username = document.frm.username.value;
       var  password = document.frm.password.value;
     
       if(username=="" && password=="" )
       {
     	  alert("Please enter username and password");	  
           return false;
       }
       else if(username=="")
       {
    	  alert("Please enter username");	  
          return false;
       }
       else if(password=="")
       {
              
    	  alert("Please enter password");	  
              return false;
              
       } 
        return true;
        
}
</script>
		<title><fmt:message key="register"/></title>

	</head>
	<body>
	<c:choose>
	  <c:when test="${msg!=null}">
	    <h3><fmt:message key="regerr"/>:</h3>
	  <c:choose>
	     <c:when test="${msg==1}">
	       <h4><fmt:message key="msg1"/>!</h4>
	     </c:when>     	  
	     <c:otherwise>
	       <h4><fmt:message key="msg2"/>!</h4>
	     </c:otherwise>
	 </c:choose>
	  </c:when>
	</c:choose>
	

		<form name="frm" action="./RegistrationController" method="post" enctype="multipart/form-data" class="registerForm" accept-charset="ISO-8859-1" onsubmit="return provera()">
				<table border="1" style="background-color: gray;">
				<tr>
					<th><fmt:message key="name"/>:</th>
					<td><input type="text" name="name">				
				</tr>
				<tr>
					<th><fmt:message key="surname"/>:</th>
					<td><input type="text" name="surname">				
				</tr>
				<tr>
					<th>*<fmt:message key="username"/>:</th>
					<td><input type="text" name="username">				
				</tr>
				<tr>
					<th>*<fmt:message key="password"/>:</th>
					<td><input type="password" name="password"></td>				
				</tr>
				<tr>			
					<th><fmt:message key="pictureLocation"/>:</th>
					<td><input type="file"  id="file" name = "uri"><td>
			   </tr>
				<tr>
					<td>&nbsp;</td>
					<td><input type="submit" name="submit" value="<fmt:message key="register"/>"></td>				
				</tr>	
				</table>						
		</form>
		
		<br/>
		<br/>
	    [<a href="/Vezbe09/home.jsp"><fmt:message key="back"/></a>]<br/>
	</body>	
</html>