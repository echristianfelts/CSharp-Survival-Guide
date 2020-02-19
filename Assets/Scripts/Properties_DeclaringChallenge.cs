using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Properties_DeclaringChallenge : MonoBehaviour
{

    //Create Properties for the Following:
    // Speed (Read Only)
    // Name Public


    //   public int Speed { get; }

    //   public string Name { get; set; }

    public string varName;

    public string Name
    {
        get
        {
            return varName;

        }
        set
        {
            if (value == "slim")
            {
                // seroiusly, weo no not need this part...
                Debug.Log("My Name is "+ varName);
            }
            varName = value;

        }


    }

    public int varSpeed;

    public int Speed
    {
        get
        {
            return varSpeed;

        }


    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
