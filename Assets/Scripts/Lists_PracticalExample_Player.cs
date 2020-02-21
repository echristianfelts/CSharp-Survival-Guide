using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lists_PracticalExample_Player : MonoBehaviour
{


    public Lists_PracticalExample_Item[] inventory = new Lists_PracticalExample_Item[10];

    private Lists_PracticalExample_Database _itemDatabase;

    // Start is called before the first frame update
    void Start()
    {
        _itemDatabase = GameObject.Find("Main Camera").GetComponent<Lists_PracticalExample_Database>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _itemDatabase.AddItem(4, this);
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
           _itemDatabase.RemoveItem(4, this);
        }
    }
}
