<%@ page isErrorPage="true" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>

<%@ taglib prefix="fmt" uri="http://java.sun.com/jstl/fmt" %>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
   
<jsp:useBean id="category" type="rs.ac.uns.ftn.informatika.mbs2.vezbe09.primer01.server.entity.Category" scope="request"/>
<jsp:useBean id="subcategories" type="java.util.List" scope="request"/>

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
		<title><fmt:message key="warn"/></title>
		<link href="./my.css" rel="stylesheet" type="text/css" />
	</head>
	<body>
		 <h4><fmt:message key="remcat1"/> ${category.categoryName}<br/> 
		 <fmt:message key="remcat2"/>:</h4>
<ol>
		 <c:forEach items="${subcategories}" var="sc">
			<li>${sc.categoryName}</li><br/>
		</c:forEach>
</ol>
		<h4><fmt:message key="remcat3"/>: </h4>
<ol>
		 <c:forEach items="${posts}" var="p">
			<li>${p.postTitle}</li><br/>
		</c:forEach>
</ol>		
		 <h4><fmt:message key="remcat4"/>!</h4>
		<br/>
		<br/>
		[<a href="ViewCategoriesController"><fmt:message key="back"/></a>]<br/>
	</body>
</html>	