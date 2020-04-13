<%@ page isErrorPage="true" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>

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
	    <title><fmt:message key="added"/></title>
		<meta HTTP-EQUIV="Pragma" CONTENT="no-cache">
		<meta HTTP-EQUIV="Expires" CONTENT="-1">
		<link href="./my.css" rel="stylesheet" type="text/css" />
	</head>
	<body>
	    <div class="text">
		 <h3><fmt:message key="post"/> ${post} <fmt:message key="okPostadd"/> </h3>
		 </div>
		  <p></p>
		  <p></p>
		 <p>[<a href="/Vezbe09/home.jsp"><fmt:message key="backHome"/></a>]</p>
	</body>
</html>	