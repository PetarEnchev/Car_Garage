using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Garage
{
    public class Garage
    {
        public List<Customer> Customers { get; set; } = new List<Customer>();
        public List<Car> Cars { get; set; } = new List<Car>();
        public List<Mechanic> Mechanics { get; set; } = new List<Mechanic>();
        public List<Service> Services { get; set; } = new List<Service>();
        public List<RepairOrder> RepairOrders { get; set; } = new List<RepairOrder>();

        private readonly List<string> garageInfo = new List<string>() { "Italian Garage", "Italiano 123", "Giacommo Pellegri" };

        public void DisplayGarageInformation()
        {
            Console.WriteLine($"Garage name: {garageInfo[0]} | Address: {garageInfo[1]} | Garage Co: {garageInfo[2]}");
        }

        public void AddCustomer(Customer customer) => Customers.Add(customer);

        public void RemoveCustomer(string customerId) => Customers.RemoveAll(x => x.CustomerId == customerId);

        public void SearchCustomerByName(string name)
        {
            var customersFound = Customers.Where(x => x.FullName.Equals(name, StringComparison.OrdinalIgnoreCase)).ToList();

            if (customersFound.Any())
            {
                Console.WriteLine($"Found {customersFound.Count} customer(s) with the name '{name}':");
                customersFound.ForEach(c => Console.WriteLine($"Customer ID: {c.CustomerId}, Name: {c.FullName}, Phone: {c.PhoneNumber}, Email: {c.Email}"));
            }
            else
            {
                Console.WriteLine($"No customers found with the name '{name}'.");
            }
        }

        public void ListAllCustomers() => Customers.ForEach(c => Console.WriteLine($"Customer: {c.FullName}"));

        public void AddCar(Car car) => Cars.Add(car);

        public void RemoveCar(string carId) => Cars.RemoveAll(x => x.CarId == carId);

        public void SearchCarByMake(string make)
        {
            var carsFound = Cars.Where(x => x.Make.Equals(make, StringComparison.OrdinalIgnoreCase)).ToList();

            if (carsFound.Any())
            {
                Console.WriteLine($"Found {carsFound.Count} car(s) with the make '{make}':");
                carsFound.ForEach(c => Console.WriteLine($"Car ID: {c.CarId}, Make: {c.Make}, Model: {c.Model}, Year: {c.Year}"));
            }
            else
            {
                Console.WriteLine($"No cars found with the make '{make}'.");
            }
        }

        public void ListAllCars() => Cars.ForEach(c => Console.WriteLine($"Car: Model {c.Model}, Make {c.Make}, Year {c.Year}"));

        public void AddMechanic(Mechanic mechanic) => Mechanics.Add(mechanic);

        public void RemoveMechanic(string mechanicId) => Mechanics.RemoveAll(x => x.MechanicId == mechanicId);

        public void AddService(Service service) => Services.Add(service);

        public void RemoveService(string serviceId) => Services.RemoveAll(x => x.ServiceId == serviceId);

        public void AddRepairOrder(RepairOrder repairOrder) => RepairOrders.Add(repairOrder);

        public void RemoveRepairOrder(string orderId) => RepairOrders.RemoveAll(x => x.OrderID == orderId);

        public void GenerateServiceReport()
        {
            var completedOrdersCount = RepairOrders.Count(o => o.IsCompleted);

            if (completedOrdersCount > 0)
            {
                Console.WriteLine($"We completed {completedOrdersCount} orders!");
            }
            else
            {
                Console.WriteLine("No completed orders found!");
            }
        }
    }
}




