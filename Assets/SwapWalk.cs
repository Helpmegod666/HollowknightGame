using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapWalk : MonoBehaviour
{
    public SmartEnemyMovement movement;
    public EnemySense area;
    public Rigidbody2D rbody;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (movement.dead == false)
        {
            if (collision.tag == "InvisibleWall" && area.Area == false)
            {
                movement.Move(true);
            }
            if (collision.tag == "JumpWall")
            {
                rbody.velocity = new Vector2(movement.moveSpeed, movement.jumpForce);
            }
        }

    }
}
