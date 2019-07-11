/////////////////////////////////////////////
////                                     ////
////           Record Objects            ////
////           Seacriest Brown           ////
////              POS/409                ////
////            May 6, 2019              ////  
////            Regina Jensen            ////
////                                     //// 
/////////////////////////////////////////////


using System;
using System.IO;
using System.Windows.Forms;

namespace Wk_1_Record_Objects
{
    class Program
    {
        // Array created with 10 slots to hold the 'data.txt' information
        // and the two added cells of AnnualTax and AnnualNetPay.
        static string[] header = new string[10];
        static string[] em1 = new string[10];
        static string[] em2 = new string[10];
        static string[] em3 = new string[10];
        static string[] em4 = new string[10];

        // Objects for the W2 & 1099 subclasses.
        static W2 emp1;
        static T1099 emp2;
        static T1099 emp3;
        static W2 emp4;

        // Get methods for retrieving the arrays into Form1.
        public string GetHeader(int i)
        {
            return header[i];
        }
        public string GetEm1(int i)
        {
            return em1[i];
        }
        public string GetEm2(int i)
        {
            return em2[i];
        }
        public string GetEm3(int i)
        {
            return em3[i];
        }
        public string GetEm4(int i)
        {
            return em4[i];
        }
        public class Employee
        {
            // Employee class created variables. 
            public string first, last, address, age, gross, id, dev, tax;
            public double pay, apay, atax, anet;

            public Employee() { }
        }
        class W2 : Employee
        {
            public W2(string f, string l, string ad, string ag, string gr, string i, string d, string t)
            {
                first = f;
                last = l;
                address = ad;
                age = ag;
                gross = gr;
                id = i;
                dev = d;
                tax = t;
                pay = Convert.ToDouble(gross); // Converted to double for calculations. 
                apay = pay * 12;
            }
            public void AnnualTax()
            {
                atax = apay * .15; // 15% tax calculated.
            }
            public void AnnualNetPay()
            {
                anet = apay - atax; // Net Pay equals the Annual Pay minus the Annual Tax.
            }
        }
        class T1099 : Employee
        {
            public T1099(string f, string l, string ad, string ag, string gr, string i, string d, string t)
            {
                first = f;
                last = l;
                address = ad;
                age = ag;
                gross = gr;
                id = i;
                dev = d;
                tax = t;
                pay = Convert.ToDouble(gross); // Converted to double for calculations. 
                apay = pay * 12;
            }
            public void AnnualTax()
            {
                atax = 0; // No taxes = no value here.
            }
            public void AnnualNetPay()
            {
                anet = apay; // With no tax substraction, net pay will equal annual pay.
            }
        }
        static public void ReadFile()
        {
            int num = 0; // For switch control.

            using (StreamReader sr = new StreamReader("data.txt"))
            {
                string f, l, ad, ag, gr, id, d, t;
                String line;

                while ((line = sr.ReadLine()) != null)
                {
                    ++num;

                    // 'info' array for holding the 'data.txt' information, before it is copied
                    // to its respective array. 
                    string[] info = line.Split(',');  
                    f = info[0];
                    l = info[1];
                    ad = info[2];
                    ag = info[3];
                    gr = info[4];
                    id = info[5];
                    d = info[6];
                    t = info[7];

                    // Switch for populating the different arrays.
                    // Once the 'em#' arrays are created, they are used
                    // to construct their respective classes. 
                    switch (num)
                    {
                        case 1: 
                            for (int i = 0; i < info.Length; i++)
                            {
                                header[i] = info[i];
                            }
                            header[8] = "AnnualTax";
                            header[9] = "AnnualNetPay";
                            break;
                        case 2:
                            for (int i = 0; i < info.Length; i++)
                            {
                                em1[i] = info[i];
                            }
                            emp1 = new W2(em1[0], em1[1], em1[2], em1[3], em1[4], em1[5], em1[6], em1[7]);
                            break;
                        case 3:
                            for (int i = 0; i < info.Length; i++)
                            {
                                em2[i] = info[i];
                            }
                            emp2 = new T1099(em2[0], em2[1], em2[2], em2[3], em2[4], em2[5], em2[6], em2[7]);
                            break;
                        case 4:
                            for (int i = 0; i < info.Length; i++)
                            {
                                em3[i] = info[i];
                            }
                            emp3 = new T1099(em3[0], em3[1], em3[2], em3[3], em3[4], em3[5], em3[6], em3[7]);
                            break;
                        case 5:
                            for (int i = 0; i < info.Length; i++)
                            {
                                em4[i] = info[i];
                            }
                            emp4 = new W2(em4[0], em4[1], em4[2], em4[3], em4[4], em4[5], em4[6], em4[7]);
                            break;
                    }
                }
            }
        }
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
        static void Main()
        {
            ReadFile();

            // After the file is read and the data is added to it respective array
            // and the calculations are completed.
            // Next, the elements that are money values are converted
            // before they are displayed. 
            emp1.AnnualTax();
            emp1.AnnualNetPay();
            em1[4] = emp1.pay.ToString("C");
            em1[8] = emp1.atax.ToString("C");
            em1[9] = emp1.anet.ToString("C");

            emp2.AnnualTax();
            emp2.AnnualNetPay();
            em2[4] = emp2.pay.ToString("C");
            em2[8] = emp2.atax.ToString("C");
            em2[9] = emp2.anet.ToString("C");

            emp3.AnnualTax();
            emp3.AnnualNetPay();
            em3[4] = emp3.pay.ToString("C");
            em3[8] = emp3.atax.ToString("C");
            em3[9] = emp3.anet.ToString("C");

            emp4.AnnualTax();
            emp4.AnnualNetPay();
            em4[4] = emp4.pay.ToString("C");
            em4[8] = emp4.atax.ToString("C");
            em4[9] = emp4.anet.ToString("C");

            Form1 myform;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            myform = new Form1();
            Application.Run(myform);


        }
    }
}
