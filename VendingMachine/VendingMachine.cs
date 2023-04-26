

using System;
using System.Collections.Generic;

namespace VendingMachine;

public class VendingMachine
{

    
  

    // Properties


    // Constructor
    public VendingMachine()
    {
            CoinBank = new Coins();
            InventoryCollection = new Inventory();
    }

    public Coins CoinBank { get; set; }
    public Inventory InventoryCollection { get; set; }

    

}