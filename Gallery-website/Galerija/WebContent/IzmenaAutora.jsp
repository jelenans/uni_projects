<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>

<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>  

<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<link rel="stylesheet" href="galerijaCss2.css">
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Izmena podataka o autoru</title>
</head>
<body>
<c:choose>
    <c:when test="${kustos.logged}">
<form method = "post" action = "IzmenaAutoraServlet">
<table border=0>
<tr>
			<td>Ime:</td>
		    <td><input type = "text"  value="${autor2.ime}" name = "ime"/></td>
</tr>
<tr>
			<td>Prezime:</td>
			<td> <input type = "text" value="${autor2.prezime}" name = "prezime"/></td>
</tr>
<tr>
			<td>Datum rođenja:</td>
			<td> <input type = "text" value="${autor2.datRodjTekstualno}" name = "datumRodjenja"/></td>
</tr>
<tr>
			<td>Datum smrti:</td> 
			<td><input type = "text" value="${autor2.datSmrtiTekstualno}" name = "datumSmrti"/></td>
</tr>
<tr>
			<td>Mesto rođenja:</td>
			<td> <input type = "text" value="${autor2.mestoRodjenja}" name = "mestoRodjenja"/></td>
</tr>
<tr>
			<td>Mesto smrti:</td>
			<td> <input type = "text" value="${autor2.mestoSmrti}" name = "mestoSmrti"/></td>
</tr>

<tr>			
			<td>ID:</td>
			<td> <input type = "text" value="${autor2.id}" name = "id" readonly/><td>
</tr>	
<tr>			
			<td>Biografija:</td> 
			<td>
			<textarea rows="10" cols="25" name = "bio">
			${autor2.bio}
			</textarea>
</tr>			
<tr>
			<td></td>
			<td><input type = "submit" value = "Potvrdi"/></td>
</tr>
</table>			
<div class="lista">
			<br/>
			<a href="/Galerija/kustosMain.jsp">Nazad</a><br/>	
			<br/>
            [<a href="LoginServlet?logoff=true">Odjavi se</a>]
            </div>
</form>		
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