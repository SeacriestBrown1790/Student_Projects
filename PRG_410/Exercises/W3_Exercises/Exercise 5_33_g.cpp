/*
Bianca is preparing special dishes for her daughter’s birthday.

It takes her a minutes to prepare the first dish, 
and each following dish takes b minutes longer than the previous dish. She has t minutes to prepare the dishes.

For example, if the first dish takes a = 10 minutes and b = 5, 
then the second dish will take 15 minutes, the third dish will take 20 minutes, and so on.

If she has 80 minutes to prepare the dishes, 
then she can prepare four dishes because 10 + 15 + 20 + 25 = 70.

Write a program that prompts the user to enter the values of a, b, and t, 
and outputs the number of dishes Bianca can prepare.
*/
#include <iostream>

using namespace std;

int main() 
{
    // Write your main here
    int a, b, t , dish=0, nA=0;
    
    cout << "Enter a,b,t: " << endl;
    cin >> a >> b >> t;
    cout << endl;
    nA = a;
    while (nA<t)
    {
        a = a + b;
        nA = nA + a;
        ++dish;
    }
    cout << endl << dish;
    return 0;
}
