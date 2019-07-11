/////////////////////////////////////////////
////                                     ////
////               JSON                  ////
////           Seacriest Brown           ////
////              POS/409                ////
////            May 27, 2019             ////  
////            Regina Jensen            ////
////                                     //// 
/////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Wk4_JSON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Class to create a List<T> for JSON information.
        public class EmployeeList
        {
            private List<Employee> Emps { get; set; }
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
            

            // List<T> object for holding the JSON file information.
            List<Employee> empList = new List<Employee>();
            
            using (StreamReader sr = new StreamReader("data.json"))
            {
                string jsonFile = sr.ReadToEnd();
                empList = JsonConvert.DeserializeObject<List<Employee>>(jsonFile);
            }
            // 'match' for seacrhing and placing the right block of employee information
            // within the proper class. First names are used for filtering. 
            Employee match = empList.Find(em => em.FirstName == "John");
            var emp1 = new W2
            {
                FirstName = match.FirstName,
                LastName = match.LastName,
                Address = match.Address,
                Age = match.Age,
                GrossMoPay = match.GrossMoPay,
                DeptID = match.DeptID,
                DevType = match.DevType,
                TaxType = match.TaxType
            };
            emp1.AnnualPay = Convert.ToDouble(emp1.GrossMoPay);
            emp1.TaxCalc();
            string[] item = emp1.GetInfo();
            var im = new ListViewItem(item);
            listView1.Items.Add(im);

            match = empList.Find(em => em.FirstName == "Mary");
            var emp2 = new T1099
            {
                FirstName = match.FirstName,
                LastName = match.LastName,
                Address = match.Address,
                Age = match.Age,
                GrossMoPay = match.GrossMoPay,
                DeptID = match.DeptID,
                DevType = match.DevType,
                TaxType = match.TaxType
            };
            emp2.AnnualPay = Convert.ToDouble(emp2.GrossMoPay);
            emp2.TaxCalc();
            item = emp2.GetInfo();
            im = new ListViewItem(item);
            listView1.Items.Add(im);

            match = empList.Find(em => em.FirstName == "Angela");
            var emp3 = new T1099
            {
                FirstName = match.FirstName,
                LastName = match.LastName,
                Address = match.Address,
                Age = match.Age,
                GrossMoPay = match.GrossMoPay,
                DeptID = match.DeptID,
                DevType = match.DevType,
                TaxType = match.TaxType
            };
            emp3.AnnualPay = Convert.ToDouble(emp3.GrossMoPay);
            emp3.TaxCalc();
            item = emp3.GetInfo();
            im = new ListViewItem(item);
            listView1.Items.Add(im);

            match = empList.Find(em => em.FirstName == "Michael");
            var emp4 = new W2
            {
                FirstName = match.FirstName,
                LastName = match.LastName,
                Address = match.Address,
                Age = match.Age,
                GrossMoPay = match.GrossMoPay,
                DeptID = match.DeptID,
                DevType = match.DevType,
                TaxType = match.TaxType
            };
            emp4.AnnualPay = Convert.ToDouble(emp4.GrossMoPay);
            emp4.TaxCalc();
            item = emp4.GetInfo();
            im = new ListViewItem(item);
            listView1.Items.Add(im);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        // For formating GrossMoPay.
        static public string FormatString(string c)
        {
            double num = Convert.ToDouble(c);
            return c = num.ToString("C");
        }
        public class Employee
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
            public string Age { get; set; }
            public string GrossMoPay { get; set; }
            public string DeptID { get; set; }
            public string DevType { get; set; }
            public string TaxType { get; set; }
            static private string AnnualTax { get; set; }
            static private string AnnualNetPay { get; set; }
            public double AnnualPay { get; set; }
            public double AT = Convert.ToDouble(AnnualTax);
            public double ANP = Convert.ToDouble(AnnualNetPay);
            public string Tax, NetPay;

            // For returning an array of the elements of the class. 
            public string[] GetInfo()
            {
                string[] list =
                {
                  FirstName,
                  LastName,
                  Address,
                  Age,
                  FormatString(GrossMoPay),
                  DeptID,
                  DevType,
                  TaxType,
                  Tax,
                  NetPay,
                };
                return list;
            }
        }
        class W2 : Employee
        {
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
        
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void form1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void employeeListBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
