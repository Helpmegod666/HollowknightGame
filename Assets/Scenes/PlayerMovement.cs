using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float walkspeed = 5f;
    public float jumpspeed = 12f;
    private Vector3 lastMoveDir;

    public DashMovement dash;
    public GroundChecker groundcheck;
    public Hp_scipt playerHealth;

    private Rigidbody2D rbody;
    public float knockback;
    public float knockbackLength;
    public float knockbackCount;
    public bool knockFromRight;
    public bool canKnockback = true;
    public JumpFeedback feedback;

    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (dash.isDashing == false && knockbackCount <= 0)
        {
            rbody.velocity = new Vector2(
                Input.GetAxisRaw("Horizontal") * walkspeed,
                rbody.velocity.y);
            if (Input.GetButtonDown("Jump"))
            {

                if (groundcheck.isgrounded > 0)
                {
                    rbody.velocity = new Vector2(
                        rbody.velocity.x,
                        jumpspeed);
                    feedback.Shake(0.1f, 0.1f);
                }

            }
        }
        if (knockbackCount > 0) 
        {
            if(knockFromRight )
            {
                rbody.velocity = new Vector2(-knockback, knockback / 3);
            }
            if(!knockFromRight )
            {
                rbody.velocity = new Vector2(knockback, knockback / 3);
            }
            knockbackCount -= Time.deltaTime;
        }
    }


}

