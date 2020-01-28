using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops_UPO : MonoBehaviour
{
    // create prog that prints out 0-10, then 10-20 evens, then 20-30 odds.
    // hint modulus.


    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < 30; i++)  //'i' is like an index variable.
        {
            if (i < 11)
            {
                Debug.Log(i);

            }
            else if (i < 21 && (i % 2 == 0))
            {
                Debug.Log(i);

            } else if (i>20 && (i % 2 == 1))
            {
                Debug.Log(i);

            }




        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
