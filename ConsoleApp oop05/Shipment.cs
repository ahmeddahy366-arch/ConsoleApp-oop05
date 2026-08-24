using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_oop05
{
    internal abstract partial class Shipment
    {
        public static int TotalShipmentsCreated = 0;
        public string TrackingCode;
        public string Description;
        private decimal Weight;
        private decimal DeliveryFee;
        public DeliveryAddress _destination;


        public DeliveryAddress Destination
        {
            get { return _destination; }
            set { _destination = value; }
        }

        public string trackingCode
        {
            get { return TrackingCode; }


            private set
            {

                if (!string.IsNullOrWhiteSpace(value))
                {
                    TrackingCode = value;
                }
                else
                {
                    Console.WriteLine("Tracking code cannot be empty.");
                }


            }
        }



        public string description
        {
            get { return Description; }


            set

            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    Description = value;
                }
                else
                {
                    Console.WriteLine("Description cannot be empty.");
                }



            }
        }

        public decimal wight
        {
            get { return Weight; }
            set
            {

                if (value > 0)
                {

                    Weight = value;

                }
                else
                {
                    Console.WriteLine("Weight must be greater than zero.");
                }




            }
        }


        public decimal deliveryFee
        {
            get { return DeliveryFee; }
            private set
            {


                if (value > 0)
                {
                    DeliveryFee = value;
                }

                else
                {
                    Console.WriteLine("Delivery fee must be greater than zero.");
                }




            }
        }

        public abstract decimal EstimatedCost { get; }


        public void UpdateWeight(decimal newWeight)
        {
            wight = newWeight;
        }
        public void UpdateWeight(decimal newWeight, decimal packingWeight)
        {
            wight = newWeight + packingWeight;
        }



        public Shipment(string trackingCode) : this(trackingCode, "Unknown", 1, 50, new DeliveryAddress("Unknown", "Unknown",0))
        {

            TrackingCode = trackingCode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            _destination = new DeliveryAddress("Unknown", "Unknown",0);


        }
        public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
        {
            TotalShipmentsCreated++;

            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            _destination = destination;

        }

        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)

            {
                deliveryFee = newFee;

            }


        }

        public abstract void PrintShipment();

        #region question6
        //public Shipment CopyShipment()
        //{
        //    return (Shipment)this.MemberwiseClone();
        //}

        #endregion
        #region question7
        //public Shipment ShallowCopy()
        //{
        //    return (Shipment)this.MemberwiseClone();
        //}
        #endregion
        #region question8
        //public Shipment DeepCopy()
        //{
        //    Shipment S1= (Shipment)this.MemberwiseClone();
        //    S1.Destination = this.Destination.copy();
        //    return S1;
        //}
        #endregion
        #region question10

        //static Shipment()
        //{
        //    TotalShipmentsCreated = 0;
        //    Console.WriteLine("Shipment System Initialized");
        //}
        #endregion



        #region question11
        public static int GetTotalShipmentsCreated()
        {
            return TotalShipmentsCreated;
        }
        #endregion

    }
}
