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
////         Simple Math Program         ////
////           Seacriest Brown           ////
////              PRG_410                ////
////           March 25, 2019            ////  
////             Brian Rague             ////
////                                     //// 
/////////////////////////////////////////////
//

#include <iostream>
#include <array>
#include <iomanip>
#include "SimpleMath.h"

using namespace std;

int option=1, select=1;//declaring input variables
SimpleMath smi; //Object for accessing SimpleMath class
int displayMenu(); //Menu function to display shopping categories

int main()
{
   cout << fixed << setprecision(2); //Setting two decimal placing for money format
   displayMenu();
}
int displayMenu() 
{
	//The user can select the category individually
	//Entering 1-6 chose a category,which goes into another menu for its type
	//while entering 9 calculates and displays the total and ends the program
	cout <<    "\n\t*******Main Menu*******"
		 <<    "\n\t1---Clothes and Accessories"
         <<    "\n\t2---Beauty Products"
         <<    "\n\t3---Grocery Items"
         <<    "\n\t4---Gardening"
         <<    "\n\t5---School Supplies"
         <<    "\n\t6---Tobacco Products"
         <<    "\n\t9   Display Totals"
		 << "\nEnter the number to the desired product type(1-6): ";
		cin >> option;
		switch(option)
		{
			case 1: cin.clear();
					cin.ignore(100, '\n');
					cout << "\n\t-----Clothing and Accessoriess-----"
						 << "\n\t1 T-Shirt ----- $" << smi.getcPrice(0)
						 << "\n\t2 Jeans ------- $" << smi.getcPrice(1)
						 << "\n\t3 Shoes ------- $" << smi.getcPrice(2)
						 << "\n\t4 Hat --------- $" << smi.getcPrice(3)
						 << "\n\t0      Return to Main Menu "
						 << "\nChoose the number to the item you wish add to your cart (1 - 4), then press Enter: ";
						cin >> select;
					if (select != 0)
						smi.clothAdd(select);
						break;
			case 2: cin.clear();
					cin.ignore(100, '\n');
					cout << "\n\t-----Beauty Products-----"
						 << "\n\t1 Eye Shadow --- $" << smi.getbPrice(0)
						 << "\n\t2 Eye Liner ---- $" << smi.getbPrice(1)
						 << "\n\t3 Moistuirzer -- $" << smi.getbPrice(2)
						 << "\n\t4 Lip Stick ---- $" << smi.getbPrice(3)
						 << "\n\t0      Return to Main Menu "
					     << "\nChoose the number to the item you wish add to your cart (1 - 4), then press Enter: ";
					cin >> select;
					if (select != 0)
						smi.beautyAdd(select);
				    break;
			case 3: cin.clear();
					cin.ignore(100, '\n');
					cout << "\n\t-----Grocery Items-----"
						 << "\n\t1 Fruits -------- $" << smi.getgrPrice(0)
						 << "\n\t2 Vegetables ---- $" << smi.getgrPrice(1)
						 << "\n\t3 Milk ---------- $" << smi.getgrPrice(2)
						 << "\n\t4 Bread --------- $" << smi.getgrPrice(3)
						 << "\n\t0      Return to Main Menu "
					     << "\nChoose the number to the item you wish add to your cart (1 - 4), then press Enter: ";
					cin >> select;
					if (select != 0)
						smi.groceryAdd(select);
				    break;
			case 4: cin.clear();
					cin.ignore(100, '\n');
					cout << "\n\t-----Gardening-----"
					<< "\n\t1 Fertilizer ---- $" << smi.getgaPrice(0)
					<< "\n\t2 Gloves -------- $" << smi.getgaPrice(1)
					<< "\n\t3 Shovel -------- $" << smi.getgaPrice(2)
					<< "\n\t4 Seeds --------- $" << smi.getgaPrice(3)
					<< "\n\t0      Return to Main Menu "
					<< "\nChoose the number to the item you wish add to your cart (1 - 4), then press Enter: ";
					cin >> select;
					if (select != 0)
						smi.gardenAdd(select);
				    break;
			case 5: cin.clear();
					cin.ignore(100, '\n');
					cout << "\n\t-----School Supplies-----"
					<< "\n\t1 Paper  -------- $" << smi.getsPrice(0)
					<< "\n\t2 Ruler --------- $" << smi.getsPrice(1)
					<< "\n\t3 Pencils ------- $" << smi.getsPrice(2)
					<< "\n\t4 Binder -------- $" << smi.getsPrice(3)
					<< "\n\t0      Return to Main Menu "
					<< "\nChoose the number to the item you wish add to your cart (1 - 4), then press Enter: ";
					cin >> select;
					if (select != 0)
						smi.suppliesAdd(select);
				    break;
			case 6: cin.clear();
					cin.ignore(100, '\n');
					cout << "\n\t-----Tobacco Products-----"
					     << "\n\t1 Cigarettes ---- $" << smi.gettPrice(0)
				         << "\n\t2 Cigars -------- $" << smi.gettPrice(1)
					     << "\n\t3 Snuff --------- $" << smi.gettPrice(2)
					     << "\n\t4 Pipe ---------- $" << smi.gettPrice(3)
					     << "\n\t0      Return to Main Menu "
					     << "\nChoose the number to the item you wish add to your cart (1 - 4), then press Enter: ";
					     cin >> select;
					if (select != 0)
						smi.tobaccoAdd(select);
				    break;
			case 9: cout << endl; 
				    smi.displayTotals();
                   break;
			default: cout << "\nInvalid input. Please select one of the following selections"<< endl;
			       break;
		}//end of switch
		if (option == 9)//When the totals are displayed, the program will end
		{
			cout <<"\nEnter any key to exit.... ";
			cin >> option;
			return 0;
		}
      else
	     displayMenu();//Otherwise the main menu will be displayed again
}

 
