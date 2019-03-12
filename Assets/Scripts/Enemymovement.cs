using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemymovement : MonoBehaviour
{
    public float moveSpeed = 2f;
    public bool isLeft = true;
    private Rigidbody2D rbody;
    public bool dead = false;
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        Move(false);
    }


    void Update() 
    {
        if(dead == false)
        {
            if (Input.GetKeyDown(KeyCode.H))
            {
                Move(true);
            }
        }
        if(dead == true)
        {
            rbody.velocity = Vector2.zero;
        }
        
    }

    void Move(bool flip)  
    {
        if(dead == false)
        {
            if (flip == true)
            {
                isLeft = !isLeft;
            }

            if (isLeft == true)
            {
                rbody.velocity = new Vector2(-moveSpeed, rbody.velocity.y);
                transform.localScale = new Vector3(1, 1, 1);
            }
            else // om inte
            {
                rbody.velocity = new Vector2(moveSpeed, rbody.velocity.y);
                transform.localScale = new Vector3(-1, 1, 1);
            }
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if(dead == false)
        {
            if (collision.tag == "InvisibleWall")
            {
                Move(true);
            }
        }
       
    }

}
