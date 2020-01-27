using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If_Then_Player_Difficulty : MonoBehaviour
{
    public int easyDifficulty = 0;
    public int mediumDifficulty = 1;
    public int hardDifficulty = 2;
    public int currentDifficulty;

    // Start is called before the first frame update
    void Start()
    {
        currentDifficulty = mediumDifficulty;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentDifficulty == easyDifficulty)
        {
            Debug.Log("You have selected the easiest level...");
        }
        else if (currentDifficulty == mediumDifficulty)
        {
            Debug.Log("You have selected a medium level...");
        }
        else if (currentDifficulty == hardDifficulty)
        {
            Debug.Log("You have selected the hardest level...");
        }
        else 
        {
            Debug.Log("This is not a valid option...");
        }
    }
}
