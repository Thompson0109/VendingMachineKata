

using System;
using System.Collections.Generic;

namespace VendingMachine;

public class VendingMachine
{

    //Contains Item name and value (Price)
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
            Console.WriteLine(item);
            inventory[item] += count;
            
        }
        else
        {
            inventory.Add(item, count);
        }
        Console.WriteLine(item + "Added");
    }

    public void SelectProduct(string product)
    {
        // Check if product is in stock
        // Check if current amount is sufficient
        // Dispense product and update display
        // If not, display price or not enough money

        
    }

    public void MakeChange()
    {
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
        return 250;
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