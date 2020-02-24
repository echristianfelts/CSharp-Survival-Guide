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

        itemList.Add(sword);
        itemDictionary.Add(0, sword);

        var Item = itemDictionary[0];

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
