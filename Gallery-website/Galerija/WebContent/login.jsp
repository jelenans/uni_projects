<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>    

   
    
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">


<html>
<head>
<link rel="stylesheet" href="galerijaCss2.css">
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Prijavljivanje kustosa</title>
</head>
<body>
<c:choose>
<c:when test="${!kustos.logged}">
		<h2>Prijavljivanje</h2>
		<form method="post" action="LoginServlet">
		<table border="0">
		<tr>
			<td>
			Ime:</td>
			<td><input type="text" name="ime" >
			</td>
		</tr>
		<tr>
			<td>	
			Lozinka:
			</td>
			<td>
 			<input type="password" name="lozinka">
			</td>
		</tr>
		<tr>
			<td>
			</td>
			<td>
			</td>
		</tr>
		<tr>
			<td>
			</td>
			<td>
			<input type="submit" value="Prijavi se">
			</td>
		</tr>
</table>
</form>
</c:when>
<c:otherwise>
 <p>Već ste se prijavili! </p>
 <br/>
 <div class="lista">
  <p>[<a href="LoginServlet?logoff=true">Odjavi se</a>]</p>
  </div>
</c:otherwise>
</c:choose>
<div class="lista">
	<a href="/Galerija/kustosMain.jsp">Pređi na glavnu stranicu kustosa</a>
	<br/>
	<a href="/Galerija/index.html">Nazad na početnu stranicu</a><br/>
</div>
</body>
</html>