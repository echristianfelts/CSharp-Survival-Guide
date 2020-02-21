using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enums_Intro_SelectDifficulty : MonoBehaviour
{      
    //  Enums but a list of potential values into a variable then
    //  makes that variable available as a radio dial in the inspector.
    //  This variable can be tested.
    //

    public enum LevelSelector
    {
        Easy,
        Normal,
        Hard,
        Expert
    }

    public LevelSelector currentLevel;

    // Start is called before the first frame update
    void Start()
    {
        switch (currentLevel)
        {
            case LevelSelector.Easy:
                break;
            case LevelSelector.Normal:
                break;
            case LevelSelector.Hard:
                break;
            case LevelSelector.Expert:
                break;

        }
    }


}
