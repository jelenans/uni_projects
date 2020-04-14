<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>   
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<link rel="stylesheet" href="galerijaCss2.css">
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">

<title>Dodavanje podataka o autoru</title>
</head>
<body>
<h2>Dodavanje podataka o autoru</h2>
<c:choose>
    <c:when test="${kustos.logged}">	
<form method = "post" action = "DodavanjeAutoraDelaServlet">
<table border=0>
<tr>
			<td>Ime:</td> 
			<td><input type = "text" name = "ime"/></td>
</tr>
<tr>
			<td>Prezime:</td>
			<td> <input type = "text" name = "prezime"/></td>
</tr>
<tr>
			<td>Datum rođenja:</td>
			<td> <input type = "text" name = "datumRodjenja"/></td>
</tr>
<tr>
			<td>Datum smrti:</td> 
			<td><input type = "text" name = "datumSmrti"/></td>
</tr>
<tr>
			<td>Mesto rođenja:</td>
			<td> <input type = "text" name = "mestoRodjenja"/></td>
</tr>
<tr>
			<td>Mesto smrti:</td>
			<td> <input type = "text" name = "mestoSmrti"/></td>
</tr>
<tr>			
			<td>ID:</td>
			<td> <input type = "text" name = "id" /><td>
</tr>		
<tr>			
			<td>Biografija:</td> 
			<td>
			<textarea rows="10" cols="25" name = "bio">
			
			</textarea>
</tr>
</table>
<table border="1" style="width: 297px; ">
<tr bordercolor="blue">			
			<th rowspan="2">Delo:</th>
			<td> <input type = "text" value="${delo2.naslov}" name = "deloNaz"></td>		
</tr>
<tr>
	 <td>   <input type = "text" value="${delo2.id}" name = "deloAutora" readonly></td>
</tr>
</table>
<table>
<tr>
			<td></td>
			<td><input type = "submit" value = "Potvrdi"/></td>
</tr>

</table>			
			<br/>
			<div class="lista">
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