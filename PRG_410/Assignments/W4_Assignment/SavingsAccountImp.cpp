//Implementation file defining the declared functions
#include <iostream>
#include "SavingsAccount.h" //Getting the declared functions from header file

using namespace std;

void SavingsAccount::setBalance(double balance)
{
	savingsBalance = balance;
}

double SavingsAccount::getBalance()
{
	return savingsBalance;
}

void SavingsAccount::calculateMonthlyInterest ()
{
	savingsBalance = savingsBalance + ((annualInterestRate * savingsBalance)/12);
}

void SavingsAccount::modifyInterestRate (double mir)
{
	annualInterestRate = mir;
}

