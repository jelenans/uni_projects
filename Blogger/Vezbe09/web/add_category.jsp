<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>

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
<script  type="text/javascript">
function provera()
{
	   var  name = document.frm.name.value;
     
	   if(name=="")
       {
              
    	  alert("Please enter category name");	  
              return false;
              
       } 
        return true;
        
}
</script>
		<title><fmt:message key="add_cat"/></title>
		<meta HTTP-EQUIV="Pragma" CONTENT="no-cache">
		<meta HTTP-EQUIV="Expires" CONTENT="-1">
		<link href="./my.css" rel="stylesheet" type="text/css" />
	</head>
	<c:if test="${sessionScope.user==null}">
		<c:redirect url="./login2.jsp" />
	</c:if>
	<body>
	
	 <c:choose>  
	     <c:when test="${msg==1}">
	       <h3><fmt:message key="caterr"/>:</h3>
	       <h4><fmt:message key="msg1"/>!</h4>
	     </c:when>     	  
	</c:choose>
		<form name="frm" action="./AddCategoryController" method="post"  accept-charset="ISO-8859-1" onsubmit="return provera()">
				<table border="1" style="background-color: gray;">
				<tr>
					<td>*<fmt:message key="name"/>:</td>
					<td><input type="text" name="name" ></td>			
				</tr>		
				<tr>
					<td><fmt:message key="ucat"/>:</td>
					<td>
						<select name="category">
						<c:forEach items="${categories}" var="category">
							<option value="${category.id}">${category.categoryName}</option>
						</c:forEach>
						    <option value="" selected>
						</select>
					</td>				
				</tr>	
				<tr>
					<td>&nbsp;</td>
					<td><input type="submit" name="submit" value="<fmt:message key="add"/>"></td>				
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