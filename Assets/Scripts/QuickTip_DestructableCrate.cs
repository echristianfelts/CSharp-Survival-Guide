using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickTip_DestructableCrate : MonoBehaviour
{
    public GameObject fracturedCrate;
    public GameObject explosionEffect;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(fracturedCrate, transform.position, Quaternion.identity);
            GameObject FracturedObj = Instantiate(explosionEffect, transform.position, Quaternion.identity);
            Rigidbody[] allRigidBodies = fracturedCrate.GetComponentsInChildren<Rigidbody>();

            //Debug.Log(allRigidBodies[1].name);
            if (allRigidBodies.Length > 0)
            {
                // Debug.Log(allRigidBodies[1].name);
                foreach (var body in allRigidBodies)
                {
                    Debug.Log(body.name);
                    Debug.Log(body.transform.position);
                    Debug.Log(transform.position);
                    body.AddExplosionForce(5000, transform.position, 10);

                }
            }
            Destroy(this.gameObject);
        }
    }
}
