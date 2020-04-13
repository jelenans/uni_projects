<%@ page isErrorPage="true" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>

<%@ taglib prefix="fmt" uri="http://java.sun.com/jstl/fmt" %>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
   

<fmt:setBundle basename="messages.messages"/>

<html>
	<head>
		<title>Reg</title>
	</head>
	<body>
		 <h3>User "${user.userName} ", you are already logged</h3>
		 <p>[<a href="LogoutController?logoff=true">Logout</a>]</p>
		 <p>[<a href="/Vezbe09/home.jsp">Return to homepage</a>]</p>
	</body>
</html>	