using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Car
{
    public static class SessionManager
    {
        public static string LoggedInCustomerID { get; private set; }
        public static string LoggedInCustomerName { get; private set; }
        public static string LoggedInCustomerEmail { get; private set; }
        public static string LoggedInCustomerAddress { get; private set; }
        public static string LoggedInCustomerContactNumber { get; private set; }

        // This method sets the session data for the logged-in customer
        public static void SetCustomerSession(string customerID, string name, string email, string address, string contactnumber)
        {
            LoggedInCustomerID = customerID;
            LoggedInCustomerName = name;
            LoggedInCustomerEmail = email;
            LoggedInCustomerAddress = address;
            LoggedInCustomerContactNumber = contactnumber;
        }

        // Clear the session data (optional for logout functionality)
        public static void ClearSession()
        {
            LoggedInCustomerID = null;
            LoggedInCustomerName = null;
            LoggedInCustomerEmail = null;
            LoggedInCustomerAddress = null;
            LoggedInCustomerContactNumber= null;
        }
    }
}
