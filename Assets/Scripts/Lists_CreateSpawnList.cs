using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lists_CreateSpawnList : MonoBehaviour   
{
    //Challenge: Create a list/array of 3 gameObjects to spawn and randomly spawn/move at a 
    //random position on the screen withein the bounds of -10 to +10 on both the x and y axes
    // when you hit the spacebar.  Every object should be stored in a list called objectsCreated. 
    // When you have 10 objects, you will no longer be able to spawn objects ans will turn all
    // created objects green.
    //
    // Then you will clear the list...
    public List<GameObject> objectsCreated = new List<GameObject>();
    public GameObject object_01;
    public GameObject object_02;
    public GameObject object_03;
    private GameObject _randGOObject;
    private int _randGOIndex = 0;
    private int _gameObjectCount = 0;

    // Start is called before the first frame update
    void Start()
    {

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            for (int i = 0; i < 3; i++)
            {
                if (_gameObjectCount < 10)
                {
                    foreach (GameObject enemy in objectsCreated)
                    {
                        enemy.GetComponent<Renderer>().sharedMaterial.color = new Vector4(1, 1, 1, 1);
                    }
                    RandomIndexSelector();
                    objectsCreated.Add(_randGOObject);
                    float xPos = Random.Range(-10f, 10f);
                    float yPos = Random.Range(-10f, 10f);
                    GameObject newObject = Instantiate(objectsCreated[_gameObjectCount], new Vector3(xPos, yPos, 0), Quaternion.identity);
                    _gameObjectCount++;
                    Debug.Log("Game Object Count:" + _gameObjectCount);
                }else 

                {

                    foreach(GameObject enemy in objectsCreated)
                    {
                        enemy.GetComponent<Renderer>().sharedMaterial.color = new Vector4(0, 1, 0, 1);
                    }
                    objectsCreated.Clear();
                    Debug.Log("<color=green>  Everything is Green...!!!!</color>");
                    //break;

                }

            }

        }

    }


    public void RandomIndexSelector()
    {
        _randGOIndex = Random.Range(0, 3);

        switch (_randGOIndex)
        {
            case 0:
                _randGOObject = object_01;
                break;
            case 1:
                _randGOObject = object_02;
                break;
            case 2:
                _randGOObject = object_03;
                break;
        }
    }

}
