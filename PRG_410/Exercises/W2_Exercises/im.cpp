#include <iostream>
#include "integerManipulation.h"

using namespace std;
using namespace IM;

int main() 
{
    // Write your main here
    integerManipulation im;
    long long num = 0;
    
    cout << "Enter the number: ";
    cin >> num;
    
    im.setNum(num);
    
    return 0;
}
