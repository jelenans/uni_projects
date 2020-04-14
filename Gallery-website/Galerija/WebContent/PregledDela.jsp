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

	
<h2>Pregled dela</h2>

<form action="DelaServlet" method="get">
<div class="lista">
<table border="1">
	<tr>
	<th></th>
	<th>Vrsta</th>
    <th>Naslov</th><th>Tehnika</th><th>Stil</th>
	<th>Datum nastanka</th><th>Mesto nastanka</th>
	<th>Opis</th><th>ID</th><th>Visina</th><th>Širina</th><th>Dužina</th><th>Trajanje</th><th>Format</th>
	<th>Pregled autora</th>
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
		<a href="AutoriDelaServlet?pregledPosLoz=${d.id}">Pregled autora</a>
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
		<a href="AutoriDelaServlet?pregledPosLoz=${d.id}">Pregled autora</a>
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
		<a href="AutoriDelaServlet?pregledPosLoz=${d.id}">Pregled autora</a>
		</td>
	   
		</tr>
	</c:forEach>
	</table>
	</div>
	</form>
		<br/>
		<br/>
		<div class="lista">
				<a href="/Galerija/index.html">Nazad na početnu stranicu</a><br/>
		</div>

</body>
</html>