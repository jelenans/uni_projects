<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
    
      <%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
      
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<link rel="stylesheet" href="galerijaCss2.css">
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Nadji delo</title>
</head>
<body>
<h2>Pronalaženje dela</h2>
<c:choose>
    <c:when test="${kustos.logged}">
    	<div class="lista">
<form method="post" action="NadjiDeloServlet">
  <table border="0">
	 <tr>
			<td><h3>Unesite ID za pretragu dela:</h3> </td>
			<td><input type="text" name="id"></td>
	 </tr>
	 <tr>
			<td></td>
			<td><input type = "submit" value = "Potvrdi"/></td>
	 </tr>
  </table>
</form>
<a href="/Galerija/kustosMain.jsp">Nazad</a><br/>
<br/>
[<a href="LoginServlet?logoff=true">Odjavi se</a>]
</div>
</c:when>
	<c:otherwise>
		<div class="lista">
		<h3><b>Niste ulogovani!</b></h3>
		<p>
		[<a href="LoginServlet?logoff=true">Logovanje</a>]
		</p>
		</div>
	</c:otherwise>
</c:choose>
</body>
</html>