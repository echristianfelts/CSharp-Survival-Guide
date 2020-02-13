using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickTip_LookRotation : MonoBehaviour
{



    [SerializeField]

    private Transform _sphere;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //direction = destination - source
        Vector3 directionToFace = _sphere.position - transform.position;
        Debug.DrawRay(transform.position, directionToFace, Color.green);
        //access current rot = Quantranion Look Rotation
        //////  This snaps rotation to follow the target object...  transform.rotation = Quaternion.LookRotation(directionToFace);

        //SlerpMods
        Quaternion targetRotation = Quaternion.LookRotation(directionToFace);

        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime);


    }
}
