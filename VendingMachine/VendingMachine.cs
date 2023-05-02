

using System;
using System.Collections.Generic;

namespace VendingMachine;

public class VendingMachine
{

    
  

    // Properties


    // Constructor
    public VendingMachine()
    {
            CoinBank = new CoinBank();
            InventoryCollection = new Inventory();
    }

    public CoinBank CoinBank { get; set; }
    public Inventory InventoryCollection { get; set; }


     public string Display 
        { 
            get
            {
                string display;

                if (!string.IsNullOrEmpty(TemporaryDisplay))
                {
                    // The temporary display is only displayed
                    // once. After it has been seen, displays 
                    // revert to their normal behavior.
                    display = TemporaryDisplay;
                    TemporaryDisplay = string.Empty;
                }
                else if(CoinSlot.Value == 0)
                {
                    if(CoinBank.Value == 0)
                    {
                        // Let the use know if there's
                        // no money left to make change.
                        display = "EXACT CHANGE ONLY";
                    }
                    else
                    {
                        // If the coin slot is empty
                        // instruct the user to add money.
                        display = "INSERT COINS";
                    }
                }
                else
                {
                    display = CreateCurrencyString(CoinBank.currentAmount);
                }

                return display;
            }
        }

      // Insert coins into the coin slot.
        public void Insert(Coin coin, int num)
        {
              if (coin == Coin.Unknown)
            {
                Console.WriteLine();
            }
            else{
                CoinBank.Insert(coin, num);
            }
        }

        // Add products to the invenory
        public void Insert(Product product, int num)
        {
            InventoryCollection.Insert(product, num);
        }

   
        private string CreateCurrencyString(int amount)
        {
            return string.Format("{0:C}", amount / 100.0);
        }

}