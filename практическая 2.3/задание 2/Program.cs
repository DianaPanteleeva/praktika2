using System;

namespace задание_2
{
    class Worker
    {
        private string Name;
        private string Surname;
        private double Rate;
        private int Days;

        public Worker(string name, string surname, double rate, int days)
        {
            Name = name;
            Surname = surname;
            Rate = rate;
            Days = days;
        }

        public string GetName
        {
            get
            {
                return Name;
            }
        }

        public string GetSurname
        {
            get
            {
                return Surname;
            }
        }

        public double GetRate
        {
            get
            {
                return Rate;
            }
        }

        public int GetDays
        {
            get
            {
                return Days;
            }
        }
        
        public double GetSalary
        {
            get
            {
                return Rate * Days;
                
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Worker worker = new Worker("Alexandr", "Proskurenko", 700, 5);
            double salary = worker.GetSalary;
            
            Console.WriteLine($"Worker - {worker.GetName} {worker.GetSurname}, rate: {worker.GetRate}, worked days: {worker.GetDays},  salary: {salary}");
        }
    }
}