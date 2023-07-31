using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInstance
{
    private Item item;
    private int itemAmount;

    public ItemInstance(Item itemObject, int amount)
    {
        item = itemObject;
        itemAmount = amount;
    }

    public Item GetItem() 
    { 
        return item;
    }
    public int GetAmount()
    {
        return itemAmount;
    }

    public void AddAmount(int amount)
    { 
        itemAmount += amount;
    }

    public void RemoveAmount(int amount)
    {
        itemAmount -= amount;
    }
}
