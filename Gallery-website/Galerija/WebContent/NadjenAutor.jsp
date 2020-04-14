<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>    



    
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<link rel="stylesheet" href="galerijaCss2.css">
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Traženje autora ID</title>
</head>
<c:choose>
    <c:when test="${kustos.logged}">
<body>
<h2>Korisniče ${kustos.ime},</h2>
<c:choose>

  	<c:when test="${autor4!=null}">
  	  
  	  <h3>Autor je uspešno pronađen: </h3>
<form action="AutoriServlet" method="get">
<table border="1">
	<tr>
	<th>id</th><th>ime</th><th>prezime</th><th>datum rođenja</th><th>datum smrti</th><th>mesto rođenja</th>
	<th>mesto smrti</th><th>biografija</th>
	</tr>
	
		<tr>
		
		<td>${autor4.id} </td>	
		<td>${autor4.ime}</td>
		<td>${autor4.prezime}</td>
		<td>${autor4.datRodjTekstualno}</td>
		<td>${autor4.datSmrtiTekstualno}</td>
		<td>${autor4.mestoRodjenja}</td>
		<td>${autor4.mestoSmrti}</td>
		<td>${autor4.bio}</td>
		<td>
		<a href="AutoriServlet?brisiLoz=${autor4.id}">Brisanje</a>
		</td>
		<td>
		<a href="AutoriServlet?izmLoz=${autor4.id}">Izmena</a>
		</td>
		</tr>

</table>
</form>

  	</c:when>
  	<c:otherwise>
  	  
  	 <h3>Autor nije uspešno pronađen!</h3>
  	</c:otherwise>
</c:choose>
	<div class="lista">
	<br/>
	<br/>
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