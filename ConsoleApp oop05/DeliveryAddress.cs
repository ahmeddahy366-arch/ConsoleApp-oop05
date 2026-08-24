using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_oop05
{
    public class DeliveryAddress
    {
        public string City;
        public string Street;
        public int BuildingNumber;

        public DeliveryAddress(string city, string street, int buildingNumber)
        {
            City = city;
            Street = street;
            BuildingNumber = buildingNumber;
        }
        public string GetFullAddress()
        {
            return $" {City} , {Street} ,  {BuildingNumber}";
        }
        #region question8

        //public DeliveryAddress copy()
        //{
        //    return new DeliveryAddress(City,Street, BuildingNumber) ;
        //}
        #endregion
    }
}
