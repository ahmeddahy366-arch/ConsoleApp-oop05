using System.ComponentModel;
using System.Timers;

namespace ConsoleApp_oop05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question6

            //      Shipment shipment1 = new StandardShipment(
            //"SH001",
            //"Standard shipment",
            //3,
            //50,
            //0,
            //new DeliveryAddress("Cairo", "Street 1", 10));

            //      Shipment shipment2 = shipment1;
            //      string code = shipment2.TrackingCode = "c,dldc";
            //      Console.WriteLine(code);
            //      Console.WriteLine(shipment1.TrackingCode);
            //      Console.WriteLine(ReferenceEquals(shipment1,shipment2));
            //      //////////////////////////////////////////
            //      Shipment shipment3 = shipment1.CopyShipment();
            //     string code2= shipment3.TrackingCode = "wwwwww";
            //      Console.WriteLine(code2);
            //      Console.WriteLine(shipment1.TrackingCode);
            //      Console.WriteLine(ReferenceEquals(shipment1, shipment3));
            #endregion
            #region question7
            //        Shipment originalShipment = new StandardShipment(
            //"SH001",
            //"Standard Shipment",
            //4,
            //60,
            //0,
            //new DeliveryAddress("Cairo", "Old Street", 10));
            //        Shipment copyshipment = originalShipment.ShallowCopy();
            //        Console.WriteLine(ReferenceEquals(copyshipment,originalShipment));
            //        Console.WriteLine(ReferenceEquals(copyshipment.Destination, originalShipment.Destination));
            //        copyshipment.Destination.City = "sohag";
            //        Console.WriteLine(originalShipment.Destination.City);
            #endregion
            #region question8
            //        Shipment originalShipment = new StandardShipment(
            //"SH001",
            //"Standard Shipment",
            //4,
            //60,
            //0,
            //new DeliveryAddress("Cairo", "Old Street", 10));
            //        Console.WriteLine("befor change");
            //        Shipment copiedshipment= originalShipment.DeepCopy();
            //        Console.WriteLine(copiedshipment.Destination.City);
            //        Console.WriteLine(originalShipment.Destination.City);
            //        Console.WriteLine("aftar change");
            //        copiedshipment.Destination.City = "Giza";
            //        Console.WriteLine(copiedshipment.Destination.City);
            //        Console.WriteLine(originalShipment.Destination.City);



            #endregion
            #region question9

            //     Shipment originalShipment = new StandardShipment(
            //  "SH001",
            //  "Standard Shipment",
            //  4,
            //  60,
            //  0,
            //  new DeliveryAddress("Cairo", "Old Street", 10));
            //     Shipment originalShipment2= new StandardShipment(
            //"SH001",
            //"Standard Shipment",
            //4,
            //60,
            //0,
            //new DeliveryAddress("Cairo", "Old Street", 10));


            //Console.WriteLine(Shipment.TotalShipmentsCreated);
            #endregion
            #region question10

            //    Shipment originalShipment1 = new StandardShipment(
            //"SH001",
            //"Standard Shipment",
            //4,
            //60,
            //0,
            //new DeliveryAddress("Cairo", "Old Street", 10));


            #endregion
            #region question11

            //     Shipment originalShipment = new StandardShipment(
            //  "SH001",
            //  "Standard Shipment",
            //  4,
            //  60,
            //  0,
            //  new DeliveryAddress("Cairo", "Old Street", 10));
            //     Shipment originalShipment2 = new StandardShipment(
            //"SH001",
            //"Standard Shipment",
            //4,
            //60,
            //0,
            //new DeliveryAddress("Cairo", "Old Street", 10));
            //     Console.WriteLine(Shipment.GetTotalShipmentsCreated());
            #endregion
            #region question12
            //DeliveryUtilities.PrintSeparator();
            //DeliveryUtilities.PrintSystemTitle();
            #endregion
            #region question13
        //    Shipment shipment = new StandardShipment(
        //"SH001",
        //"Standard Shipment",
        //3,
        //60,
        //0,
        //new DeliveryAddress("Cairo", "Old Street", 10));
        //    Console.WriteLine(shipment.GetSummary());
        //    Console.WriteLine(shipment.IsDelivered());
            #endregion
        }
    }
}
#region question1
//a) What happens when you assign one object variable to another object variable?
//This causes the two variables to point to the same location in the heap.
//b) Does assigning one object to another create a new object? Explain.
//No new object is created on the heap; the new object refers to the old one. Any modification made through it will directly affect the others.
//c) What is the difference between copying an object and copying its reference?
//copying its reference Only the address was copied onto the stack, and we have two variables both pointing to the single instance on the heap.
//Copying an Object: A new location is allocated in the heap memory, and a completely new, independent object is created containing a copy of the original object's data.
#endregion
#region question2

//a) What is a Shallow Copy?
//Shallow Copy = Copies the outer object, but the reference objects inside it remain shared.
//b) What is a Deep Copy?
//Deep Copy means creating a complete and independent copy of the object including the objects contained within it
//c) What happens to reference-type members when a Shallow Copy is created
//Reference type members point to the same object in both the original and the new copy.
//d) What happens to reference-type members when a Deep Copy is created?
//In a deep copy, new and independent copies of reference - type members are created.
//e) Give one situation where Deep Copy would be safer than Shallow Copy.
//When I need to modify a copy without affecting the original, I use a deep copy.
#endregion
#region question3
//a) What is a static field, and how is it different from an instance field?
//A static field is shared by all objects of a class, while an instance field has a separate copy for each object.

//b) What is a static method? Can a static method directly access instance members?
//Belongs to the class and can be called without creating an object.
//no
//c) What is a static constructor, and when is it executed?
//A static constructor initializes the static members of a class and is executed automatically once before the class is used for the first time.
//d) What is a static class? Can you create an object from a static class?
//A static class is a class from which objects(instances) cannot be created and which can only contain static members; you cannot instantiate a static class.
#endregion
#region question4
//a) What is an Extension Method?
//An Extension Method allows you to add a new method to an existing type without modifying the original type.
//b) What keyword must be used in the first parameter of an extension method?
//keyword this
//c) Where must an extension method be declared?
//inside a static class
//d) Can an extension method access private members of the class it extends ?
//You do not have access to the private members
#endregion
#region question5
//a) What is a Partial Class?
//"partial class" allows a class to be split across multiple files, while the compiler treats it as a single class.

//b) Why would a developer split one class into multiple files?
//To facilitate teamwork, organization, and code readability.
//c) What is a Partial Method?
//A Partial Method is a method in a partial class that allows you to declare its signature without a body in one file,
//and optionally write its body (implementation) in another file. If no body is provided, the compiler completely removes the method call.
//d) What happens if a declared partial method has no implementation?
//The program will not produce any errors (error-free): the code will execute and compile flawlessly.

#endregion
