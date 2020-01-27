using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If_Then_Player_Speedy : MonoBehaviour
{

    //
    // Increase speed with keypress for 'S'
    //Decrement Speed with keypress 'A'
    //Speed abouve 20 output "Slow Down"
    //Speed at zero output "Speed up"
    //Speed bottoms out at zero.


    public float speed = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            speed += 1;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            speed -= 1;
        }

        if (speed <= 0)
        {
            speed = 0f;
            Debug.Log("Your speed is "+ speed + ". Speed up..!!!");
        }

        if (speed > 20)
        {

            Debug.Log("Your speed is " + speed + ". Slow down..!!!");
        }

        if (speed < 20 && speed > 0)
        {

            Debug.Log("Your speed is " + speed + ". Looking Good...");
        }
    }
}
