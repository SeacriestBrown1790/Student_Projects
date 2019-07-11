/////////////////////////////////////////////
////                                     ////
////           Branching In C#           ////
////           Seacriest Brown           ////
////              POS/408                ////
////           April 15, 2019            ////  
////             Jon Jensen              ////
////                                     //// 
/////////////////////////////////////////////

using System;

namespace Wk_3_BranchingInCSharp
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
            string name1, name2, name3;
            string address1, address2, address3;
            string input; //String variable for converting to the double 'mpay' variables
            double mpay1, mpay2, mpay3; //Variables to be passed through the calculation methods

            Console.WriteLine(s);
            Console.WriteLine("\n Thank you for using our app today!");
            Console.WriteLine("\n ***** Enter the 1st Developer's Information *****");
            Console.WriteLine("\n  --Press 'Enter' after each finished input--");

            Console.Write("\n First & Last Name: ");
            name1 = Console.ReadLine();
            Console.Write("\n Address: ");
            address1 = Console.ReadLine();
            Console.Write("\n Monthly Pay: ");
            input = Console.ReadLine();
            mpay1 = Convert.ToDouble(input);

            Console.WriteLine("\n ***** Enter the 2nd Developer's Information *****");
            Console.WriteLine("\n  --Press 'Enter' after each finished input--");
            Console.Write("\n First & Last Name: ");
            name2 = Console.ReadLine();
            Console.Write("\n Address: ");
            address2 = Console.ReadLine();
            Console.Write("\n Monthly Pay: ");
            input = Console.ReadLine();
            mpay2 = Convert.ToDouble(input);

            Console.WriteLine("\n ***** Enter the 3rd Developer's Information *****");
            Console.WriteLine("\n  --Press 'Enter' after each finished input--");
            Console.Write("\n First & Last Name: ");
            name3 = Console.ReadLine();
            Console.Write("\n Address: ");
            address3 = Console.ReadLine();
            Console.Write("\n Monthly Pay: ");
            input = Console.ReadLine();
            mpay3 = Convert.ToDouble(input);

            Console.WriteLine("\n ***** 1st Developer *****");
            Console.WriteLine("\n Name: " + name1);
            Console.WriteLine("\n Address: " + address1);
            Console.WriteLine("\n Monthly Pay: $" + mpay1);
            Console.WriteLine("\n Monthly Tax: $" + MonthTax(mpay1));
            Console.WriteLine("\n Yearly Pay: $" + YearlyPay(mpay1));
            Console.WriteLine("\n Yearly Tax: $" + YearlyTax(mpay1) +"\n");

            Console.WriteLine("\n ***** 2nd Developer *****");
            Console.WriteLine("\n Name: " + name2);
            Console.WriteLine("\n Address: " + address2);
            Console.WriteLine("\n Monthly Pay: $" + mpay2);
            Console.WriteLine("\n Monthly Tax: $" + MonthTax(mpay2));
            Console.WriteLine("\n Yearly Pay: $" + YearlyPay(mpay2));
            Console.WriteLine("\n Yearly Tax: $" + YearlyTax(mpay2) + "\n");

            Console.WriteLine("\n ***** 3rd Developer *****");
            Console.WriteLine("\n Name: " + name3);
            Console.WriteLine("\n Address: " + address3);
            Console.WriteLine("\n Monthly Pay: $" + mpay3);
            Console.WriteLine("\n Monthly Tax: $" + MonthTax(mpay3));
            Console.WriteLine("\n Yearly Pay: $" + YearlyPay(mpay3));
            Console.WriteLine("\n Yearly Tax: $" + YearlyTax(mpay3));

            Console.ReadKey();
        }

        //Static return methods for calculating 
        //the month taxes, annual gross pays, and annual taxes 
        //of the three developers.
        //All returning values are rounded to two decimals
        //for money format.

        static double MonthTax(double mt)
        {
            mt = Math.Round(mt * .07, 2);
            return mt;
        }
        static double YearlyPay(double yp)
        {
            yp = Math.Round(yp * 12, 2);
            return yp;
        }
        static double YearlyTax(double yt)
        {
            yt = Math.Round((yt * 12)*.07, 2);
            return yt;
        }
    }
}

