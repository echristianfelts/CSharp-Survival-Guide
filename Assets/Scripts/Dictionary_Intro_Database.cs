using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dictionary_Intro_Database : MonoBehaviour
{

    public List<Dictionary_Intro_Item> itemList = new List<Dictionary_Intro_Item>();

    public Dictionary<int, Dictionary_Intro_Item> itemDictionary = new Dictionary<int, Dictionary_Intro_Item>();


    // Start is called before the first frame update
    void Start()
    {
        Dictionary_Intro_Item sword = new Dictionary_Intro_Item();
        sword.name = "Sword";
        sword.id = 0;

        Dictionary_Intro_Item bread = new Dictionary_Intro_Item();
        bread.name = "Bread";
        bread.id = 1;

        Dictionary_Intro_Item cape = new Dictionary_Intro_Item();
        cape.name = "Cape";
        cape.id = 2;

        itemList.Add(sword);
        itemDictionary.Add(0, sword);
        itemDictionary.Add(1, bread);
        itemDictionary.Add(2, cape);

        // var Item = itemDictionary[0];

        foreach (KeyValuePair<int, Dictionary_Intro_Item> item in itemDictionary)
        {
            Debug.Log("Key:" + item.Key);
            Debug.Log("Value:" + item.Value.name);
        }

        foreach (int key in itemDictionary.Keys)
        {
            Debug.Log("Key: " + key);
        }

        foreach (Dictionary_Intro_Item item in itemDictionary.Values)
        {
            Debug.Log("Item Name: " + item.name);
        }

        if(itemDictionary.ContainsKey(1))  // This could be repalced by some sort of switching method I suppose...
        {
            Debug.Log("You found the key");
            var randomItem = itemDictionary[1];
        }
        else
        {
            Debug.Log("This key does not exist...");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
