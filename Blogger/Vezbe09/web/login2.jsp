<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib prefix="fmt" uri="http://java.sun.com/jstl/fmt" %>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>


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
	   var  username = document.frm.korisnickoIme.value;
       var  password = document.frm.lozinka.value;
     
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
		<title><fmt:message key="login"/></title>
		<meta HTTP-EQUIV="Pragma" CONTENT="no-cache">
		<meta HTTP-EQUIV="Expires" CONTENT="-1">
		<link href="./my.css" rel="stylesheet" type="text/css" />
	
	</head>
	<body>	
	
	<c:choose>
	  <c:when test="${msg!=null}">
	    <h3><fmt:message key="logerr"/>:</h3>
	  <c:choose>
	     <c:when test="${msg==1}">
	       <h4><fmt:message key="msg1"/>!</h4>
	     </c:when>     	  
	     <c:otherwise>
	       <h4><fmt:message key="msg3"/>!</h4>
	     </c:otherwise>
	 </c:choose>
	  </c:when>
	</c:choose>

	
	<c:choose>
	  <c:when test="${logOut!=null && logOut==true}">
	     <c:when test="${user==null}">
	       <h3>Logout successful for user: "${usr.userName} " </h3>
	     </c:when>
	     <c:otherwise>
	       <h3>Logout unsuccessful for user: "${usr.userName} "</h3>
	     </c:otherwise>
	  </c:when>
	</c:choose>
		<form name="frm" action="./LoginController" method="post" class="prijavaForma" accept-charset="ISO-8859-1" onsubmit="return provera()">
				<table border="1" style="background-color: gray;">
				<tr>
					<th>*<fmt:message key="username"/>:</th>
					<td><input type="text" name="korisnickoIme"></td>				
				</tr>
				<tr>
					<th>*<fmt:message key="password"/>:</th>
					<td><input type="password" name="lozinka"></td>				
				</tr>
				<tr>
					<td>&nbsp;</td>
					<td><input type="submit" name="submit" value="<fmt:message key="login"/>"></td>				
				</tr>	
			</table>						
		</form>
		<br/>
		<br/>
		[<a href="ShowPostsController"><fmt:message key="back"/></a>]<br/>
			
	<body>	
</html>