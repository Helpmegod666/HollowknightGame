using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float walkspeed = 5f;
    private Vector3 lastMoveDir;
    public DashMovement dash;
    public GroundChecker groundcheck;
    private Rigidbody2D rbody;


    // Use this for initialization
    void Start()
    {
        // hämtar ut min RigiBody som jag vill använda eftersom att det finns flera olika och jag vill ha den jag använder
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (dash.isDashing == false)
        {
            //Min spelare rör sig till vänster eller höger om man trycker på A,D 
            rbody.velocity = new Vector2(
                Input.GetAxisRaw("Horizontal") * walkspeed,
                rbody.velocity.y);
           

        }
    }
}


