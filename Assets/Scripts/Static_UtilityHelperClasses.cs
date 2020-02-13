using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Static_UtilityHelperClasses
{ 
    // A Static Class is a Helper Class.
    //
    // The methods in a Static Class must also be static.


public static void CreateObject()
    {
        //create a new primitive cube.
        GameObject.CreatePrimitive(PrimitiveType.Cube);
    }

public static void SetPosition(GameObject obj)
    {
        // Change positions of obj.
        obj.transform.position = Vector3.zero;

    }

    public static void SetColor(GameObject obj, Color color,bool randomColor=false )
    {

        if (randomColor == true)
        {
            obj.GetComponent<Renderer>().material.color = new Vector4(Random.value, Random.value, Random.value,1);

        }
        else
        {
            obj.GetComponent<Renderer>().material.color = color;
        }
        // Change color of obj.
        ///obj.GetComponent<Renderer>().material.color = new Vector4(Random.value, Random.value, Random.value, 1);


    }

}
