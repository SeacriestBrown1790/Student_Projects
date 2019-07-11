/////////////////////////////////////////////
////                                     ////
////           Error Handling            ////
////           Seacriest Brown           ////
////              POS/408                ////
////           April 22, 2019            ////  
////             Jon Jensen              ////
////                                     //// 
/////////////////////////////////////////////

// This program takes user inputs for first names, last names, addresses, monthly pay, and tax types
// of the three employees. Each input should have a correction check for empty and valid inputs. 

using System;
using System.Linq;

namespace Wk_4_ErrorHandling
{
    class Program
    {
        // static variables used for correcting user inputs.
        static string input;
        static char key;
        static double pay;

        static void Main(string[] args)
        {
            string s = "\n\t****** SDB Software Inc. ******" +
                       "\n\t**                           **" +
                       "\n\t**          Welcome          **" +
                       "\n\t**            to             **" +
                       "\n\t**        SDB Software       **" +
                       "\n\t**                           **" +
                       "\n\t*******************************";

            int dev = 0;
            Employee em1 = new Employee();
            Employee em2 = new Employee();
            Employee em3 = new Employee();

            Console.WriteLine(s);
            Console.WriteLine("\n Thank you for using our app today!");

            ++dev;
            Console.WriteLine("\n ***** Developer #{0}'s Information *****", dev);
            Console.WriteLine(" --Press 'Enter' after each finished input--");
            Console.Write(" First Name: ");
            input = Console.ReadLine();
            Name_Check(input); //Runs the name through the name checker
            em1.first = input;
            Console.Write(" Last Name: ");
            input = Console.ReadLine();
            Name_Check(input); //Runs the name through the name checker
            em1.last = input;
            Console.Write(" Address: ");
            input = Console.ReadLine();
            Address_Check(input); // Runs the address through the address checker
            em1.address = input;
            Console.Write(" Monthly Pay: ");
            input = Console.ReadLine();
            Pay_Check(input); // Run through the number checking method.
            em1.mpay = pay;
            Console.Write(" Tax Type ('1' for W2, '2' for 1099): ");
            key = Console.ReadKey().KeyChar;
            em1.t = Tax_Type(key);
            Console.WriteLine("");

            ++dev;
            Console.WriteLine("\n ***** Developer #{0}'s Information *****", dev);
            Console.WriteLine(" --Press 'Enter' after each finished input--");
            Console.Write(" First Name: ");
            input = Console.ReadLine();
            Name_Check(input); //Runs the name through the name checker
            em2.first = input;
            Console.Write(" Last Name: ");
            input = Console.ReadLine();
            Name_Check(input); //Runs the name through the name checker
            em2.last = input;
            Console.Write(" Address: ");
            input = Console.ReadLine();
            Address_Check(input); // Runs the address through the address checker
            em2.address = input;
            Console.Write(" Monthly Pay: ");
            input = Console.ReadLine();
            Pay_Check(input); // Run through the number checking method.
            em2.mpay = pay;
            Console.Write(" Tax Type ('1' for W2, '2' for 1099): ");
            key = Console.ReadKey().KeyChar;
            em2.t = Tax_Type(key);
            Console.WriteLine("");

            ++dev;
            Console.WriteLine("\n ***** Developer #{0}'s Information *****", dev);
            Console.WriteLine(" --Press 'Enter' after each finished input--");
            Console.Write(" First Name: ");
            input = Console.ReadLine();
            Name_Check(input); //Runs the name through the name checker
            em3.first = input;
            Console.Write(" Last Name: ");
            input = Console.ReadLine();
            Name_Check(input); //Runs the name through the name checker
            em3.last = input;
            Console.Write(" Address: ");
            input = Console.ReadLine();
            Address_Check(input); // Runs the address through the address checker
            em3.address = input;
            Console.Write(" Monthly Pay: ");
            input = Console.ReadLine();
            Pay_Check(input); // Run through the number checking method.
            em3.mpay = pay;
            Console.Write(" Tax Type ('1' for W2, '2' for 1099): ");
            key = Console.ReadKey().KeyChar;
            em3.t = Tax_Type(key);
            Console.WriteLine("");

            // Displays information
            Console.WriteLine("\n ******* Developer Information *******\n");
            em1.number = 1;
            em2.number = 2;
            em3.number = 3;
            em1.Display();
            em2.Display();
            em3.Display();
            Console.ReadKey();
        }
        public static bool IsEmpty(string e) // Checks for empty inputs, runs in every input check method.
        {
            if (e == "")
                return true;
            else
                return false;
        }
        public static void Name_Check(string s) // Method for checking valid user input for Name.
        {
            string str = ""; //Resets the 'str' variable every test.
            bool anyDigits = false; //Resets the 'anyDigits' variable every test.
            str = s;
            if (IsEmpty(s))
            {
                Console.Write(" ---Please enter a name: ");
                str = Console.ReadLine();
                Name_Check(str);
            }
            anyDigits = str.Any(char.IsDigit);
            while (anyDigits == true)
            {
                Console.WriteLine(" ---No numbers in names.");
                Console.Write(" Please enter a valid name to continue: ");
                str = Console.ReadLine();
                anyDigits = str.Any(char.IsDigit);
            }
            input = str;
        }
        public static void Address_Check(string a)
        {
            string ad = "";
            if (IsEmpty(a))
            {
                Console.Write(" ---Please enter an address: ");
                ad = Console.ReadLine();
                Address_Check(ad);
            }
            else
                input = a;
        }
        public static void Pay_Check(string s) //Method for checking valid user input for Monthly Pay.
        {
            double num;
            string str = "";
            string em = "";
            if (IsEmpty(s))
            {
                Console.Write(" ---Please enter a number: ");
                em = Console.ReadLine();
                Pay_Check(em);
            }
            else
            {
                try
                {
                    num = Convert.ToDouble(s);
                    pay = num;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(" ---" + ex.Message);
                    Console.Write("Please enter a valid number to continue: ");
                    str = Console.ReadLine();
                    Pay_Check(str);
                }
            }
        }
        public static char Tax_Type(char i) // Method for checking valid user input for Tax Type.
        {
            char t = i;
            while (t != '1' && t != '2')
            {
                Console.WriteLine("\n ---Only '1' or '2' are valid inputs.");
                Console.Write(" Please enter just 1 (for W2) or 2 (for 1099): ");
                t = Console.ReadKey().KeyChar;
            }
            return t;
        }
    }

    // Class to make calculations and display employee information.
    public class Employee
    {
        public int number; // For Developer numbering purposes.
        public string first;
        public string last;
        public string address;
        public double mpay;
        public char t;
        public string type = ""; // 'type' is determined by the if statement.
        double mtax = 0;
        double ypay = 0;
        double ytax = 0;

        public void Display()
        {
            if (t == '1') // W2 calculations for type 1.
            {
                mtax = mpay * .07;
                ypay = mpay * 12;
                ytax = (mpay * 12) * .07;
                type = "W2";
            }
            else if (t == '2') // 1099 calculations for type 2.
            {
                ypay = mpay * 12;
                type = "1099";
            }
            Console.WriteLine(" ****** Developer #{0} ******", number);
            Console.WriteLine(" Name: {0} {1}", first, last);
            Console.WriteLine(" Address: {0}", address);
            Console.WriteLine(" Monthly Pay: {0}", mpay.ToString("C")); // ToString("C") for converting the numbers into money values.
            Console.WriteLine(" Yearly Pay: {0}", ypay.ToString("C"));
            Console.WriteLine(" Employee Type: {0}", type);
            Console.WriteLine(" Monthly Taxes: {0}", mtax.ToString("C"));
            Console.WriteLine(" Yearly Taxes: {0}", ytax.ToString("C") + "\n");
        }
    }
}

