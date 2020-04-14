<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>    

<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<link rel="stylesheet" href="galerijaCss2.css">
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Pregled Autora</title>
</head>
<body>
<c:choose>
 <c:when test="${kustos.logged}">	
<h2>Pregled autora</h2>
<form action="AutoriServlet" method="post">
<div class="lista">
<table border="1">
	<tr>
	<th>id</th><th>ime</th><th>prezime</th><th>datum rođenja</th><th>datum smrti</th><th>mesto rođenja</th>
	<th>mesto smrti</th><th>biografija</th><th>Brisanje</th><th> Izmena </th><th>Pregled dela</th><th>Dodavanje dela</th>
	</tr>
	<c:forEach var="a" items="${autori}">
		<tr>
		
		<td>${a.id} </td>	
		<td>${a.ime}</td>
		<td>${a.prezime}</td>
		<td>${a.datRodjTekstualno}</td>
		<td>${a.datSmrtiTekstualno}</td>
		<td>${a.mestoRodjenja}</td>
		<td>${a.mestoSmrti}</td>
		<td>${a.bio}</td>
		<td>
		<a href="AutoriServlet?brisiLoz=${a.id}">Brisanje</a>
		</td>
		<td>
		<a href="AutoriServlet?izmLoz=${a.id}">Izmena</a>
		</td>
	    <td>
		<a href="DelaAutoraServlet?pregledLoz=${a.id}">Pregled dela</a>
		</td>
	    <td>
		<a href="DelaAutoraServlet?dodajLoz=${a.id}">Dodavanje dela</a>
		</td>

		</tr>
	</c:forEach>
	</table>
	</div>
	</form>
	<br/>
	<br/>
	<div class="lista">
		<a href="/Galerija/kustosMain.jsp">Nazad</a>
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