

using System;
using System.Collections.Generic;

namespace VendingMachine;

public class VendingMachine
{

    private Dictionary<string, int> inventory;
    private int balance;

    // Properties
    private int currentAmount;
    private string currentSelection;

    // Constructor
    public VendingMachine()
    {
         // Initialize properties
        currentAmount = 0;
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

     public void AcceptCoin(int coin)
    {
        // Check if coin is valid
        switch (coin)
        {
            case 1:
                AddAmount(coin);
                break;
            case 2:
                AddAmount(coin);
                break;
            case 5:
                AddAmount(coin);
                break;
            case 10:
               AddAmount(coin);
                break;
            case 20:
                AddAmount(coin);
                break;
            case 50:
                AddAmount(coin);
                break;
            case 100:
                AddAmount(coin);
                break;
            case 200:
                AddAmount(coin);
                break;
            default:
                // Reject coin
                Console.WriteLine($"Coin Rejected. {coin} Is not a value option ");
                // Place coin in coin return
                break;
        }
    }
    public void AddAmount(int coin){
                currentAmount += coin;
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
            if (inventory[item] > 0 && currentAmount >=  50)
            {
                inventory[item]--;
                Console.WriteLine($"{item}: ");
                currentAmount -= 50;
                Console.WriteLine("Here's your {0}.", item);
            }
            else
            {
                Console.WriteLine("Sorry, {0} is out of stock or you don't have enough balance.", item);
            }
        }
        else
        {
            Console.WriteLine("Invalid item.");
        }
    }


    public void MakeChange()
    {

        Console.WriteLine("Your change is {0} cents.", balance);
        balance = 0;
        // Calculate change
        // Dispense change and update display
    }

    public void ReturnCoins()
    {
        // Return current amount to user
        // Update display
    }
    public int GetBalance()
    {
        return currentAmount;
    }
    private int GetItemPrice(string itemName) {
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


    public void DisplayItems() {
        Console.WriteLine("Available items:");
        foreach (KeyValuePair<string, int> item in inventory) {
            Console.WriteLine("{0} ({1} cents) - {2} left", item.Key, GetItemPrice(item.Key), item.Value);
        }
    }

    public bool IsProductSoldOut(string product)
    {
        // Check if product is sold out
        // Update display
        return true;
    }

    public bool IsExactChangeRequired()
    {
        // Check if exact change is required
        // Update display
        return true;
    }


}