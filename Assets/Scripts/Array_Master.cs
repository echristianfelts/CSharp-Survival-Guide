using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array_Master : MonoBehaviour
{

    //create an array of 5 names and print out the last kids name
    //create an array of 5 ages that corrispond to each kid and print out the last kid
    //create an array of 5 car models and print out the last kids favorite car.
    //This all happens on keypress spacebar.

    public string[] kidNames = new string[5] { "Manny", "Moe", "Jack", "Curly", "Sue" };
    public int[] kidAges = new int[5] { 12, 13, 12, 11, 12 };
    public string[] kidCars = new string[5] { "Porche", "Bolt", "Honda", "Trans Am", "Peterbilt" };

    private int _Rando;

    // Start is called before the first frame update
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
        _Rando = Random.Range(0, 5);
        if (Input.GetKeyDown(KeyCode.Space))
            {
            Debug.Log(kidNames[_Rando] +" is "+kidAges[_Rando] +" years old and the kid's favorite car is the "+ kidCars[_Rando] +".");
        }
    }
}
