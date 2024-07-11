using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Garage
{
    public class Customer
    {

        private string customerId;
        private string fullName;
        private string phoneNumber;
        private string email;

        public Customer(string customerId, string fullName, string phoneNumber, string email)
        {
            CustomerId = customerId;
            FullName = fullName;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public string CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }


        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }


        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }


        public string Email
        {
            get { return email; }
            set { email = value; }
        }


    }
}
