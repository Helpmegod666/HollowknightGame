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

    private Rigidbody2D rbody;

    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (dash.isDashing == false)
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
                }

            }
        }
    }
}

