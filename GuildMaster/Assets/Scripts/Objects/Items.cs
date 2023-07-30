using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Items", menuName = "Items/Resources")]
public class Items : ScriptableObject
{
    // basic information
    public string ItemName;
    public string Description;
    public int Tier;
    public int Enchantment;

    public Sprite Artwork;

}
