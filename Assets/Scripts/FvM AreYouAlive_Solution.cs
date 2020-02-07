using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FvMAreYouAlive_Solution : MonoBehaviour
{

    public int health = 100;


    // Start is called before the first frame update
    void Start()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsDead()== false)
        {
            Damage(Random.Range(5,10));
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Damage(int damageAmount)
    {
        health -= damageAmount;

        if (IsDead())
        {
            health = 0;
            Debug.Log("The player has died..!!!");

        }

    }

    public bool IsDead()
    {
        return health < 1;
    }
}
