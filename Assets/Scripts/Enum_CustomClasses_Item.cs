﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Enum_CustomClasses_Item 
{
    public string name;
    public int id;
    public Sprite icon;

    public enum ItemType
    {
        None,
        Weapon,
        Consumable
    }

    public ItemType itemType;

    public void Action()
    {
        switch(itemType)
        {
            case ItemType.Weapon:
                Debug.Log("This is a Weapon... ");
                break;
            case ItemType.Consumable:
                Debug.Log("This is food...");
                break;
            case ItemType.None:
                break;
        }
    }

}
