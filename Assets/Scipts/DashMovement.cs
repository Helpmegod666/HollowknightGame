using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Hp_scipt hp;
    public float dashSpeed;
    private float dashTime;
    public float startDashTime;
    private int direction;
    public int dashes = 1;
    public float dashCooldown;
    //public JumpFeedback feedback;

    public jumpMovement groundCheck;

    public bool isDashing = false;

    void Start()
    {
        hp = GetComponent<Hp_scipt>();
        rb = GetComponent<Rigidbody2D>();
        dashTime = startDashTime;
        dashes = 1;
    }

    void Update()
    {
        if (groundCheck.isGrounded == true && dashes == 0)
        {
            InvokeRepeating("resetDash", dashCooldown, dashCooldown);
        }
        if(dashes == 1)
        {
            CancelInvoke("resetDash");
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

        }
        else
        {
            if (dashTime <= 0)
            {
                //direction = 0;
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
                    hp.GetImmunity();

                }
                else if (direction == 2)
                {
                    rb.velocity = Vector2.right * dashSpeed;
                    hp.GetImmunity();

                }
            }
        }

    }
    public void resetDash()
    {
        dashes = 1;
    }
}
