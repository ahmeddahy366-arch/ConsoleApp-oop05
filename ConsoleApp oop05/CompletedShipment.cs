using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_oop05
{
    internal sealed class CompletedShipment : Shipment
    {
        public CompletedShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }

        public override decimal EstimatedCost => throw new NotImplementedException();

        
        public override void PrintShipment()
        {
            Console.WriteLine($"[Shipment] Code: {TrackingCode}, Cost: {EstimatedCost}");
        }
    }
    }

