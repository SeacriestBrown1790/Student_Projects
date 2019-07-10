/*
Approxiamte pi
*/
#include <iostream>
#include <iomanip>
#include <cmath>

using namespace std;

int main()
{
    double pi = 0;
    long i;
    long n;
    
    cout << "Enter the value of n: ";
    cin >> n;
    cout << endl;
      
    for ( i = 1; i <= n; i++ )
      pi += pow(-1,i+1) * 4.0 / ( 2*i - 1 );
  
    cout << endl << "pi = " << pi << endl;
    return 0;
}
