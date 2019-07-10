/*
Write a program that prompts the user to input an integer 
and then outputs both the individual digits of the number and the sum of the digits.
*/
#include <iostream>
#include <string>

using namespace std;

int main() 
{
    // Write your main here
    
    int num, sum=0, val;
    string str;
    
    cout << "Enter the number: ";
    cin >> val;
    
    num = val;
    if(val<0)
    {
        val*=-1;
    }
    str = to_string(val);
    
    for(char ch:str)
    {
      char n = ch;
      cout << n << " ";
    }
    
    while (num != 0)
    {
      sum = sum + num % 10;
      num = num / 10;
    }
    if (sum<0)
    {
        sum*=-1;
    }
    cout <<"\nSum: "<<sum;
    
    return 0;
}
