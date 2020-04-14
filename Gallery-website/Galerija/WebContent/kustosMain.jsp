<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>    



<html>
<head>
<link rel="stylesheet" href="galerijaCss2.css">
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">

<title>Pocetna</title>
</head>
<body>
<c:choose>
    <c:when test="${kustos.logged}">
<h2>Dobrodošli ${kustos.ime} ! </h2>
<div class="lista">
<ol>
	<li><a href="/Galerija/DodavanjeAutora.jsp">Dodavanje podataka o autoru</a></li>
	<li><a href="/Galerija/VrstaDela.jsp">Dodavanje podataka o umetničkom delu</a></li>
	<li><a href="AutoriServlet">Izmena podataka o autoru</a></li>
	<li><a href="DelaServlet">Izmena podataka o umetničkom delu</a></li>
	<li><a href="AutoriServlet">Brisanje podataka o autoru</a></li>
	<li><a href="DelaServlet">Brisanje podataka o umetničkom delu</a></li>
	<li><a href="/Galerija/PronalazenjeDelaID.jsp">Pronalaženje dela na osnovu ID-a</a></li>
	<li><a href="/Galerija/PronalazenjeAutoraID.jsp">Pronalaženje autora na osnovu ID-a</a></li>
	<li><a href="/Galerija/PronalazenjeDela2.jsp">Pronalaženje dela na osnovu: naslova dela, tehnike, stila i imena i prezimena autora</a></li>
    <li><a href="/Galerija/PronalazenjeAutora2.jsp">Pronalaženje autora na osnovu: imena i prezimena, stila u kom su nastale njegova dela u galeriji i tehnike kojom su nastala njegova dela u galeriji</a></li>
	<li><a href="DelaServlet">Pregled svih dela</a></li>
	<li><a href="AutoriServlet">Pregled svih autora</a></li>
</ol>
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