using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public AudioSource death;
    public AudioSource effect;
    public GameObject blood;
    SpriteRenderer selfSprite;
    public Transform playerPosition;
    SmartEnemyMovement smartEnemy;
    public Color baseColor;
    public Color damagedColor;
    SpriteRenderer enemySprite;
    Enemymovement enemyMovement;
    Vector2 previousMovement;
    Rigidbody2D enemyRbody;
    public float knockback;
    public float knockbackLength;
    public float knockbackCount;
    public float damagedLength;
    public bool knockFromRight;
    public bool canKnockback = true;
    public float speed = 20f;
    EnemyHealth enemy;
    Rigidbody2D rb;
    public RangedAttacksScript player;
    public PlayerMovement playerMovement;
    public GameObject playerObj;
    Transform enemyPosition;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Destroy", 5);
        playerObj = GameObject.FindGameObjectWithTag("RangedAttack");
        playerPosition = playerObj.GetComponent<Transform>();
        player = playerObj.GetComponent<RangedAttacksScript>();

        rb = GetComponent<Rigidbody2D>();
        selfSprite = GetComponent<SpriteRenderer>();
        if (player.shootRight == true)
        {
            rb.velocity = transform.right * speed;
        }
        if (player.shootLeft == true)
        {
            rb.velocity = transform.right * -speed;
        }
        if (player.shootUp == true)
        {
            rb.velocity = transform.right * speed;
        }
        if (player.shootDown == true)
        {
            rb.velocity = transform.right * speed;
        }

    }
    private void Update()
    {


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Groundenemy" || collision.tag == "Enemy")
        {
            //effect.Play();
            Instantiate(blood, transform.position, Quaternion.identity);
            enemy = collision.GetComponentInParent<EnemyHealth>();
            //enemy = collision.GetComponent<EnemyHealth>();
            enemySprite = collision.GetComponent<SpriteRenderer>();

            enemyRbody = collision.GetComponent<Rigidbody2D>();
            if (collision.gameObject.tag == "Groundenemy")
            {
                enemyMovement = collision.GetComponent<Enemymovement>();

            }
            if (collision.gameObject.tag == "Enemy")
            {
                smartEnemy = collision.GetComponent<SmartEnemyMovement>();
            }
            knockbackCount = knockbackLength;
            if (enemySprite != null)
                enemySprite.color = damagedColor;
            Invoke("resetColor", damagedLength);

            if (collision.transform.position.x < playerPosition.position.x)
            {
                knockFromRight = true;
            }
            else
            {
                knockFromRight = false;
            }
            if (knockbackCount > 0)
            {
                if (knockFromRight)
                {
                    if (enemyRbody != null)
                    {
                        previousMovement = new Vector2(enemyRbody.velocity.x, enemyRbody.velocity.y);
                        enemyRbody.velocity = new Vector2(-knockback, knockback / 3);
                    }



                }
                if (!knockFromRight)
                {
                    if (enemyRbody != null)
                    {
                        previousMovement = new Vector2(enemyRbody.velocity.x, enemyRbody.velocity.y);
                        enemyRbody.velocity = new Vector2(knockback, knockback / 3);

                    }

                }
                knockbackCount -= Time.deltaTime;
            }
            enemy.RangedDamage();

            if (enemy != null)
            {
                enemy.Health -= 1;
            }
            if(enemy.Health == 0)
            {
                death.Play();
            }

            Destroy(gameObject);





        }
        if (collision.tag == "Ground")
        {
            Destroy(gameObject);
        }





    }
    void resetRbody()
    {
        enemyRbody.velocity = previousMovement;
    }
    public void resetColor()
    {
        enemySprite.color = baseColor;

    }
    public void beginWalk()
    {
        enemyMovement.knockback = false;
    }
    public void Destroy()
    {
        Destroy(gameObject);
    }

}
