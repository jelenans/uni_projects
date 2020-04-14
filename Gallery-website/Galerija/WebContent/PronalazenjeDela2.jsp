<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
    
      <%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<link rel="stylesheet" href="galerijaCss2.css">
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Nadji delo</title>
</head>
<body>
<c:choose>
    <c:when test="${kustos.logged}">
    	<div class="lista">
<form method="get" action="NadjiDelo2Servlet">
  
	<h2>		
  Pronalaženje dela na osnovu: naslova dela, <br/>
   tehnike, stila i imena i prezimena autora<br/> 
   <br/>
   </h2>
   <br/>
   <h3>
   Unesite vrednost za pretragu:<br/>
	</h3>
   <input type="text" name="vrednost"><br/>
   <input type = "submit" value = "Potvrdi"/>

<br/>
<br/>
</form>
<a href="/Galerija/kustosMain.jsp">Nazad</a><br/>
<br/>
[<a href="LoginServlet?logoff=true">Odjavi se</a>]
</div>
</c:when>
	<c:otherwise>
		<div class="lista">
		<h3><b>Niste ulogovani!</b></h3>
		<p>
		[<a href="LoginServlet?logoff=true">Logovanje</a>]
		</p>
		</div>
	</c:otherwise>
</c:choose>
</body>
</html>