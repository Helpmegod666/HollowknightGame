﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemymovement : MonoBehaviour
{
    public bool canKnockback = true;
    public float moveSpeed = 2f;
    public bool isLeft = true;
    private Rigidbody2D rbody;
    public bool dead = false;
    public bool knockback = false;
    public float jumpForce;
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        Move(false);
    }


    void Update() 
    {
        if(canKnockback == true)
        {

            if (dead == true)
            {
                rbody.velocity = Vector2.zero;
            }
            if (dead == false && knockback == false)
            {
                rbody.velocity = new Vector2(moveSpeed, rbody.velocity.y);
            }
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
                moveSpeed = -moveSpeed;
                transform.localScale = new Vector3(1, 1, 1);
            }
            else // om inte
            {
                moveSpeed = -moveSpeed;
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
            if (collision.tag == "JumpWall")
            {
                rbody.velocity = new Vector2(moveSpeed, jumpForce);
            }
        }
       
    }

}
