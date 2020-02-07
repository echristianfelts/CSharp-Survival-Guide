using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FvM_PositionMattersChallenge_Corrected : MonoBehaviour
{

    public Vector3[] positions;
    private int _randomIndex;

    // Start is called before the first frame update
    void Start()
    {
        _randomIndex = GetRandom();

        Debug.Log("Random Index: " + _randomIndex);

        transform.position = GetPosition(_randomIndex);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int GetRandom()
    {
        return Random.Range(0, positions.Length);
    }

    Vector3 GetPosition(int index)
    {
        return positions[index];
    }

}
