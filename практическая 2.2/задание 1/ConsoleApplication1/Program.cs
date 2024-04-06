using System;
class Student 
{
    public string surname { get; set; }
    public DateTime dateBirth { get; set; }
    public string numGr { get; set; }
    public int[] Grade { get; set; }
  
    public void Print()
    {
        Console.WriteLine("Information about the student: ");
        Console.WriteLine("Surname: " + surname);
        Console.WriteLine("Date of birth: " + dateBirth.ToShortDateString());
        Console.WriteLine("Group number: " + numGr);
        Console.WriteLine("Grade:" );
        foreach(int score in Grade)
        {
            Console.Write(score);
        }
    }
}
class Program
{
    static void Main()
    {
        Student student = new Student();
        Console.WriteLine("Enter the student's surname : ");
        student.surname = Console.ReadLine();

        Console.WriteLine("Enter the student's date of birth (MM/DD/YYYY): ");
        student.dateBirth = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Enter the student's group number: ");
        student.numGr = Console.ReadLine();

        int[] grade = { 4, 2, 5, 1, 5 };
        student.Grade = grade;
        Console.WriteLine("\nDo you want to change the student's last name? (Y/N)");
        if (Console.ReadLine().ToUpper() == "Y")
        {
            Console.Write("Enter a new last name: ");
            student.surname = Console.ReadLine();
        }

        Console.WriteLine("\nDo you want to change the student's date of birth? (Y/N)");
        if (Console.ReadLine().ToUpper() == "Y")
        {

            Console.Write("Enter a new date of birth (MM/DD/YYYY): ");
            student.dateBirth = DateTime.Parse(Console.ReadLine());
        }
        Console.WriteLine("\nDo you want to change the student's group number? (Y/N)");
        if (Console.ReadLine().ToUpper() == "Y")
        {
             Console.Write("Enter the new group number: ");
                    student.numGr = Console.ReadLine();
        }
       
        student.Print();
        
    }
}