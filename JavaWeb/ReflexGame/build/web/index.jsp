<%-- 
    Document   : index
    Created on : Mar 8, 2013, 1:20:22 PM
    Author     : gwenz1
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Login</title>
        
        <link href="css/styles.css" rel="stylesheet">
        
    </head>
    <body>
        <h1>Enter your username then click the red button to begin!</h1>
        <form method = "post" action = "./Game.jsp">
            <input type="text" name="userNameInput" value="" id="input" />
            <input type="submit" value="" name="submit" class="submit" id="submit" />
        </form>
    </body>
</html>
