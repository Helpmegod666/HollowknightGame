using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    EnemyHealth enemy;
    public Rigidbody2D rb;
    public RangedAttacksScript player;
    public GameObject playerObj;
    // Start is called before the first frame update
    void Start()
    {
        playerObj = GameObject.FindGameObjectWithTag("Attack");
        player = playerObj.GetComponent<RangedAttacksScript>();
        rb = GetComponent<Rigidbody2D>();
     
        if(player.shootRight == true)
        {
            rb.velocity = transform.right * speed;
        }
        if (player.shootLeft == true)
        {
            rb.velocity = transform.right * -speed;
        }
        if (player.shootUp == true)
        {
            rb.velocity = transform.up * speed;
        }
        if (player.shootDown == true)
        {
            rb.velocity = transform.up * -speed;
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Groundenemy" || collision.tag == "Enemy")
        {
            enemy = collision.GetComponent<EnemyHealth>();
            enemy.Health -= 1;
            Destroy(gameObject);
        }
        if(collision.tag == "Ground")
        {
            Destroy(gameObject);
        }
        
        
        
    }

}
