/////////////////////////////////////////////
////                                     ////
////          List Collections           ////
////           Seacriest Brown           ////
////              POS/409                ////
////            May 13, 2019             ////  
////            Regina Jensen            ////
////                                     //// 
/////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Wk2_List_Collections
{
    class Program
    {
        static List<string> header = new List<string>();
        static List<string> em1 = new List<string>();
        static List<string> em2 = new List<string>();
        static List<string> em3 = new List<string>();
        static List<string> em4 = new List<string>();

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
        static W2 Emp1;
        static T1099 Emp2;
        static T1099 Emp3;
        static W2 Emp4;

        public class Employee
        {
            public string First, Last, Address, Age, Gross, ID, DevType, TaxType;
            public double pay, a_pay, a_tax, a_net;
        }
        class W2 : Employee
        {
            public W2(string f, string l, string ad, string ag, string gr, string i, string d, string t)
            {
                First = f;
                Last = l;
                Address = ad;
                Age = ag;
                Gross = gr;
                ID = i;
                DevType = d;
                TaxType = t;
            }
            public void AnnualTax()
            {
                pay = Convert.ToDouble(Gross);
                a_pay = pay * 12;
                a_tax = a_pay * .15;
            }
            public void AnnualNetPay()
            {
                a_net = a_pay - a_tax;
            }
        }
        class T1099 : Employee
        {
            public T1099(string f, string l, string ad, string ag, string gr, string i, string d, string t)
            {
                First = f;
                Last = l;
                Address = ad;
                Age = ag;
                Gross = gr;
                ID = i;
                DevType = d;
                TaxType = t;
            }
            public void AnnualTax()
            {
                pay = Convert.ToDouble(Gross);
                a_pay = pay * 12;
                a_tax = 0;
            }
            public void AnnualNetPay()
            {
                a_net = a_pay;
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
                                header.Add(info[i]);
                            }
                            header.Add("AnnualTax");
                            header.Add("AnnualNetPay");
                            break;
                        case 2:
                            for (int i = 0; i < info.Length; i++)
                            {
                                em1.Add(info[i]);
                            }
                            Emp1 = new W2(em1[0], em1[1], em1[2], em1[3], em1[4], em1[5], em1[6], em1[7]);
                            break;
                        case 3:
                            for (int i = 0; i < info.Length; i++)
                            {
                                em2.Add(info[i]);
                            }
                            Emp2 = new T1099(em2[0], em2[1], em2[2], em2[3], em2[4], em2[5], em2[6], em2[7]);
                            break;
                        case 4:
                            for (int i = 0; i < info.Length; i++)
                            {
                                em3.Add(info[i]);
                            }
                            Emp3 = new T1099(em3[0], em3[1], em3[2], em3[3], em3[4], em3[5], em3[6], em3[7]);
                            break;
                        case 5:
                            for (int i = 0; i < info.Length; i++)
                            {
                                em4.Add(info[i]);
                            }
                            Emp4 = new W2(em4[0], em4[1], em4[2], em4[3], em4[4], em4[5], em4[6], em4[7]);
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

            Emp1.AnnualTax();
            Emp1.AnnualNetPay();
            em1[4] = Emp1.pay.ToString("C");
            em1.Add(Emp1.a_tax.ToString("C"));
            em1.Add(Emp1.a_net.ToString("C"));

            Emp2.AnnualTax();
            Emp2.AnnualNetPay();
            em2[4] = Emp2.pay.ToString("C");
            em2.Add(Emp2.a_tax.ToString("C"));
            em2.Add(Emp2.a_net.ToString("C"));

            Emp3.AnnualTax();
            Emp3.AnnualNetPay();
            em3[4] = Emp3.pay.ToString("C");
            em3.Add(Emp3.a_tax.ToString("C"));
            em3.Add(Emp3.a_net.ToString("C"));

            Emp4.AnnualTax();
            Emp4.AnnualNetPay();
            em4[4] = Emp4.pay.ToString("C");
            em4.Add(Emp4.a_tax.ToString("C"));
            em4.Add(Emp4.a_net.ToString("C"));



            Form1 myform;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            myform = new Form1();
            Application.Run(myform);
        }
    }
}
