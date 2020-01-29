using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array_ForLoop : MonoBehaviour
{
    public int[] itemID;
    public string[] itemName;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < itemName.Length; i++)
            {
                if (itemName[i] == "sword")
                {
                    Debug.Log("Item Exists..!");
                    Debug.Log("Item ID: " + itemID[i]);

                }
            }
        }
        
    }
}
