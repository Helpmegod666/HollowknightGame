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
        if(self == null)
        {
            self = GetComponent<GameObject>();
        }
        
    }
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (dead == false)
        {
            if (collision.tag == "Attack")
            {

                canAttack = true;
                player.enemyHp = self.GetComponent<EnemyHealth>();
                
                
                player.enemyRbody = self.GetComponent<Rigidbody2D>();
                player.enemyMovement = self.GetComponent<Enemymovement>();
                player.smartEnemy = self.GetComponent<SmartEnemyMovement>();
                if (collision.tag == "Enemy")
                {
                    player.enemyMovement = null;
                    player.enemyRbody = null;
                }



                player.enemySprite = self.GetComponent<SpriteRenderer>();
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
