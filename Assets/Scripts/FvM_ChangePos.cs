using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FvM_ChangePos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Hard coded transform

        // transform.position = new Vector3(0, 0, 0);
        // ChangePosition(new Vector3(0, 0, 0));
        transform.position = GetPosition();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangePosition(Vector3 pos)
    {
        transform.position = pos;
    }

    public Vector3 GetPosition()
    {
        return Vector3.zero;
    }

    public Vector3 GetPosition_02(Vector3 pos)
    {
        pos = Vector3.zero;
        return pos;
    }

    public Vector3 GetPosition_03(float x, float y, float z)
    {
        Vector3 pos = new Vector3( x, y, z);
        return pos;
    }
}
