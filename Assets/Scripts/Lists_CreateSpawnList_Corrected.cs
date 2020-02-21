using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lists_CreateSpawnList_Corrected : MonoBehaviour
{
    //Challenge: Create a list/array of 3 gameObjects to spawn and randomly spawn/move at a 
    //random position on the screen withein the bounds of -10 to +10 on both the x and y axes
    // when you hit the spacebar.  Every object should be stored in a list called objectsCreated. 
    // When you have 10 objects, you will no longer be able to spawn objects ans will turn all
    // created objects green.
    //
    // Then you will clear the list...
    public GameObject[] SpawnList = new GameObject[3];
    public List<GameObject> ObjectsCreated = new List<GameObject>();
    public int SpawnCount { get; set; }

    private bool _intiColorChange = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (SpawnCount == 10)
            {
                _intiColorChange = true;

                return;
            }

            var objectToSpawn = SpawnList[Random.Range(0, SpawnList.Length)];
            var xPos = Random.Range(-10, 10);
            var yPos = Random.Range(-10, 10);
            var pos = new Vector3(xPos, yPos, 0);
            var go = Instantiate(objectToSpawn, pos, Quaternion.identity) as GameObject;

            ObjectsCreated.Add(go);

            SpawnCount++;

        }

        if (_intiColorChange == true)
        {
            _intiColorChange = false;

            foreach(var obj in ObjectsCreated)
            {
                obj.GetComponent<MeshRenderer>().material.color = Color.green;
            }
            ObjectsCreated.Clear();
        }
    }
}
