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

          Console.WriteLine("INSERT COIN");
        
        
        string input = Console.ReadLine();
        while (input != "q")
        {
            int coin = 0;
            if (int.TryParse(input, out coin))
            {
                vm.AcceptCoin(coin);
                Console.WriteLine("Your current balance is {0} cents.", vm.GetBalance());
            }
            else
            {
                //Dispense Item 
            }
            
            Console.WriteLine("INSERT COIN");
            input = Console.ReadLine();
        }
        
        vm.MakeChange();
    }
   }
    

