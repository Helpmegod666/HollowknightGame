using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScript : MonoBehaviour
{
    public static bool canAttack;
    public PlayerAttackScript player;
    public GameObject self;

    void Start()
    {
        //self = GetComponent<GameObject>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Attack")
        {
            
            canAttack = true;
            player.enemyToAttack = self;
            
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Attack")
        {
            canAttack = false;
            player.enemyToAttack = null;
        }
    }
    void Update()
    {
        
    }
}
