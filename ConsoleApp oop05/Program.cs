using System.Timers;

namespace ConsoleApp_oop05
{
    internal class Program
    {
        static void Main(string[] args)
        {
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