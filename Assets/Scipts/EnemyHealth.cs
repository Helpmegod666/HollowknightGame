using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    
    //public GameObject blood;
    public int Health = 1;
    public Hp_scipt playerHealth;
    SpriteRenderer rend;
    public Color deathColor;
    public Color standardColor;
    public EnemyDamageScript enemyDmg;
    public Enemymovement enemyMovement;
    public SmartEnemyMovement smartEnemy;
    SpriteRenderer sprite;
    public AttackScript attack;
    public Collider2D boxCollider;
    public bool dead;
    public bool groundEnemy = true;
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        enemyDmg = GetComponent<EnemyDamageScript>();
        enemyMovement = GetComponent<Enemymovement>();
        attack = GetComponent<AttackScript>();
        boxCollider = GetComponent<Collider2D>();
        sprite = GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (dead == false)
        {
            if (collision.gameObject.tag == "Player" && playerHealth.immunityframe == false)
            {
                var player = collision.gameObject.GetComponent<PlayerMovement>();
                player.knockbackCount = player.knockbackLength;
                if (collision.transform.position.x < transform.position.x)
                {
                    player.knockFromRight = true;
                }
                else
                {
                    player.knockFromRight = false;
                }
            }
        }
    }
    

    private void Update()
    {
       
           

            if (Health <= 0)
        {
            
            rend.color = deathColor;
            boxCollider.isTrigger = true;
            dead = true;
            enemyDmg.dead = true;
            if(groundEnemy == true && enemyMovement != null)
            {
                enemyMovement.dead = true;
                
            }
            if(groundEnemy == false && smartEnemy != null)
            {

                smartEnemy.dead = true;
            }
           

            //attack.dead = true;
            
            Invoke("Death", 2f);
        }
    }
    public void Death()
    {
        
        gameObject.SetActive(false);
    }
    public void RangedDamage()
    {
        Invoke("resetColor", 0.6f);
    }
    public void resetColor()
    {
        
        sprite.color = standardColor;
    }
}
