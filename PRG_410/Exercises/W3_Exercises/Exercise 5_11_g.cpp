//*************************************************************

// Author: D.S. Malik
//
// Program: nth Fibonacci number
// Given the first two numbers of a Fibonacci sequence, this
// determines and outputs the desired number of the Fibonacci
// sequence.
//*************************************************************

#include <iostream>

using namespace std;

int previous1;

int previous2;
int current;
int counter;
int nthFibonacci;

int Malik();
void Malic();

int main()
{

Malik();
    
while(previous2 < previous1 || previous1 < 0 || previous2 < 0)//loops until valid numbers are entered
{
   cout <<"\n---Please enter valid numbers---\n";
   Malik();
}
Malic();

        /* Output the Fibonacci number at nth position */
cout << current;
return 0;

}//end main

int Malik ()
{
    cout << "Enter the first two Fibonacci numbers: "; //Step 1
    cin >> previous1 >> previous2; //Step 2
    cout << endl;
    return previous1, previous2;
}
void Malic()
{
    cout << "The first two Fibonacci numbers are " << previous1 << " and " <<         previous2 << endl; //Step 3
    cout << "Enter the position of the desired Fibonacci number: " ; //Step 4
    cin >> nthFibonacci; //Step 5
    
    while (nthFibonacci < 0)
    {
      cout <<"\n---Please enter valid number---";
      cout << "\nEnter the position of the desired Fibonacci number: " ;
      cin >> nthFibonacci;
    } 

    cout << endl;
    
    if (nthFibonacci == 1) //Step 6.a
        current = previous1;
    else if (nthFibonacci == 2) //Step 6.b
        current = previous2;
    else //Step 6.c
    {
        counter = 3;
        //Steps 6.c.2 – 6.c.5

        while (counter <= nthFibonacci)
        {

            current = previous2 + previous1;
            previous1 = previous2;
            previous2 = current;
            counter++;

         }//end while
    }//end else
}
