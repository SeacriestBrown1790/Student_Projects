/**********************************************************************
* Program:        PRG/420 Week 4 
* Purpose:        Week 4 Coding Assignment
* Programmer:     Seacriest Brown       
* Class:          PRG/420       
* Creation Date:  July 2, 2018
*********************************************************************
*
**********************************************************************
*  Program Summary: This program demonstrates these basic Java concepts:
*     - Creating an array based on user input
*     - Accessing and displaying elements of the array
* 
* The program should declare an array to hold 10 integers.
* The program should then ask the user for an integer.
* The program should populate the array by assigning the user-input integer
* to the first element of the array, the value of the first element + 100 to
* the second element of the array, the value of the second element + 100 to
* the third element of the array, the value of third element + 100 to
* the fourth element of the array, and so on until all 10 elements of the
* array are populated.
* 
* Then the program should display the values of each of the array
* elements onscreen. For example, if the user inputs 4, the output
* should look like this:
* 
* Enter an integer and hit Return: 4
* Element at index 0: 4
* Element at index 1: 104
* Element at index 2: 204
* Element at index 3: 304
* Element at index 4: 404
* Element at index 5: 504
* Element at index 6: 604
* Element at index 7: 704
* Element at index 8: 804
* Element at index 9: 904
***********************************************************************/

// *** All comments were placed to show intended code use. ***

import java.util.Scanner;

public class PRG420Week4_CodingAssignment 
{

    public static void main(String[] args) 
    {
        int[] numbers = new int[10]; //Declaring an array of integers and allocating memory for 10 integers
     
        Scanner myInputScannerInstance = new Scanner(System.in); 
        
        System.out.print("Enter an integer and hit Return: ");
    
        int myFirstArrayElement = Integer.parseInt(myInputScannerInstance.next());
        
        numbers[0] = myFirstArrayElement; //Assigning the user's input as the first element in the array
        int sum=0;  //Made a 'sum' variable to handle adding the hundreds to the array elements
         
         for (int i=0;i < numbers.length;i++) //Created a 'for' loop to run through the array
            {
               numbers[i] = numbers[i] + sum;    //The current element in the loop is added to the current sum in the loop
               System.out.println("Element at index " + i + ": " + numbers[i]); //Displays the element index and current element in the array loop
               sum = numbers[i]+100;  //Makes the sum the current element in the array and add 100 to it
            }


    }
}