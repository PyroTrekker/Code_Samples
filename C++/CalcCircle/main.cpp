#include "Circle.h"
#include <iostream>
using namespace std;

int main()
{
    // Variable declarations
    double inptRadius; // Stores the raius input by the user

    // Create Circle object
    Circle myCircle;

	// As the user for the Circle's radius
	cout << "Please enter the radius of the circle: ";
	cin >> inptRadius;
	myCircle.setRadius(inptRadius);

	// Report the Circle's area, diameter, and circumference
	cout << "Area: " << myCircle.getArea() << endl;
	cout << "Diameter: " << myCircle.getDiameter() << endl;
	cout << "Circumference: " << myCircle.getCircumference() << endl;
	return 0;
}
