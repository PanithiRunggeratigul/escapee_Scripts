using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Inventory : MonoBehaviour
{
    private Inventory inventory;

    public void setInventory(Inventory inventory)
    {
        this.inventory = inventory;
    }
}