using System;
using System.Collections.Generic;
namespace VendingMachine;

public class CoinBank{

    public int currentAmount;
    private Dictionary<Coin, int> Coins { get; set; }



    public CoinBank()
    {
          // Initialize properties
        currentAmount = 0;
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


        internal void Insert(Coin coin, int num)
        {
            if(Coins.ContainsKey(coin))
            {
                Coins[coin] += num;
            }
            else
            {
                Coins.Add(coin, num);
            }
        }

        
    public void AddAmount(int coin){
                currentAmount += coin;
    }

    public void MakeChange()
    {
        Console.WriteLine("Your change is {0} p.", currentAmount);
        currentAmount = 0;
        // Calculate change
        // Dispense change and update display
    }

        private int CoinValue(Coin coin)
        {
            int value = 0;

            if (coin == Coin.OneP)
            {
                value = 1;
            }
            else if (coin == Coin.TwoP)
            {
                value = 2;
            }
            else if (coin == Coin.FiveP)
            {
                value = 5;
            }
            else if (coin == Coin.TenP)
            {
                value = 10;
            }
   
            else if (coin == Coin.TwentyP)
            {
                value = 10;
            }
            else if (coin == Coin.FiftyP)
            {
                value = 50;
            }
            else if (coin == Coin.OnePound)
            {
                value = 100;
            }
            else if (coin == Coin.TwoPound)
            {
                value = 200;
            }

            return value;
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