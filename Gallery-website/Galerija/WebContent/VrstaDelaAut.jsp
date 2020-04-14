<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<link rel="stylesheet" href="galerijaCss2.css">
<meta http-equiv="Content-Type" content="text/html;charset=UTF-8">
<title>Insert title here</title>
</head>
<body>
<h2>Dodavanje podataka o umetničkom delu</h2>
<br/>
<br/>
<h3>Izaberite vrstu umetničkog dela:</h3>

<form  method = "post" action = "VrsteDelaAutorServlet" >

			            	<select name = "vrsta">
				            <option value = "slika">slika</option>
							<option value = "skulptura">skulptura</option>
							<option value = "multimedija">multimedijalni zapis</option>
			  			    </select>
<input type = "hidden" value="${autor2.ime}" name = "ime">
<input type = "hidden" value="${autor2.prezime}" name = "prz"> 
<input type = "hidden" value="${autor2.id}" name = "id">			  			    
<input type="submit" value="Potvrdi">			  			    
</form>
</body>
</html>