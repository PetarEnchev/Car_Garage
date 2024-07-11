using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Garage
{
    public class Car
    {
        private string carId;
        private string make;
        private string model;
        private int year;
        private string customerId;

        public Car(string carId, string make, string model, int year)
        {
            CarId = carId;
            Make = make;
            Model = model;
            Year = year;
        }

        public string CarId
        {
            get { return carId; }
            set { carId = value; }
        }


        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public string CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }
    }
}
