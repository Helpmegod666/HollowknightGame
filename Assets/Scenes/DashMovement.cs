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
    

    public bool isDashing = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        dashTime = startDashTime;
    }

    // Update is called once per frame
    void Update()
    {
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
            if (Input.GetKeyDown(KeyCode.LeftShift))
                isDashing = true;
        }
        else
        {
            // Dashen är färdig.
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
