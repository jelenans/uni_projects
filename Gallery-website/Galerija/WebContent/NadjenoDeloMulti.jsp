<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>    



    
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<link rel="stylesheet" href="galerijaCss2.css">
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Traženje dela ID</title>
</head>
<body>
<c:choose>
    <c:when test="${kustos.logged}">
<h2>Korisniče ${kustos.ime},</h2>
<c:choose>

  	<c:when test="${m!=null}">
  	  
  	  <h3>Delo je uspešno pronađeno: </h3>

<form action="DelaServlet" method="get">
<table border="1">
	<tr>
	<th>Vrsta</th>
    <th>Naslov</th><th>Tehnika</th><th>Stil</th>
	<th>Datum nastanka</th><th>Mesto nastanka</th>
	<th>Opis</th><th>ID</th><th>Visina</th><th>Širina</th><th>Dužina</th><th>Trajanje</th><th>Format</th>
	<th>Brisanje</th><th> Izmena </th><th>Pregled autora</th><th>Dodavanje autora</th>
	</tr>
			<tr>
		<td>multim.zapis</td>
	<td>${m.naslov} </td>	
		<td>${m.tehnika}</td>
		<td>${m.stil} </td>	
		<td>${m.datNastTekstualno}</td>	
		<td>${m.mestoNast} </td>		
		<td>${m.opis} </td>		
		<td>${m.id} </td>				
		<td>""</td>			
		<td>""</td>			
		<td>${m.trajanje}</td>						
		<td>${m.format}</td>			
		<td>${m.vrstaZapisa}</td>
		<td>
		<a href="DelaServlet?brisiLoz=${sk.id}">Brisanje</a>
		</td>
		<td>
		<a href="DelaServlet?izmLoz=${m.id}">Izmena</a>
		</td>
		<td>
		<a href="AutoriDelaServlet?pregledLoz=${m.id}">Pregled autora</a>
		</td>
	    <td>
		<a href="AutoriDelaServlet?dodajLoz=${m.id}">Dodavanje autora</a>
		</td>
		</tr>

</table>
</form>
  	</c:when>
  	<c:otherwise>
  	  
  	 <h3>Delo nije uspešno pronađeno!</h3>
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