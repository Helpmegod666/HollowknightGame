using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public int Health = 1;
    public Hp_scipt playerHealth;
    SpriteRenderer rend;
    public Color deathColor;
    public EnemyDamageScript enemyDmg;
    public Enemymovement enemyMovement;
    public AttackScript attack;
    public bool dead;
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        enemyDmg = GetComponent<EnemyDamageScript>();
        enemyMovement = GetComponent<Enemymovement>();
        attack = GetComponent<AttackScript>();
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
        if (Health == 0)
        {
            rend.color = deathColor;
            dead = true;
            enemyDmg.dead = true;
            enemyMovement.dead = true;
            attack.dead = true;
            Invoke("Death", 2f);
        }
    }
    public void Death()
    {
        gameObject.SetActive(false);
    }
}
