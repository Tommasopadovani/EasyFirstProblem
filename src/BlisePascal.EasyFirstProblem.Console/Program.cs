public class Program
{
    public static void Main()
    {
        Console.WriteLine("whats the name of the customer?");
        string customerName = Console.ReadLine();
        Console.WriteLine($"Hello, {customerName}!");

        Console.WriteLine("whats spedition type would you like?");
        string speditonType = Console.ReadLine();

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

        int totalPrice = (int)(bookAmount * bookPrice) + 5;

        Console.WriteLine($"okay {customerName}, for {bookAmount}  books at ${bookPrice} each, with the spedition type {speditonType} which costs $5, the total price is ${totalPrice}. Would you like to proceed?");
        if (Console.ReadLine() == "yes")
        {
            Console.WriteLine("thank you for your order!");
        }
        else
        {
            Console.WriteLine("order cancelled.");
        }




    }
}
