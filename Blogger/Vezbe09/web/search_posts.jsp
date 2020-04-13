<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>

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
		<title><fmt:message key="search_post"/></title>
		<meta HTTP-EQUIV="Pragma" CONTENT="no-cache">
		<meta HTTP-EQUIV="Expires" CONTENT="-1">
		<link href="./my.css" rel="stylesheet" type="text/css" />

<script  type="text/javascript">
function provera(){
	
	var  rdate = document.frm.start_date.value;
    var rdateAr=sdate.split("/");
   if(rdate!="" && rdateAr.length!=3)
   {
           alert("Unesite datum u formatu: dd/mm/yyyy ");
           document.frm.start_date.value="";
           document.frm.start_date.focus();
           return false;
   }
   var  sdate = document.frm.end_date.value;
   var sdateAr=sdate.split("/");
   
  if(sdate!="" && sdateAr.length!=3)
  {
          alert("Unesite datum u formatu: dd/mm/yyyy ");
          document.frm.end_date.value="";
          document.frm.end_date.focus();
          return false;
  }
  
  return true;
}
        
}
</script>
	</head>
	<body>
	
	 <c:choose>  
	 <c:when test="${msg!=null}">
	    <h3><fmt:message key="daterr"/>:</h3>
	  <c:choose>
	     <c:when test="${msg==7}">
	       <h4><fmt:message key="msg7"/>!</h4>
	     </c:when>     	  
	 </c:choose>
	  </c:when>
	</c:choose>
	
	<div class="text">
	<h3><fmt:message key="hsearch_posts"/>:</h3>
	</div>
		<form name="frm" action="./SearchPostsController" method="post" onSubmit="return provera()" accept-charset="ISO-8859-1">
			<table border="1" style=" background-color: gray;">
				<tr>
					<th><fmt:message key="title"/>:</th>
					<td><input type="text" name="title" ></td>			
				</tr>
				<tr>
					<th><fmt:message key="author"/>:</th>
					<td><input type="text" name="author" ></td>				
				</tr>
				<tr>
				<th rowspan="2"><fmt:message key="btw_date"/>:<BR><fmt:message key="date_format"/></th>
				<td><fmt:message key="start_date"/>:<input type="text" name="start_date" ></td>
				</tr>
				<tr>
					<td><fmt:message key="end_date"/>: <input type="text" name="end_date" ></td>
				</tr>			
				<tr>
					<th><fmt:message key="category"/>:</th>
					<td><input type="text" name="category" ></td>			
				</tr>				
				<tr>
					<td>&nbsp;</td>
					<td><input type="submit" name="submit" value="<fmt:message key="search"/>"></td>				
				</tr>
			</table>						
		</form>

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
				[<a href="ShowPostsController"><fmt:message key="back"/></a>]<br/>
				<br/>
	<body>
</html>