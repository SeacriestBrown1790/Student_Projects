#include <iostream>
#include <cmath>

using namespace std;

int main() 
{
    // Write your main here
    double num; 
    
    cout << "Input decimal number to round: ";
    cin >> num;
    cout << endl;
    
    
    cout << "The rounded number is: " << llround(num) << endl;
    
    return 0;
}