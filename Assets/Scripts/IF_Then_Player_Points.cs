using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IF_Then_Player_Points : MonoBehaviour
{// place var to store points

    [SerializeField]
    private int _pointCount = 0;
    public int pointIncrement = 10;
    bool _awesomeFlag = false;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Current Point Count is: " + _pointCount);
    }

    // Update is called once per frame
    void Update()
    {


        // if whe his the spacekey...
        // you get 10 points.

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _pointCount += pointIncrement;

            Debug.Log ("Current Point Count is: "+ _pointCount);

        }

        // if _pointCount gets to fifty points
        // print You are awesome..!

        if (_pointCount >= 50 && _awesomeFlag == false)
        {

            Debug.Log("You are awesome..!");

            _pointCount = 0;
            _awesomeFlag = true;

            Debug.Log("Reseting Pointcount to: "+ _pointCount );

        } else if (_pointCount >= 50)
        {

            Debug.Log("I have already told you how awesome you are.  You don't need to hear it a bunch of times.");

            _pointCount = 0;

            Debug.Log("Reseting Pointcount to: " + _pointCount);
        }

    }
}
