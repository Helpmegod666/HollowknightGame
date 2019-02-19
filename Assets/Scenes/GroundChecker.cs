using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    public int isgrounded;




    public JumpFeedback feedback;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            isgrounded = isgrounded + 1;
            feedback.Shake(0.1f,0.1f);
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            isgrounded = isgrounded - 1;
        }
    }

    private void Update()
    {

    }
}
