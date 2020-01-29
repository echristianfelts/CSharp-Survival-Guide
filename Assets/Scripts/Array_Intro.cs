using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array_Intro : MonoBehaviour
{
    public string[] names;

    public string[] items = new string[5];

    public int[] ages = new int[] {5, 3, 2, 55,66 };
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(names[0]);
        Debug.Log(ages[3]);
        Debug.Log(items[1]);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
