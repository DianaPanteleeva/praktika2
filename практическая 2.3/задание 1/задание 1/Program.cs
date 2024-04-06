using System;

namespace задание_1
{
    class Worker
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public double Rate { get; set; }
        public int Days { get; set; }

        public Worker(string name, string surname, double rate, int days)
        {
            Name = name;
            Surname = surname;
            Rate = rate;
            Days = days;
        }

        public double GetSalary()
        {
            return Rate * Days;
        }
    }

    class Program
    {
        static void Main()
        {
            Worker worker = new Worker("Aleksandr", "Proskurenko", 300, 4);
            double salary = worker.GetSalary();
            
            Console.WriteLine($"Worker - {worker.Name} {worker.Surname}, rate: {worker.Rate}, worked days: {worker.Days}, salary: {salary}");
        }
    }
}