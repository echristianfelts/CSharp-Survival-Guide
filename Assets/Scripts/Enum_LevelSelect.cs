using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enum_LevelSelect : MonoBehaviour
{

    public enum Difficulty
    {
        Easy = 1,
        Normal = 2,
        Hard = 3,
        Expert = 4
    }

    public Difficulty selectedDifficulty;
    // Start is called before the first frame update
    void Start()
    {
        //SceneManager.LoadScene((int)selectedDifficulty);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {

            SceneManager.LoadScene((int)selectedDifficulty);

        }

    }
}
