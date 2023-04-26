

using System;
using System.Collections.Generic;

namespace VendingMachine;

public class VendingMachine
{

    
  

    // Properties


    // Constructor
    public VendingMachine()
    {
         // Initialize properties
        Inventory = new Inventory();
    }

    public Inventory Inventory { get; private set; }
 


}