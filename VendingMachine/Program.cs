using System;
using static VendingMachine.Inventory;

namespace VendingMachine;
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hello HTere");
            VendingMachine vm = new VendingMachine();
            CoinBank coins = new CoinBank();
            Inventory inventory = new Inventory();

           inventory.AddItem("Cola" ,5);
           inventory.AddItem("Crisps", 5);
           inventory.AddItem("Chocolate", 5);

        Console.WriteLine("INSERT COIN");
        string CoinInput = Console.ReadLine();
        while (CoinInput != "q")
        {
            int coin = 0;
            if (int.TryParse(CoinInput, out coin))
            {
                coins.AcceptCoin(coin);
                Console.WriteLine("Your current balance is {0} p.", coins.GetBalance());
            }
            else
            { 
              Console.WriteLine("What product do you want?");
                string ProductInput = Console.ReadLine();

                inventory.PurchaseItem(ProductInput);
            }
                Console.WriteLine("INSERT COIN");
                CoinInput = Console.ReadLine();
        }
        coins.MakeChange();
    }
   }
    

