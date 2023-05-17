using SecurityAccessControl.BusinessLogic;
using SecurityAccessControl.SqlDataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurityAccessControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnEmployees.Enabled=false;
            btnVisitors.Enabled = false;
        }
        ServiceClass sc = new ServiceClass();
        SqlDataaccess sda = new SqlDataaccess();
        checklist cl = new checklist();
        private void btnCheckIn_Click_1(object sender, EventArgs e)
        {
            if (isNotEmpty())
            {
                if (emailValidation() && PhoneValidation() && IdNumberValidation())
                {
                    cl.dataGridView1.Rows.Clear();
                    sc.CreateAccess(txtfirstname.Text.ToString(), txtlastname.Text.ToString(), txtemail.Text, txtid.Text, txtphone.Text, txtreasontovisit.Text.ToString(), txtpersonyouvisit.Text.ToString(), txtvehicleregistration.Text.ToString(), txthomeaddress.Text.ToString());
                    EmptyText();
                    sc.LoadAccessList(cl.dataGridView1);
                    lblError.Text = "";
                    cl.ShowDialog();
                }
                else lblError.Text = "one of your Emails,Phone or ID Number is invalid";
               
            }
            else if(!isNotEmpty())
            {
                lblError.Text = "must fill all your details"; 
                return;
            }
           
        }
        public bool isNotEmpty()
        {

            if (txtfirstname.Text == "" || txtlastname.Text == "" || txtemail.Text == "" || txtid.Text == "" || txtphone.Text == "" || txtreasontovisit.Text == "" || txtpersonyouvisit.Text == "" || txtvehicleregistration.Text == "" || txthomeaddress.Text == "")
            {
                return false;
            }
            else return true;
        }

        public bool emailValidation()
        {
            Regex regex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            bool isValidEmail = regex.IsMatch(txtemail.Text);
            if (!isValidEmail)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }
        public bool IdNumberValidation()
        {
            Regex regex = new Regex(@"^([0-9]{13})");
            bool isValidIDNumber = regex.IsMatch(txtid.Text);
            if (!isValidIDNumber)
            {
                return false;
            }
            else return true;
            
        }

        public bool PhoneValidation()
        {
            Regex regex = new Regex(@"^([+]|[0-9]{10,13})");
            bool isValidNumber = regex.IsMatch(txtphone.Text);
            if (!isValidNumber)
            {
                return false;
            }
            else return true;

        }
        public bool nameValidation()
        {
            Regex regex = new Regex(@"^([a-zA-Z]{3,})");
            bool isValidFirstname = regex.IsMatch(txtfirstname.Text);
            bool isvalidLastname = regex.IsMatch(txtlastname.Text);
            if (!isValidFirstname && !isvalidLastname)
            {
                return false;
            }
            else return true;

        }

        public void EmptyText()
        {
            txtfirstname.Text = "";
            txtlastname.Text = "";
            txtemail.Text = "";
            txtid.Text = "";
            txtphone.Text = "";
            txtreasontovisit.Text = "";
            txtpersonyouvisit.Text = "";
            txtvehicleregistration.Text = "";
            txthomeaddress.Text = "";
        }
        
        private void btnCheckList_Click(object sender, EventArgs e)
        {
            cl.dataGridView1.Rows.Clear();
            EmptyText();
            lblError.Text = "";
            sc.LoadAccessList(cl.dataGridView1);
            cl.ShowDialog();
        }

    }
}
