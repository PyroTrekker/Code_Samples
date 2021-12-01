package GamePack;

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.util.HashMap;
import java.util.Iterator;
import java.util.Map;

/**
 *
 * @author gwenz1
 */
public class UserHashBean {

    // instance variables
    private Map<String, User> userHash;
    private User user;
    private String userName;
    String str;
    String strArray[];
    private String file = "E:/IT_Programmer_Analyst/3rd_Semester/Java_Web/Final/ReflexGame/build/web/files/user.txt";
    private boolean populated; // tells us if the hashmap was populated or not

    /**
     * No-Argument Constructor populates the HashMap based on data in the file
     * called user.txt
     */
    public UserHashBean() {
        // instantiate the HashMap object in memory
        userHash = new HashMap<String, User>();
        // create a BufferedReader
        BufferedReader br; // create the instance variable
        populated = false;
        try {

            br = new BufferedReader(new FileReader(file));
            // populate the HashMap
            while (br.ready()) { // while there is data in the Buffered Reader...
                str = br.readLine(); //read a line of data from the file
                strArray = str.split(":"); // Split on the delimiter
                userHash.put(strArray[0], new User(strArray[0], strArray[1])); // create a new user entry in the hashmap with
                // userName (strArray[0]) as the kay.
            }
            br.close();
            populated = true;

        } catch (IOException e) {
            populated = false; // The hashmap was not populated succesfully
        }

    }

    /**
     * Tells us if the hashmap has been populated or not
     *
     * @return
     */
    public boolean isPopulated() {
        return populated;
    }

    /**
     * This getter returns a user from the hashmap based on the current value of
     * userName. If no user exists, it returns null in the user.
     *
     * @return the user from the hashmap, if it exists.
     */
    public User getUser() {

        if (userName != null && userHash.containsKey(userName)) {
            user = userHash.get(userName);

        } else {
            user = null;
        }
        return user;
    }

    public String getCurrentUser() {

        String current = strArray[strArray.length - 2];

        return current;
    }

    public long getCurrentStart() {
        long start = Long.parseLong(strArray[strArray.length - 1]);

        return start;
    }

    /**
     * Given us the set of titles of all the users in an Iterator.
     *
     * @return
     */
    public Iterator<String> getUserList() {

        return userHash.keySet().iterator();

    }

    public String getUserName() {
        return userName;
    }

    public void setUserName(String userName) {
        this.userName = userName;
    }

    /**
     * This is our test for the userHash
     *
     * @param args
     */
    public static void main(String[] args) {
        UserHashBean userHashBean = new UserHashBean(); // call the no-arg constructor

        if (userHashBean.isPopulated()) {
            Iterator<String> it = userHashBean.getUserList();

            while (it.hasNext()) {
                String key = it.next(); //get the key
                System.out.println(key);// print the key(title)
                userHashBean.setUserName(key); // set the title
                System.out.println(userHashBean.getUser()); // user information
            }

        } else {
            System.err.println("The User Hash Bean was not populated.");
        }
    }
}
