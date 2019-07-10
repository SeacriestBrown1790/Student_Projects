/************************************************************************************
* Program:        PRG/420 Week 5 
* Purpose:        Week 5 Coding Assignment
* Programmer:     Seacriest Brown       
* Class:          PRG/420       
* Creation Date:  July 9, 2018
*************************************************************************************
* Program Summary:   
*	This program converts a given date to a string.    
*     	The code includes exception handling for a ParseException. 
************************************************************************************/

// *** All comments were placed to show intended code use. ***

import java.util.*;     // wildcard to import all the util. classes 
import java.text.*;     // wildcard to import all the text classes   

public class PRG420Week5_CodingAssignment 
{

    public static void main(String[] args)
    {
    Calendar calendar = Calendar.getInstance(); 
    
      try //start of the try block
      {
         String str_date="01-Nov-17"; 
         DateFormat formatter = new SimpleDateFormat("dd-MMM-yy");  
         Date myFormattedDate; 
             
         myFormattedDate = formatter.parse(str_date);  
         
         System.out.println("-----LINE 1-----");    	
         System.out.println("The formatted date is " + myFormattedDate);
         System.out.println("Today is " + calendar.getTime()); 
         
         String errorDate = "01Nov17"; //The date format that will trigger the catch block
         myFormattedDate = formatter.parse(errorDate); 
         System.out.println(myFormattedDate);

      } catch (ParseException e)  //the catch block will print an error message for the 'errorDate'
        {
            System.out.println("-----LINE 2-----");
            System.out.println(e.getMessage());
        } 
  }
}