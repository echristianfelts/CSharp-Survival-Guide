using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Create a variable to store your name.
    // Create a variable to store your age.
    // Create a variable to store your speed.
    // Create a health variable.
    // Create a score variable.
    // Create a key check variable to see if all keys are collected.
    // Create a variable for the ammo count.

    private string _name = "Stewart";
    private int _age = 25;
    private float _speed = 25f;
    private int _health;
    private string _healthString = "dandy..!";
    private bool _redKey = true;
    private bool _blueKey = true;
    private bool _blackKey = true;
    private bool _yellowKey = true;
    private bool _allKeys = true;
    private string _keyDisplay = "and has";
    private int _ammoCount = 100;



    /// Start is called before the first frame update
    void Start()
    {
        Debug.Log("Patrick's name is " + _name + ".");
        Debug.Log("He is " + _age + " years old and is feeling "+ _healthString);
        Debug.Log("He travels at " + _speed + " units per hour " + _keyDisplay + " all of the keys.");
        Debug.Log("Patrick has " + _ammoCount + " shots left in his gun before his job becomes more difficult.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
