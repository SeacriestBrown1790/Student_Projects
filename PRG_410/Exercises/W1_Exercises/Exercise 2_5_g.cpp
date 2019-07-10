#include <iostream>

using namespace std;

int main() {
    // Write your main here
    double num1, num2, num3, num4, num5;
    double mean;
    
    cout <<" Enter five test scores: ";
    cin >> num1 >> num2 >> num3 >> num4 >> num5;
    cout << endl;
    mean = (num1+num2+num3+num4+num5)/5;
    
    cout <<"Your average test score is : " << mean
         << endl; 
    return 0;
}
