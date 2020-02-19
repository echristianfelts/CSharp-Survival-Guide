using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Properties_Declaring : MonoBehaviour
{
    private bool isGameOver;

    public bool IsGameOver
    {
        get
        {
            return isGameOver;

        }
        set
        {
            if (value == true)
            {

                Debug.Log("Oh No..!  The Game is over..!");
            }
            isGameOver = value;

        }
             

    }
    // Start is called before the first frame update
    void Start()
    {
        isGameOver = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            IsGameOver = true;
        }
    }
}
