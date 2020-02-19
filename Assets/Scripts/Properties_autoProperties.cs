using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Properties_autoProperties : MonoBehaviour
{
    public bool IsGameOver { get; private set; }
    public bool IsGameOver1 { get; protected set; }
    public bool IsGameOver2 { get; set; }




    // Start is called before the first frame update
    void Start()
    {
        IsGameOver = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
    
        }
    }
}
