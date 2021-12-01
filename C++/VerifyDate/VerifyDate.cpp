#include "VerifyDate.h"
#include <cstdlib>
#include <iostream>

using namespace std;

// Constructors
VerifyDate::VerifyDate()
{
    setMonth(1);
    setDay(1);
    setYear(2000);
}

VerifyDate::VerifyDate(int m, int d, int y)
{
    setMonth(m);
    setDay(d);
    setYear(y);
}

 // Destructor
VerifyDate::~VerifyDate()
{

}

// Accessors
int VerifyDate::getMonth() const
{
    return month;
}

int VerifyDate::getDay() const
{
    return day;
}

int VerifyDate::getYear() const
{
    return year;
}

// Mutators
void VerifyDate::setMonth(int m)
{
    month = m;
}

void VerifyDate::setDay(int d)
{
    day = d;
}
void VerifyDate::setYear(int y)
{
    year = y;
}

// Public Member Functions
void VerifyDate::PrintDate()
{
    cout << endl << month << "/" << day << "/" << year;
}

bool VerifyDate::CheckDate()
{
    // Variables
    bool leap, valid = false;

    // Check whether the input date is between January 1, 1850, and December 31, 2100
    if(month > 0 && month < 13 && day > 0 && year > 1849 && year < 2101)
    {
        // Check that the input day is valid within the input month
        switch (month)
        {
            case 1:
                if(day < 32)
                    valid = true;
                break;
            case 2:
                // Check whether or not it is a leap year
                leap = IsLeap();
                if(leap == true)
                {
                    if(day < 30)
                        valid = true;
                }
                else
                {
                    if(day < 29)
                        valid = true;
                }
                break;
            case 3:
                if(day < 32)
                    valid = true;
                break;
            case 4:
                 if(day < 31)
                    valid = true;
                break;
            case 5:
                 if(day < 32)
                    valid = true;
                break;
            case 6:
                 if(day < 31)
                    valid = true;
                break;
            case 7:
                 if(day < 32)
                    valid = true;
                break;
            case 8:
                 if(day < 32)
                    valid = true;
                break;
            case 9:
                 if(day < 31)
                    valid = true;
                break;
            case 10:
                 if(day < 32)
                    valid = true;
                break;
            case 11:
                 if(day < 31)
                    valid = true;
                break;
            case 12:
                 if(day < 32)
                    valid = true;
                break;
        }
    }

    return valid;
}

// Private Member Functions
bool VerifyDate::IsLeap()
{
    // Variables
    bool leap = false;

        // Check if the input year is a leap year
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            leap = true;
    return leap;
}
