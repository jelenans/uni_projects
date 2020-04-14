<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<link rel="stylesheet" href="galerijaCss2.css">
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Nadji delo</title>
</head>
<body>
	<h2>		
  Pronalaženje dela po autorima<br/> 
   <br/>
   </h2>
   <br/>
   <h3>
   Unesite ime i prezime autora za pretragu:<br/>
	</h3>
		<div class="lista">
<form method="get" action="NadjiDeloAutorServlet">
  
	<table border=0>
	<tr>
	<td>Ime:</td>
	<td><input type="text" name="imeA"></td>
	</tr>
	<tr>
	<td>Prezime:</td>
	<td><input type="text" name="przA"></td>
	</tr>
	<tr>
	<td></td>
   <td><input type = "submit" value = "Potvrdi"/></td>
   </tr>
   </table>
</form>
<p>
	<a href="/Galerija/index.html">Nazad na početnu stranicu</a><br/>
</p>
</div>
</body>
</html>