using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch_WeaponSelection : MonoBehaviour



{

    public int weaponID;

    // ID 1 = Gun
    // ID 2 = Knife
    // ID 3 = Machine Gun


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            weaponID = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            weaponID = 2;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            weaponID = 3;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            weaponID = 0;
        }


        switch (weaponID)
        {
            case 1: //easy
                Debug.Log("You have a gun!");
                break;
            case 2: //medium
                Debug.Log("You have a knife.  I hope you know how to use it!");
                break;
            case 3:
                Debug.Log("Ho, ho, ho...  Now you have a machine Gun...!!!");
                break;
            default:
                Debug.Log("You have no weapons...!!!");
                break;
        }


    }
}
