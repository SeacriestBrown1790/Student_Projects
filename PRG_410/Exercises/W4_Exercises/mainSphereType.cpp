/*
Chapter 10 defined the class circleType to implement the basic properties of a circle.
 
(Add the function print to this class to output the radius, area, and circumference of a circle.) 

Now every cylinder has a base and height, where the base is a circle. 

Design a class cylinderType that can capture the properties of a cylinder 
and perform the usual operations on the cylinder. 

Derive this class from the class circleType designed in Chapter 10. 
Some of the operations that can be performed on a cylinder are as follows: 

calculate and print the volume
calculate and print the surface area
set the height
set the radius of the base
set the center of the base 

Also, write a program to test various operations on a cylinder.
*/
#include <iostream>
#include <iomanip>
#include "cylinderTypeImp.cpp"

using namespace std;

int main() 
{
    // Write your main here
    cout << fixed << setprecision(2);
    cylinderType cylinder1(4.5, 6.75);
    cylinderType cylinder2;
    
    cylinder1.getHeight();
    cylinder1.area();
    cylinder1.volume();
    
    cylinder2.setRadius(3.75);
    cylinder2.setHeight(8.25);
    
    cylinder2.getHeight();
    cylinder2.area();
    cylinder2.volume();
    
    
  return 0;
}

