using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Static_PE_SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;

    public static int enemyCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("This maens that the a Key is down...");
            Instantiate(enemyPrefab);

        }
    }
}
