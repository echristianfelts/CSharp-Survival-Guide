using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array_ForEachLoop : MonoBehaviour
{
    //public int[] itemID;
    //public string[] itemName;
    public int[] ageArray;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            /*for(int i = 0; i < itemName.Length; i++)
            {
                Debug.Log(itemName[i]);

            }*/

            foreach (var age in ageArray)
            {

                    Debug.Log(age);
                

            }
        }

    }
}

