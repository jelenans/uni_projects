<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>    

<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<link rel="stylesheet" href="galerijaCss2.css">
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Pregled Dela</title>
</head>
<body>
<c:choose>
 <c:when test="${kustos.logged}">	
<h2>Pregled dela</h2>

<form action="DelaServlet" method="post">
<div class="lista">
<table border="1">
	<tr>
	<th></th>
	<th>Vrsta</th>
    <th>Naslov</th><th>Tehnika</th><th>Stil</th>
	<th>Datum nastanka</th><th>Mesto nastanka</th>
	<th>Opis</th><th>ID</th><th>Visina</th><th>Širina</th><th>Dužina</th><th>Trajanje</th><th>Format</th>
	<th>Brisanje</th><th> Izmena </th><th>Pregled autora</th><th>Dodavanje autora</th>
	</tr>
	<c:forEach var="d" items="${slike}">
		<tr>
		
		<td><a href="${d.uri}"><img src="${d.uri}_thumbnail" alt="#"/></a></td>
		<td>slika</td>
	    <td>${d.naslov} </td>	
		<td>${d.tehnika}</td>
		<td>${d.stil} </td>	
		<td>${d.datNastTekstualno}</td>	
		<td>${d.mestoNast} </td>		
		<td>${d.opis} </td>		
		<td>${d.id} </td>				
		<td>${d.visina}</td>			
		<td>${d.sirina}</td>			
		<td></td>	
		<td></td>	
		<td></td>		
		<td>
		<a href="DelaServlet?brisiLoz=${d.id}">Brisanje</a>
		</td>
		<td>
		<a href="DelaServlet?izmLoz=${d.id}">Izmena</a>
		</td>
		<td>
		<a href="AutoriDelaServlet?pregledLoz=${d.id}">Pregled autora</a>
		</td>
	    <td>
		<a href="AutoriDelaServlet?dodajLoz=${d.id}">Dodavanje autora</a>
		</td>
		</tr>
	</c:forEach>
	<c:forEach var="d" items="${skulpture}">
		<tr>
		<td><a href="${d.uri}"><img src="${d.uri}_thumbnail" alt="#"/></a></td>
		<td>skulptura</td>
	<td>${d.naslov} </td>	
		<td>${d.tehnika}</td>
		<td>${d.stil} </td>	
		<td>${d.datNastTekstualno}</td>	
		<td>${d.mestoNast} </td>		
		<td>${d.opis} </td>		
		<td>${d.id} </td>				
		<td>${d.visina}</td>			
		<td>${d.sirina}</td>			
		<td>${d.duzina}</td>	
		<td></td>	
		<td></td>		
		<td>
		<a href="DelaServlet?brisiLoz=${d.id}">Brisanje</a>
		</td>
		<td>
		<a href="DelaServlet?izmLoz=${d.id}">Izmena</a>
		</td>
		<td>
		<a href="AutoriDelaServlet?pregledLoz=${d.id}">Pregled autora</a>
		</td>
	    <td>
		<a href="AutoriDelaServlet?dodajLoz=${d.id}">Dodavanje autora</a>
		</td>
		</tr>
	</c:forEach>
		<c:forEach var="d" items="${multi}">
		<tr>
		<td><a href="${d.uri}"><img src="${d.uri}_thumbnail" alt="#"/></a></td>
		<td>multim.zapis</td>
	   <td>${d.naslov} </td>	
		<td>${d.tehnika}</td>
		<td>${d.stil} </td>	
		<td>${d.datNastTekstualno}</td>	
		<td>${d.mestoNast} </td>		
		<td>${d.opis} </td>		
		<td>${d.id} </td>				
		<td></td>			
		<td></td>			
		<td></td>	
		<td>${d.trajanje}</td>	
		<td>${d.format}</td>		
		<td>
		<a href="DelaServlet?brisiLoz=${d.id}">Brisanje</a>
		</td>
		<td>
		<a href="DelaServlet?izmLoz=${d.id}">Izmena</a>
		</td>
		<td>
		<a href="AutoriDelaServlet?pregledLoz=${d.id}">Pregled autora</a>
		</td>
	    <td>
		<a href="AutoriDelaServlet?dodajLoz=${d.id}">Dodavanje autora</a>
		</td>
		</tr>
	</c:forEach>
	</table>
	</div>
	</form>
		<br/>
		<br/>
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