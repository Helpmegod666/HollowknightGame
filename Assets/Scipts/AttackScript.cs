using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScript : MonoBehaviour
{
    public static bool canAttack;
    public PlayerAttackScript player;
    
    public GameObject self;
    public bool dead = false;

    void Start()
    {
        self = GetComponent<GameObject>();
    }
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (dead == false)
        {
            if (collision.tag == "Attack")
            {

                canAttack = true;
                player.enemyHp = GetComponent<EnemyHealth>();
                
                
                player.enemyRbody = GetComponent<Rigidbody2D>();
                player.enemyMovement = GetComponent<Enemymovement>();
                player.smartEnemy = GetComponent<SmartEnemyMovement>();
                if (collision.tag == "Enemy")
                {
                    player.enemyMovement = null;
                    player.enemyRbody = null;
                }



                player.enemySprite = GetComponent<SpriteRenderer>();
                if (collision.transform.position.x < transform.position.x)
                {
                    player.knockFromRight = false;
                }
                else
                {
                    player.knockFromRight = true;
                }

            }
        }
        
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (dead == false)
        {
            if (collision.tag == "Attack")
            {
                canAttack = false;
               
                
            }
        }
        
    }
}
