using System;

class Train
{
    public string NameDestination  {get; set;}
    public int NumberTrain { get; set; }
    public DateTime DepartureDate {get; set;}

    public Train(string nameDestination, int numberTrain, DateTime departureDate)
    {
        NameDestination = nameDestination;
        NumberTrain = numberTrain;
        DepartureDate = departureDate;
    }

    public void Print()
    {
        Console.WriteLine("Information about the train: ");
        Console.WriteLine("Name of the destination: " + NameDestination);
        Console.WriteLine("Train number: " + NumberTrain);
        Console.WriteLine("Departure time: " + DepartureDate.ToString());
    }
}

class Program
{
    static void Main()
    {
        Train train1 = new Train("Novosibirsk", 342, new DateTime(2024,06,13,8,0,0));
        Train train2 = new Train("Tomsk", 101, new DateTime(2024, 01, 29, 3, 50, 0));
        
        Console.WriteLine("Enter the train number in order to get information about it: ");
        int userNum = int.Parse(Console.ReadLine());
        if (userNum == train1.NumberTrain)
        {
            train1.Print();
        }
        else if (userNum == train2.NumberTrain)
        {
            train2.Print();
        }
        else
        {
            Console.WriteLine("Information about the train with this number was not found.");
        }
    }
}