#ifndef VERIFYDATE_H
#define VERIFYDATE_H

#include <iostream>
using namespace std;

class VerifyDate
{
    private:
        int month, day, year;

        // Member Functions
        bool IsLeap();

    public:
        // Constructors
        VerifyDate();
        VerifyDate(int m, int d, int y);

        // Destructor
        ~VerifyDate();

        // Accessors
        int getMonth() const;
        int getDay() const;
        int getYear() const;

        // Mutators
        void setMonth(int m);
        void setDay(int d);
        void setYear(int y);

        // Member Functions
        void PrintDate(); // prints date as mm/dd/year
        bool CheckDate();
};
#endif
