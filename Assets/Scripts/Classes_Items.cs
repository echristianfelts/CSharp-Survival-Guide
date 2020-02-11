using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Classes_Items
{
    public string itemName;
    public int id;
    public float attackDamage;
    //public string attackDamageType;
    //public float range;
    //public int hitPoints;
    //public string description;

    public Classes_Items()
    {


    }


    public Classes_Items(string itemName, int id, float attackDamage)// float attackDamage, float range, int hitPoints, string description)
    {
        this.itemName = itemName;
        this.id = id;
        this.attackDamage = attackDamage;


    }
}
