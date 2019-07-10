//Header file to declare functions
#ifndef SavingsAccount_H
#define SavingsAccount_H

class SavingsAccount
{
public:
	static double annualInterestRate; //Static variable initialized
	void setBalance(double bal); //Sets savingsBalance to 'bal' parameter
	double getBalance(); //Returns savingsBalance
	void calculateMonthlyInterest(); //Calculates the monthly interest
	static void modifyInterestRate(double mir); //Changes the current interest rate to 'mir' parameter	
private:
   //Variable
	double savingsBalance;
};

#endif