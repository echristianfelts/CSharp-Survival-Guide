using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Classes_VMO_Pets : MonoBehaviour
{

    public string petName;

    public virtual void Speak()
    {
        Debug.Log("Speak..!");
    }

    private void Start()
    {
        Speak();
    }

}
