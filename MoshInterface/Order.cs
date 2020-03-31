using System;

namespace MoshInterface
{
    public class Shipment
    {
        public float Cost { get; set; }
        public DateTime ShippingDate { get; set; }
    }
    public class Order
    {
        public DateTime DatePlaced { get; set; }
        public float TotalPrice { get; set; }
        public bool IsShiped { get; set; }
        public Shipment Shipment { get; set; }
    }
}
