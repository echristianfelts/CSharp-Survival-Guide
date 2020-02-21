using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enum_CustomClasses_Database : MonoBehaviour
{
    public List<Enum_CustomClasses_Item> ItemDB = new List<Enum_CustomClasses_Item>();

    void Start()
        {
        ItemDB[1].Action();
        }
}
