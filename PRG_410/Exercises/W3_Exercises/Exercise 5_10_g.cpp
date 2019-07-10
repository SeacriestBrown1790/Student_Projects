/*
Write a program that uses do...while loops to perform the following steps:

Prompt the user to input two integers: firstNum and secondNum
(firstNum must be less than secondNum).
Output all odd numbers between firstNum and secondNum.
Output the sum of all even numbers between firstNum and secondNum.
Output the numbers and their squares between 1 and 10.
Separate the numbers by any amount of spaces.
Output the sum of the square of the odd numbers between firstNum and secondNum.
Output all uppercase letters.
*/
#include <iostream>
#include <cmath>

using namespace std;

int main() 
{
    // Write your main here
    
    int firstNum, secondNum, evenSum=0, remainder, i, num=1, numSqrt, iSqrt, iSum=0;
    
    cout << "Enter numbers: ";
    cin >> firstNum >> secondNum;
    
    i = firstNum;
    
    //Output all odd numbers between firstNum and secondNum.
    //Output the sum of the square of the odd numbers between firstNum and secondNum.
    do
    {
        remainder = i % 2;
        if(remainder != 0)
        {
           cout << i << " "; 
           iSqrt = pow(i,2);
           iSum = iSum + iSqrt;
        } 
        ++i;
    }
    while (i <= secondNum);
    
    i = firstNum;
    remainder = 0;
    
    //Output the sum of all even numbers between firstNum and secondNum.
    do
    {
        remainder = i % 2;
        if(remainder == 0)
        {
            evenSum+=i;
        }
        ++i;
    }
    while(i<=secondNum);
    cout << endl << evenSum;
    
    cout << endl;
    
    //Output the numbers and their squares between 1 and 10.
    do
    {
        cout << num << " ";
        numSqrt = pow(num,2);
        cout << numSqrt << " ";
        ++num;
    }
    while (num<=10);
    
    //Output the sum of the square of the odd numbers between firstNum and secondNum.
    cout << iSum;
    
    //Output all uppercase letters.
    char c = 'A';
    do
    {
       cout << c << " ";
       ++c;
    }
    while(c<='Z');
    
    return 0;
}
