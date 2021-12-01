#include <iostream>
#include "VerifyDate.h"

using namespace std;



int main()
{
    // Variables
    char runAgain = 'Y';
    bool valid;

    // Allow the user to choose whether or not to run the program again
    do
    {
        // Variables
        int month, day, year;

        // Get the month, day, and year from the user
        cout << "Please enter the following: \nmonth: ";
        cin >> month;
        cout << "day: ";
        cin >> day;
        cout << "year: ";
        cin >> year;

        // Create a new VerifyDate object and pass it the user's input
        VerifyDate myDate(month, day, year);

        // Print the input date
        myDate.PrintDate();

        // Validate the input date
        valid = myDate.CheckDate();
        if (valid == true)
            cout << " is valid.\n";
        else
            cout << " is not valid.\n";


        // Ask the user if they wish to run the program again
        cout << "\nDo you wish to check another date? Y/N: ";
        cin >> runAgain;
        cout << endl;

    } while (runAgain == 'Y' || runAgain == 'y');

    return 0;
}
