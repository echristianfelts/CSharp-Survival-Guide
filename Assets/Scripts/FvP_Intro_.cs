using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FvP_Intro_ : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start()");
        MyMethod();
        Debug.Log("Compleated calling MyMethod");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void MyMethod()
    {
        Debug.Log("MyMethod()");
    }


}
