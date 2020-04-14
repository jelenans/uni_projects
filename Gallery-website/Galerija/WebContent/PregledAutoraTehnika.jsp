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
	<div class="lista">
<form method="get" action="NadjiAutoraTehPravServlet">
  
	<h2>		
  Pregled autora po tehnici<br/> 
   <br/>
   </h2>
   <br/>
   <h3>
   Unesite željenu tehniku za pretragu:<br/>
	</h3>
   <input type="text" name="tehnikaA"><br/>
   <input type = "submit" value = "Potvrdi"/>

<br/>
<br/>
</form>
	<p>
	<a href="/Galerija/index.html">Nazad na početnu stranicu</a><br/>
	</p>
	</div>
</body>
</html>