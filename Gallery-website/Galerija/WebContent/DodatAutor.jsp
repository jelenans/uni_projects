<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
  

<jsp:useBean id="autor" class="beans.Autor" scope="request"/>
<jsp:useBean id="kustos" class="beans.Kustos" scope="session"/>
    
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<link rel="stylesheet" href="galerijaCss2.css">
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Dodavanje autora</title>
</head>
<body>
 <% if (kustos!=null && kustos.isLogged())  {%>

<h2>Korisniče <%= kustos.getIme() %></h2>

  <% if (autor.getIme() != null)  {%>
  	  
  	  <h3>Autor: <b><%= autor.getIme() %>,<%=autor.getPrezime() %></b> sa ID: <%= autor.getId() %> je uspešno dodat u galeriju!</h3>
  	  
  <% } else { %>
  	  
  	 <h3>Autor nije uspešno dodat u galeriju!</h3>
  	 
  	<% } %>
  	<br/>
  	<div class="lista">
	<a href="/Galerija/kustosMain.jsp">Nazad</a><br/>
	<br/>
    [<a href="LoginServlet?logoff=true">Odjavi se</a>]
    </div>
<% } else { %>

		<h3><b>Niste ulogovani!</b></h3>
		<div class="lista">
		<p>
		[<a href="LoginServlet?logoff=true">Logovanje</a>]
		</p>
		</div>
<% } %>
</body>
</html>