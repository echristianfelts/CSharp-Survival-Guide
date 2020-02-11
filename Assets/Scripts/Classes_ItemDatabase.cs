using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Classes_ItemDatabase : MonoBehaviour
{
    public Classes_Items sword;
    public Classes_Items hammer;
    public Classes_Items bread;


    // Start is called before the first frame update
    void Start()
    {
        sword = new Classes_Items();
        sword.itemName = "Sword";
        sword.id = 1;
        sword.attackDamage = 4.5f;


        //      string name;
        //      int ID;
        //      float attackDamage;

        hammer = new Classes_Items("Hammer", 2, 3.3f);

        bread = CreateItem("Bread", 3, 0.0f);

    }


    private Classes_Items CreateItem(string name, int id, float damage)
    {
        var item = new Classes_Items(name, id, damage);
        return item;
    }


}
