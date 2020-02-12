using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Static_PE_Enemy : MonoBehaviour
{
    private Static_PE_UIManager _ui;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnEnable()
    {
        Static_PE_SpawnManager.enemyCount ++;
        _ui = GameObject.Find("UIManager").GetComponent<Static_PE_UIManager>();
        _ui.UpdateEnemyCount();
        Die();
    }


    public void OnDisable()
    {

        Static_PE_SpawnManager.enemyCount--;
        _ui.UpdateEnemyCount();
    }

    void Die()
    {
        Destroy(this.gameObject,Random.Range(2,6));
    }
}
