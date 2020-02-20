using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lists_Names : MonoBehaviour
{
    //challenge:Create a list of names and print each out.
    //When you hit the spacekey, "Remove a random elememt from the list and reprint the names.

    public List<string> randomNames = new List<string>();


    // Start is called before the first frame update
    void Start()
    {
        randomNames.Add("John");
        randomNames.Add("Bill");
        randomNames.Add("Sarah");
        randomNames.Add("Wilber");
        randomNames.Add("Noodles");

        for (int i = 0; i < randomNames.Count; i++)  //'i' is like an index variable.
        {
            Debug.Log(randomNames[i]);
        }

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("--------------------------------------------");

            //Debug.Log(randomNames[Random.Range(0, randomNames.Count)]);
            int _remove = Random.Range(0, randomNames.Count);
            if (randomNames.Count == 1)
            {
                Debug.Log(randomNames[0] + " is the Last name on the list..!!!!");
                Debug.Log("There are no other Survivors..!!!!");
            }
            else
            {
                randomNames.Remove(randomNames[_remove]);

                for (int i = 0; i < randomNames.Count; i++)  //'i' is like an index variable.
                {
                    Debug.Log(randomNames[i] + "------------------");
                    Debug.Log("index removed:" + _remove);
                    Debug.Log("New index count:" + i);
                    Debug.Log("new index number:" + randomNames.Count);

                }
            }
        }
    }
}
