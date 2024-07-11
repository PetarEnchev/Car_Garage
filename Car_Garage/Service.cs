using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Garage
{
    public class Service
    {
        private string serviceId;
        private string description;
        private decimal price;

        public Service(string serviceId, string description, decimal price)
        {
            ServiceId = serviceId;
            Description = description;
            Price = price;
        }

        public string ServiceId
        {
            get { return serviceId; }
            set { serviceId = value; }
        }


        public string Description
        {
            get { return description; }
            set { description = value; }
        }


        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }



    }
}
