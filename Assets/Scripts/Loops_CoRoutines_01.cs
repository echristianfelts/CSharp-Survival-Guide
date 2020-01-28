using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops_CoRoutines_01 : MonoBehaviour
{
    public int apples;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AddApplesCoRoutine());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator AddApplesCoRoutine()
    {
        for (int i = 0; i < 100; i++)
        {
            apples++;
            yield return new WaitForSeconds(1.0f);
            Debug.Log("we have " + apples + " apples...");

        }
    }




}
