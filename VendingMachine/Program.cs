using System;
using static VendingMachine.Product;

namespace VendingMachine;
class Program
{
    static void Main(string[] args)
    {


        Console.WriteLine("Hello HTere");
            VendingMachine vm = new VendingMachine();
            Product product = new Product();

         string VendingMachineItem;
           product.AddItem("Cola" ,5);
           product.AddItem("Crisps", 5);
           product.AddItem("Chocolate", 5);

        Console.WriteLine("INSERT COIN");
        string CoinInput = Console.ReadLine();
        while (CoinInput != "q")
        {
            int coin = 0;
            if (int.TryParse(CoinInput, out coin))
            {
                vm.AcceptCoin(coin);
                Console.WriteLine("Your current balance is {0} cents.", vm.GetBalance());
            
            }
            else
            { 
              Console.WriteLine("What product do you want?");
                string ProductInput = Console.ReadLine();
                product.DispenseItem(ProductInput);
            }
                Console.WriteLine("INSERT COIN");
                CoinInput = Console.ReadLine();
        }
        vm.MakeChange();
        product.DispenseItem("Cola");
        vm.DisplayItems();
/*
             Console.WriteLine("INSERT DESIRED ITEM");
        string ItemInput = Console.ReadLine();
        while (ItemInput != "q")
        {
            string item;
            if (int.TryParse(ItemInput, out item))
            {
                vm.AcceptCoin(coin);
                Console.WriteLine("Your current balance is {0} cents.", vm.GetBalance());
               

            }
            else
            { 
              Console.WriteLine("What product do you want?");
                string ProductInput = Console.ReadLine();
                vm.DispenseItem(ProductInput);
            }
                Console.WriteLine("INSERT COIN");
                CoinInput = Console.ReadLine();
        }*/
    }
   }
    

