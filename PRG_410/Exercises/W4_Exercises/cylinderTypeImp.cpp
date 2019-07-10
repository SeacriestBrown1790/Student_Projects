#include <iostream>
#include <cmath>
#include "cylinderType.h"
#include "circleTypeImp.cpp"

using namespace std;

cylinderType::cylinderType(double r, double h)
            : circleType(r)
{
   setHeight(r); 
}

cylinderType::cylinderType(){}

void cylinderType::setHeight(double h)
{
   height = h;
} 

double cylinderType::getHeight()
{
    return height;
}

void cylinderType::print()
{
   cout << "\nSurface Area: " << sA 
        << "\nVolume: " << volume;
}
double cylinderType::volume()
{
   volume = circleType::area() * height;
}
    
double cylinderType::area()
{
   sA = (2*3.1416*circleType::getRadius()*height) + (2*circleType::area());
}
