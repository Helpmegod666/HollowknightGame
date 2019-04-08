using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmartEnemyMovement : MonoBehaviour
{
    public bool canKnockback = true;
    public float previousMoveSpeed;
    public Transform Player;
    public float moveSpeed = 2f;
    public float speed = 2f;
    public bool isLeft = true;
    private Rigidbody2D rbody;
    public EnemySense area;
    public bool dead = false;
    public bool knockback = false;
    public float jumpForce;
    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        Move(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(rbody.velocity.x < 5)
        {
            isLeft = true;
        }
        if(rbody.velocity.x >= 5)
        {
            isLeft = false;
        }
        if (canKnockback == true)
        {
            if (dead == true)
            {
                rbody.velocity = Vector2.zero;
            }
            if (dead == false && knockback == false && area.Area == false)
            {
                rbody.velocity = new Vector2(moveSpeed, rbody.velocity.y);
            }
        }
        if (dead == false && area.Area == true)
        {
            

            rbody.velocity = Vector2.zero;
            Vector3 displacement = Player.position - transform.position;
            displacement = displacement.normalized;
            if (Vector2.Distance(Player.position, transform.position) > 1.0f)
            {
                transform.position += (displacement * speed * Time.deltaTime);
            }
        }
    }
    public void Move(bool flip)
    {
        if (dead == false)
        {
            if (flip == true)
            {
                isLeft = !isLeft;
            }

            if (isLeft == true && area.Area == false)
            {
                moveSpeed = -moveSpeed;
                transform.localScale = new Vector3(1, 1, 1);
            }
            if (isLeft == false && area.Area == false) // om inte
            {
                moveSpeed = -moveSpeed;
                transform.localScale = new Vector3(-1, 1, 1);
            }
        }

    }
 
}
