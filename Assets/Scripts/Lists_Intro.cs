using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lists_Intro : MonoBehaviour
{
    public List<GameObject> enemiesToSpawn = new List<GameObject>();
    public GameObject[] objectsToSpawn = new GameObject[10];


    private void Start()
    {
        objectsToSpawn[0] = new GameObject();

        enemiesToSpawn.Add(new GameObject());
        enemiesToSpawn.Add(new GameObject());
        enemiesToSpawn.Add(new GameObject());

        objectsToSpawn[0].name = "John";
        enemiesToSpawn[2].name = "Bill";
    }


}
