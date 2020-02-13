using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Static_Player : MonoBehaviour
{
    public bool randomColor = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Static_UtilityHelperClasses.CreateObject();

        }

        if(Input.GetKeyDown(KeyCode.E))
        {
            Static_UtilityHelperClasses.SetPosition(this.gameObject);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            Static_UtilityHelperClasses.SetColor(this.gameObject,Color.red, randomColor);
        }


    }

}
