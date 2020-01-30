using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
    public int itemID;
    public string name;
    public string description;
}

public class Array_LoopThroughData : MonoBehaviour
{
    public Item[] myItems;

    // Start is called before the first frame update
    void Start()
    {
        foreach(var item in myItems)
        {
            Debug.Log(item.name);

        }

        foreach(var item in myItems)
            if (item.itemID == 7)
            {
                Debug.Log("You have item number 7..!!! [FOREACH METHOD]");
            }
            else
            {
                Debug.Log("Sorry.  No soup for you..!!! [FOREACH METHOD]");
            }

        for (int i = 0; i < myItems.Length; i++)
        {
            if (myItems[i].itemID == 7)
            { 
            Debug.Log("You have item number 7..!!! [FOR METHOD]");
            }
            else
            {
            Debug.Log("You get nothing...!!!!  [FOR METHOD]");
            }
        }


    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space))
        {
            int randoID = Random.Range(0, myItems.Length);
            {
                Debug.Log(myItems[randoID].name);

                //for (int i = 0; i < myItems.Length ;i++)
                //{
                //}

            }



        }
    }
}
