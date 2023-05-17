
using System.Drawing;
using System.Windows.Forms;

namespace SecurityAccessControl
{
    partial class checklist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnVisitors = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDNUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasontovisit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personyouvisit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleregistration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeaddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbSearchList = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAllTimeData = new System.Windows.Forms.Button();
            this.lblsearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(506, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "SECURITY ACCESS CONTROL";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(38, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(549, 48);
            this.panel2.TabIndex = 32;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckIn.BackColor = System.Drawing.Color.Olive;
            this.btnCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCheckIn.Location = new System.Drawing.Point(612, 417);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(150, 48);
            this.btnCheckIn.TabIndex = 6;
            this.btnCheckIn.Text = "CHECK IN";
            this.btnCheckIn.UseVisualStyleBackColor = false;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.BackColor = System.Drawing.Color.Olive;
            this.btnEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployees.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEmployees.Location = new System.Drawing.Point(6, 68);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(200, 33);
            this.btnEmployees.TabIndex = 2;
            this.btnEmployees.Text = "EMPLOYEES";
            this.btnEmployees.UseVisualStyleBackColor = false;
            // 
            // btnVisitors
            // 
            this.btnVisitors.BackColor = System.Drawing.Color.Olive;
            this.btnVisitors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisitors.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVisitors.Location = new System.Drawing.Point(6, 29);
            this.btnVisitors.Name = "btnVisitors";
            this.btnVisitors.Size = new System.Drawing.Size(200, 33);
            this.btnVisitors.TabIndex = 1;
            this.btnVisitors.Text = "VISITORS";
            this.btnVisitors.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Olive;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstname,
            this.lastname,
            this.EMAIL,
            this.IDNUMBER,
            this.phonenumber,
            this.reasontovisit,
            this.personyouvisit,
            this.vehicleregistration,
            this.homeaddress,
            this.date,
            this.time});
            this.dataGridView1.Location = new System.Drawing.Point(267, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(510, 296);
            this.dataGridView1.TabIndex = 0;
            // 
            // firstname
            // 
            this.firstname.HeaderText = "FIRST NAME";
            this.firstname.Name = "firstname";
            // 
            // lastname
            // 
            this.lastname.HeaderText = "LAST NAME";
            this.lastname.Name = "lastname";
            // 
            // EMAIL
            // 
            this.EMAIL.HeaderText = "EMAIL";
            this.EMAIL.Name = "EMAIL";
            // 
            // IDNUMBER
            // 
            this.IDNUMBER.HeaderText = "ID NUMBER";
            this.IDNUMBER.Name = "IDNUMBER";
            // 
            // phonenumber
            // 
            this.phonenumber.HeaderText = "PHONE NUMBER";
            this.phonenumber.Name = "phonenumber";
            // 
            // reasontovisit
            // 
            this.reasontovisit.HeaderText = "REASON TO VISIT";
            this.reasontovisit.Name = "reasontovisit";
            // 
            // personyouvisit
            // 
            this.personyouvisit.HeaderText = "PERSON YOU VISIT";
            this.personyouvisit.Name = "personyouvisit";
            // 
            // vehicleregistration
            // 
            this.vehicleregistration.HeaderText = "VEHICLE REGISTRATION";
            this.vehicleregistration.Name = "vehicleregistration";
            // 
            // homeaddress
            // 
            this.homeaddress.HeaderText = "HOME ADDRESS";
            this.homeaddress.Name = "homeaddress";
            // 
            // date
            // 
            this.date.HeaderText = "DATE";
            this.date.Name = "date";
            // 
            // time
            // 
            this.time.HeaderText = "TIME";
            this.time.Name = "time";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEmployees);
            this.groupBox2.Controls.Add(this.btnVisitors);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(38, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 112);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FILTER LIST BY";
            // 
            // cmbSearchList
            // 
            this.cmbSearchList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cmbSearchList.FormattingEnabled = true;
            this.cmbSearchList.Items.AddRange(new object[] {
            "Date",
            "ID Number",
            "Email Address",
            "Phone Number"});
            this.cmbSearchList.Location = new System.Drawing.Point(5, 19);
            this.cmbSearchList.Name = "cmbSearchList";
            this.cmbSearchList.Size = new System.Drawing.Size(200, 24);
            this.cmbSearchList.TabIndex = 3;
            this.cmbSearchList.SelectedIndexChanged += new System.EventHandler(this.cmbSearchList_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAllTimeData);
            this.groupBox3.Controls.Add(this.lblsearch);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.btnToday);
            this.groupBox3.Controls.Add(this.lblSearchBy);
            this.groupBox3.Controls.Add(this.txtsearch);
            this.groupBox3.Controls.Add(this.cmbSearchList);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(38, 227);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(211, 168);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SEARCH BY";
            // 
            // btnAllTimeData
            // 
            this.btnAllTimeData.BackColor = System.Drawing.Color.Olive;
            this.btnAllTimeData.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllTimeData.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAllTimeData.Location = new System.Drawing.Point(5, 139);
            this.btnAllTimeData.Name = "btnAllTimeData";
            this.btnAllTimeData.Size = new System.Drawing.Size(96, 23);
            this.btnAllTimeData.TabIndex = 41;
            this.btnAllTimeData.Text = "ALL DATA";
            this.btnAllTimeData.UseVisualStyleBackColor = false;
            this.btnAllTimeData.Click += new System.EventHandler(this.btnAllTimeData_Click);
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblsearch.Location = new System.Drawing.Point(11, 45);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(0, 13);
            this.lblsearch.TabIndex = 40;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Olive;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(4, 90);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(200, 32);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "PROCEED SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnToday
            // 
            this.btnToday.BackColor = System.Drawing.Color.Olive;
            this.btnToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToday.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnToday.Location = new System.Drawing.Point(111, 139);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(94, 23);
            this.btnToday.TabIndex = 41;
            this.btnToday.Text = "TODAY";
            this.btnToday.UseVisualStyleBackColor = false;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchBy.Location = new System.Drawing.Point(76, 70);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(0, 17);
            this.lblSearchBy.TabIndex = 39;
            // 
            // txtsearch
            // 
            this.txtsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtsearch.Location = new System.Drawing.Point(4, 64);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(200, 23);
            this.txtsearch.TabIndex = 4;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(593, 51);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(66, 20);
            this.lblDate.TabIndex = 38;
            this.lblDate.Text = "DATE: ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Olive;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(45, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 23);
            this.button1.TabIndex = 39;
            this.button1.Text = "Download as pdf";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checklist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel2);
            this.Name = "checklist";
            this.ShowIcon = false;
            this.Text = "CHECK LIST";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnVisitors;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbSearchList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label lblDate;
        public System.Windows.Forms.DataGridView dataGridView1;
        private DataGridViewTextBoxColumn firstname;
        private DataGridViewTextBoxColumn lastname;
        private DataGridViewTextBoxColumn EMAIL;
        private DataGridViewTextBoxColumn IDNUMBER;
        private DataGridViewTextBoxColumn phonenumber;
        private DataGridViewTextBoxColumn reasontovisit;
        private DataGridViewTextBoxColumn personyouvisit;
        private DataGridViewTextBoxColumn vehicleregistration;
        private DataGridViewTextBoxColumn homeaddress;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn time;
        private Label lblsearch;
        private Button btnAllTimeData;
        private Button btnToday;
        private Button button1;
    }
}