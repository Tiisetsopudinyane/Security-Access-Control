using SecurityAccessControl.SqlDataAccess;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurityAccessControl.BusinessLogic
{
    class ServiceClass : SecurityAccessInterface
    {
        
        SqlDataaccess sda = new SqlDataaccess();

        public void CreateAccess(string FirstName, string LastName, string email, string IDNumber, string PhoneNumber, string ReasonToVisit, string PersonYouVisit, string VehicleRegistration, string HomeAddress)
        {
            SecurityAccessModel sc = new SecurityAccessModel();

            sc.FirstName=FirstName.ToUpper();
            sc.LastName = LastName.ToUpper();
            sc.email = email.ToLower();
            sc.IDNumber = Encryptdata(IDNumber);
            sc.PhoneNumber = PhoneNumber;
            sc.ReasonToVisit = ReasonToVisit;
            sc.PersonYouVisit = PersonYouVisit;
            sc.VehicleRegistration = VehicleRegistration.ToUpper();
            sc.HomeAddress = HomeAddress;
            sc.Date = myDate();
            sc.Time = myTime();
            sda.Load(sc.FirstName, sc.LastName, sc.email, sc.IDNumber, sc.PhoneNumber, sc.ReasonToVisit, sc.PersonYouVisit, sc.VehicleRegistration, sc.HomeAddress,sc.Date,sc.Time);

        }

        public string Encryptdata(string IDnumber)
        {
            string strmsg = string.Empty;
            byte[] encode = new byte[IDnumber.Length];
            encode = Encoding.UTF8.GetBytes(IDnumber);
            strmsg = Convert.ToBase64String(encode);
            return strmsg;
        }
        public string Decryptdata(string IDnumber)
        {
            string decryptpwd = string.Empty;
            UTF8Encoding encodepwd = new UTF8Encoding();
            Decoder Decode = encodepwd.GetDecoder();
            byte[] todecode_byte = Convert.FromBase64String(IDnumber);
            int charCount = Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
            char[] decoded_char = new char[charCount];
            Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
            decryptpwd = new String(decoded_char);
            return decryptpwd;
        }

        public string myDate()
        {
            string date=DateTime.Now.ToString("dd/MM/yyyy");
            return date;
        }
        public string myTime()
        {
            string time = DateTime.Now.ToString("H:mm tt");
            return time;
        }
        public void LoadAccessList(DataGridView data)
        {
            string today = myDate();
            sda.LoadToday(data, today);
        }

        public void SearchByEmail(DataGridView data, string Email)
        {
           sda.SearchByEmail(data,Email);
        }

        public void SearchByID(DataGridView data, string IDNumber)
        {
            string id = Encryptdata(IDNumber);
            sda.SearchByIdNumber(data,id);
        }

        public void SearchByPhoneNumber(DataGridView data, string PhoneNumber)
        {
            sda.SearchByPhone(data, PhoneNumber);
        }

        public void SearchByDate(DataGridView data, string date)
        {
            sda.SearchByDate(data, date);
        }

        public void LoadAllTimeData(DataGridView data)
        {
            sda.LoadAllTimeData(data);
        }

        public void Download()
        {
            sda.Load();
        }
    }
}
