/////////////////////////////////////////////
////                                     ////
////          Adding Variables           ////
////           Seacriest Brown           ////
////              POS/408                ////
////            April 8, 2019            ////  
////             Jon Jensen              ////
////                                     //// 
/////////////////////////////////////////////

using System;

namespace Wk_2_AddingVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "\n\t****** SDB Software Inc. ******" +
                       "\n\t**                           **" +
                       "\n\t**          Welcome          **" +
                       "\n\t**            to             **" +
                       "\n\t**        SDB Software       **" +
                       "\n\t**                           **" +
                       "\n\t*******************************";
            //Declared variables
            string firstname, lastname, address, input;
            double pay, taxes;

            Console.WriteLine(s);
            Console.WriteLine("\n Thank you for using our app today!");

            Console.Write("\n Please write the 'first' name(press Enter when finished): ");
            firstname = Console.ReadLine();

            Console.Write("\n Please write the 'last' name(press Enter when finished): ");
            lastname = Console.ReadLine();

            Console.Write("\n What is the address?(press Enter when finished): ");
            address = Console.ReadLine();

            Console.Write("\n What is the monthly gross pay?(press Enter when finished): ");
            input = Console.ReadLine(); //ReadLine takes 'input' as string
            pay = Convert.ToDouble(input); //Converts 'input' to double for the 'pay' variable
            taxes = Math.Round(pay * .07, 2);//Calculates the tax of monthly pay and rounds to two decimal places

            Console.WriteLine("\n *********************************");
            Console.WriteLine("\n ***** Name: " + firstname + " " + lastname);
            Console.WriteLine("\n ***** Address: " + address);
            Console.WriteLine("\n ***** Monthly Pay: $" + pay);
            Console.WriteLine("\n ***** Payment of Taxes: $" + taxes);
            Console.WriteLine("\n *********************************");
            Console.ReadKey();





        }
    }
}

