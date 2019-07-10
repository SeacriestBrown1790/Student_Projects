/* Assignment Scenario & Requirements
   A grocery store hired you to develop a simple application to read 2 random product prices and compare them.
   Create a C++ program that does the following:
   	- Asks the user to enter 3 integers
   	- Obtains the numbers from the user
   	- Prints the largest number and then the smallest of the numbers
   	- If the numbers are equal, prints the message: "These numbers are equal."
   Prints the sum, average, and product of the 3 numbers
*/

/////////////////////////////////////////////
////                                     ////
////     Simple Comparison Application   ////
////           Seacriest Brown           ////
////              PRG_410                ////
////           March 4, 2019             ////  
////             Brian Rague             ////
////                                     //// 
/////////////////////////////////////////////


#include <iostream>
#include <algorithm>

using namespace std;

int main()
{
   //Initialized varibles
   int num1, num2, num3, sum,product, botNum, topNum;
   int* bot; //Using int* for the min and max element functions
   int* top;
   double mean; //mean variable is 'double' due to being the divided solution
   
   cout <<"Enter three integers. Press 'ENTER' after each integer" << endl;
   cout <<"The first integer: ";
   cin >> num1;
   cout <<"The second integer: ";
   cin >> num2;
   cout <<"The third integer: ";
   cin >> num3;
   
   int numbers[] = {num1, num2, num3}; //Creating an array to hold the three numbers for comparison
   
   bot = min_element(numbers, numbers+3); //The smallest of the three numbers
   top = max_element(numbers, numbers+3); //The largest of the three numbers
   
   botNum = *bot; //Getting the integers verisons of the 'bot' and 'top' int* variables
   topNum = *top;
   
   //Solving the sum, average and product of the three numbers
   sum = num1 + num2 + num3;
   mean = sum/3;
   product = num1 * num2 * num3;
   
   cout <<"\n-----RESULTS-----"
        <<"\nLargest number:  " << topNum
        <<"\nSmallest number: " << botNum;
   if (botNum == topNum) //Will only print if the two are equal
   {
      cout <<"\nThese numberes are equal.";
   }
   cout <<"\n-----Sum, Average, and Product of the three numbers-----"
        <<"\nSum: " << sum
        <<"\nAverage: " << mean
        <<"\nProduct: " << product;
         
   return 0;
}