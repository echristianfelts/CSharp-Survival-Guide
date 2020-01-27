using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch_Intro : MonoBehaviour
{
    public int selectedLevel;

    private int _easy = 0;
    private int _medium = 1;
    private int _hard = 2;

    // Start is called before the first frame update
    void Start()
    {
        selectedLevel = Random.Range(0,3);
    }

    // Update is called once per frame
    void Update()
    {
        switch (selectedLevel)
        {
            case 0: //easy
                Debug.Log("Easy..!");
                break;
            case 1: //medium
                Debug.Log("Easy..!");
                break;
            case 2: //hard
                Debug.Log("Easy..!");
                break;
            default:
                Debug.Log("Invalid Selection..!!");
                break;

        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            selectedLevel = Random.Range(0, 3);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            selectedLevel = 55;
        }
    }
}
