﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch_Player : MonoBehaviour
{
    public int points;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Q))
        {
            points = 50;

        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            points = 100;
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            points = 0;
        }


        //based on the value of points...
        // we print out.

        if (points == 50)
        {
            Debug.Log("Points are 50!");
        }
        else if (points == 100)
        {
            Debug.Log("Points are 100!");
        }
        else
            {
            Debug.Log("Only socres of 50 or 100 get readouts..!");
            }


    }
}
