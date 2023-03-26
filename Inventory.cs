using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    private List<Items> itemList;

    public Inventory()
    {
        itemList = new List<Items>();
    }
 
    public void addItem(Items item)
    {
        itemList.Add(item);
    }
}
