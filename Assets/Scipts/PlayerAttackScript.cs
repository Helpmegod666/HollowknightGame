using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackScript : MonoBehaviour
{
    public AudioSource effect;
    public AudioSource enemyDeath;
    public GameObject blood;
    public Rigidbody2D enemyRbody;
    public float knockback;
    public float knockbackLength;
    public float knockbackCount;
    public float damagedLength;
    public bool knockFromRight;
    public bool canKnockback = true;
    public JumpFeedback feedback;
    Vector2 previousMovement;
    public Color baseColor;
    public Color damagedColor;
    public SpriteRenderer player;
    public Transform attackHitbox;
    public EnemyHealth enemyHp;
    public SpriteRenderer enemySprite;
    public Enemymovement enemyMovement;
    public SmartEnemyMovement smartEnemy;

    public bool invincibilityFrame = false;


    private void Start()
    {


    }
    void Update()
    {

        if (AttackScript.canAttack == true && Input.GetButtonDown("Fire1") && invincibilityFrame == false && enemyHp != null)
        {
            invincibilityFrame = true;
            effect.Play();
            Instantiate(blood, transform.position, Quaternion.identity);
            enemyHp.Health -= 1;
            if (enemyHp.Health == 0)
            {
                //enemyDeath.Play();
            }
            knockbackCount = knockbackLength;
            enemySprite.color = damagedColor;
            if (enemyHp.groundEnemy == true && enemyMovement != null)
            {
                enemyMovement.knockback = true;

            }
            if (enemyHp.groundEnemy == false && smartEnemy != null)
            {
                smartEnemy.knockback = true;
            }

            
            Invoke("resetInvincibilityFrame", 1f);
            if (knockbackCount > 0)
            {
                if (knockFromRight)
                {
                    previousMovement = new Vector2(enemyRbody.velocity.x, enemyRbody.velocity.y);
                    
                    enemyRbody.velocity = new Vector2(-knockback, knockback / 3);


                }
                if (!knockFromRight)
                {
                    previousMovement = new Vector2(enemyRbody.velocity.x, enemyRbody.velocity.y);
                    enemyRbody.velocity = new Vector2(knockback, knockback / 3);

                }
                knockbackCount -= Time.deltaTime;
            }

            Invoke("resetRbody", damagedLength);
            Invoke("resetColor", damagedLength);
            Invoke("beginWalk", damagedLength);
        }
        if (Input.GetAxis("Vertical2") > 0)
        {
            attackHitbox.localPosition = new Vector3(0, 0.7f);
        }
        if (Input.GetAxis("Vertical2") < 0)
        {
            attackHitbox.localPosition = new Vector3(0, -0.9f);
        }
        if (Input.GetAxis("Horizontal2") > 0)
        {
            attackHitbox.localPosition = new Vector3(1, 0);
        }
        if (Input.GetAxis("Horizontal2") < 0)
        {
            attackHitbox.localPosition = new Vector3(-1, 0);
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
        if (enemyMovement != null)
            enemyMovement.knockback = false;
    }
    public void resetInvincibilityFrame()
    {
        invincibilityFrame = false;
    }

}
