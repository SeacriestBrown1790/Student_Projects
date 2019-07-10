#include <iostream>
#include <string>

using namespace std;

int reverseDigit(int num)
{
   int rNum, newNum=0;
   
    while(num != 0)
    {
        rNum = num%10;
        newNum = newNum*10 + rNum;
        num /= 10;
    }
    cout << newNum;
    return true;
}

int main() {
    // Write your main here
    int number;
    
    cout <<"Enter number then hit enter: ";
    cin >> number;
    reverseDigit(number);
    
    return 0;
}
