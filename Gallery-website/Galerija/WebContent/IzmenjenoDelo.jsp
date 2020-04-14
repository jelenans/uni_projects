<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>    



    
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<link rel="stylesheet" href="galerijaCss2.css">
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Izmena autora</title>
</head>
<body>
<c:choose>
    <c:when test="${kustos.logged}">
<h2>Korisniče ${kustos.ime},</h2>
<c:choose>

  	<c:when test="${id3!=null}">
  	  
  	  <h3>Podaci o delu sa ID: "${id3}" su uspešno izmenjeni!</h3>
  	</c:when>
  	<c:otherwise>
  	  
  	 <h3>Podaci o delu sa ID: "${id3}" nisu uspešno izmenjeni!</h3>
  	</c:otherwise>
</c:choose>
	<div class="lista">
	<a href="/Galerija/kustosMain.jsp">Nazad</a><br/>
	<br/>
    [<a href="LoginServlet?logoff=true">Odjavi se</a>]
    </div>
</c:when>
	<c:otherwise>
		<h3><b>Niste ulogovani!</b></h3>
			<div class="lista">
		<p>
		[<a href="LoginServlet?logoff=true">Logovanje</a>]
		</p>
		</div>
	</c:otherwise>
</c:choose>
</body>
</html>