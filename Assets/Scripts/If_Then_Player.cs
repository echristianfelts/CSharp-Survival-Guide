using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If_Then_Player : MonoBehaviour
{


    public int myAge = 45;
    int legalDrivingAge = 15;

    // Start is called before the first frame update
    void Start()
    {

        //if condition (myAge is greater than the legalDrivingAge) is true
        //Run the following code:(Print "You can Drive..")
        //else...
        //Print "You cannot drive."


        if (myAge >= legalDrivingAge)
        {

            //Do this stuff
            Debug.Log("You can drive...");

        }

        else
        {

            Debug.Log("You CAN'T drive...");

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
