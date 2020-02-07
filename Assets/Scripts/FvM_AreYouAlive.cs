using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FvM_AreYouAlive : MonoBehaviour
{
    //  Create a program that checke to see if the player is dead or not. When you hit the space-key, you should damage 
    //  the player by a random amount.  If the player is dead (health less than 1...), print out "The Player has died..."
    private int _playerHealth = 100;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Player Health :"+ _playerHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerDamage();
            if (_playerHealth < 1)
            {
                _playerHealth = 0;
                Debug.Log("The Player has Died..!!!");
                Debug.Log("Player Health :" + _playerHealth);
            } else
            {
                Debug.Log("Player Health :" + _playerHealth);
            }

        }
    }

    private void PlayerDamage()
    {
        _playerHealth -= Random.Range(1, 6);
    }
}
