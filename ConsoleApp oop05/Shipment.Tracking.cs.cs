using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_oop05
{
    #region question14

    internal partial class Shipment
    {
        public string TrackingStatus { get; set; } = "In Transit";
        public string GetTrackingStatus()
        {
            return TrackingStatus;
        }
        public void UpdateTrackingStatus(string newStatus)
        {
            if (!string.IsNullOrWhiteSpace(newStatus))
            {
                TrackingStatus = newStatus;
            }
        }
    }
}
    #endregion
