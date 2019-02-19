using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float dashSpeed;
    private float dashTime;
    public float startDashTime;
    private int direction;
    public int dashes;

    public GroundChecker Groundcheck;

    public bool isDashing = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        dashTime = startDashTime;
    }

    void Update()
    {
        if (Groundcheck.isgrounded >= 1)
        {
            dashes = 1;
        }

        if (isDashing == false)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                direction = 1;
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                direction = 2;
            }
            if (Input.GetKeyDown(KeyCode.LeftShift) && dashes >= 1)
            {
                isDashing = true;
                dashes = 0;
            }

            print(dashes);
        }
        else
        {
            if (dashTime <= 0)
            {
                direction = 0;
                dashTime = startDashTime;
                rb.velocity = Vector2.zero;
                isDashing = false;
            }
            else
            {
                dashTime -= Time.deltaTime;
                if (direction == 1)
                {
                    rb.velocity = Vector2.left * dashSpeed;
                }
                else if (direction == 2)
                {
                    rb.velocity = Vector2.right * dashSpeed;
                }
            }
        }
    }
}
