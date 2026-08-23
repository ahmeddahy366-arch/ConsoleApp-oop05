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