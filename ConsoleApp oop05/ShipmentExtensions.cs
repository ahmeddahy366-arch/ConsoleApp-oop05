using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_oop05
{
    #region question13

    internal static class ShipmentExtensions
    {
        public static string GetSummary(this Shipment shipment)
        {
            if (shipment == null) return string.Empty;
            string shipmenType = shipment.GetType().Name.Replace("Shipment", "");
            string trackingStatus = "In Transit";
            return $"{shipment.TrackingCode}|{shipmenType} | {shipment.wight} KG |{trackingStatus}";
            


        }
        public static bool IsDelivered(this Shipment shipment)
        {
            if (shipment == null) return false;
            return true;

        }
    }
    #endregion
}
