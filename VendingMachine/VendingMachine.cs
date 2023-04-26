

using System;
using System.Collections.Generic;

namespace VendingMachine;

public class VendingMachine
{

    
    private int balance;

    // Properties
    private int currentAmount;
    private string currentSelection;

    // Constructor
    public VendingMachine()
    {
         // Initialize properties
        currentAmount = 0;
        Inventory = new Inventory();
    }

    public Inventory Inventory { get; private set; }
 

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
 

   
  
    public bool IsExactChangeRequired()
    {
        // Check if exact change is required
        // Update display
        return true;
    }


}