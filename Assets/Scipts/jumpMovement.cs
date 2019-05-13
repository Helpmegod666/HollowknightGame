using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpMovement : MonoBehaviour
{
    public AudioSource soundEffect;
    public float jumpForce;
    private float jumpTimeCounter;
    public float jumptime;
    private bool isJumping;
    private Rigidbody2D rbody;
    public float speed;
    private float moveInput;
    public bool isGrounded;
    public Transform feetpos;
    public float gravity;
    public float checkRadius;
    public LayerMask whatIsGround;
    //public JumpFeedback feedback;
    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    //private void FixedUpdate()
    //{
    //    moveInput = Input.GetAxisRaw("Horizontal");
    //    rbody.velocity = new Vector2(moveInput * speed, rbody.velocity.y);
    //}

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(feetpos.position, checkRadius, whatIsGround);

        if(isGrounded == true && Input.GetKeyDown(KeyCode.Space))
        {
            isJumping = true;
            jumpTimeCounter = jumptime; 
            
            rbody.velocity = Vector2.up * jumpForce;
            soundEffect.Play();
            //feedback.Shake(0.1f, 0.1f);
        }


        if (Input.GetKey(KeyCode.Space) && isJumping == true)
            if (jumpTimeCounter > 0)
            {
                rbody.velocity = new Vector2(rbody.velocity.x, rbody.velocity.y + jumpForce);
                jumpTimeCounter -= Time.deltaTime;
            }
            else
            {
                isJumping = false;
              
            }
        if (rbody.velocity.y < 0)
        {
            rbody.gravityScale = gravity;
        }
        if(rbody.velocity.y >= 0)
        {
            rbody.gravityScale = 2;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            isJumping = false;
        }
    }
 
}



    

