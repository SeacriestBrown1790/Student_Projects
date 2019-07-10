/*
Write a program that mimics a calculator. The program should take as input:

The first integer
The second integer
The operation to be performed (+, -, *, /)
It should then output the numbers, the operator, and the result. (For division, if the denominator is zero, output an appropriate message. The message should contain the word "error")
*/
#include <iostream>

using namespace std;

int main() 
{
    // Write your main here
    double num1, num2, result;
    char op;
    
    cout << "Enter two integers: \n";
    cin >> num1 >> num2;
    
    cout <<"Enter the operation( + , - , * , / ): ";
    cin >> op;
    
    if(num2 != 0)
    {
        switch(op)
        {
            case '+':
                result = num1 + num2;
                cout << num1 << " + " << num2 << " = " << result;
                break;
            case '-':
                result = num1 - num2;
                cout << num1 << " - " << num2 << " = " << result;
                break;
            case '*':
                result = num1 * num2;
                cout << num1 << " * " << num2 << " = " << result;
                break;
            case '/':
                result = num1 / num2;
                cout << num1 << " / " << num2 << " = " << result;
                break;
            default:
               cout << "Error, please try again";
               break;
        }
    }
    else
        cout << "error";
    
    return 0;
}
