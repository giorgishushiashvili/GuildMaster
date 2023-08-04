using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public GameObject inventory; // TODO check if I will need to change it.


    [SerializeField] private int gold;

    public int GetGold()
    {
        return gold;
    }

    public bool CanSpend(int amount)
    {
        return gold >= amount;
    }

    public void SpendGold(int amount)
    {
        gold -= amount;
    }

    
}
