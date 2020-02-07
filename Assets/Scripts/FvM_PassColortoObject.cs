using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FvM_PassColortoObject : MonoBehaviour
{

    //Create a program where you assign a cube in the inspector and when you hit
    //the space key, you pass that object into a function called ChangeColor.  The function should take both the GameObject
    // and a color to change to and the operation should be handled within the function.

    [SerializeField]
    private GameObject _gameObject;
    [SerializeField]
    private Color _color;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PassColor();
    }

    private void PassColor()
    {
        _gameObject.GetComponent<Renderer>().material.color = _color;
    }
}
