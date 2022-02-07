﻿namespace SimpleApp.Console;

public class Order
{
    public int Id { get; set; }
    public DateTime DatePlaced { get; set; }
    public Shipment Shipment { get; set; }
    public float TotalPrice { get; set; }
    public bool IsShipped { get => Shipment != null; }
}
