/* 
*/
#include <iostream>
#include <cmath>

using namespace std;

int main() 
{
    // Write your main here
    double a, b, c, discriminant, x1, x2, real, imagine;
    
    cout << "Enter three numbers: \n";
    cin >> a >> b >> c;
    discriminant = b*b - 4*a*c;
    cout << discriminant;
    
    if(discriminant > 0)
    {
        x1 = (-b + sqrt(discriminant)) / (2*a);
        x2 = (-b - sqrt(discriminant)) / (2*a);
        cout << "\nx1 = " << x1
             << "\nx2 = " << x2;
    }
    else if (discriminant == 0)
    {
       x1 = (-b + sqrt(discriminant)) / (2*a);
       cout << "\nx1 = x2 = " << x1;
       cout << discriminant;
    }
    else
    {
        real = -b/(2*a);
        imagine = sqrt(-discriminant)/(2*a);
        cout << "\nx1 = " << real << "+" << imagine << "i"
             << "\nx2 = " << real << "-" << imagine << "i";
    }
    return 0;
}
