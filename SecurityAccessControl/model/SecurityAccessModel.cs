using SecurityAccessControl.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityAccessControl
{
    class SecurityAccessModel
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string email { get; set; }
        public string IDNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string ReasonToVisit { get; set; }
        public string PersonYouVisit { get; set; }
        public string VehicleRegistration { get; set; }
        public string HomeAddress { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }

       
    }
}
