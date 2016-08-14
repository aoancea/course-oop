using System;

namespace Courses.OOP.Encapsulation
{
    public class Order
    {
        public string CustomerName { get; set; }

        public string ShipppingAddress { get; set; }

        public DateTime OrderDate { get; set; }


        public void PlaceOrder() { }
    }
}