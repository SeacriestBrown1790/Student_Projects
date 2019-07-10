/* Assignment Scenario & Requirements

You are now working for a department store, 
and your task is to create a point-of-sale application 
to allow customers to calculate the total cost of their sale, including taxes.
	- Calculates sales tax and total cost based on 
      the type of purchased product using the following categories and tax percentages:
		~ Category 1 - Clothing: 6%
		~ Category 2 - Beauty products: 7%
		~ Category 3 - Grocery: 3%
		~ Category 4 - Gardening: 6%
		~ Category 5 - School supplies: 3%
		~ Category 6 - Tobacco products: 10%
	- Creates an array to store the numbers users input and
      uses the switch statement to calculate the sales tax
      and final cost based on the category of the purchased product
	- Prompts the user for category and price of the product
   - Calculates and displays the final cost
   
*/
/////////////////////////////////////////////
////                                     ////
////       Savings Account Program       ////
////           Seacriest Brown           ////
////              PRG_410                ////
////           March 18, 2019            ////  
////             Brian Rague             ////
////                                     //// 
/////////////////////////////////////////////

//Main function to test the SavingsAccount implementation and header files
#include <iostream>
#include <iomanip>
#include "SavingsAccountImp.cpp" //Getting defined functions from implementation file

using namespace std; 

double SavingsAccount::annualInterestRate = .02;

int main()
{
   //Initializing the saver objects
   SavingsAccount Firstsaver;
   SavingsAccount Secondsaver;

   //Setting balances
   Firstsaver.setBalance(1000.00);
   Secondsaver.setBalance(2000.00);

   //Calculating the balance after interest
   Firstsaver.calculateMonthlyInterest();
   Secondsaver.calculateMonthlyInterest();

   //Setting decimal to along more with money notation
   cout << fixed << setprecision(2); 

   cout << "******First Month******" << endl
        << "---Saving Account #1---" << endl << "Current Balance: $" << Firstsaver.getBalance() << endl
        << "\n---Saving Account #2--- " << endl << "Current Balance: $" << Secondsaver.getBalance() << endl;

   //Changing the interest rate from .02 to .03
   SavingsAccount::modifyInterestRate(.03);
   
   //Calculating balance with new interest rate
   Firstsaver.calculateMonthlyInterest();
   Secondsaver.calculateMonthlyInterest();

   
   cout <<"\n******Second Month******" << endl
        << "---Saving Account #1---" << endl << "Current Balance: $" << Firstsaver.getBalance() << endl
        << "\n---Saving Account #2--- " << endl << "Current Balance: $" << Secondsaver.getBalance() << endl;
 
   return 0;    
}