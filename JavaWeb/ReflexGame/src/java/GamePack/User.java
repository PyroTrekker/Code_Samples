package GamePack;

import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.PrintWriter;

/**
 *
 * @author gwenz1
 */
public class User {

    private long startTime = 0;
    private long endTime = 0;
    private String userName = "";
    private int time = 0;

    public User() {
    }

    /*
     * Overloaded Constructor
     */
    public User(String userName, String startTime) {
        this.userName = userName;
        this.startTime = Long.parseLong(startTime);
    }

    public long getStartTime() {
        return startTime;
    }

    public void setStartTime(long startTime) {
        this.startTime = startTime;
    }

    public long getEndTime() {
        return endTime;
    }

    public void setEndTime(long endTime) {
        this.endTime = endTime;
    }

    public String getUserName() {
        return userName;
    }

    public void setUserName(String userName) {
            this.userName = userName;
    }

    public int getTime() {
        return time;
    }

    public void setTime(int time) {
        this.time = time;
    }

    public long getElapsedTimeSecs() {
        long elapsed = ((endTime - startTime) / 1000);

        return elapsed;
    }

    public void storeUser(String file) throws FileNotFoundException {
        String userFile = file;

        PrintWriter pw = new PrintWriter(new FileOutputStream(userFile, true));
        pw.println(userName + ":" + startTime);
        pw.close();
    }

    public void storeScore(String file) throws FileNotFoundException {

        String userFile = file;

        PrintWriter pw = new PrintWriter(new FileOutputStream(userFile, true));
        pw.println(userName + ":" + getElapsedTimeSecs());
        pw.close();
    }
}
