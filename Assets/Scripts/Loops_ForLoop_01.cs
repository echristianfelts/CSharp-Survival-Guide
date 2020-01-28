using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops_ForLoop_01 : MonoBehaviour
{

    public string myName = "Chris";

    // Start is called before the first frame update
    void Start()
    {
        //for (int i = 0; i < 100; i++)  //'i' is like an index variable.
        //{
        //    Debug.Log(myName);

        //}

        //Debug.Log("Naming Loop is Finished...");

        for ( int i = 0; i < 100; i++)  //'i' is like an index variable.
        {
            if (i % 2 == 0)
            {
                Debug.Log(i);
            }

        }

        Debug.Log("Counting Loop is Finished...");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
