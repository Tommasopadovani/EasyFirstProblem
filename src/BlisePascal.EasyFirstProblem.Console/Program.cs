public class Program
{
    public static void Main()
    {
        Console.WriteLine("whats the name of the customer?");
        string customerName = Console.ReadLine();
        Console.WriteLine($"Hello, {customerName}!");

        Console.WriteLine("whats the amount of book you want to buy?");
        int bookAmount = int.Parse(Console.ReadLine());


        Console.WriteLine("whats prize of the book?");
        double bookPrice = double.Parse(Console.ReadLine());

        Console.WriteLine("is the customer a student? (yes/no)");
        if (Console.ReadLine() == "yes")
        {
            bool isStudent = true;
        }
        else
        {
            bool isStudent = false;
        }




    }
}
