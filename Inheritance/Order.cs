using System;

namespace Inheritance
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DatePlaced { get; set; }
        public double TotalPrice { get; set; }
        public Shipment Shipment { get; set; }

        public bool IsShipped => Shipment != null;
    }
}