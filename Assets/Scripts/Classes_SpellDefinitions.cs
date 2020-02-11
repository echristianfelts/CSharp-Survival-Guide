using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Classes_SpellDefinitions
{

    public string name;
    public int levelRequired;
    public int itemIdRequired;
    public int expGained;

    // Update is called once per frame
    public Classes_SpellDefinitions(string name, int levelRequired, int itemIdRequired, int expGained)
    {
        this.name = name;
        this.levelRequired = levelRequired;
        this.itemIdRequired = itemIdRequired;
        this.expGained = expGained;

    }

    public void Cast()
    {
        Debug.Log("Casting: " + this.name);


    }
}
