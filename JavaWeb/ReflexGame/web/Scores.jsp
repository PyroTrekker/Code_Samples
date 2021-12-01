<%-- 
    Document   : Scores
    Created on : Mar 8, 2013, 4:24:49 PM
    Author     : User
--%>

<%@page import="GamePack.ScoreHashBean"%>
<%@page import="GamePack.UserHashBean"%>
<%@page import="GamePack.User"%>
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
        <form method = "post" id="form" action="./DisplayScores.jsp">
            <input type="submit" value="" name="Submit" class="submit" id="submit" />
        </form>

        <%
            long stop = System.currentTimeMillis();
            String startFile = application.getRealPath("/") + "files/user.txt";
            String scoreFile = application.getRealPath("/") + "files/score.txt";

            User me = new GamePack.User();
            ScoreHashBean score = new GamePack.ScoreHashBean();
            UserHashBean use = new GamePack.UserHashBean();

            me.setEndTime(stop);
            me.setStartTime(use.getCurrentStart());
            me.setUserName(use.getCurrentUser());
            me.storeScore(scoreFile);
        %>
        <h2>Click the red button to show your score</h2>
        
        


    </body>
</html>
