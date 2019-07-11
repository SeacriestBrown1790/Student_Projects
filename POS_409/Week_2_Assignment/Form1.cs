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
using System.Windows.Forms;

namespace Wk2_List_Collections
{
    public partial class Form1 : Form
    {
        Program pg = new Program(); // Object for accessing the Program.cs file.
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            for (int i = 0; i < 10; i++) // Loop for populating the Header row.
            {
                listView1.Columns.Add(pg.GetHeader(i), 0);
            }

            string[] info = new string[10]; // 'info' array for copying the arrays in the Program.cs file.
            ListViewItem item; // Variable for adding the 'info' elements to the next row.

            for (int i = 0; i < 10; i++)
                info[i] = pg.GetEm1(i);
            item = new ListViewItem(info);
            listView1.Items.Add(item);
            for (int i = 0; i < 10; i++)
                info[i] = pg.GetEm2(i);
            item = new ListViewItem(info);
            listView1.Items.Add(item);
            for (int i = 0; i < 10; i++)
                info[i] = pg.GetEm3(i);
            item = new ListViewItem(info);
            listView1.Items.Add(item);
            for (int i = 0; i < 10; i++)
                info[i] = pg.GetEm4(i);
            item = new ListViewItem(info);
            listView1.Items.Add(item);

            // For resizing the table, so everything is visible. 
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
