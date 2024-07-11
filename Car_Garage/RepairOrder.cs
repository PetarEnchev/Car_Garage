using System;

namespace Car_Garage
{
    public class RepairOrder
    {
        public string OrderID { get; set; }
        public string CustomerID { get; set; }
        public string CarID { get; set; }
        public string MechanicID { get; set; }
        public List<Service> Services { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public bool IsCompleted { get; set; }

        public RepairOrder(string orderId, string customerId, string carId, string mechanicId, decimal totalPrice, bool isCompleted, DateTime? orderDate = null)
        {
            OrderID = orderId;
            CustomerID = customerId;
            CarID = carId;
            MechanicID = mechanicId;
            Services = new List<Service>();
            TotalPrice = totalPrice;
            IsCompleted = isCompleted;
            OrderDate = orderDate ?? DateTime.Now;
        }
    }
}
