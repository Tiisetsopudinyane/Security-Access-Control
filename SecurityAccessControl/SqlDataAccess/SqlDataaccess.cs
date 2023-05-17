using iTextSharp.text;
using iTextSharp.text.pdf;
using SecurityAccessControl.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurityAccessControl.SqlDataAccess
{
    public class SqlDataaccess
    {

        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DataBaseAccessControl;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        /*public static string GetConnectionString(string ConnectionName = "DataBaseAccessControl")
        {
            return ConfigurationManager.ConnectionStrings[ConnectionName].ConnectionString;
        }*/


        public void Load(string FirstName, string LastName, string email, string IDNumber, string PhoneNumber, string ReasonToVisit, string PersonYouVisit, string VehicleRegistration, string HomeAddress, string date, string time)
        {
            
            try
            {
                con.Open();
                string sql = "insert into dbo.DataBaseAccessControl values ('" + FirstName + "','" + LastName + "','" + email + "','" + IDNumber + "','" + PhoneNumber + "','" + ReasonToVisit + "','" + PersonYouVisit + "','" + VehicleRegistration + "','" + HomeAddress + "','" + date + "','" + time + "')";
                SqlCommand scd = new SqlCommand(sql, con);
                scd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception excp)
            {
                MessageBox.Show("It wasn't possible to retrieve required data from database." + excp.Message);
            }
        }


        public void LoadAllTimeData(DataGridView data)
        {
            string sql = "Select * FROM dbo.DataBaseAccessControl";
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                ServiceClass sc = new ServiceClass();
                foreach (DataRow dr in dt.Rows)
                {
                    
                    int n = data.Rows.Add();
                    data.Rows[n].Cells[0].Value = dr[1].ToString();
                    data.Rows[n].Cells[1].Value = dr[2].ToString();
                    data.Rows[n].Cells[2].Value = dr[3].ToString();
                    data.Rows[n].Cells[3].Value = sc.Decryptdata(dr[4].ToString());
                    data.Rows[n].Cells[4].Value = dr[5].ToString();
                    data.Rows[n].Cells[5].Value = dr[6].ToString();
                    data.Rows[n].Cells[6].Value = dr[7].ToString();
                    data.Rows[n].Cells[7].Value = dr[8].ToString();
                    data.Rows[n].Cells[8].Value = dr[9].ToString();
                    data.Rows[n].Cells[9].Value = dr[10].ToString();
                    data.Rows[n].Cells[10].Value = dr[11].ToString();
                }
            }
            catch(Exception excp)
            {
                MessageBox.Show("It wasn't possible to retrieve required data from database." + excp.Message);
            }
        }
    

    public void SearchByEmail(DataGridView data,string email)
            {
            try
                {
                    con.Open();

                    string sql = "select * from dbo.DataBaseAccessControl where email='" + email + "'";

                    SqlDataAdapter sdA = new SqlDataAdapter(sql, con);
                ServiceClass sc = new ServiceClass();
                DataTable dt = new DataTable();
                sdA.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    int n = data.Rows.Add();
                    data.Rows[n].Cells[0].Value = dr[1].ToString();
                    data.Rows[n].Cells[1].Value = dr[2].ToString();
                    data.Rows[n].Cells[2].Value = dr[3].ToString();
                    data.Rows[n].Cells[3].Value = sc.Decryptdata(dr[4].ToString());
                    data.Rows[n].Cells[4].Value = dr[5].ToString();
                    data.Rows[n].Cells[5].Value = dr[6].ToString();
                    data.Rows[n].Cells[6].Value = dr[7].ToString();
                    data.Rows[n].Cells[7].Value = dr[8].ToString();
                    data.Rows[n].Cells[8].Value = dr[9].ToString();
                    data.Rows[n].Cells[9].Value = dr[10].ToString();
                    data.Rows[n].Cells[10].Value = dr[11].ToString();
                }
                con.Close();
            }
                catch (Exception excp)
                {
                MessageBox.Show("It wasn't possible to retrieve required data from database." + excp.Message);
            }
        }
        public void SearchByDate(DataGridView data, string Date)
        {
            try
            {
                con.Open();

                string sql = "select * from dbo.DataBaseAccessControl where Date='" + Date + "'";

                SqlDataAdapter sdA = new SqlDataAdapter(sql, con);
                ServiceClass sc = new ServiceClass();
                DataTable dt = new DataTable();
                sdA.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    int n = data.Rows.Add();
                    data.Rows[n].Cells[0].Value = dr[1].ToString();
                    data.Rows[n].Cells[1].Value = dr[2].ToString();
                    data.Rows[n].Cells[2].Value = dr[3].ToString();
                    data.Rows[n].Cells[3].Value = sc.Decryptdata(dr[4].ToString());
                    data.Rows[n].Cells[4].Value = dr[5].ToString();
                    data.Rows[n].Cells[5].Value = dr[6].ToString();
                    data.Rows[n].Cells[6].Value = dr[7].ToString();
                    data.Rows[n].Cells[7].Value = dr[8].ToString();
                    data.Rows[n].Cells[8].Value = dr[9].ToString();
                    data.Rows[n].Cells[9].Value = dr[10].ToString();
                    data.Rows[n].Cells[10].Value = dr[11].ToString();
                }
                con.Close();
            }
            catch (Exception excp)
            {
                MessageBox.Show("It wasn't possible to retrieve required data from database." + excp.Message);
            }
        }
        public void LoadToday(DataGridView data, string Today)
        {
            try
            {
                con.Open();

                string sql = "select * from dbo.DataBaseAccessControl where Date='" + Today + "'";
                ServiceClass sc = new ServiceClass();
                DataTable dt = new DataTable();
                SqlDataAdapter sdA = new SqlDataAdapter(sql, con);

                sdA.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    int n = data.Rows.Add();
                    data.Rows[n].Cells[0].Value = dr[1].ToString();
                    data.Rows[n].Cells[1].Value = dr[2].ToString();
                    data.Rows[n].Cells[2].Value = dr[3].ToString();
                    data.Rows[n].Cells[3].Value = sc.Decryptdata(dr[4].ToString());
                    data.Rows[n].Cells[4].Value = dr[5].ToString();
                    data.Rows[n].Cells[5].Value = dr[6].ToString();
                    data.Rows[n].Cells[6].Value = dr[7].ToString();
                    data.Rows[n].Cells[7].Value = dr[8].ToString();
                    data.Rows[n].Cells[8].Value = dr[9].ToString();
                    data.Rows[n].Cells[9].Value = dr[10].ToString();
                    data.Rows[n].Cells[10].Value = dr[11].ToString();
                }
                con.Close();
            }
            catch (Exception excp)
            {
                MessageBox.Show("It wasn't possible to retrieve required data from database." + excp.Message);
            }
        }
        public void SearchByIdNumber(DataGridView data, string IdNumber)
        {
            try
            {
                con.Open();
                
                string sql = "select * from dbo.DataBaseAccessControl where idNumber='" + IdNumber + "'";

                SqlDataAdapter sdA = new SqlDataAdapter(sql, con);
                ServiceClass sc = new ServiceClass();
                DataTable dt = new DataTable();
                sdA.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    int n = data.Rows.Add();
                    data.Rows[n].Cells[0].Value = dr[1].ToString();
                    data.Rows[n].Cells[1].Value = dr[2].ToString();
                    data.Rows[n].Cells[2].Value = dr[3].ToString();
                    data.Rows[n].Cells[3].Value = sc.Decryptdata(dr[4].ToString());
                    data.Rows[n].Cells[4].Value = dr[5].ToString();
                    data.Rows[n].Cells[5].Value = dr[6].ToString();
                    data.Rows[n].Cells[6].Value = dr[7].ToString();
                    data.Rows[n].Cells[7].Value = dr[8].ToString();
                    data.Rows[n].Cells[8].Value = dr[9].ToString();
                    data.Rows[n].Cells[9].Value = dr[10].ToString();
                    data.Rows[n].Cells[10].Value = dr[11].ToString();
                }
                con.Close();
                
            }
            catch (Exception excp)
            {
                MessageBox.Show("It wasn't possible to retrieve required data from database." + excp.Message);
            }
        }
        
        
        public void SearchByPhone(DataGridView data, string phone)
        {
            try
            {
                con.Open();

                string sql = "select * from dbo.DataBaseAccessControl where phoneNumber='" + phone + "'";

                SqlDataAdapter sdA = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                sdA.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    ServiceClass sc = new ServiceClass();
                    int n = data.Rows.Add();
                    data.Rows[n].Cells[0].Value = dr[1].ToString();
                    data.Rows[n].Cells[1].Value = dr[2].ToString();
                    data.Rows[n].Cells[2].Value = dr[3].ToString();
                    data.Rows[n].Cells[3].Value = sc.Decryptdata(dr[4].ToString());
                    data.Rows[n].Cells[4].Value = dr[5].ToString();
                    data.Rows[n].Cells[5].Value = dr[6].ToString();
                    data.Rows[n].Cells[6].Value = dr[7].ToString();
                    data.Rows[n].Cells[7].Value = dr[8].ToString();
                    data.Rows[n].Cells[8].Value = dr[9].ToString();
                    data.Rows[n].Cells[9].Value = dr[10].ToString();
                    data.Rows[n].Cells[10].Value = dr[11].ToString();
                }
                con.Close();
                
            }
            catch (Exception excp)
            {
                MessageBox.Show("It wasn't possible to retrieve required data from database." + excp.Message);
            }
        }

        public void Load()
        {
            DataTable dt = new DataTable();
            ServiceClass sc = new ServiceClass();
            try
            {
                con.Open();
                string sql = "select * from dbo.DataBaseAccessControl";
                SqlDataAdapter sda = new SqlDataAdapter(sql, con);
                
                sda.Fill(dt);
            }catch(Exception excp)
            {
                MessageBox.Show("It wasn't possible to retrieve required data from database." + excp.Message);
            }
            if (dt.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = sc.myDate()+"sacData.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dt.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dt.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dt.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

    }
    }
