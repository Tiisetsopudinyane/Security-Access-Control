using SecurityAccessControl.BusinessLogic;
using SecurityAccessControl.SqlDataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurityAccessControl
{
    public partial class checklist : Form
    {
        public checklist()
        {
            InitializeComponent();
            btnVisitors.Enabled = false;
            btnEmployees.Enabled = false;
            sc = new ServiceClass();
            lblDate.Text = lblDate.Text + sc.myDate();
        }
        string selecteditemname;

        ServiceClass sc;
        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// switch value selected index and return string matching the index
        /// </summary>
        /// <returns>selecetditemname</returns>
        public string selectedItem()
        {
            if (cmbSearchList.SelectedIndex != -1)
            {
                switch (cmbSearchList.SelectedIndex)
                {
                    case 0:
                        selecteditemname = "Date";
                        break;
                    case 1:
                        selecteditemname = "idNumber";
                        break;
                    case 2:
                        selecteditemname = "email";
                        break;
                    case 3:
                        selecteditemname = "phoneNumber";
                        break;

                }
            }
           
            return selecteditemname;
        }


        /// <summary>
        /// searching using date,email,phone number and id number
        /// check if combobox is not selected for options if is not then return 
        /// else check if textbox is not empty if not retreive data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            ServiceClass sc = new ServiceClass();
            if (isDataGridViewClean())
            {
                if (cmbSearchList.SelectedIndex == -1)
                {
                    sc.LoadAccessList(dataGridView1);
                    lblsearch.Text = "";
                    return;
                }
                else if (txtsearch.Text != "")
                {
                        if (selectedItem().Equals("Date"))
                        {
                        
                            sc.SearchByDate(dataGridView1, txtsearch.Text);
                        }
                        else if (selectedItem().Equals("idNumber"))
                        {
                            sc.SearchByID(dataGridView1, txtsearch.Text);
                        }
                        else if (selectedItem().Equals("email"))
                        {
                            sc.SearchByEmail(dataGridView1, txtsearch.Text);
                        }
                        else if (selectedItem().Equals("phoneNumber"))
                        {
                            sc.SearchByPhoneNumber(dataGridView1, txtsearch.Text);
                        }
                }
                else if (txtsearch.Text == "")
                {
                    sc.LoadAccessList(dataGridView1);
                }
            }
            txtsearch.Text = "";
        }


        /// <summary>
        /// clean datagridview and return true if its clean
        /// </summary>
        /// <returns></returns>
        public bool isDataGridViewClean()
        {
            if (dataGridView1.Rows.Count >0)
            {
                dataGridView1.Rows.Clear();
            }
            return true;
        }

        private void cmbSearchList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ServiceClass sc = new ServiceClass();
            if (isDataGridViewClean())
            {
                if (selectedItem().Equals("Date"))
                {
                    sc.LoadAccessList(dataGridView1);
                    lblsearch.Text = "date format Day/Month/Year";
                }
                else
                {
                    sc.LoadAccessList(dataGridView1);
                    lblsearch.Text = "";
                }
            }
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            ServiceClass sc = new ServiceClass();
            if (isDataGridViewClean())
            {
                sc.LoadAccessList(dataGridView1);
            }
        }

        private void btnAllTimeData_Click(object sender, EventArgs e)
        {
            ServiceClass sc = new ServiceClass();
            if (isDataGridViewClean())
            {
                sc.LoadAllTimeData(dataGridView1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sc.Download();
        }
    }
}
