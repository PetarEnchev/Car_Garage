# Car_Garage

Overview
The Car Garage Management System is a console-based application designed to manage the operations of a car garage. The system includes functionalities for handling customers, cars, mechanics, services, and repair orders. It provides a simple and efficient way to keep track of all these entities and perform various operations such as adding, removing, searching, and listing them.

## Features
Customer Management

Add a new customer.
Remove an existing customer.
Search for a customer by name.
List all customers.
Car Management

Add a new car.
Remove an existing car.
Search for a car by make.
List all cars.
Mechanic Management

Add a new mechanic.
Remove an existing mechanic.
Service Management

Add a new service.
Remove an existing service.
Repair Order Management

Add a new repair order.
Generate a service report for completed orders.
## Class Descriptions
Customer

Properties: CustomerId, FullName, PhoneNumber, Email.
Methods: Constructor for initializing customer details.
Car

Properties: CarId, Make, Model, Year, CustomerId.
Methods: Constructor for initializing car details.
Mechanic

Properties: MechanicId, FullName, Specialization.
Methods: Constructor for initializing mechanic details.
Service

Properties: ServiceId, Description, Price.
Methods: Constructor for initializing service details.
RepairOrder

Properties: OrderID, CustomerID, CarID, MechanicID, Services, TotalPrice, OrderDate, IsCompleted.
Methods: Constructor for initializing repair order details.
Garage

Properties: Lists to manage customers, cars, mechanics, services, and repair orders.
Methods:
Add, remove, search, and list methods for each entity.
GenerateServiceReport method to generate a report of completed repair orders.
## User Interaction
The user interacts with the system via a console menu that offers various options:

Add a customer.
Remove a customer.
Search for a customer by name.
List all customers.
Add a car.
Remove a car.
Search for a car by make.
List all cars.
Add a mechanic.
Remove a mechanic.
Add a service.
Remove a service.
Add a repair order.
Generate a service report.
Exit the application.
## How to Run
Compile the project using a C# compiler or an IDE such as Visual Studio.
Run the executable to start the console application.
Follow the on-screen prompts to navigate through the menu and manage the garage operations.
## Example Workflow
Adding a Customer:

Select the option to add a customer.
Enter the customer details (ID, name, phone number, email).
Adding a Car:

Select the option to add a car.
Enter the car details (ID, make, model, year).
Creating a Repair Order:

Select the option to add a repair order.
Enter the order details (ID, customer ID, car ID, mechanic ID, total price, completion status).
Generating a Service Report:

Select the option to generate a service report.
The system will display the report for completed orders.
This project provides a comprehensive management solution for car garages, allowing easy tracking and management of all key entities and operations within the garage.
