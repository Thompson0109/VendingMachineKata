using System;
using System.Collections.Generic;

namespace VendingMachine;

public class Inventory{


  public Dictionary<string, int> inventory;
  public Coins CoinBank { get; set; }


public Inventory()
{
      inventory = new Dictionary<string, int>();
}

   public void AddItem(string item, int count)
    {
        if (inventory.ContainsKey(item))
        {
            inventory[item] += count;
        }
        else
        {
            inventory.Add(item, count);
        }
        Console.WriteLine($"{item} Added. There are currenlty {count} {item}'s");
    }

     public void PurchaseItem(string itemName) {

        if (!inventory.ContainsKey(itemName)) {
            Console.WriteLine("Item not found: {0}", itemName);
            return;
        }
     Console.WriteLine(CoinBank.currentAmount);
        IsProductSoldOut(itemName);

        int price = GetItemPrice(itemName);
   
        if (price > CoinBank.currentAmount) {
            Console.WriteLine("Not enough balance. Price: {0} cents, Balance: {1} cents", price, CoinBank.currentAmount);
            return;
        }
        
        DispenseItem(itemName);

        CoinBank.currentAmount -= price;
        Console.WriteLine("Purchased item: {0} (price: {1} cents). Balance: {2} cents", itemName, price, CoinBank.currentAmount);
    }

    
    public void SelectProduct(string product)
    {
        // Check if product is in stock
        // Check if current amount is sufficient
        // Dispense product and update display
        // If not, display price or not enough money
    }


      public void DispenseItem(string item)
    {
        if (inventory.ContainsKey(item))
        {
            //Assuming all items are worth 50p
          
                inventory[item]--;
                Console.WriteLine($"{item}: ");

                Console.WriteLine("Here's your {0}.", item);
        }
        else
        {
            Console.WriteLine("Invalid item.");
        }
        DisplayItems();
    }



      public bool IsProductSoldOut(string product)
        {
            // Check if product is sold out
            int quantity = inventory[product];

            if (quantity == 0) {
                Console.WriteLine("Item out of stock: {0}", product);
            }
   
            return true;
        }

       public int GetItemPrice(string itemName) {
        // Assume that all items have the same price
        
          int price = 0;
            if (itemName == "Cola")
            {
                price = 100;
            }
            else if(itemName == "Crisps")
            {
                price = 50;
            }
            else if(itemName == "Chocolate")
            {
                price = 65;
            }

            return price;
    }

     private void DisplayItems() {
        Console.WriteLine("Available items:");
        foreach (KeyValuePair<string, int> item in inventory) {
            Console.WriteLine("{0} ({1} cents) - {2} left", item.Key, GetItemPrice(item.Key), item.Value);
        }
    }
}