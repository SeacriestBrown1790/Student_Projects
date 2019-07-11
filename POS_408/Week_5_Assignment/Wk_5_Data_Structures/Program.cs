/////////////////////////////////////////////
////                                     ////
////           Data Structures           ////
////           Seacriest Brown           ////
////              POS/408                ////
////           April 29, 2019            ////  
////             Jon Jensen              ////
////                                     //// 
/////////////////////////////////////////////

// This program takes information from a text file, reads the file, 
// puts that infomation into a struct, then it makes calculations and
// displays that information.

using System;
using System.IO;

namespace Wk_5_Data_Structures
{
    class Program
    {
        public struct Employee
        {
            private string first, last, address, pay, tax;
            private double mPay, mTax, yPay, yTax, mNetPay, yNetPay;

            public Employee(string f, string l, string a, string p, string t)
            {
                this.first = f;
                this.last = l;
                this.address = a;
                this.pay = p;
                this.tax = t;
                mPay = Convert.ToDouble(pay);
                yPay = 0;
                mTax = 0;
                yTax = 0;
                mNetPay = 0;
                yNetPay = 0;

                if (tax == "1") // W2 calculations for type 1.
                {
                    mTax = mPay * .07;
                    yPay = mPay * 12;
                    yTax = (mPay * 12) * .07;
                    mNetPay = mPay - mTax;
                    yNetPay = yPay - yTax;
                    tax = "W2";
                }
                else if (tax == "2") // 1099 calculations for type 2.
                {
                    yPay = mPay * 12;
                    tax = "1099";
                }
                Console.WriteLine(" Name: {0} {1}", first, last);
                Console.WriteLine(" Address: {0}", address);
                Console.WriteLine(" Monthly Gross Pay: {0}", mPay.ToString("C")); 
                Console.WriteLine(" Yearly Gross Pay: {0}", yPay.ToString("C"));
                Console.WriteLine(" Employee Type: {0}", tax);
                Console.WriteLine(" Monthly Taxes: {0}", mTax.ToString("C"));
                Console.WriteLine(" Yearly Taxes: {0}", yTax.ToString("C"));
                if (mNetPay != 0) // Will only show the net pay for W2 employees.
                {
                    Console.WriteLine(" Monthly Net Pay: {0}", mNetPay.ToString("C"));
                    Console.WriteLine(" Yearly Net Pay: {0}", yNetPay.ToString("C"));
                }
                Console.WriteLine("");
            }

        }
        static private void ReadFile() // Method for reading the file.
        {
            using (StreamReader sr = new StreamReader("data.txt"))
            {
                int number = 0;
                String line; // Variable for loop control.
                while ((line = sr.ReadLine()) != null) 
                {
                    ++number;
                    string[] info = line.Split(','); // Reads until a ',' is reached then moves to the next element.

                    string fname = info[0];
                    string lname = info[1];
                    string address = info[2];
                    string pay = info[3];
                    string type = info[4];
                    Console.WriteLine(" *** Developer #{0} ***", number);
                    Employee em = new Employee(fname, lname, address, pay, type); // Takes the data from the line and runs it through the Employee structure.
                }
            }
        }

        static void Main(string[] args)
        {
            string s = "\n\t****** SDB Software Inc. ******" +
                       "\n\t**                           **" +
                       "\n\t**          Welcome          **" +
                       "\n\t**            to             **" +
                       "\n\t**        SDB Software       **" +
                       "\n\t**                           **" +
                       "\n\t*******************************";

            Console.WriteLine(s);
            Console.WriteLine("\n Thank you for using our app today!");

            // Displays information
            Console.WriteLine("\n ******* Developer Information *******\n");
            ReadFile();
            Console.ReadKey();
        }
    }
}

