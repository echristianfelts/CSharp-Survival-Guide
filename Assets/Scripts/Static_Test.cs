using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Static_Test : MonoBehaviour
{

    private Static_Score _score;

    // Start is called before the first frame update
    void Start()
    {
       _score = GameObject.Find("Score Keeper").GetComponent<Static_Score>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Frame number");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //add 10 to score...
            Static_Score.score += 10;
            Debug.Log(Static_Score.score);

        }
    }
}
