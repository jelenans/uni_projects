<%@ page isErrorPage="true" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>

<%@ taglib prefix="fmt" uri="http://java.sun.com/jstl/fmt" %>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
   

<fmt:setBundle basename="messages.messages"/>

<html>
	<head>
		<title>Data update error</title>
	</head>
	<body>
		 <h3><fmt:message key="errChange"/> ${userId} </h3>
		  <p></p>
		  <p></p>
		 <p>[<a href="/Vezbe09/home_for_registered.jsp"><fmt:message key="backHome"/></a>]</p>
	</body>
</html>	