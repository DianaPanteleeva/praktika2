using System;

public class Counter
{ 
    private int value;

    public Counter()
    {
        value = 0;
    }

    public Counter(int startValue)
    {
        value = startValue;
        
    }

    public void Increase()
    {
        value++;
    }

    public void Decrease()
    {
        value--;
    }

    public int Value
    {
        get { return value; }
    }
}

class Program
{
    static void Main()
    {
        Counter counter1 = new Counter();
        Console.WriteLine("The value of the counter is 1: " + counter1.Value);
        
        counter1.Increase();
        Console.WriteLine("The increased value of the counter is 1: " + counter1.Value);

        Counter counter2 = new Counter(10);
        Console.WriteLine("The value of the counter is 2: " + counter2.Value);
        
        counter2.Decrease();
        Console.WriteLine("reduced counter value 2: " +counter2.Value);
    }
}
