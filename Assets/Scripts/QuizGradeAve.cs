using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizGradeAve : MonoBehaviour
{
    public float quiz1 = 0f;
    public float quiz2 = 0f;
    public float quiz3 = 0f;
    public float quiz4 = 0f;
    public float quiz5 = 0f;

    // come up with 5 quiz grades.
    //print out quiz grades along with avarage.


    // Start is called before the first frame update
    void Start()
    {
        quiz1 = Mathf.RoundToInt(100 * Random.value);
        quiz2 = Mathf.RoundToInt(100 * Random.value);
        quiz3 = Mathf.RoundToInt(100 * Random.value);
        quiz4 = Mathf.RoundToInt(100 * Random.value);
        quiz5 = Mathf.RoundToInt(100 * Random.value);

        //  OR...
        //  DEFINE VARIABLES THUSLY...
        //  <VAR>= Random.Range(0f, 100f);

        float quizAverage = Mathf.RoundToInt((quiz1 + quiz2+ quiz3+ quiz4+ quiz5)/5);

        //  THEN...
        //  Use the following line to round value to 
        //  2 decimal places rather than rounding to the nearst whole number.
        //
        //  quizAverage = Mathf.Round(quizAverage * 100f) / 100f
        //
        //  Mathf.Round() rounds the contents of the brackets to the nearest whole number.
        //  multiplying then deviding by 100 gets you a value rounded to 2 decimal places.

        Debug.Log("Individually, the quiz results were " + quiz1 + ", " + quiz1 + ", " + quiz3 + ", " + quiz4 + " and " + quiz5 + ".");
        Debug.Log("The average of all of the quizes was " + quizAverage +".");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
