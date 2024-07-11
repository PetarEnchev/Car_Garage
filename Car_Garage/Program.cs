using Car_Garage;
namespace Car_Garage
{
   internal class Program
    {
        static void Main(string[] args)
        {
            Garage garage = new Garage();
            Random random = new Random();
            bool isCompleted = random.Next(0, 2) == 1;
            decimal totalPrice = random.Next(3, 1000);

            while (true)
            {
                Console.WriteLine("1. Добавяне на клиент");
                Console.WriteLine("2. Премахване на клиент");
                Console.WriteLine("3. Търсене на клиент по име");
                Console.WriteLine("4. Списък с всички клиенти");
                Console.WriteLine("5. Добавяне на автомобил");
                Console.WriteLine("6. Премахване на автомобил");
                Console.WriteLine("7. Търсене на автомобил по марка");
                Console.WriteLine("8. Списък на всички автомобили");
                Console.WriteLine("9. Добавяне на механик");
                Console.WriteLine("10. Премахване на механик");
                Console.WriteLine("11. Добавяне на услуга");
                Console.WriteLine("12. Премахване на услуга");
                Console.WriteLine("13. Добавяне на поръчка за ремонт");
                Console.WriteLine("14. Генериране на отчет за услугите");
                Console.WriteLine("15. Изход");

                Console.Write("Изберете опция: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Въведи индификационен номер на потребителя: ");
                        string customerId = Console.ReadLine();
                        Console.Write("Въведи име на потребителя: ");
                        string fullName = Console.ReadLine();
                        Console.Write("Въведи телефон за достъп на потребителя: ");
                        string phoneNumber = Console.ReadLine();
                        Console.Write("Въведи имейл на потребителя: ");
                        string email = Console.ReadLine();
                        var customer = new Customer(customerId, fullName, phoneNumber, email);
                        garage.AddCustomer(customer);
                        break;

                    case "2":
                        Console.Write("Въведи индификационен номер на потребителя: ");
                        garage.RemoveCustomer(Console.ReadLine());
                        break;

                    case "3":
                        Console.Write("Въведи име на потребителя: ");
                        garage.SearchCustomerByName(Console.ReadLine());
                        break;

                    case "4":
                        garage.ListAllCustomers();
                        break;

                    case "5":
                        Console.Write("Въведи индификационен номер на колата: ");
                        string carId = Console.ReadLine();
                        Console.Write("Въведи марка на колата: ");
                        string make = Console.ReadLine();
                        Console.Write("Въведи модел на колата: ");
                        string model = Console.ReadLine();
                        Console.Write("Въведи година на производство на колата: ");
                        int year = int.Parse(Console.ReadLine());
                        var car = new Car(carId, make, model, year);
                        garage.AddCar(car);
                        break;

                    case "6":
                        Console.Write("Въведи индификационен номер на колата: ");
                        garage.RemoveCar(Console.ReadLine());
                        break;

                    case "7":
                        Console.Write("Въведи марка на колата: ");
                        garage.SearchCarByMake(Console.ReadLine());
                        break;

                    case "8":
                        garage.ListAllCars();
                        break;

                    case "9":
                        Console.Write("Въведи индификационен номер: ");
                        string mechanicId = Console.ReadLine();
                        Console.Write("Въведи име на механика: ");
                        string mechanicName = Console.ReadLine();
                        Console.WriteLine("Въведи специализация: ");
                        string specialization = Console.ReadLine();
                        var mechanic = new Mechanic(mechanicId, mechanicName, specialization);
                        garage.AddMechanic(mechanic);
                        break;

                    case "10":
                        Console.Write("Въведи индификационен номер: ");
                        garage.RemoveMechanic(Console.ReadLine());
                        break;

                    case "11":
                        Console.Write("Въведи индификационен номер: ");
                        string serviceId = Console.ReadLine();
                        Console.Write("Въведи описание: ");
                        string description = Console.ReadLine();
                        Console.Write("Въведи цена: ");
                        decimal price = decimal.Parse(Console.ReadLine());
                        var service = new Service(serviceId, description, price);
                        garage.AddService(service);
                        break;

                    case "12":
                        Console.Write("Въведи индификационен номер: ");
                        garage.RemoveService(Console.ReadLine());
                        break;

                    case "13":
                        Console.Write("Въведи индификационен номер на поръчката: ");
                        string orderId = Console.ReadLine();
                        Console.Write("Въведи индификационен номер на клиента: ");
                        customerId = Console.ReadLine();
                        Console.Write("Въведи индификационен номер на колата: ");
                        carId = Console.ReadLine();
                        Console.Write("Въведи индификационен номер на механика: ");
                        mechanicId = Console.ReadLine();
                        var repairOrder = new RepairOrder(orderId, customerId, carId, mechanicId, totalPrice, isCompleted);
                        garage.AddRepairOrder(repairOrder);
                        break;

                    case "14":
                        garage.GenerateServiceReport();
                        break;

                    case "15":
                        return;

                    default:
                        Console.WriteLine("Невалидна опция, опитайте отново.");
                        break;
                }
            }
        }

    }
}
    