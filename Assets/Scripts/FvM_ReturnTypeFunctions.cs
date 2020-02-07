using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FvM_ReturnTypeFunctions : MonoBehaviour
{
    public int total;
    public int total2;

    // Start is called before the first frame update
    void Start()
    {
        total = Sum(2, 5);
        total2 = Sum(10, 24);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private int Sum(int a, int b)
    {
        return a + b;
    }

}
