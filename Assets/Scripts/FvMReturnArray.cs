using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FvMReturnArray : MonoBehaviour
{

    /// <summary>
    /// /This is good for getting a bunch of the same thing to all change in the same way...
    /// There are probably other ways to filter other than "FindGameObjectsWithTag"
    /// It's nice to have options...
    /// </summary>

    public GameObject[] players;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            players = GetAllPlayers();
        }
    }

    GameObject[] GetAllPlayers()
    {
        GameObject[] allPlayers = GameObject.FindGameObjectsWithTag("Player");
        
        foreach(var p in allPlayers)
        {
            p.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);

        }

        return allPlayers;
    }

}
