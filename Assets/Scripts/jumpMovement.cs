using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpMovement : MonoBehaviour
{
    public float jumpForce;
    private float jumpTimeCounter;
    public float jumptime;
    private bool isJumping;
    private Rigidbody2D rbody;
    public float speed;
    private float moveInput;
    private bool isGrounded;
    public Transform feetpos;
    public float checkRadius;
    public LayerMask whatIsGround; 
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
        }


        if (Input.GetKey(KeyCode.Space) && isJumping == true)
            if (jumpTimeCounter > 0)
            {
                rbody.velocity = Vector2.up * jumpForce;
                jumpTimeCounter -= Time.deltaTime;
            }
            else
            {
                isJumping = false;
            }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            isJumping = false;
        }
    }
}



    

