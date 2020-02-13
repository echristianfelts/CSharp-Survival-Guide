using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickTip_DestructableCrate : MonoBehaviour
{
    public GameObject fracturedCrate;
    public GameObject explosionEffect;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(explosionEffect, transform.position, Quaternion.identity);
            GameObject FracturedObj = Instantiate(fracturedCrate, transform.position, Quaternion.identity) as GameObject;
            Rigidbody[] allRigidBodies = FracturedObj.GetComponentsInChildren<Rigidbody>();

            //Debug.Log(allRigidBodies[1].name);
            if (allRigidBodies.Length > 0)
            {
                // Debug.Log(allRigidBodies[1].name);
                foreach (var body in allRigidBodies)
                {
                    Debug.Log(body.name);
                    Debug.Log(body.transform.position);
                    Debug.Log(transform.position);
                    body.AddExplosionForce(1200, transform.position, 2);

                }
            }
            Destroy(this.gameObject);
        }
    }
}
