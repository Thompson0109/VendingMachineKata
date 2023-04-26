using System;
using System.Collections.Generic;

namespace VendingMachine;

public class Product{
 public enum Item
    {
        Unknown,
        Cola,
        Candy,
        Chips
    };

  public Dictionary<string, int> inventory;

public Product()
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
    }

      public bool IsProductSoldOut(string product)
    {
        // Check if product is sold out
        // Update display
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

}