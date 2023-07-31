using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Items")]
public class Item : ScriptableObject
{
    public int id;
    public string itemName;
    [TextArea]
    public string description;
    public Sprite icon;


    //Selector for the items
    public enum ItemTypes
    {
        Resource
    }

    [SerializeField]
    public ItemTypes itemTypes;
}
