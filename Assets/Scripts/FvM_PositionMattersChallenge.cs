using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FvM_PositionMattersChallenge : MonoBehaviour
{
    //Create an array of 5 different positions 

    public Vector3[] pos = new Vector3[5];
    public GameObject[] gameObjectObject = new GameObject[5];
    //and uses a custom method to generate a random index,

    //then use a custom methodto set the position to that subindex...
    //

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))

        {
            for (int i = 0; i < pos.Length; i++)
            {
                if (gameObjectObject[i] == null)
                {
                    gameObjectObject[i] = GameObject.CreatePrimitive(PrimitiveType.Cube);

                }

                PutThingInRandomPlace(i);

                gameObjectObject[i].GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
                gameObjectObject[i].transform.position = pos[i];

            }
        }
    }

    public Vector3 GetPosition()
    {
        return new Vector3(Random.Range(-5,5), Random.Range(-5, 5), Random.Range(-5, 5));
    }

    void PutThingInRandomPlace(int x)
    {
        pos[x] = GetPosition();
    }
}
