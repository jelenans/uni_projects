<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>   
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<link rel="stylesheet" href="galerijaCss2.css">
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<script  type="text/javascript">
function proveraIme(){  
	
	var  ime = document.frm.ime.value;
	   if(ime=="")
	      {
	              
	              alert("Unesite ime autora!");
	              document.frm.ime.focus();
	              return false;
	      }
	   return true;
	}
function proveraPrezime(){
	 var  prz= document.frm.prezime.value;
	 if(prz=="")
     {
             
             alert("Unesite prezime autora!");
             document.frm.prezime.focus();
             return false;
     }
	  return true;
}
function proveraId(){
	 var  id= document.frm.id.value;

		 if(id=="")
	      {
	              
	              alert("Unesite id autora!");
	              document.frm.id.focus();
	              return false;
	      }
		  return true;
}
function proveraDat(){
	
	  var  rdate = document.frm.datumRodjenja.value;
      var rdateAr=sdate.split("-");
     if(rdateAr.length!=3)
     {
             alert("Unesite datum u formatu: mm-dd-yyyy ");
             document.frm.datumRodjenja.value="";
             document.frm.datumRodjenja.focus();
             return false;
     }
     var  sdate = document.frm.datumSmrti.value;
     var sdateAr=sdate.split("-");
     
    if(sdateAr.length!=3)
    {
            alert("Unesite datum u formatu: mm-dd-yyyy ");
            document.frm.datumSmrti.value="";
            document.frm.datumSmrti.focus();
            return false;
    }
    
    return true;
}
function provera()
{
         var  sdate = document.frm.datumRodjenja.value;
       var  ime = document.frm.ime.value;
       var  prz= document.frm.prezime.value;
       var  id= document.frm.id.value;
      if(ime=="" && prz=="" && id=="")
      {
              
    	  alert("Morate popuniti obavezna polja(ime,prezime,id)!");
    	  
              return false;
      }
        return true;
        
}
</script>
<title>Dodavanje podataka o autoru</title>
</head>
<body>
<h2>Dodavanje podataka o autoru</h2>
<c:choose>
 <c:when test="${kustos.logged}">
 	
<form name="frm" method = "post" action = "DodavanjeAutoraServlet" onSubmit="return provera()">
<table border=0>
<tr>
			<td>Ime:</td> 
			<td><input type = "text" name = "ime" onblur="return proveraIme()"/></td>
</tr>
<tr>
			<td>Prezime:</td>
			<td> <input type = "text" name = "prezime" onblur="return proveraPrezime()"/></td>
</tr>
<tr>
			<td>Datum rođenja:</td>
			<td> <input type = "text" name = "datumRodjenja" onblur="return proveraDat()"/></td>
</tr>
<tr>
			<td>Datum smrti:</td> 
			<td><input type = "text" name = "datumSmrti" onblur="return proveraDat()"/></td>
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
			<td> <input type = "text" name = "id" onblur="return proveraId()"/><td>
</tr>		
<tr>			
			<td>Biografija:</td> 
			<td>
			<textarea rows="10" cols="25" name = "bio">
			
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