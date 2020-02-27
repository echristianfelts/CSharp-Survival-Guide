using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Dictionary_Player
{
    public string name;
    public int id;

    public Dictionary_Player(int id)
    {
        this.id = id;
    }
}


public class Dictionary_Intro_Player : MonoBehaviour
{
    public Dictionary<int, Dictionary_Player> playerDictionary = new Dictionary<int, Dictionary_Player>();

    Dictionary_Player p4;

    // Start is called before the first frame update
    void Start()
    {
        Dictionary_Player p1 = new Dictionary_Player(1);
        p1.name = "Jimmy";
        Dictionary_Player p2 = new Dictionary_Player(200);
        p2.name = "Kyle";
        Dictionary_Player p3 = new Dictionary_Player(30);
        p3.name = "Yin";
        p4 = new Dictionary_Player(45);
        p4.name = "Bilbo";

        playerDictionary.Add(p1.id, p1);
        playerDictionary.Add(p2.id, p2);
        playerDictionary.Add(p3.id, p3);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var player = playerDictionary[200];
            Debug.Log("Player name: " + player.name);

        }
        
    }
}
