<%-- 
    Document   : Game
    Created on : Mar 8, 2013, 2:31:50 PM
    Author     : gwenz1
--%>

<%@page import="GamePack.User"%>
<%@page import="java.io.IOException"%>
<%@page import="java.io.FileOutputStream"%>
<%@page import="java.io.PrintWriter"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Game</title>

        <link href="css/styles.css" rel="stylesheet">
    </head>
    <body>
        <form method = "post" id="form" action="./Scores.jsp">
            <input type="submit" value="" name="Submit" class="submit" id="submit" />
        </form>

        <input type="submit" value="" name="Submit" class="submit" id="game" />

        <script src="js/jquery.js"></script>
        <script src="js/buttonMove.js"></script>

        <%-- Write the username to a file --%>
        <%
            String userName = request.getParameter("userNameInput");
            String userFile = application.getRealPath("/") + "files/user.txt";
            long start = System.currentTimeMillis();
            
            User me = new GamePack.User();
                        
            me.setUserName(userName);
            me.setStartTime(start);
            me.storeUser(userFile);
        %>
        
    </body>
</html>
