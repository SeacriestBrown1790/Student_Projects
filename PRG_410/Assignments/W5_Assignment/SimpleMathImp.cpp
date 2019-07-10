#include <iostream>
#include <vector>
#include <iterator>
#include <array>
#include <algorithm>
#include <numeric>
#include "SimpleMath.h"

using namespace std;

int exit();//exit function to get back to main()

//Array and pointers for the prices of the items
double cPrice[4] = { 16.95, 34.40, 68.99, 14.95 };
double bPrice[4] = { 31.99, 22.00, 32.06, 7.00 };
double grPrice[4] = { 4.99 , 7.99, 8.99, 7.99 };
double gaPrice[4] = { 45.00, 17.45 , 25.00 , 10.95 };
double sPrice[4] = { 2.47, 7.08, 11.99, 11.50 };
double tPrice[4] = { 22.93, 33.93, 29.95, 21.99 };

double *c = cPrice;
double *b = bPrice;
double *gr = grPrice;
double *ga = gaPrice;
double *s = sPrice;
double *t = tPrice; 

//vectors to hold each user made list of selected items
vector<double> clothing;
vector<double> beauty;
vector<double> grocery;
vector<double> garden;
vector<double> supplies;
vector<double> tobacco;

int choice=1;

int exit()
{
   return 1;//returns to main menu when user is ready
}

//**********GetPrice Section**********\\
//Functions for returning prices to display to the user. 

double SimpleMath::getcPrice(int i)
{
	return c[i];
}
double SimpleMath::getbPrice(int i)
{
	return b[i];
}
double SimpleMath::getgrPrice(int i)
{
	return gr[i];
}
double SimpleMath::getgaPrice(int i)
{
	return ga[i];
}
double SimpleMath::getsPrice(int i)
{
	return s[i];
}
double SimpleMath::gettPrice(int i)
{
	return t[i];
}

//**********Cart Addtion Section**********\\
//The functions for adding the selected item to its respective carts. 
//Each category gets its own cart to calculate their respective tax values.

void SimpleMath::clothAdd(int i)
{
      switch (i)
      {
		  //Since 'i' will always be +1 more than the desired number,
		  //the pointer[] substracts 1 to get the desired number.
         case 1: clothing.push_back(c[i - 1]); 
                 cout << "\nItem Number " << i << " has been added to your cart.";
                 break;
         case 2: clothing.push_back(c[i - 1]);
                 cout << "\nItem Number " << i << " has been added to your cart.";
                 break;
         case 3: clothing.push_back(c[i - 1]);
                 cout << "\nItem Number " << i << " has been added to your cart.";
                 break;
         case 4: clothing.push_back(c[i - 1]);
                 cout << "\nItem Number " << i<< " has been added to your cart.";
                 break;
         case 0: exit();
                 break;
         default: cout <<"\n********Enter valid number********";
                 break;
      }
	  cout << "\nChoose the number to the item you wish add to your cart (1 - 4), then press Enter: ";
	  cin >> choice;
	  if (choice != 0)
		  clothAdd(choice); //loops back to the current menu
}
void SimpleMath::beautyAdd(int i)
{
   switch (i)
      {
         case 1: beauty.push_back(b[i - 1]);
                 cout << "\nItem Number " << i << " has been added to your cart.";
                 break;
         case 2: beauty.push_back(b[i - 1]);
                 cout << "\nItem Number " << i << " has been added to your cart.";
                 break;
         case 3: beauty.push_back(b[i - 1]);
                 cout << "\nItem Number " << i << " has been added to your cart.";
                 break;
         case 4: beauty.push_back(b[i - 1]);
                 cout << "\nItem Number " << i << " has been added to your cart.";
                 break;
         case 0: exit();
                 break;
         default: cout <<"\n********Enter valid number********";
                 break;
      }
   cout << "\nChoose the number to the item you wish add to your cart (1 - 4), then press Enter: ";
   cin >> choice;
   if (choice != 0)
	   beautyAdd(choice);
}
void SimpleMath::groceryAdd(int i)
{
   switch (i)
      {
         case 1: grocery.push_back(gr[i - 1]);
                 cout << "\nItem Number " << i << " has been added to your cart.";
                 break;
         case 2: grocery.push_back(gr[i - 1]);
                 cout << "\nItem Number " << i << " has been added to your cart.";
                 break;
         case 3: grocery.push_back(gr[i - 1]);
                 cout << "\nItem Number " << i << " has been added to your cart.";
                 break;
         case 4: grocery.push_back(gr[i - 1]);
                 cout << "\nItem Number " << i<< " has been added to your cart.";
                 break;
         case 0: exit();
                 break;
         default: cout <<"\n********Enter valid number********";
                 break;
      }
   cout << "\nChoose the number to the item you wish add to your cart (1 - 4), then press Enter: ";
   cin >> choice;
   if (choice != 0)
	   groceryAdd(choice);
}
void SimpleMath::gardenAdd(int i)
{
   switch (i)
      {
         case 1: garden.push_back(ga[i - 1]);
                 cout << "\nItem Number " << i << " has been added to your cart.";
                 break;
         case 2: garden.push_back(ga[i - 1]);
                 cout << "\nItem Number " << i << " has been added to your cart.";
                 break;
         case 3: garden.push_back(ga[i - 1]);
                 cout << "\nItem Number " << i << " has been added to your cart.";
                 break;
         case 4: garden.push_back(ga[i - 1]);
                 cout << "\nItem Number " << i << " has been added to your cart.";
                 break;
         case 0: exit();
                 break;
         default: cout <<"\n********Enter valid number********";
                 break;
      }
   cout << "\nChoose the number to the item you wish add to your cart (1 - 4), then press Enter: ";
   cin >> choice;
   if (choice != 0)
	   gardenAdd(choice);
}
void SimpleMath::suppliesAdd(int i)
{
   switch (i)
      {
         case 1: supplies.push_back(s[i - 1]);
                 cout << "\nItem Number " << i << " has been added to your cart.";
                 break;
         case 2: supplies.push_back(s[i - 1]);
                 cout << "\nItem Number " << i << " has been added to your cart.";
                 break;
         case 3: supplies.push_back(s[i - 1]);
                 cout << "\nItem Number " << i << " has been added to your cart.";
                 break;
         case 4: supplies.push_back(s[i - 1]);
                 cout << "\nItem Number " << i<< " has been added to your cart.";
                 break;
         case 0: exit();
                 break;
         default: cout <<"\n********Enter valid number********";
                 break;
      }
   cout << "\nChoose the number to the item you wish add to your cart (1 - 4), then press Enter: ";
   cin >> choice;
   if (choice != 0)
	   suppliesAdd(choice);
}
void SimpleMath::tobaccoAdd(int i)
{
   switch (i)
      {
         case 1: tobacco.push_back(t[i - 1]);
                 cout << "\nItem Number " << i << " has been added to your cart.";
                 break;
         case 2: tobacco.push_back(t[i - 1]);
                 cout << "\nItem Number " << i << " has been added to your cart.";
                 break;
         case 3: tobacco.push_back(t[i - 1]);
                 cout << "\nItem Number " << i << " has been added to your cart.";
                 break;
         case 4: tobacco.push_back(t[i - 1]);
                 cout << "\nItem Number " << i << " has been added to your cart.";
                 break;
         case 0: exit();
                 break;
         default: cout <<"\n********Enter valid number********";
                 break;
      }
   cout << "\nChoose the number to the item you wish add to your cart (1 - 4), then press Enter: ";
   cin >> choice;
   if (choice != 0)
	   tobaccoAdd(choice);
}

//**********Calculation Section**********\\
//Each cart sums its items and calculates their respective taxes.
//Their collective sums are later added together to create the grand total, which is displayed to the user.

void SimpleMath::calcCloth()
{
   for(int c = 0; c < clothing.size();c++)//Runs through the user created list and sums them up
   {
      total1 += clothing[c];
   }
      total1 = total1 + (total1 * .06); //The 6% clothing tax is added here
}
void SimpleMath::calcBeauty()
{ 
	for (int c = 0; c < beauty.size(); c++)
	{
		total2 += beauty[c];
	}
      total2 = total2 + (total2 * .07);//The 7% beauty tax is added here
}
void SimpleMath::calcGrocery()
{
	for (int c = 0; c < grocery.size(); c++)
	{
		total3 += grocery[c];
	}
      total3 = total3 + (total3 * .03);//The 3% grocery tax is added here
}
void SimpleMath::calcGarden()
{
	for (int c = 0; c < garden.size(); c++)
	{
		total4 += garden[c];
	}
      total4 = total4 + (total4 * .06);//The 6% grocery tax is added here
}
void SimpleMath::calcSupplies()
{
	for (int c = 0; c < supplies.size(); c++)
	{
		total5 += supplies[c];
	}
      total5 = total5 + (total5 * .03);//The 3% supplies tax is added here
}
void SimpleMath::calcTobacco()
{
	for (int c = 0; c < tobacco.size(); c++)
	{
		total6 += tobacco[c];
	}
      total6 = total6 + (total6 * .1);//The 10% tobacco tax is added here
}

void SimpleMath::calcTotal()
{
   finalTotal = total1 + total2 + total3 + total4 + total5 + total6;
}

void SimpleMath::displayTotals()
{
   //Each of the different categories are calculated with their respective prices and taxes
   calcCloth();
   calcBeauty();
   calcGrocery();
   calcGarden();
   calcSupplies();
   calcTobacco();
   calcTotal();
   
   //Any non-accessed categories at the time of cartting out, will not be displayed
   if(total1>0)
      cout <<"\n\tClothing Total: $" << total1;
   if(total2>0)
      cout <<"\n\tBeauty Total: $" << total2;
   if(total3>0)
      cout <<"\n\tGrocery Total: $" << total3;
   if(total4>0)
      cout <<"\n\tGarden Total: $" << total4;
   if(total5>0)
      cout <<"\n\tSupplies Total: $" << total5;
   if(total6>0)
      cout <<"\n\tTobacco Total: $" << total6;
      
   //Grand Total displayed always
      cout <<"\n\t*****Grand Total: $" << finalTotal;
}
SimpleMath::SimpleMath(){};
ostream& operator<<(ostream& ostr, const SimpleMath& smi){return ostr;}