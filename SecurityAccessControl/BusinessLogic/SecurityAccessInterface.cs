using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace SecurityAccessControl
{
    interface SecurityAccessInterface
    {
        void CreateAccess(string FirstName,string LastName,string email,string IDNumber,string PhoneNumber,string ReasonToVisit,string PersonYouVisit,string VehicleRegistration,string HomeAddress);
        void LoadAccessList(DataGridView data);
        void SearchByID(DataGridView data, string IDNumber);
        void SearchByEmail(DataGridView data,string Email);
        void SearchByPhoneNumber(DataGridView data, string PhoneNumber);
        void SearchByDate(DataGridView data, string date);
        void LoadAllTimeData(DataGridView data);
        void Download();
    }
}
