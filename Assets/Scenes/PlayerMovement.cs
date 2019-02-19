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

    // Use this for initialization
    void Start()
    {
        // hämtar ut min RigiBody som jag vill använda eftersom att det finns flera olika och jag vill ha den jag använder
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (dash.isDashing == false && knockbackCount <= 0)
        {
            //Min spelare rör sig till vänster eller höger om man trycker på A,D 
            rbody.velocity = new Vector2(
                Input.GetAxisRaw("Horizontal") * walkspeed,
                rbody.velocity.y);
            // OM jag trycker på min jump knapp vilket är "Space" så hoppar jag 
            if (Input.GetButtonDown("Jump"))
            {

                if (groundcheck.isgrounded > 0)
                {
                    // Denna kod gör så att min spelare hoppar när man trycker på hopp knappen 
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

