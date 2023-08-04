using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Market : MonoBehaviour
{
    public GameObject gameManager;


    // Returns amount bought
    public int Buy(GameObject buyer, Item item, int amount)
    {
        if (gameManager.GetComponent<InventorySystem>().CanRemove(item,amount))
        {
            gameManager.GetComponent<InventorySystem>().RemoveItem(item,amount);
            if (buyer.name == "Player")
            {
                if (buyer.GetComponent<PlayerManager>().CanSpend(amount))
                {
                    buyer.GetComponent<PlayerManager>().SpendGold(amount);
                    return amount;
                }
                else
                {
                    Debug.Log("you do not have money");
                    return 0;
                }
            }
            else
            {
                return amount;
            }
        }
        else
        {
            Debug.Log("not enough amount");
            return 0;
        }
    }
    //Returns Gold earned
    public int Sell(Item item, int amount)
    {
        if (gameManager.GetComponent<InventorySystem>().CanRemove(item, amount))
        {
            gameManager.GetComponent<InventorySystem>().RemoveItem(item, amount);
            return amount;
        }
        else
        {
            return 0;
        }
    }
}
