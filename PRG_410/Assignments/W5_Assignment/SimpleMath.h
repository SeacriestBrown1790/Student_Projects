
#ifndef SimpleMath_H
#define SimpleMath_H

class SimpleMath
{
public:
	double getcPrice(int i);
	double getbPrice(int i);
	double getgrPrice(int i);
	double getgaPrice(int i);
	double getsPrice(int i);
	double gettPrice(int i);
	
	void clothAdd(int i);
	void beautyAdd(int i);
	void groceryAdd(int i);
	void gardenAdd(int i);
	void suppliesAdd(int i);
	void tobaccoAdd(int i);
	
	void calcCloth();
	void calcBeauty();
	void calcGrocery();
	void calcGarden();
	void calcSupplies();
	void calcTobacco();
	
	void displayTotals();
	void calcTotal();
   
   SimpleMath();
	 
private:
	double total1=0, total2=0, total3=0, total4=0, total5=0, total6=0, finalTotal=0;
};

#endif
