<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
    <%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>  
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<link rel="stylesheet" href="galerijaCss2.css">
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Izmena podataka o umetničkom delu</title>
</head>
<body>
<c:choose>
    <c:when test="${kustos.logged}">
    <h2>Izmena podataka o umetničkom delu</h2>
<form method = "post" enctype="multipart/form-data" action = "IzmenaDelaServlet">
<table border=0>
<tr>
			
			<td>Vrsta:</td> 
			<td><input type = "text" name = "vrsta" value="slika" readonly></td>
</tr>
<tr>
			
			<td>Naslov:</td> 
			<td><input type = "text" value="${delo2.naslov}" name = "naslov"></td>
</tr>
<tr>
			<td>Tehnika:</td>
			<td> <input type = "text" value="${delo2.tehnika}" name = "tehnika"></td>
</tr>
<tr>
			<td>Stil:</td>
			<td> <input type = "text" value="${delo2.stil}" name = "stil"></td>
</tr>
<tr>
			<td>Datum nastanka:</td> 
			<td> <input type = "text" value="${delo2.datNastTekstualno}" name = "datumNastanka"></td>
</tr>
<tr>
			<td>Mesto nastanka:</td>
			<td> <input type = "text" value="${delo2.mestoNast}" name = "mestoNastanka"></td>
</tr>
<tr>			
			<td>ID:</td>
			<td> <input type = "text" value="${delo2.id}" name = "id" readonly/><td>
</tr>		
<tr>			
			<td>Lokacija zapisa:</td>
			<td> <input type="file"  id="file" name = "uri" value="${delo2.uri}"/><td>
</tr>	
<tr>
			
			<td>Širina:</td> 
			<td><input type = "text" value="${delo2.sirina}" name = "sirina" ></td>
</tr>
<tr>
			
			<td>Visina:</td> 
			<td><input type = "text" value="${delo2.visina}" name = "visina"></td>
</tr>
<tr>
			<td>Opis:</td>
			<td> 
			<textarea rows="10" cols="25"  name = "opis">
			${delo2.opis}
			</textarea>
			</td>
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