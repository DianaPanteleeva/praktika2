using System;
class HelloWorld {
    static void Main() {
      
        string J, S;
        Console.WriteLine("введите строку J :");
        J = Console.ReadLine();
        Console.WriteLine("введите строку S:");
        S = Console.ReadLine();
        int count = 0;
        foreach (char c in S)
        {
            foreach(char n in J)
            {
                if (c == n)
                {
                    count ++;
                    break;
                } 
            }
        }
        Console.WriteLine(count);
    }
}