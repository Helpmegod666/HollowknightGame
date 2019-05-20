using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashMovement : MonoBehaviour
{
    public AudioSource effect;
    [SerializeField]private Transform dashEffect;
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
            if (rb.velocity.x < 0)
            {
                direction = 1;
            }
            else if (rb.velocity.x > 0)
            {
                direction = 2;
            }
            if (Input.GetButtonDown("Fire3") && dashes >= 1)
            {
                effect.Play();
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
                    Vector3 beforeDashPosition = new Vector3(transform.position.x + 1, transform.position.y, transform.position.z);
                    rb.velocity = Vector2.left * dashSpeed;
                    hp.GetImmunity();
                    Instantiate(dashEffect, beforeDashPosition, Quaternion.identity);
                    float dashEffectWidth = 35f;
                    dashEffect.localScale = new Vector3(dashSpeed / dashEffectWidth, 1f, 1f);
                    
                    
                }
                else if (direction == 2)
                {
                    Vector3 beforeDashPosition = new Vector3(transform.position.x - 1, transform.position.y, transform.position.z);
                    rb.velocity = Vector2.right * dashSpeed;
                    hp.GetImmunity();
                    Instantiate(dashEffect, beforeDashPosition, Quaternion.identity);
                    float dashEffectWidth = 35f;
                    dashEffect.localScale = new Vector3(dashSpeed / dashEffectWidth, 1f, 1f);
                }
            }
        }

    }
    public void resetDash()
    {
        dashes = 1;
    }
}
