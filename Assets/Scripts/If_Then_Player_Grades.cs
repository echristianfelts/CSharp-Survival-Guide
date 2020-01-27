using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If_Then_Player_Grades : MonoBehaviour
{



    // 5 quiz grades
    // calculate average quiz grades
    // and then prints out the grade average based on the following table.

        // A => 90
        // A > B => 80
        // B > C => 70
        // F < 70

    public float quiz1 = 0f, quiz2 = 0f, quiz3 = 0f, quiz4 = 0f, quiz5 = 0f, quizAverage = 0f;
    public string letterGradeString = "C";

    // Start is called before the first frame update
    void Start()
    {
        //quiz1 = Mathf.RoundToInt((50 * Random.value) * 2);
        //quiz2 = Mathf.RoundToInt((50 * Random.value) * 2);
        //quiz3 = Mathf.RoundToInt((50 * Random.value) * 2);
        //quiz4 = Mathf.RoundToInt((50 * Random.value) * 2);
        //quiz5 = Mathf.RoundToInt((50 * Random.value) * 2);

        //float quizAverage = Mathf.RoundToInt((quiz1 + quiz2 + quiz3 + quiz4 + quiz5) / 5);

        //if (quizAverage < 70)
        //{
        //    letterGradeString = "F";
        //}
        //else if (quizAverage >= 70)
        //{
        //    letterGradeString = "C";
        //}
        //else if (quizAverage >= 80)
        //{
        //    letterGradeString = "B";
        //}

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //COMMENTED OUT to test manually inserting values.
            //
            //quiz1 = Mathf.RoundToInt((50 * Random.value) + 50);
            //quiz2 = Mathf.RoundToInt((50 * Random.value) + 50);
            //quiz3 = Mathf.RoundToInt((50 * Random.value) + 50);
            //quiz4 = Mathf.RoundToInt((50 * Random.value) + 50);
            //quiz5 = Mathf.RoundToInt((50 * Random.value) + 50);
            //
            //SECOND OPTION:
            //
            //<VARIABLE> = Mathf.RoundToInt((Random.Range(1,51)+50));


            quizAverage = Mathf.RoundToInt((quiz1 + quiz2 + quiz3 + quiz4 + quiz5) / 5);

            if (quizAverage < 70)
            {
                letterGradeString = "F";
            }
            else if (quizAverage >= 80)
            {
                letterGradeString = "B";
            }
            else if (quizAverage >= 90)
            {
                letterGradeString = "A";
            }
            else
            {
                letterGradeString = "C";
            }

            Debug.Log("Individually, the quiz results were " + quiz1 + ", " + quiz2 + ", " + quiz3 + ", " + quiz4 + " and " + quiz5 + ".");
            Debug.Log("The average of all of the quizes was " + quizAverage + " which thranslates into the lettergrade of an "+ letterGradeString + ".");

        }

    }
}
