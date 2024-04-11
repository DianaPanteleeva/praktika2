using System;

namespace task3_numbers
{
    internal class Numbers
    {
        public static int a { get; set; }
        public static int b { get; set; }

        public void CreateNumbers()
        {
            Console.WriteLine("Введите число a: ");            
            a = int.Parse(Console.ReadLine());                        
            Console.WriteLine("Введите число b: ");            
            b = int.Parse(Console.ReadLine());
        }
        
        public void PrintNumbers()
        {
            Console.WriteLine($"\nЧисло a = {a}\nЧисло b = {b}");
        }  
        
        public void EditNumbers()        
        {            
            Console.WriteLine("\nКакое число хотите изменить?: ");            
            Console.Write("0 - Число a\n" +                          
                          "1 - Число b\n");    
            
            int input = int.Parse(Console.ReadLine());            
            switch (input)            {                
                case 0:
                    Console.Write("\na = ");                    
                    a = int.Parse(Console.ReadLine());                    
                    break;                
                case 1:
                    Console.Write("\nb = ");                    
                    b = int.Parse(Console.ReadLine());                    
                    break;            
            }        
        }

        public void Sum()
        {
            Console.WriteLine($"\n{a} + {b} = {a + b}");
        }

        public void HighestNumber()
        {
            if (a > b)                
                Console.WriteLine($"\n{a} > {b}");            
            else if(a < b)               
                Console.WriteLine($"\n{a} < {b}");
            else
                Console.WriteLine($"\n{a} = {b}");
        }
        
    }        
    
    internal class Program    
    {        
        public static void Main(string[] args)        
        {            
            Numbers numbers = new Numbers();
            numbers.CreateNumbers();
            
            bool check = true;            
            while (check != false)            
            {                
                Console.WriteLine("\nЧтобы изменить данные выберите соответствующую команду: ");                
                Console.Write("0 - Изменить значения чисел\n" +                              
                              "1 - Посмотреть значения чисел\n" +                              
                              "2 - Вычислить сумму чисел\n" +                              
                              "3 - Найти наибольшее значение\n" +                              
                              "4 - Закрыть программу\n");                
                int input = int.Parse(Console.ReadLine());                
                switch (input)                
                {                    
                    case 0:
                        numbers.EditNumbers();                        
                        break;                    
                    case 1:
                        numbers.PrintNumbers();                        
                        break;                    
                    case 2:
                        numbers.Sum();                        
                        break;                    
                    case 3:
                        numbers.HighestNumber();                        
                        break;                    
                    case 4:
                        Console.WriteLine("\nЗавершение программы...");                        
                        check = false;                        
                        break;                    
                    default:
                        Console.WriteLine("\nТакой команды нет");                        
                        break;                
                }            
            }        
        }

                    
    }
    
}