/**********************************************************************
* Program:          PRG/420 Week 2 
* Purpose:          Week 2 Coding Assignment
* Programmer:       Seacriest Brown       
*  Class:           PRG/420       
*  Creation Date:   June 18,2018
*********************************************************************
*
**********************************************************************
*  Program Summary: This program demonstrates these basic Java concepts:
*                           - defining variables of different types
*                           - if-then and if-then-else logic
*                           - constructing a string to display on screen
*                           - switch logic
*
* To complete this assignment, you will add code where indicated. The
* behavior of your completed assignment should be to accept an input
* value for the number of sides of a two-dimensional figure. Based on that value, 
* your code should display the type of figure that corresponds to the number of polygon angles
* indicated (3=triangle, 4=rectangle, etc.)
*
* Here are the specific requirements:
*
* After the user types in a value from 3 to 5 inclusive (i.e., 3, 4, or 5):
*
* 1. Your code determines whether the input value is out of range (less than 3 or more than 5)
* and, if so, displays a meaningful error message on the screen and ends the program.
*
* 2. Because you will be comparing a single expression (the input value) to multiple constants (3, 4, and 5),
* your code should use a switch statement to display the following message onscreen:
*
*     If user inputs 3, onscreen message should say "A triangle has 3 sides."  
*     If user inputs 4, onscreen message should say "A rectangle has 4 sides."
*     If user inputs 5, onscreen message should see "A pentagon has 5 sides."
*
* 3. Be sure to test your program. This means running your program multiple
* times with test values 3, 4, 5, as well as at least two values that fall outside that range
* (one lower than the lowest and one higher than the highest) and making sure
* that the correct message displays for each value you input. Also be sure
* that running your program does not cause any compiler errors.
***********************************************************************/

// *** All comments were placed to show intended code use. ***

import java.util.Scanner;

public class PRG420Week2_CodingAssignment {

    public static void main(String[] args) {
               
        String userInputStringOfAngles;  // Declare a variable of type String to capture user input
        int numberOfAngles; // Declare a variable of type int to hold the converted user input

        Scanner myInputScannerInstance = new Scanner(System.in); // Recognize the keyboard
        System.out.print("Please type the integer 3, 4, or 5 and then press Enter: "); // Prompt the user
        userInputStringOfAngles= myInputScannerInstance.next(); // Capture user input as string
        numberOfAngles = Integer.parseInt(userInputStringOfAngles); // Convert the string to a number in case this will be useful later
        
        
        if (numberOfAngles < 3 || numberOfAngles > 5){    // Testing the user's input for the range asked
          System.out.println("Integer was not 3, 4, or 5. Please try again."); //Error message for out of range input
        }
            
        
        String shape;  // Declare string variable for switch
        switch (numberOfAngles){    //Reads the user's input for the switch cases
            case 3: shape = "A triangle has 3 sides."; // For input 3, this line will be printed
                break;
            case 4: shape = "A rectangle has 4 sides."; // For input 4, this line will be printed
                break;
            case 5: shape = "A pentagon has 5 sides."; // For input 5, this line will be printed
                break;
            default: shape = ""; // Any other inputs will print a blank
                break;           
        }
        System.out.println(shape);
           
      }
    }