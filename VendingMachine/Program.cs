using System;
namespace VendingMachine;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello HTere");
            VendingMachine vm = new VendingMachine();
            
           vm.AddItem("Cola", 100);
           vm.AddItem("Crisps", 50);
           vm.AddItem("Chocolate", 65);

          Console.WriteLine("Welcome to the vending machine!");
          Console.WriteLine("Please insert a coin (5, 10, or 25) or enter 'q' to quit.");
        
          string input = Console.ReadLine();

   
    }
    
}
