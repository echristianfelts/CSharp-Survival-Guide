using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops_SpeedTestChallenge : MonoBehaviour
{
    private int maxSpeed;

    // Create Program where you increment val of speed by 5 every sec.
    // When Speed is greater than MaxSpeed, stop increment and break out.
    // Max Speed random val 60 - 120

    // Start is called before the first frame update
    void Start()
    {
        maxSpeed = Random.Range(60, 121);
        StartCoroutine(speedRoutine());

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator speedRoutine()
    {
        while(true)
        {
            for (int speed = 0; speed <= maxSpeed; speed += 5)
            {
                Debug.Log("Max Speed: " + maxSpeed + " Current Speed :" + speed);
                yield return new WaitForSeconds(1.0f);
            }


        }
    }

}
