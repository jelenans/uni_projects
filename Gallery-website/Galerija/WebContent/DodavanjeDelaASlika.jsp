<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>   
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<link rel="stylesheet" href="galerijaCss2.css">
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Dodavanje podataka o umetničkom delu</title>
</head>
<body>
<h2>Dodavanje podataka o umetničkom delu</h2>
<c:choose>
    <c:when test="${kustos.logged}">	
<form method = "post" enctype="multipart/form-data" action = "DodavanjeDelaAutoraServlet" >
<table border=0>
<tr>
			
			<td>Vrsta:</td> 
			<td><input type = "text" name = "vrsta" value="${vrsta}" readonly></td>
</tr>
<tr>
			
			<td>Naslov:</td> 
			<td><input type = "text" name = "naslov"></td>
</tr>
<tr>
			<td>Tehnika:</td>
			<td> <input type = "text" name = "tehnika"></td>
</tr>
<tr>
			<td>Stil:</td>
			<td> <input type = "text" name = "stil"></td>
</tr>
<tr>
			<td>Datum nastanka:</td> 
			<td> <input type = "text" name = "datumNastanka"></td>
</tr>
<tr>
			<td>Mesto nastanka:</td>
			<td> <input type = "text" name = "mestoNastanka"></td>
</tr>

<tr>			
			<td>ID:</td>
			<td> <input type = "text" name = "id" /><td>
</tr>		
<tr>			
			<td>Lokacija zapisa:</td>
			<td> <input type="file"  id="file" name = "uri" /><td>
</tr>	
<tr>
			
			<td>Širina:</td> 
			<td><input type = "text" name = "sirina" ></td>
</tr>
<tr>
			
			<td>Visina:</td> 
			<td><input type = "text" name = "visina"></td>
</tr>	
<tr>
			<td>Opis:</td>
			<td> 
			<textarea rows="10" cols="25" name = "opis" style="width: 154px; ">
			
			</textarea>
			</td>
</tr>
</table>
<table border="1" style="width: 297px; ">
<tr bordercolor="blue">			
			<th rowspan="2">Autor:</th>
			<td> <input type = "text" value="${ime}  ${prezime}" name = "autorImePrz" readonly style="width: 198px; "></td>		
</tr>
<tr>
	 <td>   <input type = "text" value="${id}" name = "autorDela" readonly></td>
</tr>
</table>
<table border=0 >
<tr bordercolor="blue">
			<td style="width: 107px; "></td>
			<td style="width: 214px; "><input type = "submit" value = "Potvrdi"/></td>
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