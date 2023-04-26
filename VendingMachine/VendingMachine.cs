

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

    

}