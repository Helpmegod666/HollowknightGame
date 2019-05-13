using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableEnemyGun : MonoBehaviour
{
    EnemyHealth enemyHp;
    Spitenemy enemy;
    // Start is called before the first frame update
    void Start()
    {
        enemyHp = GetComponent<EnemyHealth>();
        enemy = GetComponent<Spitenemy>();
    }

    // Update is called once per frame
    void Update()
    {
        if(enemyHp.Health <= 0)
        {
            enemy.shootinterval = 1000;
        }
    }
}
