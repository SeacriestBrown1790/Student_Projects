//include statement(s)
#include <string>
#include <iostream>
//using namespace statement
using namespace std;

int main()
{
//variable declaration
    string name;
    double studyHours;

//executable statements
    cout << "Enter the name (string): ";
    cin >> name;
    cout << endl;
    cout << "Enter the hours studied (double): ";
    cin >> studyHours;
    cout << endl;
    
    cout << "Hello, " << name <<"! On Saturday, you need to study " << studyHours << " hours for the exam." << endl;

//return statement
    return 0;
}
