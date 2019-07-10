//include statement(s)
#include <string>
#include <iostream>
#include <iomanip>
//using namespace statement
using namespace std;
int main()
{

    //variable declaration
    const int SECRET = 11;
    const double RATE = 12.50;
    int num1, num2, newNum;
    string name;
    double hoursWorked, wages; 
    //executable statements
    cout <<"Enter two integers separated by a space: ";
    cin >> num1 >> num2;
    cout << endl;
    cout <<"The value of num1 = " << num1
         << " and the value of num2 = " << num2 
         << "." << endl;
    
    newNum = 2 * num1 + num2;
    cout << "The value of newNum = " << newNum << "."<< endl;
    
    newNum = newNum + SECRET;
    cout << "The value of newNum + SECRET = " << newNum << "."
         << endl << endl;
    
    cout << "Enter your last name: ";
    cin >> name;
    cout << endl;
    
    cout << "Enter hours works (0-70): ";
    cin >> hoursWorked;
    cout << endl;
    
    wages = RATE * hoursWorked;
    
    cout << "Name: " << name << endl;
    cout << fixed;
    cout << "Pay Rate: $" << setprecision(2) 
            << RATE << endl;
    cout << "Hours Worked: " << setprecision(2)
            << hoursWorked << endl;
    cout << "Salary: $" << setprecision (2) 
            << wages << endl; 
    
    //return statement
    return 0;
}
