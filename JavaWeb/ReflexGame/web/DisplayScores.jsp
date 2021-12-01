<%-- 
    Document   : DisplayScores
    Created on : Mar 8, 2013, 8:35:31 PM
    Author     : User
--%>

<%@page import="GamePack.ScoreHashBean"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Scores</title>
        <link href="css/styles.css" rel="stylesheet">
    </head>
    <body>
        <h1>Scores</h1>
        <form method = "post" id="form" action="./index.jsp">
            <input type="submit" value="" name="Submit" class="submit" id="submit" />
        </form>

        <%
            ScoreHashBean score = new GamePack.ScoreHashBean();
        %>
        <h2>
            <% out.println(score.getCurrentUser()); %> your time was: 
            <% out.println(score.getCurrentScore()); %> seconds <br/>
            Hit the red button to restart.
        </h2>
    </body>
</html>
