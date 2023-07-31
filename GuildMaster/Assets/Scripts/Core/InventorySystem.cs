using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using static UnityEditor.Progress;

public class InventorySystem : MonoBehaviour
{
    public List<ItemInstance> inventory = new();

    public ItemInstance GetItemFromInventory(Item item)
    {
        return inventory.Find(ItemInstance => ItemInstance.GetItem() == item);
    }

    public void AddItem(Item item, int amount)
    {
        ItemInstance getItem = inventory.Find(ItemInstance => ItemInstance.GetItem() == item);
        if (getItem != null)
        {
            inventory.Remove(getItem);
            getItem.AddAmount(amount);
            inventory.Add(getItem);
        }
        else
        {
            inventory.Add(new (item,amount));
        }
    }

    public void RemoveItem(Item item, int amount)
    {
        ItemInstance getItem = inventory.Find(ItemInstance => ItemInstance.GetItem() == item);
        if (getItem == null) 
        {
            return;
        }
        else
        {
            if (getItem.GetAmount() > amount)
            {
                inventory.Remove(getItem);
                getItem.RemoveAmount(amount);
                inventory.Add(getItem);
            }
            else if(getItem.GetAmount() <= amount)
            {
                inventory.Remove(getItem);
            }
        }
    }
    
}
