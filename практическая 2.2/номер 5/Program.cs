using System;
using номер_5;

namespace номер_5
{ 
    class Property
    {
       public int Property1 { get; set; }
       public string Property2 { get; set; }
       
       public Property(int property1, string property2)
       {
           Property1 = property1;
           Property2 = property2;
       }

       public Property()
       {
           Property1 = 2;
           Property2 = "default";
       }

       ~Property()
       {
           Console.WriteLine("The object has been deleted.");
       }
    }
}

class Program
{
    static void Main()
    {
        Property object1 = new Property(11, "bb");
        Console.WriteLine($"Property 1: {object1.Property1}, Property 2: {object1.Property2}.");
        Property object2 = new Property();
        Console.WriteLine($"Property 1: {object2.Property1}, Property 2: {object2.Property2}.");
    }
}