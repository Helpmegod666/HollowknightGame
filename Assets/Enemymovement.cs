using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemymovement : MonoBehaviour
{
    public float moveSpeed = 2f;
    public bool isLeft = true;
    private Rigidbody2D rbody;

    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        Move(false);
    }


    void Update() 
    {
        if (Input.GetKeyDown(KeyCode.H))
        { 
            Move(true);  
        }
    }

    void Move(bool flip)  
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

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.tag == "InvisibleWall") 
        {
            Move(true); 
        }
    }

}
