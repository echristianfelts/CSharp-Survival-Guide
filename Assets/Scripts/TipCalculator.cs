using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipCalculator : MonoBehaviour
{

    //bill is $20
    //Tip is 20% or based on what user wants.
    //Calculate and display total ammount.

    public float bill = 20f;
    public float tipPercentage = .2f;
    public float billTotal = 0f;

    // Start is called before the first frame update
    void Start()
    {
        float tipTotal = bill * tipPercentage;
        billTotal = bill + tipTotal;


        //Your bill is:xx and your tip is xx so you owe xx.
        Debug.Log("Your bill is: $" + bill + ", and your tip is: $" + tipTotal + ", so you owe: $" + billTotal + ".");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
