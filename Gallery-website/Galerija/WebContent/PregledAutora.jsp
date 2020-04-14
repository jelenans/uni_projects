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
<h2>Pregled autora</h2>
	<div class="lista">
<form action="AutoriServlet" method="get">
<table border="1">

	<tr>
	<th>id</th><th>ime</th><th>prezime</th><th>datum rođenja</th><th>datum smrti</th><th>mesto rođenja</th>
	<th>mesto smrti</th><th>biografija</th><th>pregled dela</th>
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
		<a href="DelaAutoraServlet?pregledPosLoz=${a.id}">Pregled dela</a>
		</td>
		</tr>
	</c:forEach>
	</table>
	</form>
	<br/>
		<a href="/Galerija/index.html">Nazad na početnu stranicu</a><br/>
</div>
</body>
</html>