/*
You found an exciting summer job for five weeks. It pays, say, $15.50 per hour. Suppose that the total tax you pay on your summer job income is 14%.

After paying the taxes, you spend 10% of your net income to buy new clothes and other accessories for the next school year and 1% to buy school supplies.

After buying clothes and school supplies, you use 25% of the remaining money to buy savings bonds. For each dollar you spend to buy savings bonds, your parents spend $0.50 to buy additional savings bonds for you.

The program should prompt the user to enter:

The pay rate for an hour
The number of hours you worked each week.
The percent of net income spent to buy savings bonds
The program then outputs the following:

Your income before and after taxes from your summer job.

The money you spend on clothes and other accessories.

The money you spend on school supplies.

The money you spend to buy savings bonds.

The money your parents spend to buy additional savings bonds for you.

---New stipulation---
a. If you do not spend any money to buy savings bonds, then because you had a summer job, 
your parents buy savings bonds for you in an amount equal to 1% of the money you save after paying taxes 
and buying clothes, other accessories, and school supplies.

b. If you spend up to 25% of your net income to buy savings bonds, 
your parents spend $0.25 for each dollar you spend to buy savings bonds, 
plus money equal to 1% of the money you save after paying taxes and buying clothes, other accessories, 
and school supplies.

c. If you spend more than 25% of your net income to buy savings bonds, 
your parents spend $0.40 for each dollar you spend to buy savings bonds, 
plus money equal to 2% of the money you save after paying taxes and buying clothes, other accessories, 
and school supplies.

*/
#include <iostream>
#include <iomanip>

using namespace std;

int main() 
{
    // Write your main here
    
    double pay, wage, nWage, tWage, week1, week2, week3, week4, week5, save, tax, clothes, tools, bonds, pBonds; 
    
    cout << "Enter wages, hours worked and saving bonds: ";
    cin >> pay >> week1 >> week2 >> week3 >> week4 >> week5 >> save;
    
    wage = pay * (week1 + week2 + week3 + week4 + week5);
    tax = wage * 0.14;
    nWage = wage - tax;
    
    clothes =  nWage * 0.1;
    tools = nWage * 0.01;
    bonds = nWage * (save * .01);
    tWage = wage - (tax + clothes + tools);
    
    cout << fixed << setprecision(2) 
         <<"\nIncome before taxes: " << wage
         <<"\nIncome after taxes: " << nWage
         <<"\nMoney for clothes: " << clothes
         <<"\nMoney for supplies: " << tools;
    if(save == 0)
    {
        bonds = tWage/0.01;
        pBonds = bonds/2;
         cout <<"\nMoney for bonds: " << bonds
              <<"\nParent bond money: " << pBonds;
    }
    else if(save > 0  && save <= 25)
    {
        pBonds = (bonds*.25) + (tWage*0.01);
         cout <<"\nMoney for bonds: " << bonds
              <<"\nParent bond money: " << pBonds;
    }
    else if (save > 25)
    {
        pBonds = (bonds*.4) + (tWage*0.02);
         cout <<"\nMoney for bonds: " << bonds
              <<"\nParent bond money: " << pBonds;
    }
    return 0;
}
