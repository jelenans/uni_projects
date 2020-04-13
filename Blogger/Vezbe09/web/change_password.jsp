<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>   
<%@ taglib prefix="fmt" uri="http://java.sun.com/jstl/fmt" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">

<c:choose>  
<c:when test="${lng!=null && lng==1}">  
<fmt:setLocale value="en"/>  
</c:when>  
<c:otherwise>  
<fmt:setLocale value="sr"/>  
</c:otherwise>  
</c:choose> 
<fmt:setBundle basename="messages.messages"/>
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<script  type="text/javascript">
function provera()
{
	   var  realPass = document.frm.real_pass.value;
       var  oldPass = document.frm.old_pass.value;
       var  newPass= document.frm.new_pass.value;
       var  confPass= document.frm.conf_pass.value;
     
       if(oldPass=="" && newPass=="" && confPass=="")
       {
     	  alert("Please enter old, new and confirm password");	  
           return false;
       }
       else if(oldPass=="")
       {
    	  alert("Please enter old password");	  
          return false;
       } 
       else  if(realPass!=oldPass)
       {
     	  alert("Incorrect old password");	  
           return false;
       }
       else if(newPass=="")
       {
              
    	  alert("Please enter new password");	  
              return false;
              
       } else if(confPass=="")
       {
           
     	  alert("Please confirm new password");	  
               return false;
               
        } 
      
      else if(newPass!=confPass)
      {
              
    	  alert("New password does not match the confirm password");	  
              return false;
              
      } 
        return true;
        
}
</script>
		<title><fmt:message key="changePass"/></title>
		<meta HTTP-EQUIV="Pragma" CONTENT="no-cache">
		<meta HTTP-EQUIV="Expires" CONTENT="-1">
		<link href="./my.css" rel="stylesheet" type="text/css" />
</head>
<body>	
	
	  <c:choose>
	     <c:when test="${msg==1}">
	       <h3><fmt:message key="passerr"/>:</h3>
	       <h4><fmt:message key="msg1"/>!</h4>
	     </c:when>     	  
	     <c:when test="${msg==4}">
	       <h3><fmt:message key="passerr"/>:</h3>
		   <h4><fmt:message key="msg4"/>!</h4>
		 </c:when>
	     <c:when test="${msg==5}">
	       <h3><fmt:message key="passerr"/>:</h3>
	       <h4><fmt:message key="msg5"/></h4>
	      </c:when>
	</c:choose>
	
	
	<c:choose>
    <c:when test="${empty example1}"> 
        <!-- do stuff -->
    </c:when> 
    <c:otherwise> 
        <c:choose>
            <c:when test="${empty example2}"> 
                <!-- do different stuff -->
            </c:when> 
            <c:otherwise> 
                <!-- do default stuff -->
            </c:otherwise>
        </c:choose>
    </c:otherwise> 
</c:choose>
 	
<form name="frm" method = "post" action = "./ChangePasswordController" onSubmit="return provera()">
<table border=0>
				<tr>
					<td>*<fmt:message key="oldPass"/>:</td>
					<td><input type="password" name="old_pass"></td>				
				</tr>
				<tr>
					<td>*<fmt:message key="newPass"/>:</td>
					<td><input type="password" name="new_pass"></td>				
				</tr>
				<tr>
					<td>*<fmt:message key="confPass"/>:</td>
					<td><input type="password" name="conf_pass"></td>				
				</tr>		
				<tr>
				<td></td>
				<td><input type="hidden" name="real_pass" value="${user_to_edit.userPassword}"></td>
				</tr>	
				<tr>			    
					<td><input type="hidden" name="id" value="${user_to_edit.id}"></td>
					<td><input type="submit" name="submit" value="<fmt:message key="change"/>"></td>				
				</tr>
  
            </table>
</form>	
   				<br/>
   				<br/> 				
				[<a href="ShowPostsController"><fmt:message key="backHome"/></a>]<br/>
				<br/>	


</body>
</html>