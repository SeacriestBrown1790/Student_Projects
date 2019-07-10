#include "circleType.h"
#ifndef cylinderType_H
#define cylinderType_H

class cylinderType : public circleType
{
   public:
    void print();
    void setHeight(double h);
    double getHeight();
    double volume();
    double area();
    cylinderType(double r, double h);
    cylinderType();
  
  private:
    double height;
    double volume;
    double sA; 
    
};



#endif
