/**************************************************************************************
* Program:     PRG/420 Week 3
* Purpose:     Week 3 Coding Assignment
* Programmer:  Seacriest Brown
* Class:       PRG/420
* Creation Date:  June 25, 2018
******************************************************************************************
* Program Summary:   For, while, and do-while loops; nested loops
*
* For this assignment, you will add code to create:
*
* a for loop nested inside another for loop
* a while loop
* a do-while loop

*****************************************************************************************/

// *** All comments were placed to show intended code use. ***

public class PRG420Week3_CodingAssignment 
{

    public static void main(String[] args) 
    {

    // The following code should print asterisks: 1 on line 1, 2 asterists on line 2,
    // 3 on line 3, 4 on line 4... for as many lines as the variable linesOfAsterisks.
    // To do this, we can use 2 nested for loops. The first for loop is coded for you.
    // You will need to add another for lop, NESTED INSIDE the first, that prints
    // a certain # of asterisks based on the # of times the loop code has been executed.
    // The result should look like this:
    // *
    // **
    // ***
    // ****
    // *****
    // etc.
        System.out.println("---LINE 1---");
    int linesOfAsterisks = 5;
    for (int i = 1; i <= linesOfAsterisks; i++) 
    { // for each line...
      for (int j=1;j<=i;j++) //adding the nested loop to handle printing of the asterisks
      {                      //as the variables 'i' and 'j' increase, so do the number of asterisks per line
      System.out.print("*");
      }
               
    System.out.println();
    }

    //////////////////////////////////////////////////////////////////////
    // Add a while or do-while loop that displays the numbers from 10 to 1 in that order, like so:
    // 10
    // 9
    // 8
    // 7
    // ...
    // 1
    //////////////////////////////////////////////////////////////////////

        System.out.println("\n---LINE 2---");
   int num=10; 
   do       //added a do-while loop
   {
       System.out.println(num); //the 'num' will be printed once
       num--;                   // then 'num' will be subtracted by one increment
   }while (num>0);              // this will continue until 'num' is less than 0

    ///////////////////////////////////////////////////////////////////////
    // Write a loop that adds 7s one at a time until the sum becomes > 157.
    // Then print out both the sum and the number of 7s that were aded.
    // Write a while or do-while loop, whichever you think is most appropriate.
    //////////////////////////////////////////////////////////////////////////
       
    int sum = 0;
    int numberOfSevens = 0;

        System.out.println("\n---LINE 3---");
      while (sum<157)       //added a while loop
      {
         numberOfSevens++;  //each loop will add 1 to the 'numberOfSevens
         sum=sum+7;         //the new 'sum' is made by adding the old 'sum' with 7
      }
      System.out.println("The sum: " + sum);                            //the total sum is displayed
      System.out.println("The number of sevens: " + numberOfSevens);    //the total number of sevens used are displayed
   }
}




