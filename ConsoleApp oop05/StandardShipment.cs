using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_oop05
{
    internal class StandardShipment : Shipment, ITrackable, IInsurable
    {
        public StandardShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, decimal extraFee, DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {

        }



        public StandardShipment(string trackingCode, string v1, decimal v2, decimal v3) : base(trackingCode)
        {
        }

        public override decimal EstimatedCost => throw new NotImplementedException();

        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is currently in transit.";
        }
        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.05m;
        }
        public override void PrintShipment()
        {
            Console.WriteLine($"[Standard Shipment] Code: {TrackingCode}, Description: {Description}, Cost: {EstimatedCost}");
        }
    }
}
