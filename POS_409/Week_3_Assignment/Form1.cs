/////////////////////////////////////////////
////                                     ////
////               LINQ                  ////
////           Seacriest Brown           ////
////              POS/409                ////
////            May 20, 2019             ////  
////            Regina Jensen            ////
////                                     //// 
/////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace Wk3_LINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Add("FirstName");
            listView1.Columns.Add("LastName");
            listView1.Columns.Add("Address");
            listView1.Columns.Add("Age");
            listView1.Columns.Add("GrossMoPay");
            listView1.Columns.Add("DeptID");
            listView1.Columns.Add("DevType");
            listView1.Columns.Add("TaxType");
            listView1.Columns.Add("AnnaulTax");
            listView1.Columns.Add("AnnualNetPay");

            // LINQ query to separate the W2 employees into own file.
            var getW2 = from line in File.ReadLines("data.txt")
                        where (line.Contains("W2"))
                        select line;
            File.WriteAllLines(@"W2.txt", getW2);

            // LINQ query to separate the 1099 employees into own file.
            var get1099 = from line in File.ReadLines("data.txt")
                        where (line.Contains("1099"))
                        select line;
            File.WriteAllLines(@"1099.txt", get1099);

            // Reads the newly created W2 file to create and calculate W2 class
            using (StreamReader sr = new StreamReader("W2.txt"))
            {
                string line;
                while ((line = sr.ReadLine())!=null)
                {
                    string[] info = line.Split(',');
                    var w2 = new W2
                    {
                        First = info[0],
                        Last = info[1],
                        Address = info[2],
                        Age = info[3],
                        Gross = info[4],
                        ID = info[5],
                        DevType = info[6],
                        TaxType = info[7]
                    };
                    w2.AnnualPay = Convert.ToDouble(w2.Gross);
                    w2.TaxCalc();
                    
                    string[] w2row =
                        { w2.First, w2.Last, w2.Address, w2.Age,
                        FormatString(w2.Gross),w2.ID,w2.DevType,w2.TaxType,w2.Tax,w2.NetPay};
                        var w2Item = new ListViewItem(w2row);
                        listView1.Items.Add(w2Item);
                }
            }
            // Reads the newly created 1099 file to create and calculate 1099 class
            using (StreamReader sr = new StreamReader("1099.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] info = line.Split(',');
                    var t99 = new T1099
                    {
                        First = info[0],
                        Last = info[1],
                        Address = info[2],
                        Age = info[3],
                        Gross = info[4],
                        ID = info[5],
                        DevType = info[6],
                        TaxType = info[7]
                    };
                    t99.AnnualPay = Convert.ToDouble(t99.Gross);
                    t99.TaxCalc();

                    string[] t99row =
                        { t99.First, t99.Last, t99.Address, t99.Age,
                        FormatString(t99.Gross),t99.ID,t99.DevType,t99.TaxType,t99.Tax,t99.NetPay};
                    var t99Item = new ListViewItem(t99row);
                    listView1.Items.Add(t99Item);
                }
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        static public string FormatString(string c)
        {
            double num = Convert.ToDouble(c);
            return c = num.ToString("C");
        }
        abstract class Employee
        {
            public string First { get; set; }
            public string Last{ get; set; }
            public string Address { get; set; }
            public string Age { get; set; }
            public string Gross { get; set; }
            public string ID { get; set; }
            public string DevType { get; set; }
            public string TaxType { get; set; }
            static public string AnnualTax { get; set; }
            static public string AnnualNetPay { get; set; }
            public double AnnualPay { get; set; }
            public double AT = Convert.ToDouble(AnnualTax);
            public double ANP = Convert.ToDouble(AnnualNetPay);
            public string Tax, NetPay;
    }
        class W2 : Employee
        {
            public string TempTax = AnnualTax;
            public void TaxCalc()
            {
                AnnualPay *= 12;
                AT = AnnualPay * .15;
                ANP = AnnualPay - AT;
                Tax = AT.ToString("C");
                NetPay = ANP.ToString("C");
            }
        }
        class T1099 : Employee
        {
            public void TaxCalc()
            {
                AnnualPay *= 12;
                ANP = AnnualPay;
                Tax = AT.ToString("C");
                NetPay = ANP.ToString("C");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
