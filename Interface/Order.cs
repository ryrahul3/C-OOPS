﻿using System;

namespace POSInterface
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DatePlaced { get; set; }
        public float TotalPrice { get; set; }
        public Shipment Shipment { get; set; }
        public bool IsShiped 
        { 
            get { return Shipment != null; } 
        }
    }
}
